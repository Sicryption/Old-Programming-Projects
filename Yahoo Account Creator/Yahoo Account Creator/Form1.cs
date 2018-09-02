using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo_Account_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser webbrowser = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            webbrowser.Navigate("https://edit.yahoo.com/registration?.intl=us&.lang=en-US&.pd=fpctx_ver%253D0%2526c%253D%2526ivt%253D%2526sg%253D&new=1&.done=https%3A//www.yahoo.com/&.src=fpctx&.v=0&.u=e122vj19m29gi&partner=&.partner=&pkg=&stepid=&.p=&promo=&.last=&fsredirect=1&fs=yVFZwquHafC5C3zuRAPp8zxsODUi0Aed4_mUHLdTDu75klnzB1UkPY_wZi5ox4neQQGYn6p1");
            WebBrowserProgressChanged();
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + email.Text + " " + password.Text;
        }

        private void WebBrowserProgressChanged()
        {
            foreach (HtmlElement element in this.webbrowser.Document.GetElementsByTagName("a"))
            {
                if (element.GetAttribute("id").Equals("iliveswitch"))
                {
                    element.InvokeMember("click");
                }
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iFirstName", IEHaxer.randomString(10, true, false));
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iLastName", IEHaxer.randomString(10, true, false));
                IEHaxer.fill(this.webbrowser, "select", "name", "value", "iBirthMonth", new Random().Next(1, 12).ToString());
                IEHaxer.fill(this.webbrowser, "select", "name", "value", "iBirthDay", new Random().Next(1, 0x1b).ToString());
                IEHaxer.fill(this.webbrowser, "select", "name", "value", "iBirthYear", new Random().Next(0x7b2, 0x7c6).ToString());
                IEHaxer.fill(this.webbrowser, "select", "name", "value", "iGender", "m");
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "imembernamelive", this.email.Text);
                IEHaxer.fill(this.webbrowser, "select", "name", "value", "idomain", "hotmail.com");
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iPwd", this.password.Text);
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iRetypePwd", this.password.Text);
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iPhone", IEHaxer.randomPhoneNumber().ToString());
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iAltEmail", string.Format("bsmail{0}@yahoo.com", IEHaxer.randomString(10, true, false)));
                IEHaxer.fill(this.webbrowser, "input", "name", "value", "iZipCode", IEHaxer.randomZip().ToString());
            }
        }

    }
}
