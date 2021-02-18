using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public partial class Register : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        void StartExe(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        public Register()
        {
            InitializeComponent();
        }

        void SelectTab(int key)
        {
            if(key == 1){
                RegisterButton.BackColor = Color.FromArgb(91, 119, 161);
                AboutButton.BackColor = Color.FromArgb(17, 24, 34);
                TabText.Text = "Register";
            }
            if (key == 2){
                AboutButton.BackColor = Color.FromArgb(91, 119, 161);
                RegisterButton.BackColor = Color.FromArgb(17, 24, 34);
                TabText.Text = "About";
            }
            if (key == 3){
                RegisterButton.BackColor = Color.FromArgb(91, 119, 161);
                AboutButton.BackColor = Color.FromArgb(17, 24, 34);
                TabText.Text = "Register";
            }
            TabControl.SelectedIndex = key - 1;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            SelectTab(1);
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SelectTab(1);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            SelectTab(2);
        }

        private void Tab2GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/inc-Majdev");
        }

        private void Tab1RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string character = "abcdefghijklmnoprstuvyz123456789";
            string newString = "";
            for (int i = 0; i < 10; i++){
                newString += character[random.Next(character.Length)];
            }
            Tab1PasswordText.Text = newString;
        }

        private void Tab1RegisterButton_Click(object sender, EventArgs e)
        {
            CoreLibrary.CreateDevice(Tab1PasswordText.Text);
            Struct.ID = Core_Regedit.Read("ID");
            CoreLibrary.CreateData();
            CoreLibrary.SendStatus(Struct.ID);
            CoreLibrary.SendData(Struct.ID, CoreLibrary.CreateData());
            Tab3ID.Text = "ID: " + Struct.ID;
            Tab3Password.Text = "Password: " + Tab1PasswordText.Text;
            SelectTab(3);
        }

        private void Tab3RestartButton_Click(object sender, EventArgs e)
        {
            string newPath = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\" + System.AppDomain.CurrentDomain.FriendlyName;
            File.Copy(Application.ExecutablePath, newPath, true);
            StartExe(newPath);
            Application.Exit();
        }

        private void LeftWidget_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Tab1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Tab2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Tab3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
