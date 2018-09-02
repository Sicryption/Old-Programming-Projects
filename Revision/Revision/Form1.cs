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
using XDevkit;

namespace Revision
{
    public partial class Form1 : Form
    {
        IXboxConsole Console;
        public Form1()
        {
            InitializeComponent();
            prestigeCycleThread = new System.Threading.Thread(prestigeCycler);
            tbagCycleThread = new System.Threading.Thread(tbag);
        }

        
        offsetsTU16 offsets = new offsetsTU16();
        int mainClientIndex;
        string[] gamemodes = { "dom", "war", "dm", "sd", "conf", "sr", "grind", "blitz", "cranked", "infect", "sotf", "dem", "horde", "stf_ffa" };
        public class offsetsTU16
        {
            public uint bypassOffset = 0x82626ADC,
            Laser = 0x8227ED90,
            ChromePlayers = 0x82672EA8,
            NoRecoil = 0x822C8F3C,
            FPS = 0x8253F47C,
            FPSText = 0x8204B454,
            SP_script_model = 0x82425748,
            SV_LinkEntity = 0x824EF828,
            SV_SetBrushModel = 0x824D8620,
            SV_UnLinkEntity = 0x824EF4C0,
            MapBrushModel = 0x7F80,
            ClientX = 0x1c,
            ClientY = 0x20,
            ClientZ = 0x24,
            unlimitedammo = 0x82248208,
            fullyauto = 0x8224324C,
            redboxes = 0x8226CEAC,
            G_GivePlayerWeapon = 0x824312F0,
            BG_GetWeaponIndexForName = 0x82249F68,
            G_InitializeAmmo = 0x823EEE28,
            G_Spawn = 0x8242C9D8,
            SV_GameSendServerCommand = 0x824D84E0,
            getPlayerStateOffset = 0x83301900,
            gEntity = 0x8337B600,
            Cbuf_AddText = 0x8244B8B8,
            Gamertag_Pregame = 0x83F0A2D8,
            jumpheight = 0x8201674C,
            chams = 0x8229008C,
            falldamage = 0x822309CC,
            G_SetModel = 0x8242C4F8,
            AdvancedUAV1 = 0x82264F90,
            AdvancedUAV2 = 0x82265388,
            AdvancedUAV3 = 0x822653F4;
        };

        Stats stats = new Stats();
        public class Stats
        {
            public uint Deaths = 0x5d,
            Kills = 0x85,
            Killstreak = 0x89,
            GamePlayed = 0x75,
            Losses = 0x8D,
            Wins = 0xd6,
            Score = 0xAE,
            TimePlayed = 0xCA,
            Hits = 0x6D,
            Misses = 0x92,
            SquadPoints = 0x4C30,
            Prestige = 0x4F28,
            RankXP = 0xFE6,
            EntryStats = 0x8358384C;
        }

        private void setModel(string model)
        {
            if (mainClientIndex == -1)
            {
                for (int n = 0; n < 17; n++)
                {
                    Console.Call<uint>(offsets.G_SetModel, new object[] { gEntity((uint)n), model });
                }
            }
            else
            {
                Console.Call<uint>(offsets.G_SetModel, new object[] { gEntity((uint)mainClientIndex), model });
            }
        }

        private void giveWeapon(bool akimbo, string gun)
        {
            int akim = (akimbo) ? 1 : 0;
            uint num = Console.Call<uint>(offsets.BG_GetWeaponIndexForName, new object[] { gun });
            if (num == 0 || num == 1)
            {
                MessageBox.Show("An Error has Occured");
            }
            else
            {
                if (mainClientIndex == -1)
                {
                    for (uint i = 0; i < 12; i++)
                    {
                        Console.CallVoid(offsets.G_GivePlayerWeapon, new object[] { getPlayerState(i), num, akim, 0 });
                        Console.CallVoid(offsets.G_InitializeAmmo, new object[] { getPlayerState(i), num, 0, 0 });
                    }
                }
                else
                {
                    Console.CallVoid(offsets.G_GivePlayerWeapon, new object[] { getPlayerState((uint)mainClientIndex), num, akim, 0 });
                    Console.CallVoid(offsets.G_InitializeAmmo, new object[] { getPlayerState((uint)mainClientIndex), num, 0, 0 });
                }
            }
        }

        uint gEntity(uint clientNum)
        {
            return offsets.gEntity + (clientNum * 0x280);
        }

        public void Dvar(string text)
        {
            Console.CallVoid(offsets.Cbuf_AddText, new object[] { 0, text });
        }

        public void Dvar(int client, string text)
        {
            if(client == -1)
                for (int i = 0; i < 12; i++)
                    Console.CallVoid(offsets.Cbuf_AddText, new object[] { i, text });

            else
                Console.CallVoid(offsets.Cbuf_AddText, new object[] { client, text });
        }

        private void killFeedText(string text, int times = 1)
        {
            if (mainClientIndex == -1)
            {
                for (int value = times; value > 0; value--)
                {
                    for (int n = 0; n < 12; n++)
                    {
                        Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { n, 0, "f \"" + text + "\"" });
                    }
                }
            }
            else
            {
                for (int value = times; value > 0; value--)
                {
                    Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { mainClientIndex, 0, "f \"" + text + "\"" });
                }
            }
        }

        private void kickPlayer(int client, string text)
        {
            if (client != -1)
                Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { client, 0, "r \"" + text + "\"" });
            else
                for(int i = 0; i < 12; i++)
                    Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { i, 0, "r \"" + text + "\"" });

        }

        private void centerText(string text, int times = 1)
        {
            if (mainClientIndex == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { n, 0, "c \"" + text + "\"" });
                }
            }
            else
            {
                Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { mainClientIndex, 0, "c \"" + text + "\"" });
            }
        }

        private void mFlags(int flag, int client)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {

                    Console.WriteInt32(getPlayerState((uint)n) + 0x331C, 0);
                }
            }
            else
            {
                Console.WriteInt32(getPlayerState((uint)client) + 0x331C, flag);
            }
        }

        private uint getPlayerState(uint clientNum)
        {
            return (offsets.getPlayerStateOffset + (clientNum * 0x3700));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setConnectionStatus(false);
            string contents = new System.Net.WebClient().DownloadString("http://pastebin.com/raw.php?i=Uh1rHicL");
            string[] info = contents.Split(new string[] { "[-]" }, StringSplitOptions.RemoveEmptyEntries);
            string currentversion = Application.ProductVersion;
            //new System.Net.WebClient().DownloadFile("https://www.dropbox.com/s/2l6ihrbb8qbq5zq/Revision%20v1.0.0.1.rar?dl=1", "Revision " + info[0].ToString() + ".rar");
            if (!contents.Contains(currentversion))
            {
                MessageBox.Show("A new update is available, press okay to start the download. Info regarding the update is below.\r\n" + info[1], "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(info[2].ToString());
                Dispose();
            }
        }

        private void setConnectionStatus(bool status)
        {
            ac.Checked = status;
            listBox1.Enabled = status;
            tabcontrol1.Enabled = status;
            groupBox4.Enabled = status;
            button3.Enabled = status;
            button5.Enabled = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.Connect(out Console, "default");
                Console.XNotify("Revision Connected!");
                setConnectionStatus(true);
            }
            catch
            {
                MessageBox.Show("Unable to connect to console");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//bypass
        {
            Console.WriteInt32(offsets.bypassOffset, 0x48000020);
            Console.XNotify("Ban Bypass Activated!");
        }

        private void redbox_CheckedChanged(object sender, EventArgs e)
        {
            if(redbox.Checked)
                Console.SetMemory(offsets.redboxes, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            else
                Console.SetMemory(offsets.redboxes, new byte[] { 0x41, 0x9A, 0x00, 0x0C });
        }

        private void laser_CheckedChanged(object sender, EventArgs e)
        {
            if (laser.Checked)
                Console.SetMemory(offsets.Laser, new byte[] { 0x38, 0x60, 0x00, 0x01 });
            else
                Console.SetMemory(offsets.Laser, new byte[] { 0x38, 0x60, 0x00, 0x00 });
        }

        private void chams_CheckedChanged(object sender, EventArgs e)
        {
            byte r = (byte)comboBox2.SelectedIndex;
            byte[] data = new byte[] { 0x38, 0xC0, 0x00, r };
            if (chams.Checked)
                Console.SetMemory(0x8229008C, data);
            else
                Console.SetMemory(0x8229008C, new byte[] { 0x7F, 0x46, 0xD3, 0x78 });
        }

        private void uav_CheckedChanged(object sender, EventArgs e)
        {           
            if (uav.Checked)
            {
                Console.SetMemory(offsets.AdvancedUAV1, new byte[] { 0x2F, 0x03, 0x00, 0x01 });
                Console.SetMemory(offsets.AdvancedUAV2, new byte[] { 0x2F, 0x03, 0x00, 0x01 });
                Console.SetMemory(offsets.AdvancedUAV3, new byte[] { 0x2F, 0x03, 0x00, 0x01 });
            }
            else
            {
                Console.SetMemory(offsets.AdvancedUAV1, new byte[] { 0x2F, 0x03, 0x00, 0x00 });
                Console.SetMemory(offsets.AdvancedUAV2, new byte[] { 0x2F, 0x03, 0x00, 0x00 });
                Console.SetMemory(offsets.AdvancedUAV3, new byte[] { 0x2F, 0x03, 0x00, 0x00 });
            }
        }

        private void norecoil_CheckedChanged(object sender, EventArgs e)
        {
            if (norecoil.Checked)
                Console.SetMemory(offsets.NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            else
                Console.SetMemory(offsets.NoRecoil, new byte[] { 0x38, 0xC0, 0x00, 0x00 });
        }


        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("All");
            for (int i = 0; i < 12; i++)
            {
                UTF8Encoding encoding = new UTF8Encoding();
                string ff = encoding.GetString(Console.GetMemory(getPlayerState((uint)i) + 0x301C, 20));
                listBox1.Items.Add(ff);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                Console.SetMemory(offsets.unlimitedammo, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            else
                Console.SetMemory(offsets.unlimitedammo, new byte[] { 0x7D, 0x4B, 0x18, 0x2E });
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                Console.SetMemory(offsets.fullyauto, new byte[] { 0x3B, 0x40, 0x00, 0x00 });
            else
                Console.SetMemory(offsets.fullyauto, new byte[] { 0x3B, 0x40, 0x00, 0x01 });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Console.SetMemory(offsets.falldamage, new byte[] { 0x48, 0x00, 0x03, 0x20 });
            else
                Console.SetMemory(offsets.falldamage, new byte[] { 0x41, 0x98, 0x03, 0x20 });
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                Dvar(mainClientIndex, "g_knockback 100000");
            else
                Dvar(mainClientIndex, "g_knockback 1000");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                Dvar("set camera_thirdPerson \"1\"");
            else
                Dvar("set camera_thirdPerson \"0\"");
        }

        private void Prestige(int var)
        {
            Console.SetMemory(stats.EntryStats + stats.Prestige, BitConverter.GetBytes((uint)var));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Prestige((int)prestige.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.RankXP, BitConverter.GetBytes((uint)xp.Value));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Kills, BitConverter.GetBytes((uint)kills.Value));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Deaths, BitConverter.GetBytes((uint)deaths.Value));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Killstreak, BitConverter.GetBytes((uint)killstreak.Value));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Wins, BitConverter.GetBytes((uint)wins.Value));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Losses, BitConverter.GetBytes((uint)losses.Value));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.GamePlayed, BitConverter.GetBytes((uint)games.Value));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Hits, BitConverter.GetBytes((uint)hits.Value));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Misses, BitConverter.GetBytes((uint)misses.Value));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.SquadPoints, BitConverter.GetBytes((uint)squad.Value));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.SetMemory(stats.EntryStats + stats.Score, BitConverter.GetBytes((uint)score.Value));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gamemodes.Length; i++)
                Dvar((string)("set scr_" + gamemodes[i] + "_timelimit " + (int)timelimit.Value));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gamemodes.Length; i++)
                Dvar((string)("set scr_" + gamemodes[i] + "_scorelimit " + (int)scorelimit.Value));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gamemodes.Length; i++)
                Dvar((string)("set scr_" + gamemodes[i] + "_score_kill " + (int)xpperkill.Value));       
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Console.WriteFloat(offsets.jumpheight, (float)jumpheight.Value);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Dvar("party_minPlayers 1");
            Console.SetMemory(0x822DB6E0, new byte[]{ 0x60, 0x00, 0x00, 0x00 });
            Dvar("xpartygo");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Dvar(mainClientIndex, customdvar.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kickPlayer(mainClientIndex, "Bye!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainClientIndex = listBox1.SelectedIndex - 1;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            centerText(text.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            killFeedText(text.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dvar(mainClientIndex, "set cg_fov " + (int)fov.Value);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(mainClientIndex != -1)
                Console.WriteFloat(getPlayerState((uint)mainClientIndex) + 0x3050, (float)speed.Value);
            else
                for(int i = 0; i < 12; i++)
                    Console.WriteFloat(getPlayerState((uint)i) + 0x3050, (float)speed.Value);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Dvar(mainClientIndex, "set r_znear " + (int)wallhack.Value);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Normal":
                    mFlags(0, mainClientIndex);
                    break;
                case "No-Clip":
                    mFlags(1, mainClientIndex);
                    break;
                case "UFO":
                    mFlags(2, mainClientIndex);
                    break;
                case "Freeze":
                    mFlags(4, mainClientIndex);
                    break;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked)
                if(mainClientIndex == -1)
                    for(int i = 0; i < 12; i++)
                       Console.WriteUInt32(gEntity((uint)i) + 0x18C, 1);
                else
                    Console.WriteUInt32(gEntity((uint)mainClientIndex) + 0x18C, 1);
            else
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.WriteUInt32(gEntity((uint)i) + 0x18C, 0);
                else
                    Console.WriteUInt32(gEntity((uint)mainClientIndex) + 0x18C, 0);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
                Console.WriteUInt32(gEntity((uint)i) + 0x11C, 1);

            if (checkBox11.Checked)
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                       Console.SetMemory(getPlayerState((uint)i) + 0x127, new byte[] { 0x20 } );
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x127, new byte[] { 0x20 });
            else
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x127, new byte[] { 0x00 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x127, new byte[] { 0x00 });
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x13, new byte[] { 0x10 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x13, new byte[] { 0x10 });
            else
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x13, new byte[] { 0x0 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x13, new byte[] { 0x0 });
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x437, new byte[] { 0x02 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x437, new byte[] { 0x02 });
            else
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x437, new byte[] { 0x00 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x437, new byte[] { 0x00 });
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x3163, new byte[] { 0x01 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x3163, new byte[] { 0x01 });
            else
                if (mainClientIndex == -1)
                    for (int i = 0; i < 12; i++)
                        Console.SetMemory(getPlayerState((uint)i) + 0x3163, new byte[] { 0x00 });
                else
                    Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x3163, new byte[] { 0x00 });
        }

        private void button31_Click(object sender, EventArgs e)
        {
            giveWeapon(checkBox2.Checked, weap.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            setModel(model.Text);
        }
        ASCIIEncoding encoding = new ASCIIEncoding();
        private void ingameGT()
        {
            string i = "       ";
            string gamer = gt.Text;
            if (mainClientIndex == -1)
            {
                string name = gt.Text;
                for (int n = 0; n < 12; n++)
                {
                    Console.SetMemory(getPlayerState((uint)n) + 0x301C, encoding.GetBytes(i));
                    Console.SetMemory(getPlayerState((uint)n) + 0x301C, encoding.GetBytes(gt.Text));
                }
            }
            else
            {
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x301C, encoding.GetBytes(i));
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x301C, encoding.GetBytes(gt.Text));
            }
        }

        private void pregameGT()
        {
            ASCIIEncoding Encoding = new ASCIIEncoding();
            string i = null;
            while (gt.TextLength > 0)
            {
                i = i + " ";
            }
            Console.SetMemory(offsets.Gamertag_Pregame, Encoding.GetBytes(i));
            Console.SetMemory(offsets.Gamertag_Pregame, Encoding.GetBytes(gt.Text));
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (poi.Text == "In-Game")
                ingameGT();
            else if (poi.Text == "Pre-Game")
                pregameGT();
        }

        void setActionSlot(int clientIndex, int slot, uint thing)
        {
            if (clientIndex != -1)
                Console.WriteUInt32((uint)(getPlayerState((uint)clientIndex) + 0xA60 + (slot * 4)), ~thing);
            else
                for (int i = 0; i < 12; i++)
                    Console.WriteUInt32((uint)(getPlayerState((uint)clientIndex) + 0xA60 + (slot * 4)), ~thing);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(mainClientIndex, 2, 4);
            else
                setActionSlot(mainClientIndex, 2, 1);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(mainClientIndex, 3, 4);
            else
                setActionSlot(mainClientIndex, 3, 1);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(mainClientIndex, 0, 4);
            else
                setActionSlot(mainClientIndex, 0, 1);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(mainClientIndex, 1, 4);
            else
                setActionSlot(mainClientIndex, 1, 1);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                if (mainClientIndex != -1)
                {
                    int test = Console.ReadInt32(getPlayerState((uint)mainClientIndex) + 0xC);
                    test >>= 16;
                    Console.WriteInt32(getPlayerState((uint)mainClientIndex) + 0xC, (test | 0x01));
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        int test = Console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test >>= 16;
                        Console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x01));
                    }
                }
            }
            else
            {
                if (mainClientIndex != -1)
                {
                    int test = Console.ReadInt32(getPlayerState((uint)mainClientIndex) + 0xC);
                    test <<= 16;
                    Console.WriteInt32(getPlayerState((uint)mainClientIndex) + 0xC, (test | 0x01));
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        int test = Console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test <<= 16;
                        Console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x01));
                    }
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                if (mainClientIndex != -1)
                {
                    int test = Console.ReadInt32(getPlayerState((uint)mainClientIndex) + 0xC);
                    test >>= 16;
                    Console.WriteInt32(getPlayerState((uint)mainClientIndex) + 0xC, (test | 0x02));
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        int test = Console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test >>= 16;
                        Console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x02));
                    }
                }
            }
            else
            {
                if (mainClientIndex != -1)
                {
                    int test = Console.ReadInt32(getPlayerState((uint)mainClientIndex) + 0xC);
                    test <<= 16;
                    Console.WriteInt32(getPlayerState((uint)mainClientIndex) + 0xC, (test | 0x02));
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        int test = Console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test <<= 16;
                        Console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x02));
                    }
                }
            }
        }
        bool prestigeCycleFirst,
            tbagCycleFirst,
            prestigeCycle;
        bool[] tbagb = new bool[12];
        System.Threading.Thread tbagCycleThread,
            prestigeCycleThread;
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (!tbagCycleFirst)
            {
                tbagCycleThread.Start();
                tbagCycleFirst = true;
            }
            bool onOrOff = checkBox8.Checked;
            if (mainClientIndex != -1)
                tbagb[mainClientIndex] = onOrOff;
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    tbagb[i] = onOrOff;
                }
            }
        }

        private void tbag()
        {
            for (; ; )
            {
                for (int i = 0; i < 12; i++)
                {
                    if (tbagb[i])
                    {
                        int test = Console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test <<= 16;
                        Console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x06));
                    }
                }
            }
        }
        Random rnd = new Random();
        private void prestigeCycler()
        {
            for (; ; )
            {
                if (prestigeCycle == true)
                {
                    Prestige(rnd.Next(0, 11));
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (!prestigeCycleFirst)
            {
                prestigeCycleThread.Start();
                prestigeCycleFirst = true;
            }
            prestigeCycle = checkBox15.Checked;;
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
                Console.SetMemory(offsets.ChromePlayers + 0x3, new byte[] { 0x01 });
            else
                Console.SetMemory(offsets.ChromePlayers + 0x3, new byte[] { 0x00 });
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (mainClientIndex == -1)
                for (int i = 0; i < 12; i++)
                    Console.SetMemory(getPlayerState((uint)i) + 0x30C3, new byte[] { 0x00 });
            else
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x30C3, new byte[] { 0x00 });
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (mainClientIndex == -1)
                for (int i = 0; i < 12; i++)
                    Console.SetMemory(getPlayerState((uint)i) + 0x30C3, new byte[] { 0x0A });
            else
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x30C3, new byte[] { 0x0A });
        }

        string[] achievements = { "LEVEL_1",
            "LEVEL_1A",
            "LEVEL_2",
            "LEVEL_2A",
            "LEVEL_3",
            "LEVEL_3A",
            "LEVEL_4",
            "LEVEL_4A",
            "LEVEL_5",
            "LEVEL_5A",
            "LEVEL_6",
            "LEVEL_6A",
            "LEVEL_7",
            "LEVEL_7A",
            "LEVEL_7B",
            "LEVEL_8",
            "LEVEL_8A",
            "LEVEL_9",
            "LEVEL_9A",
            "LEVEL_10",
            "LEVEL_10A",
            "LEVEL_11",
            "LEVEL_11A",
            "LEVEL_11B",
            "LEVEL_12",
            "LEVEL_12A",
            "LEVEL_13",
            "LEVEL_13A",
            "LEVEL_14",
            "LEVEL_14A",
            "LEVEL_15",
            "LEVEL_15A",
            "LEVEL_16",
            "LEVEL_16A",
            "LEVEL_17",
            "LEVEL_17A",
            "LEVEL_18",
            "LEVEL_18A",
            "EXT_1",
            "ESCAPE_ALL_PLAYERS",
            "ESCAPE_IN_TIME",
            "ESCAPE_1ST_TIME",
            "ESCAPE_ALL_CHALLENGE",
            "REACH_CABIN",
            "REACH_CITY",
            "KILL_WITH_TRAP",
            "SCAVENGE_ITEM",
            "ESCAPE_WITH_NERF_ON",
            "EXTRA1",
            "EXTRA2",
            "REACH_COMPOUND",
            "REACH_FACILITY",
            "KILLBOSS_1ST_TIME",
            "KILLBOSS_IN_TIME",
            "KILL_WITH_SWEAPON",
            "COMPLETE_ALL_CHALLENGE",
            "KILLBOSS_WITH_RELIC",
            "KILL_PHANTOMS",
            "KILL_RHINO_PISTOL",
            "FOUND_ALL_INTELS",
            "GOT_THEEGGSTRA_XP",
            "REACH_CARGO",
            "REACH_DECK",
            "KILL_KRAKEN_1ST_TIME",
            "KILL_KRAKEN_WITH_RELIC",
            "KILL_KRAKEN_AND_ALL_CHALLENGES",
            "FOUND_ALL_INTELS_MAYDAY",
            "KILL_SEEDER_TURRETS",
            "HYPNO_TRAP_RHINO",
            "GOT_THEEGGSTRA_XP_DLC2",
            "CRAFT_ALL_ITEMS",
            "FINISH_GATE",
            "EXTEND_THE_BRIDGE",
            "AWAKENING_ESCAPE",
            "AWAKENING_RELIC_ESCAPE",
            "AWAKENING_ALL_CHALLENGES_ESCAPE",
            "AWAKENING_ALL_INTEL",
            "KILL_GARG_WITH_VANGUARD",
            "GOT_THEEGGSTRA_XP_DLC3",
            "LIKE_A_GLOVE",
            "AWAKENING_4_CLASS_ESCAPE",
            "LAST_COMPLETED",
            "LAST_RELIC_COMPLETED",
            "LAST_ALL_CHALLENGES_COMPLETED",
            "LAST_ALL_INTEL",
            "LAST_COMPLETE_AN_OUTPOST",
            "GOT_THEEGGSTRA_XP_DLC4",
            "TIMING_IS_EVERYTHING",
            "YOU_WISH",
            "ALWAYS_HARD",
            "HAT_TRICK" };

        private void button37_Click(object sender, EventArgs e)
        {
            if (mainClientIndex == -1)
                for (int i = 0; i < 12; i++)
                    for (int l = 0; l < achievements.Length; l++)
                        Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { i, 0, "3 \"" + achievements[l] + "\"" });
            else
                for (int l = 0; l < achievements.Length; l++)
                    Console.CallVoid(offsets.SV_GameSendServerCommand, new object[] { mainClientIndex, 0, "3 \"" + achievements[l] + "\"" });
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x30, new byte[] { 0x01 });
            else
                Console.SetMemory(getPlayerState((uint)mainClientIndex) + 0x30, new byte[] { 0x02 });
        }
    }
}
