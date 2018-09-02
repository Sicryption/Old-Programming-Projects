using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;

namespace BO2_TU18_XUID_Spoofer
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Created by: Unsigned Chaos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.dieselgaming.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                MessageBox.Show("Successfully connected to the default console!");
                groupBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Unable to connect to the default console.");
                groupBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASCIIEncoding r = new ASCIIEncoding();
            Jtag.SetMemory(0x841E1B30, r.GetBytes(textBox1.Text));
            Jtag.SetMemory(0x841E1B50, hexString(textBox2.Text));
        }

        public string ConvertStringToHex(string asciiString)
        {
            string str = "";
            foreach (char ch in asciiString)
            {
                int num = ch;
                if (num == 0)
                {
                    return str;
                }
                str = str + string.Format("{0:x2}", Convert.ToUInt32(num.ToString()));
            }
            return str;
        }

        public byte[] hexString(string hex)
        {
            Func<int, byte> func2 = null;
            Func<int, byte> selector = null;
            try
            {
                hex = hex.Replace(" ", "").Replace("0x", "");
                if (selector == null)
                {
                    if (func2 == null)
                    {
                        func2 = x => Convert.ToByte(hex.Substring(x, 2), 0x10);
                    }
                    selector = func2;
                }
                return (from x in Enumerable.Range(0, hex.Length)
                        where (x % 2) == 0
                        select x).Select<int, byte>(selector).ToArray<byte>();
            }
            catch (Exception)
            {
                return new byte[1];
            }
        }
    }
}
