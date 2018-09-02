using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using XRPCLib;
using JRPC_Client;

namespace Snow
{
    public partial class Snow : DevComponents.DotNetBar.OfficeForm
    {
        XRPC Jtag = new XRPC();
        JRPC Console = new JRPC();
        bool login = false;
        public Snow()
        {
            InitializeComponent();
        }
        //MW3 Offsets Start
        uint SV_GameSendServerCommandMW3 = 0x822C9278;
        uint laserMW3 = 0x8215a2c0;
        uint NoRecoilMW3 = 0x821614d4;
        uint UAVMW3 = 0x8210E58C;
        uint boxesMW3 = 0x821154a4;
        uint getPlayerStateMW3(uint clientIndex)
        {
            uint num;
            byte[] data = new byte[4];
            Jtag.xbCon.DebugTarget.GetMemory((0x82dccc80 + (clientIndex * 640)) + 0x158, 4, data, out num);
            Array.Reverse(data);
            return BitConverter.ToUInt32(data, 0);
        }
        private uint GentityMW3(int client)
        {
            return (uint)(-2099458944 + (client * 640));
        }

        private uint getClientStateMW3(int client)
        {
            return (0x82f99580 + (Convert.ToUInt32(client) * 0x3980));
        }
        //MW3 Offsets End
        //BO2 Offsets Start
        uint Cbuf_AddTextBO2 = 0x82401518;
        uint SV_GameSendServerCommandBO2 = 0x8242FAE0;
        public uint getPlayerStateBO2(uint clientIndex)
        {
            return (0x8354a310 + (clientIndex * 0x57f8));
        }
        //BO2 Offsets End
        //Ghosts Offsets Start

        uint Cbuf_AddTextGhosts = 0x82437490;//TU7
        uint autogunsGhosts = 0x82233C4C;//TU7
        uint boxesGhosts = 0x8225D58C;//TU7
        uint AmmoGhosts = 0x82238950;//TU7
        uint NoRecoilGhosts = 0x822B92B4;
        uint UAVGhosts = 0x8225591F;
        uint SV_GameSendServerCommandGhosts = 0x824BDC98;//TU7
        uint getPlayerStateGhosts(uint clientNum)//TU7
        {
            return 0x8328B700 + (clientNum * 0x3600);
        }
        uint gEntityGhosts(uint clientNum)//TU7
        {
            return 0x83302B80 + (clientNum * 0x280);
        }
        //Ghosts Offsets End
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(501, 215);
            GhostsClients.SelectedIndex = 0;
            TextClients.SelectedIndex = 0;
            GamertagClients.SelectedIndex = 0;
        }

        private void labelItem2_Click(object sender, EventArgs e)
        {

        }

        private void EnorDi(bool k)
        {
            Ghostsp.Enabled = k;
            Gamertagp.Enabled = k;
            Textp.Enabled = k;
            Statsp.Enabled = k;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                Random l = new Random();
                int r = l.Next(20, 40);
                connectionStatusBar.Value = 0;
                for (int n = connectionStatusBar.Value; n <= r; n++)
                {
                    System.Threading.Thread.Sleep(7);
                    connectionStatusBar.Value++;
                }
                Jtag.Connect();
                if (Jtag.activeConnection == true)
                {
                    int w = l.Next(60, 80);
                    for (int t = r; t <= w; t++)
                    {
                        System.Threading.Thread.Sleep(5);
                        connectionStatusBar.Value++;
                    }
                    Console.Connect();
                    if (Console.activeConnection == true)
                    {
                        for (int u = connectionStatusBar.Value; u <= 100; u++)
                        {
                            System.Threading.Thread.Sleep(7);
                            connectionStatusBar.Value++;
                        }
                        EnorDi(true);
                        status.Text = "Status: Successful";
                    }
                    else
                    {
                        EnorDi(false);
                        status.Text = "Status: Failed";
                    }
                }
                else
                {
                    EnorDi(false);
                    status.Text = "Status: Failed";
                }
            }
            catch
            {
                EnorDi(false);
                status.Text = "Status: Failed";
            }
        }

        public string ByteToString(byte[] input)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return encoding.GetString(input);
        }

        private void getClients(string loc, string game, int amount)
        {
            switch (loc)
            {
                case "Home":
                    switch (game)
                    {
                        case "Modern Warfare 3":
                            GhostsClients.Items.Clear();
                            GhostsClients.Items.Add("All Clients");
                            for (uint clientIndex = 0; clientIndex < amount; clientIndex++)
                            {
                                uint num;
                                byte[] data = new byte[20];
                                Jtag.xbCon.DebugTarget.GetMemory(this.getPlayerStateMW3(clientIndex) + 0x3414, 20, data, out num);
                                Jtag.xbCon.DebugTarget.InvalidateMemoryCache(true, this.getPlayerStateMW3(clientIndex) + 0x3414, 20);
                                string str = this.ByteToString(data);
                                GhostsClients.Items.Add("Client " + clientIndex + ": " + str);
                            }
                            break;
                        case "Black Ops 2":
                            GhostsClients.Items.Clear();
                            GhostsClients.Items.Add("All Clients");
                            for (int i = 0; i < amount; i++)
                            {
                                byte[] memory = Jtag.GetMemory(getPlayerStateBO2((uint)i) + 0x5534, 20);
                                Array.Reverse(memory);
                                GhostsClients.Items.Add("Client " + i + ": " + Encoding.ASCII.GetString(memory));
                            }
                            break;
                        case "Ghosts":
                            GhostsClients.Items.Clear();
                            GhostsClients.Items.Add("All Clients");
                            ASCIIEncoding encoding = new ASCIIEncoding();
                            for (int clients = 0; clients < amount; clients++)
                            {
                                byte[] memory = this.Jtag.GetMemory(getPlayerStateGhosts((uint)clients) + 0x2f9c, 0x10);
                                string str = encoding.GetString(memory);
                                GhostsClients.Items.Add("Client " + clients + ": " + str);
                            }
                            break;
                    }
                    break;
                case "Gamertag":
                    switch (game)
                    {
                        case "Modern Warfare 3":
                            GamertagClients.Items.Clear();
                            GamertagClients.Items.Add("All Clients");
                            for (uint clientIndex = 0; clientIndex < amount; clientIndex++)
                            {
                                uint num;
                                byte[] data = new byte[20];
                                Jtag.xbCon.DebugTarget.GetMemory(this.getPlayerStateMW3(clientIndex) + 0x3414, 20, data, out num);
                                Jtag.xbCon.DebugTarget.InvalidateMemoryCache(true, this.getPlayerStateMW3(clientIndex) + 0x3414, 20);
                                string str = this.ByteToString(data);
                                GamertagClients.Items.Add("Client " + clientIndex + ": " + str);
                            }
                            break;
                        case "Black Ops 2":
                            GamertagClients.Items.Clear();
                            GamertagClients.Items.Add("All Clients");
                            for (int i = 0; i < amount; i++)
                            {
                                byte[] memory = Jtag.GetMemory(getPlayerStateBO2((uint)i) + 0x5534, 20);
                                Array.Reverse(memory);
                                GamertagClients.Items.Add("Client " + i + ": " + Encoding.ASCII.GetString(memory));
                            }
                            break;
                        case "Ghosts":
                            GamertagClients.Items.Clear();
                            GamertagClients.Items.Add("All Clients");
                            ASCIIEncoding encoding = new ASCIIEncoding();
                            for (int clients = 0; clients < amount; clients++)
                            {
                                byte[] memory = this.Jtag.GetMemory(getPlayerStateGhosts((uint)clients) + 0x2f9c, 0x10);
                                string str = encoding.GetString(memory);
                                GamertagClients.Items.Add("Client " + clients + ": " + str);
                            }
                            break;
                    }
                    break;
                case "Text":
                    switch (game)
                    {
                        case "Modern Warfare 3":
                            TextClients.Items.Clear();
                            TextClients.Items.Add("All Clients");
                            for (uint clientIndex = 0; clientIndex < amount; clientIndex++)
                            {
                                uint num;
                                byte[] data = new byte[20];
                                Jtag.xbCon.DebugTarget.GetMemory(this.getPlayerStateMW3(clientIndex) + 0x3414, 20, data, out num);
                                Jtag.xbCon.DebugTarget.InvalidateMemoryCache(true, this.getPlayerStateMW3(clientIndex) + 0x3414, 20);
                                string str = this.ByteToString(data);
                                TextClients.Items.Add("Client " + clientIndex + ": " + str);
                            }
                            break;
                        case "Black Ops 2":
                            TextClients.Items.Clear();
                            TextClients.Items.Add("All Clients");
                            for (int i = 0; i < amount; i++)
                            {
                                byte[] memory = Jtag.GetMemory(getPlayerStateBO2((uint)i) + 0x5534, 20);
                                Array.Reverse(memory);
                                TextClients.Items.Add("Client " + i + ": " + Encoding.ASCII.GetString(memory));
                            }
                            break;
                        case "Ghosts":
                            TextClients.Items.Clear();
                            TextClients.Items.Add("All Clients");
                            ASCIIEncoding encoding = new ASCIIEncoding();
                            for (int clients = 0; clients < amount; clients++)
                            {
                                byte[] memory = this.Jtag.GetMemory(getPlayerStateGhosts((uint)clients) + 0x2f9c, 0x10);
                                string str = encoding.GetString(memory);
                                TextClients.Items.Add("Client " + clients + ": " + str);
                            }
                            break;
                    }
                    break;
            }
        }

        private void sendText(string game, string type, string text, int client)
        {
            switch (game)
            {
                case "Modern Warfare 3":
                    if(type == "center")
                        Jtag.Call(SV_GameSendServerCommandMW3, new object[] { client, 0, "c \"" + text + "\"" });
                    else
                        Jtag.Call(SV_GameSendServerCommandMW3, new object[] { client, 0, "f \"" + text +"\"" });
                    break;
                case "Black Ops 2":
                    if (type == "center")
                        Jtag.Call(SV_GameSendServerCommandBO2, new object[] { client, 0, "< \"" + text + "\"" });
                    else
                        Jtag.Call(SV_GameSendServerCommandBO2, new object[] { client, 0, "O \"" + text + "\"" });
                    break;
                case "Ghosts":
                    if (type == "center")
                        Jtag.Call(SV_GameSendServerCommandGhosts, new object[] { client, 0, "c \"" + text + "\"" });
                    else
                        Jtag.Call(SV_GameSendServerCommandGhosts, new object[] { client, 0, "f \"" + text + "\"" });
                    break;
            }
        }

        private void GetClientsGhosts_Click(object sender, EventArgs e)
        {
            if (MW3Fun.Checked == true)
            {
                getClients("Home", "Modern Warfare 3", 18);
            }
            else if (BO2Fun.Checked == true)
            {
                getClients("Home", "Black Ops 2", 18);
            }
            else if (GhostsFun.Checked == true)
            {
                getClients("Home", "Ghosts", 12);
            }
            GhostsClients.SelectedIndex = 0;
        }

        private void GetClientsGamertag_Click(object sender, EventArgs e)
        {
            if (MW3Gamertag.Checked == true)
            {
                getClients("Gamertag", "Modern Warfare 3", 18);
            }
            else if (BO2Gamertag.Checked == true)
            {
                getClients("Gamertag", "Black Ops 2", 18);
            }
            else if (GhostsGamertag.Checked == true)
            {
                getClients("Gamertag", "Ghosts", 12);
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void GetClientsText_Click(object sender, EventArgs e)
        {
            if (MW3Text.Checked == true)
            {
                getClients("Text", "Modern Warfare 3", 18);
            }
            else if (BO2Text.Checked == true)
            {
                getClients("Text", "Black Ops 2", 18);
            }
            else
            {
                getClients("Text", "Ghosts", 12);
            }
        }

        private void SendTextButton_Click(object sender, EventArgs e)
        {
            int client = TextClients.SelectedIndex - 1;
            string type;
            if(center.Checked == true)
            {
                type = "center";
            }
            else
            {
                type = "killfeed";
            }
            if (MW3Text.Checked == true)
            {
                for (int t = (int)numericUpDown1.Value; t >= 0; t--)
                {
                    sendText("Modern Warfare 3", type, TextTextbox.Text, client);
                }
            }
            else if (BO2Text.Checked == true)
            {
                for (int t = (int)numericUpDown1.Value; t >= 0; t--)
                {
                    if (client == -1)
                    {
                        for (int n = 0; n < 18; n++)
                        {
                            sendText("Black Ops 2", type, TextTextbox.Text, n);
                        }
                    }
                    else
                    {
                        sendText("Black Ops 2", type, TextTextbox.Text, client);
                    }
                }
            }
            else
            {
                for (int t = (int)numericUpDown1.Value; t >= 0; t--)
                {
                    if (client == -1)
                    {
                        for (int n = 0; n < 12; n++)
                        {
                            sendText("Ghosts", type, TextTextbox.Text, n);
                        }
                    }
                    else
                    {
                        sendText("Ghosts", type, TextTextbox.Text, client);
                    }
                }
            }
        }

        private void setGamertag(string game, string InorPre, string gamertag, int client)
        {
            string i = null;
            for (int y = GamertagText.TextLength; y > 0; y++)
            {
                i = i + " ";
            }
            switch(game)
            {
                case "Modern Warfare 3":
                    if (client == -1)
                    {
                        string name = GamertagText.Text;
                        for (int n = 0; n < 18; n++)
                        {
                            Jtag.SetMemory(getPlayerStateMW3((uint)n) + 0x3414, Encoding.ASCII.GetBytes(i));
                            Jtag.SetMemory(getPlayerStateMW3((uint)n) + 0x3414, Encoding.ASCII.GetBytes(gamertag));
                        }
                    }
                    else
                    {
                            Jtag.SetMemory(getPlayerStateMW3((uint)client) + 0x3414, Encoding.ASCII.GetBytes(i));
                            Jtag.SetMemory(getPlayerStateMW3((uint)client) + 0x3414, Encoding.ASCII.GetBytes(gamertag));
                    }
                    break;
                case "Black Ops 2":
                    if (client == -1)
                    {
                        for (int n = 0; n < 18; n++)
                        {
                            Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5534, Encoding.ASCII.GetBytes(i));
                            Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5534, Encoding.ASCII.GetBytes(gamertag));
                        }
                    }
                    else
                    {
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5534, Encoding.ASCII.GetBytes(i));
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5534, Encoding.ASCII.GetBytes(gamertag));
                    }
                    break;
                case "Ghosts":
                    if (client == -1)
                    {
                        string name = GamertagText.Text;
                        for (int n = 0; n < 12; n++)
                        {
                            Console.Memory.WriteString(getPlayerStateGhosts((uint)n) + 0x2F9C, i);
                            Console.Memory.WriteString(getPlayerStateGhosts((uint)n) + 0x2F9C, gamertag);
                        }
                    }
                    else
                    {
                        Console.Memory.WriteString(getPlayerStateGhosts((uint)client) + 0x2F9C, i);
                        Console.Memory.WriteString(getPlayerStateGhosts((uint)client) + 0x2F9C, gamertag);
                    }
                break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string l;
            string r;
            if (BO2Gamertag.Checked == true)
            {
                l = "Black Ops 2";
            }
            else if (MW3Gamertag.Checked == true)
            {
                l = "Modern Warfare 3";
            }
            else
            {
                l = "Ghosts";
            }
            if(radioButton2.Checked == true)
            {
                r = "In-Game";
            }
            else
            {
                r = "Pre-Game";
            }
            setGamertag(l, r, GamertagText.Text, GhostsClients.SelectedIndex - 1);
        }

        public string color(string color)
        {
            switch (color)
            {
                case "Red":
                    return "^1";
                case "Green":
                    return "^2";
                case "Yellow":
                    return "^3";
                case "White":
                    return "^4";
                case "Light Grey":
                    return "^5";
                case "Dark Grey":
                    return "^6";
                case "Blue":
                    return "^7";
                case "Cyan":
                    return "^8";
                case "Pink":
                    return "^9";
                case "Black":
                    return "^0";
                case "Dark Blue":
                    return "^;";
                case "Banana Yellow":
                    return "^:";
            }
            return null;
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            GamertagText.Text = GamertagText.Text + color(TextColors.Text);
        }

        private void buttonX14_Click_1(object sender, EventArgs e)
        {
            TextTextbox.Text = TextTextbox.Text + color(TextColors.Text);
        }

        private void KickClientGhosts_Click(object sender, EventArgs e)
        {
            int client = GhostsClients.SelectedIndex - 1;
            if (client == -1)
            {
                for (int n = 0; n < 12; n++)
                {
                    string msg = "This profile has been permanently banned from playing Call of Duty: Ghosts online due to a violation of the posted Security & Enforcement Policy. For more information, visit http://support.activision.com/ghosts";
                    this.Jtag.Call(SV_GameSendServerCommandGhosts, new object[] { n, 0, "r \"" + msg + "\"" });
                }
            }
            else
            {
                string msg = "This profile has been permanently banned from playing Call of Duty: Ghosts online due to a violation of the posted Security & Enforcement Policy. For more information, visit http://support.activision.com/ghosts";
                this.Jtag.Call(SV_GameSendServerCommandGhosts, new object[] { client, 0, "r \"" + msg + "\"" });
            }
        }

        private void godmode(string game, int client, int amount, bool enabled)
        {
            uint ghost = 0;
            if (enabled == true)
            {
                ghost = 1;
            }
            else
            {
                ghost = 0;
            }
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.WriteUInt32(gEntityGhosts((uint)n) + 0x18C, ghost);
                            break;
                        case "BO2":
                            this.Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x1b, new byte[] { 1 });
                            break;
                        case "MW3":
                            Jtag.SetMemory(GentityMW3(n) + 0x19f, new byte[1]);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.WriteUInt32(gEntityGhosts((uint)client) + 0x18C, ghost);
                        break;
                    case "BO2":
                        this.Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x1b, new byte[1]);
                        break;
                    case "MW3":
                        Jtag.SetMemory(GentityMW3(client) + 0x19f, new byte[1]);
                        break;
                }
            }
        }

        private void mFlags(string game, int client, int amount, int var, bool enabled)
        {
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.WriteInt32(getPlayerStateGhosts((uint)n) + 0x3218, var);
                            break;
                        case "BO2":
                            if (enabled == true)
                            {
                                int num = 0;
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x54ea, new byte[1]);
                                do
                                {
                                    Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5413, new byte[] { 1 });
                                    System.Threading.Thread.Sleep(num += 500);
                                }
                                while (num != 0x7d0);
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5413, new byte[] { 2 });
                            }
                            else
                            {
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5413, new byte[1]);
                            }
                            break;
                        case "MW3":
                            Console.Memory.WriteInt32(getClientStateMW3(n) + 0x35ff, var);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.WriteInt32(getPlayerStateGhosts((uint)client) + 0x3218, var);
                        break;
                    case "BO2":
                        if (enabled == true)
                        {
                            int num = 0;
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x54ea, new byte[1]);
                            do
                            {
                                Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5413, new byte[] { 1 });
                                System.Threading.Thread.Sleep(num += 500);
                            }
                            while (num != 0x7d0);
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5413, new byte[] { 2 });
                        }
                        else
                        {
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5413, new byte[1]);
                        }
                        break;
                    case "MW3":
                        Console.Memory.WriteInt32(getClientStateMW3(client) + 0x35ff, var);
                        break;
                }
            }
        }

        private void Visibility(string game, int client, int amount, bool enabled)
        {
            int ghost = 0;
            byte[] BO2;
            if (enabled == true)
            {
                ghost = 0x20;
                BO2 = new byte[] { 0xff };
            }
            else
            {
                ghost = ~0x20;
                BO2 = new byte[1];
            }
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.AND_Int32(getPlayerStateGhosts((uint)n) + 0x124, ghost);
                            break;
                        case "BO2":
                            Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0xff, BO2);
                            break;
                        case "MW3":
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.AND_Int32(getPlayerStateGhosts((uint)client) + 0x124, ghost);
                        break;
                    case "BO2":
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0xff, BO2);
                        break;
                    case "MW3":
                        break;
                }
            }
        }

        private void UAV(string game, int client, int amount, bool enabled)
        {
            byte[] ghost;
            byte[] BO2;
            byte[] MW3 = new byte[] { 0x3B, 0x80, 0x00, 0x01};
            if (enabled == true)
            {
                ghost = new byte[] { 01 };
                BO2 = new byte[] { 0xff };
            }
            else
            {
                ghost = new byte[] { 00 };
                BO2 = new byte[1];
            }
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Jtag.SetMemory(UAVGhosts, ghost);
                            break;
                        case "BO2":
                            Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x5607, BO2);
                            break;
                        case "MW3":
                            Jtag.SetMemory(UAVMW3, MW3);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Jtag.SetMemory(UAVGhosts, ghost);
                        break;
                    case "BO2":
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x5607, BO2);
                        break;
                    case "MW3":
                        Jtag.SetMemory(UAVMW3, MW3);
                        break;
                }
            }
        }

        private void noRecoil(string game, int client, int amount, bool enabled)
        {
            byte[] ghost;
            if (enabled == true)
            {
                ghost = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            }
            else
            {
                ghost = new byte[] { 0x4B, 0xF8, 0xB7, 0x65 };
            }
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Jtag.SetMemory(NoRecoilGhosts, ghost);
                            break;
                        case "BO2":
                            break;
                        case "MW3":
                            Jtag.SetMemory(NoRecoilMW3, ghost);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Jtag.SetMemory(NoRecoilGhosts, ghost);
                        break;
                    case "BO2":
                        break;
                    case "MW3":
                        Jtag.SetMemory(NoRecoilMW3, ghost);
                        break;
                }
            }
        }

        private void laser(string game, int client, int amount, bool enabled)
        {
            uint ghost;
            byte[] MW3;
            if (enabled == true)
            {
                ghost = 0x10000;
                MW3 = new byte[] { 0x2f, 0x10, 0, 1 };
            }
            else
            {
                ghost = 0x00;
                MW3 = new byte[] { 0x2f, 0x10, 0, 0 };
            }

            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.WriteUInt32(getPlayerStateGhosts((uint)n) + 0x124, ghost);
                            break;
                        case "BO2":
                            break;
                        case "MW3":
                            this.Jtag.SetMemory(laserMW3, MW3);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.WriteUInt32(getPlayerStateGhosts((uint)client) + 0x124, ghost);
                        break;
                    case "BO2":
                        break;
                    case "MW3":
                        this.Jtag.SetMemory(laserMW3,  MW3);
                        break;
                }
            }
        }

        private void redbox(string game, int client, int amount, bool enabled)
        {
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.NOP(boxesGhosts);
                            break;
                        case "BO2":
                            break;
                        case "MW3":
                            Console.Memory.NOP(boxesMW3);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.NOP(boxesGhosts);
                        break;
                    case "BO2":
                        break;
                    case "MW3":
                        Console.Memory.NOP(boxesMW3);
                        break;
                }
            }
        }

        private string gameSelectedFun()
        {
            if (MW3Fun.Checked == true)
            {
                return "MW3";
            }
            else if (BO2Fun.Checked == true)
            {
                return "BO2";
            }
            else
            {
                return "Ghosts";
            }
        }

        public int gameAmount()
        {
            if (MW3Fun.Checked == true)
            {
                return 18;
            }
            else if (BO2Fun.Checked == true)
            {
                return 18;
            }
            else
            {
                return 12;
            }
        }

        private void buttonX15_Click(object sender, EventArgs e)
        {
            godmode(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), true);
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            godmode(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void buttonX24_Click(object sender, EventArgs e)
        {
            Visibility(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), true);
        }

        private void buttonX23_Click(object sender, EventArgs e)
        {
            Visibility(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {
            mFlags(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), 1, true);
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            mFlags(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), 2, false);
        }

        private void buttonX22_Click(object sender, EventArgs e)
        {
            mFlags(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), 4, false);
        }

        private void buttonX21_Click(object sender, EventArgs e)
        {
            mFlags(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), 0, false);
        }

        private void buttonX28_Click(object sender, EventArgs e)
        {
            UAV(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), true);
        }

        private void buttonX27_Click(object sender, EventArgs e)
        {
            UAV(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void buttonX32_Click(object sender, EventArgs e)
        {
            redbox(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void buttonX26_Click(object sender, EventArgs e)
        {
            noRecoil(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), true);
        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            noRecoil(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void buttonX30_Click(object sender, EventArgs e)
        {
            laser(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), true);
        }

        private void buttonX29_Click(object sender, EventArgs e)
        {
            laser(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), false);
        }

        private void MW3Fun_CheckedChanged(object sender, EventArgs e)
        {
            KickClientGhosts.Enabled = false;
            buttonX2.Enabled = false;
            buttonX24.Enabled = false;
            buttonX23.Enabled = false;
            buttonX16.Enabled = false;
            buttonX27.Enabled = false;
            buttonX17.Enabled = true;
            buttonX22.Enabled = true;
            buttonX26.Enabled = true;
            buttonX25.Enabled = true;
            buttonX30.Enabled = true;
            buttonX29.Enabled = true;
            buttonX4.Enabled = false;
            buttonX5.Enabled = false;
            buttonX6.Enabled = false;
            buttonX7.Enabled = false;
            buttonX3.Enabled = false;
            buttonX32.Enabled = true;
            buttonX25.Enabled = true;
        }

        private void BO2Fun_CheckedChanged(object sender, EventArgs e)
        {
            KickClientGhosts.Enabled = false;
            buttonX2.Enabled = false;
            buttonX17.Enabled = false;
            buttonX22.Enabled = false;
            buttonX26.Enabled = false;
            buttonX25.Enabled = false;
            buttonX30.Enabled = false;
            buttonX29.Enabled = false;
            buttonX24.Enabled = true;
            buttonX23.Enabled = true;
            buttonX32.Enabled = false;
            buttonX16.Enabled = true;
            buttonX27.Enabled = true;
            buttonX4.Enabled = false;
            buttonX5.Enabled = false;
            buttonX6.Enabled = false;
            buttonX7.Enabled = false;
            buttonX3.Enabled = true;
            buttonX25.Enabled = false;
        }

        private void GhostsFun_CheckedChanged(object sender, EventArgs e)
        {
            buttonX25.Enabled = false;
            KickClientGhosts.Enabled = true;
            buttonX2.Enabled = true;
            buttonX24.Enabled = true;
            buttonX32.Enabled = true;
            buttonX23.Enabled = true;
            buttonX16.Enabled = true;
            buttonX27.Enabled = true;
            buttonX17.Enabled = true;
            buttonX22.Enabled = true;
            buttonX26.Enabled = true;
            buttonX25.Enabled = true;
            buttonX30.Enabled = true;
            buttonX29.Enabled = true;
            buttonX4.Enabled = true;
            buttonX5.Enabled = true;
            buttonX6.Enabled = true;
            buttonX7.Enabled = true;
            buttonX3.Enabled = false;
            buttonX9.Enabled = true;
            buttonX8.Enabled = true;
        }

        private void ammo(string game, int client, int amount, int Mode)
        {
            if (client == -1)
            {
                for (int n = 0; n < amount; n++)
                {
                    switch (game)
                    {

                        case "Ghosts":
                            Console.Memory.NOP(AmmoGhosts);
                            break;
                        case "BO2":
                            if (Mode == 0)
                            {
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x43e, new byte[] { 0xff });
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x43a, new byte[] { 0xff });
                            }
                            else if (Mode == 1)
                            {
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x436, new byte[] { 0xff });
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x42a, new byte[] { 0xff });
                                Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x42e, new byte[] { 0xff });
                            }
                            break;
                        case "MW3":
                            Console.Memory.NOP(0x821614d4);
                            Console.Memory.NOP(0x820f63e0);
                            break;
                    }
                }
            }
            else
            {
                switch (game)
                {
                    case "Ghosts":
                        Console.Memory.NOP(AmmoGhosts);
                        break;
                    case "BO2":
                        if (Mode == 0)
                        {
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x43e, new byte[] { 0xff });
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x43a, new byte[] { 0xff });
                        }
                        else if (Mode == 1)
                        {
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x436, new byte[] { 0xff });
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x42a, new byte[] { 0xff });
                            Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x42e, new byte[] { 0xff });
                        }
                        break;
                    case "MW3":
                        Console.Memory.NOP(0x821614d4);
                        Console.Memory.NOP(0x820f63e0);
                        break;
                }
            }
        }

        private void buttonX31_Click(object sender, EventArgs e)
        {
            ammo(gameSelectedFun(), GhostsClients.SelectedIndex - 1, gameAmount(), 0);
        }

        private void Texttab_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(501, 426);
        }

        private void FunMods_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(501, 426);
        }

        private void Gamertag_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(501, 426);
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(501, 426);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (login == true)
            {
                this.Size = new System.Drawing.Size(501, 426);
            }
            else
            {
                this.Size = new System.Drawing.Size(501, 215);
            }
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            int r = 0;
            string stoof = new System.Net.WebClient().DownloadString("http://pastebin.com/HrnEpyqN");
            string nu = "";
            for (int t = 0; t < 20; t++)
            {
                nu = nu + " ";
                if ((user.Text != nu) && (pass.Text != nu))
                {
                    r++;
                }
            }
            if (r >= 20)
            {
                if (stoof.Contains(user.Text + ":" + pass.Text))
                {
                    login = true;
                    this.Size = new System.Drawing.Size(501, 426);
                    MessageBox.Show("Login Successful");
                    buttonX13.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            string contents = new System.Net.WebClient().DownloadString("http://pastebin.com/XgzwbbP5");
            string currentversion = Application.ProductVersion;
            if (contents.Contains(currentversion))
            {
                MessageBox.Show("You are up to date!");
            }
            else
            {
                MessageBoxEx.Show("A new update is available, press okay to start the download.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Diagnostics.Process.Start("LINK");
                Dispose();
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool was created by: Unsigned Chaos\r\nThis tool was created for: SnowRGH");
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.DieselGaming.com");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[4];
            array[0] = 96;
            Jtag.SetMemory(autogunsGhosts, array);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            int client = GhostsClients.SelectedIndex - 1;
            if (client == -1)
            {
                for (int n = 0; n < 18; n++)
                {
                    Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x42e, new byte[] { 1 });
                    Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x432, new byte[] { 1 });
                    Jtag.SetMemory(getPlayerStateBO2((uint)n) + 0x437, new byte[] { 1 });
                }
            }
            else
            {
                Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x42e, new byte[] { 1 });
                Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x432, new byte[] { 1 });
                Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x437, new byte[] { 1 });
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (BO2Fun.Checked == true)
            {
                Jtag.Call(Cbuf_AddTextBO2, new object[] { 0, "party_connectToOthers 0;partyMigrate_disabled 1" });
            }
            else if(GhostsFun.Checked == true)
            {
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set party_minplayers \"1\"" });
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set hostmigration \"0\"" });
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set host \"1\"" });
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set migration_timeBetween \"30000\"" });
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set migration_msgtimeout \"500\"" });
                this.Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set badhost_maxHappyPingTime \"400\"" });
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            string[] game = { "dom", "war", "dm", "sd", "conf", "sr", "grind", "blitz", "cranked", "infect", "sotf", "dem", "horde", "soft_ffa" };
            for (int n = 0; n < 14; n++)
            {
                Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set scr_" + game[n] + "_score_kill 100000" });
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            string[] game = { "dom", "war", "dm", "sd", "conf", "sr", "grind", "blitz", "cranked", "infect", "sotf", "dem", "horde", "soft_ffa" };
            for (int n = 0; n < 14; n++)
            {
                Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set scr_" + game[n] + "_scorelimit 100000" });
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            string[] game = { "dom", "war", "dm", "sd", "conf", "sr", "grind", "blitz", "cranked", "infect", "sotf", "dem", "horde", "soft_ffa" };
            for (int n = 0; n < 14; n++)
            {
                Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set scr_" + game[n] + "_scorelimit 100000" });
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            int client = GhostsClients.SelectedIndex - 1;
            if (GhostsFun.Checked == true)
            {
                Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set camera_thirdPerson \"1\""});
            }
            else if (BO2Fun.Checked == true)
            {
                if (client == -1)
                {
                    for (uint i = 0; i < 0x12; i++)
                    {
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x84, new byte[] { 0xff });
                    }
                }
                else
                {
                    Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x84, new byte[] { 0xff });
                }
            }
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            int client = GhostsClients.SelectedIndex - 1;
            if (GhostsFun.Checked == true)
            {
                Jtag.Call(Cbuf_AddTextGhosts, new object[] { 0, "set camera_thirdPerson \"0\""});
            }
            else if (BO2Fun.Checked == true)
            {
                if (client == -1)
                {
                    for (uint i = 0; i < 0x12; i++)
                    {
                        Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x84, new byte[1]);
                    }
                }
                else
                {
                    Jtag.SetMemory(getPlayerStateBO2((uint)client) + 0x84, new byte[1]);
                }
            }
        }
    }
}
