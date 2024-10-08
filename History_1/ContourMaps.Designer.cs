namespace History_1
{
    partial class ContourMaps
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Maps_flowLP = new System.Windows.Forms.FlowLayoutPanel();
            this.Maps_Picture = new System.Windows.Forms.PictureBox();
            this.Back_Link = new System.Windows.Forms.LinkLabel();
            this.label_maps_name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maps_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.словарьToolStripMenuItem.Text = "Словарь";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.словарьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Maps_flowLP
            // 
            this.Maps_flowLP.AutoScroll = true;
            this.Maps_flowLP.Dock = System.Windows.Forms.DockStyle.Left;
            this.Maps_flowLP.Location = new System.Drawing.Point(0, 25);
            this.Maps_flowLP.Margin = new System.Windows.Forms.Padding(2);
            this.Maps_flowLP.Name = "Maps_flowLP";
            this.Maps_flowLP.Size = new System.Drawing.Size(200, 665);
            this.Maps_flowLP.TabIndex = 1;
            // 
            // Maps_Picture
            // 
            this.Maps_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maps_Picture.Location = new System.Drawing.Point(200, 92);
            this.Maps_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.Maps_Picture.Name = "Maps_Picture";
            this.Maps_Picture.Size = new System.Drawing.Size(1162, 598);
            this.Maps_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maps_Picture.TabIndex = 2;
            this.Maps_Picture.TabStop = false;
            // 
            // Back_Link
            // 
            this.Back_Link.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.Back_Link.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Link.LinkColor = System.Drawing.SystemColors.ControlText;
            this.Back_Link.Location = new System.Drawing.Point(200, 25);
            this.Back_Link.Name = "Back_Link";
            this.Back_Link.Size = new System.Drawing.Size(1162, 23);
            this.Back_Link.TabIndex = 3;
            this.Back_Link.TabStop = true;
            this.Back_Link.Text = "Вернуться назад";
            this.Back_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_Link.VisitedLinkColor = System.Drawing.Color.RosyBrown;
            this.Back_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_Link_LinkClicked);
            // 
            // label_maps_name
            // 
            this.label_maps_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_maps_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_maps_name.Location = new System.Drawing.Point(200, 48);
            this.label_maps_name.Name = "label_maps_name";
            this.label_maps_name.Size = new System.Drawing.Size(1162, 44);
            this.label_maps_name.TabIndex = 4;
            this.label_maps_name.Text = "Наименование контурной карты";
            this.label_maps_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContourMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.Maps_Picture);
            this.Controls.Add(this.label_maps_name);
            this.Controls.Add(this.Back_Link);
            this.Controls.Add(this.Maps_flowLP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContourMaps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контурные карты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContourMaps_FormClosed);
            this.Load += new System.EventHandler(this.ContourMaps_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maps_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel Maps_flowLP;
        private System.Windows.Forms.PictureBox Maps_Picture;
        private System.Windows.Forms.LinkLabel Back_Link;
        private System.Windows.Forms.Label label_maps_name;
    }
}