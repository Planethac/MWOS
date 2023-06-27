using CMD_SHELL_LIB;
using System.Diagnostics;
using System.Linq;
namespace CMD_SHELL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] SystemCommands = { "hell", "nahman" };

            Console.WriteLine("QUNATUM FS 0.0.1");
            Console.WriteLine("© KOTL");
            while (true)
            {
                Console.Write("QUANTUMNT> ");
                string? ExecuteCommand = Console.ReadLine();
                if (ExecuteCommand != null)
                {
                    CMD_SHELL_LIB.CommandTypeNull.PressedEnter();
                }
                if (SystemCommands.Contains(ExecuteCommand))
                {
                    int CommandID = CMD_SHELL_LIB.CommandDotCom.RunSysBin(ExecuteCommand);
                    if (CommandID == 0)
                    {
                        Console.WriteLine("NULL IS INVALID");
                    } else if (CommandID == 1)
                    {
                        Console.WriteLine("Hell!");
                    }
                }
                else
                {
                    Console.WriteLine("INVALID COMMAND");
                    Console.WriteLine("Try 'help' for Help");
                    Console.WriteLine();
                }
            }
        }
    }
}