using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace History_1
{
    public partial class HistoryPers : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";

        public HistoryPers()
        {
            InitializeComponent();
        }

        private void comboBox_Chapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Chapter.SelectedItem != null)
            {
                int selectedChapterId = (int)comboBox_Chapter.SelectedValue;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = $"SELECT p.id_person, p.pers_FIO, g.picture " +
                                       $"FROM person p " +
                                       $"JOIN person_pictures pp ON p.id_person = pp.id_person " +
                                       $"JOIN gallery g ON pp.id_picture = g.id_picture " +
                                       $"JOIN chapter_persons cp ON cp.id_person = p.id_person " +
                                       $"WHERE cp.id_chapter = {selectedChapterId} AND g.id_type = 1"; // id_type = 1 для портретов

                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Очищаем существующие элементы перед добавлением новых
                        Persons_flowLP.Controls.Clear();

                        //Добавляем исторических личностей в FlowLayoutPanel
                        foreach (DataRow row in table.Rows)
                        {
                            string personName = row["pers_FIO"].ToString();
                            byte[] imageData = (byte[])row["picture"];
                            int idPerson = (int)row["id_person"];

                            Panel personPanel = new Panel();
                            personPanel.Width = 182;
                            personPanel.Height = 287;
                            personPanel.BorderStyle = BorderStyle.FixedSingle;

                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Width = 180;
                            pictureBox.Height = 224;
                            pictureBox.Dock = DockStyle.Top;
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                            pictureBox.Tag = idPerson;
                            pictureBox.Click += pictureBox_Click;

                            Label nameLabel = new Label();
                            nameLabel.Text = personName;
                            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                            nameLabel.AutoSize = false;
                            nameLabel.Width = 180;
                            nameLabel.Height = 63;
                            nameLabel.Dock = DockStyle.Bottom;
                            nameLabel.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                            nameLabel.BackColor = Color.Lavender;
                            nameLabel.Tag = idPerson;
                            nameLabel.Click += nameLabel_Click;

                            personPanel.Controls.Add(pictureBox);
                            personPanel.Controls.Add(nameLabel);
                            Persons_flowLP.Controls.Add(personPanel);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                    }
                }
            }
        }

        private void HistoryPers_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id_chapter, chapter_name FROM chapter ORDER BY id_chapter";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    comboBox_Chapter.DisplayMember = "chapter_name";
                    comboBox_Chapter.ValueMember = "id_chapter";
                    comboBox_Chapter.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void DisplayAllHistoricalPersons()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT p.id_person, p.pers_FIO, g.picture 
                             FROM person p
                             JOIN person_pictures pp ON p.id_person = pp.id_person
                             JOIN gallery g ON pp.id_picture = g.id_picture
                             WHERE g.id_type = 1"; // Портреты имеют id_type = 1

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Очищаем панели перед добавлением новых
                    Persons_flowLP.Controls.Clear();

                    // Добавляем исторических личностей в FlowLayoutPanel
                    foreach (DataRow row in table.Rows)
                    {
                        string personName = row["pers_FIO"].ToString();
                        byte[] imageData = (byte[])row["picture"];
                        int idPerson = (int)row["id_person"];

                        Panel personPanel = new Panel();
                        personPanel.Width = 182;
                        personPanel.Height = 272;
                        personPanel.BorderStyle = BorderStyle.FixedSingle;

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 180;
                        pictureBox.Height = 224;
                        pictureBox.Dock = DockStyle.Top;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                        pictureBox.Tag = idPerson;
                        pictureBox.Click += pictureBox_Click;

                        Label nameLabel = new Label();
                        nameLabel.Text = personName;
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nameLabel.AutoSize = false;
                        nameLabel.Width = 180;
                        nameLabel.Height = 44;
                        nameLabel.Dock = DockStyle.Bottom;
                        nameLabel.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                        nameLabel.BackColor = Color.Lavender;
                        nameLabel.Tag = idPerson;
                        nameLabel.Click += nameLabel_Click;

                        personPanel.Controls.Add(pictureBox);
                        personPanel.Controls.Add(nameLabel);
                        Persons_flowLP.Controls.Add(personPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        // Обработчик события для PictureBox (клик по изображению)
        private void pictureBox_Click(object sender, EventArgs e)
        {
            // Получаем id_person из PictureBox.Tag
            PictureBox pictureBox = (PictureBox)sender;
            int idPerson = (int)pictureBox.Tag;

            // Открываем форму HistoryPersInfo с передачей id_person            
            HistoryPers.ActiveForm.Hide();
            HistoryPersInfo historyForm = new HistoryPersInfo(idPerson);
            historyForm.ShowDialog();
            Close();

        }

        // Обработчик события для Label (клик по имени)
        private void nameLabel_Click(object sender, EventArgs e)
        {
            // Получаем id_person из Label.Tag
            Label nameLabel = (Label)sender;
            int idPerson = (int)nameLabel.Tag;

            // Открываем форму HistoryPersInfo с передачей id_person
            HistoryPers.ActiveForm.Hide();
            HistoryPersInfo historyForm = new HistoryPersInfo(idPerson);
            historyForm.ShowDialog();
            Close();
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPers.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void Back_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistoryPers.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
    }
}