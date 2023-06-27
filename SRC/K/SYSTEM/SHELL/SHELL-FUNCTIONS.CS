using System;
namespace quantumnt
{
    public static class CommandDotCom
    {
        public static int RunSysBin(string command)
        {
            if(command.ToLower() == "help") return 1;

            else return 0;
        }
    }
}