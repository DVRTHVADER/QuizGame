namespace QuizGame.Core.Entities;

public class Player
{ // Modifiable au fur et a mesure
    public int Id { get; set; }
    public string Nomutilisateur { get; set; } = string.Empty;
    public int Score { get; set; }

    
} /*namespace QuizGame.Core.Notifications
     {
         public interface INotifiable
         {
             void Notify(string message);
         } Interface qui donne l'etat du score et notifie le joueur a chaque fois quil a trouver ou pas une reponse.
         dites moi ce que vous en pensez
     }*/