namespace WindowsFormsApplication9
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
            this.dec1 = new System.Windows.Forms.RadioButton();
            this.hex1 = new System.Windows.Forms.RadioButton();
            this.bin1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dec2 = new System.Windows.Forms.RadioButton();
            this.hex2 = new System.Windows.Forms.RadioButton();
            this.bin2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dec1
            // 
            this.dec1.AutoSize = true;
            this.dec1.Checked = true;
            this.dec1.Location = new System.Drawing.Point(6, 19);
            this.dec1.Name = "dec1";
            this.dec1.Size = new System.Drawing.Size(63, 17);
            this.dec1.TabIndex = 0;
            this.dec1.TabStop = true;
            this.dec1.Text = "Decimal";
            this.dec1.UseVisualStyleBackColor = true;
            this.dec1.CheckedChanged += new System.EventHandler(this.dec1_CheckedChanged);
            // 
            // hex1
            // 
            this.hex1.AutoSize = true;
            this.hex1.Location = new System.Drawing.Point(6, 42);
            this.hex1.Name = "hex1";
            this.hex1.Size = new System.Drawing.Size(86, 17);
            this.hex1.TabIndex = 1;
            this.hex1.Text = "Hexadecimal";
            this.hex1.UseVisualStyleBackColor = true;
            this.hex1.CheckedChanged += new System.EventHandler(this.hex1_CheckedChanged);
            // 
            // bin1
            // 
            this.bin1.AutoSize = true;
            this.bin1.Location = new System.Drawing.Point(6, 65);
            this.bin1.Name = "bin1";
            this.bin1.Size = new System.Drawing.Size(54, 17);
            this.bin1.TabIndex = 2;
            this.bin1.Text = "Binary";
            this.bin1.UseVisualStyleBackColor = true;
            this.bin1.CheckedChanged += new System.EventHandler(this.bin1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dec1);
            this.groupBox1.Controls.Add(this.hex1);
            this.groupBox1.Controls.Add(this.bin1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dec2);
            this.groupBox2.Controls.Add(this.hex2);
            this.groupBox2.Controls.Add(this.bin2);
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Base";
            // 
            // dec2
            // 
            this.dec2.AutoSize = true;
            this.dec2.Location = new System.Drawing.Point(6, 19);
            this.dec2.Name = "dec2";
            this.dec2.Size = new System.Drawing.Size(63, 17);
            this.dec2.TabIndex = 0;
            this.dec2.Text = "Decimal";
            this.dec2.UseVisualStyleBackColor = true;
            this.dec2.CheckedChanged += new System.EventHandler(this.dec2_CheckedChanged);
            // 
            // hex2
            // 
            this.hex2.AutoSize = true;
            this.hex2.Checked = true;
            this.hex2.Location = new System.Drawing.Point(6, 42);
            this.hex2.Name = "hex2";
            this.hex2.Size = new System.Drawing.Size(86, 17);
            this.hex2.TabIndex = 1;
            this.hex2.TabStop = true;
            this.hex2.Text = "Hexadecimal";
            this.hex2.UseVisualStyleBackColor = true;
            this.hex2.CheckedChanged += new System.EventHandler(this.hex2_CheckedChanged);
            // 
            // bin2
            // 
            this.bin2.AutoSize = true;
            this.bin2.Location = new System.Drawing.Point(6, 65);
            this.bin2.Name = "bin2";
            this.bin2.Size = new System.Drawing.Size(54, 17);
            this.bin2.TabIndex = 2;
            this.bin2.Text = "Binary";
            this.bin2.UseVisualStyleBackColor = true;
            this.bin2.CheckedChanged += new System.EventHandler(this.bin2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(216, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "None";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Errors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dec1;
        private System.Windows.Forms.RadioButton hex1;
        private System.Windows.Forms.RadioButton bin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dec2;
        private System.Windows.Forms.RadioButton hex2;
        private System.Windows.Forms.RadioButton bin2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}

