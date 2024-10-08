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
    public partial class ContourMaps : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        public ContourMaps()
        {
            InitializeComponent();            
        }

        private void ContourMaps_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Запрос для получения контурных карт из базы данных
                    string query = "SELECT g.pic_name, g.picture " +
                                   "FROM gallery g " +
                                   "JOIN type t ON g.id_type = t.id_type " +
                                   "WHERE t.type_name = 'Контурная карта';";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Создание PictureBox и Label для каждой контурной карты
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string picName = row["pic_name"].ToString();
                        byte[] imageData = (byte[])row["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 171;
                        pictureBox.Height = 135;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавляем обработчик события Click для PictureBox
                        //pictureBox.Click += pictureBox_Click;
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Maps_Picture.Image = pictureBox.Image;
                            label_maps_name.Text = picName;
                        };

                        Label nameLabel = new Label();
                        nameLabel.Text = picName;
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nameLabel.AutoSize = true;
                        nameLabel.Width = 165;
                        //nameLabel.Height = 23;

                        // Установка стиля шрифта для Label
                        nameLabel.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

                        // Добавление PictureBox и Label в FlowLayoutPanel
                        Maps_flowLP.Controls.Add(pictureBox);
                        Maps_flowLP.Controls.Add(nameLabel);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        //private void pictureBox_Click(object sender, EventArgs e)
        //{
        //    // Получение PictureBox, на котором произошел клик
        //    PictureBox pictureBox = (PictureBox)sender;

        //    Maps_Picture.Image = pictureBox.Image;
        //}        

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
        }

        private void ContourMaps_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ContourMaps.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void Back_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContourMaps.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
    }
}
