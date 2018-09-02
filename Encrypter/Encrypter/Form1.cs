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
using System.Windows.Forms;

namespace Encrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Method_1(Method_0(textBox1.Text));
        }
    }
}
