using System.Linq;
namespace quantumnt-shell
{
    public satic class cmdshell
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("QUANTUMNT VER 0.0.1");
            System.Console.WriteLine("© KOTL");
            while (true)
            {
                Console.Write("QUANTUMNT> ");
                string? Command = Console.ReadLine();
                string[] SystemCommand = { "help" };

                if(SystemCommand.Contains(Command))
                {
                    int CommandID = CommandDotCom.RunSysBin(command);
                    Functions.ExecuteSystemCommand(CommandID);
                }
            }
        }
    } 
}