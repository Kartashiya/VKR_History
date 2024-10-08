using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace History_1
{
    public partial class GalleryForm : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        public GalleryForm()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GalleryForm.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void GalleryForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос данных
                    string query = "SELECT pic_name, picture FROM gallery ORDER BY pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            GalleryForm.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void Portraits_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 1 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Maps_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 2 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chapters_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 3 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Period_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 4 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Conspects_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 5 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Persons_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    AllPic_flowLP.Controls.Clear();
                    Main_PicBox.Image = null;
                    Picture_name_label.Text = "Название изображения";

                    // Запрос данных
                    string query = "SELECT g.pic_name, g.picture, g.id_type " +
                                    "FROM gallery g " +
                                    "WHERE g.id_type = 6 " +
                                    "ORDER BY g.pic_name";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                    DataTable imageDataTable = new DataTable();
                    adapter.Fill(imageDataTable);

                    // Создание и добавление TabPage на основе данных из таблицы
                    foreach (DataRow imageRow in imageDataTable.Rows)
                    {
                        string picName = imageRow["pic_name"].ToString();
                        byte[] imageData = (byte[])imageRow["picture"];

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 134;
                        pictureBox.Height = 88;
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

                        // Добавление обработчика события Click для PictureBox
                        pictureBox.Click += (s, ev) =>
                        {
                            // Передача изображения и названия
                            Main_PicBox.Image = pictureBox.Image;
                            Picture_name_label.Text = picName;
                        };

                        AllPic_flowLP.Controls.Add(pictureBox);
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
    }
}
