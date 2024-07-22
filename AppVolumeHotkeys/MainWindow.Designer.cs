namespace AppVolumeHotkeys
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "TEST1",
            "TestSub1",
            "TestSub2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("TEST2");
            this.lsvApps = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoApps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvApps
            // 
            this.lsvApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colVolume,
            this.colMute,
            this.colTest});
            this.lsvApps.FullRowSelect = true;
            this.lsvApps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvApps.HideSelection = false;
            this.lsvApps.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lsvApps.LargeImageList = this.imgIcons;
            this.lsvApps.Location = new System.Drawing.Point(37, 61);
            this.lsvApps.MultiSelect = false;
            this.lsvApps.Name = "lsvApps";
            this.lsvApps.Size = new System.Drawing.Size(250, 340);
            this.lsvApps.TabIndex = 3;
            this.lsvApps.TileSize = new System.Drawing.Size(246, 52);
            this.lsvApps.UseCompatibleStateImageBehavior = false;
            this.lsvApps.View = System.Windows.Forms.View.Tile;
            // 
            // imgIcons
            // 
            this.imgIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgIcons.ImageSize = new System.Drawing.Size(48, 48);
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Hotkeys";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblNoApps
            // 
            this.lblNoApps.BackColor = System.Drawing.SystemColors.Window;
            this.lblNoApps.Location = new System.Drawing.Point(51, 212);
            this.lblNoApps.Name = "lblNoApps";
            this.lblNoApps.Size = new System.Drawing.Size(220, 52);
            this.lblNoApps.TabIndex = 4;
            this.lblNoApps.Text = "No application hotkeys set up.\r\nUse the \"Add Hotkeys\" button below.";
            this.lblNoApps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.Controls.Add(this.lblNoApps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsvApps);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvApps;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colVolume;
        private System.Windows.Forms.ColumnHeader colMute;
        private System.Windows.Forms.ColumnHeader colTest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.Label lblNoApps;
    }
}

