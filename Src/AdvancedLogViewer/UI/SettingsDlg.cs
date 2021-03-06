﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdvancedLogViewer.BL;
using Scarfsail.Common.UI;
using Scarfsail.Common.UI.Controls;
using AdvancedLogViewer.BL.Settings;
using System.Diagnostics;
using AdvancedLogViewer.BL.FindText;
using AdvancedLogViewer.BL.LogBrowser;
using Scarfsail.Common.BL;
using System.Reflection;

namespace AdvancedLogViewer.UI
{
    public partial class SettingsDlg : Form
    {
        AlvSettings settings;
        TotalCmdIntegration totalCmd;
        LogBrowserSettings logBrowser;
        bool alvWasAssociated;
        private static Scarfsail.Logging.Log log = new Scarfsail.Logging.Log();

        public SettingsDlg(AlvSettings alvSettings, bool firstTimeShown)
        {
            log.Debug("Creating SettingsDlg form");

            InitializeComponent();
            this.settings = alvSettings;
            this.totalCmd = new TotalCmdIntegration();
            this.logBrowser = LogBrowserSettings.Instance;


            //Load values from filter entry
            this.showMarkersCheckBox.Checked = this.settings.MainFormUI.ShowMarkers;
            this.exitAppOnESCCheckBox.Checked = this.settings.MainFormUI.ExitAppOnESC;
            this.autoScrollCheckBox.Checked = this.settings.MainFormUI.AutoScrollWhenAutoRefresh;
            this.autoScrollShowTwoItemsCheckBox.Checked = this.settings.MainFormUI.AutoScrollShowTwoItems;
            this.autoRefreshPeriodEdit.Value = this.settings.MainFormUI.AutoRefreshPeriod;
            this.addOnlyBaseNameInRecentListCheckBox.Checked = this.settings.MainFormUI.AddOnlyBaseNameInRecentList;
            this.rememberFiltersEnabledCheckBox.Checked = this.settings.MainFormUI.RememberFiltersEnabled;
            this.trimClassColumnFromLeftCheckBox.Checked = this.settings.MainFormUI.TrimClassColumnFromLeft;
            this.showLogIconsCheckBox.Checked = this.settings.MainFormUI.ShowLogIcons;

            this.extDiffPathEdit.Text = settings.TextDiff.DiffPath;
            this.extDiffParametersEdit.Text = settings.TextDiff.DiffParameters;

            this.extTextEditPathEdit.Text = settings.TextEditor.TextEditorPath;
            this.extTextEditParametersEdit.Text = settings.TextEditor.TextEditorParameteres;

            this.topLevelFolders.Text = this.logBrowser.TopLevelFolders;
            this.openAndExitOnDoubleClickCheckBox.Checked = this.logBrowser.ShowAndCloseOnDoubleClick;

            this.integrateWithTotalCmdCheckBox.Checked = this.totalCmd.IsLogViewerIntegrated;
            if (this.totalCmd.IsInstalled)
            {
                this.integrateWithTotalCmdCheckBox.Enabled = true;
                this.totalCmdStatusLabel.Text = "Total Commander is installed on this computer.";
            }
            else
            {
                this.integrateWithTotalCmdCheckBox.Enabled = false;
                this.totalCmdStatusLabel.Text = "Total Commander wasn't found on this computer.";
            }

            try
            {
                alvWasAssociated = FileAssociation.IsAssociated(".log", "AdvancedLogViewer");
                associateWithAlvCheckBox.Checked = alvWasAssociated || firstTimeShown;               
            }
            catch
            {
                MessageBox.Show("Can't get information about associated application with LOG extension. Run ALV as Administrator.", "Administration rights required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                associateWithAlvCheckBox.Enabled = false;
            }
            this.automaticUpdateEnabledCheckBox.Checked = this.settings.AutomaticUpdates.EnableAutomaticCheck;
            this.automaticUpdateCheckPeriodEdit.Value = this.settings.AutomaticUpdates.CheckInterval;

            log.Debug("SettingsDlg form created");
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            log.Debug("Saving data...");

            //Save values from UI
            this.settings.MainFormUI.ShowMarkers = this.showMarkersCheckBox.Checked;
            this.settings.MainFormUI.ExitAppOnESC = this.exitAppOnESCCheckBox.Checked;
            this.settings.MainFormUI.AutoScrollWhenAutoRefresh = this.autoScrollCheckBox.Checked;
            this.settings.MainFormUI.AutoScrollShowTwoItems = this.autoScrollShowTwoItemsCheckBox.Checked;
            this.settings.MainFormUI.AutoRefreshPeriod = Convert.ToInt32(this.autoRefreshPeriodEdit.Value);
            this.settings.MainFormUI.AddOnlyBaseNameInRecentList = this.addOnlyBaseNameInRecentListCheckBox.Checked;
            this.settings.MainFormUI.RememberFiltersEnabled = this.rememberFiltersEnabledCheckBox.Checked;
            this.settings.MainFormUI.TrimClassColumnFromLeft = this.trimClassColumnFromLeftCheckBox.Checked;
            this.settings.MainFormUI.ShowLogIcons = this.showLogIconsCheckBox.Checked;

            this.settings.TextDiff.DiffPath = this.extDiffPathEdit.Text;
            this.settings.TextDiff.DiffParameters = this.extDiffParametersEdit.Text;

            this.settings.TextEditor.TextEditorPath = this.extTextEditPathEdit.Text;
            this.settings.TextEditor.TextEditorParameteres = this.extTextEditParametersEdit.Text;

            this.settings.AutomaticUpdates.EnableAutomaticCheck = this.automaticUpdateEnabledCheckBox.Checked;
            this.settings.AutomaticUpdates.CheckInterval = Convert.ToInt32(this.automaticUpdateCheckPeriodEdit.Value);

            this.settings.Save();

            //Browse for logs around
            this.logBrowser.TopLevelFolders = this.topLevelFolders.Text;
            this.logBrowser.ShowAndCloseOnDoubleClick = this.openAndExitOnDoubleClickCheckBox.Checked;
            this.logBrowser.Save();

            log.Debug("Data saved...");

            if (this.totalCmd.IsInstalled && this.totalCmd.IsLogViewerIntegrated != this.integrateWithTotalCmdCheckBox.Checked)
            {
                log.Debug("Saving TotalCmd settings");
                log.Debug("Checking if TotalCmd is running...");
                bool totalCmdRunning = false;

                while (Process.GetProcessesByName("TOTALCMD").Where(p => p.MainModule.ModuleName.Equals("TOTALCMD.EXE", StringComparison.OrdinalIgnoreCase)).Count() > 0)
                {
                    if (MessageBox.Show("Total Commander is running, please close it and then click on Retry. Isn't possible to save Total Commander configuration when is running.", "Total Commander", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) != DialogResult.Retry)
                    {
                        totalCmdRunning = true;
                        break;
                    }
                }
                if (!totalCmdRunning)
                {
                    if (this.integrateWithTotalCmdCheckBox.Checked)
                        this.totalCmd.IntegrateLogViewer();
                    else
                        this.totalCmd.UnIntegrateLogViewer();
                    log.Debug("TotalCmd settigns saved");
                }
                else
                {
                    MessageBox.Show("Total Commander configuration wasn't saved because Total Commander is running. Rest of the configuration was saved successfuly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    log.Debug("TotalCmd isn't saved because Total Commander is running");
                }
            }
            if (this.associateWithAlvCheckBox.Enabled && this.associateWithAlvCheckBox.Checked != alvWasAssociated)
            {

                try
                {
                    string executable = Assembly.GetExecutingAssembly().Location;
                    if (this.associateWithAlvCheckBox.Checked)
                        FileAssociation.Associate(".log", "AdvancedLogViewer", "Log file", executable, 0, executable);
                    else
                        FileAssociation.Remove(".log", "AdvancedLogViewer");
                }
                catch
                {
                    MessageBox.Show("Can'setassociation for the LOG extension. Run ALV as Administrator.", "Administration rights required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void extDiffBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.FileName = this.extDiffPathEdit.Text;
                dlg.Title = "Select external diff tool executable";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this.extDiffPathEdit.Text = dlg.FileName;
                }
            }
        }

        private void extTextEditBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.FileName = this.extTextEditPathEdit.Text;
                dlg.Title = "Select external text editor executable";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this.extTextEditPathEdit.Text = dlg.FileName;
                }
            }

        }

    }
}
