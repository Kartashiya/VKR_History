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

namespace History_1
{
    public partial class HistoryPeriod : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        private int selectedChapterId;
        public HistoryPeriod(int id_chapter)
        {
            InitializeComponent();
            selectedChapterId = id_chapter;
            Load_HistoryPeriod(selectedChapterId);            
        }

        private void Load_HistoryPeriod(int id_chapter)
        {            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) 
                {
                    connection.Open();

                    // Запрос данных для тем выбранной главы (по переданному id_chapter)
                    string query = "SELECT t.id_topic, t.topic_name, t.topic_desc, g.pic_name, g.picture " +
                                   "FROM topic t " +
                                   "INNER JOIN gallery g ON t.id_picture = g.id_picture " +
                                   "WHERE t.id_chapter = @id_chapter";
                    
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id_chapter", id_chapter);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Создание и добавление элементов на форму для каждой темы
                    while (reader.Read())
                    {
                        int idTopic = reader.GetInt32("id_topic");
                        string topicName = reader.GetString("topic_name");
                        string topicDesc = reader.GetString("topic_desc");
                        string picName = reader.GetString("pic_name");
                        byte[] imageData = (byte[])reader["picture"];
                                                
                        // Создание новой панели для каждой темы
                        Panel panel = new Panel();
                        panel.Width = 271;
                        panel.Height = 613;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                                                
                        // Создание PictureBox для изображения темы
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Dock = DockStyle.Top;                    
                        pictureBox.Width = 269;
                        pictureBox.Height = 202;
                        pictureBox.BackColor = Color.FromArgb(244, 237, 245);
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                        pictureBox.Click += (s, ev) =>
                        {
                            // Открытие формы HistoryPeriodInfo при нажатии на кнопку
                            HistoryPeriod.ActiveForm.Hide();
                            HistoryPeriodInfo historyPeriodInfoForm = new HistoryPeriodInfo(id_chapter, idTopic);
                            historyPeriodInfoForm.ShowDialog();
                            Close();
                        };

                        // Создание Label для названия темы
                        Label nameLabel = new Label();
                        nameLabel.Text = topicName;
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nameLabel.Dock = DockStyle.Bottom;
                        nameLabel.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        nameLabel.Dock = DockStyle.Top;
                        nameLabel.AutoSize = false;
                        nameLabel.Width = 269;
                        nameLabel.Height = 52;


                        // Создание RichTextBox для описания темы
                        RichTextBox descriptionBox = new RichTextBox();
                        descriptionBox.Text = topicDesc;
                        descriptionBox.ReadOnly = true;
                        descriptionBox.ScrollBars = RichTextBoxScrollBars.Vertical;
                        descriptionBox.Dock = DockStyle.Fill;
                        descriptionBox.Font = new Font("Microsoft Sans Serif", 13);                        
                        descriptionBox.Width = 269;
                        descriptionBox.Height = 362;
                        descriptionBox.BorderStyle = BorderStyle.None;
                        descriptionBox.BackColor = Color.FromArgb(244, 237, 245);

                        // Создание Button для открытия дополнительной информации
                        Button button = new Button();
                        button.Text = "Изучить";
                        button.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        button.BackColor = Color.Lavender;
                        button.FlatStyle = FlatStyle.Popup;
                        button.Height = 37;
                        button.Dock = DockStyle.Bottom;
                        button.Click += (s, ev) =>
                        {
                            // Открытие формы HistoryPeriodInfo при нажатии на кнопку
                            HistoryPeriod.ActiveForm.Hide();                            
                            HistoryPeriodInfo historyPeriodInfoForm = new HistoryPeriodInfo(id_chapter, idTopic);
                            historyPeriodInfoForm.ShowDialog();
                            Close();
                        };

                        // Добавление элементов на Panel
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(descriptionBox);
                        panel.Controls.Add(button);

                        // Установка RichTextBox как верхний слой
                        descriptionBox.BringToFront();

                        // Добавление Panel на FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                    reader.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
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
            HistoryPeriod.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }       

        private void Back_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistoryPeriod.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
    }
}
