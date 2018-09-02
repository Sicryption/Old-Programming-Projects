using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zulrah_Helper
{
    public partial class Form1 : Form
    {
        int Rotation = -1;
        int Step = 0;

        public ZulrahRotation Rotation1 = new ZulrahRotation(
                new string[] { "North", "North", "North", "South", "North", "West", "South", "South", "West" },
                new string[] { "Ranged", "Melee", "Mage", "Ranged", "Melee", "Mage", "Ranged", "Mage", "Range/Mage" },
                new string[] { "North East", "North East", "North East", "West Pole", "West Pole", "West Pole", "East Pole", "East Pole", "North West" });
        public ZulrahRotation Rotation2 = new ZulrahRotation(
                new string[] { "North", "North", "North", "West", "South", "North", "East", "South", "West" },
                new string[] { "Ranged", "Melee", "Mage", "Ranged", "Mage", "Melee", "Ranged", "Mage", "Range/Mage" },
                new string[] { "North East", "North East", "North East", "West Pole", "West Pole", "West Pole", "East Pole", "East Pole", "North West" });
        public ZulrahRotation Rotation3 = new ZulrahRotation(
                new string[] { "North", "East", "North", "West", "South", "East", "North", "West", "North", "East" },
                new string[] { "Ranged", "Ranged", "Melee", "Mage", "Ranged", "Mage", "Ranged", "Ranged", "Mage", "Mage/Range" },
                new string[] { "North East", "North East", "North West", "West Pole", "West Pole", "East Pole", "West Center", "West Center", "East Center", "East Center" });
        public ZulrahRotation Rotation4 = new ZulrahRotation(
                new string[] { "North", "East", "South", "West", "North", "East", "South", "West", "North", "North", "East" },
                new string[] { "Ranged", "Mage", "Ranged", "Mage", "Melee", "Ranged", "Ranged", "Mage", "Range", "Mage", "Mage/Range" },
                new string[] { "North East", "North East", "West Pole", "West Pole", "East Pole", "East Pole", "West Pole", "West Pole", "East Pole", "East Pole", "East Pole" });


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        void ResetControls()
        {
            foreach (GroupBox obj in Controls.OfType<GroupBox>())
            {
                foreach (TextBox obj2 in obj.Controls)
                {
                    obj2.Text = (string)obj2.Tag;
                }
            }
            Rotation = -1;
            Step = 0;
        }

        //First Step Button
        private void button2_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Ranged":
                    if(Rotation == -1)
                        Rotation = 3;
                    break;
                case "Mage":
                    if (Rotation == -1)
                        Rotation = 4;
                    break;
                case "Melee":
                    if (Rotation == -1)
                        Rotation = 2;
                    if (label1.Text != "Fourth Step:" && Step == 2)
                    {
                        label1.Text = "Fourth Step:";
                        comboBox1.Text = "South";
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("South");
                        comboBox1.Items.Add("West");
                        Step++;
                        UpdateLocation(true);
                    }
                    break;
                case "West":
                    Rotation = 2;
                    Step = 3;

                    label1.Text = "First Step:";
                    comboBox1.Text = "Ranged";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Ranged");
                    comboBox1.Items.Add("Mage");
                    comboBox1.Items.Add("Melee");
                    break;
                case "South":
                    Rotation = 1;
                    Step = 3;

                    label1.Text = "First Step:";
                    comboBox1.Text = "Ranged";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Ranged");
                    comboBox1.Items.Add("Mage");
                    comboBox1.Items.Add("Melee");
                    break;
            }
            if (label1.Text != "Fourth Step:")
            {
                Step++;
                UpdateLocation();
            }
        }

        public void UpdateLocation(bool unsure = false)
        {
            ZulrahRotation rotation = GetRotation();
            if (rotation != null)
            {
                int nextStep = Step + 1;
                if (nextStep == rotation.Position.Length)
                    nextStep = 0;
                else if (nextStep == rotation.Position.Length +1)
                {
                    ResetControls();
                    return;
                }

                ActiveStep.Text = "Step: " + (Step +  1) + "/" + rotation.Position.Length;
                ActiveRotation.Text = "Rotation: " + Rotation + "/4";
                ActivePosition.Text = "Position: " + rotation.Position[Step];
                ActiveType.Text = "Type: " + rotation.Type[Step];
                ActiveSS.Text = "SafeSpot: " + rotation.SafeSpot[Step];
                ActivePray.Text = "Pray: " + rotation.Type[Step];

                if (!unsure)
                {
                    NextStep.Text = "Step: " + (nextStep + 1) + "/" + rotation.Position.Length;
                    NextRotation.Text = "Rotation: " + Rotation + "/4";
                    NextPosition.Text = "Position: " + rotation.Position[nextStep];
                    NextType.Text = "Type: " + rotation.Type[nextStep];
                    NextSS.Text = "SafeSpot: " + rotation.SafeSpot[nextStep];
                    NextPray.Text = "Pray: " + rotation.Type[nextStep];
                }
                else
                {
                    NextStep.Text = "Step: " + (nextStep + 1) + "/" + rotation.Position.Length;
                    NextRotation.Text = "Rotation: " + Rotation + "/4";
                    NextPosition.Text = "Position: Unsure";
                    NextType.Text = "Type: Unsure";
                    NextSS.Text = "SafeSpot: Unsure";
                    NextPray.Text = "Pray: Unsure";
                }
            }
        }

        public ZulrahRotation GetRotation()
        {
            if (Rotation == 1)
                return Rotation1;
            else if (Rotation == 2)
                return Rotation2;
            else if (Rotation == 3)
                return Rotation3;
            else if (Rotation == 4)
                return Rotation4;
            else
                return null;
        }
    }

    public class ZulrahRotation
    {
        public string[] Position,
            Type,
            SafeSpot;

        public ZulrahRotation(string[] pos, string[] type, string[] ss)
        {
            Position = pos;
            Type = type;
            SafeSpot = ss;
        }
    }
}
