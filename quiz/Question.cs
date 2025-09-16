namespace ConsoleQuizGame.quiz
{
    public class Question
    {
        public required string Text { get; set; }
        public required string[] Options { get; set; }
        public required int CorrectIndex { get; set; }
    }
}