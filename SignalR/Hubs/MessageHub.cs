

using Microsoft.AspNetCore.SignalR;
using SignalR.Helpers;

namespace SignalR.Hubs
{
    public class MessageHub:Hub
    {
        //hazir metod-qosulduqda tetiklenir
        public override async Task OnConnectedAsync()
        {
            //hamiya gonderir
            //ReceiveConnectedInfo=> bu metodu cagiririq heryerde
            await Clients.Others.SendAsync("ReceiveConnectInfo", "User connected");
        }

        //hubdan cixdiqda isleyir
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await Clients.Others.SendAsync("ReceiveDisConnectedInfo", "User Disconnected");
        }


        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",message,FileHelper.Read());
        }

       

    }
}
