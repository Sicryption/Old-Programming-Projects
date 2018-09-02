using System;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using DevComponents.DotNetBar;
using JRPC_Client;

namespace WindowsFormsApplication6
{
    public partial class Form2 : DevComponents.DotNetBar.Office2007Form
    {
        CorRev form1 = new CorRev();
        public string userType = null;
        public string userName;
        public string passWord;
        public Form2()
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string stoof = new WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/buisness-history");
            string stoof2 = new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/platform-for-change");
            if ((user != "") && (pass != ""))
            {
                userName = Method_1(Method_0(user));
                passWord = Method_1(Method_0(pass));
                if (stoof.Contains(userName + "|" + passWord))
                {
                    if (checkBox1.Checked)
                    {
                        File.WriteAllText(Directory.GetCurrentDirectory() + "\\AutoLogin.txt", (string)(userName + "|" + passWord));
                    }
                    else
                    {
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\AutoLogin.txt"))
                        {
                            File.Delete(Directory.GetCurrentDirectory() + "\\AutoLogin.txt");
                        }
                    }
                    form1.ShowDialog();
                    userType = "User";
                    if (stoof2.Contains(userName + "|" + passWord))
                    {
                        userType = "Premium";
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
        }

        public static string Method_0(string IP)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(IP);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        
        public static string Method_1(string CPU)
        {
            MD5 Tru = new MD5CryptoServiceProvider();
            Tru.ComputeHash(ASCIIEncoding.ASCII.GetBytes(CPU));
            byte[] result = Tru.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        public static string Generate_1()//Get HWID
        {
            ManagementObjectCollection objects = null;
            objects = new ManagementObjectSearcher("Select * From Win32_processor").Get();
            string str = "";
            foreach (ManagementObject obj2 in objects)
            {
                str = obj2["ProcessorID"].ToString();
            }
            ManagementObject obj3 = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            obj3.Get();
            string str2 = obj3["VolumeSerialNumber"].ToString();
            return (str + str2);
        }

        public static string Generate_2()//Hardware Serial #
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["SerialNumber"] != null)
                    return wmi_HD["SerialNumber"].ToString();
            }

            return string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string stoof = new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/buisness-history");
            string stoof2 = new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/platform-for-change");
            if (File.Exists(Directory.GetCurrentDirectory() + "\\AutoLogin.txt"))
            {
                string diretory = Directory.GetCurrentDirectory();
                string cu = File.ReadAllText(Directory.GetCurrentDirectory() + "\\AutoLogin.txt");
                if (cu != "")
                {
                    if (stoof.Contains(cu))
                    {
                        form1.skiplogin = true;
                        this.Hide();
                        form1.ShowDialog();
                        userType = "User";
                        if (stoof2.Contains(cu))
                        {
                            userType = "Premium";
                        }
                        this.Dispose();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            form1.user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            form1.pass = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}