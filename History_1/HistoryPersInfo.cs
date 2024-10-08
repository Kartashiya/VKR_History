using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace History_1
{
    public partial class HistoryPersInfo : Form
    {
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        private int personId;

        public HistoryPersInfo(int personId)
        {
            InitializeComponent();
            //GeneralInfo(personId);
            this.personId = personId;
        }

        private void HistoryPersInfo_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Получаем информацию о личности
                    string query = "SELECT pers_FIO, pers_lifeYear, pers_genInf FROM person WHERE id_person = @personId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@personId", personId);
                    MySqlDataReader personReader = command.ExecuteReader();

                    if (personReader.Read())
                    {
                        string fullName = personReader["pers_FIO"].ToString();
                        string lifeYears = personReader["pers_lifeYear"].ToString();
                        string generalInfo = personReader["pers_genInf"].ToString();

                        Name_label.Text = fullName;
                        Name_label.Text += "\n" + lifeYears;
                        Info_richTB.Text = generalInfo;

                        personReader.Close();

                        // Получаем изображения, связанные с этой личностью
                        string picturesQuery = "SELECT gallery.id_picture, gallery.pic_name, gallery.picture, type.type_name " +
                                                "FROM gallery " +
                                                "INNER JOIN person_pictures ON gallery.id_picture = person_pictures.id_picture " +
                                                "INNER JOIN type ON gallery.id_type = type.id_type " +
                                                "WHERE person_pictures.id_person = @personId";

                        MySqlCommand picturesCommand = new MySqlCommand(picturesQuery, connection);
                        picturesCommand.Parameters.AddWithValue("@personId", personId);
                        MySqlDataReader picturesReader = picturesCommand.ExecuteReader();

                        while (picturesReader.Read())
                        {
                            byte[] imageData = (byte[])picturesReader["picture"];
                            string imageName = picturesReader["pic_name"].ToString();
                            string imageType = picturesReader["type_name"].ToString(); ;

                            if (imageType == "Портрет")
                            {
                                DisplayImageInPictureBox(imageData, MainCard_picB);
                                MainCard_picB.Click += (s, er) =>
                                {
                                    FullScreenForm fullScreenForm = new FullScreenForm(MainCard_picB.Image, imageName);
                                    fullScreenForm.ShowDialog();
                                };
                            }
                            else
                            {
                                // Отображаем другие изображения в PictureBox в FlowLayoutPanel
                                DisplayImageInFlowLayoutPanel(imageData, imageName);
                            }

                        }
                        picturesReader.Close();
                    }
                    else
                        MessageBox.Show("Информация о личности не найдена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void DisplayImageInPictureBox(byte[] imageData, PictureBox pictureBox)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                    pictureBox.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отображении изображения: " + ex.Message);
            }
        }

        private void DisplayImageInFlowLayoutPanel(byte[] imageData, string imageName)
        {
            try
            {
                // Создаем новый PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 343;
                pictureBox.Height = 222;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
                // Создаем Label с именем изображения
                Label imageLabel = new Label();
                imageLabel.Text = imageName;
                //imageLabel.AutoSize = true;
                imageLabel.Width = 343;
                imageLabel.Height = 60;
                imageLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                imageLabel.TextAlign = ContentAlignment.MiddleCenter;
                //imageLabel.Width = 343;
                // Создаем новую панель для размещения PictureBox и Label
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.TopDown;
                panel.WrapContents = false;
                panel.AutoSize = true;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(imageLabel);

                pictureBox.Click += (sender, e) =>
                {
                    FullScreenForm fullScreenForm = new FullScreenForm(pictureBox.Image, imageLabel.Text);
                    fullScreenForm.ShowDialog();
                };


                Pic_flowLP.Controls.Add(panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отображении изображения: " + ex.Message);
            }
        }

        private void GenInfo_But_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Получаем информацию о личности
                    string query = "SELECT pers_genInf FROM person WHERE id_person = @personId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@personId", personId);
                    MySqlDataReader personReader = command.ExecuteReader();

                    if (personReader.Read())
                    {                        
                        string generalInfo = personReader["pers_genInf"].ToString();                                                
                        Info_richTB.Text = generalInfo;
                        personReader.Close();
                    }
                    else
                        MessageBox.Show("Информация о личности не найдена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void Reform_But_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //// Получаем информацию о личности
                    //string query = "SELECT pers_Reforms FROM person WHERE id_person = @personId";

                    // Проверяем наличие данных о реформах
                    string query = "SELECT pers_Reforms FROM person WHERE id_person = @personId AND pers_Reforms IS NOT NULL";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@personId", personId);
                    //MySqlDataReader personReader = command.ExecuteReader();

                    //if (personReader.Read())
                    //{
                    //    string reforms = personReader["pers_Reforms"].ToString();
                    //    Info_richTB.Text = reforms;
                    //    personReader.Close();
                    //}
                    //else
                    //    MessageBox.Show("Информация о личности не найдена!");

                    object reformResult = command.ExecuteScalar();

                    if (reformResult != null && reformResult != DBNull.Value)
                    {
                        string reforms = reformResult.ToString();
                        Info_richTB.Text = reforms;
                    }
                    else
                    {
                        Info_richTB.Text = "Информация о политической деятельности не найдена!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void War_But_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //// Получаем информацию о личности
                    //string query = "SELECT pers_War FROM person WHERE id_person = @personId";

                    //Проверяем наличие данных о войнах
                    string query = "SELECT pers_War FROM person WHERE id_person = @personId AND pers_War IS NOT NULL";


                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@personId", personId);
                    //MySqlDataReader personReader = command.ExecuteReader();

                    //if (personReader.Read())
                    //{
                    //    string war = personReader["pers_War"].ToString();
                    //    Info_richTB.Text = war;
                    //    personReader.Close();
                    //}
                    //else
                    //    MessageBox.Show("Информация о личности не найдена!");

                    object warResult = command.ExecuteScalar();

                    if (warResult != null && warResult != DBNull.Value)
                    {
                        string war = warResult.ToString();
                        Info_richTB.Text = war;
                    }
                    else
                    {
                        Info_richTB.Text = "Информация о войнах не найдена!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void Death_But_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Получаем информацию о личности
                    string query = "SELECT pers_Death FROM person WHERE id_person = @personId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@personId", personId);
                    MySqlDataReader personReader = command.ExecuteReader();

                    if (personReader.Read())
                    {
                        string death = personReader["pers_Death"].ToString();
                        Info_richTB.Text = death;
                        personReader.Close();
                    }
                    else
                        MessageBox.Show("Информация о личности не найдена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            HistoryPeriodInfo.ActiveForm.Hide();
            HistoryPers historyPers = new HistoryPers();
            historyPers.ShowDialog();
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
            aboutBox.ShowDialog();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPeriodInfo.ActiveForm.Hide();
            HistoryPers historyPers = new HistoryPers();
            historyPers.ShowDialog();
            Close();
        }

    }
}
