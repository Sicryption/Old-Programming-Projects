using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string findBin(int num)
        {
            string nu = "";
            int isNum = num;
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
                    if(!first)
                        nu = nu + "0";
            }
            return nu;
        }

        private void setError(string errorMessage, bool Error = true)
        {
            if (Error)
                error.Text = "Error: " + errorMessage;
            else
                error.Text = errorMessage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decInBin.Text != "")
                {
                    if (toBinFromDec.Checked)
                    {
                        binInBin.Text = findBin(Convert.ToInt32(decInBin.Text));
                        setError("Binary Calculated", false);
                    }
                }
                else
                {
                    binInBin.Text = "";
                }
            }
            catch
            {
                setError("Not a valid integer");
            }
        }
    }
}
