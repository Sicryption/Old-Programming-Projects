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

namespace Advanced_MW3_GT_Changer
{
    public partial class Form1 : Form
    {
        ASCIIEncoding r = new ASCIIEncoding();
        Encoding encoding;
        XRPC Jtag = new XRPC();
        public Form1()
        {
            InitializeComponent();
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
            
        void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void mw3button3_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                if (mw3checkBox1.Checked)
                {
                    string name = textBox1.Text;
                    while (name.Length <= 0x20)
                        name = name + " ";
                    Jtag.SetMemory(0x839691AC, r.GetBytes(name));
                }
                if (mw3checkBox2.Checked)
                {
                    Jtag.SetMemory(0x839691D8, r.GetBytes(textBox2.Text));
                    Jtag.SetMemory(0x839691D0, hexString(textBox2.Text));
                }
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }

        private void mw3button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                ComboBox use;
                if (mw3radioButton3.Checked)
                    use = mw3comboBox4;
                else
                    use = mw3comboBox3;
                byte length = (byte)use.Text.Length;
                byte[] data = new byte[] { 0x5E, 0x01, 0x3D, 0x3D, length };
                byte[] data2 = r.GetBytes(use.Text);
                byte[] combined = new byte[0x20];
                Array.Copy(data, combined, data.Length);
                Array.Copy(data2, 0, combined, data.Length, data2.Length);
                Jtag.SetMemory(0x839691AC, combined);
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }

        private void mw3groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                if (checkBox1.Checked)
                {
                    string name = textBox4.Text;
                    while (name.Length <= 0x20)
                        name = name + " ";
                    Jtag.SetMemory(0x838BA824, r.GetBytes(name));
                }
                if (checkBox2.Checked)
                {
                    Jtag.SetMemory(0x838BA850, r.GetBytes(textBox3.Text));
                    Jtag.SetMemory(0x838BA848, hexString(textBox3.Text));
                }
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                ComboBox use;
                if (radioButton1.Checked)
                    use = comboBox2;
                else
                    use = comboBox1;
                byte length = (byte)use.Text.Length;
                byte[] data = new byte[] { 0x5E, 0x01, 0x3D, 0x3D, length };
                byte[] data2 = r.GetBytes(use.Text);
                byte[] combined = new byte[0x20];
                Array.Copy(data, combined, data.Length);
                Array.Copy(data2, 0, combined, data.Length, data2.Length);
                Jtag.SetMemory(0x838BA824, combined);
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        uint mw3classOffset(int classNum)
        {
            return (uint)(0x830AD128 + (0x62 * classNum));
        }

        uint mw3classOffset2(int classNum)
        {
            return (uint)(0x830A711C + (0x62 * classNum));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                int use = 0;
                if (radioButton3.Checked)
                    use = 1;
                else if (radioButton4.Checked)
                    use = 2;
                else
                    use = 3;
                bool[] useable = new bool[10];
                if (mw3ClassName1.Checked)
                    useable[0] = true;
                if (mw3ClassName2.Checked)
                    useable[1] = true;
                if (mw3ClassName3.Checked)
                    useable[2] = true;
                if (mw3ClassName4.Checked)
                    useable[3] = true;
                if (mw3ClassName5.Checked)
                    useable[4] = true;
                if (mw3ClassName6.Checked)
                    useable[5] = true;
                if (mw3ClassName7.Checked)
                    useable[6] = true;
                if (mw3ClassName8.Checked)
                    useable[7] = true;
                if (mw3ClassName9.Checked)
                    useable[8] = true;
                if (mw3ClassName10.Checked)
                    useable[9] = true;
                byte length;
                byte[] data;
                byte[] data2;
                byte[] combined = new byte[] { 0 }; ;
                for (int i = 0; i < 10; i++)
                {
                    if (useable[i])
                    {
                        switch (use)
                        {
                            case 1:
                                length = (byte)comboBox4.Text.Length;
                                data = new byte[] { 0x5E, 0x01, 0x3D, 0x3D, length };
                                data2 = r.GetBytes(comboBox4.Text);
                                combined = new byte[0x20];
                                Array.Copy(data, combined, data.Length);
                                Array.Copy(data2, 0, combined, data.Length, data2.Length);
                                break;
                            case 2:
                                length = (byte)comboBox3.Text.Length;
                                data = new byte[] { 0x5E, 0x01, 0x3D, 0x3D, length };
                                data2 = r.GetBytes(comboBox3.Text);
                                combined = new byte[0x20];
                                Array.Copy(data, combined, data.Length);
                                Array.Copy(data2, 0, combined, data.Length, data2.Length);
                                break;
                            case 3:
                                data = r.GetBytes(textBox5.Text);
                                combined = new byte[0x20];
                                Array.Copy(data, combined, data.Length);
                                break;
                            default:
                                MessageBox.Show("An Error has occured");
                                break;
                        }
                        Jtag.SetMemory(mw3classOffset(i), combined);
                        Jtag.SetMemory(mw3classOffset2(i), combined);
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jtag.Connect();
            if (Jtag.activeConnection)
            {
                if (!radioButton8.Checked)
                {
                    string use = "";
                    if (radioButton9.Checked)
                        use = comboBox8.Text;
                    else
                        use = comboBox7.Text;
                    byte length = (byte)use.Length;
                    byte[] data = new byte[] { 0x5E, 0x01, 0x3D, 0x3D, length };
                    byte[] data2 = r.GetBytes(use);
                    byte[] combined = new byte[0x100];
                    Array.Copy(data, combined, data.Length);
                    Array.Copy(data2, 0, combined, data.Length, data2.Length);
                    Jtag.SetMemory(0x82718EE4, combined);
                }
                else
                {
                    Jtag.SetMemory(0x82718EE4, r.GetBytes(textBox7.Text));
                }
            }
            else
            {
                MessageBox.Show("Failed to Connect");
            }
        }
    }
}
