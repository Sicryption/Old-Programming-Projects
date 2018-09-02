using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;
using JRPC_Client;

namespace Troubleshooter
{
    public partial class Form1 : Form
    {
        XRPC Jtag = new XRPC();
        JRPC Console = new JRPC();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log.Items.Clear();
            checkNeighborhood();
            Log.Items.Add("Console: Unable to Recognize");
            XRPCCheck();
            JRPCCheck();
            completeProcess();
        }

        private void completeProcess()
        {
            string status = null;
            Log.Items.Add("Troubleshooting Complete");
            if (Log.Items.Contains("XRPC Connection: Failed") || Log.Items.Contains("JRPC Connection: Failed") || Log.Items.Contains("Neighborhood: Not Found"))
            {
                status = "Failed";
            }
            else
            {
                status = "Success";
            }
            if (status == "Failed")
            {
                MessageBox.Show("One or more checks failed. \r\nClick on the item(s) that had failed to review how to fix it");
            }
            else if(status == "Success")
            {
                MessageBox.Show("Every Check Passed");
            }
        }

        private void XRPCCheck()
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection == true)
                {
                    Log.Items.Add("XRPC Connection: Passed");
                }
                else if (Jtag.activeConnection == false)
                {
                    Log.Items.Add("XRPC Connection: Failed");
                }
            }
            catch (Exception)
            {
                Log.Items.Add("XRPC Connection: Failed");
            }
        }

        private void JRPCCheck()
        {
            try
            {
                Console.Connect();
                if (Console.activeConnection == true)
                {
                    Log.Items.Add("JRPC Connection: Passed");
                }
                else if (Console.activeConnection == false)
                {
                    Log.Items.Add("JRPC Connection: Failed");
                }
            }
            catch (Exception)
            {
                Log.Items.Add("JRPC Connection: Failed");
            }
        }

        private void checkNeighborhood()
        {
            try
            {
                if (Directory.Exists("C:\\Program Files (x86)\\Microsoft Xbox 360 SDK\\bin\\win32") || Directory.Exists("C:\\Program Files\\Microsoft Xbox 360 SDK\\bin\\win32\\"))
                {
                    Log.Items.Add("Neighborhood: Found");
                }
                else
                {
                    Log.Items.Add("Neighborhood: Not Found");
                }
            }
            catch (Exception)
            {
                Log.Items.Add("Neighborhood: Not Found");
            }
        }

        private void Log_Selected(object sender, EventArgs e)
        {
            if (Log.SelectedItem.ToString() == "Neighborhood: Not Found")
            {
                Description.Text = "You need to install Xbox 360 Neighborhood in order for this check to pass. Download it from here: \r\n(Note: This could be a false alarm and maybe the scan failed to locate your Neighborhood folder). \r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "Neighborhood: Found")
            {
                Description.Text = "This check passed because you have Xbox 360 Neighborhood Installed.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "XRPC Connection: Failed")
            {
                Description.Text = "This check failed because you don't have RPC.xex set as a plugin on your console. Download it from here: https://www.dropbox.com/s/4rssodye4ej53ka/RPC.xex. Make sure to set it as a plugin by changing the launch.ini.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "JRPC Connection: Failed")
            {
                Description.Text = "This check failed because you don't have JRPC.xex set as a plugin on your console. Download it from here: https://www.dropbox.com/s/qrrqljscrpeytpx/JRPC.xex. \r\nMake sure to set it as a plugin by changing the launch.ini.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "XRPC Connection: Passed")
            {
                Description.Text = "This check passed because you have RPC.xex set as a plugin in your launch.ini.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "JRPC Connection: Passed")
            {
                Description.Text = "This check passed because you have JRPC.xex set as a plugin in your launch.ini.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "Console: Unable to Recognize")
            {
                Description.Text = "This check could not be completed. To verify it by yourself open Xbox 360 Neighborhood and try to open your console from there. If your console does not show up you must click Add Xbox 360.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
            else if (Log.SelectedItem.ToString() == "Troubleshooting Complete")
            {
                Description.Text = "You see this because the Troubleshooter scanned everything.\r\n \r\nFor more help contact me on Skype: Unsigned Chaos";
            }
        }
    }
}
