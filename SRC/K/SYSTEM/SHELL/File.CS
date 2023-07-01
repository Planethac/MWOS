using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quantumnt
{
    public static class MakeDirectory
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
                Directory.CreateDirectory(fullPath);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class RemoveDirectory
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
                Directory.Delete(fullPath);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class CreateFile
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
                File.Create(fullPath);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class RemoveFile
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
                File.Delete(fullPath);
            }
            catch (System.UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class MoveDirectoryOrFile
    {
        public static void Do(string path, string location)
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
            string fullLocation = "";
            int i2 = 1;
            if (amountParam == 1) fullLocation = location;
            if (amountParam >= 2)
            {
                fullLocation = fullLocation + cmdshell.ParamPB[1];
                while (i2 != amountParam)
                {
                fullLocation = fullLocation + " " + cmdshell.ParamPB[i + 1];
                i++;            
                }
            }
            try
            {
                if (Directory.Exists(fullPath))
                {
                    Directory.Move(fullPath, fullLocation);
                } else if (File.Exists(fullPath))
                {
                    File.Move(fullPath, fullLocation);
                }
            }
            catch (System.UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
    public static class CopyDirectoryOrFile
    {
        public static void Do(string path, string location)
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
            string fullLocation = "";
            int i2 = 1;
            if (amountParam == 1) fullLocation = location;
            if (amountParam >= 2)
            {
                fullLocation = fullLocation + cmdshell.ParamPB[1];
                while (i2 != amountParam)
                {
                fullLocation = fullLocation + " " + cmdshell.ParamPB[i + 1];
                i++;            
                }
            }
            try
            {
                if (Directory.Exists(fullPath))
                {
                    try
                    {
                        cp.CopyDirectory(fullPath, fullLocation, true);
                    }
                    catch (System.Exception)
                    {
                        
                        throw;
                    }        
                }
            }
            catch (System.UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
            catch (System.IO.IOException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine();
            }
        }
    }
}