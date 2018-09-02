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

namespace Map_Editor
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
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Check your plugins");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Jtag.Call(0x82439B90, new object[] { 0, "set ui_mapname " + textBox1.Text });
        }
    }
}
