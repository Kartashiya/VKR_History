using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace History_1
{
    public partial class MainForm : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_chapter, chapter_name, id_picture FROM chapter;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int idChapter = Convert.ToInt32(row["id_chapter"]);
                        string chapterName = row["chapter_name"].ToString();
                        int idPicture = Convert.ToInt32(row["id_picture"]);

                        // Создание новой панели для каждой главы
                        Panel panel = new Panel();
                        panel.Width = 439;
                        panel.Height = 377;
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        // Создание PictureBox для изображения главы
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 437;
                        pictureBox.Height = 331;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox.Image = LoadImageFromDatabase(idPicture); // Загрузка изображения из базы данных

                        // Создание Label для названия главы
                        Label label = new Label();
                        label.Text = chapterName;
                        label.AutoSize = false;
                        label.Dock = DockStyle.Bottom;
                        label.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        label.BackColor = Color.FromArgb(244, 237, 245);
                        label.Width = 437;
                        label.Height = 44;
                        label.TextAlign = ContentAlignment.MiddleCenter;

                        // Добавление обработчика события Click для PictureBox и Label
                        pictureBox.Click += (s, ev) => OpenHistoryPeriod(idChapter);
                        label.Click += (s, ev) => OpenHistoryPeriod(idChapter);

                        // Добавление элементов на панель
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);

                        // Добавление панели в FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки глав: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenHistoryPeriod(int idChapter)
        {
            MainForm.ActiveForm.Hide();
            HistoryPeriod historyPeriodForm = new HistoryPeriod(idChapter);
            historyPeriodForm.ShowDialog();
            Close();
        }

        private Image LoadImageFromDatabase(int idPicture)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT picture FROM gallery WHERE id_picture = @idPicture;";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPicture", idPicture);

                byte[] imageData = (byte[])command.ExecuteScalar();
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void словарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
        }

        private void btnHistoryPers_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            HistoryPers historyPers = new HistoryPers();
            historyPers.ShowDialog();
            Close();
        }

        private void btnMaps_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            ContourMaps mappers = new ContourMaps();
            mappers.ShowDialog();
            Close();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            GalleryForm galleryForm = new GalleryForm();
            galleryForm.ShowDialog();
            Close();
        }
        
        private void btnTests_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Hide();
            TestForm testForm = new TestForm();
            testForm.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
