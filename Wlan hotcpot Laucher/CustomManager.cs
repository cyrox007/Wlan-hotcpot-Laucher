using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlan_hotcpot_Laucher
{
    class CustomManager
    {
        INI ini = new INI(Environment.CurrentDirectory);
        Process proc = new Process();
        string ssidstring;
        string passstring;
        public string LoadApp (string urlVersion)
        {
            try
            {
                if (Internet.CheckConnection())
                {
                    //процедура обновления
                    Version currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                    WebClient http = new WebClient();
                    Version latestVersion = new Version(http.DownloadString(urlVersion));
                    if (latestVersion > currentVersion)
                    {
                        Process.Start("Update.exe");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            finally
            {
                ssidstring = ini.IniReadValue("Sett", "ssidNam");
                passstring = ini.IniReadValue("Sett", "pass");
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = "/r netsh wlan set hostednetwork mode=allow ssid=" + ssidstring + " key=" + passstring;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            string SizeScreen = "Разрешение экрана: " + Screen.PrimaryScreen.Bounds.Width + " * " + Screen.PrimaryScreen.Bounds.Height;
            return SizeScreen;
        }
    }
}
