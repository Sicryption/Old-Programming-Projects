using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;

namespace Ghost_RTE
{
    public partial class Main_Form : Form
    {
        JRPC xbox = new JRPC();
        Thread prestigeCycleThread;
        Random random = new Random();
        bool randomizePrestigeCycle, prestigeCycleThreadEnabled;
        int currentCycle = 0;
        string[] list = new string[] { "Red Boxes", "Laser", "Chams", "Radar1", "Radar2", "Radar3", "No Recoil", "Entry Stats" };
        uint[] offsetList = new uint[] { 0x8226CEAC, 0x8227ED90, 0x8229008C, 0x82264F90, 0x82265388, 0x822653F4, 0x822C8F3C, 0x8358384C };
        uint[] originals;
        bool[] hasValue;
        uint[] ppcBytes = new uint[] { 0x60000000, 0x38600001, 0x38C0FFFF, 0x2F030001, 0x2F030001, 0x2F030001, 0x60000000, 0x00 };
        int[] levels = new int[] { 0, 1000, 2500, 5000, 10000, 20000, 30000, 40000, 50000, 60000, 70000, 80000, 90000, 100000, 120000, 140000, 150000, 180000, 200000, 220000, 240000, 260000, 280000, 300000, 320000, 340000, 360000, 380000, 400000, 420000, 440000, 460000, 480000, 500000, 520000, 540000, 560000, 580000, 600000, 620000, 640000, 660000, 680000, 700000, 720000, 740000, 760000, 780000, 800000, 820000, 840000, 870000, 900000, 930000, 960000, 990000, 1030000, 1070000, 1120000, 1170000, 1230000 };

        public Main_Form()
        {
            originals = new uint[list.Length];
            hasValue = new bool[list.Length];
            prestigeCycleThread = new Thread(prestigeCycleThreadVoid);
            prestigeCycleThread.Start();
            InitializeComponent();
        }

        void sendBooleanModification(CheckBox current, string mod)
        {
            int orig = useOriginal(mod);
            if (!hasValue[orig])
            {
                originals[orig] = xbox.ReadUInt32(offsetList[orig]);
                hasValue[orig] = true;
            }
            if (current.Checked)
                xbox.WriteUInt32(offsetList[orig], ppcBytes[orig]);
            else
                xbox.WriteUInt32(offsetList[orig], originals[orig]);
        }

        int useOriginal(string mod)
        {
            for (int i = 0; i < list.Length; i++)
                if (list[i] == mod)
                    return i;
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xbox.Connect();
            checkBox1.Checked = xbox.activeConnection ? true : false;
        }

        private void redBoxes_CheckedChanged(object sender, EventArgs e)
        {
            sendBooleanModification(redBoxes, "Red Boxes");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sendBooleanModification(laser, "Laser");
        }

        private void chams_CheckedChanged(object sender, EventArgs e)
        {
            byte r = 0x01;
            if (chamsShowBody.Checked)
                r += (byte)Convert.ToByte((chamsComboBox.SelectedIndex * 2) + 2);
            else
                r += (byte)Convert.ToByte((chamsComboBox.SelectedIndex * 2) + 1);
            byte[] data = new byte[] { 0x38, 0xC0, 0x00, r };
            if (chams.Checked)
                xbox.SetMemory(0x8229008C, data);
            else
                xbox.SetMemory(0x8229008C, new byte[] { 0x7F, 0x46, 0xD3, 0x78 });
        }

        private void level_Click(object sender, EventArgs e)
        {
            int orig = useOriginal("Entry Stats");
            byte[] data = BitConverter.GetBytes((uint)levels[(int)levelValue.Value -1]);
            xbox.SetMemory(offsetList[orig] + 0xFE6, data);
        }

        private void prestige_Click(object sender, EventArgs e)
        {
            int orig = useOriginal("Entry Stats");
            byte[] data = BitConverter.GetBytes((uint)prestigeValue.Value);
            xbox.SetMemory(offsetList[orig] + 0x4F28, data);
        }

        private void radar_CheckedChanged(object sender, EventArgs e)
        {
            int orig = useOriginal("Radar1");
            if (!hasValue[orig])
            {
                originals[orig] = xbox.ReadUInt32(offsetList[orig]);
                originals[orig + 1] = xbox.ReadUInt32(offsetList[orig + 1]);
                originals[orig + 2] = xbox.ReadUInt32(offsetList[orig + 2]);
                hasValue[orig] = true;
            }
            if (radar.Checked)
            {
                xbox.WriteUInt32(offsetList[orig], ppcBytes[orig]);
                xbox.WriteUInt32(offsetList[orig + 1], ppcBytes[orig]);
                xbox.WriteUInt32(offsetList[orig + 2], ppcBytes[orig]);
            }
            else
            {
                xbox.WriteUInt32(offsetList[orig], originals[orig]);
                xbox.WriteUInt32(offsetList[orig + 1], originals[orig]);
                xbox.WriteUInt32(offsetList[orig + 2], originals[orig]);
            }
        }

        private void randomizeCycle_CheckedChanged(object sender, EventArgs e)
        {
            randomizePrestigeCycle = randomizeCycle.Checked;
        }

        private void prestigeCycle_CheckedChanged(object sender, EventArgs e)
        {
            prestigeCycleThreadEnabled = prestigeCycle.Checked;
        }

        private void prestigeCycleThreadVoid()
        {
            for (; ; )
            {
                if (prestigeCycleThreadEnabled)
                {
                    int orig = useOriginal("Entry Stats");
                    int prestige;
                    if (randomizePrestigeCycle)
                    {
                        prestige = random.Next(0, 11);
                    }
                    else
                    {
                        if (currentCycle < 12)
                            currentCycle++;
                        else
                            currentCycle = 0;
                        prestige = currentCycle;
                    }
                    byte[] data = BitConverter.GetBytes((uint)prestige);
                    xbox.SetMemory(offsetList[orig] + 0x4F28, data);
                    System.Threading.Thread.Sleep(750);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentCycle = 0;
        }

        private void noRecoil_CheckedChanged(object sender, EventArgs e)
        {
            sendBooleanModification(noRecoil, "No Recoil");
        }

        private void chamsShowBody_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
