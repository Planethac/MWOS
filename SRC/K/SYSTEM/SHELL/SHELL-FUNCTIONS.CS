using System;
namespace quantumnt
{
    public static class CommandDotCom
    {
        public static int RunSysBin(string command)
        {
            if(command.ToLower() == "help") return 1;
            if(command.ToLower() == "vista-macbook") return 2;
            if(command.ToLower() == "shutdown" || command.ToLower() == "exit") return 3;

            else return 0;
        }
    }
}