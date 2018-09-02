using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4_Deal_Checker
{
    public partial class Form1 : Form
    {
        System.Threading.Thread thread;
        public bool doCheck = true;
        public int checkCount = 0;
        public int docCount = 0;

        public List<string> urls = new List<string>()
            {
                "https://www.walmart.com/ip/Playstation-4-PS4-1TB-Slim-Gaming-System/782841840",
                //"https://www.toysrus.com/product?productId=130463446",
                "https://www.gamestop.com/ps4/consoles/playstation-4-1tb-system/147719",
                "https://www.newegg.com/Product/Product.aspx?Item=9SIAEBU6MV2172",
                "https://www.newegg.com/Product/Product.aspx?Item=9SIAEYJ6MV1659",
                "https://www.newegg.com/Product/Product.aspx?_ga=2.246063108.1889572204.1511683690-487073752.1508451901&Item=N82E16868110237",
                //"https://www.bestbuy.com/site/sony-playstation4-1tb-console-black/5850905.p?skuId=5850905",
            };

        public List<string> failMsgs = new List<string>()
            {
                "Out of stock",
                //"email me when available",
                "Currently unavailable online",
                "299.00",
                "299.99",
                "349.00",
                //"In Store Only",
            };

        public Form1()
        {
            InitializeComponent();
            thread = new System.Threading.Thread(DoCheck);
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Checking...\nAttempt: " + 0;
        }

        public void DoCheck()
        {
            Console.WriteLine("Start");
            while (doCheck)
            {
                WebClient wc = new WebClient();
                for(int i = 0; i < urls.Count(); i++)
                {
                    try
                    {
                        Console.WriteLine("Checking: " + urls[i]);
                        string data = wc.DownloadString(urls[i]);

                        if (!data.Contains(failMsgs[i]))
                        {
                            Console.WriteLine("PS4 AVAILABLE");
                            Clipboard.SetText(urls[i]);
                            Process.Start(urls[i]);
                            MessageBox.Show("PS4 AVAILABLE");
                            doCheck = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Failed");
                    }
                }
                checkCount += 1;

                MethodInvoker mi = new MethodInvoker(() => label1.Text = "Checking...\nAttempt: " + checkCount);

                if (label1.InvokeRequired)
                    label1.Invoke(mi);
                else
                    mi.Invoke();

                Console.WriteLine("Check count: " + checkCount);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
