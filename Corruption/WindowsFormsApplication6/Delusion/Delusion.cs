using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using JRPC_Client;
using CorruptionRevamped;

namespace WindowsFormsApplication6
{
    public partial class CorRev : Office2007Form
    {
        public string user; 
        public string pass;
        XDevkit.IXboxConsole console;
        public static bool logintype = false;
        public static bool autoupdate;
        public static bool autologin;
        public static bool autoconnect;
        bool ammobool = false;
        bool redboxbool = false;
        bool norecoilbool = false;
        bool fullyautogunsbool = false;
        byte[] ammoorig = new byte[] { 0x0 };
        byte[] norecoilorig = new byte[] { 0x0 };
        byte[] redboxorig = new byte[] { 0x0 };
        byte[] fullyautogunsorig = new byte[] { 0x0 };
        bool XRPCConnection;
        bool JRPCConnection;
        bool NeighborhoodExists;
        bool[] godmode = new bool[12];
        int[] mflag = new int[12];
        bool[] uav = new bool[12];
        bool[] tinycrosshairs = new bool[12];
        bool[] invisibility = new bool[12];
        bool redboxes = false;
        bool fullyautoguns = false;
        bool unlimitedammo = false;
        bool uavt = false;
        bool lasert = false;
        bool thermalplayerst = false;
        bool norecoilt = false;
        bool thirdpersont = false;
        uint FPSText;//TU8
        uint AdvancedUAV1;
        uint AdvancedUAV2;
        uint AdvancedUAV3;
        uint Laser; //Laser (01 On - 00 Off) TU9
        uint ChromePlayers; //Chrome Players (01 On - 00 Off) TU9
        uint NoRecoil; //Norecoil (60000000 On - 4BF8B765 Off) TU9
        uint FPS;//TU9
        uint SP_script_model;//TU9
        uint SV_LinkEntity;//TU9
        uint SV_SetBrushModel;//TU9
        uint SV_UnLinkEntity;//TU9
        uint MapBrushModel;
        uint ClientX;
        uint ClientY;
        uint ClientZ;
        uint EntryStats; //TU9
        uint Deaths;
        uint Kills;
        uint KillStreaks;
        uint GamePlayed;
        uint Losses;
        uint Wins;
        uint Score;
        uint TimePlayed;
        uint Hits;
        uint Misses;
        uint SquadPoints;
        uint Prestige;
        uint RankXP;
        uint Ammo;//TU9
        uint autoguns;//TU9
        uint Boxes;//TU9
        uint G_GivePlayerWeapon;//TU9
        uint BG_GetWeaponIndexForName;//TU9
        uint G_InitializeAmmo;//TU9
        int client = -1;
        uint G_Spawn; //TU9
        uint SV_SendGameServerCommand;//TU9
        uint getPlayerStateOffset;
        uint gEntityOffset;
        uint Demonware;
        uint Demonware1;
        uint Demonware2;
        uint Demonware3;
        uint Demonware4;
        uint Demonware5;
        uint getPlayerState(uint clientNum)//TU9
        {
            return getPlayerStateOffset + (clientNum * 0x3700);
        }
        uint gEntity(uint clientNum)//TU9
        {
            return gEntityOffset + (clientNum * 0x280);
        }
        uint Cbuf_AddText;//TU9
        string game = null;
        uint Gamertag_Pregame;//TU9
        uint jump;//TU9
        uint falldmgoffset;
        uint falldmg;//TU9
        uint G_SetModel;//TU9
        string userType = "none";
        bool pregamegtCycle = false;
        System.Threading.Thread pregameGTCycleThread;
        bool pregameGTFirst = false;
        bool ingamegtcycle = false;
        System.Threading.Thread ingamegtcyclethread;
        bool ingameGTFirst = false;
        bool prestigeCycle = false;
        Random rnd = new Random();
        System.Threading.Thread prestigeCycleThread;
        bool prestigeCycleFirst = false;
        private void addClient(string gamertag)
        {
            listBox1.Items.Add(gamertag);
        }
        uint cliID = 0x309C;
        uint Gamertag_Ingame(uint clientNum)
        {
            return getPlayerState(clientNum) + cliID;
        }

        public CorRev()
        {
            InitializeComponent();
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            prestigeCycleThread = new System.Threading.Thread(prestigeCycler);
            pregameGTCycleThread = new System.Threading.Thread(pregamegtcycler);
            ingamegtcyclethread = new System.Threading.Thread(pregamegtcycler);
            tbagthread = new System.Threading.Thread(tbag);
        }

        public static string Method_0(string IP)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes((string)IP);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Method_1(string CPU)
        {
            System.Security.Cryptography.MD5 Tru = new System.Security.Cryptography.MD5CryptoServiceProvider();
            Tru.ComputeHash(ASCIIEncoding.ASCII.GetBytes(CPU));
            byte[] result = Tru.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public bool skiplogin = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            string stoof = new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/buisness-history");
            string stoof2 = new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/home/platform-for-change");
            Form2 login = new Form2();
            string r = "[herpidy]" + new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/update-info") + "[herpidy]";
            string[] info = r.Split(new string[] { "[herpidy]" }, StringSplitOptions.RemoveEmptyEntries);
            string contents = new System.Net.WebClient().DownloadString("http://pastebin.com/42pkJsNk");
            string currentversion = Application.ProductVersion;
            listBox1.SelectedIndex = 0;
            if (!skiplogin)
            {
                if ((user != "") && (pass != ""))
                {
                    if (login.userType != "")
                    {
                        if (stoof.Contains(Method_1(Method_0(user)) + "|" + Method_1(Method_0(pass))))
                        {
                            userType = "User";
                            if (stoof2.Contains(Method_1(Method_0(user)) + "|" + Method_1(Method_0(pass))))
                            {
                                userType = "Premium";
                            }
                        }
                        else
                        {
                            Dispose();
                        }
                    }
                    else
                    {
                        Dispose();
                    }
                }
            }
            else
            {
                string[] autolconts = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\AutoLogin.txt");
                if (stoof.Contains(autolconts[0]) && autolconts[0].Length == 65)
                {
                    userType = "User";
                    if (stoof2.Contains(autolconts[0]))
                    {
                        userType = "Premium";
                    }
                }
                else
                {
                    Dispose();
                }
            }

            if (contents.Contains(currentversion))
            {
                try
                {
                    console.Connect(out console);
                    retrieveOffsets();
                    if (!skiplogin)
                    {
                        if (console.Connect(out console))
                        {
                            if (userType == "Premium")
                            {
                                doEnable(userType);
                                MessageBoxEx.Show("Hello " + user + "!\r\nDelusion Premium Connected Successfully\r\nYour account is: " + userType);
                            }
                            else if (userType == "User")
                            {
                                doEnable(userType);
                                MessageBoxEx.Show("Hello " + user + "!\r\nDelusion Connected Successfully\r\n" + "Your account is: " + userType + "\r\nFor more features upgrade your account to Premium for only $10 more!");
                            }
                        }
                        else
                        {
                            MessageBoxEx.Show("Hello " + user + "!\r\nAn Error has occured when trying to Connect to your Console. Make sure your console is turned on with RPC and JRPC set as plugins.");
                        }
                    }
                    else
                    {
                        if (console.Connect(out console))
                        {
                            MessageBoxEx.Show("Hello!\r\nDelusion Connected Successfully\r\nAuto-Login is checked, turn it off in the settings menu to see your current status!");
                            doEnable(userType);
                        }
                        else
                        {
                            MessageBoxEx.Show("Hello!\r\nAn Error has occured when trying to Connect to your Console. Make sure your console is turned on with RPC and JRPC set as plugins.\r\nAuto-Login is checked, turn it off in the settings menu to see your current status!");
                        }
                    }
                }
                catch
                {
                    MessageBoxEx.Show("Hello!\r\nAn Error has occured when trying to Connect to your Console. Make sure your console is turned on with RPC and JRPC set as plugins.");
                }
            }
            else
            {
                MessageBoxEx.Show("A new update is available, press okay to start the download. Info regarding the update is below.\r\n" +info[1], "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(info[2].ToString());
                Dispose();
            }
            MOTD.Text = info[4].ToString();
        }

        private void retrieveOffsets()
        {
            try
            {
                string offf = "[herpidy]" + new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/offsets") + "[herpidy]";
                string[] result = offf.Split(new string[] { "[herpidy]" }, StringSplitOptions.None);
                int curnum = 2;
                FPSText = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                AdvancedUAV1 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Laser = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                ChromePlayers = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                NoRecoil = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                FPS = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SP_script_model = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SV_LinkEntity = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SV_SetBrushModel = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SV_UnLinkEntity = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                MapBrushModel = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                ClientX = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                ClientY = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                ClientZ = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                EntryStats = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Deaths = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Kills = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                KillStreaks = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                GamePlayed = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Losses = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Wins = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Score = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                TimePlayed = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Hits = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Misses = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SquadPoints = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Prestige = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                RankXP = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Ammo = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                autoguns = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Boxes = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                G_GivePlayerWeapon = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                BG_GetWeaponIndexForName = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                G_InitializeAmmo = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                G_Spawn = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                SV_SendGameServerCommand = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                getPlayerStateOffset = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                gEntityOffset = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Cbuf_AddText = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Gamertag_Pregame = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                jump = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                falldmgoffset = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                G_SetModel = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware1 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware2 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware3 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware4 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                Demonware5 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                AdvancedUAV2 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                AdvancedUAV3 = Convert.ToUInt32(result[curnum], 16);
                curnum += 2;
                falldmg = falldmgoffset + 0x74;
                MapBrushModel = gEntity(0x38);
            }
            catch
            {
                MessageBox.Show("Unable to retrieve offsets");
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (userType == "none")
                {
                    Dispose();
                }
                else
                {
                    if (console.Connect(out console))
                    {
                        doEnable(userType);
                        MessageBoxEx.Show("Connection to Console Successful");
                    }
                    else
                    {
                        MessageBoxEx.Show("An Error has occured. Run the troubleshooter to find the problem(s).");
                    }
                }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("An Error has occured. Run the troubleshooter to find the problem(s).");
            }
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("This program was coded by Chaos_RGH\r\n\r\nThanks to the following people for help:\r\nNicholasbroo\r\nimGol2den\r\nHeistful\r\nChris7s\r\n+ Many more");
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dieselgaming.com/forums/");
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=LFZB4YGRHCTQ6&lc=CA&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted");
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            XRPCCheck();
            JRPCCheck();
            checkNeighborhood();
            completeTroubleshoot();
        }

        private void doEnable(string type)
        {
            if (type != "none")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                groupBox11.Enabled = true;
                groupBox12.Enabled = true;
                groupBox13.Enabled = true;
                groupBox14.Enabled = true;
                groupBox15.Enabled = true;
                groupBox16.Enabled = true;
                groupBox17.Enabled = true;
                groupBox18.Enabled = true;
                groupBox19.Enabled = true;
                groupBox20.Enabled = true;
                groupBox21.Enabled = true;
                gclient.Enabled = true;
                buttonX20.Enabled = true;
                buttonX59.Enabled = true;
                buttonX56.Enabled = true;
                groupBox22.Enabled = true;
            }
            if (type == "Premium")
            {
                groupBox23.Enabled = true;
                groupBox24.Enabled = true;
                groupBox25.Enabled = true;
                groupBox26.Enabled = true;
                groupBox27.Enabled = true;
                groupBox28.Enabled = true;
                groupBox29.Enabled = true;
                groupBox30.Enabled = true;
                groupBox31.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
                buttonX48.Enabled = false;
                numericUpDown1.Enabled = false;
                flip.Enabled = false;
            }
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            string contents = new System.Net.WebClient().DownloadString("http://pastebin.com/42pkJsNk");
            string currentversion = Application.ProductVersion;
            if (contents.Contains(currentversion))
            {
                MessageBoxEx.Show("You currently have the most Up-to-Date version!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("Click OK to download the newest version!", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string r = "[herpidy]" + new System.Net.WebClient().DownloadString("https://sites.google.com/site/6irfarrelkingvichi/update-info") + "[herpidy]";
                string[] info = r.Split(new string[] { "[herpidy]" }, StringSplitOptions.RemoveEmptyEntries);
                MessageBoxEx.Show("A new update is available, press okay to start the download. Info regarding the update is below.\n\n" + info[1], "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start(info[2].ToString());
                Dispose();
            }
        }

        private void completeTroubleshoot()
        {
            if (XRPCConnection == true && JRPCConnection == true && NeighborhoodExists == true)
            {
                MessageBox.Show("Everything seems to be running fine.\r\nIf a problem is still occuring restart your console and make sure your console is set to the default console in Xbox 360 Neighborhood.");
            }
        }

        private void XRPCCheck()
        {
            try
            {
                console.Connect(out console);
                if (console.Connect(out console))
                {
                    XRPCConnection = true;
                }
                else if (!console.Connect(out console))
                {
                    XRPCConnection = false;
                    if (MessageBoxEx.Show("This check failed because you don't have RPC.xex set as a plugin on your console.\r\nMake sure to set it as a plugin by changing the launch.ini.\r\nClick Ok to start the download.", "XRPC Check Failed", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start("https://mega.co.nz/#!4MIhjQTI!apYAI9FrSZU5XUbA_tNpe-uY8bAXYjB7Za3ta-bOBr8");
                    }
                }
            }
            catch (Exception)
            {
                XRPCConnection = false;
                if (MessageBoxEx.Show("This check failed because you don't have RPC.xex set as a plugin on your console.\r\nMake sure to set it as a plugin by changing the launch.ini.\r\nClick Ok to start the download.", "XRPC Check Failed", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://mega.co.nz/#!4MIhjQTI!apYAI9FrSZU5XUbA_tNpe-uY8bAXYjB7Za3ta-bOBr8");
                }
            }
        }

        private void JRPCCheck()
        {
            try
            {
                console.Connect(out console);
                if (console.Connect(out console))
                {
                    JRPCConnection = true;
                }
                else
                {
                    JRPCConnection = false;
                    if (MessageBoxEx.Show("This check failed because you don't have JRPC.xex set as a plugin on your console.\r\nMake sure to set it as a plugin by changing the launch.ini.\r\nClick Ok to start the download.", "JRPC Check Failed", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        System.Diagnostics.Process.Start("https://mega.co.nz/#!ocRlTJwR!cQ-xOdqldwGXecC-ZLCB9Q66DwQD-wy4B33QvBxybGs");
                    }
                }
            }
            catch (Exception)
            {
                JRPCConnection = false;
                if (MessageBoxEx.Show("This check failed because you don't have JRPC.xex set as a plugin on your console.\r\nMake sure to set it as a plugin by changing the launch.ini.\r\nClick Ok to start the download.", "JRPC Check Failed", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://mega.co.nz/#!ocRlTJwR!cQ-xOdqldwGXecC-ZLCB9Q66DwQD-wy4B33QvBxybGs");
                }
            }
        }

        private void checkNeighborhood()
        {
            try
            {
                if (Directory.Exists("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32") || Directory.Exists("C:\\Program Files\\Microsoft Xbox 360 SDK\\bin\\win32\\"))
                {
                    NeighborhoodExists = true;
                }
                else
                {
                    NeighborhoodExists = false;
                    MessageBoxEx.Show("You need to install Xbox 360 Neighborhood in order for this check to pass.\r\n(Note: This could be a false alarm and maybe the scan failed to locate your Neighborhood folder)");
                }
            }
            catch (Exception)
            {
                NeighborhoodExists = false;
                MessageBoxEx.Show("You need to install Xbox 360 Neighborhood in order for this check to pass.\r\n(Note: This could be a false alarm and maybe the scan failed to locate your Neighborhood folder)");
            }
        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX3.Checked == true)
            {
                slider3.Maximum = 10000;
                slider3.Value = 39;
            }
            else
            {
                slider3.Maximum = 1000;
                slider3.Value = 39;
            }
        }

        private void checkBoxX4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX4.Checked == true)
            {
                slider4.Maximum = 10000;
                slider4.Value = 39;
            }
            else
            {
                slider4.Maximum = 1000;
                slider4.Value = 39;
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            slider1.Value = 1;
            slider2.Value = 65;
            slider3.Value = 39;
            slider4.Value = 39;
            slider5.Value = 1;
            slider6.Value = 1;
            slider11.Value = 520;
            //Console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
            
            console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
        }

        private void checkBoxX7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX7.Checked == true)
            {
                slider7.Maximum = 10000;
                slider7.Value = 39;
            }
            else
            {
                slider7.Maximum = 1000;
                slider7.Value = 39;
            }
        }

        private void checkBoxX8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX8.Checked == true)
            {
                slider8.Maximum = 10000;
                slider8.Value = 39;
            }
            else
            {
                slider8.Maximum = 1000;
                slider8.Value = 39;
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            slider7.Value = 39;
            slider8.Value = 39;
            slider9.Value = 65;
            slider10.Value = 1;
            slider12.Value = 520;
            slider13.Value = 1;
            //Console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
            console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    if (switchButton1.Value == true)
                    {
                        GodmodeOn(n);
                    }
                    else
                    {
                        GodmodeOff(n);
                    }
                }
            }
            else
            {
                if (switchButton1.Value == true)
                {
                    GodmodeOn(client);
                }
                else
                {
                    GodmodeOff(client);
                }
            }
        }

        private void GodmodeOn(int clientt)
        {
            console.WriteUInt32(gEntity((uint)clientt) + 0x18C, 1);
            //Console.WriteUInt32(gEntity((uint)clientt) + 0x18C, 1);
        }

        private void GodmodeOff(int clientt)
        {
            console.WriteUInt32(gEntity((uint)clientt) + 0x18C, 0);
            //Console.WriteUInt32(gEntity((uint)clientt) + 0x18C, 0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getClients()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Client -1: All Clients");
            ASCIIEncoding encoding = new ASCIIEncoding();
            try
            {
                for (int clients = 0; clients < 12; clients++)
                {
                    byte[] memory = console.GetMemory(Gamertag_Ingame((uint)clients), 0x10);
                    string str = encoding.GetString(memory);
                    listBox1.Items.Add("Client " + clients + ": " + str);
                }
            }
            catch (Exception)
            {

            }
        }

        private void buttonX18_Click(object sender, EventArgs e)
        {
            getClients();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void mFlags(int flag, int clientt)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    JRPC.WriteInt32(console, getPlayerState((uint)n) + 0x331C, 0);
                }
            }
            else
            {
                JRPC.WriteInt32(console, getPlayerState((uint)clientt) + 0x331C, flag);
                mflag[clientt] = flag;
            }
        }

        private void switchButton5_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton5.Value)
            {
                console.SetMemory(AdvancedUAV1, new byte[] { 1 });
                console.SetMemory(AdvancedUAV2, new byte[] { 1 });
                console.SetMemory(AdvancedUAV3, new byte[] { 1 });
            }
            else
            {
                console.SetMemory(AdvancedUAV1, new byte[1]);
                console.SetMemory(AdvancedUAV2, new byte[1]);
                console.SetMemory(AdvancedUAV3, new byte[1]);
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (unlimitedammo == false)
            {
                console.SetMemory(Ammo, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                unlimitedammo = true;
            }
            else
            {
                unlimitedammo = false;
            }
        }

        private void switchButton16_ValueChanged(object sender, EventArgs e)
        {

        }

        private void switchButton20_ValueChanged(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    if (godmode[n] == true)
                    {
                        GodmodeOn(n);
                    }
                    else
                    {
                        GodmodeOff(n);
                    }
                }
            }
            else
            {
                if (godmode[client] == true)
                {
                    GodmodeOn(client);
                }
                else
                {
                    GodmodeOff(client);
                }
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (fullyautoguns == false)
            {
                console.SetMemory(autoguns, new byte[] { 0x96, 0x00, 0x00, 0x00 });
                fullyautoguns = true;
            }
            else
            {
                fullyautoguns = false;
            }
        }

        private void mFlagsExt(int flag, int clientt)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    if (mflag[clientt] != flag)
                    {
                        JRPC.WriteInt32(console, getPlayerState((uint)n) + 0x331C, flag);
                        mflag[clientt] = flag;
                        if (flag == 2)
                        {
                            switchButton19.Value = false;
                            switchButton17.Value = false;
                        }
                        else if (flag == 1)
                        {
                            switchButton18.Value = false;
                            switchButton17.Value = false;
                        }
                        else if (flag == 4)
                        {
                            switchButton18.Value = false;
                            switchButton19.Value = false;
                        }
                    }
                    else
                    {
                        JRPC.WriteInt32(console, getPlayerState((uint)n) + 0x331C, 0);
                        mflag[clientt] = 0;
                        switchButton19.Value = false;
                        switchButton17.Value = false;
                        switchButton18.Value = false;
                    }
                }
            }
            else
            {
                if (mflag[clientt] != flag)
                {
                    JRPC.WriteInt32(console, getPlayerState((uint)clientt) + 0x321C, flag);
                    mflag[clientt] = flag;
                    if (flag == 2)
                    {
                        switchButton19.Value = false;
                        switchButton17.Value = false;
                    }
                    else if (flag == 1)
                    {
                        switchButton18.Value = false;
                        switchButton17.Value = false;
                    }
                    else if (flag == 4)
                    {
                        switchButton18.Value = false;
                        switchButton19.Value = false;
                    }
                }
                else
                {
                    JRPC.WriteInt32(console, getPlayerState((uint)clientt) + 0x321C, 0);
                    mflag[clientt] = 0;
                    switchButton19.Value = false;
                    switchButton17.Value = false;
                    switchButton18.Value = false;
                }
            }
        }

        private void switchButton18_ValueChanged(object sender, EventArgs e)
        {
            mFlags(2, client);
        }

        private void switchButton17_ValueChanged(object sender, EventArgs e)
        {
            mFlags(4, client);
        }

        private void switchButton19_ValueChanged(object sender, EventArgs e)
        {
            mFlags(1, client);
        }

        private void switchButton15_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton15.Value == true)
            {
                if (norecoilbool == false)
                {
                    norecoilorig = console.GetMemory(NoRecoil, 4);
                    norecoilbool = true;
                }
                console.SetMemory(NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                console.SetMemory(NoRecoil, norecoilorig);
            }
        }

        private void switchButton6_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton6.Value)
            {
                console.SetMemory(NoRecoil, new byte[] { 0x4b, 0xf8, 0xae, 0x95 });
            }
            if (switchButton6.Value)
            {
                byte[] data = new byte[4];
                data[0] = 0x60;
                console.SetMemory(NoRecoil, data);
            }
        }

        private void switchButton12_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton12.Value)
            {
                byte[] data = new byte[4];
                data[0] = 0x2b;
                data[1] = 11;
                console.SetMemory(ChromePlayers, data);
            }
            if (switchButton12.Value)
            {
                console.SetMemory(ChromePlayers, new byte[] { 0x2b, 11, 0, 1 });
            }
        }

        private void switchButton10_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton10.Value)
            {
                byte[] data = new byte[4];
                data[0] = 0x2b;
                data[1] = 11;
                console.SetMemory(ChromePlayers, data);
            }
            if (switchButton10.Value)
            {
                console.SetMemory(ChromePlayers, new byte[] { 0x2b, 11, 0, 1 });
            }
        }

        private void switchButton7_ValueChanged(object sender, EventArgs e)
        {
            if (!switchButton7.Value)
            {
                byte[] data = new byte[4];
                data[0] = 0x38;
                data[1] = 0x60;
                console.SetMemory(Laser, data);
            }
            if (switchButton7.Value)
            {
                console.SetMemory(Laser, new byte[] { 0x38, 0x60, 0, 1 });
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void switchButton11_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton11.Value == true)
            {
                console.SetMemory(Laser, new byte[] { 01 });
            }
            else
            {
                console.SetMemory(Laser, new byte[] { 00 });
            }
        }

        public void Dvar(string text)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, text });
        }

        private void switchButton8_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton8.Value == true)
            {
                Dvar((string)("set camera_thirdPerson \"1\""));
            }
            else
            {
                Dvar((string)("set camera_thirdPerson \"0\""));
            }
        }

        private void switchButton13_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton13.Value == true)
            {
                Dvar((string)("set camera_thirdPerson \"1\""));
            }
            else
            {
                Dvar((string)("set camera_thirdPerson \"0\""));
            }
        }

        private void switchButton14_ValueChanged(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    if (switchButton14.Value == false)
                    {
                        console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                        console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                        //Console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                        //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                    }
                    else
                    {
                        //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 1);
                        console.WriteUInt32(getPlayerState((uint)n) + 0x434, 1);
                    }
                }
            }
            else
            {
                if (switchButton14.Value == false)
                {
                    console.WriteInt32(getPlayerState((uint)client) + 0x430, 0);
                    console.WriteUInt32(getPlayerState((uint)client) + 0x434, 2);
                    //Console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                }
                else
                {                        
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 1);
                    console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
                }
            }
        }

        private void switchButton9_ValueChanged(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    if(switchButton9.Value == false)
                    {
                        console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                        console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                        //Console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                        //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                    }
                    else
                    {
                        //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 1);
                        console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
                    }
                }
            }
            else
            {
                if (switchButton9.Value == false)
                {
                    console.WriteInt32(getPlayerState((uint)client) + 0x430, 0);
                    console.WriteUInt32(getPlayerState((uint)client) + 0x434, 2);
                    //Console.WriteInt32(getPlayerState((uint)n) + 0x430, 0);
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                }
                else
                {
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 1);
                    console.WriteUInt32(getPlayerState((uint)client) + 0x434, 1);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            console.SetMemory(Boxes, new byte[] { 0x60, 0x00, 0x00, 0x00 });
        }

        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set r_znear " + slider1.Value });
        }

        private void slider10_ValueChanged(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set r_znear " + slider10.Value });
        }

        private void slider9_ValueChanged(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set cg_fov " + slider9.Value });
        }

        private void slider2_ValueChanged(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set cg_fov " + slider2.Value });
        }

        private void slider3_ValueChanged(object sender, EventArgs e)
        {
            console.WriteFloat(jump, (float)slider3.Value);
        }

        private void slider8_ValueChanged(object sender, EventArgs e)
        {
            console.WriteFloat(jump, (float)slider8.Value);
        }

        private void slider7_ValueChanged(object sender, EventArgs e)
        {
            console.SetMemory(falldmg, new byte[] { 0x48, 00 });
        }

        private void slider4_ValueChanged(object sender, EventArgs e)
        {
            console.SetMemory(falldmg, new byte[] { 0x48, 00 });
        }

        private void slider5_ValueChanged(object sender, EventArgs e)
        {
            Dvar((string)("set compassSize " + slider5.Value));
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {
            if (client == -1)
            {
                MessageBoxEx.Show("Unable to Kick All Clients");
            }
            else
            {
                console.CallVoid(SV_SendGameServerCommand, new object[] { client, 0, "r \"This profile has been permanently banned from playing Call of Duty: Ghosts online due to a violation of the posted Security & Enforcement Policy. For more information, visit http://support.activision.com/ghosts\"" });
            }
        }

        private void findGame()
        {
            switch (comboBox1.Text)
            {
                case "Domination":
                    game = "dom";
                    break;
                case "Team Deathmatch": 
                    game = "war";
                    break;
                case "Free for All": 
                    game = "dm";
                    break;
                case "Search and Destroy": 
                    game = "sd";
                    break;
                case "Kill Confirmed": 
                    game = "conf";
                    break;
                case "Search and Rescue": 
                    game = "sr";
                    break;
                case "Grind": 
                    game = "grind";
                    break;
                case "Blitz": 
                    game = "blitz";
                    break;
                case "Cranked": 
                    game = "cranked";
                    break;
                case "Infected": 
                    game = "infect";
                    break;
                case "Hunted": 
                    game = "sotf";
                    break;
                case "Demolition": 
                    game = "dem";
                    break;
                case "Safeguard": 
                    game = "horde";
                    break;
                case "Hunted FFA": 
                    game = "sotf_ffa";
                    break;
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            findGame();
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set scr_"+game +"_score_kill " + (int)numericUpDown2.Value });
        }

        private void forceHost()
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set party_minplayers \"1\"" });
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set hostmigration \"0\"" });
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set host \"1\"" });
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set migration_timeBetween \"30000\"" });
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set migration_msgtimeout \"500\"" });
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set badhost_maxHappyPingTime \"400\"" });
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            forceHost();
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            findGame();
            Dvar((string)("set scr_" + game + "_timelimit " + numericUpDown4.Value));
        }

        private void buttonX15_Click(object sender, EventArgs e)
        {
            findGame();
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set scr_" + game + "_scorelimit " + numericUpDown5.Value });
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            Dvar((string)("set scr_nukeTimer " + numericUpDown3.Value));
        }

        private void killFeedText(string text, int times)
        {
            if (client == -1)
            {
                for (int value = times; value > 0; value--)
                {
                    for (int n = 0; n < 12; n++)
                    {
                        console.CallVoid(SV_SendGameServerCommand, new object[] { n, 0, "f \"" + text + "\"" });
                    }
                }
            }
            else
            {
                for (int value = times; value > 0; value--)
                {
                    console.CallVoid(SV_SendGameServerCommand, new object[] { client, 0, "f \"" + text + "\"" });
                }
            }
        }

        private void centerText(string text, int times)
        {
            if (client == -1)
            {
                for (int value = times; value > 0; value--)
                {
                    for (int n = 0; n < 12; n++)
                    {
                        console.CallVoid(SV_SendGameServerCommand, new object[] { n, 0, "c \"" + text + "\"" });
                    }
                }
            }
            else
            {
                for (int value = times; value > 0; value--)
                {
                    console.CallVoid(SV_SendGameServerCommand, new object[] { client, 0, "c \"" + text + "\"" });
                }
            }
        }

        private void centerText(string text, int times, int clientt)
        {
            if (clientt == -1)
            {
                for (int value = times; value > 0; value--)
                {
                    for (int n = 0; n < 12; n++)
                    {
                        console.CallVoid(SV_SendGameServerCommand, new object[] { n, 0, "c \"" + text + "\"" });
                    }
                }
            }
            else
            {
                for (int value = times; value > 0; value--)
                {
                    console.CallVoid(SV_SendGameServerCommand, new object[] { clientt, 0, "c \"" + text + "\"" });
                }
            }
        }

        private void vision(string text)
        {
            if (client == -1)
            {
                for (int n = 17; n > 0; n--)
                {
                    console.CallVoid(SV_SendGameServerCommand, new object[] { n, 0, "J \"" + text + "\"" });
                }
            }
            else
            {
                console.CallVoid(SV_SendGameServerCommand, new object[] { client, 0, "J \"" + text + "\"" });
            }
        }

        private void giveWeapon(int akimbo, string gun)
        {
            uint num = console.Call<uint>(BG_GetWeaponIndexForName, new object[] { gun });
            if (num == 0 || num == 1)
            {
                MessageBoxEx.Show("An Error has Occured");
            }
            else
            {
                if (client == -1)
                {
                    for (uint i = 0; i < 12; i++)
                    {
                        console.CallVoid(G_GivePlayerWeapon, new object[] { getPlayerState(i), num, akimbo, 0 });
                        console.CallVoid(G_InitializeAmmo, new object[] { getPlayerState(i), num, 0, 0 });
                        centerText(gun + " given", 1);
                    }
                }
                else
                {
                    centerText(gun + " given", 1);
                    console.CallVoid(G_GivePlayerWeapon, new object[] { getPlayerState((uint)client), num, akimbo, 0 });
                    console.CallVoid(G_InitializeAmmo, new object[] { getPlayerState((uint)client), num, 0, 0 });
                }
            }
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            if (checkBoxX6.Checked == true)
            {
                giveWeapon(1, comboBox3.Text);
            }
            else
            {
                giveWeapon(0, comboBox3.Text);
            }
        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {
            Multiplayer.Checked = true;
            ribbonControl1.Size = new Size(801, 598);
        }

        private void setModel(string model)
        {
            if (client == -1)
            {
                for (int n = 0; n < 17; n++)
                {
                    console.CallVoid(G_SetModel, new object[] { gEntity((uint)n), model });
                    //Console.CallVoid(G_SetModel, new object[] { gEntity((uint)n), model });
                }
            }
            else
            {
                console.CallVoid(G_SetModel, new object[] { gEntity((uint)client), model });
                //Console.CallVoid(G_SetModel, new object[] { gEntity((uint)client), model });
            }
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            setModel(comboBox2.Text);
        }

        private void buttonX21_Click(object sender, EventArgs e)
        {
            //Levels
            int[] levels = new int[] { 
            0, 0x3e8, 0x9c4, 0x1388, 0x2710, 0x4e20, 0x7530, 0x9c40, 0xc350, 0xea60, 0x11170, 0x13880, 0x15f90, 0x186a0, 0x1d4c0, 0x222e0, 
            0x27100, 0x2bf20, 0x30d40, 0x35b60, 0x3a980, 0x3f7a0, 0x445c0, 0x493e0, 0x4e200, 0x53020, 0x57e40, 0x5cc60, 0x61a80, 0x668a0, 0x6b6c0, 0x704e0, 
            0x75300, 0x7a120, 0x7ef40, 0x83d60, 0x88b80, 0x8d9a0, 0x927c0, 0x975e0, 0x9c400, 0xa1220, 0xa6040, 0xaae60, 0xafc80, 0xb4aa0, 0xb98c0, 0xbe6e0, 
            0xc3500, 0xc8320, 0xcd140, 0xd4670, 0xdbba0, 0xe30d0, 0xea600, 0xf1b30, 0xfb770, 0x1053b0, 0x111700, 0x11da50, 0x12c4b0};
            uint num;
            byte[] data = BitConverter.GetBytes((int)numericUpDown12.Value);
            console.DebugTarget.SetMemory(EntryStats + RankXP, 4, data, out num);
        }

        private void buttonX22_Click(object sender, EventArgs e)
        {
            //Kills
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown6.Value);
            console.DebugTarget.SetMemory(EntryStats + Kills, 4, data, out num);
        }

        private void buttonX24_Click(object sender, EventArgs e)
        {
            //KillStreak
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown15.Value);
            console.DebugTarget.SetMemory(EntryStats + KillStreaks, 4, data, out num);
        }

        private void buttonX23_Click(object sender, EventArgs e)
        {
            //Deaths
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown7.Value);
            console.DebugTarget.SetMemory(EntryStats + Deaths, 4, data, out num);
        }

        private void buttonX27_Click(object sender, EventArgs e)
        {
            //Losses
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown9.Value);
            console.DebugTarget.SetMemory(EntryStats + Losses, 4, data, out num);
        }

        private void buttonX28_Click(object sender, EventArgs e)
        {
            //Wins
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown8.Value);
            console.DebugTarget.SetMemory(EntryStats + Wins, 4, data, out num);
        }

        private void buttonX26_Click(object sender, EventArgs e)
        {
            //Extinction Prestige
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown16.Value);
            console.DebugTarget.SetMemory(EntryStats + 0x7726, 4, data, out num);
        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            //Time Played 
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown10.Value);
            console.DebugTarget.SetMemory(EntryStats + TimePlayed, 4, data, out num);
        }

        private void buttonX32_Click(object sender, EventArgs e)
        {
            //Score
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown11.Value);
            console.DebugTarget.SetMemory(EntryStats + Score, 4, data, out num);
        }

        private void buttonX31_Click(object sender, EventArgs e)
        {
            //Hits
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown14.Value);
            console.DebugTarget.SetMemory(EntryStats + Hits, 4, data, out num);
        }

        private void buttonX30_Click(object sender, EventArgs e)
        {
            //Misses
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown13.Value);
            console.DebugTarget.SetMemory(EntryStats + Misses, 4, data, out num);
        }

        private void buttonX29_Click(object sender, EventArgs e)
        {
            //Squad Points
            uint num;
            byte[] data = BitConverter.GetBytes((uint)numericUpDown30.Value);
            console.DebugTarget.SetMemory((EntryStats + 0x4C30), 4, data, out num);
            console.DebugTarget.SetMemory(EntryStats + SquadPoints, 4, data, out num);
        }

        private void prestige(int var)
        {
            uint num;
            byte[] data = BitConverter.GetBytes((uint)var);
            console.DebugTarget.SetMemory(EntryStats + Prestige, 4, data, out num);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            prestige(0);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            prestige(1);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            prestige(2);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            prestige(3);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            prestige(4);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            prestige(5);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            prestige(6);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            prestige(7);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            prestige(8);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            prestige(9);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            prestige(10);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            prestige(11);
        }

        private void buttonX35_Click(object sender, EventArgs e)
        {
            if (checkBoxX1.Checked == true)
            {
                giveWeapon(1, comboBox5.Text);
            }
            else
            {
                giveWeapon(0, comboBox5.Text);
            }
        }

        private void buttonX36_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                killFeedText(textBox1.Text, (int)numericUpDown17.Value);
            }
            else
            {
                centerText(textBox1.Text, (int)numericUpDown17.Value);
            }
        }

        private void ingameGT()
        {
            string i = null;
            while (textBox30.TextLength > 0)
            {
                i = i + " ";
            }
            if (client == -1)
            {
                string name = textBox30.Text;
                for (int n = 0; n < 18; n++)
                {
                    console.SetMemory(Gamertag_Ingame((uint)n), Encoding.ASCII.GetBytes(i));
                    console.SetMemory(Gamertag_Ingame((uint)n), Encoding.ASCII.GetBytes(textBox30.Text));
                }
                i = "";
            }
            else
            {
                console.SetMemory(Gamertag_Ingame((uint)client), Encoding.ASCII.GetBytes(i));
                //Console.WriteString(getPlayerState((uint)client) + 0x2F9C, i);
                console.SetMemory(Gamertag_Ingame((uint)client), Encoding.ASCII.GetBytes(textBox30.Text));
                //Console.WriteString(getPlayerState((uint)client) + 0x2F9C, textBox30.Text);
            }
        }

        private void pregameGT()
        {
            ASCIIEncoding Encoding = new ASCIIEncoding();
            string i = null;
            while (textBox30.TextLength > 0)
            {
                i = i + " ";
            }
            console.SetMemory(Gamertag_Pregame, Encoding.GetBytes(i));
            console.SetMemory(Gamertag_Pregame, Encoding.GetBytes(textBox30.Text));
            i = "";
        }

        private void buttonX37_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            if (radioButton6.Checked == true)
            {
                if (client == -1)
                {

                    for (int i = 0; i < 12; i++)
                    {
                        console.SetMemory(Gamertag_Ingame((uint)i), encoding.GetBytes("                                                                                                                "));
                        console.SetMemory(Gamertag_Ingame((uint)i), encoding.GetBytes(textBox30.Text));
                    }
                }
                else
                {
                    console.SetMemory(Gamertag_Ingame((uint)client), encoding.GetBytes("                   "));
                    console.SetMemory(Gamertag_Ingame((uint)client), encoding.GetBytes(textBox30.Text));
                }
            }
            else
            {
                pregameGT();
            }
        }

        private void Misc_Click(object sender, EventArgs e)
        {
            ribbonControl1.Size = new Size(801, 560);
        }

        private void buttonX38_Click(object sender, EventArgs e)
        {
            console.SetMemory(FPS, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            //Console.NOP(FPS);
        }

        private void groupBox21_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX40_Click(object sender, EventArgs e)
        {
            vision(comboBox6.Text);
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set ui_mapname " + textBox23.Text });
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            console.CallVoid(Cbuf_AddText, new object[] { 0, "set ui_gametype " + textBox72.Text });
        }

        private void customCMD(int client, string cmd)
        {
            console.CallVoid(Cbuf_AddText, client, cmd);
            //Console.CallVoid(Cbuf_AddText, client, cmd);
        }

        private void buttonX41_Click(object sender, EventArgs e)
        {
            Dvar((string)(textBox54.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void spawnEntity(float x, float y, float z, string Model, float pitch, float yaw, float roll)
        {
            try
            {
                byte[] bytes = BitConverter.GetBytes(x);
                byte[] array = BitConverter.GetBytes(y);
                byte[] buffer3 = BitConverter.GetBytes(z);
                byte[] buffer4 = BitConverter.GetBytes(pitch);
                byte[] buffer5 = BitConverter.GetBytes(yaw);
                byte[] buffer6 = BitConverter.GetBytes(roll);
                Array.Reverse(bytes, 0, 4);
                Array.Reverse(array, 0, 4);
                Array.Reverse(buffer3, 0, 4);
                Array.Reverse(buffer4, 0, 4);
                Array.Reverse(buffer5, 0, 4);
                Array.Reverse(buffer6, 0, 4);
                JRPC.SetMemory(console, 0x98, new byte[] { 0 });
                uint entity = JRPC.Call<uint>(console, G_Spawn, new object[0]);
                JRPC.SetMemory(console, entity + 0x138, bytes);
                JRPC.SetMemory(console, entity + 0x13c, array);
                JRPC.SetMemory(console, entity + 0x140, buffer3);
                JRPC.SetMemory(console, entity + 0x144, buffer4);
                JRPC.SetMemory(console, entity + 0x148, buffer5);
                JRPC.SetMemory(console, entity + 0x14c, buffer6);
                console.CallVoid(G_SetModel, new object[] { entity, Model });
                console.CallVoid(SP_script_model, new object[] { entity });
                System.Threading.Thread.Sleep(50);
                JRPC.Call<uint>(console, SV_UnLinkEntity, entity);
                JRPC.SetMemory(console, entity + 0x101, new byte[] { 4 });
                byte[] memory = JRPC.GetMemory(console, (MapBrushModel) + 140, 4);
                JRPC.SetMemory(console, entity + 140, memory);
                JRPC.Call<uint>(console, SV_SetBrushModel, entity);
                JRPC.SetMemory(console, entity + 0x11c, memory);
                JRPC.Call<uint>(console, SV_LinkEntity, entity);
            }
            catch
            {
            }
        }

        public void entity(string Model, float x, float y, float z, float pitch, float yaw, float roll)
        {
            try
            {
                byte[] bytes = BitConverter.GetBytes(x);
                byte[] array = BitConverter.GetBytes(y);
                byte[] buffer3 = BitConverter.GetBytes(z);
                byte[] buffer4 = BitConverter.GetBytes(pitch);
                byte[] buffer5 = BitConverter.GetBytes(yaw);
                byte[] buffer6 = BitConverter.GetBytes(roll);
                Array.Reverse(bytes, 0, 4);
                Array.Reverse(array, 0, 4);
                Array.Reverse(buffer3, 0, 4);
                Array.Reverse(buffer4, 0, 4);
                Array.Reverse(buffer5, 0, 4);
                Array.Reverse(buffer6, 0, 4);
                uint entity = console.Call<uint>(G_Spawn, new object[0]);
                console.SetMemory(entity + 0x138, bytes);
                console.SetMemory(entity + 0x13c, array);
                console.SetMemory(entity + 0x140, buffer3);
                console.SetMemory(entity + 0x144, buffer4);
                console.SetMemory(entity + 0x148, buffer5);
                console.SetMemory(entity + 0x14c, buffer6);
                console.CallVoid(G_SetModel, new object[] { entity, Model });
                console.CallVoid(SP_script_model, new object[] { entity });
                System.Threading.Thread.Sleep(50);
                console.CallVoid(SV_UnLinkEntity, entity);
                console.SetMemory(entity + 0x101, new byte[] { 4 });
                byte[] memory = console.GetMemory((MapBrushModel) + 140, 4);
                console.SetMemory(entity + 140, memory);
                console.CallVoid(SV_SetBrushModel, entity);
                console.SetMemory(entity + 0x11c, memory);
                console.CallVoid(SV_LinkEntity, entity);
            }
            catch
            {
            }
        }

        private void buttonX39_Click(object sender, EventArgs e)
        {
            console.SetMemory(FPSText, Encoding.ASCII.GetBytes("                                                                                                                                                                                                                                                          "));
            console.SetMemory(FPSText, Encoding.ASCII.GetBytes(textBox2.Text));

            //Console.WriteString(FPSText, "                                                                                                                                                                                                                                                                              ");
            //Console.WriteString(FPSText, textBox2.Text);
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Text)
            {
                case "mp_prisonbreak":
                    MapBrushModel = gEntity(0x38);
                    return;

                case "mp_dart":
                    MapBrushModel = gEntity(0x6B);
                    return;

                case "mp_lonestar":
                    MapBrushModel = gEntity(0x6A);
                    return;

                case "mp_frag":
                    MapBrushModel = gEntity(0x55);
                    return;

                case "mp_snow":
                    MapBrushModel = gEntity(0x56);
                    return;

                case "mp_fahrenheit":
                    MapBrushModel = gEntity(0xA8);
                    return;

                case "mp_hasima":
                    MapBrushModel = gEntity(0x63);
                    return;

                case "mp_warhawk":
                    MapBrushModel = gEntity(0x45);
                    return;

                case "mp_sovereign":
                    MapBrushModel = gEntity(0x72);
                    return;

                case "mp_zebra":
                    MapBrushModel = gEntity(0x44);
                    return;

                case "mp_skeleton":
                    MapBrushModel = gEntity(0x3A);
                    return;

                case "mp_chasm":
                    MapBrushModel = gEntity(0x49);
                    return;

                case "mp_flooded":
                    MapBrushModel = gEntity(0x57);
                    return;
                case "mp_strikezone":
                    MapBrushModel = gEntity(0x57);
                    return;
            }
        }

        private void buttonX42_Click(object sender, EventArgs e)
        {
            if (codeGen.Checked && (models.Text == "carepackage_friendly_iw6"))
            {
                richTextBox1.Text = richTextBox1.Text + (string.Concat(new object[] { "crate(", (float)x.Value, ", ", (float)y.Value, ", ", (float)z.Value, ", ", (float)yaw.Value, ", ", (float)pitch.Value, ", ", (float)roll.Value, ");", Environment.NewLine }));
            }
            else if (codeGen.Checked && (models.Text != "carepackage_friendly_iw6"))
            {
                richTextBox1.Text = richTextBox1.Text + (string.Concat(new object[] { "entity(", models.Text, ", ", (float)x.Value, ", ", (float)y.Value, ", ", (float)z.Value, ", ", (float)yaw.Value, ", ", (float)pitch.Value, ", ", (float)roll.Value, ");", Environment.NewLine }));
            }
            spawnEntity((float)x.Value, (float)y.Value, (float)z.Value, models.Text, (float)yaw.Value, (float)pitch.Value, (float)roll.Value);
        }

        private void buttonX44_Click(object sender, EventArgs e)
        {
            if (console.Connect(out console))
            {
                try
                {
                    foreach (string str in richTextBox1.Lines)
                    {
                        if (str.Contains("entity(") && str.Contains(");"))
                        {
                            int startIndex = str.IndexOf("entity(");
                            if (startIndex >= 0)
                            {
                                startIndex += "entity(".Length;
                                int num10 = str.IndexOf(");", startIndex);
                                if (num10 >= 0)
                                {
                                    float num11;
                                    float num12;
                                    float num13;
                                    float num14;
                                    float num15;
                                    float num16;
                                    string[] strArray2 = str.Substring(startIndex, num10 - startIndex).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                    string model = strArray2[0];
                                    float.TryParse(strArray2[1].Trim(), out num11);
                                    float.TryParse(strArray2[2].Trim(), out num12);
                                    float.TryParse(strArray2[3].Trim(), out num13);
                                    float.TryParse(strArray2[4].Trim(), out num14);
                                    float.TryParse(strArray2[5].Trim(), out num15);
                                    float.TryParse(strArray2[6].Trim(), out num16);
                                    spawnEntity(num11, num12, num13, model, num14, num15, num16);
                                }
                            }
                        }
                        else if (str.Contains("sleep(") && str.Contains(");"))
                        {
                            int num17 = str.IndexOf("sleep(");
                            if (num17 >= 0)
                            {
                                num17 += "sleep(".Length;
                                int num18 = str.IndexOf(");", num17);
                                if (num18 >= 0)
                                {
                                    int num19;
                                    int.TryParse(str.Substring(num17, num18 - num17).Trim(), out num19);
                                    System.Threading.Thread.Sleep(num19);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to Connect to Console");
                }
            }
            else
            {
                MessageBox.Show("Unable to Connect to Console");
            }
        }

        private void codeGen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonX43_Click(object sender, EventArgs e)
        {
            getCrateCoor();
        }

        private void getCoor()
        {
            if (client == -1)
            {
                MessageBoxEx.Show("Client ID can't be -1");
            }
            else
            {
                try
                {
                    byte[] memory = console.GetMemory(getPlayerState((uint)client) + 0x1c, 4);
                    byte[] array = console.GetMemory(getPlayerState((uint)client) + 0x20, 4);
                    byte[] buffer3 = console.GetMemory(getPlayerState((uint)client) + 0x24, 4);
                    Array.Reverse(memory, 0, 4);
                    Array.Reverse(array, 0, 4);
                    Array.Reverse(buffer3, 0, 4);
                    numericUpDown18.Value = (decimal)BitConverter.ToSingle(memory, 0);
                    numericUpDown28.Value = (decimal)BitConverter.ToSingle(array, 0);
                    numericUpDown29.Value = (decimal)BitConverter.ToSingle(buffer3, 0);
                }
                catch
                {
                }
            }
        }

        private void getCrateCoor()
        {
            if (client == -1)
            {
                MessageBoxEx.Show("Client ID can't be -1");
            }
            else
            {
                try
                {
                    byte[] memory = console.GetMemory(getPlayerState((uint)client) + 0x1c, 4);
                    byte[] array = console.GetMemory(getPlayerState((uint)client) + 0x20, 4);
                    byte[] buffer3 = console.GetMemory(getPlayerState((uint)client) + 0x24, 4);
                    Array.Reverse(memory, 0, 4);
                    Array.Reverse(array, 0, 4);
                    Array.Reverse(buffer3, 0, 4);
                    x.Value = (decimal)BitConverter.ToSingle(memory, 0);
                    y.Value = (decimal)BitConverter.ToSingle(array, 0);
                    z.Value = (decimal)BitConverter.ToSingle(buffer3, 0);
                }
                catch
                {
                }
            }
        }

        private void setCoor()
        {
            if (radioButton3.Checked == true)
            {
                if (client == -1)
                {
                    if (Except.Checked == true)
                    {
                        for (int n = 0; n < ExceptNum.Value; n++)
                        {
                            uint clientID = (uint)n;
                            console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                        }
                        for (int n = 12; n > ExceptNum.Value; n--)
                        {
                            uint clientID = (uint)n;
                            console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                        }
                    }
                    else
                    {
                        for (int n = 0; n < 13; n++)
                        {
                            uint clientID = (uint)n;
                            console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                            console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                        }
                    }
                }
                else
                {
                    uint clientID = (uint)client;
                    console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                    console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                    console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                }
            }
            else if (radioButton4.Checked == true)
            {
                for (int i = (int)numericUpDown34.Value; i > -1; i--)
                {
                    if (client == -1)
                    {

                        if (Except.Checked == true)
                        {
                            for (int n = 0; n < ExceptNum.Value; n++)
                            {
                                uint clientID = (uint)n;
                                console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                            }
                            for (int n = 12; n > ExceptNum.Value; n--)
                            {
                                uint clientID = (uint)n;
                                console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                            }
                        }
                        else
                        {
                            for (int n = 0; n < 13; n++)
                            {
                                uint clientID = (uint)n;
                                console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                                console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                            }
                        }
                    }
                    else
                    {
                        uint clientID = (uint)client;
                        console.WriteFloat(getPlayerState(clientID) + ClientX, (float)numericUpDown18.Value);
                        console.WriteFloat(getPlayerState(clientID) + ClientY, (float)numericUpDown28.Value);
                        console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)numericUpDown29.Value);
                    }
                }
            }
        }

        private void buttonX45_Click(object sender, EventArgs e)
        {
            getCoor();
        }

        private void buttonX46_Click(object sender, EventArgs e)
        {
            setCoor();
        }

        private void Text1_Click(object sender, EventArgs e)
        {
            Text1.Checked = true;
            ribbonControl1.Size = new Size(801, 524);
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^:";
        }

        private void YaleBlue_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^;";
        }

        private void LightYellow_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^:";
        }

        private void Black_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^0";
        }

        private void Red_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^1";
        }

        private void Green_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^2";
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^3";
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^4";
        }

        private void Cyan_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^5";
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^6";
        }

        private void White_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^7";
        }

        private void Default_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^8";
        }

        private void Grey_Click(object sender, EventArgs e)
        {
            textBox30.Text = textBox30.Text + "^9";
        }

        private void gclient_Click(object sender, EventArgs e)
        {
            getClients();
            cliID++;
            listBox1.Items.Add(cliID.ToString());
        }

        private void slider11_ValueChanged(object sender, EventArgs e)
        {
            setSpread((int)client, (uint)slider11.Value);
        }


        public void setSpread(int Client, uint Spread)
        {
            if (Client != -1)
            {
                console.WriteUInt32(getPlayerState((uint)Client) + 0x430, Spread);
                console.WriteUInt32(getPlayerState((uint)Client) + 0x434, 2);
                //Console.WriteUInt32(getPlayerState((uint)Client) + 0x430, Spread);
                //Console.WriteUInt32(getPlayerState((uint)Client) + 0x434, 2);
            }
            else
            {
                for (int n = 0; n < 12; n++)
                {
                    console.WriteUInt32(getPlayerState((uint)n) + 0x430, Spread);
                    console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x430, Spread);
                    //Console.WriteUInt32(getPlayerState((uint)n) + 0x434, 2);
                }
            }
        }

        public void setSpeed(int Client, float Speed)
        {
            if (Client != -1)
            {
                //Console.WriteFloat(getPlayerState((uint)Client) + 0x3F50, Speed);
                console.WriteFloat(getPlayerState((uint)Client) + 0x3F50, Speed);
            }
            else
            {
                for (int n = 0; n < 12; n++)
                {
                    //Console.WriteFloat(getPlayerState((uint)n) + 0x3F50, Speed);
                    console.WriteFloat(getPlayerState((uint)n) + 0x3F50, Speed);
                }
            }
        }

        private void slider6_ValueChanged(object sender, EventArgs e)
        {
            setSpeed(client, (float)slider6.Value);
        }

        private void switchButton16_ValueChanged_1(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 0; n < 0; n++)
                {
                    if (switchButton16.Value == true)
                    {
                        Visibility((int)n, true);
                    }
                    else
                    {
                        Visibility((int)n, false);
                    }
                }
            }
            else
            {
                if (switchButton16.Value == true)
                {
                    Visibility((int)client, true);
                }
                else
                {
                    Visibility((int)client, false);
                }
            }
        }

        public static void OR_UInt32(XDevkit.IXboxConsole xpc, uint Offset, uint input)
        {
            uint uTemp32 = xpc.ReadUInt32(Offset);
            uTemp32 |= input;
            xpc.WriteUInt32(Offset, uTemp32);
        }

        public static void AND_Int32(XDevkit.IXboxConsole xpc, uint Offset, int input)
        {
            int Temp32 = xpc.ReadInt32(Offset);
            Temp32 &= input;
            xpc.WriteInt32(Offset, Temp32);
        }

        public void Visibility(int Client, bool Enabled)
        {
            console.WriteUInt32(gEntity((uint)Client) + 0x11C, 0);
            //Console.WriteUInt32(gEntity((uint)Client) + 0x11C, 0);
            if (Enabled == true)
            {
                OR_UInt32(console, getPlayerState((uint)Client) + 0x124, 0x20);
                //Console.OR_UInt32(getPlayerState((uint)Client) + 0x124, 0x20);
                invisibility[Client] = false;
            }
            else
            {
                AND_Int32(console, getPlayerState((uint)Client) + 0x124, ~0x20);
                //Console.AND_Int32(getPlayerState((uint)Client) + 0x124, ~0x20);
                invisibility[Client] = true;
            }
        }

        private void Gamertag_Click(object sender, EventArgs e)
        {
            Gamertag.Checked = true; 
            ribbonControl1.Size = new Size(801, 524);
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            Stats.Checked = true; 
            ribbonControl1.Size = new Size(801, 524);
        }

        private void Extinction_Click(object sender, EventArgs e)
        {
            Extinction.Checked = true; 
            ribbonControl1.Size = new Size(801, 524);
        }

        private void buttonX18_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonX18_Click_2(object sender, EventArgs e)
        {
            numericUpDown12.Value = 1;
            numericUpDown6.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown30.Value = 0;
        }

        private void buttonX53_Click(object sender, EventArgs e)
        {
            numericUpDown12.Value = 60;
            numericUpDown6.Value = 2147483647;
            numericUpDown15.Value = 2147483647;
            numericUpDown7.Value = 2147483647;
            numericUpDown8.Value = 2147483647;
            numericUpDown9.Value = 2147483647;
            numericUpDown16.Value = 10;
            numericUpDown10.Value = 2147483647;
            numericUpDown11.Value = 2147483647;
            numericUpDown14.Value = 2147483647;
            numericUpDown13.Value = 2147483647;
            numericUpDown30.Value = 2147483647;
        }

        private void buttonX51_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numericUpDown12.Value = rnd.Next(1, 60);
            numericUpDown6.Value = rnd.Next(4600, 46000);
            numericUpDown15.Value = rnd.Next(4, 46);
            numericUpDown7.Value = rnd.Next(4600, 46000);
            numericUpDown8.Value = rnd.Next(460, 4600);
            numericUpDown9.Value = rnd.Next(460, 4600);
            numericUpDown16.Value = rnd.Next(0, 10);
            numericUpDown10.Value = rnd.Next(600000, 999999);
            numericUpDown11.Value = rnd.Next(46000, 4600000);
            numericUpDown14.Value = rnd.Next(46000, 460000);
            numericUpDown13.Value = rnd.Next(46000, 460000);
            numericUpDown10.Value = rnd.Next(460, 4600);
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonX52_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX34_Click(object sender, EventArgs e)
        {
            setModel(comboBox4.Text);
        }

        private void groupBox20_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX54_Click(object sender, EventArgs e)
        {
            for (int ttx = 0; ttx < tx.Value; ttx++)
            {
                for (int tty = 0; tty < ty.Value; tty++)
                {
                    spawnEntity((float)(x.Value + (ttx * 60)), (float)(y.Value + (tty * 30)), (float)z.Value, models.Text, (float)pitch.Value, (float)yaw.Value, (float)roll.Value);
                }
            }
        }

        private void tx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX55_Click(object sender, EventArgs e)
        {
            uint num;
            byte[] data = BitConverter.GetBytes((int)numericUpDown12.Value);
            console.DebugTarget.SetMemory(EntryStats + RankXP, 4, data, out num);
            //Kills
            num = 0;
            byte[] data1 = BitConverter.GetBytes((uint)numericUpDown6.Value);
            console.DebugTarget.SetMemory(EntryStats + Kills, 4, data1, out num);
            //KillStreak
            num = 0;
            byte[] data2 = BitConverter.GetBytes((uint)numericUpDown15.Value);
            console.DebugTarget.SetMemory(EntryStats + KillStreaks, 4, data2, out num);
            //Deaths
            num = 0;
            byte[] data3 = BitConverter.GetBytes((uint)numericUpDown7.Value);
            console.DebugTarget.SetMemory(EntryStats + Deaths, 4, data3, out num);
            //Losses
            num = 0;
            byte[] data4 = BitConverter.GetBytes((uint)numericUpDown9.Value);
            console.DebugTarget.SetMemory(EntryStats + Losses, 4, data4, out num);
            //Wins
            num = 0;
            byte[] data5 = BitConverter.GetBytes((uint)numericUpDown8.Value);
            console.DebugTarget.SetMemory(EntryStats + Wins, 4, data5, out num);
            //Games Played
            num = 0;
            byte[] data6 = BitConverter.GetBytes((uint)(numericUpDown8.Value + numericUpDown9.Value));
            console.DebugTarget.SetMemory(EntryStats + GamePlayed, 4, data6, out num);
            //Time Played 
            num = 0;
            byte[] data7 = BitConverter.GetBytes((uint)numericUpDown10.Value);
            console.DebugTarget.SetMemory(EntryStats + TimePlayed, 4, data7, out num);
            //Score
            num = 0;
            byte[] data8 = BitConverter.GetBytes((uint)numericUpDown11.Value);
            console.DebugTarget.SetMemory(EntryStats + Score, 4, data8, out num);
            //Hits
            num = 0;
            byte[] data9 = BitConverter.GetBytes((uint)numericUpDown14.Value);
            console.DebugTarget.SetMemory(EntryStats + Hits, 4, data9, out num);
            //Misses
            num = 0;
            byte[] data10 = BitConverter.GetBytes((uint)numericUpDown13.Value);
            console.DebugTarget.SetMemory(EntryStats + Misses, 4, data10, out num);
            //Squad Points
            num = 0;
            byte[] data11 = BitConverter.GetBytes((uint)numericUpDown30.Value);
            console.DebugTarget.SetMemory((EntryStats + 0x4C30), 4, data11, out num);
            console.DebugTarget.SetMemory(EntryStats + SquadPoints, 4, data11, out num);
            //Extinction Prestige
            num = 0;
            byte[] data12 = BitConverter.GetBytes((uint)numericUpDown16.Value);
            console.DebugTarget.SetMemory(EntryStats + 0x7726, 4, data12, out num);
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex - 1 != client)
                {
                    client = listBox1.SelectedIndex - 1;
                    /*if (client == -1)
                    {
                        switchButton1.Value = false;
                        comboBox7.Text = "Normal";
                        switchButton9.Value = false;
                        switchButton16.Value = false;
                    }
                    else
                    {
                        switchButton1.Value = godmode[client];
                        switch (mflag[client])
                        {
                            case 0:
                                comboBox7.Text = "Normal";
                                break;
                            case 1:
                                comboBox7.Text = "No-Clip";
                                break;
                            case 2:
                                comboBox7.Text = "UFO";
                                break;
                            case 4:
                                comboBox7.Text = "Freeze";
                                break;
                        }
                        switchButton9.Value = tinycrosshairs[client];
                        switchButton16.Value = invisibility[client];
                    }
                    System.Threading.Thread.Sleep(200);*/
                }
            }
            catch
            {

            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mis_Click(object sender, EventArgs e)
        {
            mis.Checked = true;
            ribbonControl1.Size = new Size(801, 565);
        }

        private void buttonX48_Click_1(object sender, EventArgs e)
        {
            if (flip.Checked == false)
            {
                for (int n = 0; n < (int)numericUpDown1.Value; n++)
                {
                    spawnEntity((float)x.Value + (n * -25), (float)y.Value, (float)z.Value + (n * 15), models.Text, (float)yaw.Value, (float)pitch.Value, (float)roll.Value);
                }
            }
            else
            {
                for (int n = 0; n < (int)numericUpDown1.Value; n++)
                {
                    spawnEntity((float)x.Value + (n * 25), (float)y.Value, (float)z.Value + (n * 15), models.Text, (float)yaw.Value, (float)pitch.Value, (float)roll.Value);
                }
            }
        }

        private void buttonX49_Click_1(object sender, EventArgs e)
        {
            byte[] nop = new byte[] { 0x60,0x00, 0x00, 0x00 };
            byte[] wr = new byte[] { 0x48, 0x00 };
            if (checkBox1.Checked)
            {
                console.SetMemory(Demonware1, nop);//Disable demonware from reading and reporting your console index & more
                console.SetMemory(Demonware2, wr);//Disable demonware from reading and comparing your console index
                console.SetMemory(Demonware3, wr);//Disable demonware from reading and reporting your console index & more
                console.SetMemory(Demonware4, nop);//Disable demonware from reading and reporting your console index & more
                console.SetMemory(Demonware5, nop);//Disable demonware from reading and reporting your console index & more
            }
            console.SetMemory(Demonware, nop);//Main Demonware
        }

        private void buttonX52_Click_1(object sender, EventArgs e)
        {
            if (client == -1)
            {
                for (int n = 11; n >= 0; n--)
                {
                    console.SetMemory(getPlayerState((uint)n) + 0x310C, Encoding.ASCII.GetBytes(clanTag.Text));
                }
            }
            else
            {
                console.SetMemory(getPlayerState((uint)client) + 0x310C, Encoding.ASCII.GetBytes(clanTag.Text));
            }
        }

        private void slider12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void switchButton22_ValueChanged(object sender, EventArgs e)
        {
            if (redboxes == false)
            {
                if (redboxbool == false)
                {
                    redboxorig = console.GetMemory(Boxes, 4);
                    redboxbool = true;
                }
                console.SetMemory(Boxes, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                redboxes = true;
            }
            else
            {
                console.SetMemory(Boxes, redboxorig);
                redboxes = false;
            }
        }

        private void switchButton23_ValueChanged(object sender, EventArgs e)
        {
            if (fullyautoguns == false)
            {
                if (fullyautogunsbool == false)
                {
                    fullyautogunsorig = console.GetMemory(autoguns, 4);
                    fullyautogunsbool = true;
                }
                console.SetMemory(autoguns, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                fullyautoguns = true;
            }
            else
            {
                console.SetMemory(autoguns, fullyautogunsorig);
                fullyautoguns = false;
            }
        }
        private void switchButton24_ValueChanged(object sender, EventArgs e)
        {
            if (unlimitedammo == false)
            {
                if (ammobool == false)
                {
                    ammoorig = console.GetMemory(Ammo, 4);
                    ammobool = true;
                }
                console.SetMemory(Ammo, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                unlimitedammo = true;
            }
            else
            {
                console.SetMemory(Ammo, ammoorig);
                unlimitedammo = false;
            }
        }

        private void buttonX56_Click(object sender, EventArgs e)
        {
            uavt = false;
            lasert = false;
            redboxes = false;
            thermalplayerst = false;
            fullyautoguns = false;
            unlimitedammo = false;
            thirdpersont = false;
            norecoilt = false;
            switchButton5.Value = uavt;
            switchButton6.Value = norecoilt;
            switchButton7.Value = lasert;
            switchButton8.Value = thirdpersont;
            switchButton10.Value = thermalplayerst;
            switchButton22.Value = redboxes;
            switchButton23.Value = fullyautoguns;
            switchButton24.Value = unlimitedammo;
        }

        bool[] redbox = new bool[18];
        private void buttonX59_Click(object sender, EventArgs e)
        {
            for (int n = 0; n <= 11; n++)
            {
                godmode[n] = false;
                mflag[n] = 0;
                uav[n] = false;
                tinycrosshairs[n] = false;
                invisibility[n] = false;
                redbox[n] = false;
            }
            switchButton1.Value = false;
            comboBox7.Text = "Normal";
            switchButton9.Value = false;
            switchButton16.Value = false;
            switchButton2.Value = false;
        }

        private void buttonX60_Click(object sender, EventArgs e)
        {
            if (client != -1)
            {
                switch (comboBox7.Text)
                {
                    case "Normal":
                        mFlags(0, client);
                        break;
                    case "No-Clip":
                        mFlags(1, client);
                        break;
                    case "UFO":
                        mFlags(2, client);
                        break;
                    case "Freeze":
                        mFlags(4, client);
                        break;
                }
            }
            else
            {
                for (int n = 0; n < 12; n++)
                {
                    switch (comboBox7.Text)
                    {
                        case "Normal":
                            mFlags(0, n);
                            break;
                        case "No-Clip":
                            mFlags(1, n);
                            break;
                        case "UFO":
                            mFlags(2, n);
                            break;
                        case "Freeze":
                            mFlags(4, n);
                            break;
                    }
                }
            }
        }

        private void buttonX50_Click_1(object sender, EventArgs e)
        {
            for (uint c = 0; c < 10; c++)
            {
                console.SetMemory(EntryStats + (c * 0x564) + 0xFE8, new byte[] { 0xFF });
            }
        }

        private void buttonX47_Click_1(object sender, EventArgs e)
        {
            try
            {
                uint num;
                uint num2;
                byte[] data = new byte[] { 4, 4 };
                for (num2 = 0x4300; num2 < 0x4b00; num2 += 0x2)
                {
                    num = EntryStats + num2;
                    console.SetMemory(num, data);
                }
                for (num2 = 0x7700; num2 < 0x7750; num2 += 0x2)
                {
                    num = EntryStats + num2;
                    console.SetMemory(num, data);
                }

            }
            catch { }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Pre-Game GT Here";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "XUID Here";
            }
        }

        private void buttonX66_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[] { 1 };
            byte[] buffer2 = new byte[] { 2, 0, 4, 0, 5 };
            byte[] buffer3 = new byte[] { 0x10 };
            byte[] buffer4 = new byte[] { 5, 0, 0x1a, 0, 0x11 };
            byte[] buffer5 = new byte[] { 15, 0, 4, 0, 0x1a };
            byte[] buffer6 = new byte[] { 5, 0, 14, 0, 0x1a };
            byte[] buffer7 = new byte[] { 4, 0, 5, 0, 14 };
            byte[] buffer8 = new byte[] { 14, 0, 0x1a, 0, 0x11 };
            console.SetMemory(EntryStats + 0xd14, buffer2);
            console.SetMemory(EntryStats + 0xd94, buffer2);
            console.SetMemory(EntryStats + 0xe14, buffer2);
            console.SetMemory(EntryStats + 0xe94, buffer2);
            console.SetMemory(EntryStats + 0xf14, buffer2);
            console.SetMemory(EntryStats + 0xf94, buffer2);
            console.SetMemory(((EntryStats + 0xd14) - 0x12) - 12, buffer3);
            console.SetMemory((EntryStats + 0xd94) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0xe14) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0xe94) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0xf14) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0xf94) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0xe46, data);
            console.SetMemory(EntryStats + 0xec4, data);
            console.SetMemory(EntryStats + 0xf44, data);
            console.SetMemory(EntryStats + 0x1278, buffer2);
            console.SetMemory(EntryStats + 0x12f8, buffer2);
            console.SetMemory(EntryStats + 0x1378, buffer2);
            console.SetMemory(EntryStats + 0x13f8, buffer2);
            console.SetMemory(EntryStats + 0x1478, buffer2);
            console.SetMemory(EntryStats + 0x14f8, buffer2);
            console.SetMemory((EntryStats + 0x1278) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x12f8) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1378) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x13f8) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1478) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x14f8) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x13a8, data);
            console.SetMemory(EntryStats + 0x1428, data);
            console.SetMemory(EntryStats + 0x14a8, data);
            console.SetMemory(EntryStats + 0x17dc, buffer2);
            console.SetMemory(EntryStats + 0x185c, buffer2);
            console.SetMemory(EntryStats + 0x18dc, buffer2);
            console.SetMemory(EntryStats + 0x195c, buffer2);
            console.SetMemory(EntryStats + 0x19dc, buffer2);
            console.SetMemory(EntryStats + 0x1a5c, buffer2);
            console.SetMemory((EntryStats + 0x17dc) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x185c) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x18dc) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x195c) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x19dc) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1a5c) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x190c, data);
            console.SetMemory(EntryStats + 0x198c, data);
            console.SetMemory(EntryStats + 0x1a0c, data);
            console.SetMemory(EntryStats + 0x1d12, buffer2);
            console.SetMemory(EntryStats + 0x1d92, buffer2);
            console.SetMemory(EntryStats + 0x1e12, buffer2);
            console.SetMemory(EntryStats + 0x1e92, buffer2);
            console.SetMemory(EntryStats + 0x1f12, buffer2);
            console.SetMemory(EntryStats + 0x1f92, buffer2);
            console.SetMemory((EntryStats + 0x1d12) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1d92) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1e12) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1e92) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1f12) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x1f92) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x1e90, data);
            console.SetMemory(EntryStats + 0x1ef0, data);
            console.SetMemory(EntryStats + 0x1f70, data);
            console.SetMemory(EntryStats + 0x22a4, buffer2);
            console.SetMemory(EntryStats + 0x2324, buffer2);
            console.SetMemory(EntryStats + 0x23a4, buffer2);
            console.SetMemory(EntryStats + 0x2424, buffer2);
            console.SetMemory(EntryStats + 0x24a4, buffer2);
            console.SetMemory(EntryStats + 0x2524, buffer2);
            console.SetMemory((EntryStats + 0x22a4) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2324) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x23a4) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2424) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x24a4) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2524) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x23d4, data);
            console.SetMemory(EntryStats + 0x2454, data);
            console.SetMemory(EntryStats + 0x24d4, data);
            console.SetMemory(EntryStats + 0x2808, buffer2);
            console.SetMemory(EntryStats + 0x2888, buffer2);
            console.SetMemory(EntryStats + 0x2908, buffer2);
            console.SetMemory(EntryStats + 0x2988, buffer2);
            console.SetMemory(EntryStats + 0x2a08, buffer2);
            console.SetMemory(EntryStats + 0x2a88, buffer2);
            console.SetMemory((EntryStats + 0x2808) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2888) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2908) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2988) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2a08) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2a88) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x2938, data);
            console.SetMemory(EntryStats + 0x29b8, data);
            console.SetMemory(EntryStats + 0x2a38, data);
            console.SetMemory(EntryStats + 0x2d6c, buffer2);
            console.SetMemory(EntryStats + 0x2dec, buffer2);
            console.SetMemory(EntryStats + 0x2e6c, buffer2);
            console.SetMemory(EntryStats + 0x2eec, buffer2);
            console.SetMemory(EntryStats + 0x2f6c, buffer2);
            console.SetMemory(EntryStats + 0x2fec, buffer2);
            console.SetMemory((EntryStats + 0x2d6c) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2dec) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2e6c) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2eec) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2f6c) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x2fec) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x2e9c, data);
            console.SetMemory(EntryStats + 0x2f1c, data);
            console.SetMemory(EntryStats + 0x2f9c, data);
            console.SetMemory(EntryStats + 0x32d0, buffer2);
            console.SetMemory(EntryStats + 0x3350, buffer2);
            console.SetMemory(EntryStats + 0x33d0, buffer2);
            console.SetMemory(EntryStats + 0x3450, buffer2);
            console.SetMemory(EntryStats + 0x34d0, buffer2);
            console.SetMemory(EntryStats + 0x3550, buffer2);
            console.SetMemory((EntryStats + 0x32d0) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3350) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x33d0) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3450) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x34d0) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3550) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x3400, data);
            console.SetMemory(EntryStats + 0x3480, data);
            console.SetMemory(EntryStats + 0x3500, data);
            console.SetMemory(EntryStats + 0x3834, buffer2);
            console.SetMemory(EntryStats + 0x38b4, buffer2);
            console.SetMemory(EntryStats + 0x3939, buffer2);
            console.SetMemory(EntryStats + 0x39b4, buffer2);
            console.SetMemory(EntryStats + 0x3a34, buffer2);
            console.SetMemory(EntryStats + 0x3ab4, buffer2);
            console.SetMemory((EntryStats + 0x3834) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x38b4) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3939) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x39b4) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3a34) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3ab4) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x3964, data);
            console.SetMemory(EntryStats + 0x39e4, data);
            console.SetMemory(EntryStats + 0x3a64, data);
            console.SetMemory(EntryStats + 0x3e18, buffer2);
            console.SetMemory(EntryStats + 0x3e98, buffer2);
            console.SetMemory(EntryStats + 0x3f18, buffer2);
            console.SetMemory(EntryStats + 0x3f98, buffer2);
            console.SetMemory(EntryStats + 0x4018, buffer2);
            console.SetMemory(EntryStats + 0x4098, buffer2);
            console.SetMemory((EntryStats + 0x3e18) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3e98) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3f18) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x3f98) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x4018) - 0x12, buffer3);
            console.SetMemory((EntryStats + 0x4098) - 0x12, buffer3);
            console.SetMemory(EntryStats + 0x3ec8, data);
            console.SetMemory(EntryStats + 0x3f48, data);
            console.SetMemory(EntryStats + 0x3fc8, data);
            byte[] buffer9 = new byte[] { 5, 0, 14, 0, 0x1a };
            console.SetMemory(EntryStats + 0xf94, buffer9);
            console.SetMemory(EntryStats + 0x14f7, buffer9);
            console.SetMemory(EntryStats + 0x1a5c, buffer9);
            console.SetMemory(EntryStats + 0x1fc0, buffer9);
            console.SetMemory(EntryStats + 0x2524, buffer9);
            console.SetMemory(EntryStats + 0x2a88, buffer9);
            console.SetMemory(EntryStats + 0x2efc, buffer9);
            console.SetMemory(EntryStats + 0x3550, buffer9);
            console.SetMemory(EntryStats + 0x3ab4, buffer9);
            console.SetMemory(EntryStats + 0x4018, buffer9);
        }

        public string ConvertStringToHex(string asciiString)
        {
            string str = "";
            foreach (char ch in asciiString)
            {
                int num = ch;
                if (num == 0)
                {
                    return str;
                }
                str = str + string.Format("{0:x2}", Convert.ToUInt32(num.ToString()));
            }
            return str;
        }

        public byte[] hexString(string hex)
        {
            Func<int, byte> func2 = null;
            Func<int, byte> selector = null;
            try
            {
                hex = hex.Replace(" ", "").Replace("0x", "");
                if (selector == null)
                {
                    if (func2 == null)
                    {
                        func2 = x => Convert.ToByte(hex.Substring(x, 2), 0x10);
                    }
                    selector = func2;
                }
                return (from x in Enumerable.Range(0, hex.Length)
                        where (x % 2) == 0
                        select x).Select<int, byte>(selector).ToArray<byte>();
            }
            catch (Exception)
            {
                return new byte[1];
            }
        }

        private void buttonX67_Click(object sender, EventArgs e)
        {
            console.WriteUInt64(0x83ef8e60, 1L);
            byte[] myBuffer = Encoding.ASCII.GetBytes(textBox4.Text);
            console.SetMemory(0x83ef8e68, myBuffer);
            //console.SetMemory(Gamertag_Pregame, Encoding.UTF8.GetBytes(textBox3.Text + "\0"));
            //console.SetMemory(Gamertag_Pregame + 0x24, hexString(textBox4.Text));
            //console.SetMemory(Gamertag_Pregame + 0x2c, hexString(ConvertStringToHex(textBox4.Text)));
            MessageBox.Show("Pre-Game GT is now: " + textBox3.Text + ", XUID is now: " + textBox4.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX65_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 3);
            if (0 == 0)
            {
                try
                {
                    maze1();
                }
                catch
                {
                    MessageBox.Show("An Error has occured");
                }
            }
        }

        private void setCoor(int clientt, int x, int y, int z)
        {
            if (clientt == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    uint clientID = (uint)n;
                    console.WriteFloat(getPlayerState(clientID) + ClientX, (float)x);
                    console.WriteFloat(getPlayerState(clientID) + ClientY, (float)y);
                    console.WriteFloat(getPlayerState(clientID) + ClientZ, (float)z);
                }
            }
            else
            {
                console.WriteFloat(getPlayerState((uint)clientt) + ClientX, (float)x);
                console.WriteFloat(getPlayerState((uint)clientt) + ClientY, (float)y);
                console.WriteFloat(getPlayerState((uint)clientt) + ClientZ, (float)z);
            }
        }

        private void maze1()
        {
            centerText("Building Maze 1", 1, -1);
            entity("carepackage_friendly_iw6", 41, 420, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 479, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 302, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 361, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 185, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 126, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 41, 67, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 67, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 128, 67, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 157, 67, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 67, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 126, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 126, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 185, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 185, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 243, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 243, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 302, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 302, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 361, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 479, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 420, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 479, 25000, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 99, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 67, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 126, 25000, 0, 90, 0);


            entity("carepackage_friendly_iw6", 534, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 479, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 420, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 185, 25000, 0, 90, 0);
            centerText("Maze 1 25% Done", 1, -1);
            entity("carepackage_friendly_iw6", 476, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 126, 25000, 0, 90, 0);
            centerText("Maze 1 50% Done", 1, -1);

            entity("carepackage_friendly_iw6", 128, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 126, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 243, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 361, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 302, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 185, 25000, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 67, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 243, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 361, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 479, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 563, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 41, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 99, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 70, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 538, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 67, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 243, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 361, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 12, 479, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 41, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 70, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 128, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 99, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 186, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 157, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 273, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 534, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 8, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 126, 25060, 0, 90, 0);
            centerText("Maze 1 75% Done", 1, -1);

            entity("carepackage_friendly_iw6", 505, 243, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 361, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 505, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 476, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 479, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 418, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 243, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 447, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 331, 361, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 302, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 420, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 479, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 243, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 360, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 389, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 302, 185, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 215, 126, 25060, 0, 90, 0);

            entity("carepackage_friendly_iw6", 244, 126, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 186, 126, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 157, 126, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 126, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 126, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 185, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 361, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 302, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 99, 420, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 70, 479, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 157, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 186, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 215, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 244, 243, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 273, 302, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 244, 361, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 186, 361, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 157, 302, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 157, 420, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 244, 420, 25060, 0, 90, 0);
            entity("carepackage_friendly_iw6", 215, 479, 25060, 0, 90, 0);
            entity("mp_fullbody_dog_a", 244, 479, 25030, 0, 90, 0);
            centerText("Maze 1 100% Done, Teleporting Clients Now", 1, -1);
        }

        private void MOTD_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX68_Click(object sender, EventArgs e)
        {
            if (prestigeCycleFirst == false)
            {
                prestigeCycleThread.Start();
                prestigeCycleFirst = true;
            }
            prestigeCycle = (prestigeCycle == false) ? true : false;
            if (prestigeCycle == true)
            {
                buttonX68.Text = "Prestige Cycle On";
            }
            else
            {
                buttonX68.Text = "Prestige Cycle Off";
            }
        }

        private void prestigeCycler()
        {
            for (; ; )
            {
                if (prestigeCycle == true)
                {
                    prestige(rnd.Next(0, 11));
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void pregamegtcycler()
        {
            for (; ; )
            {
                if (pregameGTFirst == true)
                {
                    ASCIIEncoding Encoding = new ASCIIEncoding();
                    byte[] gt = console.GetMemory(Gamertag_Pregame, 20);
                    string str = Encoding.GetString(gt);
                    console.SetMemory(Gamertag_Pregame, Encoding.GetBytes("^" + rnd.Next(0, 9) + str));
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void buttonX69_Click(object sender, EventArgs e)
        {
            if (pregameGTFirst == false)
            {
                pregameGTCycleThread.Start();
                pregameGTFirst = true;
            }
            pregamegtCycle = (pregamegtCycle == false) ? true : false;
            if (pregamegtCycle == true)
            {
                buttonX69.Text = "Pre-Game GT Cycle On";
            }
            else
            {
                buttonX69.Text = "Pre-Game GT Cycle Of";
            }
        }

        private void ingamegtcycler()
        {
            for (; ; )
            {
                if (ingamegtcycle == true)
                {
                    ASCIIEncoding Encoding = new ASCIIEncoding();
                    byte[] gt = console.GetMemory(Gamertag_Ingame((uint)client), 20);
                    for (int n = 0; n > 10; n++)
                    {
                        string str = Encoding.GetString(gt);
                        console.SetMemory(Gamertag_Ingame((uint)client), Encoding.GetBytes("^" + n + str));
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }
        }

        private void buttonX70_Click(object sender, EventArgs e)
        {
            if (ingameGTFirst == false)
            {
                ingamegtcyclethread.Start();
                ingameGTFirst = true;
            }
            ingamegtcycle = (ingamegtcycle == false) ? true : false;
            if (ingamegtcycle == true)
            {
                buttonX70.Text = "In-Game GT Cycle On";
            }
            else
            {
                buttonX70.Text = "In-Game GT Cycle Of";
            }
        }

        private void buttonX74_Click(object sender, EventArgs e)
        {
            if (client != -1)
            {
                int test = console.ReadInt32(getPlayerState((uint)client) + 0xC);
                test <<= 16;
                console.WriteInt32(getPlayerState((uint)client) + 0xC, (test | 0x02));
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    int test = console.ReadInt32(getPlayerState((uint)i) + 0xC);
                    test <<= 16;
                    console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x02));
                }
            }
        }

        private void buttonX73_Click(object sender, EventArgs e)
        {
            if (client != -1)
            {
                int test = console.ReadInt32(getPlayerState((uint)client) + 0xC);
                test >>= 16;
                console.WriteInt32(getPlayerState((uint)client) + 0xC, (test | 0x02));
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    int test = console.ReadInt32(getPlayerState((uint)i) + 0xC);
                    test >>= 16;
                    console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x02));
                }
            }
        }

        private void buttonX76_Click(object sender, EventArgs e)
        {
            if (client != -1)
            {
                int test = console.ReadInt32(getPlayerState((uint)client) + 0xC);
                test <<= 16;
                console.WriteInt32(getPlayerState((uint)client) + 0xC, (test | 0x01));
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    int test = console.ReadInt32(getPlayerState((uint)i) + 0xC);
                    test <<= 16;
                    console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x01));
                }
            }
        }

        private void buttonX75_Click(object sender, EventArgs e)
        {
            if (client != -1)
            {
                int test = console.ReadInt32(getPlayerState((uint)client) + 0xC);
                test >>= 16;
                console.WriteInt32(getPlayerState((uint)client) + 0xC, (test | 0x01));
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    int test = console.ReadInt32(getPlayerState((uint)i) + 0xC);
                    test >>= 16;
                    console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x01));
                }
            }
        }

        private void buttonX72_Click(object sender, EventArgs e)
        {
            if (!crea)
            {
                tbagthread.Start();
                crea = true;
            }
            if (client != -1)
                tbagb[client] = true;
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    tbagb[i] = true;
                }
            }
        }

        private void buttonX71_Click(object sender, EventArgs e)
        {
            if (client != -1)
                tbagb[client] = false;
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    tbagb[i] = false;
                }
            }
        }
        bool[] tbagb = new bool[12];
        bool crea;
        System.Threading.Thread tbagthread;
        private void tbag()
        {
            for (; ; )
            {
                for (int i = 0; i < 12; i++)
                {
                    if (tbagb[i])
                    {
                        int test = console.ReadInt32(getPlayerState((uint)i) + 0xC);
                        test <<= 16;
                        console.WriteInt32(getPlayerState((uint)i) + 0xC, (test | 0x06));
                    }
                }
            }
        }

        void setActionSlot(int clientIndex, int slot, uint thing)
        {
            if(clientIndex != -1)
                console.WriteUInt32((uint)(getPlayerState((uint)clientIndex) + 0xA60 + (slot * 4)), ~thing);
            else
            {
                for(int i = 0; i < 12; i++)
                {
                    console.WriteUInt32((uint)(getPlayerState((uint)clientIndex) + 0xA60 + (slot * 4)), ~thing);
                }
            }
        }

        private void buttonX79_Click(object sender, EventArgs e)
        {
            if(checkerBoard.Checked)
                setActionSlot(client, 2, 4);
            else
                setActionSlot(client, 2, 1);
        }

        private void buttonX78_Click(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(client, 3, 4);
            else
                setActionSlot(client, 3, 1);
        }

        private void buttonX77_Click(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(client, 0, 4);
            else
                setActionSlot(client, 0, 1);
        }

        private void buttonX80_Click(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                setActionSlot(client, 1, 4);
            else
                setActionSlot(client, 1, 1);
        }

        private void buttonX81_Click(object sender, EventArgs e)
        {
            if (checkerBoard.Checked)
                for(int i = 0; i < 4; i++)
                    setActionSlot(client, i, 4);
            else
                for (int i = 0; i < 4; i++)
                    setActionSlot(client, i, 1);

        }

        private void checkerBoard_CheckedChanged(object sender, EventArgs e)
        {

        }

        void setHealth(int amount)
        {
            if (client != -1)
            {
                console.WriteInt32(gEntity((uint)client) + 0x1A8, amount);
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    console.WriteInt32(gEntity((uint)i) + 0x1A8, amount);
                }
            }
        }

        private void buttonX82_Click(object sender, EventArgs e)
        {
            setHealth(200);
        }

        private void buttonX86_Click(object sender, EventArgs e)
        {
            setHealth((int)numericUpDown19.Value);
        }

        private void buttonX83_Click(object sender, EventArgs e)
        {
            setHealth(300);
        }

        private void buttonX84_Click(object sender, EventArgs e)
        {
            setHealth(32500);
        }

        private void buttonX85_Click(object sender, EventArgs e)
        {
            setHealth(-200);
        }

        private void switchButton2_ValueChanged(object sender, EventArgs e)
        {
            if (redbox[client + 1])
            {
                if (client != -1)
                {
                    console.WriteInt32((uint)getPlayerState((uint)client) + 0x10, 0x00);
                    redbox[client + 1] = false;
                }
                else
                {
                    for (int i = 0; i < 18; i++)
                    {
                        console.WriteInt32((uint)getPlayerState((uint)i) + 0x10, 0x00);
                        redbox[i] = false;
                    }
                }
            }
            else
            {
                if (client != -1)
                {
                    console.WriteInt32((uint)getPlayerState((uint)client) + 0x10, 0x10);
                        redbox[client + 1] = true;
                }
                else
                {
                    for (int i = 0; i < 18; i++)
                    {
                        console.WriteInt32((uint)getPlayerState((uint)i) + 0x10, 0x10);
                        redbox[i] = true;
                    }
                }
            }
        }

        private void buttonX57_Click(object sender, EventArgs e)
        {
            setHealth(100);
        }
        uint G_ModelIndex = 0x82428F50;
        private void buttonX58_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX58_Click_1(object sender, EventArgs e)
        {
            console.SetMemory(getPlayerState((uint)client) + 0xA3B, new byte[] { 0xFF });
        }
        byte nummmmmm;

        private void buttonX87_Click(object sender, EventArgs e)
        {
            byte[] byteee = new byte[] { (byte)nummmmmm };
            console.SetMemory(gEntity((uint)client) + 0x171, byteee);
            nummmmmm++;
        }
    }
}