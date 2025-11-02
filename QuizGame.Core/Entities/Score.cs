namespace QuizGame.Core.Entities;

public class Score // A visiter
{
    public int PlayerId { get; set; }
    public int Points { get; set; }
    public Player Player { get; set; } = null!;
    public DateTime DateAchieved { get; set; } = DateTime.Now;
} /*Score totalise les point de chaque joueur et communique avec inotifiable pour retourner la valeur a la partie*/