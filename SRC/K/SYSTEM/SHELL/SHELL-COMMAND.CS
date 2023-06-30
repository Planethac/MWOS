namespace quantumnt
{
    public static class Functions
    {
        public static void ExecuteSystemCommand(int CommandID, string param)
        {
            if(CommandID == 1) {
                System.Console.WriteLine("HELP OVERVIEW");
                System.Console.WriteLine("HELP - Display this help menu");

                System.Console.WriteLine();
            } else if (CommandID == 2) {
                System.Console.WriteLine("https://youtu.be/sxqqvfn-6eo");
                System.Console.WriteLine();
            } else if (CommandID == 3) {
                System.Environment.Exit(1);
            } else if (CommandID == 4) {
                ReadFiles.Do(param);
            }
        }
    }
}