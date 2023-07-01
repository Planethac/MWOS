// Verdian is Bad coder!
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
        public static string InputPB = "";
        public static string[] ParamPB  = {""};
        public static void Main()
        {
            Functions.ExecuteSystemCommand(5, "", "");
            System.Console.WriteLine("QUANTUMNT VER 0.0.1");
            System.Console.WriteLine("© BigPO, Planethac");
            while (true)
            {
                Console.Write("{0}> ", cpth);
                string Input = Console.ReadLine();
                string[] param = Input.Split(' ');
                InputPB = Input;
                ParamPB = param;
                string Command = ParamPB[0];
                string[] SystemCommand = { "help", "vista-macbook", "exit", "shutdown", "ls", "dir", "clear", "cd", "mkdir", "rmdir", "mwver", "cat", "rm", "mv", "cp" };

                if(SystemCommand.Contains(Command)) {
                    int CommandID = CommandDotCom.RunSysBin(Command);
                    try
                    {
                        Functions.ExecuteSystemCommand(CommandID, ParamPB[1], ParamPB[2]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        try
                        {
                            Functions.ExecuteSystemCommand(CommandID, ParamPB[1], "");
                        }
                        catch (System.Exception)
                        {
                            Functions.ExecuteSystemCommand(CommandID, ParamPB[0], "");
                        }    
                    }
                } else {
                    ExecuteBinary.Do(ParamPB[0]);
                }
            }
        }
    } 
}