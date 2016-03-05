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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label_Description1 = new System.Windows.Forms.Label();
            this.button_SetName = new System.Windows.Forms.Button();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.checkBox_showLog = new System.Windows.Forms.CheckBox();
            this.label_Description7 = new System.Windows.Forms.Label();
            this.textBox_MuteHotkey = new System.Windows.Forms.TextBox();
            this.button_ResetHotkeys = new System.Windows.Forms.Button();
            this.button_SaveHotkeys = new System.Windows.Forms.Button();
            this.label_Description6 = new System.Windows.Forms.Label();
            this.label_Description5 = new System.Windows.Forms.Label();
            this.textBox_VolDownHotkey = new System.Windows.Forms.TextBox();
            this.textBox_VolUpHotkey = new System.Windows.Forms.TextBox();
            this.numericUpDown_VolumeSteps = new System.Windows.Forms.NumericUpDown();
            this.label_Description3 = new System.Windows.Forms.Label();
            this.label_ProgramStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Description4 = new System.Windows.Forms.Label();
            this.label_AppVolume = new System.Windows.Forms.Label();
            this.label_AppMute = new System.Windows.Forms.Label();
            this.label_Description8 = new System.Windows.Forms.Label();
            this.CueTextBox_AppName = new AppVolumeHotkeys.CueTextBox();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VolumeSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description1
            // 
            this.label_Description1.Location = new System.Drawing.Point(8, 5);
            this.label_Description1.Name = "label_Description1";
            this.label_Description1.Size = new System.Drawing.Size(220, 44);
            this.label_Description1.TabIndex = 0;
            this.label_Description1.Text = "A simple tool to control the volume of an application through global Hotkeys, whi" +
    "ch you can set in the three TextBoxes below.\r\n";
            // 
            // button_SetName
            // 
            this.button_SetName.Location = new System.Drawing.Point(133, 17);
            this.button_SetName.Name = "button_SetName";
            this.button_SetName.Size = new System.Drawing.Size(68, 23);
            this.button_SetName.TabIndex = 2;
            this.button_SetName.Text = "Set Name";
            this.button_SetName.UseVisualStyleBackColor = true;
            this.button_SetName.Click += new System.EventHandler(this.button_SetName_Click);
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.checkBox_showLog);
            this.groupBox_Settings.Controls.Add(this.label_Description7);
            this.groupBox_Settings.Controls.Add(this.textBox_MuteHotkey);
            this.groupBox_Settings.Controls.Add(this.button_ResetHotkeys);
            this.groupBox_Settings.Controls.Add(this.button_SaveHotkeys);
            this.groupBox_Settings.Controls.Add(this.label_Description6);
            this.groupBox_Settings.Controls.Add(this.label_Description5);
            this.groupBox_Settings.Controls.Add(this.textBox_VolDownHotkey);
            this.groupBox_Settings.Controls.Add(this.textBox_VolUpHotkey);
            this.groupBox_Settings.Controls.Add(this.CueTextBox_AppName);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_VolumeSteps);
            this.groupBox_Settings.Controls.Add(this.label_Description3);
            this.groupBox_Settings.Controls.Add(this.label_ProgramStatus);
            this.groupBox_Settings.Controls.Add(this.button_SetName);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 46);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(207, 229);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // checkBox_showLog
            // 
            this.checkBox_showLog.AutoSize = true;
            this.checkBox_showLog.Location = new System.Drawing.Point(6, 206);
            this.checkBox_showLog.Name = "checkBox_showLog";
            this.checkBox_showLog.Size = new System.Drawing.Size(103, 17);
            this.checkBox_showLog.TabIndex = 16;
            this.checkBox_showLog.Text = "Show debug log";
            this.checkBox_showLog.UseVisualStyleBackColor = true;
            this.checkBox_showLog.CheckedChanged += new System.EventHandler(this.checkBox_showLog_CheckedChanged);
            // 
            // label_Description7
            // 
            this.label_Description7.AutoSize = true;
            this.label_Description7.Location = new System.Drawing.Point(112, 155);
            this.label_Description7.Name = "label_Description7";
            this.label_Description7.Size = new System.Drawing.Size(68, 13);
            this.label_Description7.TabIndex = 15;
            this.label_Description7.Text = "Mute Hotkey";
            // 
            // textBox_MuteHotkey
            // 
            this.textBox_MuteHotkey.Location = new System.Drawing.Point(6, 152);
            this.textBox_MuteHotkey.Name = "textBox_MuteHotkey";
            this.textBox_MuteHotkey.ReadOnly = true;
            this.textBox_MuteHotkey.Size = new System.Drawing.Size(100, 20);
            this.textBox_MuteHotkey.TabIndex = 14;
            this.textBox_MuteHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_MuteHotkey_KeyDown);
            // 
            // button_ResetHotkeys
            // 
            this.button_ResetHotkeys.Location = new System.Drawing.Point(107, 178);
            this.button_ResetHotkeys.Name = "button_ResetHotkeys";
            this.button_ResetHotkeys.Size = new System.Drawing.Size(94, 23);
            this.button_ResetHotkeys.TabIndex = 13;
            this.button_ResetHotkeys.Text = "Reset Hotkeys";
            this.button_ResetHotkeys.UseVisualStyleBackColor = true;
            this.button_ResetHotkeys.Click += new System.EventHandler(this.button_ResetHotkeys_Click);
            // 
            // button_SaveHotkeys
            // 
            this.button_SaveHotkeys.Location = new System.Drawing.Point(6, 178);
            this.button_SaveHotkeys.Name = "button_SaveHotkeys";
            this.button_SaveHotkeys.Size = new System.Drawing.Size(94, 23);
            this.button_SaveHotkeys.TabIndex = 12;
            this.button_SaveHotkeys.Text = "Save Hotkeys";
            this.button_SaveHotkeys.UseVisualStyleBackColor = true;
            this.button_SaveHotkeys.Click += new System.EventHandler(this.button_SaveHotkeys_Click);
            // 
            // label_Description6
            // 
            this.label_Description6.AutoSize = true;
            this.label_Description6.Location = new System.Drawing.Point(112, 129);
            this.label_Description6.Name = "label_Description6";
            this.label_Description6.Size = new System.Drawing.Size(87, 13);
            this.label_Description6.TabIndex = 11;
            this.label_Description6.Text = "VolDown Hotkey";
            // 
            // label_Description5
            // 
            this.label_Description5.AutoSize = true;
            this.label_Description5.Location = new System.Drawing.Point(112, 103);
            this.label_Description5.Name = "label_Description5";
            this.label_Description5.Size = new System.Drawing.Size(73, 13);
            this.label_Description5.TabIndex = 10;
            this.label_Description5.Text = "VolUp Hotkey";
            // 
            // textBox_VolDownHotkey
            // 
            this.textBox_VolDownHotkey.Location = new System.Drawing.Point(6, 126);
            this.textBox_VolDownHotkey.MaxLength = 0;
            this.textBox_VolDownHotkey.Name = "textBox_VolDownHotkey";
            this.textBox_VolDownHotkey.ReadOnly = true;
            this.textBox_VolDownHotkey.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolDownHotkey.TabIndex = 9;
            this.textBox_VolDownHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_VolDownHotkey_KeyDown);
            // 
            // textBox_VolUpHotkey
            // 
            this.textBox_VolUpHotkey.Location = new System.Drawing.Point(6, 100);
            this.textBox_VolUpHotkey.MaxLength = 0;
            this.textBox_VolUpHotkey.Name = "textBox_VolUpHotkey";
            this.textBox_VolUpHotkey.ReadOnly = true;
            this.textBox_VolUpHotkey.Size = new System.Drawing.Size(100, 20);
            this.textBox_VolUpHotkey.TabIndex = 8;
            this.textBox_VolUpHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_VolUpHotkey_KeyDown);
            // 
            // numericUpDown_VolumeSteps
            // 
            this.numericUpDown_VolumeSteps.Location = new System.Drawing.Point(6, 74);
            this.numericUpDown_VolumeSteps.Name = "numericUpDown_VolumeSteps";
            this.numericUpDown_VolumeSteps.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_VolumeSteps.TabIndex = 6;
            this.numericUpDown_VolumeSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_VolumeSteps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_VolumeSteps.ValueChanged += new System.EventHandler(this.numericUpDown_VolumeSteps_ValueChanged);
            this.numericUpDown_VolumeSteps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_VolumeSteps_KeyDown);
            // 
            // label_Description3
            // 
            this.label_Description3.AutoSize = true;
            this.label_Description3.Location = new System.Drawing.Point(49, 77);
            this.label_Description3.Name = "label_Description3";
            this.label_Description3.Size = new System.Drawing.Size(145, 13);
            this.label_Description3.TabIndex = 5;
            this.label_Description3.Text = "Enter the Volume Steps here.";
            // 
            // label_ProgramStatus
            // 
            this.label_ProgramStatus.Location = new System.Drawing.Point(3, 42);
            this.label_ProgramStatus.Name = "label_ProgramStatus";
            this.label_ProgramStatus.Size = new System.Drawing.Size(203, 27);
            this.label_ProgramStatus.TabIndex = 3;
            this.label_ProgramStatus.Text = "No application set. ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(238, 247);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1 Debug Output";
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description4.Location = new System.Drawing.Point(230, 5);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(57, 16);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume:";
            this.label_Description4.Visible = false;
            // 
            // label_AppVolume
            // 
            this.label_AppVolume.AutoSize = true;
            this.label_AppVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AppVolume.Location = new System.Drawing.Point(283, 5);
            this.label_AppVolume.Name = "label_AppVolume";
            this.label_AppVolume.Size = new System.Drawing.Size(15, 16);
            this.label_AppVolume.TabIndex = 6;
            this.label_AppVolume.Text = "0";
            this.label_AppVolume.Visible = false;
            // 
            // label_AppMute
            // 
            this.label_AppMute.AutoSize = true;
            this.label_AppMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AppMute.Location = new System.Drawing.Point(344, 5);
            this.label_AppMute.Name = "label_AppMute";
            this.label_AppMute.Size = new System.Drawing.Size(26, 16);
            this.label_AppMute.TabIndex = 7;
            this.label_AppMute.Text = "No";
            this.label_AppMute.Visible = false;
            // 
            // label_Description8
            // 
            this.label_Description8.AutoSize = true;
            this.label_Description8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description8.Location = new System.Drawing.Point(308, 5);
            this.label_Description8.Name = "label_Description8";
            this.label_Description8.Size = new System.Drawing.Size(40, 16);
            this.label_Description8.TabIndex = 8;
            this.label_Description8.Text = "Mute:";
            this.label_Description8.Visible = false;
            // 
            // CueTextBox_AppName
            // 
            this.CueTextBox_AppName.Cue = "Search keywords";
            this.CueTextBox_AppName.Location = new System.Drawing.Point(6, 19);
            this.CueTextBox_AppName.Name = "CueTextBox_AppName";
            this.CueTextBox_AppName.Size = new System.Drawing.Size(121, 20);
            this.CueTextBox_AppName.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(231, 283);
            this.Controls.Add(this.label_Description8);
            this.Controls.Add(this.label_AppMute);
            this.Controls.Add(this.label_AppVolume);
            this.Controls.Add(this.label_Description4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.label_Description1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AppVolHot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VolumeSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description1;
        private System.Windows.Forms.Button button_SetName;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_ProgramStatus;
        private System.Windows.Forms.Label label_Description3;
        private System.Windows.Forms.NumericUpDown numericUpDown_VolumeSteps;
        private CueTextBox CueTextBox_AppName;
        private System.Windows.Forms.Label label_Description4;
        private System.Windows.Forms.Label label_AppVolume;
        private System.Windows.Forms.Label label_AppMute;
        private System.Windows.Forms.Label label_Description6;
        private System.Windows.Forms.Label label_Description5;
        private System.Windows.Forms.TextBox textBox_VolDownHotkey;
        private System.Windows.Forms.TextBox textBox_VolUpHotkey;
        private System.Windows.Forms.Button button_SaveHotkeys;
        private System.Windows.Forms.Button button_ResetHotkeys;
        private System.Windows.Forms.TextBox textBox_MuteHotkey;
        private System.Windows.Forms.Label label_Description7;
        private System.Windows.Forms.Label label_Description8;
        private System.Windows.Forms.CheckBox checkBox_showLog;
    }
}

