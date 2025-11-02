using QuizGame.Core.Entities;
namespace QuizGame.Core.Entities;


public class Question // Modifiable au fur et a mesure
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public List<AnswerOption> Options { get; set; } = new();
    public int CorrectAnswerId { get; set; }
}