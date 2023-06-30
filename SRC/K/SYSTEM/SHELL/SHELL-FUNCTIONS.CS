using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quantumnt
{
    public static class CommandDotCom
    {
        public static int RunSysBin(string command)
        {
            if(command.ToLower() == "help") return 1;
            if(command.ToLower() == "vista-macbook") return 2;
            if(command.ToLower() == "shutdown" || command.ToLower() == "exit") return 3;
            if(command.ToLower() == "ls" || command.ToLower() == "dir") return 4;
            if(command.ToLower() == "clear") return 5;

            else return 0;
        }
    }
    public static class ReadFiles
    {
        public static void Do(string path)
        {
            try
            {
                string[] FilePath = Directory.GetFiles(path); 
                string[] DirPath = Directory.GetDirectories(path); 

                foreach (string Dir in DirPath)
                {
                    System.Console.WriteLine(Dir);
                }
                foreach(string File in FilePath)
                {
                    System.Console.WriteLine(File);
                }
            }
            catch (System.IO.IOException)
            {
                System.Console.WriteLine("System.IO.IOException");
                System.Console.WriteLine();
            }
        }
    }
    public static class ExecuteBinary
    {
        public static void Do(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = command;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    StreamReader reader = process.StandardOutput;
                    string output = reader.ReadToEnd();

                    Console.WriteLine(output);

                    process.WaitForExit();
                }

            } catch (System.InvalidOperationException) {
                return;
            } catch (System.ComponentModel.Win32Exception) {
                System.Console.WriteLine("System.ComponentModel.Win32Exception");
                System.Console.WriteLine();
            }
        }
    }
}