namespace Zulrah_Helper
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
            this.button1 = new System.Windows.Forms.Button();
            this.ActiveStep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActivePray = new System.Windows.Forms.TextBox();
            this.ActiveSS = new System.Windows.Forms.TextBox();
            this.ActiveType = new System.Windows.Forms.TextBox();
            this.ActivePosition = new System.Windows.Forms.TextBox();
            this.ActiveRotation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextPray = new System.Windows.Forms.TextBox();
            this.NextSS = new System.Windows.Forms.TextBox();
            this.NextType = new System.Windows.Forms.TextBox();
            this.NextPosition = new System.Windows.Forms.TextBox();
            this.NextRotation = new System.Windows.Forms.TextBox();
            this.NextStep = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActiveStep
            // 
            this.ActiveStep.Location = new System.Drawing.Point(6, 19);
            this.ActiveStep.Name = "ActiveStep";
            this.ActiveStep.Size = new System.Drawing.Size(208, 20);
            this.ActiveStep.TabIndex = 1;
            this.ActiveStep.Tag = "Step: Select First Step to start";
            this.ActiveStep.Text = "Step: Select First Step to start";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActivePray);
            this.groupBox1.Controls.Add(this.ActiveSS);
            this.groupBox1.Controls.Add(this.ActiveType);
            this.groupBox1.Controls.Add(this.ActivePosition);
            this.groupBox1.Controls.Add(this.ActiveRotation);
            this.groupBox1.Controls.Add(this.ActiveStep);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zulrah Active Step";
            // 
            // ActivePray
            // 
            this.ActivePray.Location = new System.Drawing.Point(6, 149);
            this.ActivePray.Name = "ActivePray";
            this.ActivePray.Size = new System.Drawing.Size(208, 20);
            this.ActivePray.TabIndex = 7;
            this.ActivePray.Tag = "Pray:";
            this.ActivePray.Text = "Pray:";
            // 
            // ActiveSS
            // 
            this.ActiveSS.Location = new System.Drawing.Point(6, 123);
            this.ActiveSS.Name = "ActiveSS";
            this.ActiveSS.Size = new System.Drawing.Size(208, 20);
            this.ActiveSS.TabIndex = 5;
            this.ActiveSS.Tag = "Safe Spot: North East";
            this.ActiveSS.Text = "Safe Spot: North East";
            // 
            // ActiveType
            // 
            this.ActiveType.Location = new System.Drawing.Point(6, 97);
            this.ActiveType.Name = "ActiveType";
            this.ActiveType.Size = new System.Drawing.Size(208, 20);
            this.ActiveType.TabIndex = 4;
            this.ActiveType.Tag = "Type: Ranged";
            this.ActiveType.Text = "Type: Ranged";
            // 
            // ActivePosition
            // 
            this.ActivePosition.Location = new System.Drawing.Point(6, 71);
            this.ActivePosition.Name = "ActivePosition";
            this.ActivePosition.Size = new System.Drawing.Size(208, 20);
            this.ActivePosition.TabIndex = 3;
            this.ActivePosition.Tag = "Position: North";
            this.ActivePosition.Text = "Position: North";
            // 
            // ActiveRotation
            // 
            this.ActiveRotation.Location = new System.Drawing.Point(6, 45);
            this.ActiveRotation.Name = "ActiveRotation";
            this.ActiveRotation.Size = new System.Drawing.Size(208, 20);
            this.ActiveRotation.TabIndex = 2;
            this.ActiveRotation.Tag = "Rotation: Unkown/4";
            this.ActiveRotation.Text = "Rotation: Unkown/4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextPray);
            this.groupBox2.Controls.Add(this.NextSS);
            this.groupBox2.Controls.Add(this.NextType);
            this.groupBox2.Controls.Add(this.NextPosition);
            this.groupBox2.Controls.Add(this.NextRotation);
            this.groupBox2.Controls.Add(this.NextStep);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 182);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zulrah Next Step";
            // 
            // NextPray
            // 
            this.NextPray.Location = new System.Drawing.Point(6, 149);
            this.NextPray.Name = "NextPray";
            this.NextPray.Size = new System.Drawing.Size(208, 20);
            this.NextPray.TabIndex = 6;
            this.NextPray.Tag = "Pray:";
            this.NextPray.Text = "Pray:";
            // 
            // NextSS
            // 
            this.NextSS.Location = new System.Drawing.Point(6, 123);
            this.NextSS.Name = "NextSS";
            this.NextSS.Size = new System.Drawing.Size(208, 20);
            this.NextSS.TabIndex = 5;
            this.NextSS.Tag = "Safe Spot: North East";
            this.NextSS.Text = "Safe Spot: North East";
            // 
            // NextType
            // 
            this.NextType.Location = new System.Drawing.Point(6, 97);
            this.NextType.Name = "NextType";
            this.NextType.Size = new System.Drawing.Size(208, 20);
            this.NextType.TabIndex = 4;
            this.NextType.Tag = "Type:";
            this.NextType.Text = "Type:";
            // 
            // NextPosition
            // 
            this.NextPosition.Location = new System.Drawing.Point(6, 71);
            this.NextPosition.Name = "NextPosition";
            this.NextPosition.Size = new System.Drawing.Size(208, 20);
            this.NextPosition.TabIndex = 3;
            this.NextPosition.Tag = "Position: ";
            this.NextPosition.Text = "Position: ";
            // 
            // NextRotation
            // 
            this.NextRotation.Location = new System.Drawing.Point(6, 45);
            this.NextRotation.Name = "NextRotation";
            this.NextRotation.Size = new System.Drawing.Size(208, 20);
            this.NextRotation.TabIndex = 2;
            this.NextRotation.Tag = "Rotation: ";
            this.NextRotation.Text = "Rotation: ";
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(6, 19);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(208, 20);
            this.NextStep.TabIndex = 1;
            this.NextStep.Tag = "Step: ";
            this.NextStep.Text = "Step: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ranged",
            "Mage",
            "Melee"});
            this.comboBox1.Location = new System.Drawing.Point(96, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Tag = "Ranged";
            this.comboBox1.Text = "Ranged";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Step:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Zulrah Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ActiveStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ActivePray;
        private System.Windows.Forms.TextBox ActiveSS;
        private System.Windows.Forms.TextBox ActiveType;
        private System.Windows.Forms.TextBox ActivePosition;
        private System.Windows.Forms.TextBox ActiveRotation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NextPray;
        private System.Windows.Forms.TextBox NextSS;
        private System.Windows.Forms.TextBox NextType;
        private System.Windows.Forms.TextBox NextPosition;
        private System.Windows.Forms.TextBox NextRotation;
        private System.Windows.Forms.TextBox NextStep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

