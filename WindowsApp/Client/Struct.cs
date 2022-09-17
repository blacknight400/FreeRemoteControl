using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Struct
    {
        public static string ID;
        public static bool Lan = false;
        public static bool KillerPower = false;

        public static string Data = null;
        public static string Computer_Data = null;
        public static string Apps;

        public static void WriteLogo(){
            string Logo = @"
  __  __    ____    ___    ____    _____ 
 |  \/  |  / ___|  / _ \  |  _ \  | ____|
 | |\/| | | |     | | | | | |_) | |  _|  
 | |  | | | |___  | |_| | |  _ <  | |___ 
 |_|  |_|  \____|  \___/  |_| \_\ |_____|
                                                                                                            ";
            Console.WriteLine(Logo);
        }

        public static void Command(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C " + command,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
        }
    }
}
