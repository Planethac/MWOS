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
            System.Console.WriteLine("MWOS VER 0.0.1");
            System.Console.WriteLine("© BigPO, Planethac");
            Startup();
            while (true)
            {
                Console.Write("{0}> ", cpth);
                string Input = Console.ReadLine();
                string[] param = Input.Split(' ');
                InputPB = Input;
                ParamPB = param;
                string Command = ParamPB[0];
                string[] SystemCommand = { "help", "driveinfo", "vista-macbook", "exit", "shutdown", "ls", "dir", "clear", "cd", "mkdir", "rmdir", "mwver", "cat", "rm", "mv", "cp", "gui", "run", "diskfpm" };
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
                } 
            }
        }

        public static void Startup()
        {
            string[] SystemCommand = { "help", "diskfpm", "driveinfo", "vista-macbook", "exit", "shutdown", "ls", "dir", "clear", "cd", "mkdir", "rmdir", "mwver", "cat", "rm", "mv", "cp", "gui", "run" };
            StreamReader au = new StreamReader("../../CONFIGURATION/boot.cfg");
            string line = au.ReadLine();
            while (line != null)
            {
                string[] lineParam = line.Split(' ');
                if (SystemCommand.Contains(lineParam[0]))
                {
                    int CommandID = CommandDotCom.RunSysBin(lineParam[0]);
                    try
                    {
                        Functions.ExecuteSystemCommand(CommandID, lineParam[1], lineParam[2]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        try
                        {
                            Functions.ExecuteSystemCommand(CommandID, lineParam[1], "");
                        }
                        catch (System.Exception)
                        {
                            Functions.ExecuteSystemCommand(CommandID, lineParam[0], "");
                        }    
                    }
                }

                line = au.ReadLine();
            }
            au.Close();
        }
    } 
}
