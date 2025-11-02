namespace QuizGame.Core.Entities;

public class AnswerOption // A Reverifier
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
}