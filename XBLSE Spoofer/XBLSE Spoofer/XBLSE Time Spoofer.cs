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

namespace XBLSE_Spoofer
{
    public partial class Form1 : Form
    {
        XRPC XBLSE = new XRPC();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XBLSE.Connect();
            if (XBLSE.activeConnection)
            {
                label1.Text = "Connection Successful | #FuckedXBLSE";
            }
            else
            {
                label1.Text = "Connection Failed | #FuckedXBLSE";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASCIIEncoding r;
            r = new ASCIIEncoding();
            byte[] data = r.GetBytes(textBox1.Text);
            Array.Reverse(data);
            XBLSE.SetMemory(0x7206812, data);
        }
    }
}
