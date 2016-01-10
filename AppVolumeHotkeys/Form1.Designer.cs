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
            this.label_Description7 = new System.Windows.Forms.Label();
            this.textBox_MuteHotkey = new System.Windows.Forms.TextBox();
            this.button_ResetHotkeys = new System.Windows.Forms.Button();
            this.button_SaveHotkeys = new System.Windows.Forms.Button();
            this.label_Description6 = new System.Windows.Forms.Label();
            this.label_Description5 = new System.Windows.Forms.Label();
            this.textBox_VolDownHotkey = new System.Windows.Forms.TextBox();
            this.textBox_VolUpHotkey = new System.Windows.Forms.TextBox();
            this.CueTextBox_AppName = new AppVolumeHotkeys.CueTextBox();
            this.numericUpDown_VolumeSteps = new System.Windows.Forms.NumericUpDown();
            this.label_Description3 = new System.Windows.Forms.Label();
            this.label_ProgramStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Description2 = new System.Windows.Forms.Label();
            this.label_Description4 = new System.Windows.Forms.Label();
            this.label_AppVolume = new System.Windows.Forms.Label();
            this.label_AppMute = new System.Windows.Forms.Label();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VolumeSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description1
            // 
            this.label_Description1.Location = new System.Drawing.Point(7, 5);
            this.label_Description1.Name = "label_Description1";
            this.label_Description1.Size = new System.Drawing.Size(407, 28);
            this.label_Description1.TabIndex = 0;
            this.label_Description1.Text = "A simple tool to control the volume of an application in the Windows Audio Mixer." +
    " Just enter a keyword from the title of the window which volume you want to cont" +
    "rol.";
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
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 34);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(207, 208);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
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
            // CueTextBox_AppName
            // 
            this.CueTextBox_AppName.Cue = "Search keywords";
            this.CueTextBox_AppName.Location = new System.Drawing.Point(6, 19);
            this.CueTextBox_AppName.Name = "CueTextBox_AppName";
            this.CueTextBox_AppName.Size = new System.Drawing.Size(121, 20);
            this.CueTextBox_AppName.TabIndex = 7;
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
            this.numericUpDown_VolumeSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_VolumeSteps_KeyPress);
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
            this.textBox1.Location = new System.Drawing.Point(228, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(171, 117);
            this.textBox1.TabIndex = 3;
            // 
            // label_Description2
            // 
            this.label_Description2.Location = new System.Drawing.Point(225, 42);
            this.label_Description2.Name = "label_Description2";
            this.label_Description2.Size = new System.Drawing.Size(174, 45);
            this.label_Description2.TabIndex = 4;
            this.label_Description2.Text = "You can set your own hotkey when you click on the desired TextBox and press the k" +
    "ey you want! ";
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Location = new System.Drawing.Point(225, 87);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(48, 26);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume: \r\nMute: ";
            // 
            // label_AppVolume
            // 
            this.label_AppVolume.AutoSize = true;
            this.label_AppVolume.Location = new System.Drawing.Point(270, 87);
            this.label_AppVolume.Name = "label_AppVolume";
            this.label_AppVolume.Size = new System.Drawing.Size(13, 13);
            this.label_AppVolume.TabIndex = 6;
            this.label_AppVolume.Text = "0";
            // 
            // label_AppMute
            // 
            this.label_AppMute.AutoSize = true;
            this.label_AppMute.Location = new System.Drawing.Point(258, 100);
            this.label_AppMute.Name = "label_AppMute";
            this.label_AppMute.Size = new System.Drawing.Size(21, 13);
            this.label_AppMute.TabIndex = 7;
            this.label_AppMute.Text = "No";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 251);
            this.Controls.Add(this.label_AppMute);
            this.Controls.Add(this.label_AppVolume);
            this.Controls.Add(this.label_Description4);
            this.Controls.Add(this.label_Description2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.label_Description1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "App Volume Hotkeys";
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
        private System.Windows.Forms.Label label_Description2;
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
    }
}

