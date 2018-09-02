using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Document_Searcher
{
    class Program
    {
        static StreamReader sr;
        static StreamWriter sw;
        static int lineNumber = 0;
        static int numLines = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Insert File Name (do not incude .txt)");
            string input = Console.ReadLine();
            sr = new StreamReader(input + ".txt");
            sw = new StreamWriter(input + "_Temp.txt");

            while (!sr.EndOfStream)
            {
                numLines++;
                sr.ReadLine();
            }

            sr = new StreamReader(input + ".txt");
            while (!sr.EndOfStream)
            {
                Console.Clear();
                Console.WriteLine("Line: " + lineNumber + "/" + numLines);
                lineNumber++;
                string currentLine = sr.ReadLine();
                if (hasMultipleOfSameCharacter(currentLine, ':'))
                {
                    string[] information = currentLine.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                    if (information.Length != 2)
                        continue;
                    string username = information[0];
                    string password = information[1];

                    if (!username.Contains("@")
                        && username.Length <= 12
                        && !username.ToLower().Contains("fuck"))
                    {
                        //good username
                        sw.WriteLine(currentLine);
                    }
                    else if (!hasMultipleOfSameCharacter(username, '@') && username.Contains("@") && username.Contains("."))
                    {
                        //good email
                        sw.WriteLine(currentLine);
                    }
                }
            }
            Console.WriteLine("Press Enter to continue.");
            Console.Read();
        }

        static bool hasMultipleOfSameCharacter(string text, char character)
        {
            int numInstances = 0;
            char[] temp = text.ToCharArray();
            foreach (char c in temp)
                if (c == character)
                    numInstances++;

            if (numInstances > 1)
                return true;

            return false;
        }
    }
}
