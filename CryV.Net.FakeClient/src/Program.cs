using System;
using System.Threading;
using System.Threading.Tasks;

namespace CryV.Net.FakeClient
{
    public class Program
    {

        private static FakeClient _fakeClient;

        public static void Main(string[] args)
        {
            _fakeClient = new FakeClient();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1));

                    _fakeClient.Tick();
                }
            });

            while (true)
            {
                _fakeClient.HandleCommand(Console.ReadLine());

                Thread.Sleep(1);
            }

        }
    }
}
