using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VS.Logic;
using VS.Data;
using VS.Core;


namespace Console
{
    class Program
    {
        public static Logic Logics = new Logic(new Storage());

        static IDictionary<string, CommandProcessor> commands = new Dictionary<string, CommandProcessor>
        {
            { "list", new ListCommandProcessor() },
            { "create", new CreateCommandProcessor() }
            //{ "delete", new DeleteCommandProcessor() },
            //{ "rename",new RenameCommandProcessor()}
        };

        static void Main(string[] args)
        {
            var command = WaitForNextCommand();
            while (command != "exit")
            {
                ProcessCommand(command);

                command = WaitForNextCommand();
            }
        }

        private static string WaitForNextCommand()
        {
            System.Console.Write("> ");
            return System.Console.ReadLine().Trim();
        }

        private static void ProcessCommand(string command)
        {
            if (commands.ContainsKey(command))
                commands[command].Process();
            else
                System.Console.WriteLine("command not recognized");
        }

    }
}

