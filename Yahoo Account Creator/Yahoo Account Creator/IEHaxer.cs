namespace Yahoo_Account_Creator
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    internal class IEHaxer
    {
        internal static Dictionary<string, string> fillData;
        internal static Random rand = new Random();

        internal static void click(WebBrowser ieb, string tagName, string type)
        {
            foreach (HtmlElement element in ieb.Document.GetElementsByTagName(tagName))
            {
                if (element.GetAttribute("type").Equals(type))
                {
                    element.InvokeMember("click");
                }
            }
        }

        internal static bool contains(WebBrowser ie, string toFind)
        {
            return ie.DocumentText.Contains(toFind);
        }

        internal static void error(WebBrowser ie, Button button, ToolStripStatusLabel label, string msg)
        {
            button.Text = "Reload from profile.json and retry";
            button.Enabled = true;
            label.ForeColor = Color.Red;
            label.Text = msg;
            ie.Stop();
        }

        internal static void fill(WebBrowser ie, string tag, string AttributeName, string AttributeValue, string value, string innerText)
        {
            foreach (HtmlElement element in ie.Document.GetElementsByTagName(tag))
            {
                if (element.GetAttribute(AttributeName).Equals(value))
                {
                    element.SetAttribute(AttributeValue, innerText);
                }
            }
        }

        internal static string getLivecaptcha(WebBrowser ie)
        {
            foreach (HtmlElement element in ie.Document.GetElementsByTagName("img"))
            {
                Console.WriteLine(string.Format("{0}\n\n\n", element.OuterHtml));
                if (element.OuterHtml.Contains("width: 218px; height: 48px; display: inline;"))
                {
                    return element.GetAttribute("src");
                }
            }
            return "Failed";
        }

        internal static string getRecaptcha(WebBrowser ie)
        {
            foreach (HtmlElement element in ie.Document.GetElementsByTagName("img"))
            {
                if (element.GetAttribute("alt").Equals("reCAPTCHA challenge image"))
                {
                    return element.GetAttribute("src");
                }
            }
            return null;
        }

        internal static string getVFcaptcha(WebBrowser ie)
        {
            foreach (HtmlElement element in ie.Document.GetElementsByTagName("img"))
            {
                if (element.GetAttribute("src").Contains("doimg.php?c="))
                {
                    return element.GetAttribute("src");
                }
            }
            return null;
        }

        internal static bool page(WebBrowser ieb, string matchUrl)
        {
            return ieb.Url.ToString().Contains(matchUrl);
        }

        internal static bool randomBool()
        {
            return (rand.Next(0, 2) > 0);
        }

        internal static long randomPhoneNumber()
        {
            string str = string.Empty;
            for (uint i = 0; i < 11; i++)
            {
                str = str + rand.Next(0, 9).ToString();
            }
            return Convert.ToInt64(str);
        }

        internal static string randomString(int size, bool lower, bool randomCase)
        {
            StringBuilder builder = new StringBuilder();
            int num = rand.Next(0, size);
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor((double)((26.0 * rand.NextDouble()) + 65.0))));
                if (randomCase)
                {
                    builder.Append(randomBool() ? ch : ch.ToString().ToLower()[0]);
                }
                else
                {
                    builder.Append(lower ? ch.ToString().ToLower()[0] : ch);
                }
            }
            return builder.ToString();
        }

        internal static int randomZip()
        {
            return rand.Next(0x2b67, 0x1869f);
        }

        internal static void sendPost(WebBrowser ie, string url, string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            ie.Navigate(url, "", bytes, "Content-Type: application/x-www-form-urlencoded");
        }

        internal static void success(WebBrowser ie, Button button, ToolStripStatusLabel label)
        {
            string path = "accounts.txt";
            string str2 = string.Format("Interpals - {0}:{1}", Regex.Replace(fillData["username"], @"\d", ""), fillData["password"]);
            button.Text = "Make another";
            button.Enabled = true;
            label.ForeColor = Color.Green;
            label.Text = "Acount created";
            ie.Stop();
            if (File.Exists(path) && !File.ReadAllText(path).Contains(str2))
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(str2);
                }
            }
        }

        internal static void wildFill(WebBrowser ie, string likeName, string newValue, string tag = "input")
        {
            foreach (HtmlElement element in ie.Document.GetElementsByTagName(tag))
            {
                if (element.GetAttribute("id").Contains(likeName) || element.GetAttribute("name").Contains(likeName))
                {
                    element.SetAttribute("value", newValue);
                }
            }
        }

        internal static void wildFillByArray(WebBrowser ie)
        {
            foreach (KeyValuePair<string, string> pair in fillData)
            {
                string[] strArray = pair.Key.Split(new char[] { ',' });
                foreach (string str in strArray)
                {
                    foreach (HtmlElement element in ie.Document.GetElementsByTagName("input"))
                    {
                        if (element.GetAttribute("id").Contains(str) || element.GetAttribute("name").Contains(str))
                        {
                            element.SetAttribute("value", pair.Value);
                        }
                    }
                }
            }
        }
    }
}

