namespace quantumnt
{
    public static class Functions
    {
        public static void ExecuteSystemCommand(int CommandID)
        {
            if(CommandID == 1)
            {
                System.Console.WriteLine("HELP OVERVIEW");
                System.Console.WriteLine("HELP - Display this help menu");

                System.Console.WriteLine();
            }
        }
    }
}