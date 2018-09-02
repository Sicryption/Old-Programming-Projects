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

namespace MW2_Position
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

        uint getPlayerState(int client)
        {
            return (uint)(0x82F03600 + (client * 0x280));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x.Value = (decimal)Jtag.ReadFloat(getPlayerState((int)numericUpDown1.Value) + 0x1C);
            y.Value = (decimal)Jtag.ReadFloat(getPlayerState((int)numericUpDown1.Value) + 0x20);
            z.Value = (decimal)Jtag.ReadFloat(getPlayerState((int)numericUpDown1.Value) + 0x24);
            SpawnModel("com_plasticcase_friendly", (float)x.Value, (float)y.Value, (float)z.Value, (float)0, (float)0, (float)0); 
        }
        
        void SpawnModel(string Model, float X, float Y, float Z, float AngleX, float AngleY, float AngleZ) 
        {
            uint flag = Jtag.Call(0x8220DBE8); 
            Jtag.WriteInt32(flag + 0x04, 0x06);
            Jtag.WriteInt32(flag + 0x11C, 0x2080);
            Jtag.WriteInt32(flag + 0x174, 0x11E4);
            //Jtag.ReadInt16(G_GetModelIndex(Model)
            //Jtag.ReadInt32(flag + 0x168, = G_GetModelIndex(Model); 
          
            Jtag.WriteFloat(flag + 0x138, X);
            Jtag.WriteFloat(flag + 0x13C, Y);
            Jtag.WriteFloat(flag + 0x140, Z);
            Jtag.WriteFloat(flag + 0x144, AngleX);
            Jtag.WriteFloat(flag + 0x148, AngleY);
            Jtag.WriteFloat(flag + 0x14C, AngleZ);
            Jtag.Call(0x820E22C0, flag); 
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                MessageBox.Show("I SUCK COCK");
            }
            else
            {
                MessageBox.Show("I failed :'(");
            }
        }
    }
}
