namespace History_1
{
    partial class GalleryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllPic_flowLP = new System.Windows.Forms.FlowLayoutPanel();
            this.Picture_name_label = new System.Windows.Forms.Label();
            this.Main_PicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.Persons_radBtn = new System.Windows.Forms.RadioButton();
            this.Conspects_radBtn = new System.Windows.Forms.RadioButton();
            this.Period_radBtn = new System.Windows.Forms.RadioButton();
            this.Chapters_radBtn = new System.Windows.Forms.RadioButton();
            this.Maps_radBtn = new System.Windows.Forms.RadioButton();
            this.Portraits_radBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
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
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.словарьToolStripMenuItem.Text = "Словарь";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.словарьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // AllPic_flowLP
            // 
            this.AllPic_flowLP.AutoScroll = true;
            this.AllPic_flowLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllPic_flowLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AllPic_flowLP.Location = new System.Drawing.Point(200, 577);
            this.AllPic_flowLP.Margin = new System.Windows.Forms.Padding(2);
            this.AllPic_flowLP.Name = "AllPic_flowLP";
            this.AllPic_flowLP.Size = new System.Drawing.Size(1162, 113);
            this.AllPic_flowLP.TabIndex = 1;
            this.AllPic_flowLP.WrapContents = false;
            // 
            // Picture_name_label
            // 
            this.Picture_name_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Picture_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Picture_name_label.Location = new System.Drawing.Point(200, 548);
            this.Picture_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Picture_name_label.Name = "Picture_name_label";
            this.Picture_name_label.Size = new System.Drawing.Size(1162, 29);
            this.Picture_name_label.TabIndex = 3;
            this.Picture_name_label.Text = "Наименование изображения";
            this.Picture_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_PicBox
            // 
            this.Main_PicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_PicBox.Location = new System.Drawing.Point(200, 25);
            this.Main_PicBox.Margin = new System.Windows.Forms.Padding(2);
            this.Main_PicBox.Name = "Main_PicBox";
            this.Main_PicBox.Size = new System.Drawing.Size(1162, 523);
            this.Main_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_PicBox.TabIndex = 4;
            this.Main_PicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_Btn);
            this.panel1.Controls.Add(this.Persons_radBtn);
            this.panel1.Controls.Add(this.Conspects_radBtn);
            this.panel1.Controls.Add(this.Period_radBtn);
            this.panel1.Controls.Add(this.Chapters_radBtn);
            this.panel1.Controls.Add(this.Maps_radBtn);
            this.panel1.Controls.Add(this.Portraits_radBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox_icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 665);
            this.panel1.TabIndex = 5;
            // 
            // Back_Btn
            // 
            this.Back_Btn.BackColor = System.Drawing.Color.Thistle;
            this.Back_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_Btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Back_Btn.Location = new System.Drawing.Point(0, 570);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(200, 55);
            this.Back_Btn.TabIndex = 19;
            this.Back_Btn.Text = "Назад";
            this.Back_Btn.UseVisualStyleBackColor = false;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // Persons_radBtn
            // 
            this.Persons_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Persons_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Persons_radBtn.Location = new System.Drawing.Point(0, 502);
            this.Persons_radBtn.Name = "Persons_radBtn";
            this.Persons_radBtn.Size = new System.Drawing.Size(200, 68);
            this.Persons_radBtn.TabIndex = 18;
            this.Persons_radBtn.Text = "исторические личности";
            this.Persons_radBtn.UseVisualStyleBackColor = true;
            this.Persons_radBtn.CheckedChanged += new System.EventHandler(this.Persons_radBtn_CheckedChanged);
            // 
            // Conspects_radBtn
            // 
            this.Conspects_radBtn.AutoSize = true;
            this.Conspects_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Conspects_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conspects_radBtn.Location = new System.Drawing.Point(0, 461);
            this.Conspects_radBtn.Name = "Conspects_radBtn";
            this.Conspects_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Conspects_radBtn.Size = new System.Drawing.Size(200, 41);
            this.Conspects_radBtn.TabIndex = 17;
            this.Conspects_radBtn.Text = "конспекты";
            this.Conspects_radBtn.UseVisualStyleBackColor = true;
            this.Conspects_radBtn.CheckedChanged += new System.EventHandler(this.Conspects_radBtn_CheckedChanged);
            // 
            // Period_radBtn
            // 
            this.Period_radBtn.AutoSize = true;
            this.Period_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Period_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Period_radBtn.Location = new System.Drawing.Point(0, 420);
            this.Period_radBtn.Name = "Period_radBtn";
            this.Period_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Period_radBtn.Size = new System.Drawing.Size(200, 41);
            this.Period_radBtn.TabIndex = 16;
            this.Period_radBtn.Text = "темы";
            this.Period_radBtn.UseVisualStyleBackColor = true;
            this.Period_radBtn.CheckedChanged += new System.EventHandler(this.Period_radBtn_CheckedChanged);
            // 
            // Chapters_radBtn
            // 
            this.Chapters_radBtn.AutoSize = true;
            this.Chapters_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chapters_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chapters_radBtn.Location = new System.Drawing.Point(0, 379);
            this.Chapters_radBtn.Name = "Chapters_radBtn";
            this.Chapters_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Chapters_radBtn.Size = new System.Drawing.Size(200, 41);
            this.Chapters_radBtn.TabIndex = 15;
            this.Chapters_radBtn.Text = "главы";
            this.Chapters_radBtn.UseVisualStyleBackColor = true;
            this.Chapters_radBtn.CheckedChanged += new System.EventHandler(this.Chapters_radBtn_CheckedChanged);
            // 
            // Maps_radBtn
            // 
            this.Maps_radBtn.AutoSize = true;
            this.Maps_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maps_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maps_radBtn.Location = new System.Drawing.Point(0, 338);
            this.Maps_radBtn.Name = "Maps_radBtn";
            this.Maps_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Maps_radBtn.Size = new System.Drawing.Size(200, 41);
            this.Maps_radBtn.TabIndex = 14;
            this.Maps_radBtn.Text = "контурные карты";
            this.Maps_radBtn.UseVisualStyleBackColor = true;
            this.Maps_radBtn.CheckedChanged += new System.EventHandler(this.Maps_radBtn_CheckedChanged);
            // 
            // Portraits_radBtn
            // 
            this.Portraits_radBtn.AutoSize = true;
            this.Portraits_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Portraits_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Portraits_radBtn.Location = new System.Drawing.Point(0, 297);
            this.Portraits_radBtn.Name = "Portraits_radBtn";
            this.Portraits_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Portraits_radBtn.Size = new System.Drawing.Size(200, 41);
            this.Portraits_radBtn.TabIndex = 13;
            this.Portraits_radBtn.Text = "портреты";
            this.Portraits_radBtn.UseVisualStyleBackColor = true;
            this.Portraits_radBtn.CheckedChanged += new System.EventHandler(this.Portraits_radBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 93);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выбор изображений";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(200, 204);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // GalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.Main_PicBox);
            this.Controls.Add(this.Picture_name_label);
            this.Controls.Add(this.AllPic_flowLP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GalleryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Галерея";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GalleryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel AllPic_flowLP;
        private System.Windows.Forms.Label Picture_name_label;
        private System.Windows.Forms.PictureBox Main_PicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Portraits_radBtn;
        private System.Windows.Forms.RadioButton Conspects_radBtn;
        private System.Windows.Forms.RadioButton Period_radBtn;
        private System.Windows.Forms.RadioButton Chapters_radBtn;
        private System.Windows.Forms.RadioButton Maps_radBtn;
        private System.Windows.Forms.RadioButton Persons_radBtn;
        private System.Windows.Forms.Button Back_Btn;
    }
}