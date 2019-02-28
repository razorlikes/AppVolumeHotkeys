namespace AppVolumeHotkeys
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkCSCore = new System.Windows.Forms.LinkLabel();
            this.lnkFody = new System.Windows.Forms.LinkLabel();
            this.lnkCostura = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppVolumeHotkeys v2.0.0\r\n \r\nCopyright (c) 2019 by Jeremy \"razorlikes\" Nieth.\r\nRel" +
    "eased under the MIT License.\r\n\r\nOpen source licenses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CSCore by filoe: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fody by Simon Cropp: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fody Costura by Simon Cropp: ";
            // 
            // lnkCSCore
            // 
            this.lnkCSCore.AutoSize = true;
            this.lnkCSCore.Location = new System.Drawing.Point(117, 87);
            this.lnkCSCore.Name = "lnkCSCore";
            this.lnkCSCore.Size = new System.Drawing.Size(122, 13);
            this.lnkCSCore.TabIndex = 5;
            this.lnkCSCore.TabStop = true;
            this.lnkCSCore.Text = "Microsoft Public License";
            this.lnkCSCore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCSCore_LinkClicked);
            // 
            // lnkFody
            // 
            this.lnkFody.AutoSize = true;
            this.lnkFody.Location = new System.Drawing.Point(145, 100);
            this.lnkFody.Name = "lnkFody";
            this.lnkFody.Size = new System.Drawing.Size(66, 13);
            this.lnkFody.TabIndex = 6;
            this.lnkFody.TabStop = true;
            this.lnkFody.Text = "MIT License";
            this.lnkFody.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFody_LinkClicked);
            // 
            // lnkCostura
            // 
            this.lnkCostura.AutoSize = true;
            this.lnkCostura.Location = new System.Drawing.Point(184, 113);
            this.lnkCostura.Name = "lnkCostura";
            this.lnkCostura.Size = new System.Drawing.Size(66, 13);
            this.lnkCostura.TabIndex = 7;
            this.lnkCostura.TabStop = true;
            this.lnkCostura.Text = "MIT License";
            this.lnkCostura.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCostura_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.Controls.Add(this.lnkCostura);
            this.Controls.Add(this.lnkFody);
            this.Controls.Add(this.lnkCSCore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkCSCore;
        private System.Windows.Forms.LinkLabel lnkFody;
        private System.Windows.Forms.LinkLabel lnkCostura;
    }
}