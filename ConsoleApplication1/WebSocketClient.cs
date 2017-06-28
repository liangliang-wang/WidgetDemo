using HPSocketCS;
using System;
using System.Net;
using System.Net.WebSockets;

namespace ConsoleApplication1
{
    public class MyWebSocketClient
    {
        TcpClient client = new TcpClient();

        public MyWebSocketClient()
        {
           
            client.OnReceive += new TcpClientEvent.OnReceiveEventHandler(OnReceive);
        }

        public void start()
        {
            var conRes = client.Connect("192.168.2.180", 8081);
        }

        HandleResult OnReceive(TcpClient sender, byte[] bytes)
        {
            string str = System.Text.Encoding.Default.GetString(bytes);
            Console.WriteLine(str);
            return HandleResult.Ok;
        }
    }
}
