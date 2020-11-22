using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;
using System.Windows.Forms;

namespace mCore
{
    static public class mCore_Controls
    {
        public static string Key = "0X8BADSJGF23!!^?=)";
        public static string Path = "https://core.majdev.net/";
        static public bool CheckID()
        {
            string id = mCore_Regedit.Read("ID");
            if(id == null){
                return false;
            }
            else
            {
                if(id.Length == 3){
                    return true;
                }
                else{
                    return false;
                }
            }
        }

        static public bool CheckLan()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        static public bool CheckServer()
        {
            try{
                if (CheckLan() == true){
                    WebClient client = new WebClient();
                    string value = client.DownloadString(Path + "core_checkserver.php");
                    if (value == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            catch{
                return false;
            }
        }
        static public string CreateDevice(string password)
        {
            WebClient client = new WebClient();
            string id = client.DownloadString(Path + "core_createdevice.php?key=" + Key + "&password=" + password);
            mCore_Regedit.Create("ID", id);
            return id;
        }

        static public void SendStatus(string id)
        {
            WebClient client = new WebClient();
            client.DownloadString(Path + "core_sendstatus.php?key=" + Key + "&id=" + id);
        }

        static public void SendData(string id, string data)
        {
            WebClient client = new WebClient();
            client.DownloadString(Path + "core_senddata.php?key=" + Key + "&id=" + id + "&data=" + data);
        }
        static public string SendTaskReset(string id)
        {
            WebClient client = new WebClient();
            return client.DownloadString(Path + "core_sendtaskreset.php?key=" + Key + "&id=" + id);
        }

        static public string ChechTask(string id)
        {
            WebClient client = new WebClient();
            return client.DownloadString(Path + "core_checktask.php?key=" + Key + "&id=" + id);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        static string Data = null;
        static string Computer_Data = null;
        static string Apps;
        static public string CreateData()
        {
            if(Computer_Data == null){       
            string st1 = Dns.GetHostName() + "*|*" + Environment.UserName;
            string st2 = mCore_Computer.CPUName() + "*|*" + mCore_Computer.GPUName() + "*|*" + mCore_Computer.RAMSize() + "*|*" + mCore_Computer.OSInfo();
            string st3 = mCore_Computer.IP();
                Computer_Data = st1 + "!=!" + st2 + "!=!" + st3;
            }

            Apps = "";
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    Apps = Apps + p.ProcessName + ".exe?%%?";
                }
            }


            Data = Computer_Data + "^*^" + Apps;
            return Base64Encode(Data);
        }
    }

    static public class mCore_Regedit
    {
        public static string App = "mCore";
        public static void Create(string name, string data)
        {
            Registry.CurrentUser.CreateSubKey(App);
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            regedit.SetValue(name, data);
        }
        public static string Read(string name)
        {
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            if (regedit != null)
            {
                object data = regedit.GetValue(name);
                if (data != null)
                {
                    return data.ToString();
                }
                else{
                    return null;
                }
            }
            else{
                return null;
            }
        }
        public static void AddStatup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(App, "\"" + Application.ExecutablePath + "\"");
        }
    }

    static public class mCore_Computer
    {
        public static string CPUName()
        {
            try{
                string name = null;
                ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject moProcessor in mosProcessor.Get())
                {
                    name = moProcessor["name"].ToString();
                }
                return name;
            }
            catch{
                return "#ERROR";
            }
        }
        public static string GPUName()
        {
            try {
                string name = null;
                ManagementObjectSearcher vidSearcher = new ManagementObjectSearcher("Select * from Win32_VideoController Where availability='3'");
                foreach (ManagementObject mObject in vidSearcher.Get())
                {
                    name = mObject["name"].ToString();
                }
                return name;
            }
            catch{
                return "#ERROR";
            }
        }
        public static string RAMSize()
        {
            try{
                string size = null;
                ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
                foreach (ManagementObject mObject in ramSearcher.Get())
                {
                    double Ram_Bytes = (Convert.ToDouble(mObject["TotalPhysicalMemory"]));
                    double ramgb = Ram_Bytes / 1073741824;
                    double ramSize = Math.Ceiling(ramgb);
                    size = ramSize.ToString() + " GB";
                }
                return size;
            }
            catch{
                return "#ERROR";
            }  
        }
        public static string OSInfo()
        {
            try {
                string osSerial = null;
                string osVersionInfo = null;
                string OSinfo = null;
                ManagementObjectSearcher osInfo = new ManagementObjectSearcher("Select * From Win32_OperatingSystem");
                foreach (ManagementObject osInfoObj in osInfo.Get())
                {
                    osSerial = (string)osInfoObj["Caption"];
                    osVersionInfo = (string)osInfoObj["Version"];
                    OSinfo = osSerial + " - " + osVersionInfo;
                }
                return OSinfo;
            }
            catch{
                return "#ERROR";
            } 
        }
        public static string IP()
        {
            try{
                WebClient client = new WebClient();
                return client.DownloadString("http://checkip.dyndns.org/").Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", "").Replace("</body></html>", "").Replace("\n", "");
            }
            catch {
                return "#ERROR";
            }
        }
    }
}
