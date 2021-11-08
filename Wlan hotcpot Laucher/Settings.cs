using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlan_hotcpot_Laucher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        INI ini = new INI(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WlanLaunchDoc\set.ini");
        private void textBoxSetPass_TextChanged(object sender, EventArgs e)
        {
            labelValue.Text = textBoxSetPass.Text.Length.ToString();
            if (textBoxSetPass.Text.Length < 8)
            {
                this.labelValue.ForeColor = Color.Red;
                this.Save.Enabled = false;
            }
            else
            {
                this.labelValue.ForeColor = Color.Black;
                this.Save.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ini.IniWriteValue("Sett", "ssidNam", textBoxSetSsid.Text);
            ini.IniWriteValue("Sett", "pass", textBoxSetPass.Text);
        }
    }
}
