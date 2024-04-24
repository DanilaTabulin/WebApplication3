using Microsoft.AspNetCore.SignalR;

namespace WebApplication3.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string user)
        {
            await this.Clients.All.SendAsync("Send", message, user);
        }
        public async Task UpDateSubjectGrades(int movieId, string subjectName, int grade)
        {
            await this.Clients.All.SendAsync("UpDateSubjectGrades", movieId, subjectName, grade);
        }
    }
}
