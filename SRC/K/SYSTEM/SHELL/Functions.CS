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
            if(command.ToLower() == "mkdir") return 7;
            if(command.ToLower() == "rmdir") return 8;
            if(command.ToLower() == "mwver") return 9;
            if(command.ToLower() == "cat") return 10;
            if(command.ToLower() == "rm") return 11;
            if(command.ToLower() == "mw") return 12;
            if(command.ToLower() == "cp") return 13;
            if(command.ToLower() == "gui") return 14;

            else return 0;
        }
    }
    public static class ReadFiles
    {
        public static void Do(string path)
        {
            try
            {
                string fullPath = "";
                int amountParam = cmdshell.ParamPB.Length - 1;
                int i = 1;
                if (amountParam == 1) fullPath = path;
                if (amountParam >= 2)
                {
                    fullPath = fullPath + cmdshell.ParamPB[1];
                    while (i != amountParam)
                    {
                    fullPath = fullPath + " " + cmdshell.ParamPB[i + 1];
                    i++;            
                    }
                }
                if (path == "ls") fullPath = ".";

                string[] FilePath = Directory.GetFiles(fullPath); 
                string[] DirPath = Directory.GetDirectories(fullPath); 

                foreach (string Dir in DirPath)
                {
                    System.Console.WriteLine(Dir);
                }
                foreach(string File in FilePath)
                {
                    System.Console.WriteLine(File);
                }
            }
            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.Message);
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
    
            } catch (System.InvalidOperationException ex) {
                if (ex.Message == "Cannot start process because a file name has not been provided." || ex.Message == "Der Prozess kann nicht gestartet werden, da ein Dateiname nicht angegeben wurde.") return;
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            } catch (System.ComponentModel.Win32Exception ex) {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            } catch (System.IO.IOException ex) {
                System.Console.WriteLine(ex.Message);
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
            string fullPath = "";
            int amountParam = cmdshell.ParamPB.Length - 1;
            int i = 1;
            if (amountParam == 1) fullPath = path;
            if (amountParam >= 2)
            {
                fullPath = fullPath + cmdshell.ParamPB[1];
                while (i != amountParam)
                {
                fullPath = fullPath + " " + cmdshell.ParamPB[i + 1];
                i++;            
                }
            }
            try
            {
                Directory.SetCurrentDirectory(fullPath);
                cmdshell.cpth = Directory.GetCurrentDirectory();
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
            catch (System.ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class LaunchUI
    {
        public static void Do()
        {
            Process gui = new Process();
            gui.StartInfo.FileName = @"..\GUI\gui.exe";
            gui.Start();
        }
    }
}