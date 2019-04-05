using System;
using System.Threading;
using System.Threading.Tasks;

namespace CryV.Net.Server
{
    public class Program
    {
        
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting CryV.Net.Server");

            var gameServer = new GameServer();

            Console.WriteLine("Started CryV.Net.Server");

            while (true)
            {
                await Task.Delay(1);

                gameServer.Tick();
            }

            Console.WriteLine("Shutting down CryV.Net.Server");

            // Shutdown
        }

    }
}
