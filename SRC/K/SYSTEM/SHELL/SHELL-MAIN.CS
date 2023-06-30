using System.Linq;
using System;
namespace quantumnt 
{
    public class cmdshell
    {
        public static void Main()
        {
            string exepth = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string cpth = System.IO.Path.GetDirectoryName(exepth);
            System.Console.WriteLine("QUANTUMNT VER 0.0.1");
            System.Console.WriteLine("© BigPO, Planethac");
            while (true)
            {
                Console.Write("{0}> ", cpth);
                string Input = Console.ReadLine();
                string[] param  = Input.Split(' ');
                string Command = param[0];
                string[] SystemCommand = { "help", "vista-macbook", "exit", "shutdown", "ls", "dir", "clear" };

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