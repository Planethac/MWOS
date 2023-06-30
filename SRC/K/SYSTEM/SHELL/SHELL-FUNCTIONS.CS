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
            if(command.ToLower() == "cd") return 6;

            else return 0;
        }
    }
    public static class ReadFiles
    {
        public static void Do(string path)
        {
            try
            {
                if (path == "ls") path = ".";

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
                Process process = new Process();
        

                process.StartInfo.FileName = command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.OutputDataReceived += Process_OutputDataReceived;
                process.Start();
                process.BeginOutputReadLine();
                string input;
                while ((input = Console.ReadLine()) != "exit")
                {
                    process.StandardInput.WriteLine(input);
                }
                process.StandardInput.Close();
                process.WaitForExit();
                int exitCode = process.ExitCode;
                process.Close();
                
                Console.WriteLine("Cmd process exited with code {0}.", exitCode);
                System.Console.WriteLine();
    
            } catch (System.InvalidOperationException) {
                return;
            } catch (System.ComponentModel.Win32Exception) {
                System.Console.WriteLine("System.ComponentModel.Win32Exception");
                System.Console.WriteLine();
            }
        }
        static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                Console.WriteLine(e.Data);
            }
        }
    }
    public static class ChangeDirectory
    {
        public static void Do(string path)
        {
            try
            {
                Directory.SetCurrentDirectory(path);
                cmdshell.cpth = Directory.GetCurrentDirectory();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                System.Console.WriteLine("System.IO.DirectoryNotFoundException");
                System.Console.WriteLine(path);
            }
        }
    }
}