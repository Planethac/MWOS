using System;
using System.IO;
namespace quantumnt
{
    public static class CommandDotCom
    {
        public static int RunSysBin(string command)
        {
            if(command.ToLower() == "help") return 1;
            if(command.ToLower() == "vista-macbook") return 2;
            if(command.ToLower() == "shutdown" || command.ToLower() == "exit") return 3;
            if(command.ToLower() == "ls") return 4;

            else return 0;
        }
    }
    public static class ReadFiles
    {
        public static void Do(string path)
        {
            string[] FilePath = Directory.GetFiles(path);
            foreach(string File in FilePath)
            {
                System.Console.WriteLine(File);
            }
        }
    }
}