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
            this.btnEndpointsRefresh = new System.Windows.Forms.Button();
            this.cmbEndpoints = new System.Windows.Forms.ComboBox();
            this.btnAppNameRefresh = new System.Windows.Forms.Button();
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
            this.label_Description4 = new System.Windows.Forms.Label();
            this.lblAppVolume = new System.Windows.Forms.Label();
            this.lblAppMute = new System.Windows.Forms.Label();
            this.label_Description8 = new System.Windows.Forms.Label();
            this.groupBox_Status = new System.Windows.Forms.GroupBox();
            this.timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemVolUp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVolDown = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_ptt = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolumeSteps)).BeginInit();
            this.groupBox_Status.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.btnEndpointsRefresh);
            this.groupBox_Settings.Controls.Add(this.cmbEndpoints);
            this.groupBox_Settings.Controls.Add(this.btnAppNameRefresh);
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
            this.groupBox_Settings.Location = new System.Drawing.Point(16, 15);
            this.groupBox_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Settings.Size = new System.Drawing.Size(276, 255);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // btnEndpointsRefresh
            // 
            this.btnEndpointsRefresh.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold);
            this.btnEndpointsRefresh.Location = new System.Drawing.Point(237, 22);
            this.btnEndpointsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndpointsRefresh.Name = "btnEndpointsRefresh";
            this.btnEndpointsRefresh.Size = new System.Drawing.Size(31, 28);
            this.btnEndpointsRefresh.TabIndex = 20;
            this.btnEndpointsRefresh.Text = "Q";
            this.btnEndpointsRefresh.UseVisualStyleBackColor = true;
            this.btnEndpointsRefresh.Click += new System.EventHandler(this.btnEndpointsRefresh_Click);
            // 
            // cmbEndpoints
            // 
            this.cmbEndpoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndpoints.DropDownWidth = 206;
            this.cmbEndpoints.FormattingEnabled = true;
            this.cmbEndpoints.Location = new System.Drawing.Point(8, 23);
            this.cmbEndpoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEndpoints.Name = "cmbEndpoints";
            this.cmbEndpoints.Size = new System.Drawing.Size(220, 24);
            this.cmbEndpoints.TabIndex = 19;
            this.cmbEndpoints.TabStop = false;
            this.cmbEndpoints.SelectedIndexChanged += new System.EventHandler(this.cmbEndpoints_SelectedIndexChanged);
            // 
            // btnAppNameRefresh
            // 
            this.btnAppNameRefresh.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAppNameRefresh.Location = new System.Drawing.Point(237, 53);
            this.btnAppNameRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppNameRefresh.Name = "btnAppNameRefresh";
            this.btnAppNameRefresh.Size = new System.Drawing.Size(31, 28);
            this.btnAppNameRefresh.TabIndex = 1;
            this.btnAppNameRefresh.TabStop = false;
            this.btnAppNameRefresh.Text = "Q";
            this.btnAppNameRefresh.UseVisualStyleBackColor = true;
            this.btnAppNameRefresh.Click += new System.EventHandler(this.btnAppNameRefresh_Click);
            // 
            // cmbAppName
            // 
            this.cmbAppName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppName.FormattingEnabled = true;
            this.cmbAppName.Location = new System.Drawing.Point(8, 54);
            this.cmbAppName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAppName.Name = "cmbAppName";
            this.cmbAppName.Size = new System.Drawing.Size(220, 24);
            this.cmbAppName.TabIndex = 18;
            this.cmbAppName.TabStop = false;
            this.cmbAppName.SelectedIndexChanged += new System.EventHandler(this.cmbAppName_SelectedIndexChanged);
            // 
            // label_Description7
            // 
            this.label_Description7.AutoSize = true;
            this.label_Description7.Location = new System.Drawing.Point(149, 188);
            this.label_Description7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description7.Name = "label_Description7";
            this.label_Description7.Size = new System.Drawing.Size(87, 17);
            this.label_Description7.TabIndex = 15;
            this.label_Description7.Text = "Mute Hotkey";
            // 
            // tbxMuteHotkey
            // 
            this.tbxMuteHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxMuteHotkey.Location = new System.Drawing.Point(8, 185);
            this.tbxMuteHotkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMuteHotkey.Name = "tbxMuteHotkey";
            this.tbxMuteHotkey.ReadOnly = true;
            this.tbxMuteHotkey.Size = new System.Drawing.Size(132, 22);
            this.tbxMuteHotkey.TabIndex = 14;
            this.tbxMuteHotkey.TabStop = false;
            this.tbxMuteHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_MuteHotkey_KeyUp);
            // 
            // btnResetHotkeys
            // 
            this.btnResetHotkeys.Location = new System.Drawing.Point(143, 217);
            this.btnResetHotkeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetHotkeys.Name = "btnResetHotkeys";
            this.btnResetHotkeys.Size = new System.Drawing.Size(125, 28);
            this.btnResetHotkeys.TabIndex = 13;
            this.btnResetHotkeys.TabStop = false;
            this.btnResetHotkeys.Text = "Reset Hotkeys";
            this.btnResetHotkeys.UseVisualStyleBackColor = true;
            this.btnResetHotkeys.Click += new System.EventHandler(this.button_ResetHotkeys_Click);
            // 
            // btnSaveHotkeys
            // 
            this.btnSaveHotkeys.Location = new System.Drawing.Point(8, 217);
            this.btnSaveHotkeys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveHotkeys.Name = "btnSaveHotkeys";
            this.btnSaveHotkeys.Size = new System.Drawing.Size(125, 28);
            this.btnSaveHotkeys.TabIndex = 12;
            this.btnSaveHotkeys.TabStop = false;
            this.btnSaveHotkeys.Text = "Save Hotkeys";
            this.btnSaveHotkeys.UseVisualStyleBackColor = true;
            this.btnSaveHotkeys.Click += new System.EventHandler(this.button_SaveHotkeys_Click);
            // 
            // label_Description6
            // 
            this.label_Description6.AutoSize = true;
            this.label_Description6.Location = new System.Drawing.Point(149, 156);
            this.label_Description6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description6.Name = "label_Description6";
            this.label_Description6.Size = new System.Drawing.Size(111, 17);
            this.label_Description6.TabIndex = 11;
            this.label_Description6.Text = "VolDown Hotkey";
            // 
            // label_Description5
            // 
            this.label_Description5.AutoSize = true;
            this.label_Description5.Location = new System.Drawing.Point(149, 124);
            this.label_Description5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description5.Name = "label_Description5";
            this.label_Description5.Size = new System.Drawing.Size(94, 17);
            this.label_Description5.TabIndex = 10;
            this.label_Description5.Text = "VolUp Hotkey";
            // 
            // tbxVolDownHotkey
            // 
            this.tbxVolDownHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxVolDownHotkey.Location = new System.Drawing.Point(8, 153);
            this.tbxVolDownHotkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxVolDownHotkey.MaxLength = 0;
            this.tbxVolDownHotkey.Name = "tbxVolDownHotkey";
            this.tbxVolDownHotkey.ReadOnly = true;
            this.tbxVolDownHotkey.Size = new System.Drawing.Size(132, 22);
            this.tbxVolDownHotkey.TabIndex = 9;
            this.tbxVolDownHotkey.TabStop = false;
            this.tbxVolDownHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_VolDownHotkey_KeyUp);
            // 
            // tbxVolUpHotkey
            // 
            this.tbxVolUpHotkey.BackColor = System.Drawing.SystemColors.Control;
            this.tbxVolUpHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxVolUpHotkey.Location = new System.Drawing.Point(8, 121);
            this.tbxVolUpHotkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxVolUpHotkey.MaxLength = 0;
            this.tbxVolUpHotkey.Name = "tbxVolUpHotkey";
            this.tbxVolUpHotkey.ReadOnly = true;
            this.tbxVolUpHotkey.Size = new System.Drawing.Size(132, 22);
            this.tbxVolUpHotkey.TabIndex = 8;
            this.tbxVolUpHotkey.TabStop = false;
            this.tbxVolUpHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_VolUpHotkey_KeyUp);
            // 
            // nudVolumeSteps
            // 
            this.nudVolumeSteps.Location = new System.Drawing.Point(8, 89);
            this.nudVolumeSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudVolumeSteps.Name = "nudVolumeSteps";
            this.nudVolumeSteps.Size = new System.Drawing.Size(52, 22);
            this.nudVolumeSteps.TabIndex = 6;
            this.nudVolumeSteps.TabStop = false;
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
            this.label_Description3.Location = new System.Drawing.Point(65, 92);
            this.label_Description3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description3.Name = "label_Description3";
            this.label_Description3.Size = new System.Drawing.Size(115, 17);
            this.label_Description3.TabIndex = 5;
            this.label_Description3.Text = "Volume step size";
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Description4.Location = new System.Drawing.Point(8, 20);
            this.label_Description4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(59, 17);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume:";
            // 
            // lblAppVolume
            // 
            this.lblAppVolume.AutoSize = true;
            this.lblAppVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppVolume.Location = new System.Drawing.Point(65, 20);
            this.lblAppVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppVolume.Name = "lblAppVolume";
            this.lblAppVolume.Size = new System.Drawing.Size(16, 17);
            this.lblAppVolume.TabIndex = 6;
            this.lblAppVolume.Text = "0";
            // 
            // lblAppMute
            // 
            this.lblAppMute.AutoSize = true;
            this.lblAppMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAppMute.Location = new System.Drawing.Point(181, 20);
            this.lblAppMute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppMute.Name = "lblAppMute";
            this.lblAppMute.Size = new System.Drawing.Size(26, 17);
            this.lblAppMute.TabIndex = 7;
            this.lblAppMute.Text = "No";
            // 
            // label_Description8
            // 
            this.label_Description8.AutoSize = true;
            this.label_Description8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Description8.Location = new System.Drawing.Point(139, 20);
            this.label_Description8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description8.Name = "label_Description8";
            this.label_Description8.Size = new System.Drawing.Size(43, 17);
            this.label_Description8.TabIndex = 8;
            this.label_Description8.Text = "Mute:";
            // 
            // groupBox_Status
            // 
            this.groupBox_Status.Controls.Add(this.label_Description4);
            this.groupBox_Status.Controls.Add(this.label_Description8);
            this.groupBox_Status.Controls.Add(this.lblAppVolume);
            this.groupBox_Status.Controls.Add(this.lblAppMute);
            this.groupBox_Status.Location = new System.Drawing.Point(16, 277);
            this.groupBox_Status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Status.Name = "groupBox_Status";
            this.groupBox_Status.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Status.Size = new System.Drawing.Size(276, 47);
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AppVolumeHotkeys";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // cmsTray
            // 
            this.cmsTray.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.cmsTray.Size = new System.Drawing.Size(172, 166);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(171, 24);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // itemVolUp
            // 
            this.itemVolUp.Name = "itemVolUp";
            this.itemVolUp.Size = new System.Drawing.Size(171, 24);
            this.itemVolUp.Text = "Volume Up";
            this.itemVolUp.Click += new System.EventHandler(this.itemVolUp_Click);
            // 
            // itemVolDown
            // 
            this.itemVolDown.Name = "itemVolDown";
            this.itemVolDown.Size = new System.Drawing.Size(171, 24);
            this.itemVolDown.Text = "Volume Down";
            this.itemVolDown.Click += new System.EventHandler(this.itemVolDown_Click);
            // 
            // itemMute
            // 
            this.itemMute.Name = "itemMute";
            this.itemMute.Size = new System.Drawing.Size(171, 24);
            this.itemMute.Text = "Toggle Mute";
            this.itemMute.Click += new System.EventHandler(this.itemMute_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(171, 24);
            this.itemAbout.Text = "About";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(171, 24);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // timer_ptt
            // 
            this.timer_ptt.Tick += new System.EventHandler(this.timer_ptt_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 338);
            this.Controls.Add(this.groupBox_Status);
            this.Controls.Add(this.groupBox_Settings);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Settings;
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
        private System.Windows.Forms.Button btnAppNameRefresh;
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
        private System.Windows.Forms.Button btnEndpointsRefresh;
        private System.Windows.Forms.ComboBox cmbEndpoints;
        private System.Windows.Forms.Timer timer_ptt;
    }
}

