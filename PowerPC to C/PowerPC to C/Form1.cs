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

namespace PowerPC_to_C
{
    public partial class Form1 : Form
    {
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertToC(richTextBox1.Text);
        }

        private void convertToC(string code)
        {
            if (File.Exists(System.IO.Directory.GetCurrentDirectory() + "//debugg.txt"))
                File.Delete(System.IO.Directory.GetCurrentDirectory() + "//debugg.txt");
            StreamWriter r = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "//debugg.txt");
            r.Write(code);
            r.Flush();
            r.Close();
            sr = new StreamReader(System.IO.Directory.GetCurrentDirectory() + "//debugg.txt");
            try
            {
                string newCode = "";
                    string curDebug = sr.ReadLine();
                    if (curDebug.Contains("addi"))
                    {
                        string[] newDevice = curDebug.Split(' ');
                        for (int i = 0; i < newDevice.Length; i++)
                        {
                            if(newDevice[i].Contains(','))
                            {
                                newDevice[i].Replace(",", "");
                            }
                        }
                        newCode += newDevice[1] + " = " + newDevice[2] + " + " + newDevice[3] + ";";
                    }
                    code.Replace(curDebug, null);
                richTextBox2.Text = newCode;
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
