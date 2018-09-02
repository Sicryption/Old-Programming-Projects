using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosetta_Stone_Project
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        int optionNum = -1;
        int correctButton;
        double numWrong;
        double numCorrect = 0;
        bool[] gotWrong;
        bool[] slotFilled = new bool[3];
        string[] options = new string[]
        {   "¡Hola!",//
            "Me llamo Bryce Vichi.",//
            "Vivo en Medford.",//
            "Yo nací en Grants Pass.",//
            "Tengo quince años.",//
            "Soy inteligente, alto, y creativo.",//
            "Soy un estudiante de escuela Logos Público Charter Escuela.",//
            "Me gusta programación, hablar con mis amigos, y jugar juegos.",//
            "No me gusta los deportes.",//
            "Tengo un amplio conocimiento de computadoras",
            "Mi color favorito es el naranja.",//
            "Mi comida favorita es la pizza.",
            "Está es mi casa.",//
            "Está es mi sala de estar.",//
            "¡Espero que hayas disfrutado mi presentación!",
            "¡Adiós!"//
        };

        Image[] pictures = new Image[] 
        {
            Image.FromFile("Pictures\\Hola!.jpg"),
            Image.FromFile("Pictures\\Me llamo.jpg"),
            Image.FromFile("Pictures\\Medford.png"),
            Image.FromFile("Pictures\\GrantsPass.png"),
            Image.FromFile("Pictures\\15.png"),
            Image.FromFile("Pictures\\Smarts.png"),
            Image.FromFile("Pictures\\LogosSchool.png"),
            Image.FromFile("Pictures\\Coding.jpg"),
            Image.FromFile("Pictures\\Sports.jpg"),//
            Image.FromFile("Pictures\\Computas.jpg"),
            Image.FromFile("Pictures\\Orange.jpg"),
            Image.FromFile("Pictures\\Pizza.jpg"),
            Image.FromFile("Pictures\\House.jpg"),
            Image.FromFile("Pictures\\SalaDeEstar.jpg"),
            Image.FromFile("Pictures\\Enjoyed.jpg"),//
            Image.FromFile("Pictures\\Adios.jpg")
        };

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void setOptions(Image newImage, string[] option)
        {
            pictureBox1.BackgroundImage = newImage;
            buttonX1.Text = option[0];
            buttonX2.Text = option[1];
            buttonX3.Text = option[2];
        }

        private void switchOptions()
        {
            string[] newList = new string[3];
            Random r = new Random();
            int ne = r.Next(0, 2);
            newList[ne] = options[optionNum];
            slotFilled[ne] = true;
            correctButton = ne + 1;
            while (slotFilled[0] == false)
            {
                int tempNum = r.Next(0, options.Length);
                if (tempNum != optionNum)
                {
                    newList[0] = options[tempNum];
                    if (newList[0] != newList[1] && newList[0] != newList[2])
                    {
                        slotFilled[0] = true;
                    }
                }
            }
            while (slotFilled[1] == false)
            {
                int tempNum = r.Next(0, options.Length);
                if (tempNum != optionNum)
                {
                    newList[1] = options[tempNum];
                    if (newList[1] != newList[0] && newList[1] != newList[2])
                    {
                        slotFilled[1] = true;
                    }
                }
            }
            while (slotFilled[2] == false)
            {
                int tempNum = r.Next(0, options.Length);
                if (tempNum != optionNum)
                {
                    newList[2] = options[tempNum];
                    if (newList[0] != newList[2] && newList[0] != newList[1])
                    {
                        slotFilled[2] = true;
                    }
                }
            }
            slotFilled[0] = false;
            slotFilled[1] = false;
            slotFilled[2] = false;
            setOptions(pictures[optionNum], newList);
        }

        private void clickedOption(int num)
        {
            if (correctButton == num)
            {
                optionNum++;
                //Correct Answer
                if(optionNum != 0)
                    if (gotWrong[optionNum - 1] != true)
                        numCorrect++;
                label1.Text = "Incorrect " + numWrong;
                label2.Text = "Correct " + numCorrect;
                if (optionNum <= options.Length - 1)
                    switchOptions();
                else
                {
                    MessageBox.Show("You have completed my presentation!\r\nYour Score: " + ((int)((numCorrect / (options.Length)) * 100)).ToString() + "%", "Complete");
                    DialogResult dialogResult = MessageBox.Show("Would you like to try again?", "Try Again?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gotWrong = new bool[50];
                        optionNum = -1;
                        numWrong = 0;
                        correctButton = 0;
                        numCorrect = 0;
                        clickedOption(0);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Dispose();
                    }
                }

            }
            else
            {
                //Incorrect Answer
                if (gotWrong[optionNum] == false)
                {
                    numWrong++;
                    gotWrong[optionNum] = true;
                }
                label1.Text = "Incorrect " + numWrong;
                label2.Text = "Correct " + numCorrect;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gotWrong = new bool[options.Length + 2];
            clickedOption(0);
            this.Show();
            DevComponents.DotNetBar.MessageBoxEx.Show("Welcome to my Spanish Project!\r\nThis program was created entirely by: Bryce Vichi\r\n\r\nInstructions:\r\n1) Look at the image.\r\n2) Determine which button describes what is going on in the image.\r\n3) Click on that button.\r\n4) Continue until completed.", "Introduction");
        
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            clickedOption(1);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            clickedOption(2);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            clickedOption(3);
        }
    }
}
