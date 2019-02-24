namespace AppVolumeHotkeys
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbAppName = new System.Windows.Forms.ComboBox();
            this.label_Description7 = new System.Windows.Forms.Label();
            this.tbxMuteHotkey = new System.Windows.Forms.TextBox();
            this.btnResetHotkeys = new System.Windows.Forms.Button();
            this.btnSaveHotkeys = new System.Windows.Forms.Button();
            this.label_Description6 = new System.Windows.Forms.Label();
            this.label_Description5 = new System.Windows.Forms.Label();
            this.tbxVolDownHotkey = new System.Windows.Forms.TextBox();
            this.tbxVolUpHotkey = new System.Windows.Forms.TextBox();
            this.nudVolumeSteps = new System.Windows.Forms.NumericUpDown();
            this.label_Description3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Description4 = new System.Windows.Forms.Label();
            this.lblAppVolume = new System.Windows.Forms.Label();
            this.lblAppMute = new System.Windows.Forms.Label();
            this.label_Description8 = new System.Windows.Forms.Label();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemVolUp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVolDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumeSteps)).BeginInit();
            this.groupBox_Status.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.btnRefresh);
            this.groupBox_Settings.Controls.Add(this.cmbAppName);
            this.groupBox_Settings.Controls.Add(this.label_Description7);
            this.groupBox_Settings.Controls.Add(this.tbxMuteHotkey);
            this.groupBox_Settings.Controls.Add(this.btnResetHotkeys);
            this.groupBox_Settings.Controls.Add(this.btnSaveHotkeys);
            this.groupBox_Settings.Controls.Add(this.label_Description6);
            this.groupBox_Settings.Controls.Add(this.label_Description5);
            this.groupBox_Settings.Controls.Add(this.tbxVolDownHotkey);
            this.groupBox_Settings.Controls.Add(this.tbxVolUpHotkey);
            this.groupBox_Settings.Controls.Add(this.nudVolumeSteps);
            this.groupBox_Settings.Controls.Add(this.label_Description3);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(207, 178);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.Location = new System.Drawing.Point(178, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Q";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbAppName
            // 
            this.cmbAppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppName.FormattingEnabled = true;
            this.cmbAppName.Location = new System.Drawing.Point(6, 17);
            this.cmbAppName.Name = "cmbAppName";
            this.cmbAppName.Size = new System.Drawing.Size(166, 21);
            this.cmbAppName.TabIndex = 1;
            this.cmbAppName.SelectedIndexChanged += new System.EventHandler(this.comboBox_AppName_SelectedIndexChanged);
            // 
            // label_Description7
            // 
            this.label_Description7.AutoSize = true;
            this.label_Description7.Location = new System.Drawing.Point(112, 126);
            this.label_Description7.Name = "label_Description7";
            this.label_Description7.Size = new System.Drawing.Size(68, 13);
            this.label_Description7.TabIndex = 15;
            this.label_Description7.Text = "Mute Hotkey";
            // 
            // tbxMuteHotkey
            // 
            this.tbxMuteHotkey.Location = new System.Drawing.Point(6, 123);
            this.tbxMuteHotkey.Name = "tbxMuteHotkey";
            this.tbxMuteHotkey.ReadOnly = true;
            this.tbxMuteHotkey.Size = new System.Drawing.Size(100, 20);
            this.tbxMuteHotkey.TabIndex = 14;
            this.tbxMuteHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MuteHotkey_KeyDown);
            // 
            // btnResetHotkeys
            // 
            this.btnResetHotkeys.Location = new System.Drawing.Point(107, 149);
            this.btnResetHotkeys.Name = "btnResetHotkeys";
            this.btnResetHotkeys.Size = new System.Drawing.Size(94, 23);
            this.btnResetHotkeys.TabIndex = 13;
            this.btnResetHotkeys.Text = "Reset Hotkeys";
            this.btnResetHotkeys.UseVisualStyleBackColor = true;
            this.btnResetHotkeys.Click += new System.EventHandler(this.button_ResetHotkeys_Click);
            // 
            // btnSaveHotkeys
            // 
            this.btnSaveHotkeys.Location = new System.Drawing.Point(6, 149);
            this.btnSaveHotkeys.Name = "btnSaveHotkeys";
            this.btnSaveHotkeys.Size = new System.Drawing.Size(94, 23);
            this.btnSaveHotkeys.TabIndex = 12;
            this.btnSaveHotkeys.Text = "Save Hotkeys";
            this.btnSaveHotkeys.UseVisualStyleBackColor = true;
            this.btnSaveHotkeys.Click += new System.EventHandler(this.button_SaveHotkeys_Click);
            // 
            // label_Description6
            // 
            this.label_Description6.AutoSize = true;
            this.label_Description6.Location = new System.Drawing.Point(112, 100);
            this.label_Description6.Name = "label_Description6";
            this.label_Description6.Size = new System.Drawing.Size(87, 13);
            this.label_Description6.TabIndex = 11;
            this.label_Description6.Text = "VolDown Hotkey";
            // 
            // label_Description5
            // 
            this.label_Description5.AutoSize = true;
            this.label_Description5.Location = new System.Drawing.Point(112, 74);
            this.label_Description5.Name = "label_Description5";
            this.label_Description5.Size = new System.Drawing.Size(73, 13);
            this.label_Description5.TabIndex = 10;
            this.label_Description5.Text = "VolUp Hotkey";
            // 
            // tbxVolDownHotkey
            // 
            this.tbxVolDownHotkey.Location = new System.Drawing.Point(6, 97);
            this.tbxVolDownHotkey.MaxLength = 0;
            this.tbxVolDownHotkey.Name = "tbxVolDownHotkey";
            this.tbxVolDownHotkey.ReadOnly = true;
            this.tbxVolDownHotkey.Size = new System.Drawing.Size(100, 20);
            this.tbxVolDownHotkey.TabIndex = 9;
            this.tbxVolDownHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_VolDownHotkey_KeyDown);
            // 
            // tbxVolUpHotkey
            // 
            this.tbxVolUpHotkey.Location = new System.Drawing.Point(6, 71);
            this.tbxVolUpHotkey.MaxLength = 0;
            this.tbxVolUpHotkey.Name = "tbxVolUpHotkey";
            this.tbxVolUpHotkey.ReadOnly = true;
            this.tbxVolUpHotkey.Size = new System.Drawing.Size(100, 20);
            this.tbxVolUpHotkey.TabIndex = 8;
            this.tbxVolUpHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_VolUpHotkey_KeyDown);
            // 
            // nudVolumeSteps
            // 
            this.nudVolumeSteps.Location = new System.Drawing.Point(6, 45);
            this.nudVolumeSteps.Name = "nudVolumeSteps";
            this.nudVolumeSteps.Size = new System.Drawing.Size(39, 20);
            this.nudVolumeSteps.TabIndex = 6;
            this.nudVolumeSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudVolumeSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVolumeSteps.ValueChanged += new System.EventHandler(this.numericUpDown_VolumeSteps_ValueChanged);
            this.nudVolumeSteps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_VolumeSteps_KeyDown);
            // 
            // label_Description3
            // 
            this.label_Description3.AutoSize = true;
            this.label_Description3.Location = new System.Drawing.Point(49, 48);
            this.label_Description3.Name = "label_Description3";
            this.label_Description3.Size = new System.Drawing.Size(86, 13);
            this.label_Description3.TabIndex = 5;
            this.label_Description3.Text = "Volume step size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(238, 296);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1 Debug Output";
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Description4.Location = new System.Drawing.Point(6, 16);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(45, 13);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume:";
            // 
            // lblAppVolume
            // 
            this.lblAppVolume.AutoSize = true;
            this.lblAppVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppVolume.Location = new System.Drawing.Point(47, 16);
            this.lblAppVolume.Name = "lblAppVolume";
            this.lblAppVolume.Size = new System.Drawing.Size(13, 13);
            this.lblAppVolume.TabIndex = 6;
            this.lblAppVolume.Text = "0";
            // 
            // lblAppMute
            // 
            this.lblAppMute.AutoSize = true;
            this.lblAppMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppMute.Location = new System.Drawing.Point(134, 16);
            this.lblAppMute.Name = "lblAppMute";
            this.lblAppMute.Size = new System.Drawing.Size(21, 13);
            this.lblAppMute.TabIndex = 7;
            this.lblAppMute.Text = "No";
            // 
            // label_Description8
            // 
            this.label_Description8.AutoSize = true;
            this.label_Description8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Description8.Location = new System.Drawing.Point(104, 16);
            this.label_Description8.Name = "label_Description8";
            this.label_Description8.Size = new System.Drawing.Size(34, 13);
            this.label_Description8.TabIndex = 8;
            this.label_Description8.Text = "Mute:";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.label_Description4);
            this.groupBox_Status.Controls.Add(this.label_Description8);
            this.groupBox_Status.Controls.Add(this.lblAppVolume);
            this.groupBox_Status.Controls.Add(this.lblAppMute);
            this.groupBox_Status.Location = new System.Drawing.Point(12, 196);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Size = new System.Drawing.Size(207, 38);
            this.groupBox_Status.TabIndex = 9;
            this.groupBox_Status.TabStop = false;
            this.groupBox_Status.Text = "Status";
            // 
            // timer_Refresh
            // 
            this.timer_Refresh.Enabled = true;
            this.timer_Refresh.Interval = 500;
            this.timer_Refresh.Tick += new System.EventHandler(this.timer_Refresh_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AppVolumeHotkeys";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.toolStripSeparator1,
            this.itemVolUp,
            this.itemVolDown,
            this.itemMute,
            this.toolStripSeparator2,
            this.itemAbout,
            this.toolStripSeparator3,
            this.itemExit});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(181, 176);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(180, 22);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(180, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // itemMute
            // 
            this.itemMute.Name = "itemMute";
            this.itemMute.Size = new System.Drawing.Size(180, 22);
            this.itemMute.Text = "Toggle Mute";
            this.itemMute.Click += new System.EventHandler(this.itemMute_Click);
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(180, 22);
            this.itemAbout.Text = "About";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // itemVolUp
            // 
            this.itemVolUp.Name = "itemVolUp";
            this.itemVolUp.Size = new System.Drawing.Size(180, 22);
            this.itemVolUp.Text = "Volume Up";
            this.itemVolUp.Click += new System.EventHandler(this.itemVolUp_Click);
            // 
            // itemVolDown
            // 
            this.itemVolDown.Name = "itemVolDown";
            this.itemVolDown.Size = new System.Drawing.Size(180, 22);
            this.itemVolDown.Text = "Volume Down";
            this.itemVolDown.Click += new System.EventHandler(this.itemVolDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(231, 246);
            this.Controls.Add(this.groupBox_Status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox_Settings);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "AppVolumeHotkeys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumeSteps)).EndInit();
            this.groupBox_Status.ResumeLayout(false);
            this.groupBox_Status.PerformLayout();
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Description3;
        private System.Windows.Forms.NumericUpDown nudVolumeSteps;
        private System.Windows.Forms.Label label_Description4;
        private System.Windows.Forms.Label lblAppVolume;
        private System.Windows.Forms.Label lblAppMute;
        private System.Windows.Forms.Label label_Description6;
        private System.Windows.Forms.Label label_Description5;
        private System.Windows.Forms.TextBox tbxVolDownHotkey;
        private System.Windows.Forms.TextBox tbxVolUpHotkey;
        private System.Windows.Forms.Button btnSaveHotkeys;
        private System.Windows.Forms.Button btnResetHotkeys;
        private System.Windows.Forms.TextBox tbxMuteHotkey;
        private System.Windows.Forms.Label label_Description7;
        private System.Windows.Forms.Label label_Description8;
        private System.Windows.Forms.GroupBox groupBox_Status;
        private System.Windows.Forms.Timer timer_Refresh;
        private System.Windows.Forms.ComboBox cmbAppName;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemMute;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemVolUp;
        private System.Windows.Forms.ToolStripMenuItem itemVolDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

