using System.Text.Json;

namespace ConsoleQuizGame.quiz
{
    public class Quiz
    {
        private List<Question> Questions = new List<Question>();

        public void Start()
        {
            Questions = LoadQuestions()!;
            clearScreen();
            Console.WriteLine("Welcome to Zani's Quiz.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("To play the game, you pick the numeber\nof the answer you believe is correct\nThe game will begin in 5 seconds...");
            Thread.Sleep(5000);
            RunQuiz();
        }

        private static List<Question>? LoadQuestions()
        {
            try
            {
                string data = File.ReadAllText("assets/Questions.json");
                return JsonSerializer.Deserialize<List<Question>>(data)!;

            }
            catch (Exception e)
            {
                Console.WriteLine("", e.Message);
                return null;
            }
        }

        private void RunQuiz()
        {
            int Score = 0;
            foreach (Question question in Questions)
            {
                clearScreen();
                Console.WriteLine("Your question is:");
                Console.WriteLine($"{question.Text}");
                Console.WriteLine();
                Console.WriteLine("Your possible answers are: ");
                for (int index = 0; index <= question.Options.Length - 1; index++)
                {
                    Console.WriteLine($"{index}: {question.Options[index]}");
                }
                var ans = Console.ReadLine()!.Trim();
                if (ans == question.CorrectIndex.ToString())
                {
                    Console.WriteLine("Correct answer +1 point");
                    Score++;
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Wrong answer!");
                    Thread.Sleep(3000);
                }

                Console.WriteLine($"Your final score is {Score}/{Questions.Count}");
            }
        }

        private void clearScreen()
        {
            // Console.Write("\x1B[3J"); // Clear scroll buffer
            // Console.Write("\x1B[2J"); // Clear visible screen
            // Console.Write("\x1B[H"); // Cursor to home
            // Console.Write("\x1Bc"); // Full terminal reset

            Console.Clear();
        }
    }
}