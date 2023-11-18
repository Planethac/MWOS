using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace quantumnt
{
    public class DiskIE
    {
        public static DriveInfo[] allDrives = DriveInfo.GetDrives();
        public static void drvHelp(string gdiagtf)
        {
            Console.WriteLine("Found {0} Drives", allDrives.Length.ToString());
            System.Console.WriteLine();
            int ligmabals /*Im very creative ik */ = 0;
            foreach (DriveInfo driveInfo in allDrives)
            {
                string volLab;
                int loopcount = 11;
                if (gdiagtf == "gdiag")
                {
                    loopcount = 101;
                }
                int loop = 0;
                if (driveInfo.VolumeLabel == "")
                {
                    volLab = "Local Disk";
                } else 
                {
                    volLab = driveInfo.VolumeLabel;
                }
                System.Console.WriteLine("Disk {0}: [{1}] Name: {2}", ligmabals, driveInfo.Name, volLab);
                System.Console.WriteLine("Total Space: {0} B / {1} GB", driveInfo.TotalSize, driveInfo.TotalSize / 1000000000);
                System.Console.WriteLine("Avilabel Space: {0} B / {1} GB", driveInfo.AvailableFreeSpace, driveInfo.AvailableFreeSpace / 1000000000);
                float freespace = (int)((double)driveInfo.AvailableFreeSpace / driveInfo.TotalSize * 100);
                if (gdiagtf != "gdiag")
                {
                    freespace = freespace / 10;
                }
                int free = Convert.ToInt32(freespace);
                Console.Write("[");
                while (loop != loopcount)
                {
                    if (free >= 0)
                    {
                        Console.Write("#");
                    } else {
                        Console.Write("-");
                    }
                    free--;
                    loop++;
                }
                Console.Write("]\n");
                System.Console.WriteLine("{0}", driveInfo.DriveFormat);
                System.Console.WriteLine("{0}", driveInfo.DriveType);
                System.Console.WriteLine();
                System.Console.WriteLine();
                ligmabals++;
            }
        }
    }
}