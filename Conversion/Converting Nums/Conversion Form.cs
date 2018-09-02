using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string decToDec(int dec)
        {
            return dec.ToString();
        }

        string hexToHex(uint hex)
        {
            return Convert.ToString(hex, 16);
        }

        string hexToBin(uint hex)
        {
            return decToBin((int)hex);
        }

        string decToHex(int dec)
        {
            return Convert.ToString(dec, 16);
        }

        string hexToDec(uint hex)
        {
            return hex.ToString();
        }

        string decToBin(int dec)
        {
            string nu = "";
            int isNum = dec;
            bool first = true;
            for (int i = 32; i >= 0; i--)
            {
                if (isNum - Math.Pow(2, i) >= 0)
                {
                    isNum = isNum - (int)Math.Pow(2, i);
                    nu = nu + "1";
                    if (first)
                        first = false;
                }
                else
                    if (!first)
                        nu = nu + "0";
            }
            return nu;
        }

        string binToDec(string bin)
        {
            int sumOfNums = 0;
            int i = 1;
            while (i <= bin.Length)
            {
                char r = bin[bin.Length - i];
                int value = r - '0';
                if (value == 1)
                    sumOfNums += (int)Math.Pow(2, i);
                i++;
            }
            return sumOfNums.ToString();
        }

        string binToBin(string bin)
        {
            return bin;
        }

        string binToHex(string bin)
        {
            return Convert.ToString(Convert.ToInt32(binToDec(bin), 10), 16);
        }

        private void convert()
        {
            try
            {
                if (dec1.Checked && dec2.Checked)
                    textBox2.Text = decToDec(Convert.ToInt32(textBox1.Text, 10));
                else if (dec1.Checked && hex2.Checked)
                    textBox2.Text = decToHex(Convert.ToInt32(textBox1.Text, 10));
                else if (dec1.Checked && bin2.Checked)
                    textBox2.Text = decToBin(Convert.ToInt32(textBox1.Text, 10));
                else if (hex1.Checked && dec2.Checked)
                    textBox2.Text = hexToDec(Convert.ToUInt32(textBox1.Text, 16));
                else if (hex1.Checked && hex2.Checked)
                    textBox2.Text = hexToHex(Convert.ToUInt32(textBox1.Text, 16));
                else if (hex1.Checked && bin2.Checked)
                    textBox2.Text = hexToBin(Convert.ToUInt32(textBox1.Text, 16));
                else if (bin1.Checked && dec2.Checked)
                    textBox2.Text = binToDec(textBox1.Text);
                else if (bin1.Checked && hex2.Checked)
                    textBox2.Text = binToHex(textBox1.Text);
                else if (bin1.Checked && bin2.Checked)
                    textBox2.Text = binToBin(textBox1.Text);
                textBox3.Text = "None";
            }
            catch
            {
                textBox3.Text = "Invalid Input";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void hex2_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void hex1_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void bin1_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void dec2_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void dec1_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }

        private void bin2_CheckedChanged(object sender, EventArgs e)
        {
            convert();
        }
    }
}
