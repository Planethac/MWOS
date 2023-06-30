using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quantumnt 
{
    public class cmdshell
    {

        public static string exepth = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static string cpth = System.IO.Path.GetDirectoryName(exepth);
        public static void Main()
        {
            System.Console.WriteLine("QUANTUMNT VER 0.0.1");
            System.Console.WriteLine("© BigPO, Planethac");
            while (true)
            {
                Console.Write("{0}> ", cpth);
                string Input = Console.ReadLine();
                string[] param  = Input.Split(' ');
                string Command = param[0];
                string[] SystemCommand = { "help", "vista-macbook", "exit", "shutdown", "ls", "dir", "clear", "cd" };

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