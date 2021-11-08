using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NativeWifi;
using System.Management;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;

namespace Wlan_hotcpot_Laucher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomManager cm = new CustomManager();
        //ManagerAdminSystem mas = new ManagerAdminSystem();
        OpenFileDialog ofd = new OpenFileDialog();
        INI ini = new INI(Environment.CurrentDirectory);
        Process proc = new Process();
        //string url = "http://ossproject.tk/Win7_custom/version.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            //lScreen.Text = cm.LoadApp(url);
        }
        
        

        private void Start_Click(object sender, EventArgs e)
        {
            
            if (textBoxPass.Text.Length<8)
            {
                MessageBox.Show("Пароль должен быть не меньше 8 символов");
            }
            else
            {
                if (Start.Text != "Стоп")
                {
                    ini.IniWriteValue("Sett", "ssidNam", textBoxSsid.Text);
                    ini.IniWriteValue("Sett", "pass", textBoxPass.Text);
                    
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = @"/C " + "netsh wlan start hostednetwork";
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.Start();
                    proc.WaitForExit();
                    this.Start.Text = "Стоп";
                }
                else
                {
                    proc.StartInfo.FileName = "cmd.exe";
                    proc.StartInfo.Arguments = /*@"/C " +*/ "netsh wlan stop hostednetwork";
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.Start();
                    proc.WaitForExit();
                    this.Start.Text = "Старт";
                }
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            ValuePass.Text = textBoxPass.Text.Length.ToString();
            if (textBoxPass.Text.Length < 8)
            {
                this.ValuePass.ForeColor = Color.Red;
                this.Start.Enabled = false;
            }
            else
            {
                this.ValuePass.ForeColor = Color.Black;
                this.Start.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBoxPass.PasswordChar = '*';
            }
            else
            {
                textBoxPass.PasswordChar = '\0';
            }
        }



        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abode = new About();
            abode.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Process.Start("netsh", "wlan stop hostednetwork");
            Process.Start("netsh", "wlan start hostednetwork");
        }

        private void btView_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Image img = Image.FromFile(ofd.FileName);
            FileInfo fi = new FileInfo(ofd.FileName);
            ofd.Filter = "Image file (*.jpg, *.jpeg)|*.jpg; *.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbPathFile.Text = ofd.FileName;
                pbImage.Image = img;
                lPicSize.Text = "Разрешение изображение: " + Convert.ToString(img.Width) + "*" + Convert.ToString(img.Height);
                int sizefile = (int)fi.Length / 1024;
                if (img.Height != Screen.PrimaryScreen.Bounds.Height)
                {
                    this.lPicSize.ForeColor = Color.Red;
                    this.btStaring.Enabled = false;
                }
                else if (img.Width != Screen.PrimaryScreen.Bounds.Width)
                {
                    this.lPicSize.ForeColor = Color.Red;
                    this.btStaring.Enabled = false;
                }
                else if (sizefile != 256)
                {
                    //this.lPicSize.ForeColor = Color.Red;
                    this.btStaring.Enabled = false;
                    Label newlabel = new Label();
                        newlabel.Size = new System.Drawing.Size(35, 13);
                        newlabel.Location = new Point(15, 149);
                        newlabel.Name = "label3";
                        newlabel.Text = "Больше 256 Кб: " + sizefile + " Kб";
                        newlabel.ForeColor = Color.Red;
                        newlabel.AutoEllipsis = false;
                        newlabel.AutoSize = true;
                        Controls.Add(newlabel);
                }
            }
        }
        
        
    }
}
