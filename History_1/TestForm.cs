using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace History_1
{
    public partial class TestForm : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;uid=root;database=history;port=3306;charset=utf8mb4";
        int correct_answ = 0;                   // Сумма правильных ответов
        private bool answerSelected = false;    // Флаг для отслеживания выбора ответа

        private List<int> questionIds;          // Список идентификаторов вопросов для выбранного теста
        private int currentQuestionIndex = 0;   // Индекс текущего вопроса
        private int IDQuestion;

        Label lblQuestion = new Label();

        public TestForm()
        {
            InitializeComponent();
            InitializeConnection();
        }

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Метод для открытия соединения с базой данных
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Метод для закрытия соединения с базой данных
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Chapter_test_radBtn.Checked = true;
            LoadTestsByType("chapter");
        }

        private void Chapter_test_radBtn_CheckedChanged(object sender, EventArgs e)
        {

            LoadTestsByType("chapter");

        }

        private void Topic_test_radBtn_CheckedChanged(object sender, EventArgs e)
        {
            LoadTestsByType("topic");

        }

        // Загрузка тестов согласно их типу
        private void LoadTestsByType(string type)
        {
            if (OpenConnection())
            {
                comboBoxTests.Items.Clear();

                string query = "";
                if (type == "chapter")
                {
                    query = "SELECT test_name FROM tests " +
                            "INNER JOIN tests_chapter ON tests.id_test = tests_chapter.id_test";
                }
                else if (type == "topic")
                {
                    query = "SELECT test_name FROM tests " +
                            "INNER JOIN test_topic ON tests.id_test = test_topic.id_test";
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comboBoxTests.Items.Add(dataReader["test_name"].ToString());
                }

                dataReader.Close();
                CloseConnection();

                // Выбрать первый элемент в ComboBox, если есть элементы в списке
                if (comboBoxTests.Items.Count > 0)
                {
                    comboBoxTests.SelectedIndex = 0;
                }
            }
        }

        // Кнопка "Начать тестирование"
        private void StartTest_Btn_Click(object sender, EventArgs e)
        {
            if (comboBoxTests.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тест из списка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StartTest_Btn.Enabled = false;
            Chapter_test_radBtn.Enabled = false;
            Topic_test_radBtn.Enabled = false;

            string testName = comboBoxTests.SelectedItem.ToString();

            if (OpenConnection())
            {
                string queryTestId = $"SELECT id_test FROM tests WHERE test_name = '{testName}'";
                MySqlCommand cmdTestId = new MySqlCommand(queryTestId, connection);
                int testId = Convert.ToInt32(cmdTestId.ExecuteScalar());

                LoadRandomQuestionsForTest(testId, 10); // Загружаем список вопросов для выбранного теста

                if (questionIds != null && questionIds.Count > 0)
                {
                    int firstQuestionId = questionIds[0]; // Получаем ID первого вопроса
                    ShowQuestion(firstQuestionId); // Отображаем первый вопрос
                }
                else
                {
                    MessageBox.Show("Выбранный тест не содержит вопросов.");
                }

                CloseConnection();
            }
        }

        // Отображение следующего вопроса и завершение тестирования
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questionIds.Count)
            {
                // Отобразить следующий вопрос
                int questionId = questionIds[currentQuestionIndex];
                ShowQuestion(questionId);
            }
            else
            {
                MessageBox.Show("Тест пройден! Правильных ответов: " + correct_answ); // Сообщение о завершении теста

                // Разблокировка элементов формы для нового теста
                StartTest_Btn.Enabled = true;
                Chapter_test_radBtn.Enabled = true;
                Topic_test_radBtn.Enabled = true;

                // Сброс переменных и подготовка к новому тесту
                currentQuestionIndex = 0;
                correct_answ = 0;
                answerSelected = false;
            }
        }

        // Отображение вопроса
        private void ShowQuestion(int questionId)
        {
            IDQuestion = questionId;

            string queryQuestion = $"SELECT quest_text FROM questions WHERE id_question = {questionId}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmdQuestion = new MySqlCommand(queryQuestion, connection))
                {
                    string questionText = cmdQuestion.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(questionText))
                    {
                        // Создаем TableLayoutPanel для организации элементов
                        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                        tableLayoutPanel.Dock = DockStyle.Fill; // Занимает всю доступную площадь панели
                        tableLayoutPanel.AutoSize = true; // Автоматический размер для подгонки размеров элементов
                        tableLayoutPanel.ColumnCount = 2; // Два столбца

                        // Установка ширины столбцов (50% каждый)
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                        // Устанавливаем высоту каждой строки
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Высота первой строки
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Высота второй строки
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Высота третьей строки
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Высота 4 строки
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Высота 5 строки

                        // Добавляем Label с текстом вопроса на TableLayoutPanel
                        lblQuestion.Text = questionText;
                        lblQuestion.Width = 1154;
                        lblQuestion.Height = 225;
                        lblQuestion.Font = new Font("Inter SemiBold", 25, FontStyle.Bold);
                        lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
                        //lblQuestion.AutoSize = true;

                        // Добавляем Label в первую строку, первый столбец с объединением ячейки по столбцам
                        tableLayoutPanel.Controls.Add(lblQuestion, 0, 0);
                        tableLayoutPanel.SetColumnSpan(lblQuestion, 2); // Объединяем ячейки на два столбца

                        // Получаем варианты ответов на заданный вопрос
                        string queryAnswers = $"SELECT answ_text, answ_corr FROM answers WHERE id_question = {questionId}";
                        using (MySqlCommand cmdAnswers = new MySqlCommand(queryAnswers, connection))
                        {
                            using (MySqlDataReader answerReader = cmdAnswers.ExecuteReader())
                            {
                                int rowIndex = 1; // Индекс строки для ответов (начинаем с 1, чтобы начать со второй строки)
                                int columnIndex = 0; // Индекс столбца для ответов (начинаем с 0)

                                while (answerReader.Read())
                                {
                                    string answerText = answerReader.GetString("answ_text");
                                    bool isCorrect = answerReader.GetInt32("answ_corr") == 1;

                                    // Создаем RadioButton для ответа
                                    RadioButton radioButton = new RadioButton();
                                    radioButton.Text = answerText;
                                    // Устанавливаем стиль для RadioButton (выглядит как кнопка)
                                    radioButton.Appearance = Appearance.Button;
                                    radioButton.Height = 120;
                                    radioButton.Padding = new Padding(10, 10, 0, 10);

                                    // Устанавливаем выравнивание RadioButton по центру
                                    radioButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                                    radioButton.TextAlign = ContentAlignment.MiddleCenter;
                                    radioButton.Font = new Font("Inter SemiBold", 16, FontStyle.Bold);
                                    radioButton.Enabled = true;

                                    // Добавляем обработчик события Click для текущего RadioButton
                                    radioButton.Click += radioButton_Click;

                                    // Добавляем RadioButton в TableLayoutPanel в соответствующую ячейку
                                    tableLayoutPanel.Controls.Add(radioButton, columnIndex, rowIndex);

                                    // Переключаемся на следующий столбец (0 или 1)
                                    columnIndex = (columnIndex + 1) % 2;

                                    // Если перешли на следующий столбец, переходим на следующую строку
                                    if (columnIndex == 0)
                                    {
                                        rowIndex++; // Переходим на следующую строку
                                    }
                                }

                                answerReader.Close(); // Закрываем answerReader после использования

                                // Добавляем кнопку "Далее" в 4 строку
                                Button btnNext = new Button();
                                btnNext.Text = "Далее";
                                //btnNext.AutoSize = true;
                                btnNext.Height = 50;
                                btnNext.Width = 150;
                                btnNext.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
                                btnNext.BackColor = Color.Lavender;
                                btnNext.FlatStyle= FlatStyle.Popup;
                                btnNext.Click += btnNext_Click;
                                btnNext.Dock = DockStyle.Right;


                                // Добавляем кнопку "Далее" в 4 строку и объединяем ячейку на два столбца
                                tableLayoutPanel.Controls.Add(btnNext, 1, rowIndex + 1);

                                Label label_for_table = new Label();
                                label_for_table.Text = "";
                                tableLayoutPanel.Controls.Add(label_for_table, 0, rowIndex + 2);

                                // Добавляем TableLayoutPanel на question_panel
                                question_panel.Controls.Add(tableLayoutPanel);
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        //Загрузка вопросов теста
        private void LoadRandomQuestionsForTest(int testId, int numberOfQuestions)
        {
            questionIds = new List<int>();

            string query = $"SELECT id_question FROM questions_for_tests WHERE id_test = {testId} ORDER BY RAND() LIMIT {numberOfQuestions}";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int questionId = reader.GetInt32("id_question");
                        questionIds.Add(questionId);
                    }
                }
            }
        }

        // Изменение цвета radioButton
        private void radioButton_Click(object sender, EventArgs e)
        {
            if (!answerSelected)
            {
                RadioButton selectedRadioButton = (RadioButton)sender;
                string answerText = selectedRadioButton.Text;

                bool isCorrect = IsAnswerCorrect(answerText);

                if (isCorrect)
                {
                    selectedRadioButton.BackColor = Color.FromArgb(192, 255, 192); // Правильный ответ - зеленый
                    correct_answ++;
                }
                else
                {
                    selectedRadioButton.BackColor = Color.Pink; // Неправильный ответ - красный
                    HighlightCorrectAnswer();                   // Выделяем правильный ответ зеленым
                }

                answerSelected = true;
                DisableRadioButtons();
            }
        }

        // Проверка правильного ответа
        private bool IsAnswerCorrect(string answerText)
        {
            bool isCorrect = false;

            // Проверяем, открыто ли соединение
            if (OpenConnection())
            {
                string query = $"SELECT answ_corr " +
                                $"FROM answers " +
                                $"WHERE answ_text = @answerText AND id_question = @IDQuestion";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@answerText", answerText);
                    cmd.Parameters.AddWithValue("@IDQuestion", IDQuestion);
                    object result = cmd.ExecuteScalar();

                    if (result != null && bool.TryParse(result.ToString(), out bool ansCorr))
                    {
                        isCorrect = ansCorr;
                    }
                }

                // Закрываем соединение после использования
                CloseConnection();
            }
            return isCorrect;
        }


        private void HighlightCorrectAnswer()
        {
            // Проверяем, что в question_panel есть TableLayoutPanel
            if (question_panel.Controls.Count > 0 && question_panel.Controls[0] is TableLayoutPanel tableLayoutPanel)
            {
                // Обходим все элементы в TableLayoutPanel
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        string answerText = radioButton.Text;
                        bool isCorrect = IsAnswerCorrect(answerText);

                        if (isCorrect)
                        {
                            radioButton.BackColor = Color.FromArgb(192, 255, 192); // Правильный ответ - зеленый
                        }
                        else
                        {
                            radioButton.BackColor = Color.Pink; // Неправильный ответ - красный
                        }
                    }
                }
            }
        }


        private void DisableRadioButtons()
        {
            foreach (Control control in question_panel.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Enabled = false;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            question_panel.Controls.Clear();    // Очищаем панель перед добавлением новых элементов
            currentQuestionIndex++;             // Увеличиваем индекс текущего вопроса
            answerSelected = false;             // Разблокируем выбор ответа
            DisplayCurrentQuestion();           // Отобразить следующий вопрос
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            TestForm.ActiveForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
    }
}
