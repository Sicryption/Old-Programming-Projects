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

namespace Halo_Reach_RTE
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
            r = new System.Threading.Thread(tbag);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection)
                {
                    label1.Text = "Connection: Successful";
                }
                else
                {
                    label1.Text = "Connection: Failed";
                }
            }
            catch
            {
                label1.Text = "Connection: Failed";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!crea)
            {
                r.Start();
                crea = true;
            }
            en = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            en = false;
        }
        bool en;
        bool crea;
        System.Threading.Thread r;
        private void tbag()
        {
            for (; ; )
            {
                if (en)
                {
                    int test = Jtag.ReadInt32(0x832F1200 + 0xC);
                    test <<= 16;
                    Jtag.WriteInt32(0x832F1200 + 0xC, (test | 0x06));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setActionSlot(0, 0, (uint)num);
            setActionSlot(0, 1, (uint)num);
            setActionSlot(0, 2, (uint)num);
            setActionSlot(0, 3, (uint)num);
            num++;
        }

        void setActionSlot(int clientIndex, int slot, uint thing)
        {
            Jtag.WriteUInt32((uint)(0x832F1200 + 0xA60 + (slot * 4)), ~thing);
        }
        int num;
        private void button2_Click(object sender, EventArgs e)
        {
        }

        int closestClient(int clientIndex)
        {
            Mod client(clientIndex);
            int cl;
            float flt = (float)3.4 * (10^38);//149.6
            for(int i = 0; i < (strstr(Dvar_GetString("g_gametype"),"ffa") ? 0x7 : 0xC)/*Declare Dvar_GetString yourself*/; i++)
            {
                Mod lol(i);
                if(!lol.Alive() || i == hostIndex || data().ReadInt32(lol.playerState() + 0x28F0) == data().ReadInt32(client.playerState() + 0x28F0) || i == clientIndex) continue;
                Mod clients(i);
                if(sqrt((client.bit.origin[0] - clients.bit.origin[0]) * (client.bit.origin[0] - clients.bit.origin[0])) < flt)
                cl = i;
            }
            return cl;
        }

                void aimAtCC(int clientIndex)
        {
            Mod client(clientIndex);
            Mod inf(closestClient(clientIndex));
            data().Origin2Angles(inf.bit.origin, client.bit.angle);
            client.setAngles(client.bit.angle);
        }
    }
}


