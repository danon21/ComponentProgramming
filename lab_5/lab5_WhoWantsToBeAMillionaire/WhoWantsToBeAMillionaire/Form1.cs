using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Threading;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int Level = 0;
        Question currentQuestion;
        bool ToMakeMistake = false;
        int FirelessAmountIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
            ReadQuestionsFromDatabase();
            startGame();
        }

        private void SelectAmount()
        {
            SelectAmount selectionForm = new SelectAmount();
            selectionForm.ShowDialog();

            // Получвем выбранный элемент из SelectionForm
            FirelessAmountIndex = selectionForm.SelectedItem;


        }
        // Метод чтения данных из БД
        private void ReadQuestionsFromDatabase()
        {
            string connectionString = "Host=localhost;Port=5432;Database=who_wants_to_be_a_millionaire;Username=postgres;Password=post!2439!gres;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand qsql = new NpgsqlCommand("SELECT * FROM Questions", connection))
                {
                    using (NpgsqlDataReader reader = qsql.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string questionText = reader["QuestionText"].ToString();
                            string answer1 = reader["Answer1"].ToString();
                            string answer2 = reader["Answer2"].ToString();
                            string answer3 = reader["Answer3"].ToString();
                            string answer4 = reader["Answer4"].ToString();
                            string correctAnswerIndex = reader["CorrectAnswerIndex"].ToString();
                            int weight = Convert.ToInt32(reader["Weight"]);

                            // Создаем объект Question и добавляем его в коллекцию
                            Question question = new Question(questionText, answer1, answer2, answer3, answer4, correctAnswerIndex, weight);
                            questions.Add(question);
                        }
                    }
                }
            }
        }


        private void ShowQuestion(Question q)
        {
            lblQuestionText.Text = q.Text;
            btnAnswer1.Text = q.Answer1;
            btnAnswer2.Text = q.Answer2;
            btnAnswer3.Text = q.Answer3;
            btnAnswer4.Text = q.Answer4;
        }

        private Question GetQuestion(int level)
        {
            List<Question> list = questions.Where(q => q.Level == level).ToList();
            return list[rnd.Next(list.Count)];
        }
        private void NextStep()
        {
            ToMakeMistake = false;
            Button[] buttons = new Button[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            Level++;
            currentQuestion = GetQuestion(Level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - Level;
        }

        private void startGame()
        {
            btnChangeQuestion.Enabled = true;
            btnCallFriend.Enabled = true;
            btnHalf.Enabled = true;
            btnHelpAudience.Enabled = true;
            btnRightToMakeMistake.Enabled = true;          
            Level = 0;
            NextStep();
            SelectAmount();
            lstLevel.Invalidate();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            btnClick(sender);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            btnClick(sender);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            btnClick(sender);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            btnClick(sender);
        }
        private void btnClick(object sender)
        {
            Button clickedButton = (Button)sender;
            if (!ToMakeMistake)
            {
                if (currentQuestion.RightAnswer.Equals(clickedButton.Tag.ToString())) // clickedButton.Text
                {
                    NextStep();
                }
                else
                {
                    MessageBox.Show("Неверный ответ!");
                    Prize();
                    startGame();
                }
            }
            else
            {
                if (currentQuestion.RightAnswer.Equals(clickedButton.Tag.ToString())) // clickedButton.Text
                {
                    NextStep();
                }
                else
                {
                    MessageBox.Show("Неверный ответ!");
                    ToMakeMistake = false;
                    clickedButton.Enabled = false;
                }
            }
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                string ac = btns[n].Tag.ToString();

                if (!ac.Equals(currentQuestion.RightAnswer) && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            btnHalf.Enabled = false;
        }

        private void btnCallFriend_Click(object sender, EventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
            btnCallFriend.Enabled = false;
        }

        private void btnTakeMoney_Click(object sender, EventArgs e)
        {
            string Prize = lstLevel.Text.Trim();
            MessageBox.Show($"Вы выиграли: {Prize} рублей!");
            startGame();
        }
        private void Prize()
        {
            if (lstLevel.SelectedIndex < FirelessAmountIndex)
            {
                string Prize = lstLevel.Items[FirelessAmountIndex].ToString().Trim();
                MessageBox.Show($"Вы выиграли: {Prize} рублей!");
            }
        }
        private void btnChangeQuestion_Click(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            currentQuestion = GetQuestion(Level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - Level;
            btnChangeQuestion.Enabled = false;
        }

        private void btnRightToMakeMistake_Click(object sender, EventArgs e)
        {
            ToMakeMistake = true;
            btnRightToMakeMistake.Enabled = false;
        }

        private void btnHelpAudience_Click(object sender, EventArgs e)
        {
            int RigthAnswer = int.Parse(currentQuestion.RightAnswer);
            int SecAnswer = 0;
            int procSecAnswer = 0;
            int procRightAnswer = 0;
            bool ok = true;
            while (ok)
            {
                if (SecAnswer == RigthAnswer || SecAnswer == 0)
                    SecAnswer = rnd.Next(1, 4);
                else ok = false;
            }
            while ((procSecAnswer + procRightAnswer) != 100)
            {
                procRightAnswer = rnd.Next(0, 80);
                procSecAnswer = rnd.Next(0, 60);

            }
            MessageBox.Show($"За вариант ответа под номером {SecAnswer} - {procSecAnswer}%\n\nЗа вариант ответа под номером {RigthAnswer} - {procRightAnswer}%");

            btnHelpAudience.Enabled = false;
        }

        private void lstLevel_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Проверяем, что индекс элемента действительный
            if (e.Index >= 0)
            {
                ListBox listBox = sender as ListBox;
                string itemText = listBox.Items[e.Index].ToString();

                // Создаем кисть для цвета текста
                Brush textBrush = Brushes.Black; // Черный цвет по умолчанию

                if (e.Index == FirelessAmountIndex) // Устанавливаем цвет текста для элемента с индексом
                {
                    textBrush = Brushes.Red; // Красный цвет для несгораемой суммы
                }

                e.DrawBackground();
                e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}

