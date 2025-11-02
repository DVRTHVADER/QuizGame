/*class controleur*/
using Microsoft.AspNetCore.SignalR;
using QuizGame.Core.Interfaces;
namespace QuizGame.API.Hubs
{
    public class GameHub : Hub, INotifiable
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async void NotifyAll(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }
    }
}