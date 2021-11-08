using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;

namespace Wlan_hotcpot_Laucher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher5 =
        new ManagementObjectSearcher("root\\CIMV2",
            "SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher5.Get())
            {
                label2.Text = "Win32_OperatingSystem instance" +
                    "\n\nBuildNumber: " + queryObj["BuildNumber"] + 
                    "\nCaption: " + queryObj["Caption"] +
                    "\nFreePhysicalMemory: " + queryObj["FreePhysicalMemory"] +
                    "\nFreeVirtualMemory: " + queryObj["FreeVirtualMemory"] +
                "\nName: " + queryObj["Name"] +
                "\nOSType: " + queryObj["OSType"] +
                "\nRegisteredUser: " + queryObj["RegisteredUser"] +
                "\nSerialNumber: " + queryObj["SerialNumber"] +
                "\nServicePackMajorVersion: " + queryObj["ServicePackMajorVersion"] +
                "\nServicePackMinorVersion: " + queryObj["ServicePackMinorVersion"] +
                "\nStatus: " + queryObj["Status"] +
                "\nSystemDevice: " + queryObj["SystemDevice"] +
                "\nSystemDirectory: " + queryObj["SystemDirectory"] +
                "\nSystemDrive: " + queryObj["SystemDrive"] +
                "\nVersion: " + queryObj["Version"] +
                "\nWindowsDirectory: " + queryObj["WindowsDirectory"];
            }
        }
    }
}
