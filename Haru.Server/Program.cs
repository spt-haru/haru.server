using System;
using Haru.ServerData.Servers;

namespace Haru.Server
{
    public class Program
    {
        private static readonly ServerManager _serverManager;

        static Program()
        {
            _serverManager = new ServerManager();
        }

        static void Main()
        {
            Console.Title = "Haru.Server";

            // start the servers
            _serverManager.Start();

            // keep the server running
            // note: Console.ReadKey() doesn't work inside vscode's internal
            //       debug console due to input redirection. We must read the
            //       console's stdin stream instead.
            Console.In.ReadLine();
        }
    }
}