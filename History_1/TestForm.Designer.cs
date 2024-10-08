namespace History_1
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.menuStrip_mainPage = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.Topic_test_radBtn = new System.Windows.Forms.RadioButton();
            this.Chapter_test_radBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Choice_test_panel = new System.Windows.Forms.Panel();
            this.StartTest_Btn = new System.Windows.Forms.Button();
            this.comboBoxTests = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.question_panel = new System.Windows.Forms.Panel();
            this.menuStrip_mainPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Choice_test_panel.SuspendLayout();
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
            this.menuStrip_mainPage.TabIndex = 2;
            this.menuStrip_mainPage.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_Btn);
            this.panel1.Controls.Add(this.Topic_test_radBtn);
            this.panel1.Controls.Add(this.Chapter_test_radBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 666);
            this.panel1.TabIndex = 3;
            // 
            // Back_Btn
            // 
            this.Back_Btn.BackColor = System.Drawing.Color.Thistle;
            this.Back_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_Btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Back_Btn.Location = new System.Drawing.Point(0, 361);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(208, 55);
            this.Back_Btn.TabIndex = 10;
            this.Back_Btn.Text = "Назад";
            this.Back_Btn.UseVisualStyleBackColor = false;
            this.Back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // Topic_test_radBtn
            // 
            this.Topic_test_radBtn.AutoSize = true;
            this.Topic_test_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topic_test_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Topic_test_radBtn.Location = new System.Drawing.Point(0, 295);
            this.Topic_test_radBtn.Name = "Topic_test_radBtn";
            this.Topic_test_radBtn.Padding = new System.Windows.Forms.Padding(0, 10, 0, 30);
            this.Topic_test_radBtn.Size = new System.Drawing.Size(208, 66);
            this.Topic_test_radBtn.TabIndex = 13;
            this.Topic_test_radBtn.Text = "по темам";
            this.Topic_test_radBtn.UseVisualStyleBackColor = true;
            this.Topic_test_radBtn.CheckedChanged += new System.EventHandler(this.Topic_test_radBtn_CheckedChanged);
            // 
            // Chapter_test_radBtn
            // 
            this.Chapter_test_radBtn.AutoSize = true;
            this.Chapter_test_radBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chapter_test_radBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chapter_test_radBtn.Location = new System.Drawing.Point(0, 254);
            this.Chapter_test_radBtn.Name = "Chapter_test_radBtn";
            this.Chapter_test_radBtn.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.Chapter_test_radBtn.Size = new System.Drawing.Size(208, 41);
            this.Chapter_test_radBtn.TabIndex = 12;
            this.Chapter_test_radBtn.Text = "по главам";
            this.Chapter_test_radBtn.UseVisualStyleBackColor = true;
            this.Chapter_test_radBtn.CheckedChanged += new System.EventHandler(this.Chapter_test_radBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тестирование";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureBox1.Size = new System.Drawing.Size(208, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Choice_test_panel
            // 
            this.Choice_test_panel.AutoSize = true;
            this.Choice_test_panel.Controls.Add(this.StartTest_Btn);
            this.Choice_test_panel.Controls.Add(this.comboBoxTests);
            this.Choice_test_panel.Controls.Add(this.label1);
            this.Choice_test_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Choice_test_panel.Location = new System.Drawing.Point(208, 24);
            this.Choice_test_panel.Name = "Choice_test_panel";
            this.Choice_test_panel.Size = new System.Drawing.Size(1154, 36);
            this.Choice_test_panel.TabIndex = 4;
            // 
            // StartTest_Btn
            // 
            this.StartTest_Btn.BackColor = System.Drawing.Color.Lavender;
            this.StartTest_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTest_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTest_Btn.Location = new System.Drawing.Point(674, 3);
            this.StartTest_Btn.Name = "StartTest_Btn";
            this.StartTest_Btn.Size = new System.Drawing.Size(468, 30);
            this.StartTest_Btn.TabIndex = 2;
            this.StartTest_Btn.Text = "Начать тестирование";
            this.StartTest_Btn.UseVisualStyleBackColor = false;
            this.StartTest_Btn.Click += new System.EventHandler(this.StartTest_Btn_Click);
            // 
            // comboBoxTests
            // 
            this.comboBoxTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTests.FormattingEnabled = true;
            this.comboBoxTests.Location = new System.Drawing.Point(123, 5);
            this.comboBoxTests.Name = "comboBoxTests";
            this.comboBoxTests.Size = new System.Drawing.Size(545, 28);
            this.comboBoxTests.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете тест";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // question_panel
            // 
            this.question_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question_panel.Location = new System.Drawing.Point(208, 60);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(1154, 630);
            this.question_panel.TabIndex = 5;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1362, 690);
            this.Controls.Add(this.question_panel);
            this.Controls.Add(this.Choice_test_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_mainPage);
            this.MaximizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.menuStrip_mainPage.ResumeLayout(false);
            this.menuStrip_mainPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Choice_test_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_mainPage;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Choice_test_panel;
        private System.Windows.Forms.ComboBox comboBoxTests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel question_panel;
        private System.Windows.Forms.Button StartTest_Btn;
        private System.Windows.Forms.RadioButton Chapter_test_radBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Topic_test_radBtn;
    }
}