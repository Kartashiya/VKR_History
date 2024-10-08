namespace History_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_mainPage = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTests = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnMaps = new System.Windows.Forms.Button();
            this.btnHistoryPers = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.menuStrip_mainPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_mainPage
            // 
            this.menuStrip_mainPage.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip_mainPage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_mainPage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_mainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip_mainPage.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_mainPage.Name = "menuStrip_mainPage";
            this.menuStrip_mainPage.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_mainPage.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip_mainPage.TabIndex = 1;
            this.menuStrip_mainPage.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.словарьToolStripMenuItem.Text = "Словарь";
            this.словарьToolStripMenuItem.Click += new System.EventHandler(this.словарьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1362, 566);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnTests
            // 
            this.btnTests.BackColor = System.Drawing.Color.Lavender;
            this.btnTests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnTests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTests.Location = new System.Drawing.Point(686, 3);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(655, 43);
            this.btnTests.TabIndex = 5;
            this.btnTests.Text = "Тестирование";
            this.btnTests.UseVisualStyleBackColor = false;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // btnGallery
            // 
            this.btnGallery.BackColor = System.Drawing.Color.Lavender;
            this.btnGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnGallery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGallery.Location = new System.Drawing.Point(686, 52);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(655, 40);
            this.btnGallery.TabIndex = 6;
            this.btnGallery.Text = "Галерея";
            this.btnGallery.UseVisualStyleBackColor = false;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // btnMaps
            // 
            this.btnMaps.BackColor = System.Drawing.Color.Lavender;
            this.btnMaps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnMaps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaps.Location = new System.Drawing.Point(3, 52);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(677, 40);
            this.btnMaps.TabIndex = 4;
            this.btnMaps.Text = "Контурные карты";
            this.btnMaps.UseVisualStyleBackColor = false;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // btnHistoryPers
            // 
            this.btnHistoryPers.BackColor = System.Drawing.Color.Lavender;
            this.btnHistoryPers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LavenderBlush;
            this.btnHistoryPers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnHistoryPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistoryPers.Location = new System.Drawing.Point(0, 3);
            this.btnHistoryPers.Name = "btnHistoryPers";
            this.btnHistoryPers.Size = new System.Drawing.Size(681, 43);
            this.btnHistoryPers.TabIndex = 3;
            this.btnHistoryPers.Text = "Исторические личности";
            this.btnHistoryPers.UseVisualStyleBackColor = false;
            this.btnHistoryPers.Click += new System.EventHandler(this.btnHistoryPers_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHistoryPers);
            this.panel8.Controls.Add(this.btnGallery);
            this.panel8.Controls.Add(this.btnMaps);
            this.panel8.Controls.Add(this.btnTests);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 590);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1362, 100);
            this.panel8.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.menuStrip_mainPage);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip_mainPage;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История России 9 класс";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip_mainPage.ResumeLayout(false);
            this.menuStrip_mainPage.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip_mainPage;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.Button btnHistoryPers;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel8;
    }
}

