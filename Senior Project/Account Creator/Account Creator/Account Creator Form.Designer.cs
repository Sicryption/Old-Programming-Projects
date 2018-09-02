namespace Account_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.TextBox();
            this.labelES = new System.Windows.Forms.Label();
            this.ES = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.labelStudentFirstName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Edgenuity = new System.Windows.Forms.RadioButton();
            this.Odysseyware = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelParentEmail = new System.Windows.Forms.Label();
            this.ParentEmail = new System.Windows.Forms.TextBox();
            this.labelParentLastName = new System.Windows.Forms.Label();
            this.ParentLastName = new System.Windows.Forms.TextBox();
            this.labelParentFirstName = new System.Windows.Forms.Label();
            this.ParentFirstName = new System.Windows.Forms.TextBox();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgenuityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odysseyWareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelGrade);
            this.groupBox1.Controls.Add(this.Grade);
            this.groupBox1.Controls.Add(this.labelES);
            this.groupBox1.Controls.Add(this.ES);
            this.groupBox1.Controls.Add(this.labelStudentID);
            this.groupBox1.Controls.Add(this.StudentID);
            this.groupBox1.Controls.Add(this.labelStudentLastName);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.labelStudentFirstName);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Location = new System.Drawing.Point(239, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(6, 131);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 9;
            this.labelGrade.Text = "Grade";
            // 
            // Grade
            // 
            this.Grade.Enabled = false;
            this.Grade.Location = new System.Drawing.Point(85, 128);
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Size = new System.Drawing.Size(157, 20);
            this.Grade.TabIndex = 8;
            // 
            // labelES
            // 
            this.labelES.AutoSize = true;
            this.labelES.Location = new System.Drawing.Point(6, 105);
            this.labelES.Name = "labelES";
            this.labelES.Size = new System.Drawing.Size(21, 13);
            this.labelES.TabIndex = 7;
            this.labelES.Text = "ES";
            // 
            // ES
            // 
            this.ES.Enabled = false;
            this.ES.Location = new System.Drawing.Point(85, 102);
            this.ES.Name = "ES";
            this.ES.ReadOnly = true;
            this.ES.Size = new System.Drawing.Size(157, 20);
            this.ES.TabIndex = 6;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(6, 79);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 5;
            this.labelStudentID.Text = "Student ID";
            // 
            // StudentID
            // 
            this.StudentID.Enabled = false;
            this.StudentID.Location = new System.Drawing.Point(85, 76);
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Size = new System.Drawing.Size(157, 20);
            this.StudentID.TabIndex = 4;
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Location = new System.Drawing.Point(6, 53);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(58, 13);
            this.labelStudentLastName.TabIndex = 3;
            this.labelStudentLastName.Text = "Last Name";
            // 
            // LastName
            // 
            this.LastName.Enabled = false;
            this.LastName.Location = new System.Drawing.Point(85, 50);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(157, 20);
            this.LastName.TabIndex = 2;
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.AutoSize = true;
            this.labelStudentFirstName.Location = new System.Drawing.Point(6, 27);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelStudentFirstName.TabIndex = 1;
            this.labelStudentFirstName.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Enabled = false;
            this.FirstName.Location = new System.Drawing.Point(85, 24);
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Size = new System.Drawing.Size(157, 20);
            this.FirstName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Edgenuity);
            this.groupBox2.Controls.Add(this.Odysseyware);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Website";
            // 
            // Edgenuity
            // 
            this.Edgenuity.AutoSize = true;
            this.Edgenuity.Enabled = false;
            this.Edgenuity.Location = new System.Drawing.Point(6, 42);
            this.Edgenuity.Name = "Edgenuity";
            this.Edgenuity.Size = new System.Drawing.Size(72, 17);
            this.Edgenuity.TabIndex = 1;
            this.Edgenuity.Text = "Edgenuity";
            this.Edgenuity.UseVisualStyleBackColor = true;
            // 
            // Odysseyware
            // 
            this.Odysseyware.AutoSize = true;
            this.Odysseyware.Enabled = false;
            this.Odysseyware.Location = new System.Drawing.Point(6, 19);
            this.Odysseyware.Name = "Odysseyware";
            this.Odysseyware.Size = new System.Drawing.Size(88, 17);
            this.Odysseyware.TabIndex = 0;
            this.Odysseyware.Text = "Odysseyware";
            this.Odysseyware.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.formattingToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.labelParentEmail);
            this.groupBox3.Controls.Add(this.ParentEmail);
            this.groupBox3.Controls.Add(this.labelParentLastName);
            this.groupBox3.Controls.Add(this.ParentLastName);
            this.groupBox3.Controls.Add(this.labelParentFirstName);
            this.groupBox3.Controls.Add(this.ParentFirstName);
            this.groupBox3.Location = new System.Drawing.Point(239, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parent Details";
            // 
            // labelParentEmail
            // 
            this.labelParentEmail.AutoSize = true;
            this.labelParentEmail.Location = new System.Drawing.Point(6, 79);
            this.labelParentEmail.Name = "labelParentEmail";
            this.labelParentEmail.Size = new System.Drawing.Size(32, 13);
            this.labelParentEmail.TabIndex = 5;
            this.labelParentEmail.Text = "Email";
            // 
            // ParentEmail
            // 
            this.ParentEmail.Enabled = false;
            this.ParentEmail.Location = new System.Drawing.Point(85, 76);
            this.ParentEmail.Name = "ParentEmail";
            this.ParentEmail.ReadOnly = true;
            this.ParentEmail.Size = new System.Drawing.Size(157, 20);
            this.ParentEmail.TabIndex = 4;
            // 
            // labelParentLastName
            // 
            this.labelParentLastName.AutoSize = true;
            this.labelParentLastName.Location = new System.Drawing.Point(6, 53);
            this.labelParentLastName.Name = "labelParentLastName";
            this.labelParentLastName.Size = new System.Drawing.Size(58, 13);
            this.labelParentLastName.TabIndex = 3;
            this.labelParentLastName.Text = "Last Name";
            // 
            // ParentLastName
            // 
            this.ParentLastName.Enabled = false;
            this.ParentLastName.Location = new System.Drawing.Point(85, 50);
            this.ParentLastName.Name = "ParentLastName";
            this.ParentLastName.ReadOnly = true;
            this.ParentLastName.Size = new System.Drawing.Size(157, 20);
            this.ParentLastName.TabIndex = 2;
            // 
            // labelParentFirstName
            // 
            this.labelParentFirstName.AutoSize = true;
            this.labelParentFirstName.Location = new System.Drawing.Point(6, 27);
            this.labelParentFirstName.Name = "labelParentFirstName";
            this.labelParentFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelParentFirstName.TabIndex = 1;
            this.labelParentFirstName.Text = "First Name";
            // 
            // ParentFirstName
            // 
            this.ParentFirstName.Enabled = false;
            this.ParentFirstName.Location = new System.Drawing.Point(85, 24);
            this.ParentFirstName.Name = "ParentFirstName";
            this.ParentFirstName.ReadOnly = true;
            this.ParentFirstName.Size = new System.Drawing.Size(157, 20);
            this.ParentFirstName.TabIndex = 0;
            // 
            // StudentList
            // 
            this.StudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Items.AddRange(new object[] {
            "New Student"});
            this.StudentList.Location = new System.Drawing.Point(12, 106);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(221, 186);
            this.StudentList.TabIndex = 5;
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.password);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.username);
            this.groupBox4.Location = new System.Drawing.Point(12, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 86);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(91, 50);
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(378, 20);
            this.password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(91, 24);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(378, 20);
            this.username.TabIndex = 0;
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // formattingToolStripMenuItem
            // 
            this.formattingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgenuityToolStripMenuItem,
            this.odysseyWareToolStripMenuItem});
            this.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem";
            this.formattingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formattingToolStripMenuItem.Text = "Formatting";
            this.formattingToolStripMenuItem.Click += new System.EventHandler(this.formattingToolStripMenuItem_Click);
            // 
            // edgenuityToolStripMenuItem
            // 
            this.edgenuityToolStripMenuItem.Name = "edgenuityToolStripMenuItem";
            this.edgenuityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edgenuityToolStripMenuItem.Text = "Edgenuity";
            this.edgenuityToolStripMenuItem.Click += new System.EventHandler(this.edgenuityToolStripMenuItem_Click);
            // 
            // odysseyWareToolStripMenuItem
            // 
            this.odysseyWareToolStripMenuItem.Name = "odysseyWareToolStripMenuItem";
            this.odysseyWareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odysseyWareToolStripMenuItem.Text = "OdysseyWare";
            this.odysseyWareToolStripMenuItem.Click += new System.EventHandler(this.odysseyWareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 396);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(515, 435);
            this.MinimumSize = new System.Drawing.Size(515, 435);
            this.Name = "Form1";
            this.Text = "Account Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label labelStudentLastName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label labelStudentFirstName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label labelES;
        private System.Windows.Forms.TextBox ES;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Edgenuity;
        private System.Windows.Forms.RadioButton Odysseyware;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelParentEmail;
        private System.Windows.Forms.TextBox ParentEmail;
        private System.Windows.Forms.Label labelParentLastName;
        private System.Windows.Forms.TextBox ParentLastName;
        private System.Windows.Forms.Label labelParentFirstName;
        private System.Windows.Forms.TextBox ParentFirstName;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox Grade;
        private System.Windows.Forms.ListBox StudentList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgenuityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odysseyWareToolStripMenuItem;
    }
}

