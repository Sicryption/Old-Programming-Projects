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

namespace BO2_Camo_Changer_TU16
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
        }

        public uint getPlayerState(int clientIndex)
        {
            return (uint)(0x8354E510 + (clientIndex * 0x57f8));
        }

        string camoName = "DEVGRU";

        private void button1_Click(object sender, EventArgs e)
        {
            _changeCamo(comboBox1.Text, (int)numericUpDown1.Value);
        }
		
		public void forceChangeCamo(byte data)
		{
			Jtag.xbCon.DebugTarget.SetMemory(getPlayerState(client) + 0x2BF, 1, new byte[] { data }, out num);
            Jtag.xbCon.DebugTarget.SetMemory(getPlayerState(client) + 0x2DB, 1, new byte[] { data }, out num);
		}
		
        public void _changeCamo(string camoName, int client)
        {
            uint num;
            if (camoName == "DEVGRU")
				forceChangeCamo(1);
            if (camoName == "A-TACS AU")
				forceChangeCamo(2);
            if (camoName == "ERDL")
				forceChangeCamo(3);
            if (camoName == "Siberia")
				forceChangeCamo(4);
            if (camoName == "Choco")
				forceChangeCamo(5);
            if (camoName == "Blue Tiger")
				forceChangeCamo(6);
            if (camoName == "Bloodshot")
				forceChangeCamo(7);
            if (camoName == "Ghostex: Delta 6")
				forceChangeCamo(8);
            if (camoName == "Kryptek: Typhon")
				forceChangeCamo(9);
            if (camoName == "Carbon Fiber")
				forceChangeCamo(10);
            if (camoName == "Cherry Blossom")
				forceChangeCamo(11);
            if (camoName == "Art of War")
				forceChangeCamo(12);
            if (camoName == "Ronin")
				forceChangeCamo(13);
            if (camoName == "Skulls")
				forceChangeCamo(14);
            if (camoName == "Gold")
				forceChangeCamo(15);
            if (camoName == "Diamond")
				forceChangeCamo(0x10);
            if (camoName == "CE Digital")
				forceChangeCamo(0x12);
            if (camoName == "Elite Member")
				forceChangeCamo(0x11);
            if (camoName == "Jungle Warfare")
				forceChangeCamo(1);
            if (camoName == "Benjamins")
				forceChangeCamo(0x15);
            if (camoName == "Dia de Muertos")
				forceChangeCamo(0x16);
            if (camoName == "Graffiti")
				forceChangeCamo(0x17);
            if (camoName == "Kawaii")
				forceChangeCamo(0x18);
            if (camoName == "Party Rock")
				forceChangeCamo(0x19);
            if (camoName == "Zombies")
				forceChangeCamo(0x1a);
            if (camoName == "Viper")
				forceChangeCamo(0x1b);
            if (camoName == "Bacon")
				forceChangeCamo(0x1c);
            if (camoName == "Random Color")
				forceChangeCamo(0x20);
            if (camoName == "Ghost")
				forceChangeCamo(0x1d);
            if (camoName == "Paladin")
				forceChangeCamo(0x30);
            if (camoName == "Comics")
				forceChangeCamo(0x21);
            if (camoName == "Dragon")
				forceChangeCamo(0x22);
            if (camoName == "Cyborg")
				forceChangeCamo(0x1f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                MessageBox.Show("Connected to Console Successfully!");
            }
            else
            {
                MessageBox.Show("Failed to connect to your console.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
