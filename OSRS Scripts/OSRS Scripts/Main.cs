using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSRS_Scripts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaggase";
            int[] nums = new int[40];

            int i, x = 0, b = 39, c = 0;
            
            x = 40 - str.Length;

            if (str.Length > 40)
                x = 0;

            for (i = b; i > b - x; i--)
                nums[i] = 0;
            for (i = b - x; i >= 0; i--)
            {
                nums[i] = str[c];
                c++;
            }

            kw26PrintBy2X(nums);

        }
        void kw26PrintBy2X(int[] p)
        {
            int i;

            string s = "";
            for (i = 40 - 1; i >= 0; i--)
                s += p[i].ToString("X2");

            MessageBox.Show(s);
        }
    }
}
