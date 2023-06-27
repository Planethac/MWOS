using System.Linq;
using System;
namespace quantumnt 
{
    public class cmdshell
    {
        public static void Main()
        {
            System.Console.WriteLine("QUANTUMNT VER 0.0.1");
            System.Console.WriteLine("© KOTL");
            while (true)
            {
                Console.Write("QUANTUMNT> ");
                string Command = Console.ReadLine();
                string[] SystemCommand = { "help" };

                if(SystemCommand.Contains(Command))
                {
                    int CommandID = CommandDotCom.RunSysBin(Command);
                    Functions.ExecuteSystemCommand(CommandID);
                }
            }
        }
    } 
}