using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace History_1
{
    public partial class HistoryPeriodInfo : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        private int id_chapter;
        public HistoryPeriodInfo(int id_chapter, int id_topic)
        {
            InitializeComponent();
            Load_HistoryPeriodInfo(id_topic);
            this.id_chapter = id_chapter;
        }

        private void Load_HistoryPeriodInfo(int id_topic)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос данных из таблицы topicinfo
                    string query = "SELECT ti.id_topinfo, ti.topinfo_name, ti.topinfo_text " +
                           "FROM topicinfo ti " +
                           "WHERE ti.id_topic = @id_topic";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_topic", id_topic);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int idTopinfo = Convert.ToInt32(row["id_topinfo"]);

                        string topicinfoName = row["topinfo_name"].ToString();
                        string topicinfoText = row["topinfo_text"].ToString();

                        // Создание новой TabPage
                        TabPage tabPage = new TabPage();
                        tabPage.Text = topicinfoName;                        

                        // Создание нового RichTextBox для отображения текста
                        RichTextBox richTextBox = new RichTextBox();
                        richTextBox.Dock = DockStyle.Fill;
                        richTextBox.Text = topicinfoText;
                        richTextBox.ReadOnly = true;
                        richTextBox.BackColor = Color.FromArgb(244, 237, 245);
                        richTextBox.Font = new Font("Microsoft Sans Serif", 12);
                        richTextBox.BorderStyle = BorderStyle.None;

                        // Добавление RichTextBox на TabPage
                        tabPage.Controls.Add(richTextBox);


                        // Проверка наличия изображений для текущего конспекта
                        query = "SELECT g.pic_name, g.picture " +
                                "FROM gallery g " +
                                "INNER JOIN topinfo_pictures tp ON g.id_picture = tp.id_picture " +
                                "WHERE tp.id_topinfo = @idTopinfo";

                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idTopinfo", idTopinfo);
                        DataTable imageDataTable = new DataTable();
                        adapter.SelectCommand = command;
                        adapter.Fill(imageDataTable);

                        // Если есть изображения, создаем FlowLayoutPanel и добавляем на TabPage
                        if (imageDataTable.Rows.Count > 0)
                        {
                            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                            flowLayoutPanel.Dock = DockStyle.Right;
                            flowLayoutPanel.AutoScroll = true;
                            flowLayoutPanel.Width = 507;
                            tabPage.Controls.Add(flowLayoutPanel);

                            // Добавление изображений в FlowLayoutPanel
                            foreach (DataRow imageRow in imageDataTable.Rows)
                            {
                                string picName = imageRow["pic_name"].ToString();
                                byte[] imageData = (byte[])imageRow["picture"];

                                PictureBox pictureBox = new PictureBox();
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.Width = 482;
                                pictureBox.Height = 349;
                                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                                Label label = new Label();
                                label.Text = picName;
                                label.TextAlign = ContentAlignment.MiddleCenter;
                                label.Width = 482;
                                label.Height = 40;
                                //label.AutoSize = true;
                                label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

                                // Добавление обработчика события Click для PictureBox
                                pictureBox.Click += (s, ev) =>
                                {
                                    // Передача изображения и названия
                                    FullScreenForm fullScreenForm = new FullScreenForm(pictureBox.Image, picName);
                                    fullScreenForm.ShowDialog();
                                };

                                flowLayoutPanel.Controls.Add(pictureBox);
                                flowLayoutPanel.Controls.Add(label);
                            }
                        }
                        // Добавление TabPage на TabControl
                        tabControl1.TabPages.Add(tabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPeriodInfo.ActiveForm.Hide();
            HistoryPeriod historyPeriod = new HistoryPeriod(id_chapter);
            historyPeriod.ShowDialog();
            Close();
        }

        private void Back_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistoryPeriodInfo.ActiveForm.Hide();
            HistoryPeriod historyPeriod = new HistoryPeriod(id_chapter);
            historyPeriod.ShowDialog();
            Close();
        }
    }
}
