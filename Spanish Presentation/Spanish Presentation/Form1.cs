using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanish_Presentation
{
    public partial class Form1 : Form
    {
        int curimage = 0;
        int tempnum = 0;
        string[] imgLoc = new string[] {"http://www.printrbottalk.com/forum/download/file.php?id=3287.png",
        "http://jenntgrace.com/wp-content/uploads/2012/12/2.png",
        "http://dwellingintheword.files.wordpress.com/2011/08/3.png",
        "http://www.roulette-online.org/wp-content/uploads/2011/03/4.png",
        "http://www.kristensimmonsbooks.com/wp-content/uploads/2011/11/51.png",
        "http://www.roulette-online.org/wp-content/uploads/2011/03/6-2.png",
        "http://2.bp.blogspot.com/-kupuQ0FEERQ/URyZmylL1kI/AAAAAAAAAP8/j1fEmEdb-ys/s1600/10.png"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (curimage < imgLoc.Length - 1)
                curimage++;
            else
                curimage = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curimage != 0)
                curimage--;
            else
                curimage = imgLoc.Length - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoNext.Enabled = false;
            autoNext.Interval = (int)(Convert.ToDecimal(textBox1.Text) * (decimal)1000);
            pictureBox1.ImageLocation = imgLoc[curimage];
        }

        private void Switch_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Delante")
            {
                if (curimage < imgLoc.Length - 1)
                    curimage++;
                else
                    curimage = 0;
            }
            else
            {
                if (curimage != 0)
                    curimage--;
                else
                    curimage = imgLoc.Length - 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                autoNext.Interval = (int)(Convert.ToDecimal(textBox1.Text) * (decimal)1000);
            }
            catch
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            autoNext.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            autoNext.Enabled = false;
        }

        private void changeImage_Tick(object sender, EventArgs e)
        {
            if (tempnum != curimage)
            {
                pictureBox1.ImageLocation = imgLoc[curimage];
                tempnum = curimage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
