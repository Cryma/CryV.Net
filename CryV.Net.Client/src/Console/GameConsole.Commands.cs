using System.Linq;

namespace CryV.Net.Client.Console
{
    public partial class GameConsole
    {

        private void CommandOutputText(GameConsole gameConsole, params string[] arguments)
        {
            if (arguments.Length == 0)
            {
                PrintLine("Please specify something to output.");

                return;
            }

            PrintLine("Output: " + string.Join(' ', arguments));
        }

        private void CommandClear(GameConsole gameConsole, params string[] arguments)
        {
            lock (_output)
            {
                _output.Clear();
            }
        }

    }
}
