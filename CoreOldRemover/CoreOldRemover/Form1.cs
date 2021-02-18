using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOldRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(0, 0);
            try{
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("mCore", true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("ID");

                    }
                }
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey("Core", true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("ID");
                    }
                }
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("mCore");
                    }
                }
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("Core");
                    }
                }
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    if (Key != null)
                    {
                        Key.DeleteValue("Client");
                    }
                }
            }
            catch { }
            MessageBox.Show("All data has been removed, You can download and install the new version!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                Application.Exit();
            }
        }
    }
}
