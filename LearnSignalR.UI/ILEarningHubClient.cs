using System.Threading.Tasks;

namespace LearnSignalR.UI
{
    public interface ILearningHubClient
    {
        Task ReceiveMessage(string message);
    }
}
