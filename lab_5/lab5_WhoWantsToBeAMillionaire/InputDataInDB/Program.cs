using Npgsql;

namespace InputDataInDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Host=localhost;Port=5432;Database=who_wants_to_be_a_millionaire;Username=postgres;Password=post!2439!gres;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (StreamReader sr = new StreamReader("Вопросы.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] s = line.Split('\t');

                        if (s.Length == 7)
                        {
                            string questionText = s[0];
                            string answer1 = s[1];
                            string answer2 = s[2];
                            string answer3 = s[3];
                            string answer4 = s[4];
                            int correctAnswerIndex = int.Parse(s[5]);
                            int weight = int.Parse(s[6]);

                            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO Questions (QuestionText, Answer1, Answer2, Answer3, Answer4, CorrectAnswerIndex, Weight) VALUES (@questionText, @answer1, @answer2, @answer3, @answer4, @correctAnswerIndex, @weight)", connection))
                            {
                                cmd.Parameters.AddWithValue("questionText", questionText);
                                cmd.Parameters.AddWithValue("answer1", answer1);
                                cmd.Parameters.AddWithValue("answer2", answer2);
                                cmd.Parameters.AddWithValue("answer3", answer3);
                                cmd.Parameters.AddWithValue("answer4", answer4);
                                cmd.Parameters.AddWithValue("correctAnswerIndex", correctAnswerIndex);
                                cmd.Parameters.AddWithValue("weight", weight);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

        }

    }
}