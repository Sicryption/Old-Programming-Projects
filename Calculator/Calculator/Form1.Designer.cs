namespace Calculator
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
            this.decInBin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.binInBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toBinFromDec = new System.Windows.Forms.RadioButton();
            this.toDecFromBin = new System.Windows.Forms.RadioButton();
            this.error = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // decInBin
            // 
            this.decInBin.Location = new System.Drawing.Point(61, 19);
            this.decInBin.Name = "decInBin";
            this.decInBin.Size = new System.Drawing.Size(196, 20);
            this.decInBin.TabIndex = 0;
            this.decInBin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toDecFromBin);
            this.groupBox1.Controls.Add(this.toBinFromDec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.binInBin);
            this.groupBox1.Controls.Add(this.decInBin);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binary";
            // 
            // binInBin
            // 
            this.binInBin.Location = new System.Drawing.Point(61, 74);
            this.binInBin.Name = "binInBin";
            this.binInBin.Size = new System.Drawing.Size(196, 20);
            this.binInBin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binary";
            // 
            // toBinFromDec
            // 
            this.toBinFromDec.AutoSize = true;
            this.toBinFromDec.Checked = true;
            this.toBinFromDec.Location = new System.Drawing.Point(61, 48);
            this.toBinFromDec.Name = "toBinFromDec";
            this.toBinFromDec.Size = new System.Drawing.Size(56, 17);
            this.toBinFromDec.TabIndex = 4;
            this.toBinFromDec.TabStop = true;
            this.toBinFromDec.Text = "To Bin";
            this.toBinFromDec.UseVisualStyleBackColor = true;
            // 
            // toDecFromBin
            // 
            this.toDecFromBin.AutoSize = true;
            this.toDecFromBin.Location = new System.Drawing.Point(135, 48);
            this.toDecFromBin.Name = "toDecFromBin";
            this.toDecFromBin.Size = new System.Drawing.Size(61, 17);
            this.toDecFromBin.TabIndex = 5;
            this.toDecFromBin.Text = "To Dec";
            this.toDecFromBin.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(9, 229);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(266, 20);
            this.error.TabIndex = 2;
            this.error.Text = "No error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.error);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decInBin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton toDecFromBin;
        private System.Windows.Forms.RadioButton toBinFromDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox binInBin;
        private System.Windows.Forms.TextBox error;
    }
}

