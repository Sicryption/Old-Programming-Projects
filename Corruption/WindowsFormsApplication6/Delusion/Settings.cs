using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CorruptionRevamped;
using Delusion;
using WindowsFormsApplication6;

namespace CorruptionRevamped
{
    public partial class Settings : DevComponents.DotNetBar.Office2007Form
    {
        Form2 Login = new Form2();
        CorRev r = new CorRev();
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\AutoLogin.txt"))
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("You must check auto-login when signing in.");
                //File.WriteAllText(Directory.GetCurrentDirectory() + "\\AutoLogin.txt", (string)(Login.userName + "|" + Login.passWord));
            }
            else
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\AutoLogin.txt"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + "\\AutoLogin.txt");
                }
            }
        }
    }
}
