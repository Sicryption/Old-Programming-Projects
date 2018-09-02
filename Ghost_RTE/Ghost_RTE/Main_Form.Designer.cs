namespace Ghost_RTE
{
    partial class Main_Form
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
            prestigeCycleThread.Abort();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noRecoil = new System.Windows.Forms.CheckBox();
            this.radar = new System.Windows.Forms.CheckBox();
            this.laser = new System.Windows.Forms.CheckBox();
            this.redBoxes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.prestigeCycle = new System.Windows.Forms.CheckBox();
            this.randomizeCycle = new System.Windows.Forms.CheckBox();
            this.levelValue = new System.Windows.Forms.NumericUpDown();
            this.level = new System.Windows.Forms.Button();
            this.prestigeValue = new System.Windows.Forms.NumericUpDown();
            this.prestige = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chams = new System.Windows.Forms.CheckBox();
            this.chamsShowBody = new System.Windows.Forms.CheckBox();
            this.chamsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestigeValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noRecoil);
            this.groupBox1.Controls.Add(this.radar);
            this.groupBox1.Controls.Add(this.laser);
            this.groupBox1.Controls.Add(this.redBoxes);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Off-Host Mods";
            // 
            // noRecoil
            // 
            this.noRecoil.AutoSize = true;
            this.noRecoil.Location = new System.Drawing.Point(6, 88);
            this.noRecoil.Name = "noRecoil";
            this.noRecoil.Size = new System.Drawing.Size(73, 17);
            this.noRecoil.TabIndex = 4;
            this.noRecoil.Text = "No Recoil";
            this.noRecoil.UseVisualStyleBackColor = true;
            this.noRecoil.CheckedChanged += new System.EventHandler(this.noRecoil_CheckedChanged);
            // 
            // radar
            // 
            this.radar.AutoSize = true;
            this.radar.Location = new System.Drawing.Point(6, 65);
            this.radar.Name = "radar";
            this.radar.Size = new System.Drawing.Size(55, 17);
            this.radar.TabIndex = 3;
            this.radar.Text = "Radar";
            this.radar.UseVisualStyleBackColor = true;
            this.radar.CheckedChanged += new System.EventHandler(this.radar_CheckedChanged);
            // 
            // laser
            // 
            this.laser.AutoSize = true;
            this.laser.Location = new System.Drawing.Point(6, 42);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(52, 17);
            this.laser.TabIndex = 1;
            this.laser.Text = "Laser";
            this.laser.UseVisualStyleBackColor = true;
            this.laser.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // redBoxes
            // 
            this.redBoxes.AutoSize = true;
            this.redBoxes.Location = new System.Drawing.Point(6, 19);
            this.redBoxes.Name = "redBoxes";
            this.redBoxes.Size = new System.Drawing.Size(78, 17);
            this.redBoxes.TabIndex = 0;
            this.redBoxes.Text = "Red Boxes";
            this.redBoxes.UseVisualStyleBackColor = true;
            this.redBoxes.CheckedChanged += new System.EventHandler(this.redBoxes_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Active Connection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.prestigeCycle);
            this.groupBox2.Controls.Add(this.randomizeCycle);
            this.groupBox2.Controls.Add(this.levelValue);
            this.groupBox2.Controls.Add(this.level);
            this.groupBox2.Controls.Add(this.prestigeValue);
            this.groupBox2.Location = new System.Drawing.Point(122, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Restart Cycle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prestigeCycle
            // 
            this.prestigeCycle.AutoSize = true;
            this.prestigeCycle.Location = new System.Drawing.Point(6, 90);
            this.prestigeCycle.Name = "prestigeCycle";
            this.prestigeCycle.Size = new System.Drawing.Size(93, 17);
            this.prestigeCycle.TabIndex = 7;
            this.prestigeCycle.Text = "Prestige Cycle";
            this.prestigeCycle.UseVisualStyleBackColor = true;
            this.prestigeCycle.CheckedChanged += new System.EventHandler(this.prestigeCycle_CheckedChanged);
            // 
            // randomizeCycle
            // 
            this.randomizeCycle.AutoSize = true;
            this.randomizeCycle.Location = new System.Drawing.Point(6, 67);
            this.randomizeCycle.Name = "randomizeCycle";
            this.randomizeCycle.Size = new System.Drawing.Size(108, 17);
            this.randomizeCycle.TabIndex = 6;
            this.randomizeCycle.Text = "Randomize Cycle";
            this.randomizeCycle.UseVisualStyleBackColor = true;
            this.randomizeCycle.CheckedChanged += new System.EventHandler(this.randomizeCycle_CheckedChanged);
            // 
            // levelValue
            // 
            this.levelValue.Location = new System.Drawing.Point(6, 41);
            this.levelValue.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.levelValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(86, 20);
            this.levelValue.TabIndex = 5;
            this.levelValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(98, 42);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(78, 20);
            this.level.TabIndex = 4;
            this.level.Text = "Level";
            this.level.UseVisualStyleBackColor = true;
            this.level.Click += new System.EventHandler(this.level_Click);
            // 
            // prestigeValue
            // 
            this.prestigeValue.Location = new System.Drawing.Point(6, 16);
            this.prestigeValue.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.prestigeValue.Name = "prestigeValue";
            this.prestigeValue.Size = new System.Drawing.Size(86, 20);
            this.prestigeValue.TabIndex = 0;
            // 
            // prestige
            // 
            this.prestige.Location = new System.Drawing.Point(220, 66);
            this.prestige.Name = "prestige";
            this.prestige.Size = new System.Drawing.Size(78, 20);
            this.prestige.TabIndex = 1;
            this.prestige.Text = "Prestige";
            this.prestige.UseVisualStyleBackColor = true;
            this.prestige.Click += new System.EventHandler(this.prestige_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chams);
            this.groupBox3.Controls.Add(this.chamsShowBody);
            this.groupBox3.Controls.Add(this.chamsComboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chams";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chams
            // 
            this.chams.AutoSize = true;
            this.chams.Location = new System.Drawing.Point(6, 68);
            this.chams.Name = "chams";
            this.chams.Size = new System.Drawing.Size(58, 17);
            this.chams.TabIndex = 2;
            this.chams.Text = "Chams";
            this.chams.UseVisualStyleBackColor = true;
            this.chams.CheckedChanged += new System.EventHandler(this.chams_CheckedChanged);
            // 
            // chamsShowBody
            // 
            this.chamsShowBody.AutoSize = true;
            this.chamsShowBody.Location = new System.Drawing.Point(6, 19);
            this.chamsShowBody.Name = "chamsShowBody";
            this.chamsShowBody.Size = new System.Drawing.Size(80, 17);
            this.chamsShowBody.TabIndex = 6;
            this.chamsShowBody.Text = "Show Body";
            this.chamsShowBody.UseVisualStyleBackColor = true;
            this.chamsShowBody.CheckedChanged += new System.EventHandler(this.chamsShowBody_CheckedChanged);
            // 
            // chamsComboBox
            // 
            this.chamsComboBox.FormattingEnabled = true;
            this.chamsComboBox.Items.AddRange(new object[] {
            "White",
            "Red",
            "Green",
            "Blue",
            "Orange",
            "Yellow"});
            this.chamsComboBox.Location = new System.Drawing.Point(6, 41);
            this.chamsComboBox.Name = "chamsComboBox";
            this.chamsComboBox.Size = new System.Drawing.Size(92, 21);
            this.chamsComboBox.TabIndex = 5;
            this.chamsComboBox.Text = "White";
            this.chamsComboBox.SelectedIndexChanged += new System.EventHandler(this.chamsComboBox_SelectedIndexChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 267);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.prestige);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_Form";
            this.Text = "Ghosts RTE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestigeValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox radar;
        private System.Windows.Forms.CheckBox laser;
        private System.Windows.Forms.CheckBox redBoxes;
        private System.Windows.Forms.CheckBox noRecoil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown levelValue;
        private System.Windows.Forms.Button level;
        private System.Windows.Forms.NumericUpDown prestigeValue;
        private System.Windows.Forms.Button prestige;
        private System.Windows.Forms.CheckBox prestigeCycle;
        private System.Windows.Forms.CheckBox randomizeCycle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chams;
        private System.Windows.Forms.CheckBox chamsShowBody;
        private System.Windows.Forms.ComboBox chamsComboBox;
    }
}

