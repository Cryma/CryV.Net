using System;
using System.Threading;

namespace CryV.Net.Server.Core
{
    public class Program
    {

        private static ContainerManager _containerManager;

        public static void Main(string[] args)
        {
            _containerManager = new ContainerManager();
            _containerManager.Start();

            while (true)
            {
                Thread.Sleep(1);
            }
        }
    }
}
