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
            this.button_SetName.Location = new System.Drawing.Point(133, 19);
            this.button_SetName.Name = "button_SetName";
            this.button_SetName.Size = new System.Drawing.Size(68, 20);
            this.button_SetName.TabIndex = 2;
            this.button_SetName.Text = "Set Name";
            this.button_SetName.UseVisualStyleBackColor = true;
            this.button_SetName.Click += new System.EventHandler(this.button_SetName_Click);
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.CueTextBox_AppName);
            this.groupBox_Settings.Controls.Add(this.numericUpDown_VolumeSteps);
            this.groupBox_Settings.Controls.Add(this.label_Description3);
            this.groupBox_Settings.Controls.Add(this.label_ProgramStatus);
            this.groupBox_Settings.Controls.Add(this.button_SetName);
            this.groupBox_Settings.Location = new System.Drawing.Point(12, 34);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(207, 140);
            this.groupBox_Settings.TabIndex = 2;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
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
            this.textBox1.Location = new System.Drawing.Point(12, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(387, 176);
            this.textBox1.TabIndex = 3;
            // 
            // label_Description2
            // 
            this.label_Description2.Location = new System.Drawing.Point(225, 42);
            this.label_Description2.Name = "label_Description2";
            this.label_Description2.Size = new System.Drawing.Size(174, 45);
            this.label_Description2.TabIndex = 4;
            this.label_Description2.Text = "Preset Hotkeys are \'PageUp\' for Volume UP and \'PageDown\' for Volume DOWN right no" +
    "w.";
            // 
            // label_Description4
            // 
            this.label_Description4.AutoSize = true;
            this.label_Description4.Location = new System.Drawing.Point(224, 98);
            this.label_Description4.Name = "label_Description4";
            this.label_Description4.Size = new System.Drawing.Size(48, 26);
            this.label_Description4.TabIndex = 5;
            this.label_Description4.Text = "Volume: \r\nMute: ";
            // 
            // label_AppVolume
            // 
            this.label_AppVolume.AutoSize = true;
            this.label_AppVolume.Location = new System.Drawing.Point(269, 98);
            this.label_AppVolume.Name = "label_AppVolume";
            this.label_AppVolume.Size = new System.Drawing.Size(13, 13);
            this.label_AppVolume.TabIndex = 6;
            this.label_AppVolume.Text = "0";
            // 
            // label_AppMute
            // 
            this.label_AppMute.AutoSize = true;
            this.label_AppMute.Location = new System.Drawing.Point(257, 111);
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
            this.ClientSize = new System.Drawing.Size(411, 379);
            this.Controls.Add(this.label_AppMute);
            this.Controls.Add(this.label_AppVolume);
            this.Controls.Add(this.label_Description4);
            this.Controls.Add(this.label_Description2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.label_Description1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "App Volume Hotkeys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
    }
}

