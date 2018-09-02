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
using JRPC_Client;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        JRPC Console = new JRPC();
        uint getPlayerState(uint clientNum)//TU8
        {
            return 0x8328F100 + (clientNum * 0x3600);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ASCIIEncoding encoding = new ASCIIEncoding();
            try
            {
                for (int clients = 0; clients < 12; clients++)
                {
                    byte[] memory = this.Jtag.GetMemory(getPlayerState((uint)clients) + 0x2f9c, 0x10);
                    string str = encoding.GetString(memory);
                    listBox1.Items.Add("Client " + clients + ": " + str);
                }
            }
            catch (Exception)
            {

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string i = null;
            int n = textBox1.TextLength;
            while (n > 0)
            {
                i = i + " ";
                n--;
            }
            Console.WriteString(getPlayerState((uint)listBox1.SelectedIndex) + 0x2F9C, i);
            Console.WriteString(getPlayerState((uint)listBox1.SelectedIndex) + 0x2F9C, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Jtag.Connect();
            Console.Connect();
            if (Console.activeConnection && Jtag.activeConnection)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Fix your plugins");
            }
        }
    }
}
