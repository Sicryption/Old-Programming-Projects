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
using XRPCLib;

namespace WindowsFormsApplication9
{
    public partial class xPublic_Cheater : Form
    {
        XRPC Jtag = new XRPC();
        int client = -1;
        int FormX;
        int FormY;
        uint Cbuf_AddText = 0x82437490;//TU7
        string[] gamename = { "dom", "dm", "war", "sd", "infection", "conf", "grind", "blitz", "cranked" };
        uint jump = 0x820155CC;//TU7
        uint falldmg = 0x822213A8 + 0x74;//TU7
        uint UAVOFFSET = 0x8225591F; //Advanced Uav (01 On - 00 Off) TU7
        uint Laser = 0x8226F5C3; //Laser (01 On - 00 Off) TU7
        uint ChromePlayers = 0x82654D3B; //Chrome Players (01 On - 00 Off) TU7
        uint NoRecoilOFFSET = 0x822B92B4; //Norecoil (60000000 On - 4BF8B765 Off) TU7
        uint Ammo = 0x82238950;//TU7
        uint autoguns = 0x82233C4C;//TU7
        uint Boxes = 0x8225D58C;//TU7
        int Client = -1;
        uint getPlayerState(uint clientNum)//TU7
        {
            return 0x8328B700 + (clientNum * 0x3600);
        }
        uint gEntity(uint clientNum)//TU7
        {
            return 0x83302B80 + (clientNum * 0x280);
        }
        JRPC Console = new JRPC();
        public xPublic_Cheater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string contents = new System.Net.WebClient().DownloadString("http://pastebin.com/Df6CvTnL");
            string currentversion = Application.ProductVersion;
            if (contents.Contains(currentversion))
            {
                Updatel.Enabled = false;
            }
            else
            {
                Updatel.Enabled = true;
            }
            FormX = this.Size.Width;
            FormY = this.Size.Height;
            this.Size = new Size(320, 75);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }

        private void Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is an update! Click Okay to start the download!");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/7i766oh4n2db21g/xPublic%20Cheater.rar");
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Console.Connect();
                if (Console.activeConnection)
                {
                    this.Size = new Size(FormX, FormY);
                    MessageBox.Show("Connection to Console Succesful!");
                }
                else
                {
                    MessageBox.Show("Unable to connect to the console. \r\nMake sure JRPC.xex is set as a plugin,");
                }
            }
            catch
            {
                MessageBox.Show("Unable to connect to the console. \r\nMake sure JRPC.xex is set as a plugin,");
            }
        }

        private void All(bool cor)
        {
            Godmode.Enabled = cor;
            NoClip.Enabled = cor;
            UFO.Enabled = cor;
            Freeze.Enabled = cor;
            UAV.Enabled = cor;
            NoRecoil.Enabled = cor;
            TinyCrosshairs.Enabled = cor;
            ThirdPerson.Enabled = cor;
            switchButton10.Enabled = cor;
            switchButton7.Enabled = cor;
            switchButton16.Enabled = cor;
            switchButton11.Enabled = cor;
            button1.Enabled = cor;
            button2.Enabled = cor;
            button3.Enabled = cor;
            button5.Enabled = cor;
            button6.Enabled = cor;
            button7.Enabled = cor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            try
            {
                for (int clients = 0; clients < 12; clients++)
                {
                    byte[] gt = Console.Memory.GetMemory(getPlayerState((uint)clients) + 0x2f9c, 0x10);
                    string str = encoding.GetString(gt);
                    if (str.Equals(Gamertag.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        client = (int)clients;
                        MessageBox.Show("Gamertag Verified");
                        All(true);
                        break;
                    }
                    else
                    {
                        client = -1;
                        All(false);
                    }
                }
                if (client == -1)
                {
                    MessageBox.Show("Gamertag Incorrect or not in-game.");
                }
            }
            catch (Exception)
            {

            }
        }

        private void Godmode_ValueChanged(object sender, EventArgs e)
        {
            if (Godmode.Value == false && Console.Memory.ReadUInt32(gEntity((uint)client) + 0x18C) != 0)
            {
                Console.Memory.WriteUInt32(gEntity((uint)client) + 0x18C, 0);
            }
            else
            {
                Console.Memory.WriteUInt32(gEntity((uint)client) + 0x18C, 1);
            }
        }

        private void mFlags(int flag)
        {
            Console.Memory.WriteInt32((getPlayerState((uint)client)) + 0x3218, flag);
        }

        private void NoClip_ValueChanged(object sender, EventArgs e)
        {
            if (NoClip.Value == true)
            {
                mFlags(1);
                UFO.Value = false;
                Freeze.Value = false;
            }
            else
            {
                mFlags(0);
            }
        }

        private void UFO_ValueChanged(object sender, EventArgs e)
        {
            if (UFO.Value == true)
            {
                mFlags(2);
                NoClip.Value = false;
                Freeze.Value = false;
            }
            else
            {
                mFlags(0);
            }
        }

        private void Freeze_ValueChanged(object sender, EventArgs e)
        {
            if (Freeze.Value == true)
            {
                mFlags(4);
                UFO.Value = false;
                NoClip.Value = false;
            }
            else
            {
                mFlags(0);
            }
        }

        private void UAV_ValueChanged(object sender, EventArgs e)
        {
            if (UAV.Value == true)
            {
                Console.Memory.SetMemory(UAVOFFSET, new byte[] { 01 });
            }
            else
            {
                Console.Memory.SetMemory(UAVOFFSET, new byte[] { 00 });
            }
        }

        private void NoRecoil_ValueChanged(object sender, EventArgs e)
        {
            if (NoRecoil.Value == true)
            {
                Console.Memory.SetMemory(NoRecoilOFFSET, new byte[] { 01 });
            }
            else
            {
                Console.Memory.SetMemory(NoRecoilOFFSET, new byte[] { 00 });
            }
        }

        private void TinyCrosshairs_ValueChanged(object sender, EventArgs e)
        {
            if (TinyCrosshairs.Value == true)
            {
                Console.Memory.WriteInt32(getPlayerState((uint)client) + 0x430, 0);
                Console.Memory.WriteUInt32(getPlayerState((uint)client) + 0x434, 2);
            }
            else
            {
                Console.Memory.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
            }
        }

        private void ThirdPerson_ValueChanged(object sender, EventArgs e)
        {
            if (ThirdPerson.Value == true)
            {
                Console.CallVoid(Cbuf_AddText, new object[] { 0, "set camera_thirdPerson \"1\"" });
            }
            else
            {
                Console.CallVoid(Cbuf_AddText, new object[] { 0, "set camera_thirdPerson \"0\"" });
            }
        }

        private void switchButton10_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton10.Value == true)
            {
                Console.Memory.SetMemory(ChromePlayers, new byte[] { 01 });
            }
            else
            {
                Console.Memory.SetMemory(ChromePlayers, new byte[] { 00 });
            }
        }

        private void switchButton7_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton7.Value == true)
            {
                Console.Memory.SetMemory(Laser, new byte[] { 01 });
            }
            else
            {
                Console.Memory.SetMemory(Laser, new byte[] { 00 });
            }
        }

        private void switchButton16_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton16.Value == true)
            {
                Console.Memory.OR_UInt32(getPlayerState((uint)client) + 0x124, 0x20);
            }
            else
            {
                Console.Memory.AND_Int32(getPlayerState((uint)client) + 0x124, ~0x20);
            }
        }

        private void switchButton11_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton16.Value == true)
            {
                Console.CallVoid(Cbuf_AddText, new object[] { 0, "set r_znear 45" }); 
            }
            else
            {
                Console.CallVoid(Cbuf_AddText, new object[] { 0, "set r_znear 4" }); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Memory.NOP(Ammo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Memory.NOP(Boxes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Memory.NOP(autoguns);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set party_minplayers \"1\"" });
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set hostmigration \"0\"" });
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set host \"1\"" });
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set migration_timeBetween \"30000\"" });
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set migration_msgtimeout \"500\"" });
            Console.CallVoid(Cbuf_AddText, new object[] { 0, "set badhost_maxHappyPingTime \"400\"" });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 9; n++)
            {
                this.Jtag.Call(Cbuf_AddText, new object[] { 0, "set scr_" +gamename[n] + "_score_kill 100000"});
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.CallFloat(jump, 999f);
            Console.Memory.SetMemory(falldmg, new byte[] { 0x48, 00 });
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool was created by Unsigned Nation.");
        }
    }
}
