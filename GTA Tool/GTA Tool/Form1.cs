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
using XRPCPlusPlus;

namespace GTA_Tool
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
            if (Jtag.activeConnection)
                MessageBox.Show("Connected");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes((int)money.Value);
            Array.Reverse(bytes);
            byte[] buffer3 = new byte[] { 60, 0x60, 0, 0, 0x60, 0x63, 0, 0 };
            buffer3[2] = bytes[0];
            buffer3[3] = bytes[1];
            buffer3[6] = bytes[2];
            buffer3[7] = bytes[3];
            Jtag.SetMemory(0x82C7C5D0, buffer3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes((int)bank.Value);
            Array.Reverse(bytes);
            byte[] buffer3 = new byte[] { 60, 0x60, 0, 0, 0x60, 0x63, 0, 0 };
            buffer3[2] = bytes[0];
            buffer3[3] = bytes[1];
            buffer3[6] = bytes[2];
            buffer3[7] = bytes[3];
            Jtag.SetMemory(0x82C7C6E8, buffer3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Jtag.WriteFloat(0x82004F24, 0.5f);
            else
                Jtag.WriteFloat(0x82004F24, 0.166667f);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                Jtag.WriteFloat(0x82034E40, 2.003906f);
            else
                Jtag.WriteFloat(0x82034E40, -0.1f);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                Jtag.SetMemory(0x827DAAA4, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            else
                Jtag.SetMemory(0x827DAAA4, new byte[] { 0xD0, 0x3F, 0x00, 0xC0 });
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
                Jtag.WriteFloat(0x8200A4C0, (float)1E-05);
            else
                Jtag.WriteFloat(0x8200A4C0, (float)1);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Jtag.SetMemory(0x8344792C, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            Jtag.SetMemory(0x83447938, new byte[] { 0x60, 0x00, 0x00, 0x00 });
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Jtag.Call(0x82C407D0, "SNOW");
        }
    }
}
