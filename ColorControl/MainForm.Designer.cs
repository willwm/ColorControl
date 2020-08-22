﻿namespace ColorControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabNVIDIA = new System.Windows.Forms.TabPage();
            this.btnAddModesNv = new System.Windows.Forms.Button();
            this.btnNvPresetDelete = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnSetShortcut = new System.Windows.Forms.Button();
            this.lblShortcut = new System.Windows.Forms.Label();
            this.edtShortcut = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.mnuNvPresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miNvApply = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNvDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPrimaryDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNvPresetsColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefreshRateIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetDithering = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetApplyDithering = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetDitheringEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvHDR = new System.Windows.Forms.ToolStripMenuItem();
            this.miHDRIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.miToggleHDR = new System.Windows.Forms.ToolStripMenuItem();
            this.miHDREnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.lvNvPresets = new System.Windows.Forms.ListView();
            this.tabLG = new System.Windows.Forms.TabPage();
            this.btnLgAddButton = new System.Windows.Forms.Button();
            this.mnuLgButtons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLgDevices = new System.Windows.Forms.ComboBox();
            this.btnLgRefreshApps = new System.Windows.Forms.Button();
            this.btnAddLg = new System.Windows.Forms.Button();
            this.btnDeleteLg = new System.Windows.Forms.Button();
            this.cbxLgApps = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtLgTvName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtNameLg = new System.Windows.Forms.TextBox();
            this.edtStepsLg = new System.Windows.Forms.TextBox();
            this.lblStepsLg = new System.Windows.Forms.Label();
            this.lblLgError = new System.Windows.Forms.Label();
            this.btnCloneLg = new System.Windows.Forms.Button();
            this.btnSetShortcutLg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtShortcutLg = new System.Windows.Forms.TextBox();
            this.btnApplyLg = new System.Windows.Forms.Button();
            this.lvLgPresets = new System.Windows.Forms.ListView();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtDelayDisplaySettings = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkStartAfterLogin = new System.Windows.Forms.CheckBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.edtLog = new System.Windows.Forms.TextBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.grpNVIDIAInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshNVIDIAInfo = new System.Windows.Forms.Button();
            this.tvNVIDIAInfo = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tabNVIDIA.SuspendLayout();
            this.mnuNvPresets.SuspendLayout();
            this.tabLG.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDelayDisplaySettings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.grpNVIDIAInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabNVIDIA);
            this.tcMain.Controls.Add(this.tabLG);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabInfo);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(849, 532);
            this.tcMain.TabIndex = 3;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNVIDIA
            // 
            this.tabNVIDIA.Controls.Add(this.btnAddModesNv);
            this.tabNVIDIA.Controls.Add(this.btnNvPresetDelete);
            this.tabNVIDIA.Controls.Add(this.lblError);
            this.tabNVIDIA.Controls.Add(this.btnClone);
            this.tabNVIDIA.Controls.Add(this.btnSetShortcut);
            this.tabNVIDIA.Controls.Add(this.lblShortcut);
            this.tabNVIDIA.Controls.Add(this.edtShortcut);
            this.tabNVIDIA.Controls.Add(this.btnChange);
            this.tabNVIDIA.Controls.Add(this.btnApply);
            this.tabNVIDIA.Controls.Add(this.lvNvPresets);
            this.tabNVIDIA.Location = new System.Drawing.Point(4, 22);
            this.tabNVIDIA.Name = "tabNVIDIA";
            this.tabNVIDIA.Padding = new System.Windows.Forms.Padding(3);
            this.tabNVIDIA.Size = new System.Drawing.Size(841, 506);
            this.tabNVIDIA.TabIndex = 0;
            this.tabNVIDIA.Text = "NVIDIA controller";
            this.tabNVIDIA.UseVisualStyleBackColor = true;
            // 
            // btnAddModesNv
            // 
            this.btnAddModesNv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddModesNv.Location = new System.Drawing.Point(574, 477);
            this.btnAddModesNv.Name = "btnAddModesNv";
            this.btnAddModesNv.Size = new System.Drawing.Size(75, 23);
            this.btnAddModesNv.TabIndex = 9;
            this.btnAddModesNv.Text = "Add modes";
            this.btnAddModesNv.UseVisualStyleBackColor = true;
            this.btnAddModesNv.Click += new System.EventHandler(this.btnAddModesNv_Click);
            // 
            // btnNvPresetDelete
            // 
            this.btnNvPresetDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNvPresetDelete.Enabled = false;
            this.btnNvPresetDelete.Location = new System.Drawing.Point(493, 477);
            this.btnNvPresetDelete.Name = "btnNvPresetDelete";
            this.btnNvPresetDelete.Size = new System.Drawing.Size(75, 23);
            this.btnNvPresetDelete.TabIndex = 8;
            this.btnNvPresetDelete.Text = "Delete";
            this.btnNvPresetDelete.UseVisualStyleBackColor = true;
            this.btnNvPresetDelete.Click += new System.EventHandler(this.btnNvPresetDelete_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(6, 6);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(50, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "ErrorText";
            this.lblError.Visible = false;
            // 
            // btnClone
            // 
            this.btnClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClone.Enabled = false;
            this.btnClone.Location = new System.Drawing.Point(412, 477);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 6;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnSetShortcut
            // 
            this.btnSetShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetShortcut.Enabled = false;
            this.btnSetShortcut.Location = new System.Drawing.Point(372, 477);
            this.btnSetShortcut.Name = "btnSetShortcut";
            this.btnSetShortcut.Size = new System.Drawing.Size(34, 23);
            this.btnSetShortcut.TabIndex = 5;
            this.btnSetShortcut.Text = "Set";
            this.btnSetShortcut.UseVisualStyleBackColor = true;
            this.btnSetShortcut.Click += new System.EventHandler(this.btnSetShortcut_Click);
            // 
            // lblShortcut
            // 
            this.lblShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(168, 482);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(50, 13);
            this.lblShortcut.TabIndex = 4;
            this.lblShortcut.Text = "Shortcut:";
            // 
            // edtShortcut
            // 
            this.edtShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShortcut.Enabled = false;
            this.edtShortcut.Location = new System.Drawing.Point(224, 479);
            this.edtShortcut.Name = "edtShortcut";
            this.edtShortcut.ReadOnly = true;
            this.edtShortcut.Size = new System.Drawing.Size(142, 20);
            this.edtShortcut.TabIndex = 3;
            this.edtShortcut.TextChanged += new System.EventHandler(this.edtShortcut_TextChanged);
            this.edtShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyUp);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChange.ContextMenuStrip = this.mnuNvPresets;
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(87, 477);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // mnuNvPresets
            // 
            this.mnuNvPresets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuNvPresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvApply,
            this.toolStripSeparator1,
            this.mnuNvDisplay,
            this.mnuNvPresetsColorSettings,
            this.mnuRefreshRate,
            this.miNvPresetDithering,
            this.miNvHDR});
            this.mnuNvPresets.Name = "mnuNvPresets";
            this.mnuNvPresets.Size = new System.Drawing.Size(148, 142);
            this.mnuNvPresets.Opening += new System.ComponentModel.CancelEventHandler(this.mnuNvPresets_Opening);
            // 
            // miNvApply
            // 
            this.miNvApply.Name = "miNvApply";
            this.miNvApply.Size = new System.Drawing.Size(147, 22);
            this.miNvApply.Text = "Apply";
            this.miNvApply.Click += new System.EventHandler(this.miNvApply_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // mnuNvDisplay
            // 
            this.mnuNvDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPrimaryDisplay});
            this.mnuNvDisplay.Name = "mnuNvDisplay";
            this.mnuNvDisplay.Size = new System.Drawing.Size(147, 22);
            this.mnuNvDisplay.Text = "Display";
            // 
            // miNvPrimaryDisplay
            // 
            this.miNvPrimaryDisplay.Name = "miNvPrimaryDisplay";
            this.miNvPrimaryDisplay.Size = new System.Drawing.Size(155, 22);
            this.miNvPrimaryDisplay.Text = "Primary display";
            this.miNvPrimaryDisplay.Click += new System.EventHandler(this.displayMenuItem_Click);
            // 
            // mnuNvPresetsColorSettings
            // 
            this.mnuNvPresetsColorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPresetColorSettings});
            this.mnuNvPresetsColorSettings.Name = "mnuNvPresetsColorSettings";
            this.mnuNvPresetsColorSettings.Size = new System.Drawing.Size(147, 22);
            this.mnuNvPresetsColorSettings.Text = "Color settings";
            // 
            // miNvPresetColorSettings
            // 
            this.miNvPresetColorSettings.Name = "miNvPresetColorSettings";
            this.miNvPresetColorSettings.Size = new System.Drawing.Size(120, 22);
            this.miNvPresetColorSettings.Text = "Included";
            this.miNvPresetColorSettings.Click += new System.EventHandler(this.miNvPresetColorSettings_Click);
            // 
            // mnuRefreshRate
            // 
            this.mnuRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefreshRateIncluded});
            this.mnuRefreshRate.Name = "mnuRefreshRate";
            this.mnuRefreshRate.Size = new System.Drawing.Size(147, 22);
            this.mnuRefreshRate.Text = "Refresh Rate";
            // 
            // miRefreshRateIncluded
            // 
            this.miRefreshRateIncluded.Name = "miRefreshRateIncluded";
            this.miRefreshRateIncluded.Size = new System.Drawing.Size(120, 22);
            this.miRefreshRateIncluded.Text = "Included";
            this.miRefreshRateIncluded.Click += new System.EventHandler(this.includedToolStripMenuItem_Click);
            // 
            // miNvPresetDithering
            // 
            this.miNvPresetDithering.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPresetApplyDithering,
            this.miNvPresetDitheringEnabled});
            this.miNvPresetDithering.Name = "miNvPresetDithering";
            this.miNvPresetDithering.Size = new System.Drawing.Size(147, 22);
            this.miNvPresetDithering.Text = "Dithering";
            // 
            // miNvPresetApplyDithering
            // 
            this.miNvPresetApplyDithering.Name = "miNvPresetApplyDithering";
            this.miNvPresetApplyDithering.Size = new System.Drawing.Size(120, 22);
            this.miNvPresetApplyDithering.Text = "Included";
            this.miNvPresetApplyDithering.Click += new System.EventHandler(this.miNvPresetApplyDithering_Click);
            // 
            // miNvPresetDitheringEnabled
            // 
            this.miNvPresetDitheringEnabled.Name = "miNvPresetDitheringEnabled";
            this.miNvPresetDitheringEnabled.Size = new System.Drawing.Size(120, 22);
            this.miNvPresetDitheringEnabled.Text = "Enabled";
            this.miNvPresetDitheringEnabled.Click += new System.EventHandler(this.miNvPresetDitheringEnabled_Click);
            // 
            // miNvHDR
            // 
            this.miNvHDR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHDRIncluded,
            this.miToggleHDR,
            this.miHDREnabled});
            this.miNvHDR.Name = "miNvHDR";
            this.miNvHDR.Size = new System.Drawing.Size(147, 22);
            this.miNvHDR.Text = "HDR";
            // 
            // miHDRIncluded
            // 
            this.miHDRIncluded.Name = "miHDRIncluded";
            this.miHDRIncluded.Size = new System.Drawing.Size(136, 22);
            this.miHDRIncluded.Text = "Included";
            this.miHDRIncluded.Click += new System.EventHandler(this.miHDRIncluded_Click);
            // 
            // miToggleHDR
            // 
            this.miToggleHDR.Name = "miToggleHDR";
            this.miToggleHDR.Size = new System.Drawing.Size(136, 22);
            this.miToggleHDR.Text = "Toggle HDR";
            this.miToggleHDR.Click += new System.EventHandler(this.miToggleHDR_Click);
            // 
            // miHDREnabled
            // 
            this.miHDREnabled.Name = "miHDREnabled";
            this.miHDREnabled.Size = new System.Drawing.Size(136, 22);
            this.miHDREnabled.Text = "Enabled";
            this.miHDREnabled.Click += new System.EventHandler(this.miHDREnabled_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(6, 477);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lvNvPresets
            // 
            this.lvNvPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNvPresets.ContextMenuStrip = this.mnuNvPresets;
            this.lvNvPresets.FullRowSelect = true;
            this.lvNvPresets.HideSelection = false;
            this.lvNvPresets.Location = new System.Drawing.Point(6, 6);
            this.lvNvPresets.MultiSelect = false;
            this.lvNvPresets.Name = "lvNvPresets";
            this.lvNvPresets.Size = new System.Drawing.Size(829, 465);
            this.lvNvPresets.TabIndex = 0;
            this.lvNvPresets.UseCompatibleStateImageBehavior = false;
            this.lvNvPresets.View = System.Windows.Forms.View.Details;
            this.lvNvPresets.SelectedIndexChanged += new System.EventHandler(this.lvNvPresets_SelectedIndexChanged);
            this.lvNvPresets.DoubleClick += new System.EventHandler(this.lvNvPresets_DoubleClick);
            // 
            // tabLG
            // 
            this.tabLG.Controls.Add(this.btnLgAddButton);
            this.tabLG.Controls.Add(this.label3);
            this.tabLG.Controls.Add(this.cbxLgDevices);
            this.tabLG.Controls.Add(this.btnLgRefreshApps);
            this.tabLG.Controls.Add(this.btnAddLg);
            this.tabLG.Controls.Add(this.btnDeleteLg);
            this.tabLG.Controls.Add(this.cbxLgApps);
            this.tabLG.Controls.Add(this.label5);
            this.tabLG.Controls.Add(this.label4);
            this.tabLG.Controls.Add(this.edtLgTvName);
            this.tabLG.Controls.Add(this.label1);
            this.tabLG.Controls.Add(this.edtNameLg);
            this.tabLG.Controls.Add(this.edtStepsLg);
            this.tabLG.Controls.Add(this.lblStepsLg);
            this.tabLG.Controls.Add(this.lblLgError);
            this.tabLG.Controls.Add(this.btnCloneLg);
            this.tabLG.Controls.Add(this.btnSetShortcutLg);
            this.tabLG.Controls.Add(this.label2);
            this.tabLG.Controls.Add(this.edtShortcutLg);
            this.tabLG.Controls.Add(this.btnApplyLg);
            this.tabLG.Controls.Add(this.lvLgPresets);
            this.tabLG.Location = new System.Drawing.Point(4, 22);
            this.tabLG.Name = "tabLG";
            this.tabLG.Padding = new System.Windows.Forms.Padding(3);
            this.tabLG.Size = new System.Drawing.Size(841, 506);
            this.tabLG.TabIndex = 1;
            this.tabLG.Text = "LG controller";
            this.tabLG.UseVisualStyleBackColor = true;
            // 
            // btnLgAddButton
            // 
            this.btnLgAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLgAddButton.ContextMenuStrip = this.mnuLgButtons;
            this.btnLgAddButton.Enabled = false;
            this.btnLgAddButton.Location = new System.Drawing.Point(760, 460);
            this.btnLgAddButton.Name = "btnLgAddButton";
            this.btnLgAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnLgAddButton.TabIndex = 32;
            this.btnLgAddButton.Text = "Add button";
            this.btnLgAddButton.UseVisualStyleBackColor = true;
            this.btnLgAddButton.Click += new System.EventHandler(this.btnLgAddButton_Click);
            // 
            // mnuLgButtons
            // 
            this.mnuLgButtons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuLgButtons.Name = "mnuLgButtons";
            this.mnuLgButtons.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Device:";
            // 
            // cbxLgDevices
            // 
            this.cbxLgDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgDevices.FormattingEnabled = true;
            this.cbxLgDevices.Location = new System.Drawing.Point(87, 6);
            this.cbxLgDevices.Name = "cbxLgDevices";
            this.cbxLgDevices.Size = new System.Drawing.Size(281, 21);
            this.cbxLgDevices.TabIndex = 30;
            this.cbxLgDevices.SelectedIndexChanged += new System.EventHandler(this.cbxLgDevices_SelectedIndexChanged);
            // 
            // btnLgRefreshApps
            // 
            this.btnLgRefreshApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLgRefreshApps.Location = new System.Drawing.Point(293, 407);
            this.btnLgRefreshApps.Name = "btnLgRefreshApps";
            this.btnLgRefreshApps.Size = new System.Drawing.Size(75, 23);
            this.btnLgRefreshApps.TabIndex = 29;
            this.btnLgRefreshApps.Text = "Refresh";
            this.btnLgRefreshApps.UseVisualStyleBackColor = true;
            this.btnLgRefreshApps.Click += new System.EventHandler(this.btnLgRefreshApps_Click);
            // 
            // btnAddLg
            // 
            this.btnAddLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLg.Location = new System.Drawing.Point(168, 354);
            this.btnAddLg.Name = "btnAddLg";
            this.btnAddLg.Size = new System.Drawing.Size(75, 23);
            this.btnAddLg.TabIndex = 28;
            this.btnAddLg.Text = "Add";
            this.btnAddLg.UseVisualStyleBackColor = true;
            this.btnAddLg.Click += new System.EventHandler(this.btnAddLg_Click);
            // 
            // btnDeleteLg
            // 
            this.btnDeleteLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteLg.Enabled = false;
            this.btnDeleteLg.Location = new System.Drawing.Point(249, 354);
            this.btnDeleteLg.Name = "btnDeleteLg";
            this.btnDeleteLg.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLg.TabIndex = 27;
            this.btnDeleteLg.Text = "Delete";
            this.btnDeleteLg.UseVisualStyleBackColor = true;
            this.btnDeleteLg.Click += new System.EventHandler(this.btnDeleteLg_Click);
            // 
            // cbxLgApps
            // 
            this.cbxLgApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxLgApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgApps.Enabled = false;
            this.cbxLgApps.FormattingEnabled = true;
            this.cbxLgApps.Location = new System.Drawing.Point(87, 409);
            this.cbxLgApps.Name = "cbxLgApps";
            this.cbxLgApps.Size = new System.Drawing.Size(200, 21);
            this.cbxLgApps.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "App:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Friendly screen name:";
            // 
            // edtLgTvName
            // 
            this.edtLgTvName.Enabled = false;
            this.edtLgTvName.Location = new System.Drawing.Point(497, 7);
            this.edtLgTvName.Name = "edtLgTvName";
            this.edtLgTvName.Size = new System.Drawing.Size(142, 20);
            this.edtLgTvName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // edtNameLg
            // 
            this.edtNameLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtNameLg.Enabled = false;
            this.edtNameLg.Location = new System.Drawing.Point(87, 383);
            this.edtNameLg.Name = "edtNameLg";
            this.edtNameLg.Size = new System.Drawing.Size(200, 20);
            this.edtNameLg.TabIndex = 19;
            // 
            // edtStepsLg
            // 
            this.edtStepsLg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStepsLg.Enabled = false;
            this.edtStepsLg.Location = new System.Drawing.Point(87, 462);
            this.edtStepsLg.Multiline = true;
            this.edtStepsLg.Name = "edtStepsLg";
            this.edtStepsLg.Size = new System.Drawing.Size(667, 37);
            this.edtStepsLg.TabIndex = 17;
            // 
            // lblStepsLg
            // 
            this.lblStepsLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStepsLg.AutoSize = true;
            this.lblStepsLg.Location = new System.Drawing.Point(6, 465);
            this.lblStepsLg.Name = "lblStepsLg";
            this.lblStepsLg.Size = new System.Drawing.Size(37, 13);
            this.lblStepsLg.TabIndex = 16;
            this.lblStepsLg.Text = "Steps:";
            // 
            // lblLgError
            // 
            this.lblLgError.AutoSize = true;
            this.lblLgError.Location = new System.Drawing.Point(6, 6);
            this.lblLgError.Name = "lblLgError";
            this.lblLgError.Size = new System.Drawing.Size(50, 13);
            this.lblLgError.TabIndex = 15;
            this.lblLgError.Text = "ErrorText";
            this.lblLgError.Visible = false;
            // 
            // btnCloneLg
            // 
            this.btnCloneLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloneLg.Enabled = false;
            this.btnCloneLg.Location = new System.Drawing.Point(87, 354);
            this.btnCloneLg.Name = "btnCloneLg";
            this.btnCloneLg.Size = new System.Drawing.Size(75, 23);
            this.btnCloneLg.TabIndex = 14;
            this.btnCloneLg.Text = "Clone";
            this.btnCloneLg.UseVisualStyleBackColor = true;
            this.btnCloneLg.Click += new System.EventHandler(this.btnCloneLg_Click);
            // 
            // btnSetShortcutLg
            // 
            this.btnSetShortcutLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetShortcutLg.Enabled = false;
            this.btnSetShortcutLg.Location = new System.Drawing.Point(330, 354);
            this.btnSetShortcutLg.Name = "btnSetShortcutLg";
            this.btnSetShortcutLg.Size = new System.Drawing.Size(75, 23);
            this.btnSetShortcutLg.TabIndex = 13;
            this.btnSetShortcutLg.Text = "Save";
            this.btnSetShortcutLg.UseVisualStyleBackColor = true;
            this.btnSetShortcutLg.Click += new System.EventHandler(this.btnSetShortcutLg_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Shortcut:";
            // 
            // edtShortcutLg
            // 
            this.edtShortcutLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShortcutLg.Enabled = false;
            this.edtShortcutLg.Location = new System.Drawing.Point(87, 436);
            this.edtShortcutLg.Name = "edtShortcutLg";
            this.edtShortcutLg.ReadOnly = true;
            this.edtShortcutLg.Size = new System.Drawing.Size(200, 20);
            this.edtShortcutLg.TabIndex = 11;
            this.edtShortcutLg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtShortcutLg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtShortcut_KeyPress);
            // 
            // btnApplyLg
            // 
            this.btnApplyLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyLg.Enabled = false;
            this.btnApplyLg.Location = new System.Drawing.Point(6, 354);
            this.btnApplyLg.Name = "btnApplyLg";
            this.btnApplyLg.Size = new System.Drawing.Size(75, 23);
            this.btnApplyLg.TabIndex = 9;
            this.btnApplyLg.Text = "Apply";
            this.btnApplyLg.UseVisualStyleBackColor = true;
            this.btnApplyLg.Click += new System.EventHandler(this.btnApplyLg_Click);
            // 
            // lvLgPresets
            // 
            this.lvLgPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLgPresets.FullRowSelect = true;
            this.lvLgPresets.HideSelection = false;
            this.lvLgPresets.Location = new System.Drawing.Point(6, 33);
            this.lvLgPresets.MultiSelect = false;
            this.lvLgPresets.Name = "lvLgPresets";
            this.lvLgPresets.Size = new System.Drawing.Size(829, 315);
            this.lvLgPresets.TabIndex = 8;
            this.lvLgPresets.UseCompatibleStateImageBehavior = false;
            this.lvLgPresets.View = System.Windows.Forms.View.Details;
            this.lvLgPresets.SelectedIndexChanged += new System.EventHandler(this.lvLgPresets_SelectedIndexChanged);
            this.lvLgPresets.DoubleClick += new System.EventHandler(this.lvLgPresets_DoubleClick);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.groupBox2);
            this.tabOptions.Controls.Add(this.groupBox1);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(841, 506);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtDelayDisplaySettings);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HDR";
            // 
            // edtDelayDisplaySettings
            // 
            this.edtDelayDisplaySettings.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edtDelayDisplaySettings.Location = new System.Drawing.Point(296, 17);
            this.edtDelayDisplaySettings.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edtDelayDisplaySettings.Name = "edtDelayDisplaySettings";
            this.edtDelayDisplaySettings.ReadOnly = true;
            this.edtDelayDisplaySettings.Size = new System.Drawing.Size(74, 20);
            this.edtDelayDisplaySettings.TabIndex = 1;
            this.edtDelayDisplaySettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtDelayDisplaySettings.ValueChanged += new System.EventHandler(this.edtDelayDisplaySettings_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Delay opening display settings (ms):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStartMinimized);
            this.groupBox1.Controls.Add(this.chkStartAfterLogin);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(6, 42);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(96, 17);
            this.chkStartMinimized.TabIndex = 3;
            this.chkStartMinimized.Text = "Start minimized";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            // 
            // chkStartAfterLogin
            // 
            this.chkStartAfterLogin.AutoSize = true;
            this.chkStartAfterLogin.Location = new System.Drawing.Point(6, 19);
            this.chkStartAfterLogin.Name = "chkStartAfterLogin";
            this.chkStartAfterLogin.Size = new System.Drawing.Size(160, 17);
            this.chkStartAfterLogin.TabIndex = 2;
            this.chkStartAfterLogin.Text = "Automatically start after login";
            this.chkStartAfterLogin.UseVisualStyleBackColor = true;
            this.chkStartAfterLogin.CheckedChanged += new System.EventHandler(this.chkStartAfterLogin_CheckedChanged);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.edtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(841, 506);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // edtLog
            // 
            this.edtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtLog.Location = new System.Drawing.Point(6, 6);
            this.edtLog.Multiline = true;
            this.edtLog.Name = "edtLog";
            this.edtLog.ReadOnly = true;
            this.edtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtLog.Size = new System.Drawing.Size(832, 497);
            this.edtLog.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.grpNVIDIAInfo);
            this.tabInfo.Controls.Add(this.groupBox3);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(841, 506);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // grpNVIDIAInfo
            // 
            this.grpNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNVIDIAInfo.Controls.Add(this.btnRefreshNVIDIAInfo);
            this.grpNVIDIAInfo.Controls.Add(this.tvNVIDIAInfo);
            this.grpNVIDIAInfo.Location = new System.Drawing.Point(397, 6);
            this.grpNVIDIAInfo.Name = "grpNVIDIAInfo";
            this.grpNVIDIAInfo.Size = new System.Drawing.Size(440, 496);
            this.grpNVIDIAInfo.TabIndex = 4;
            this.grpNVIDIAInfo.TabStop = false;
            this.grpNVIDIAInfo.Text = "NVIDIA info";
            // 
            // btnRefreshNVIDIAInfo
            // 
            this.btnRefreshNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshNVIDIAInfo.Location = new System.Drawing.Point(6, 467);
            this.btnRefreshNVIDIAInfo.Name = "btnRefreshNVIDIAInfo";
            this.btnRefreshNVIDIAInfo.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshNVIDIAInfo.TabIndex = 1;
            this.btnRefreshNVIDIAInfo.Text = "Refresh";
            this.btnRefreshNVIDIAInfo.UseVisualStyleBackColor = true;
            this.btnRefreshNVIDIAInfo.Click += new System.EventHandler(this.btnRefreshNVIDIAInfo_Click);
            // 
            // tvNVIDIAInfo
            // 
            this.tvNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvNVIDIAInfo.Location = new System.Drawing.Point(6, 19);
            this.tvNVIDIAInfo.Name = "tvNVIDIAInfo";
            this.tvNVIDIAInfo.Size = new System.Drawing.Size(428, 442);
            this.tvNVIDIAInfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPlugins);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblInfo);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 220);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // lbPlugins
            // 
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.HorizontalScrollbar = true;
            this.lbPlugins.Location = new System.Drawing.Point(9, 67);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(371, 147);
            this.lbPlugins.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "This app contains the following 3rd party plugins:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(873, 556);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 398);
            this.Name = "MainForm";
            this.Text = "ColorControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tcMain.ResumeLayout(false);
            this.tabNVIDIA.ResumeLayout(false);
            this.tabNVIDIA.PerformLayout();
            this.mnuNvPresets.ResumeLayout(false);
            this.tabLG.ResumeLayout(false);
            this.tabLG.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDelayDisplaySettings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.grpNVIDIAInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabNVIDIA;
        private System.Windows.Forms.TabPage tabLG;
        private System.Windows.Forms.ListView lvNvPresets;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSetShortcut;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.TextBox edtShortcut;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ContextMenuStrip mnuNvPresets;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetDithering;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetApplyDithering;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetDitheringEnabled;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshRate;
        private System.Windows.Forms.ToolStripMenuItem miRefreshRateIncluded;
        private System.Windows.Forms.ToolStripMenuItem miNvHDR;
        private System.Windows.Forms.ToolStripMenuItem miHDRIncluded;
        private System.Windows.Forms.ToolStripMenuItem miToggleHDR;
        private System.Windows.Forms.ToolStripMenuItem miHDREnabled;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLgError;
        private System.Windows.Forms.Button btnCloneLg;
        private System.Windows.Forms.Button btnSetShortcutLg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtShortcutLg;
        private System.Windows.Forms.Button btnApplyLg;
        private System.Windows.Forms.ListView lvLgPresets;
        private System.Windows.Forms.TextBox edtStepsLg;
        private System.Windows.Forms.Label lblStepsLg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNameLg;
        private System.Windows.Forms.Button btnNvPresetDelete;
        private System.Windows.Forms.Button btnAddModesNv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtLgTvName;
        private System.Windows.Forms.ComboBox cbxLgApps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem miNvApply;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnDeleteLg;
        private System.Windows.Forms.Button btnAddLg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkStartAfterLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown edtDelayDisplaySettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem mnuNvDisplay;
        private System.Windows.Forms.ToolStripMenuItem miNvPrimaryDisplay;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TextBox edtLog;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpNVIDIAInfo;
        private System.Windows.Forms.TreeView tvNVIDIAInfo;
        private System.Windows.Forms.Button btnLgRefreshApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLgDevices;
        private System.Windows.Forms.Button btnRefreshNVIDIAInfo;
        private System.Windows.Forms.Button btnLgAddButton;
        private System.Windows.Forms.ContextMenuStrip mnuLgButtons;
        private System.Windows.Forms.ToolStripMenuItem mnuNvPresetsColorSettings;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetColorSettings;
    }
}

