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

namespace Titanfall
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Jtag.GetMemory(0xCA5DE098, 0x25)[0].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded by: Unsigned Chaos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.dieselgaming.com");
        }
    }
}
