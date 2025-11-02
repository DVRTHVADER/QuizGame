using Microsoft.EntityFrameworkCore;
using QuizGame.Core.Entities;
namespace QuizGame.Infrastructure;

public class QuizGameDbContext : DbContext
{
    
        public QuizGameDbContext(DbContextOptions<QuizGameDbContext> options)
            : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<Score> Scores { get; set; }
    }

