﻿using System.Windows.Forms;
using System.Drawing;
using System;
namespace x360ce.App
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.ResetButton = new System.Windows.Forms.Button();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.Pad1TabPage = new System.Windows.Forms.TabPage();
			this.Pad2TabPage = new System.Windows.Forms.TabPage();
			this.Pad3TabPage = new System.Windows.Forms.TabPage();
			this.Pad4TabPage = new System.Windows.Forms.TabPage();
			this.OptionsTabPage = new System.Windows.Forms.TabPage();
			this.ElevatedActionButton = new System.Windows.Forms.Button();
			this.ElevateThisAppButton = new System.Windows.Forms.Button();
			this.FakePidLabel = new System.Windows.Forms.Label();
			this.InstalledFilesLabel = new System.Windows.Forms.Label();
			this.FakeVidLabel = new System.Windows.Forms.Label();
			this.FakePidTextBox = new System.Windows.Forms.TextBox();
			this.FakeVidTextBox = new System.Windows.Forms.TextBox();
			this.EnableLoggingCheckBox = new System.Windows.Forms.CheckBox();
			this.UseInitBeepCheckBox = new System.Windows.Forms.CheckBox();
			this.FakeDiCheckBox = new System.Windows.Forms.CheckBox();
			this.FakeWmiCheckBox = new System.Windows.Forms.CheckBox();
			this.InstallFilesX360ceCheckBox = new System.Windows.Forms.CheckBox();
			this.InstallFilesXinput910CheckBox = new System.Windows.Forms.CheckBox();
			this.InstallFilesXinput11CheckBox = new System.Windows.Forms.CheckBox();
			this.InstallFilesXinput12CheckBox = new System.Windows.Forms.CheckBox();
			this.InstallFilesXinput13CheckBox = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.FakeApiCheckBox = new System.Windows.Forms.CheckBox();
			this.HelpTabPage = new System.Windows.Forms.TabPage();
			this.HelpRichTextBox = new System.Windows.Forms.RichTextBox();
			this.AboutTabPage = new System.Windows.Forms.TabPage();
			this.BuletImageList = new System.Windows.Forms.ImageList(this.components);
			this.PresetComboBox = new System.Windows.Forms.ComboBox();
			this.LoadPresetButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusEventsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusSaveLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.StatusIsAdminLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.CleanStatusTimer = new System.Windows.Forms.Timer(this.components);
			this.SaveButton = new System.Windows.Forms.Button();
			this.SettingsTimer = new System.Windows.Forms.Timer(this.components);
			this.MainTabControl.SuspendLayout();
			this.OptionsTabPage.SuspendLayout();
			this.HelpTabPage.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 50;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// ResetButton
			// 
			this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetButton.Location = new System.Drawing.Point(491, 484);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 15;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// MainTabControl
			// 
			this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.MainTabControl.Controls.Add(this.Pad1TabPage);
			this.MainTabControl.Controls.Add(this.Pad2TabPage);
			this.MainTabControl.Controls.Add(this.Pad3TabPage);
			this.MainTabControl.Controls.Add(this.Pad4TabPage);
			this.MainTabControl.Controls.Add(this.OptionsTabPage);
			this.MainTabControl.Controls.Add(this.HelpTabPage);
			this.MainTabControl.Controls.Add(this.AboutTabPage);
			this.MainTabControl.ImageList = this.BuletImageList;
			this.MainTabControl.Location = new System.Drawing.Point(12, 12);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(635, 466);
			this.MainTabControl.TabIndex = 16;
			this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
			// 
			// Pad1TabPage
			// 
			this.Pad1TabPage.Location = new System.Drawing.Point(4, 23);
			this.Pad1TabPage.Name = "Pad1TabPage";
			this.Pad1TabPage.Size = new System.Drawing.Size(627, 439);
			this.Pad1TabPage.TabIndex = 6;
			this.Pad1TabPage.Text = "Controller 1";
			// 
			// Pad2TabPage
			// 
			this.Pad2TabPage.Location = new System.Drawing.Point(4, 23);
			this.Pad2TabPage.Name = "Pad2TabPage";
			this.Pad2TabPage.Size = new System.Drawing.Size(627, 439);
			this.Pad2TabPage.TabIndex = 7;
			this.Pad2TabPage.Text = "Controller 2";
			// 
			// Pad3TabPage
			// 
			this.Pad3TabPage.Location = new System.Drawing.Point(4, 23);
			this.Pad3TabPage.Name = "Pad3TabPage";
			this.Pad3TabPage.Size = new System.Drawing.Size(627, 439);
			this.Pad3TabPage.TabIndex = 8;
			this.Pad3TabPage.Text = "Controller 3";
			// 
			// Pad4TabPage
			// 
			this.Pad4TabPage.Location = new System.Drawing.Point(4, 23);
			this.Pad4TabPage.Name = "Pad4TabPage";
			this.Pad4TabPage.Size = new System.Drawing.Size(627, 439);
			this.Pad4TabPage.TabIndex = 9;
			this.Pad4TabPage.Text = "Controller 4";
			// 
			// OptionsTabPage
			// 
			this.OptionsTabPage.BackColor = System.Drawing.Color.Transparent;
			this.OptionsTabPage.Controls.Add(this.ElevatedActionButton);
			this.OptionsTabPage.Controls.Add(this.ElevateThisAppButton);
			this.OptionsTabPage.Controls.Add(this.FakePidLabel);
			this.OptionsTabPage.Controls.Add(this.InstalledFilesLabel);
			this.OptionsTabPage.Controls.Add(this.FakeVidLabel);
			this.OptionsTabPage.Controls.Add(this.FakePidTextBox);
			this.OptionsTabPage.Controls.Add(this.FakeVidTextBox);
			this.OptionsTabPage.Controls.Add(this.EnableLoggingCheckBox);
			this.OptionsTabPage.Controls.Add(this.UseInitBeepCheckBox);
			this.OptionsTabPage.Controls.Add(this.FakeDiCheckBox);
			this.OptionsTabPage.Controls.Add(this.FakeWmiCheckBox);
			this.OptionsTabPage.Controls.Add(this.InstallFilesX360ceCheckBox);
			this.OptionsTabPage.Controls.Add(this.InstallFilesXinput910CheckBox);
			this.OptionsTabPage.Controls.Add(this.InstallFilesXinput11CheckBox);
			this.OptionsTabPage.Controls.Add(this.InstallFilesXinput12CheckBox);
			this.OptionsTabPage.Controls.Add(this.InstallFilesXinput13CheckBox);
			this.OptionsTabPage.Controls.Add(this.checkBox1);
			this.OptionsTabPage.Controls.Add(this.FakeApiCheckBox);
			this.OptionsTabPage.Location = new System.Drawing.Point(4, 23);
			this.OptionsTabPage.Name = "OptionsTabPage";
			this.OptionsTabPage.Size = new System.Drawing.Size(627, 439);
			this.OptionsTabPage.TabIndex = 5;
			this.OptionsTabPage.Text = "Options";
			// 
			// ElevatedActionButton
			// 
			this.ElevatedActionButton.Location = new System.Drawing.Point(346, 317);
			this.ElevatedActionButton.Name = "ElevatedActionButton";
			this.ElevatedActionButton.Size = new System.Drawing.Size(75, 23);
			this.ElevatedActionButton.TabIndex = 27;
			this.ElevatedActionButton.Text = "Action";
			this.ElevatedActionButton.UseVisualStyleBackColor = true;
			this.ElevatedActionButton.Visible = false;
			// 
			// ElevateThisAppButton
			// 
			this.ElevateThisAppButton.Location = new System.Drawing.Point(346, 288);
			this.ElevateThisAppButton.Name = "ElevateThisAppButton";
			this.ElevateThisAppButton.Size = new System.Drawing.Size(75, 23);
			this.ElevateThisAppButton.TabIndex = 27;
			this.ElevateThisAppButton.Text = "Elevate";
			this.ElevateThisAppButton.UseVisualStyleBackColor = true;
			this.ElevateThisAppButton.Visible = false;
			this.ElevateThisAppButton.Click += new System.EventHandler(this.ElevateThisAppButton_Click);
			// 
			// FakePidLabel
			// 
			this.FakePidLabel.AutoSize = true;
			this.FakePidLabel.Location = new System.Drawing.Point(4, 178);
			this.FakePidLabel.Name = "FakePidLabel";
			this.FakePidLabel.Size = new System.Drawing.Size(52, 13);
			this.FakePidLabel.TabIndex = 26;
			this.FakePidLabel.Text = "FakePID:";
			// 
			// InstalledFilesLabel
			// 
			this.InstalledFilesLabel.AutoSize = true;
			this.InstalledFilesLabel.Location = new System.Drawing.Point(119, 8);
			this.InstalledFilesLabel.Name = "InstalledFilesLabel";
			this.InstalledFilesLabel.Size = new System.Drawing.Size(70, 13);
			this.InstalledFilesLabel.TabIndex = 26;
			this.InstalledFilesLabel.Text = "Installed files:";
			// 
			// FakeVidLabel
			// 
			this.FakeVidLabel.AutoSize = true;
			this.FakeVidLabel.Location = new System.Drawing.Point(4, 152);
			this.FakeVidLabel.Name = "FakeVidLabel";
			this.FakeVidLabel.Size = new System.Drawing.Size(52, 13);
			this.FakeVidLabel.TabIndex = 26;
			this.FakeVidLabel.Text = "FakeVID:";
			// 
			// FakePidTextBox
			// 
			this.FakePidTextBox.Location = new System.Drawing.Point(82, 175);
			this.FakePidTextBox.Name = "FakePidTextBox";
			this.FakePidTextBox.Size = new System.Drawing.Size(100, 20);
			this.FakePidTextBox.TabIndex = 25;
			// 
			// FakeVidTextBox
			// 
			this.FakeVidTextBox.Location = new System.Drawing.Point(82, 149);
			this.FakeVidTextBox.Name = "FakeVidTextBox";
			this.FakeVidTextBox.Size = new System.Drawing.Size(100, 20);
			this.FakeVidTextBox.TabIndex = 24;
			// 
			// EnableLoggingCheckBox
			// 
			this.EnableLoggingCheckBox.AutoSize = true;
			this.EnableLoggingCheckBox.Location = new System.Drawing.Point(7, 122);
			this.EnableLoggingCheckBox.Name = "EnableLoggingCheckBox";
			this.EnableLoggingCheckBox.Size = new System.Drawing.Size(100, 17);
			this.EnableLoggingCheckBox.TabIndex = 21;
			this.EnableLoggingCheckBox.Text = "Enable Logging";
			this.EnableLoggingCheckBox.UseVisualStyleBackColor = true;
			// 
			// UseInitBeepCheckBox
			// 
			this.UseInitBeepCheckBox.AutoSize = true;
			this.UseInitBeepCheckBox.Location = new System.Drawing.Point(7, 99);
			this.UseInitBeepCheckBox.Name = "UseInitBeepCheckBox";
			this.UseInitBeepCheckBox.Size = new System.Drawing.Size(90, 17);
			this.UseInitBeepCheckBox.TabIndex = 22;
			this.UseInitBeepCheckBox.Text = "Use Init Beep";
			this.UseInitBeepCheckBox.UseVisualStyleBackColor = true;
			// 
			// FakeDiCheckBox
			// 
			this.FakeDiCheckBox.AutoSize = true;
			this.FakeDiCheckBox.Location = new System.Drawing.Point(7, 76);
			this.FakeDiCheckBox.Name = "FakeDiCheckBox";
			this.FakeDiCheckBox.Size = new System.Drawing.Size(64, 17);
			this.FakeDiCheckBox.TabIndex = 23;
			this.FakeDiCheckBox.Text = "Fake DI";
			this.FakeDiCheckBox.UseVisualStyleBackColor = true;
			// 
			// FakeWmiCheckBox
			// 
			this.FakeWmiCheckBox.AutoSize = true;
			this.FakeWmiCheckBox.Location = new System.Drawing.Point(7, 53);
			this.FakeWmiCheckBox.Name = "FakeWmiCheckBox";
			this.FakeWmiCheckBox.Size = new System.Drawing.Size(76, 17);
			this.FakeWmiCheckBox.TabIndex = 18;
			this.FakeWmiCheckBox.Text = "Fake WMI";
			this.FakeWmiCheckBox.UseVisualStyleBackColor = true;
			// 
			// InstallFilesX360ceCheckBox
			// 
			this.InstallFilesX360ceCheckBox.AutoSize = true;
			this.InstallFilesX360ceCheckBox.Location = new System.Drawing.Point(122, 30);
			this.InstallFilesX360ceCheckBox.Name = "InstallFilesX360ceCheckBox";
			this.InstallFilesX360ceCheckBox.Size = new System.Drawing.Size(74, 17);
			this.InstallFilesX360ceCheckBox.TabIndex = 19;
			this.InstallFilesX360ceCheckBox.Text = "x360ce.ini";
			this.InstallFilesX360ceCheckBox.UseVisualStyleBackColor = true;
			// 
			// InstallFilesXinput910CheckBox
			// 
			this.InstallFilesXinput910CheckBox.AutoSize = true;
			this.InstallFilesXinput910CheckBox.Location = new System.Drawing.Point(122, 122);
			this.InstallFilesXinput910CheckBox.Name = "InstallFilesXinput910CheckBox";
			this.InstallFilesXinput910CheckBox.Size = new System.Drawing.Size(97, 17);
			this.InstallFilesXinput910CheckBox.TabIndex = 19;
			this.InstallFilesXinput910CheckBox.Text = "xinput9_1_0.dll";
			this.InstallFilesXinput910CheckBox.UseVisualStyleBackColor = true;
			// 
			// InstallFilesXinput11CheckBox
			// 
			this.InstallFilesXinput11CheckBox.AutoSize = true;
			this.InstallFilesXinput11CheckBox.Location = new System.Drawing.Point(122, 99);
			this.InstallFilesXinput11CheckBox.Name = "InstallFilesXinput11CheckBox";
			this.InstallFilesXinput11CheckBox.Size = new System.Drawing.Size(85, 17);
			this.InstallFilesXinput11CheckBox.TabIndex = 19;
			this.InstallFilesXinput11CheckBox.Text = "xinput1_1.dll";
			this.InstallFilesXinput11CheckBox.UseVisualStyleBackColor = true;
			// 
			// InstallFilesXinput12CheckBox
			// 
			this.InstallFilesXinput12CheckBox.AutoSize = true;
			this.InstallFilesXinput12CheckBox.Location = new System.Drawing.Point(122, 76);
			this.InstallFilesXinput12CheckBox.Name = "InstallFilesXinput12CheckBox";
			this.InstallFilesXinput12CheckBox.Size = new System.Drawing.Size(85, 17);
			this.InstallFilesXinput12CheckBox.TabIndex = 19;
			this.InstallFilesXinput12CheckBox.Text = "xinput1_2.dll";
			this.InstallFilesXinput12CheckBox.UseVisualStyleBackColor = true;
			// 
			// InstallFilesXinput13CheckBox
			// 
			this.InstallFilesXinput13CheckBox.AutoSize = true;
			this.InstallFilesXinput13CheckBox.Location = new System.Drawing.Point(122, 53);
			this.InstallFilesXinput13CheckBox.Name = "InstallFilesXinput13CheckBox";
			this.InstallFilesXinput13CheckBox.Size = new System.Drawing.Size(166, 17);
			this.InstallFilesXinput13CheckBox.TabIndex = 19;
			this.InstallFilesXinput13CheckBox.Text = "xinput1_3.dll (Recommended)";
			this.InstallFilesXinput13CheckBox.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(7, 7);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(87, 17);
			this.checkBox1.TabIndex = 19;
			this.checkBox1.Text = "Native Mode";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// FakeApiCheckBox
			// 
			this.FakeApiCheckBox.AutoSize = true;
			this.FakeApiCheckBox.Location = new System.Drawing.Point(7, 30);
			this.FakeApiCheckBox.Name = "FakeApiCheckBox";
			this.FakeApiCheckBox.Size = new System.Drawing.Size(70, 17);
			this.FakeApiCheckBox.TabIndex = 20;
			this.FakeApiCheckBox.Text = "Fake API";
			this.FakeApiCheckBox.UseVisualStyleBackColor = true;
			// 
			// HelpTabPage
			// 
			this.HelpTabPage.Controls.Add(this.HelpRichTextBox);
			this.HelpTabPage.Location = new System.Drawing.Point(4, 23);
			this.HelpTabPage.Name = "HelpTabPage";
			this.HelpTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.HelpTabPage.Size = new System.Drawing.Size(627, 439);
			this.HelpTabPage.TabIndex = 10;
			this.HelpTabPage.Text = "Help";
			// 
			// HelpRichTextBox
			// 
			this.HelpRichTextBox.BackColor = System.Drawing.Color.White;
			this.HelpRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HelpRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HelpRichTextBox.Location = new System.Drawing.Point(3, 3);
			this.HelpRichTextBox.Name = "HelpRichTextBox";
			this.HelpRichTextBox.ReadOnly = true;
			this.HelpRichTextBox.Size = new System.Drawing.Size(621, 433);
			this.HelpRichTextBox.TabIndex = 0;
			this.HelpRichTextBox.Text = "";
			// 
			// AboutTabPage
			// 
			this.AboutTabPage.BackColor = System.Drawing.Color.Transparent;
			this.AboutTabPage.Location = new System.Drawing.Point(4, 23);
			this.AboutTabPage.Name = "AboutTabPage";
			this.AboutTabPage.Size = new System.Drawing.Size(627, 439);
			this.AboutTabPage.TabIndex = 2;
			this.AboutTabPage.Text = "About";
			// 
			// BuletImageList
			// 
			this.BuletImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.BuletImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.BuletImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// PresetComboBox
			// 
			this.PresetComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PresetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PresetComboBox.FormattingEnabled = true;
			this.PresetComboBox.Location = new System.Drawing.Point(12, 484);
			this.PresetComboBox.Name = "PresetComboBox";
			this.PresetComboBox.Size = new System.Drawing.Size(392, 21);
			this.PresetComboBox.TabIndex = 27;
			// 
			// LoadPresetButton
			// 
			this.LoadPresetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LoadPresetButton.Location = new System.Drawing.Point(410, 484);
			this.LoadPresetButton.Name = "LoadPresetButton";
			this.LoadPresetButton.Size = new System.Drawing.Size(75, 23);
			this.LoadPresetButton.TabIndex = 15;
			this.LoadPresetButton.Text = "Load";
			this.LoadPresetButton.UseVisualStyleBackColor = true;
			this.LoadPresetButton.Click += new System.EventHandler(this.LoadPresetButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.StatusEventsLabel,
            this.StatusSaveLabel,
            this.StatusIsAdminLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 508);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(659, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 17;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 19);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(215, 19);
			this.toolStripStatusLabel2.Spring = true;
			// 
			// StatusEventsLabel
			// 
			this.StatusEventsLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.StatusEventsLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.StatusEventsLabel.Name = "StatusEventsLabel";
			this.StatusEventsLabel.Size = new System.Drawing.Size(105, 19);
			this.StatusEventsLabel.Text = "StatusEventsLabel";
			// 
			// StatusSaveLabel
			// 
			this.StatusSaveLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.StatusSaveLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.StatusSaveLabel.Name = "StatusSaveLabel";
			this.StatusSaveLabel.Size = new System.Drawing.Size(95, 19);
			this.StatusSaveLabel.Text = "StatusSaveLabel";
			// 
			// StatusIsAdminLabel
			// 
			this.StatusIsAdminLabel.Name = "StatusIsAdminLabel";
			this.StatusIsAdminLabel.Size = new System.Drawing.Size(111, 19);
			this.StatusIsAdminLabel.Text = "StatusIsAdminLabel";
			// 
			// CleanStatusTimer
			// 
			this.CleanStatusTimer.Interval = 3000;
			this.CleanStatusTimer.Tick += new System.EventHandler(this.CleanStatusTimer_Tick);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(572, 484);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 15;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// SettingsTimer
			// 
			this.SettingsTimer.Interval = 500;
			this.SettingsTimer.Tick += new System.EventHandler(this.SettingsTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(659, 532);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.PresetComboBox);
			this.Controls.Add(this.MainTabControl);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.LoadPresetButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(675, 570);
			this.MinimumSize = new System.Drawing.Size(675, 570);
			this.Name = "MainForm";
			this.Text = "TocaEdit Xbox 360 Controller Emulator {0}";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.MainTabControl.ResumeLayout(false);
			this.OptionsTabPage.ResumeLayout(false);
			this.OptionsTabPage.PerformLayout();
			this.HelpTabPage.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button ResetButton;
		private TabControl MainTabControl;
		private TabPage AboutTabPage;
		private StatusStrip statusStrip1;
		private TabPage OptionsTabPage;
		private CheckBox EnableLoggingCheckBox;
		private CheckBox UseInitBeepCheckBox;
		private CheckBox FakeDiCheckBox;
		private CheckBox FakeWmiCheckBox;
		private CheckBox checkBox1;
		private CheckBox FakeApiCheckBox;
		private Label FakePidLabel;
		private Label FakeVidLabel;
		private TextBox FakePidTextBox;
		private TextBox FakeVidTextBox;
		private Timer CleanStatusTimer;
		private ComboBox PresetComboBox;
		private Button LoadPresetButton;
		private Label InstalledFilesLabel;
		private CheckBox InstallFilesX360ceCheckBox;
		private CheckBox InstallFilesXinput910CheckBox;
		private CheckBox InstallFilesXinput11CheckBox;
		private CheckBox InstallFilesXinput12CheckBox;
		private CheckBox InstallFilesXinput13CheckBox;
		private Button SaveButton;
		private TabPage Pad1TabPage;
		private TabPage Pad2TabPage;
		private TabPage Pad3TabPage;
		private TabPage Pad4TabPage;
		private ImageList BuletImageList;
		public ToolStripStatusLabel toolStripStatusLabel1;
		private Timer timer;
		private Timer SettingsTimer;
		private ToolStripStatusLabel StatusEventsLabel;
		private ToolStripStatusLabel StatusSaveLabel;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private TabPage HelpTabPage;
		private RichTextBox HelpRichTextBox;
		private Button ElevatedActionButton;
		private Button ElevateThisAppButton;
		private ToolStripStatusLabel StatusIsAdminLabel;

	}
}