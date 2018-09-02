using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Account_Creator
{
    public partial class Form1 : Form
    {
        Student[] students;
        public static string site;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentList.SelectedIndex = 0;
        }

        private void saveFile()
        {
            try
            {
                saveFileDialog1.FileName = "default";
                saveFileDialog1.Filter = "Excel files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (Student student in students)
                        {
                            sw.WriteLine(student.StudentFirstName + ", " + student.StudentLastName + ", " + student.Username + ", " + student.Password);
                        }

                        sw.Flush();
                    }
                }
            }
            catch
            {
                MessageBox.Show("An unknown exception has occured while saving file.");
            }
        }

        private void openFile()
        {
            string[] data = null, data2 = null, data3 = null;

            openFileDialog1.FileName = "default";
            openFileDialog1.Filter = "Excel files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //read document
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                //skips line 1
                sr.ReadLine();

                //get number of lines after line 1
                string tempString = String.Empty;
                int count = 0;
                while ((tempString = sr.ReadLine()) != null)
                {
                    count++;
                }

                //if there is multiple lines continue
                if (count > 0)
                {
                    try
                    {
                        //reopen file
                        sr = new StreamReader(openFileDialog1.FileName);

                        //skip line 1
                        sr.ReadLine();

                        //create arrays based off number of lines
                        data = new string[count];
                        students = new Student[count];

                        //collect data for each line
                        for (int i = 0; i < count; i++)
                            data[i] = sr.ReadLine();

                        //count number of commas
                        int commaCount = data[1].Count(x => x == ',');

                        //create arrays based off number of commas
                        data2 = new string[commaCount];

                        //check what file type it is
                        if (commaCount == 5)//edgenuity
                            Edgenuity.Checked = true;
                        else if (commaCount == 2)//odysseyware
                            Odysseyware.Checked = true;
                        else
                            MessageBox.Show("This file is formatted incorrectly.");
                         
                        //create students from data and saves to array "students"
                        for (int i = 0; i < data.Length; i++)
                        {
                            data2 = data[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            if (Edgenuity.Checked)//edgenuity
                                students[i] = new Student(data2[0], data2[1], data2[2], data2[3], data2[4], data2[5]);
                            else if (Odysseyware.Checked)//odysseyware
                                students[i] = new Student(data2[0], data2[1], data2[2]);
                        }

                        //clear listbox
                        StudentList.Items.Clear();

                        //adds data to listbox and creates user/pass
                        foreach (Student s in students)
                        {
                            StudentList.Items.Add(s.StudentFirstName + " " + s.StudentLastName);
                            //creates user/pass
                            GenerateDetails(s);
                        }

                        //reset listbox
                        StudentList.SelectedIndex = 0;

                        //enable save mode
                        if (!saveToolStripMenuItem.Enabled)
                            saveToolStripMenuItem.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("This file is incorrectly formatted.");
                    }
                }
            }
            else//if lack of lines tell user it doesnt contain data
                MessageBox.Show("This file is does not contain data.");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshActiveStudent();
        }

        private void RefreshActiveStudent()
        {
            try
            {
                if (students[0] != null)
                {
                    FirstName.Text = students[StudentList.SelectedIndex].StudentFirstName;
                    LastName.Text = students[StudentList.SelectedIndex].StudentLastName;
                    StudentID.Text = students[StudentList.SelectedIndex].StudentID;
                    ES.Text = students[StudentList.SelectedIndex].StudentES;
                    Grade.Text = students[StudentList.SelectedIndex].StudentGrade;
                    ParentFirstName.Text = students[StudentList.SelectedIndex].ParentFirstName;
                    ParentLastName.Text = students[StudentList.SelectedIndex].ParentLastName;
                    ParentEmail.Text = students[StudentList.SelectedIndex].ParentEmail;
                    username.Text = students[StudentList.SelectedIndex].Username;
                    password.Text = students[StudentList.SelectedIndex].Password;
                }
            }
            catch
            {

            }
        }

        private bool CheckForWordList()
        {
            try
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\Words.txt"))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void CreateWordList()
        {
            MessageBox.Show("The active folder lacks a Words.txt.\n\nCreating one automatically.");

            try
            {
                StreamWriter sw = new StreamWriter("Words.txt");
                sw.WriteLine("Logos");
                sw.WriteLine("Public");
                sw.WriteLine("Charter");
                sw.WriteLine("School");
                sw.WriteLine("Rocks");
                sw.Flush();
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Unable to create a Words.txt.\nPlease go to the below directory and manually create one before continueing.\n" + Directory.GetCurrentDirectory());
            }
        }

        private void formattingToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void edgenuityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edgenuity is formatted as First and Last Name, ID, Grade, Parent First, Parent Last, Parent Email", "Edgenuity Formatting");
        }

        private void odysseyWareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OdysseyWare is formatted as First and Last Name, ID, ES", "OW Formatting");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was created by:\r\nBryce Vichi\r\nFor:\r\nLogos Public Charter School");
        }
    }
}