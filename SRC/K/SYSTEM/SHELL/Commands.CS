namespace quantumnt
{
    public static class Functions
    {
        public static void ExecuteSystemCommand(int CommandID, string param, string param2)
        {
            if(CommandID == 1) {
                System.Console.WriteLine("HELP OVERVIEW");
                System.Console.WriteLine("HELP - Display this help menu");
                System.Console.WriteLine("CD - Change Directory");
                System.Console.WriteLine("LS - List Directory content");
                System.Console.WriteLine("EXIT - Close The Shell");
                System.Console.WriteLine("MKDIR - Make new directory");
                System.Console.WriteLine("CLEAR- Clear The Output");
                System.Console.WriteLine("MWVER - Diplay MWOS Version");
                System.Console.WriteLine("RMDIR - remove directory");
                System.Console.WriteLine("CAT - create directory");
                System.Console.WriteLine("MV - Move a file ore directory");

                System.Console.WriteLine();
            } else if (CommandID == 2) {
                System.Console.WriteLine("https://youtu.be/sxqqvfn-6eo");
                System.Console.WriteLine();
            } else if (CommandID == 3) {
                System.Environment.Exit(1);
            } else if (CommandID == 4) {
                ReadFiles.Do(param);
            } else if (CommandID == 5) {
                System.Console.Clear();
            } else if (CommandID == 6) {
                ChangeDirectory.Do(param);
            } else if (CommandID == 7) {
                MakeDirectory.Do(param);
            } else if (CommandID == 8) {
                RemoveDirectory.Do(param);
            } else if (CommandID == 9) {
                System.Console.WriteLine("------- MWOS -------");
                System.Console.WriteLine("The glorius MWOS de-");
                System.Console.WriteLine("veolepment Team:");
                System.Console.WriteLine("BigPO - Kernel");
                System.Console.WriteLine("Planethac - Shell");
                System.Console.WriteLine();
                System.Console.WriteLine("MWOS VER 0.0.1");
                System.Console.WriteLine("© BigPO, Planethac");
            } else if (CommandID == 10) {
                CreateFile.Do(param);
            } else if (CommandID == 11) {
                RemoveFile.Do(param);
            } else if (CommandID == 12) {
                MoveDirectoryOrFile.Do(param, param2);
            } else if (CommandID == 13) {
                try
                {
                    CopyDirectoryOrFile.Do(param, param2);    
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    System.Console.WriteLine("How did you manage to do this? but:");
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine();
                }
            } else if (CommandID == 14) {
                LaunchUI.Do();
            }
        }
    }
}