
using QuizGame.Core.Interfaces;
namespace QuizGame.Core.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public Player CurrentPlayer { get; set; } = null!;
        public List<Question> Questions { get; set; } = new();
        public int CurrentQuestionIndex { get; private set; } = 0;
        public Score TotalScore { get; private set; }
        public bool IsFinished { get; private set; } = false;
        private readonly INotifiable? _notifier;

        /* 
        public Game(Player player, List<Question> questions, INotifiable? notifier = null)
        {
            CurrentPlayer = player;
            Quest...
        }
    */
    }
}

