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
                string Input = Console.ReadLine();
                string[] param  = Input.Split(' ');
                string Command = param[0];
                string[] SystemCommand = { "help", "vista-macbook", "exit", "shutdown", "ls", "dir" };

                if(SystemCommand.Contains(Command)) {
                    int CommandID = CommandDotCom.RunSysBin(Command);
                    try
                    {
                        Functions.ExecuteSystemCommand(CommandID, param[1]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        
                        Functions.ExecuteSystemCommand(CommandID, param[0]);
                    }
                } else {
                    ExecuteBinary.Do(param[0]);
                }
            }
        }
    } 
}