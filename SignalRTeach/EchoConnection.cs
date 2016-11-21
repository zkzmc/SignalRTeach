using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRTeach
{
    public class EchoConnection : PersistentConnection
    {
       

        protected override async Task OnReceived(IRequest request, string connectionId, string data)
        {
            await this.Connection.Broadcast(data);
        }
    }
}