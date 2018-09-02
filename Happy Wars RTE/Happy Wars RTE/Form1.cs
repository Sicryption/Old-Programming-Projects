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

namespace Happy_Wars_RTE
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(250, 78);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                MessageBox.Show("Connected");
                this.Size = new Size(250, 300);
            }
            else
            {
                MessageBox.Show("Not Connected");
                this.Size = new Size(250, 78);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intValue;
            byte[] intBytes = BitConverter.GetBytes((int)numericUpDown1.Value);
            Array.Reverse(intBytes);
            byte[] result = intBytes;
            Jtag.SetMemory(0x83E9DE9C, result);
        }
    }
}
