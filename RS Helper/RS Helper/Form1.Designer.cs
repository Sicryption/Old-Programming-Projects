namespace RS_Helper
{
    partial class RSHelper
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
            this.components = new System.ComponentModel.Container();
            this.NormalAHK = new System.Windows.Forms.RadioButton();
            this.herbCleaning = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hotkeys = new System.Windows.Forms.GroupBox();
            this.prayerFlick = new System.Windows.Forms.RadioButton();
            this.Bank = new System.Windows.Forms.CheckBox();
            this.herbloreoption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NormalAHKCheckbox = new System.Windows.Forms.CheckBox();
            this.NormalAHKLine = new System.Windows.Forms.NumericUpDown();
            this.mousePos = new System.Windows.Forms.Label();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.hotkeys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalAHKLine)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalAHK
            // 
            this.NormalAHK.AutoSize = true;
            this.NormalAHK.Checked = true;
            this.NormalAHK.Location = new System.Drawing.Point(6, 44);
            this.NormalAHK.Name = "NormalAHK";
            this.NormalAHK.Size = new System.Drawing.Size(116, 17);
            this.NormalAHK.TabIndex = 6;
            this.NormalAHK.TabStop = true;
            this.NormalAHK.Text = "Normal MouseKeys";
            this.NormalAHK.UseVisualStyleBackColor = true;
            // 
            // herbCleaning
            // 
            this.herbCleaning.AutoSize = true;
            this.herbCleaning.Location = new System.Drawing.Point(6, 90);
            this.herbCleaning.Name = "herbCleaning";
            this.herbCleaning.Size = new System.Drawing.Size(106, 17);
            this.herbCleaning.TabIndex = 9;
            this.herbCleaning.Text = "Herblore (Key: H)";
            this.herbCleaning.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(55, 21);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.TabIndex = 11;
            this.status.Text = "Disabled";
            this.status.UseVisualStyleBackColor = true;
            this.status.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status: ";
            // 
            // hotkeys
            // 
            this.hotkeys.Controls.Add(this.prayerFlick);
            this.hotkeys.Controls.Add(this.Bank);
            this.hotkeys.Controls.Add(this.herbloreoption);
            this.hotkeys.Controls.Add(this.label2);
            this.hotkeys.Controls.Add(this.NormalAHKCheckbox);
            this.hotkeys.Controls.Add(this.NormalAHKLine);
            this.hotkeys.Controls.Add(this.NormalAHK);
            this.hotkeys.Controls.Add(this.label1);
            this.hotkeys.Controls.Add(this.status);
            this.hotkeys.Controls.Add(this.herbCleaning);
            this.hotkeys.Location = new System.Drawing.Point(12, 12);
            this.hotkeys.Name = "hotkeys";
            this.hotkeys.Size = new System.Drawing.Size(370, 116);
            this.hotkeys.TabIndex = 13;
            this.hotkeys.TabStop = false;
            this.hotkeys.Text = "Hotkeys";
            // 
            // prayerFlick
            // 
            this.prayerFlick.AutoSize = true;
            this.prayerFlick.Location = new System.Drawing.Point(6, 67);
            this.prayerFlick.Name = "prayerFlick";
            this.prayerFlick.Size = new System.Drawing.Size(94, 17);
            this.prayerFlick.TabIndex = 33;
            this.prayerFlick.Text = "Prayer Flicking";
            this.prayerFlick.UseVisualStyleBackColor = true;
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Location = new System.Drawing.Point(217, 91);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(51, 17);
            this.Bank.TabIndex = 32;
            this.Bank.Text = "Bank";
            this.Bank.UseVisualStyleBackColor = true;
            // 
            // herbloreoption
            // 
            this.herbloreoption.AutoSize = true;
            this.herbloreoption.Location = new System.Drawing.Point(118, 91);
            this.herbloreoption.Name = "herbloreoption";
            this.herbloreoption.Size = new System.Drawing.Size(93, 17);
            this.herbloreoption.TabIndex = 27;
            this.herbloreoption.Text = "Herb Cleaning";
            this.herbloreoption.UseVisualStyleBackColor = true;
            this.herbloreoption.CheckedChanged += new System.EventHandler(this.herbloreoption_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Line Num:";
            // 
            // NormalAHKCheckbox
            // 
            this.NormalAHKCheckbox.AutoSize = true;
            this.NormalAHKCheckbox.Location = new System.Drawing.Point(128, 46);
            this.NormalAHKCheckbox.Name = "NormalAHKCheckbox";
            this.NormalAHKCheckbox.Size = new System.Drawing.Size(113, 17);
            this.NormalAHKCheckbox.TabIndex = 16;
            this.NormalAHKCheckbox.Text = "(Keys: Q, W, E, R)";
            this.NormalAHKCheckbox.UseVisualStyleBackColor = true;
            this.NormalAHKCheckbox.CheckedChanged += new System.EventHandler(this.NormalAHKCheckbox_CheckedChanged);
            // 
            // NormalAHKLine
            // 
            this.NormalAHKLine.Location = new System.Drawing.Point(321, 44);
            this.NormalAHKLine.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NormalAHKLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NormalAHKLine.Name = "NormalAHKLine";
            this.NormalAHKLine.Size = new System.Drawing.Size(43, 20);
            this.NormalAHKLine.TabIndex = 15;
            this.NormalAHKLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.Location = new System.Drawing.Point(15, 131);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(103, 13);
            this.mousePos.TabIndex = 14;
            this.mousePos.Text = "Mouse Position: 0, 0";
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // RSHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 147);
            this.Controls.Add(this.mousePos);
            this.Controls.Add(this.hotkeys);
            this.Name = "RSHelper";
            this.Text = "RS Helper";
            this.hotkeys.ResumeLayout(false);
            this.hotkeys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalAHKLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton NormalAHK;
        private System.Windows.Forms.RadioButton herbCleaning;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox hotkeys;
        private System.Windows.Forms.Label mousePos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox NormalAHKCheckbox;
        private System.Windows.Forms.NumericUpDown NormalAHKLine;
        private System.Windows.Forms.CheckBox herbloreoption;
        private System.Windows.Forms.CheckBox Bank;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.RadioButton prayerFlick;
    }
}

