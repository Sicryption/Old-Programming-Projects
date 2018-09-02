namespace Troubleshooter
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
            this.Troubleshoot = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Troubleshoot
            // 
            this.Troubleshoot.Location = new System.Drawing.Point(12, 12);
            this.Troubleshoot.Name = "Troubleshoot";
            this.Troubleshoot.Size = new System.Drawing.Size(301, 66);
            this.Troubleshoot.TabIndex = 0;
            this.Troubleshoot.Text = "Troubleshoot Problems";
            this.Troubleshoot.UseVisualStyleBackColor = true;
            this.Troubleshoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.Location = new System.Drawing.Point(12, 91);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(301, 186);
            this.Log.TabIndex = 2;
            this.Log.SelectedIndexChanged += new System.EventHandler(this.Log_Selected);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(319, 12);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(302, 265);
            this.Description.TabIndex = 3;
            this.Description.Text = "Click on a Item First";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 288);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Troubleshoot);
            this.Name = "Form1";
            this.Text = "Troubleshooter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Troubleshoot;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.TextBox Description;
    }
}

