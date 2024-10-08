namespace History_1
{
    partial class HistoryPers
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
            this.Persons_flowLP = new System.Windows.Forms.FlowLayoutPanel();
            this.Back_Link = new System.Windows.Forms.LinkLabel();
            this.Choicen_panel = new System.Windows.Forms.Panel();
            this.comboBox_Chapter = new System.Windows.Forms.ComboBox();
            this.Chapter_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Choicen_panel.SuspendLayout();
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
            // Persons_flowLP
            // 
            this.Persons_flowLP.AutoScroll = true;
            this.Persons_flowLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Persons_flowLP.Location = new System.Drawing.Point(0, 92);
            this.Persons_flowLP.Margin = new System.Windows.Forms.Padding(2);
            this.Persons_flowLP.Name = "Persons_flowLP";
            this.Persons_flowLP.Size = new System.Drawing.Size(1362, 598);
            this.Persons_flowLP.TabIndex = 1;
            // 
            // Back_Link
            // 
            this.Back_Link.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.Back_Link.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_Link.LinkColor = System.Drawing.SystemColors.ControlText;
            this.Back_Link.Location = new System.Drawing.Point(0, 25);
            this.Back_Link.Name = "Back_Link";
            this.Back_Link.Size = new System.Drawing.Size(1362, 21);
            this.Back_Link.TabIndex = 2;
            this.Back_Link.TabStop = true;
            this.Back_Link.Text = "Вернуться назад";
            this.Back_Link.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back_Link.VisitedLinkColor = System.Drawing.Color.RosyBrown;
            this.Back_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_Link_LinkClicked);
            // 
            // Choicen_panel
            // 
            this.Choicen_panel.Controls.Add(this.comboBox_Chapter);
            this.Choicen_panel.Controls.Add(this.Chapter_label);
            this.Choicen_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Choicen_panel.Location = new System.Drawing.Point(0, 46);
            this.Choicen_panel.Name = "Choicen_panel";
            this.Choicen_panel.Size = new System.Drawing.Size(1362, 46);
            this.Choicen_panel.TabIndex = 3;
            // 
            // comboBox_Chapter
            // 
            this.comboBox_Chapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Chapter.FormattingEnabled = true;
            this.comboBox_Chapter.Location = new System.Drawing.Point(140, 8);
            this.comboBox_Chapter.Name = "comboBox_Chapter";
            this.comboBox_Chapter.Size = new System.Drawing.Size(436, 28);
            this.comboBox_Chapter.TabIndex = 1;
            this.comboBox_Chapter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Chapter_SelectedIndexChanged);
            // 
            // Chapter_label
            // 
            this.Chapter_label.AutoSize = true;
            this.Chapter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chapter_label.Location = new System.Drawing.Point(3, 9);
            this.Chapter_label.Name = "Chapter_label";
            this.Chapter_label.Size = new System.Drawing.Size(131, 20);
            this.Chapter_label.TabIndex = 0;
            this.Chapter_label.Text = "Выберете главу";
            // 
            // HistoryPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.Persons_flowLP);
            this.Controls.Add(this.Choicen_panel);
            this.Controls.Add(this.Back_Link);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistoryPers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исторические личности";
            this.Load += new System.EventHandler(this.HistoryPers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Choicen_panel.ResumeLayout(false);
            this.Choicen_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel Persons_flowLP;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.LinkLabel Back_Link;
        private System.Windows.Forms.Panel Choicen_panel;
        private System.Windows.Forms.ComboBox comboBox_Chapter;
        private System.Windows.Forms.Label Chapter_label;
    }
}