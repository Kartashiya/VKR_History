using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace History_1
{
    public partial class Dictionary : Form
    {        
        //строка подключения
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        //список определений
        private List<string> definitions = new List<string>();

        public Dictionary()
        {
            InitializeComponent();            
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            LoadAlphabet();     // Загрузка букв алфавита в ComboBox
            LoadDictionary();   // Загрузка словаря
        }

        private void LoadAlphabet()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT alph_char FROM alphabet_dict ORDER BY alph_char";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string alphabetChar = reader["alph_char"].ToString();
                        comboBoxAlphabet.Items.Add(alphabetChar);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке словаря: " + ex.Message);
                }                            
            }
        }

        private void LoadDictionary()
        {
            richTB_Dictonary.Clear();
            definitions.Clear();

            using(MySqlConnection connection = new MySqlConnection( connectionString ))
            {
                try
                {
                    connection.Open();

                    string selectedAlphabetChar = comboBoxAlphabet.SelectedItem as string;

                    string query = @"SELECT alph.alph_char, dict.dict_definition
                            FROM alphabet_dict AS alph
                            INNER JOIN dictionary AS dict ON alph.id_alph = dict.id_alph";

                    // Если выбрана буква алфавита, добавляем условие WHERE
                    if (!string.IsNullOrEmpty(selectedAlphabetChar))
                        query += " WHERE alph.alph_char = @selectedAlphabetChar";

                    query += " ORDER BY alph.alph_char, dict.dict_definition";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Если выбрана буква алфавита, добавляем параметр для запроса
                    if (!string.IsNullOrEmpty(selectedAlphabetChar))
                        command.Parameters.AddWithValue("@selectedAlphabetChar", selectedAlphabetChar);
                    
                    MySqlDataReader reader = command.ExecuteReader();

                    string currentAlphabetChar = null;  //Для проверки буквы
                    bool definitionsFound = false;      //Флаг для проверки наличия определений


                    while (reader.Read())
                    {
                        string alphabetChar = reader["alph_char"].ToString();
                        string definition = reader["dict_definition"].ToString();

                        // Если текущая буква алфавита отличается от предыдущей,
                        // добавляем её в richTextBox перед определениями
                        if (currentAlphabetChar != alphabetChar)
                        {
                            if (currentAlphabetChar != null)
                            {
                                if (!definitionsFound)
                                    richTB_Dictonary.AppendText("\tОпределений нет\n");

                                richTB_Dictonary.AppendText("\n"); // Добавляем пустую строку между группами определений
                            }
                            richTB_Dictonary.AppendText("--------------------------------------------------------------------------------\n");
                            richTB_Dictonary.AppendText("\t\t\t\t\t" + alphabetChar + "\n");
                            richTB_Dictonary.AppendText("--------------------------------------------------------------------------------\n");
                            currentAlphabetChar = alphabetChar;
                            definitionsFound = false; // Сбрасываем флаг
                        }

                        // Если определение не null, добавляем его в richTextBox
                        if (!reader.IsDBNull(1))
                        {
                            richTB_Dictonary.AppendText("\t" + definition + "\n");
                            definitionsFound = true; // Устанавливаем флаг, что определение найдено
                        }
                    }

                    // Если в конце цикла нет определений для последней буквы, выводим сообщение "Определений нет"
                    if (!definitionsFound)
                    {
                        richTB_Dictonary.AppendText("\tОпределений нет\n");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке словаря: " + ex.Message);
                }
            }
            richTB_Dictonary.Select(0, 0);
            richTB_Dictonary.ScrollToCaret(); // Этот метод прокручивает контрол до текущей позиции каретки
        }

        private void comboBoxAlphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDictionary();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}