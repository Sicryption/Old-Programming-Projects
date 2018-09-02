using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;

namespace MW2_Random_Testing
{
    public partial class Form1 : Form
    {
        JRPC Jtag = new JRPC();
        int client = 0;
        public Form1()
        {
            InitializeComponent();
        }

        uint getPlayerState(int ClientIndex)
        {
            return (uint)(0x830CBF80 + (ClientIndex * 0x3700));
        } 

        bool connected()
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(connected())
            {
                //Jtag.WriteFloat(getPlayerState(client) + 0x28, 100);
                //Jtag.WriteFloat(getPlayerState(client) + 0x2C, 100);
                Jtag.WriteFloat(getPlayerState(client) + 0x30, 10000);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            client = (int)numericUpDown1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            if(connected())
                MessageBox.Show(Jtag.ReadInt16(Convert.ToUInt32(textBox1.Text, 16)).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
