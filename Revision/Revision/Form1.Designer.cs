namespace Revision
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
                this.Close();
                components.Dispose();
            }
            prestigeCycleThread.Abort();
            tbagCycleThread.Abort();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage StatsTab;
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.NumericUpDown();
            this.button16 = new System.Windows.Forms.Button();
            this.squad = new System.Windows.Forms.NumericUpDown();
            this.button17 = new System.Windows.Forms.Button();
            this.misses = new System.Windows.Forms.NumericUpDown();
            this.button12 = new System.Windows.Forms.Button();
            this.hits = new System.Windows.Forms.NumericUpDown();
            this.button13 = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.NumericUpDown();
            this.button14 = new System.Windows.Forms.Button();
            this.losses = new System.Windows.Forms.NumericUpDown();
            this.button9 = new System.Windows.Forms.Button();
            this.wins = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.killstreak = new System.Windows.Forms.NumericUpDown();
            this.button11 = new System.Windows.Forms.Button();
            this.deaths = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.kills = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.xp = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.prestige = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClientsTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.button21 = new System.Windows.Forms.Button();
            this.wallhack = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.fov = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button37 = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.TogglesTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.offhost = new System.Windows.Forms.GroupBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.uav = new System.Windows.Forms.CheckBox();
            this.norecoil = new System.Windows.Forms.CheckBox();
            this.chams = new System.Windows.Forms.CheckBox();
            this.laser = new System.Windows.Forms.CheckBox();
            this.redbox = new System.Windows.Forms.CheckBox();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.Misc1Tab = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.poi = new System.Windows.Forms.ComboBox();
            this.button33 = new System.Windows.Forms.Button();
            this.gt = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button32 = new System.Windows.Forms.Button();
            this.model = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button31 = new System.Windows.Forms.Button();
            this.weap = new System.Windows.Forms.ComboBox();
            this.Misc2Tab = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button34 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button28 = new System.Windows.Forms.Button();
            this.customdvar = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button30 = new System.Windows.Forms.Button();
            this.timelimit = new System.Windows.Forms.NumericUpDown();
            this.button27 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.jumpheight = new System.Windows.Forms.NumericUpDown();
            this.scorelimit = new System.Windows.Forms.NumericUpDown();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.xpperkill = new System.Windows.Forms.NumericUpDown();
            this.Misc3Tab = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.checkerBoard = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.NewTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            StatsTab = new System.Windows.Forms.TabPage();
            StatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.losses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killstreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestige)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ClientsTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallhack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fov)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TogglesTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.offhost.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.Misc1Tab.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.Misc2Tab.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scorelimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpperkill)).BeginInit();
            this.Misc3Tab.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatsTab
            // 
            StatsTab.Controls.Add(this.button20);
            StatsTab.Controls.Add(this.button19);
            StatsTab.Controls.Add(this.button18);
            StatsTab.Controls.Add(this.button15);
            StatsTab.Controls.Add(this.score);
            StatsTab.Controls.Add(this.button16);
            StatsTab.Controls.Add(this.squad);
            StatsTab.Controls.Add(this.button17);
            StatsTab.Controls.Add(this.misses);
            StatsTab.Controls.Add(this.button12);
            StatsTab.Controls.Add(this.hits);
            StatsTab.Controls.Add(this.button13);
            StatsTab.Controls.Add(this.games);
            StatsTab.Controls.Add(this.button14);
            StatsTab.Controls.Add(this.losses);
            StatsTab.Controls.Add(this.button9);
            StatsTab.Controls.Add(this.wins);
            StatsTab.Controls.Add(this.button10);
            StatsTab.Controls.Add(this.killstreak);
            StatsTab.Controls.Add(this.button11);
            StatsTab.Controls.Add(this.deaths);
            StatsTab.Controls.Add(this.button4);
            StatsTab.Controls.Add(this.kills);
            StatsTab.Controls.Add(this.button7);
            StatsTab.Controls.Add(this.xp);
            StatsTab.Controls.Add(this.button8);
            StatsTab.Controls.Add(this.prestige);
            StatsTab.Location = new System.Drawing.Point(4, 22);
            StatsTab.Name = "StatsTab";
            StatsTab.Padding = new System.Windows.Forms.Padding(3);
            StatsTab.Size = new System.Drawing.Size(332, 167);
            StatsTab.TabIndex = 2;
            StatsTab.Text = "Stats";
            StatsTab.UseVisualStyleBackColor = true;
            StatsTab.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 175);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(96, 21);
            this.button20.TabIndex = 34;
            this.button20.Tag = "";
            this.button20.Text = "Squads Level 60";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(119, 175);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 21);
            this.button19.TabIndex = 33;
            this.button19.Tag = "";
            this.button19.Text = "Unlock All";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(230, 175);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(96, 21);
            this.button18.TabIndex = 32;
            this.button18.Tag = "";
            this.button18.Text = "Set All";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(258, 136);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 20);
            this.button15.TabIndex = 31;
            this.button15.Text = "Score";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(170, 136);
            this.score.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(82, 20);
            this.score.TabIndex = 30;
            this.score.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(258, 110);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 20);
            this.button16.TabIndex = 29;
            this.button16.Text = "Squad Point";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // squad
            // 
            this.squad.Location = new System.Drawing.Point(170, 110);
            this.squad.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.squad.Name = "squad";
            this.squad.Size = new System.Drawing.Size(82, 20);
            this.squad.TabIndex = 28;
            this.squad.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(258, 84);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 20);
            this.button17.TabIndex = 27;
            this.button17.Text = "Misses";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // misses
            // 
            this.misses.Location = new System.Drawing.Point(170, 84);
            this.misses.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.misses.Name = "misses";
            this.misses.Size = new System.Drawing.Size(82, 20);
            this.misses.TabIndex = 26;
            this.misses.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(258, 58);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 20);
            this.button12.TabIndex = 25;
            this.button12.Text = "Hits";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // hits
            // 
            this.hits.Location = new System.Drawing.Point(170, 58);
            this.hits.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.hits.Name = "hits";
            this.hits.Size = new System.Drawing.Size(82, 20);
            this.hits.TabIndex = 24;
            this.hits.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(258, 32);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 20);
            this.button13.TabIndex = 23;
            this.button13.Text = "Games Played";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // games
            // 
            this.games.Location = new System.Drawing.Point(170, 32);
            this.games.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(82, 20);
            this.games.TabIndex = 22;
            this.games.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(258, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 20);
            this.button14.TabIndex = 21;
            this.button14.Text = "Losses";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // losses
            // 
            this.losses.Location = new System.Drawing.Point(170, 6);
            this.losses.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(82, 20);
            this.losses.TabIndex = 20;
            this.losses.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(94, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 20);
            this.button9.TabIndex = 19;
            this.button9.Tag = "";
            this.button9.Text = "Wins";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // wins
            // 
            this.wins.Location = new System.Drawing.Point(6, 136);
            this.wins.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(82, 20);
            this.wins.TabIndex = 18;
            this.wins.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(94, 110);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 20);
            this.button10.TabIndex = 17;
            this.button10.Text = "Killstreak";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // killstreak
            // 
            this.killstreak.Location = new System.Drawing.Point(6, 110);
            this.killstreak.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.killstreak.Name = "killstreak";
            this.killstreak.Size = new System.Drawing.Size(82, 20);
            this.killstreak.TabIndex = 16;
            this.killstreak.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(94, 84);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 20);
            this.button11.TabIndex = 15;
            this.button11.Text = "Deaths";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // deaths
            // 
            this.deaths.Location = new System.Drawing.Point(6, 84);
            this.deaths.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.deaths.Name = "deaths";
            this.deaths.Size = new System.Drawing.Size(82, 20);
            this.deaths.TabIndex = 14;
            this.deaths.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(94, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 20);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kills";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kills
            // 
            this.kills.Location = new System.Drawing.Point(6, 58);
            this.kills.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.kills.Name = "kills";
            this.kills.Size = new System.Drawing.Size(82, 20);
            this.kills.TabIndex = 12;
            this.kills.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(94, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 20);
            this.button7.TabIndex = 11;
            this.button7.Text = "XP";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(6, 32);
            this.xp.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(82, 20);
            this.xp.TabIndex = 10;
            this.xp.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(94, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 20);
            this.button8.TabIndex = 9;
            this.button8.Text = "Prestige";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // prestige
            // 
            this.prestige.Location = new System.Drawing.Point(6, 6);
            this.prestige.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.prestige.Name = "prestige";
            this.prestige.Size = new System.Drawing.Size(82, 20);
            this.prestige.TabIndex = 8;
            this.prestige.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.ac.Enabled = false;
            this.ac.Location = new System.Drawing.Point(87, 26);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(116, 17);
            this.ac.TabIndex = 2;
            this.ac.Text = "Active Connection:";
            this.ac.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ban Bypass";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Get Clients";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kick Client(s)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.ac);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connectivity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(231, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 58);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bypass";
            // 
            // ClientsTab
            // 
            this.ClientsTab.Controls.Add(this.groupBox6);
            this.ClientsTab.Controls.Add(this.groupBox5);
            this.ClientsTab.Controls.Add(this.groupBox2);
            this.ClientsTab.Location = new System.Drawing.Point(4, 22);
            this.ClientsTab.Name = "ClientsTab";
            this.ClientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsTab.Size = new System.Drawing.Size(332, 167);
            this.ClientsTab.TabIndex = 3;
            this.ClientsTab.Text = "Client";
            this.ClientsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button23);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Location = new System.Drawing.Point(119, 117);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(207, 44);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "mFlags";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(133, 18);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(68, 20);
            this.button23.TabIndex = 16;
            this.button23.Text = "Set";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "No-Clip",
            "Freeze",
            "UFO"});
            this.comboBox1.Location = new System.Drawing.Point(8, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Normal";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button22);
            this.groupBox5.Controls.Add(this.speed);
            this.groupBox5.Controls.Add(this.button21);
            this.groupBox5.Controls.Add(this.wallhack);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.fov);
            this.groupBox5.Location = new System.Drawing.Point(119, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 105);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Variables";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(133, 71);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(68, 20);
            this.button22.TabIndex = 15;
            this.button22.Text = "Speed";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(8, 71);
            this.speed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(119, 20);
            this.speed.TabIndex = 14;
            this.speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(133, 45);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(68, 20);
            this.button21.TabIndex = 13;
            this.button21.Text = "Wallhack";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // wallhack
            // 
            this.wallhack.Location = new System.Drawing.Point(8, 45);
            this.wallhack.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.wallhack.Name = "wallhack";
            this.wallhack.Size = new System.Drawing.Size(119, 20);
            this.wallhack.TabIndex = 12;
            this.wallhack.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(133, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 20);
            this.button6.TabIndex = 11;
            this.button6.Text = "FOV";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // fov
            // 
            this.fov.Location = new System.Drawing.Point(8, 19);
            this.fov.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fov.Name = "fov";
            this.fov.Size = new System.Drawing.Size(119, 20);
            this.fov.TabIndex = 10;
            this.fov.Value = new decimal(new int[] {
            39,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button37);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toggles";
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(6, 132);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(92, 20);
            this.button37.TabIndex = 17;
            this.button37.Text = "Achievements";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 111);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(70, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Adv UAV";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 88);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(92, 17);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Tiny Crosshair";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 65);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(74, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "Redboxes";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 42);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(70, 17);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "Invisibility";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 19);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(72, 17);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Godmode";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // TogglesTab
            // 
            this.TogglesTab.Controls.Add(this.groupBox1);
            this.TogglesTab.Controls.Add(this.offhost);
            this.TogglesTab.Location = new System.Drawing.Point(4, 22);
            this.TogglesTab.Name = "TogglesTab";
            this.TogglesTab.Padding = new System.Windows.Forms.Padding(3);
            this.TogglesTab.Size = new System.Drawing.Size(332, 167);
            this.TogglesTab.TabIndex = 0;
            this.TogglesTab.Text = "Toggles";
            this.TogglesTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox21);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Location = new System.Drawing.Point(219, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On-Host Mods";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "No Fall Damage";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Third Person";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(81, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Knockback";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Full Auto";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(89, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Infinite Ammo";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // offhost
            // 
            this.offhost.Controls.Add(this.checkBox20);
            this.offhost.Controls.Add(this.comboBox2);
            this.offhost.Controls.Add(this.uav);
            this.offhost.Controls.Add(this.norecoil);
            this.offhost.Controls.Add(this.chams);
            this.offhost.Controls.Add(this.laser);
            this.offhost.Controls.Add(this.redbox);
            this.offhost.Location = new System.Drawing.Point(6, 6);
            this.offhost.Name = "offhost";
            this.offhost.Size = new System.Drawing.Size(207, 155);
            this.offhost.TabIndex = 0;
            this.offhost.TabStop = false;
            this.offhost.Text = "Off-Host Mods";
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(107, 19);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(99, 17);
            this.checkBox20.TabIndex = 7;
            this.checkBox20.Text = "Chrome Players";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Chams Color",
            "Body",
            "White",
            "White + Body",
            "Red",
            "Red + Body",
            "Green",
            "Green + Body",
            "Blue",
            "Blue + Body",
            "Orange",
            "Orange + Body",
            "Yellow",
            "Yellow + Body"});
            this.comboBox2.Location = new System.Drawing.Point(6, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Chams Color";
            // 
            // uav
            // 
            this.uav.AutoSize = true;
            this.uav.Location = new System.Drawing.Point(6, 88);
            this.uav.Name = "uav";
            this.uav.Size = new System.Drawing.Size(48, 17);
            this.uav.TabIndex = 5;
            this.uav.Text = "UAV";
            this.uav.UseVisualStyleBackColor = true;
            this.uav.CheckedChanged += new System.EventHandler(this.uav_CheckedChanged);
            // 
            // norecoil
            // 
            this.norecoil.AutoSize = true;
            this.norecoil.Location = new System.Drawing.Point(6, 65);
            this.norecoil.Name = "norecoil";
            this.norecoil.Size = new System.Drawing.Size(73, 17);
            this.norecoil.TabIndex = 4;
            this.norecoil.Text = "No Recoil";
            this.norecoil.UseVisualStyleBackColor = true;
            this.norecoil.CheckedChanged += new System.EventHandler(this.norecoil_CheckedChanged);
            // 
            // chams
            // 
            this.chams.AutoSize = true;
            this.chams.Location = new System.Drawing.Point(6, 136);
            this.chams.Name = "chams";
            this.chams.Size = new System.Drawing.Size(58, 17);
            this.chams.TabIndex = 2;
            this.chams.Text = "Chams";
            this.chams.UseVisualStyleBackColor = true;
            this.chams.CheckedChanged += new System.EventHandler(this.chams_CheckedChanged);
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
            this.laser.CheckedChanged += new System.EventHandler(this.laser_CheckedChanged);
            // 
            // redbox
            // 
            this.redbox.AutoSize = true;
            this.redbox.Location = new System.Drawing.Point(6, 19);
            this.redbox.Name = "redbox";
            this.redbox.Size = new System.Drawing.Size(74, 17);
            this.redbox.TabIndex = 0;
            this.redbox.Text = "Redboxes";
            this.redbox.UseVisualStyleBackColor = true;
            this.redbox.CheckedChanged += new System.EventHandler(this.redbox_CheckedChanged);
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.TogglesTab);
            this.tabcontrol1.Controls.Add(this.ClientsTab);
            this.tabcontrol1.Controls.Add(StatsTab);
            this.tabcontrol1.Controls.Add(this.Misc1Tab);
            this.tabcontrol1.Controls.Add(this.Misc2Tab);
            this.tabcontrol1.Controls.Add(this.Misc3Tab);
            this.tabcontrol1.Controls.Add(this.NewTab);
            this.tabcontrol1.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(340, 193);
            this.tabcontrol1.TabIndex = 4;
            // 
            // Misc1Tab
            // 
            this.Misc1Tab.Controls.Add(this.groupBox12);
            this.Misc1Tab.Controls.Add(this.groupBox11);
            this.Misc1Tab.Controls.Add(this.groupBox10);
            this.Misc1Tab.Location = new System.Drawing.Point(4, 22);
            this.Misc1Tab.Name = "Misc1Tab";
            this.Misc1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Misc1Tab.Size = new System.Drawing.Size(332, 167);
            this.Misc1Tab.TabIndex = 5;
            this.Misc1Tab.Text = "Misc";
            this.Misc1Tab.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.poi);
            this.groupBox12.Controls.Add(this.button33);
            this.groupBox12.Controls.Add(this.gt);
            this.groupBox12.Location = new System.Drawing.Point(9, 114);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(317, 48);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Gamertag";
            // 
            // poi
            // 
            this.poi.FormattingEnabled = true;
            this.poi.Items.AddRange(new object[] {
            "In-Game",
            "Pre-Game"});
            this.poi.Location = new System.Drawing.Point(140, 19);
            this.poi.Name = "poi";
            this.poi.Size = new System.Drawing.Size(93, 21);
            this.poi.TabIndex = 13;
            this.poi.Text = "In-Game";
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(239, 19);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(72, 20);
            this.button33.TabIndex = 11;
            this.button33.Text = "Send";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // gt
            // 
            this.gt.Location = new System.Drawing.Point(6, 19);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(128, 20);
            this.gt.TabIndex = 0;
            this.gt.Text = "Gamertag";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button32);
            this.groupBox11.Controls.Add(this.model);
            this.groupBox11.Location = new System.Drawing.Point(9, 60);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(317, 48);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Model";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(239, 19);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(72, 21);
            this.button32.TabIndex = 11;
            this.button32.Text = "Send";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Items.AddRange(new object[] {
            "void",
            "tag_ik_target",
            "weapon_sc2010_gold",
            "defaultvehicle",
            "viewmodel_reticle_standard_02",
            "ims_scorpion_explosive_iw6",
            "viewmodel_cz_805_bren",
            "viewmodel_default",
            "defaultweapon",
            "vfx_metal_fracture_piece_small_28",
            "weapon_msbs_gold",
            "ac_prs_prp_metal_debris_a_13",
            "weapon_msbs",
            "weapon_reflex_vmr",
            "ac_prs_prp_metal_debris_a_14",
            "veh_aas72x_tailpiece1_1s",
            "veh_battle_hind_wing_leftpiece2_1s",
            "veh_apache_wing_right_1s",
            "veh_apache_wing_left_pc1_1s",
            "vfx_metal_fracture_piece_med_09",
            "vfx_metal_fracture_piece_med_08",
            "vfx_metal_fracture_piece_med_07",
            "vfx_metal_fracture_piece_med_06",
            "vfx_metal_fracture_piece_med_05",
            "veh_apache_bodypiece02_1s",
            "veh_apache_wing_left_1s",
            "veh_apache_rotor_main_1s",
            "veh_apache_bodypiece01_1s",
            "veh_apache_body_1s",
            "vfx_metal_fracture_piece_med_01",
            "weapon_remington_r5rgp",
            "weapon_us_smoke_grenade_burnt",
            "veh_aas72x_bodypiece03_1s",
            "weapon_acog_iw6",
            "weapon_stow_mid_up",
            "weapon_ak12_gold",
            "weapon_ak12",
            "viewmodel_ak12_camo",
            "vfx_metal_fracture_piece_small_09",
            "ac_prs_prp_metal_debris_a_11",
            "veh_apache_bodypiece05_1s",
            "vfx_metal_fracture_piece_small_24",
            "vfx_metal_fracture_piece_small_23",
            "vfx_metal_fracture_piece_small_22",
            "vfx_metal_fracture_piece_small_21",
            "vfx_metal_fracture_piece_small_20",
            "viewmodel_grenade_launcher_no_cover",
            "viewmodel_reticle_acog_02",
            "veh_battle_hind_wing_left_1p",
            "vehicle_odin_mp",
            "vehicle_skylark",
            "vehicle_drone_backup_buddy_gun",
            "vehicle_drone_backup_buddy",
            "projectile_at4",
            "vfx_metal_fracture_piece_small_19",
            "vehicle_mi17_woodland_d_piece01",
            "weapon_fad_iw6_camo",
            "veh_aas72x_bodypiece10_1s",
            "veh_battle_hind_bodypiece01_2p",
            "ims_scorpion_body_iw6_bombsquad",
            "viewmodel_sc2010_camo",
            "ims_scorpion_body_iw6_placement_failed",
            "veh_battle_hind_bodypiece06_2p",
            "viewmodel_fad_iw6",
            "ac_prs_prp_metal_debris_a_04",
            "vfx_metal_fracture_piece_small_25",
            "vehicle_aas_72x_killstreak",
            "viewmodel_eotech_pwr_reader",
            "viewmodel_reticle_clan_01",
            "weapon_target_finder",
            "weapon_maul_attachment",
            "viewmodel_maul_attachement",
            "projectile_tag",
            "viewmodel_reticle_hybrid_01",
            "fx_rifle_shell_blur",
            "veh_battle_hind_wing_leftpiece3_1p",
            "viewmodel_reticle_hybrid_02",
            "veh_battle_hind_tailpiece2_1p",
            "vfx_metal_fracture_piece_small_16",
            "veh_apache_tailpiece3_1s",
            "vfx_metal_fracture_piece_small_15",
            "weapon_knife_iw6",
            "veh_apache_tailpiece2_1s",
            "weapon_thermal_hybrid",
            "vfx_metal_fracture_piece_small_11",
            "veh_apache_bodypiece11_1s",
            "vfx_metal_fracture_piece_small_10",
            "veh_aas72x_bodypiece02_1s",
            "veh_apache_tailpiece1_1s",
            "weapon_sc2010",
            "viewmodel_reticle_reflex_01",
            "ac_prs_prp_metal_debris_a_06",
            "viewmodel_reticle_reflex_default",
            "veh_apache_bodypiece12_1s",
            "ac_prs_prp_metal_debris_a_07",
            "viewmodel_ak12",
            "veh_aas72x_tail_1s",
            "placeable_barrier",
            "veh_aas72x_tailpiece2_1s",
            "veh_battle_hind_tailpiece1_1p",
            "placeable_barrier_destroyed",
            "veh_aas72x_bodypiece08_1s",
            "veh_battle_hind_rotor_lower_2s",
            "weapon_honeybadger_gold",
            "vfx_metal_fracture_piece_small_29",
            "weapon_honeybadger",
            "ac_prs_prp_metal_debris_a_01",
            "vfx_metal_fracture_piece_med_00",
            "placeable_barrier_obj",
            "prop_flag_neutral",
            "viewmodel_sc2010_gold",
            "vehicle_drone_vanguard_gun",
            "viewmodel_reticle_hybrid_03",
            "weapon_sc2010_camo",
            "viewmodel_reticle_hybrid_04",
            "veh_battle_hind_camerastand_2s",
            "weapon_msbs_camo",
            "veh_battle_hind_body_2s",
            "weapon_sentry_chaingun_obj",
            "viewmodel_msbs_camo",
            "viewmodel_flash_supressor_ar",
            "veh_aas72x_wing_left_1s",
            "viewmodel_reticle_hybrid_default",
            "vfx_metal_fracture_piece_small_05",
            "viewmodel_variable_zoom_relfex",
            "ims_scorpion_body_iw6",
            "vfx_metal_fracture_piece_small_06",
            "vfx_metal_fracture_piece_small_04",
            "veh_battle_hind_wing_leftpiece2_1p",
            "viewmodel_reticle_eotech_02",
            "veh_battle_hind_wing_leftpiece1_1p",
            "viewmodel_reticle_acog_01",
            "viewmodel_reticle_eotech_03",
            "viewmodel_remington_r5rgp_gold",
            "viewmodel_arx_160",
            "vfx_metal_fracture_piece_med_19",
            "fx_space_shell",
            "veh_aas72x_bodypiece09_1s",
            "ac_prs_prp_metal_debris_a_10",
            "viewmodel_cz_805_bren_gold",
            "projectile_m203grenade",
            "weapon_reflex_reddot",
            "placeable_barrier_obj_red",
            "veh_apache_tailpiece5_1s",
            "viewmodel_reddot_reflex_iw6",
            "vfx_metal_fracture_piece_small_07",
            "veh_battle_hind_bodypiece01_2s",
            "viewmodel_base_viewhands",
            "ac_prs_prp_metal_debris_a_15",
            "weapon_cz_805_bren",
            "viewmodel_knife_iw6",
            "veh_battle_hind_body_2p",
            "vfx_metal_fracture_piece_med_18",
            "viewmodel_msbs",
            "vfx_metal_fracture_piece_med_17",
            "weapon_briefcase_bomb_iw6",
            "viewmodel_msbs_gold",
            "vfx_metal_fracture_piece_small_14",
            "veh_battle_hind_bodypiece03_2s",
            "viewmodel_target_finder",
            "veh_battle_hind_bodypiece02_2s",
            "viewmodel_reticle_standard_05",
            "weapon_grenade_launcher_iw6",
            "viewmodel_briefcase_bomb_mp_iw6",
            "viewmodel_reticle_eotech_default",
            "veh_aas72x_bodypiece01_1s",
            "weapon_eotech_pwr_reader",
            "viewmodel_reticle_reflex_05",
            "veh_aas72x_bodypiece11_1s",
            "viewmodel_reticle_hybrid_05",
            "vfx_metal_fracture_piece_small_18",
            "veh_apache_rotor_tail_1s",
            "vfx_metal_fracture_piece_small_17",
            "viewmodel_kriss_gold",
            "veh_apache_bodypiece09_1s",
            "projectile_hellfire_missile",
            "viewmodel_reticle_eotech_05",
            "ac_prs_prp_metal_debris_a_05",
            "weapon_kriss_v_gold",
            "weapon_cz_805_bren_camo",
            "weapon_kriss_v",
            "veh_battle_hind_tail_1s",
            "viewmodel_cz_805_bren_camo",
            "veh_battle_hind_tail_1p",
            "weapon_pp19_bizon_iw6_camo",
            "veh_battle_hind_tailpiece2_1s",
            "veh_battle_hind_gun_pivot_2s",
            "veh_apache_bodypiece07_1s",
            "vehicle_drone_vanguard",
            "veh_apache_rotor_t3_1s",
            "vehicle_a10_warthog_iw6_mp",
            "viewmodel_reticle_standard_03",
            "veh_aas72x_body_1s",
            "weapon_remington_r5rgp_gold",
            "viewmodel_reticle_eotech_04",
            "vfx_metal_fracture_piece_small_01",
            "vfx_metal_fracture_piece_small_03",
            "viewmodel_reticle_reflex_03",
            "vfx_metal_fracture_piece_small_02",
            "veh_battle_hind_bodypiece03_2p",
            "viewmodel_reticle_reflex_04",
            "viewmodel_pp19_bizon_iw6_gold",
            "veh_battle_hind_wing_left_1s",
            "ac_prs_prp_metal_debris_a_09",
            "vfx_metal_fracture_piece_small_27",
            "viewmodel_muzzle_break_ar",
            "vfx_metal_fracture_piece_small_26",
            "viewmodel_reticle_standard_01",
            "weapon_flash_suppressor_iw6_ar",
            "vehicle_fracture_piece_01",
            "weapon_muzzle_brake_iw6_ar",
            "weapon_ak12_camo",
            "veh_aas72x_rotor_main_1s",
            "weapon_sentry_chaingun_obj_red",
            "veh_battle_hind_bodypiece06_2s",
            "veh_apache_bodypiece06_1s",
            "veh_battle_hind_bodypiece04_2s",
            "viewmodel_honeybadger",
            "vehicle_fracture_piece_06",
            "veh_aas72x_bodypiece04_1s",
            "vfx_metal_fracture_piece_small_12",
            "fx_pistol_shell_blur",
            "vfx_metal_fracture_piece_med_14",
            "veh_apache_bodypiece08_1s",
            "vehicle_ac130_low_mp",
            "vehicle_battle_hind",
            "veh_ball_drone_pc04_p1",
            "projectile_javelin_missile",
            "viewmodel_folding_grip",
            "veh_battle_hind_rotor_lower_2p",
            "weapon_cz_805_bren_gold",
            "vfx_metal_fracture_piece_med_04",
            "veh_aas72x_bodypiece05_1s",
            "veh_aas72x_bodypiece07_1s",
            "veh_apache_bodypiece03_1s",
            "veh_aas72x_bodypiece06_1s",
            "viewmodel_reticle_eotech_01",
            "veh_apache_bodypiece04_1s",
            "veh_battle_hind_bodypiece02_2p",
            "viewmodel_remington_r5rgp",
            "weapon_sentry_chaingun",
            "viewmodel_kriss_camo",
            "veh_battle_hind_bodypiece05_2s",
            "weapon_kriss_v_camo",
            "vfx_metal_fracture_piece_med_16",
            "veh_battle_hind_bodypiece07_2s",
            "vehicle_ball_drone_iw6",
            "veh_apache_rotor_m1_1s",
            "viewmodel_remington_r5rgp_camo",
            "weapon_fad_iw6_gold",
            "ac_prs_prp_metal_debris_a_02",
            "weapon_fad_iw6",
            "viewmodel_reticle_reflex_02",
            "ac_prs_prp_metal_debris_a_03",
            "viewmodel_fad_iw6_gold",
            "vfx_metal_fracture_piece_med_03",
            "veh_battle_hind_bodypiece04_2p",
            "vfx_metal_fracture_piece_med_02",
            "veh_battle_hind_tailpiece1_1s",
            "veh_battle_hind_bodypiece05_2p",
            "ac_prs_prp_metal_debris_a_12",
            "viewmodel_reticle_acog_default",
            "weapon_arx_160_camo",
            "viewmodel_acog_iw6",
            "viewmodel_thermal_hybrid",
            "viewmodel_arx_160_camo",
            "veh_battle_hind_bodypiece08_2s",
            "veh_battle_hind_wing_leftpiece3_1s",
            "veh_battle_hind_bodypiece08_2p",
            "vfx_metal_fracture_piece_med_11",
            "viewmodel_silencer_pitted_medium",
            "vfx_metal_fracture_piece_med_10",
            "viewmodel_honeybadger_gold",
            "viewmodel_sc2010",
            "veh_battle_hind_wing_leftpiece1_1s",
            "weapon_silencer_pitted_medium",
            "weapon_foregrip_folding",
            "viewmodel_reticle_acog_03",
            "weapon_arx_160_gold",
            "vfx_metal_fracture_piece_med_12",
            "viewmodel_grenade_launcher",
            "weapon_sentry_chaingun_destroyed",
            "viewmodel_pp19_bizon_iw6",
            "fx_space_shell_blur",
            "veh_aas72x_wing_right_pc1_1s",
            "weapon_remington_r5rgp_camo",
            "veh_aas72x_wing_right_1s",
            "viewmodel_arx_160_gold",
            "vfx_metal_fracture_piece_med_15",
            "veh_ball_drone_pc03_p1",
            "weapon_stow_mid",
            "weapon_sentry_chaingun_bombsquad",
            "vfx_metal_fracture_piece_small_13",
            "vfx_metal_fracture_piece_med_13",
            "viewmodel_kriss",
            "viewmodel_ak12_gold",
            "vfx_metal_fracture_piece_small_00",
            "veh_battle_hind_bodypiece07_2p",
            "ims_scorpion_body_iw6_placement",
            "ac_prs_prp_metal_debris_a_08",
            "vfx_metal_fracture_piece_small_08",
            "viewmodel_reticle_standard_04",
            "weapon_arx_160",
            "viewmodel_reticle_acog_05",
            "weapon_honeybadger_camo",
            "viewmodel_reticle_acog_04",
            "viewmodel_fad_iw6_camo",
            "viewmodel_honeybadger_camo",
            "fx_glass_piece01",
            "fx_glass_piece02",
            "fx_icicle_piece_1",
            "fx_icicle_piece_2",
            "fx_flesh_chunk_01",
            "fx_wood_splinter01_nosound",
            "fx_wood_splinter02_nosound",
            "fx_wood_splinter01",
            "fx_wood_splinter02",
            "fx_rifle_shell",
            "mil_bullet",
            "fx_pistol_shell",
            "fx_bullet_chain",
            "fx_shotgun_shell",
            "fx",
            "fx_me_brick_01",
            "fx_me_brick_01_piece01",
            "fx_me_brick_01_piece02",
            "fx_rock_small",
            "fx_glass_piece_large_01",
            "fx_glass_piece_large_02",
            "fx_glass_piece_large_03",
            "fx_metal_piece02_distant",
            "projectile_cbu97_clusterbomb_tail",
            "projectile_cbu97_clusterbomb_shell",
            "ch_rubble_chunk01",
            "ch_rubble_chunk02",
            "chunk_03",
            "me_stone_block01",
            "me_stone_block02",
            "me_stone_block03",
            "projectile_cbu97_clusterbomb",
            "tag_origin",
            "projectile_bouncing_betty_trigger",
            "fx_metal_piece01",
            "fx_metal_piece02",
            "defaultactor",
            "viewmodel_pp19_bizon_iw6_camo",
            "test_sphere_silver",
            "test_sphere_redchrome",
            "tag_player",
            "prop_dogtags_friend_iw6",
            "weapon_smart_phone_iw6",
            "weapon_pp19_bizon_iw6",
            "weapon_pp19_bizon_iw6_gold",
            "viewmodel_vepr",
            "viewmodel_vepr_gold",
            "weapon_vepr_camo",
            "viewmodel_vepr_camo",
            "weapon_vepr",
            "weapon_vepr_gold",
            "viewmodel_tar21",
            "viewmodel_tar21_gold",
            "weapon_tar21_camo",
            "viewmodel_tar21_camo",
            "weapon_tar21",
            "weapon_tar21_gold",
            "viewmodel_cbj_ms_iw6",
            "viewmodel_cbj_ms_iw6_gold",
            "weapon_cbj_ms_iw6_camo",
            "viewmodel_cbj_ms_iw6_camo",
            "weapon_cbj_ms_iw6",
            "weapon_cbj_ms_iw6_gold",
            "viewmodel_k7",
            "viewmodel_k7_gold",
            "weapon_k7_camo",
            "viewmodel_k7_camo",
            "weapon_k7",
            "weapon_k7_gold",
            "fx_bullet_chain_blur",
            "viewmodel_m27",
            "viewmodel_m27_gold",
            "weapon_m27_camo",
            "viewmodel_m27_camo",
            "weapon_m27",
            "weapon_m27_gold",
            "viewmodel_ameli",
            "viewmodel_ameli_gold",
            "weapon_ameli_camo",
            "viewmodel_ameli_camo",
            "weapon_ameli",
            "weapon_ameli_gold",
            "viewmodel_lsat",
            "viewmodel_lsat_gold",
            "weapon_lsat_iw6_camo",
            "viewmodel_lsat_camo",
            "weapon_lsat_iw6",
            "weapon_lsat_iw6_gold",
            "viewmodel_kac_chainsaw",
            "viewmodel_kac_chainsaw_gold",
            "weapon_kac_chainsaw_camo",
            "viewmodel_kac_chainsaw_camo",
            "weapon_kac_chainsaw",
            "weapon_kac_chainsaw_gold",
            "viewmodel_minigun_iw6",
            "weapon_minigun_iw6",
            "viewmodel_vks",
            "viewmodel_vks_gold",
            "weapon_vks_camo",
            "viewmodel_vks_camo",
            "weapon_vks",
            "weapon_vks_gold",
            "weapon_vks_scope",
            "viewmodel_vks_scope",
            "weapon_silencer_pitted_large",
            "viewmodel_silencer_pitted_large",
            "viewmodel_gm6",
            "viewmodel_gm6_gold",
            "weapon_gm6_camo",
            "viewmodel_gm6_camo",
            "weapon_gm6",
            "weapon_gm6_gold",
            "weapon_gm6_scope",
            "viewmodel_gm6_scope",
            "viewmodel_usr",
            "viewmodel_usr_gold",
            "weapon_usr_camo",
            "viewmodel_usr_camo",
            "weapon_usr",
            "weapon_usr_gold",
            "weapon_usr_scope",
            "viewmodel_usr_scope_mp",
            "viewmodel_l115a3",
            "viewmodel_l115a3_gold",
            "weapon_l115a3_camo",
            "viewmodel_l115a3_camo",
            "weapon_l115a3",
            "weapon_l115a3_gold",
            "weapon_l115a3_scope",
            "viewmodel_l115a3_scope_mp",
            "weapon_l115a3_silencer",
            "viewmodel_l115a3_silencer",
            "viewmodel_imbel_ia2",
            "viewmodel_imbel_ia2_gold",
            "weapon_imbel_ia2_camo",
            "viewmodel_imbel_ia2_camo",
            "weapon_imbel_ia2",
            "weapon_imbel_ia2_gold",
            "weapon_imbel_ia2_scope",
            "viewmodel_imbel_ia2_scope",
            "weapon_muzzle_brake_iw6_sniper",
            "viewmodel_muzzle_break_sniper",
            "viewmodel_flash_supressor_sniper",
            "viewmodel_dragunov_svu",
            "viewmodel_dragunov_svu_gold",
            "weapon_dragunov_svu_camo",
            "viewmodel_dragunov_svu_camo",
            "weapon_dragunov_svu",
            "weapon_dragunov_svu_gold",
            "weapon_dragunov_svu_scope",
            "viewmodel_dragunov_svu_scope",
            "viewmodel_g28",
            "viewmodel_g28_gold",
            "weapon_g28_camo",
            "viewmodel_g28_camo",
            "weapon_g28",
            "weapon_g28_gold",
            "weapon_g28_scope",
            "viewmodel_g28_scope",
            "viewmodel_mk14_ebr",
            "viewmodel_mk14_ebr_gold",
            "weapon_mk14_ebr_iw6_camo",
            "viewmodel_mk14_ebr_camo",
            "weapon_mk14_ebr_iw6",
            "weapon_mk14_ebr_iw6_gold",
            "weapon_mk14_ebr_iw6_clip_scope",
            "viewmodel_mk14_ebr_scope",
            "viewmodel_mts_255",
            "viewmodel_mts_255_gold",
            "weapon_mts_255_camo",
            "viewmodel_mts_255_camo",
            "weapon_mts_255",
            "weapon_mts_255_gold",
            "fx_shotgun_shell_blur",
            "viewmodel_fabarm_fp6",
            "viewmodel_fabarm_fp6_gold",
            "weapon_fabarm_fp6_camo",
            "viewmodel_fabarm_fp6_camo",
            "weapon_fabarm_fp6",
            "weapon_fabarm_fp6_gold",
            "viewmodel_maul",
            "viewmodel_maul_gold",
            "weapon_maul_camo",
            "viewmodel_maul_camo",
            "weapon_maul",
            "weapon_maul_gold",
            "weapon_silencer_pitted_small",
            "viewmodel_silencer_pitted_small",
            "viewmodel_uts_15",
            "viewmodel_uts_15_gold",
            "weapon_uts_15_camo",
            "viewmodel_uts_15_camo",
            "weapon_uts_15",
            "weapon_uts_15_gold",
            "viewmodel_p226",
            "weapon_p226",
            "weapon_muzzle_brake_iw6_pistol",
            "viewmodel_muzzle_break_pistols",
            "weapon_flash_suppressor_iw6_pistol",
            "viewmodel_flash_supressor_pistol",
            "weapon_silencer_pistol_angular",
            "viewmodel_silencer_pistol_angular",
            "viewmodel_m9a1_iw6",
            "weapon_m9a1_iw6",
            "viewmodel_mp443",
            "weapon_mp443",
            "viewmodel_magum_iw6",
            "weapon_magnum_iw6",
            "viewmodel_vbr_pdw",
            "weapon_vbr",
            "viewmodel_kastet",
            "weapon_kastet",
            "weapon_panzerfaust3_missle",
            "viewmodel_panzerfaust3",
            "weapon_panzerfaust3",
            "viewmodel_panzerfaust3_missle",
            "viewmodel_mk14",
            "weapon_mk14_iw6",
            "viewmodel_maaws",
            "weapon_maaws",
            "projectile_smaw",
            "weapon_smaw_stow",
            "viewmodel_riot_shield",
            "viewmodel_riot_shield_gold",
            "weapon_riot_shield_iw6_camo",
            "viewmodel_riot_shield_camo",
            "weapon_riot_shield_iw6",
            "weapon_riot_shield_iw6_gold",
            "viewmodel_knife_jugmaniac",
            "viewmodel_ak47",
            "weapon_claymore",
            "weapon_ak47_clip",
            "weapon_ak74u_clip",
            "weapon_dragunov_clip",
            "weapon_g3_clip",
            "weapon_g36_clip",
            "weapon_m14_clip",
            "weapon_m16_clip",
            "weapon_mp5_clip",
            "weapon_saw_clip",
            "viewmodel_uav_radio",
            "viewmodel_uav_control_unit_iw6",
            "weapon_uav_control_unit_iw6",
            "viewmodel_smoke_grenade_iw6",
            "weapon_smoke_grenade_iw6",
            "prop_ballistic_vest_iw6_viewmodel",
            "prop_ballistic_vest_iw6",
            "viewmodel_weapon_crate",
            "mp_weapon_crate",
            "projectile_sidewinder_missile",
            "viewmodel_uav_control_unit",
            "weapon_uav_control_unit",
            "mp_switchblade",
            "mp_satcom",
            "mp_satcom_obj",
            "mp_satcom_obj_red",
            "mp_satcom_bombsquad",
            "viewmodel_flare_iw6",
            "emergency_flare_iw6",
            "viewmodel_m67",
            "weapon_m67_grenade",
            "projectile_m67fraggrenade",
            "weapon_c4_iw6_bombsquad",
            "projectile_m67fraggrenade_bombsquad",
            "weapon_semtex_grenade_iw6_bombsquad",
            "projectile_semtex_grenade_bombsquad",
            "weapon_light_stick_tactical_bombsquad",
            "mp_proximity_explosive_bombsquad",
            "weapon_canister_bomb_bombsquad",
            "prop_ballistic_vest_iw6_bombsquad",
            "mp_weapon_crate_bombsquad",
            "weapon_thermobaric_grenade_bombsquad",
            "mp_trophy_system_iw6_bombsquad",
            "mp_trophy_system_iw6",
            "viewmodel_semtex_grenade_iw6",
            "weapon_semtex_grenade_iw6",
            "projectile_semtex_grenade",
            "viewmodel_canister_bomb",
            "weapon_canister_bomb_world",
            "weapon_canister_bomb",
            "viewmodel_c4_iw6",
            "weapon_c4_iw6_world",
            "weapon_c4_iw6",
            "mp_proximity_explosive_world",
            "mp_proximity_explosive",
            "viewmodel_trophy_system_iw6",
            "mp_trophy_system_folded_iw6",
            "viewmodel_twist_flashbang",
            "weapon_twist_flashbang",
            "weapon_m84_flashbang_grenade_burnt",
            "viewmodel_concussion_grenade_iw6",
            "weapon_concussion_grenade_iw6",
            "viewmodel_motion_sensor",
            "weapon_motion_sensor",
            "viewmodel_thermobaric_grenade",
            "weapon_thermobaric_grenade",
            "weapon_scavenger_grenadebag",
            "veh_ball_drone_pc01_s1",
            "veh_ball_drone_pc02_s1",
            "veh_ball_drone_pc03_s1",
            "veh_ball_drone_pc04_s1",
            "veh_ball_drone_pc05_s1",
            "veh_ball_drone_pc06_s1",
            "veh_ball_drone_pc07_s1",
            "veh_ball_drone_pc01_p1",
            "veh_ball_drone_pc02_p1",
            "veh_ball_drone_pc05_p1",
            "veh_ball_drone_pc06_p1",
            "veh_ball_drone_pc07_p1",
            "veh_vanguard_motor_s1",
            "veh_vanguard_arm1_s1",
            "veh_vanguard_arm2_s1",
            "veh_vanguard_arm3_s1",
            "veh_vanguard_arm4_s1",
            "veh_vanguard_blade1_s1",
            "veh_vanguard_blade2_s1",
            "veh_vanguard_blade3_s1",
            "veh_vanguard_stand_s1",
            "veh_vanguard_duct1_s1",
            "veh_vanguard_gun_s1",
            "veh_vanguard_duct2_s1",
            "veh_vanguard_duct3_s1",
            "veh_vanguard_fan1_s1",
            "veh_vanguard_fan2_s1",
            "veh_vanguard_fan3_s1",
            "veh_vanguard_fan4_s1",
            "veh_vanguard_motor_p1",
            "veh_vanguard_arm1_p1",
            "veh_vanguard_arm2_p1",
            "veh_vanguard_arm3_p1",
            "veh_vanguard_arm4_p1",
            "veh_vanguard_blade1_p1",
            "veh_vanguard_blade2_p1",
            "veh_vanguard_blade3_p1",
            "veh_vanguard_stand_p1",
            "veh_vanguard_duct1_p1",
            "veh_vanguard_gun_p1",
            "veh_vanguard_duct2_p1",
            "veh_vanguard_fan1_p1",
            "veh_vanguard_fan2_p1",
            "veh_vanguard_fan3_p1",
            "veh_vanguard_fan4_p1",
            "chunk_01",
            "chunk_02",
            "fx_cash02",
            "fx_cash01",
            "weapon_motion_sensor_bombsquad",
            "mp_fullbody_juggernaut_heavy_black",
            "viewhands_juggernaut_ally",
            "mp_body_juggernaut_light_black",
            "head_juggernaut_light_black",
            "mp_body_infected_a",
            "head_mp_infected",
            "viewhands_gs_hostage",
            "prop_dogtags_foe_iw6",
            "carepackage_dummy_iw6",
            "carepackage_friendly_iw6",
            "carepackage_enemy_iw6",
            "mp_juggernaut_carepackage_dummy",
            "mp_juggernaut_carepackage",
            "mp_juggernaut_carepackage_red",
            "weapon_riot_shield_jug_iw6",
            "viewmodel_riot_shield_mp",
            "weapon_us_smoke_grenade_burnt2",
            "mp_weapon_level_pickup_badge",
            "prop_mp_max_ammo_pickup",
            "weapon_ac130",
            "head_mp_head_a",
            "head_mp_head_ab",
            "head_mp_head_ac",
            "head_mp_head_ad",
            "mp_body_us_rangers_assault_a_arctic",
            "mp_body_us_rangers_assault_a_desert",
            "mp_body_us_rangers_assault_a_elite",
            "mp_body_us_rangers_assault_a_urban",
            "mp_body_us_rangers_assault_a_woodland",
            "viewhands_us_rangers_arctic",
            "viewhands_us_rangers_desert",
            "viewhands_us_rangers_elite",
            "viewhands_us_rangers_urban",
            "viewhands_us_rangers_woodland",
            "com_metal_briefcase_intel",
            "prop_flag_iw6_federation",
            "prop_flag_iw6_ghost",
            "mp_fullbody_dog_a",
            "com_debris_paper_single_brn_iw6_03",
            "fx_paper_sheet02_burn",
            "fx_cliff_piece_00",
            "fx_paper_sheet02",
            "fx_paper_sheet01",
            "office_paper_piece01_iw6",
            "office_paper_piece02_iw6",
            "fx_newsp_sheet_flat_wrinkled_02",
            "fx_newsp_sheet_flat_wrinkled_01",
            "fx_newsp_sheet_04",
            "fx_newsp_sheet_05",
            "fx_newsp_sheet_06",
            "fx_newsp_sheet_07",
            "fx_newsp_sheet_03",
            "trash_props_carton_juice_iw6",
            "trash_props_container_small2_iw6",
            "trash_props_cup_short1_iw6",
            "trash_props_cup_tall1_iw6",
            "trash_props_plate1_iw6",
            "trash_props_plate2_iw6",
            "trash_props_trash_can2_iw6",
            "trash_props_trash_can3_iw6",
            "trash_styrofoam_container6",
            "fx_cnd_bottle_05_bot",
            "fx_cnd_bottle_05_mid",
            "fx_cnd_bottle_05_top",
            "kitchen_glass01_wine_broken_bottom",
            "kitchen_glass01_wine_broken_mid1",
            "kitchen_glass01_wine_broken_top",
            "fx_cnd_bottle_02_bot",
            "fx_cnd_bottle_02_top",
            "fx_cnd_bottle_03_bot",
            "fx_cnd_bottle_03_mid",
            "fx_cnd_bottle_03_top",
            "fx_cnd_bottle_06_bot",
            "fx_cnd_bottle_06_top",
            "fx_cnd_bottle_10_bot",
            "fx_cnd_bottle_10_top",
            "com_plate_round1",
            "com_plasticcase_green_big_us_dirt",
            "mp_missile_bombsite_destroyed",
            "mp_missile_bombsite",
            "elevator_01",
            "vehicle_metro_bus_cabin_front",
            "vehicle_metro_bus_cabinmiddledamaged_1",
            "vehicle_metro_bus_2_seats_flipped",
            "vehicle_metro_bus_2_seats_w_rail",
            "vehicle_metro_bus_2_seats",
            "vehicle_metro_bus_tire_vegas",
            "vehicle_metro_bus_2_seats_w_rail_flipped",
            "vehicle_metro_bus_chair_1_seater",
            "vehicle_metro_bus_chair_side_metal_2",
            "prop_suitcase_bomb",
            "ac_prs_imp_foliage_gardenflowers_red_group",
            "curb_piece_01",
            "curb_piece_02",
            "beam_set_03",
            "rubble_chunk_07",
            "rubble_chunk_13",
            "rubble_chunk_08",
            "rubble_chunk_09",
            "beam_set_04",
            "rubble_chunk_12",
            "rubble_chunk_14",
            "ground_rubble_01",
            "sign_donut_01",
            "elevator_01_cable",
            "office_ceiling_pc_02",
            "office_ceiling_pc_07",
            "office_ceiling_pc_08",
            "pillar_dmg_01_long",
            "pillar_dmg_01_short",
            "pillar_dmg_01_lshapebend2",
            "pillar_dmg_01_thinbend",
            "pillar_dmg_01_lshapebend1",
            "pillar_dmg_concrete_01_long",
            "pillar_dmg_concrete_01_short",
            "rock_pile_01_set1",
            "rock_pile_01_set3",
            "rubble_chunk_06",
            "rubble_chunk_05",
            "rebar_group_02",
            "rebar_group_01",
            "rebar_group_04",
            "rebar_group_05",
            "rebar_group_07",
            "rebar_group_08",
            "rebar_group_09",
            "rubble_chunk_01",
            "rubble_chunk_03",
            "rubble_chunk_04",
            "rebar_group_10",
            "ground_concrete_bits_01",
            "rubble_chunk_10",
            "air_duct_wrap_01_curved",
            "air_duct_wrap_01_straight",
            "beam_set_01_dust",
            "beam_set_02_dust",
            "cg_chasm_crater_pc10",
            "cg_chasm_crater_pc12",
            "cg_chasm_crater_pc4",
            "cg_chasm_crater_pc7",
            "cg_chasm_crater_pc8",
            "cnd_bar_coaster_stack",
            "cnd_bar_coaster",
            "mp_chasm_brick_broken_corner_02",
            "mp_chasm_brick_broken_hor_02",
            "mp_chasm_brick_broken_ver_01",
            "mp_chasm_brick_broken_ver_02",
            "mp_chasm_brick_broken_corner_01",
            "mp_chasm_brick_broken_hor_01",
            "concrete_rubble_pile02_iw6",
            "picture_frame2_modern_scale3_iw6_04",
            "picture_frame2_abstract_art_1",
            "picture_frame2_abstract_art_2",
            "picture_frame2_abstract_art_3",
            "picture_frame2_car_poster_1",
            "picture_frame2_car_poster_2",
            "picture_frame2_car_poster_3",
            "concrete_rubble_pile03_iw6",
            "lv_white_chair",
            "lv_curvedcouchwhite02",
            "lv_squarecouchwhite",
            "mp_chasm_foliage_tree_palm_dead_06_ng",
            "vehicle_civilian_sedan_black_destroy_iw6",
            "cnd_computer_01_dest",
            "cnd_office_chair_01",
            "cg_chasm_crater_pc15",
            "cg_chasm_crater_pc13",
            "la_building_09",
            "la_building_01",
            "la_building_04",
            "la_building_10",
            "la_building_15",
            "sign_donutboxprice",
            "sign_donutprices",
            "sign_noshoesnoshirtnoservice",
            "sign_restaurantgrade",
            "sign_employmentnotice",
            "sign_washhands",
            "sign_restroom_mens",
            "sign_restroom_womens",
            "sign_noparking",
            "sign_open24hours",
            "utility_panel_01",
            "sign_caution_osharegs",
            "sign_employeesonly",
            "sign_deliveriesonly",
            "sky_bridge_01",
            "concrete_rubble_piece1_iw6",
            "concrete_rubble_piece3_iw6",
            "concrete_rubble_piece4_iw6",
            "concrete_rubble_pile01_iw6",
            "concrete_rubble_pile04_iw6",
            "ma_garbage_bin_1red",
            "com_telephone_desk",
            "berlin_hotel_lights_ceiling1_small_off",
            "furniture_pos_register02",
            "com_steel_ladder",
            "cs_cargoship_wall_light_on",
            "cs_cargoship_wall_light_red_on",
            "ma_tray_1red",
            "foliage_dub_plant_fern_02",
            "ch_bunker_wires_03",
            "paris_window_planter_01",
            "ma_stoolseat_1",
            "railroad_rustybolt_01",
            "vehicle_civilian_sedan_gray_destroy_iw6",
            "vehicle_civilian_sedan_red_destroy_iw6",
            "vehicle_civilian_sedan_blue_destroy_iw6",
            "planter_01",
            "mp_chasm_window_01",
            "barricade_construction_sign_chasm_iw6",
            "sign_stockyard_steakhouse_02",
            "sign_stockyard_steakhouse_03",
            "clk_monitor_flatpanel_broken",
            "ctl_plate_diamond_3",
            "ctl_plate_diamond_4",
            "sidewalk_chunk_a",
            "sidewalk_chunk_c",
            "sidewalk_chunk_b",
            "sidewalk_chunk_d",
            "sz_big_hitters_sign_01",
            "fah_lamp_small_01",
            "rubble_chunk_asphalt_06",
            "rubble_chunk_asphalt_07",
            "rubble_chunk_asphalt_08",
            "rubble_chunk_asphalt_12",
            "rubble_chunk_asphalt_02",
            "rubble_chunk_asphalt_03",
            "rubble_chunk_asphalt_11",
            "rubble_chunk_asphalt_09",
            "rubble_chunk_asphalt_13",
            "rubble_chunk_asphalt_14",
            "cnd_coffee_packets_pink_bowl_01",
            "tree_cypress_b_light_iw6",
            "cnd_desk_cubicle_brown",
            "cnd_hinge",
            "chasm_vending_machine_01",
            "coffee_table_modern_01_iw6",
            "trash_props_styroform3_iw6",
            "trash_props_trash_can1_iw6",
            "couch_modern_2seats",
            "ctl_door_security_sliding",
            "dumpster_chasm_closed",
            "electrical_box02_iw6",
            "fac_doorframe_a",
            "fac_door_a_solo",
            "fac_metal_fluorescent_light_01",
            "fac_metal_fluorescent_light_off_01",
            "fac_metal_cabinet_01",
            "fah_exit_sign",
            "furniture_light_set3_wall_sconces2",
            "furniture_light_set3_wall_sconces1",
            "light_outdoorwall02_on",
            "hjk_metal_briefcase",
            "vehicle_metro_bus_cabin_back",
            "fah_monitor_01_nocables",
            "moving_truck_destroyed_iw6",
            "office_book_open_iw6_black",
            "office_paper_stack02_iw6",
            "pipes_metal01",
            "pipes_metal_horiz02",
            "pipes_metal_vert03",
            "small_building_doorgate02",
            "chasm_bench_long_iw6",
            "street_lamp_post_old_iw6",
            "chasm_telephone_booth_iw6",
            "cg_chasm_crater_pc14",
            "light_highway_01",
            "clk_light_support_beam",
            "chasm_trash_bin",
            "pipe_metal_fire_sprinkler",
            "chasm_storefront_door01",
            "storefront_door01",
            "fac_parking_post_01",
            "chasm_kitchen_plates_broken_02",
            "com_breakable_platestack_large",
            "chasm_kitchen_plates_broken_01",
            "chasm_kitchen_plates_broken_02.",
            "ow_restaurant_barstool",
            "fac_keyboard",
            "lv_booth_seat_01",
            "vehicle_metro_bus_cabinmiddledamaged_2",
            "gulag_broken_tile1",
            "gulag_broken_tile2",
            "window_warehouse_7",
            "tv_flatscreen_large",
            "dub_door_handle_chrome",
            "oilpipe_cap",
            "kitchen_shelf01_chasm",
            "bathroom_urinal_iw6",
            "kitchen_dishwasher01_chasm",
            "kitchen_work_table01",
            "kitchen_fryer01",
            "chasm_food_prep_station_stove",
            "cg_chasm_crater_pc11",
            "cg_chasm_crater_pc2",
            "cg_chasm_crater_pc6",
            "la_building_06",
            "la_building_11",
            "la_building_12",
            "la_building_02",
            "la_building_03",
            "la_building_07",
            "la_building_08",
            "la_building_14",
            "clk_pipes_galvanized_45deg",
            "clk_pipes_galvanized_straight",
            "berlin_office_doorframe",
            "clk_light_outdoorwall03_off",
            "parking_meter_nosign_iw6",
            "plastic_computer_mouse_01",
            "arc_deco_light",
            "dub_light_exposed_can_on",
            "mp_dart_diner_squeeze_bottle_ketchup",
            "chasm_steakhouse_bars_01",
            "mp_dart_dinertable",
            "com_debris_paper_iw6_01",
            "com_debris_paper_iw6_02",
            "street_painted_metal_bench_iw6",
            "prague_awning01_blue",
            "fac_exit_sign_on",
            "chasm_manhole_telephone",
            "mp_chasm_industrial_fridge",
            "cnd_coffee_machine_01",
            "cnd_coffee_air_pot_closed_01",
            "machinery_ticketmachine01",
            "ng_door_kitchen_right",
            "com_office_chair_iw6_white",
            "light_fluorescent_damaged_iw6",
            "light_fluorescent_iw6",
            "light_fluorescent_light_iw6",
            "furniture_table_console01",
            "ls_lightswitch_01_iw6",
            "kitchen_faucet_modern_iw6",
            "vehicle_subway_cart_dest_back_mp",
            "kitchen_sink_modern_iw6",
            "ow_restaurant_table",
            "ow_restaurant_table_round",
            "cnd_potted_plant",
            "interior_light01",
            "ls_light_int_ceiling_01",
            "ls_light_int_ceiling_01_broken",
            "mp_chasm_amphitheatre_arch",
            "couch_modern_ottoman_dark_dust",
            "couch_modern_3seats_dust",
            "cg_chasm_crater_pc1",
            "cg_chasm_crater_pc9",
            "cg_chasm_crater_pc3",
            "ls_metal_hanging_strips_ehq_lrg_01",
            "cg_chasm_crater_pc5",
            "vehicle_subway_door_left_d",
            "com_door_05_handle_l",
            "com_door_05_handle_r",
            "berlin_wall_lightfixture_01",
            "berlin_patio_table",
            "mp_prison_kitchen_table_01",
            "chasm_kitchen_table_01",
            "ch_bunker_wires_02",
            "furniture_patio_dining_wood_chair",
            "old_news_paper_box_rusty_iw6",
            "bathroom_toilet_iw6",
            "ma_patio_heater",
            "mv/beam_set_01_dust",
            "mv/beam_set_02_dust",
            "mv/rubble_chunk_08",
            "mv/rubble_chunk_09",
            "mv/rubble_chunk_07",
            "mv/pillar_dmg_01_long",
            "mv/pillar_dmg_01_lshapebend1",
            "mv/pillar_dmg_01_lshapestraight",
            "mv/pillar_dmg_01_short",
            "mv/rubble_chunk_03",
            "mv/rubble_chunk_04",
            "mv/rubble_chunk_05",
            "mv/rebar_group_09",
            "mv/mp_chasm_brick_broken_ver_02",
            "mv/mp_chasm_brick_broken_corner_01",
            "mv/mp_chasm_brick_broken_corner_02",
            "mv/mp_chasm_brick_broken_ver_01",
            "cnd_plant_hosta_wilt",
            "brokenglass_pile01_iw6",
            "brokenglass_pile02_iw6",
            "brokenglass_pile03_iw6",
            "brokenglass_pile09_iw6",
            "brokenglass_pile07_iw6",
            "brokenglass_pile08_iw6",
            "brokenglass_pile06_iw6",
            "brokenglass_pile05_iw6",
            "brokenglass_pile08_planes",
            "brokenglass_pile09_planes",
            "brokenglass_window01",
            "brokenglass_window02",
            "brokenglass_window03",
            "brokenglass_pile01_planes",
            "brokenglass_pile02_planes",
            "pillar_dmg_01_lshapestraight",
            "prop_photocopier_destroyed_left_feeder",
            "prop_photocopier_destroyed_right_shelf",
            "lamp_meshtablelamp_iw6",
            "cnd_bottle_05",
            "kitchen_glass01_wine",
            "cnd_bottle_02",
            "cnd_bottle_03",
            "cnd_bottle_06",
            "cnd_bottle_10",
            "kitchen_glass01_martini_broken_bottom",
            "cnd_copy_machine_lid_closed",
            "cnd_copy_machine_dmg",
            "street_trashcan_open_iw6",
            "viewhands_devgru_arctic",
            "viewhands_devgru_desert",
            "viewhands_devgru_elite",
            "viewhands_devgru_urban",
            "viewhands_devgru_woodland",
            "head_mp_head_e_helmet_x",
            "head_mp_head_e_helmet_x_alt",
            "head_mp_head_e_helmet_x_alt_c",
            "head_mp_head_e_helmet_x_alt_d",
            "head_mp_head_e_helmet_x_alt_e",
            "head_mp_head_e_helmet_x_alt_f",
            "head_mp_head_eb_helmet_x",
            "head_mp_head_eb_helmet_x_alt",
            "head_mp_head_eb_helmet_x_alt_c",
            "head_mp_head_eb_helmet_x_alt_d",
            "head_mp_head_eb_helmet_x_alt_e",
            "head_mp_head_eb_helmet_x_alt_f",
            "head_mp_head_ec_helmet_x",
            "head_mp_head_ec_helmet_x_alt",
            "head_mp_head_ec_helmet_x_alt_c",
            "head_mp_head_ec_helmet_x_alt_d",
            "head_mp_head_ec_helmet_x_alt_e",
            "head_mp_head_ec_helmet_x_alt_f",
            "head_mp_head_ed_helmet_x",
            "head_mp_head_ed_helmet_x_alt",
            "head_mp_head_ed_helmet_x_alt_c",
            "head_mp_head_ed_helmet_x_alt_d",
            "head_mp_head_ed_helmet_x_alt_e",
            "head_mp_head_ed_helmet_x_alt_f",
            "head_mp_head_k_helmet_w",
            "head_mp_head_k_helmet_w_alt",
            "head_mp_head_k_helmet_w_alt_c",
            "head_mp_head_k_helmet_w_alt_d",
            "head_mp_head_k_helmet_w_alt_e",
            "head_mp_head_k_helmet_w_alt_f",
            "head_mp_head_kb_helmet_w",
            "head_mp_head_kb_helmet_w_alt",
            "head_mp_head_kb_helmet_w_alt_c",
            "head_mp_head_kb_helmet_w_alt_d",
            "head_mp_head_kb_helmet_w_alt_e",
            "head_mp_head_kb_helmet_w_alt_f",
            "head_mp_head_kc_helmet_w",
            "head_mp_head_kc_helmet_w_alt",
            "head_mp_head_kc_helmet_w_alt_c",
            "head_mp_head_kc_helmet_w_alt_d",
            "head_mp_head_kc_helmet_w_alt_e",
            "head_mp_head_kc_helmet_w_alt_f",
            "head_mp_head_kd_helmet_w",
            "head_mp_head_kd_helmet_w_alt",
            "head_mp_head_kd_helmet_w_alt_c",
            "head_mp_head_kd_helmet_w_alt_d",
            "head_mp_head_kd_helmet_w_alt_e",
            "head_mp_head_kd_helmet_w_alt_f",
            "head_mp_head_e_helmet_q",
            "head_mp_head_e_helmet_q_alt",
            "head_mp_head_eb_helmet_q",
            "head_mp_head_eb_helmet_q_alt",
            "head_mp_head_ec_helmet_q",
            "head_mp_head_ec_helmet_q_alt",
            "head_mp_head_ed_helmet_q",
            "head_mp_head_ed_helmet_q_alt",
            "head_mp_head_c_helmet_j",
            "head_mp_head_c_helmet_j_alt",
            "head_mp_head_c_helmet_j_alt_c",
            "head_mp_head_c_helmet_j_alt_d",
            "head_mp_head_c_helmet_j_alt_e",
            "head_mp_head_c_helmet_j_alt_f",
            "head_mp_head_cb_helmet_j",
            "head_mp_head_cb_helmet_j_alt",
            "head_mp_head_cb_helmet_j_alt_c",
            "head_mp_head_cb_helmet_j_alt_d",
            "head_mp_head_cb_helmet_j_alt_e",
            "head_mp_head_cb_helmet_j_alt_f",
            "head_mp_head_cc_helmet_j",
            "head_mp_head_cc_helmet_j_alt",
            "head_mp_head_cc_helmet_j_alt_c",
            "head_mp_head_cc_helmet_j_alt_d",
            "head_mp_head_cc_helmet_j_alt_e",
            "head_mp_head_cc_helmet_j_alt_f",
            "head_mp_head_cd_helmet_j",
            "head_mp_head_cd_helmet_j_alt",
            "head_mp_head_cd_helmet_j_alt_c",
            "head_mp_head_cd_helmet_j_alt_d",
            "head_mp_head_cd_helmet_j_alt_e",
            "head_mp_head_cd_helmet_j_alt_f",
            "head_mp_head_c_helmet_g",
            "head_mp_head_c_helmet_g_alt",
            "head_mp_head_cb_helmet_g",
            "head_mp_head_cb_helmet_g_alt",
            "head_mp_head_cc_helmet_g",
            "head_mp_head_cc_helmet_g_alt",
            "head_mp_head_cd_helmet_g",
            "head_mp_head_cd_helmet_g_alt",
            "head_mp_head_b_helmet_o",
            "head_mp_head_b_helmet_o_alt",
            "head_mp_head_b_helmet_o_alt_c",
            "head_mp_head_bb_helmet_o",
            "head_mp_head_bb_helmet_o_alt",
            "head_mp_head_bb_helmet_o_alt_c",
            "head_mp_head_bc_helmet_o",
            "head_mp_head_bc_helmet_o_alt",
            "head_mp_head_bc_helmet_o_alt_c",
            "head_mp_head_bd_helmet_o",
            "head_mp_head_bd_helmet_o_alt",
            "head_mp_head_bd_helmet_o_alt_c",
            "head_mp_head_k_helmet_q",
            "head_mp_head_k_helmet_q_alt",
            "head_mp_head_kb_helmet_q",
            "head_mp_head_kb_helmet_q_alt",
            "head_mp_head_kc_helmet_q",
            "head_mp_head_kc_helmet_q_alt",
            "head_mp_head_kd_helmet_q",
            "head_mp_head_kd_helmet_q_alt",
            "head_mp_head_d_helmet_h",
            "head_mp_head_d_helmet_h_alt",
            "head_mp_head_db_helmet_h",
            "head_mp_head_db_helmet_h_alt",
            "head_mp_head_dc_helmet_h",
            "head_mp_head_dc_helmet_h_alt",
            "head_mp_head_dd_helmet_h",
            "head_mp_head_dd_helmet_h_alt",
            "head_mp_head_d_helmet_r",
            "head_mp_head_d_helmet_r_alt",
            "head_mp_head_db_helmet_r",
            "head_mp_head_db_helmet_r_alt",
            "head_mp_head_dc_helmet_r",
            "head_mp_head_dc_helmet_r_alt",
            "head_mp_head_dd_helmet_r",
            "head_mp_head_dd_helmet_r_alt",
            "head_mp_head_e_helmet_a",
            "head_mp_head_eb_helmet_a",
            "head_mp_head_ec_helmet_a",
            "head_mp_head_ed_helmet_a",
            "head_mp_head_b",
            "head_mp_head_bb",
            "head_mp_head_bc",
            "head_mp_head_bd",
            "mp_body_devgru_lmg_a_arctic",
            "mp_body_devgru_lmg_a_desert",
            "mp_body_devgru_lmg_a_elite",
            "mp_body_devgru_lmg_a_urban",
            "mp_body_devgru_lmg_a_woodland",
            "mp_body_female_elite_pmc_shotgun_b_arctic",
            "mp_body_female_elite_pmc_shotgun_b_desert",
            "mp_body_female_elite_pmc_shotgun_b_elite",
            "mp_body_female_elite_pmc_shotgun_b_urban",
            "mp_body_female_elite_pmc_shotgun_b_woodland",
            "mp_body_fed_basic_assault_a_arctic",
            "mp_body_fed_basic_assault_a_desert",
            "mp_body_fed_basic_assault_a_elite",
            "mp_body_fed_basic_assault_a_urban",
            "mp_body_fed_basic_assault_a_woodland",
            "mp_body_us_rangers_shotgun_a_arctic",
            "mp_body_us_rangers_shotgun_a_desert",
            "mp_body_us_rangers_shotgun_a_elite",
            "mp_body_us_rangers_shotgun_a_urban",
            "mp_body_us_rangers_shotgun_a_woodland",
            "mp_body_elite_pmc_assault_b_arctic",
            "mp_body_elite_pmc_assault_b_desert",
            "mp_body_elite_pmc_assault_b_elite",
            "mp_body_elite_pmc_assault_b_urban",
            "mp_body_elite_pmc_assault_b_woodland",
            "mp_body_elite_pmc_shotgun_b_arctic",
            "mp_body_elite_pmc_shotgun_b_desert",
            "mp_body_elite_pmc_shotgun_b_elite",
            "mp_body_elite_pmc_shotgun_b_urban",
            "mp_body_elite_pmc_shotgun_b_woodland",
            "mp_body_female_fed_army_assault_a_arctic",
            "mp_body_female_fed_army_assault_a_desert",
            "mp_body_female_fed_army_assault_a_elite",
            "mp_body_female_fed_army_assault_a_urban",
            "mp_body_female_fed_army_assault_a_woodland",
            "mp_body_fed_basic_lmg_a_arctic",
            "mp_body_fed_basic_lmg_a_desert",
            "mp_body_fed_basic_lmg_a_elite",
            "mp_body_fed_basic_lmg_a_urban",
            "mp_body_fed_basic_lmg_a_woodland",
            "mp_body_devgru_smg_a_arctic",
            "mp_body_devgru_smg_a_desert",
            "mp_body_devgru_smg_a_elite",
            "mp_body_devgru_smg_a_urban",
            "mp_body_devgru_smg_a_woodland",
            "mp_body_us_rangers_smg_a_arctic",
            "mp_body_us_rangers_smg_a_desert",
            "mp_body_us_rangers_smg_a_elite",
            "mp_body_us_rangers_smg_a_urban",
            "mp_body_us_rangers_smg_a_woodland",
            "mp_body_devgru_assault_a_arctic",
            "mp_body_devgru_assault_a_desert",
            "mp_body_devgru_assault_a_elite",
            "mp_body_devgru_assault_a_urban",
            "mp_body_devgru_assault_a_woodland"});
            this.model.Location = new System.Drawing.Point(6, 19);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(227, 21);
            this.model.TabIndex = 10;
            this.model.Text = "void";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox2);
            this.groupBox10.Controls.Add(this.button31);
            this.groupBox10.Controls.Add(this.weap);
            this.groupBox10.Location = new System.Drawing.Point(9, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(317, 48);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Weapon";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(172, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Akimbo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(239, 19);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(72, 21);
            this.button31.TabIndex = 10;
            this.button31.Text = "Send";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // weap
            // 
            this.weap.FormattingEnabled = true;
            this.weap.Items.AddRange(new object[] {
            "smoke_grenade_mp",
            "smoke_grenadejugg_mp",
            "switch_blade_child_mp",
            "thermobaric_grenade_mp",
            "throwingknife_mp",
            "throwingknifejugg_mp",
            "trophy_mp",
            "a10_30mm_turret_mp",
            "aamissile_projectile_mp",
            "agent_mp",
            "agent_support_mp",
            "airdrop_juggernaut_def_mp",
            "airdrop_juggernaut_maniac_mp",
            "airdrop_juggernaut_mp",
            "airdrop_marker_assault_mp",
            "airdrop_marker_support_mp",
            "ball_drone_gun_mp",
            "barrel_mp",
            "bomb_site_mp",
            "briefcase_bomb_defuse_mp",
            "briefcase_bomb_mp",
            "c4_mp",
            "camera_5fov",
            "camera_10fov",
            "camera_20fov",
            "camera_30fov",
            "camera_45fov",
            "cobra_20mm_mp",
            "concussion_grenade_mp",
            "defaultweapon_mp",
            "deployable_vest_marker_mp",
            "deployable_weapon_crate_marker_mp",
            "destructible_car",
            "destructible_toy",
            "drone_hive_projectile_mp",
            "flare_mp",
            "flash_grenade_mp",
            "frag_grenade_mp",
            "frag_grenade_short_mp",
            "guard_dog_mp",
            "heli_pilot_turret_mp",
            "hind_bomb_mp",
            "hind_missile_mp",
            "ims_projectile_mp",
            "iw6_ak12_mp",
            "iw6_ameli_mp",
            "iw6_arx160_mp",
            "iw6_bren_mp",
            "iw6_cbjms_mp",
            "iw6_fads_mp",
            "iw6_fp6_mp",
            "iw6_g28_mp",
            "iw6_gm6_mp",
            "iw6_gm6helisnipe_mp",
            "iw6_honeybadger_mp",
            "iw6_imbel_mp",
            "iw6_k7_mp",
            "iw6_kac_mp",
            "iw6_knifeonly_mp",
            "iw6_knifeonlyjugg_mp",
            "iw6_kriss_mp",
            "iw6_l115a3_mp",
            "iw6_lsat_mp",
            "iw6_m9a1_mp",
            "iw6_m27_mp",
            "iw6_maaws_mp",
            "iw6_maawschild_mp",
            "iw6_maawshoming_mp",
            "iw6_magnum_mp",
            "iw6_magnumhorde_mp",
            "iw6_magnumjugg_mp",
            "iw6_maul_mp",
            "iw6_microtar_mp",
            "iw6_minigun_mp",
            "iw6_minigunjugg_mp",
            "iw6_mk14_mp",
            "iw6_mk32_mp",
            "iw6_mk32horde_mp",
            "iw6_mp443_mp",
            "iw6_msbs_mp",
            "iw6_mts255_mp",
            "iw6_p226_mp",
            "iw6_p226jugg_mp",
            "iw6_panzerfaust3_mp",
            "iw6_pdw_mp",
            "iw6_pp19_mp",
            "iw6_r5rgp_mp",
            "iw6_rgm_mp",
            "iw6_riotshield_mp",
            "iw6_riotshieldjugg_mp",
            "iw6_sc2010_mp",
            "iw6_svu_mp",
            "iw6_usr_mp",
            "iw6_uts15_mp",
            "iw6_vepr_mp",
            "iw6_vks_mp",
            "killstreak_agent_mp",
            "killstreak_air_superiority_mp",
            "killstreak_ball_drone_backup_mp",
            "killstreak_ball_drone_radar_mp",
            "killstreak_guard_dog_mp",
            "killstreak_heli_pilot_mp",
            "killstreak_helicopter_mp",
            "killstreak_helicopter_sniper_mp",
            "killstreak_ims_mp",
            "killstreak_jammer_mp",
            "killstreak_level_event_mp",
            "killstreak_nuke_mp",
            "killstreak_odin_assault_mp",
            "killstreak_odin_support_mp",
            "killstreak_predator_missile_mp",
            "killstreak_recon_agent",
            "killstreak_sentry_mp",
            "killstreak_uav_3dping_mp",
            "killstreak_uav_mp",
            "killstreak_uplink_assault_mp",
            "killstreak_uplink_support_mp",
            "killstreak_vanguard_mp",
            "littlebird_20mm_mp",
            "mortar_shell_mp",
            "mortar_shelljugg_mp",
            "motion_sensor_mp",
            "none",
            "nuke_mp",
            "odin_projectile_airdrop_mp",
            "odin_projectile_large_rod_mp",
            "odin_projectile_marking_mp",
            "odin_projectile_small_rod_mp",
            "odin_projectile_smoke_mp",
            "proximity_explosive_mp",
            "remote_tank_projectile_mp",
            "scavenger_bag_mp",
            "semtex_mp",
            "semtexproj_mp",
            "sentry_minigun_mp"});
            this.weap.Location = new System.Drawing.Point(6, 19);
            this.weap.Name = "weap";
            this.weap.Size = new System.Drawing.Size(159, 21);
            this.weap.TabIndex = 9;
            this.weap.Text = "smoke_grenade_mp";
            // 
            // Misc2Tab
            // 
            this.Misc2Tab.Controls.Add(this.groupBox9);
            this.Misc2Tab.Controls.Add(this.groupBox8);
            this.Misc2Tab.Controls.Add(this.groupBox7);
            this.Misc2Tab.Location = new System.Drawing.Point(4, 22);
            this.Misc2Tab.Name = "Misc2Tab";
            this.Misc2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Misc2Tab.Size = new System.Drawing.Size(332, 167);
            this.Misc2Tab.TabIndex = 4;
            this.Misc2Tab.Text = "Misc2";
            this.Misc2Tab.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button34);
            this.groupBox9.Controls.Add(this.button29);
            this.groupBox9.Controls.Add(this.text);
            this.groupBox9.Location = new System.Drawing.Point(196, 91);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(130, 70);
            this.groupBox9.TabIndex = 32;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Custom Text";
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(68, 44);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(56, 20);
            this.button34.TabIndex = 33;
            this.button34.Text = "Killfeed";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(6, 44);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(56, 20);
            this.button29.TabIndex = 32;
            this.button29.Text = "Center";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(6, 19);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(118, 20);
            this.text.TabIndex = 0;
            this.text.Text = "Text";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button28);
            this.groupBox8.Controls.Add(this.customdvar);
            this.groupBox8.Location = new System.Drawing.Point(196, 9);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(130, 70);
            this.groupBox8.TabIndex = 31;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Custom CMD";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(6, 45);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(118, 20);
            this.button28.TabIndex = 32;
            this.button28.Text = "Send";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // customdvar
            // 
            this.customdvar.Location = new System.Drawing.Point(6, 19);
            this.customdvar.Name = "customdvar";
            this.customdvar.Size = new System.Drawing.Size(118, 20);
            this.customdvar.TabIndex = 0;
            this.customdvar.Text = "DVAR";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button30);
            this.groupBox7.Controls.Add(this.timelimit);
            this.groupBox7.Controls.Add(this.button27);
            this.groupBox7.Controls.Add(this.button24);
            this.groupBox7.Controls.Add(this.jumpheight);
            this.groupBox7.Controls.Add(this.scorelimit);
            this.groupBox7.Controls.Add(this.button26);
            this.groupBox7.Controls.Add(this.button25);
            this.groupBox7.Controls.Add(this.xpperkill);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(184, 155);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Game Settings";
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(6, 123);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(172, 26);
            this.button30.TabIndex = 30;
            this.button30.Text = "Force Host";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // timelimit
            // 
            this.timelimit.Location = new System.Drawing.Point(6, 19);
            this.timelimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.timelimit.Name = "timelimit";
            this.timelimit.Size = new System.Drawing.Size(82, 20);
            this.timelimit.TabIndex = 22;
            this.timelimit.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(94, 97);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(84, 20);
            this.button27.TabIndex = 29;
            this.button27.Text = "Jump Height";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(94, 19);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 20);
            this.button24.TabIndex = 23;
            this.button24.Text = "Time Limit";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // jumpheight
            // 
            this.jumpheight.Location = new System.Drawing.Point(6, 97);
            this.jumpheight.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.jumpheight.Name = "jumpheight";
            this.jumpheight.Size = new System.Drawing.Size(82, 20);
            this.jumpheight.TabIndex = 28;
            this.jumpheight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // scorelimit
            // 
            this.scorelimit.Location = new System.Drawing.Point(6, 45);
            this.scorelimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.scorelimit.Name = "scorelimit";
            this.scorelimit.Size = new System.Drawing.Size(82, 20);
            this.scorelimit.TabIndex = 24;
            this.scorelimit.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(94, 71);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(84, 20);
            this.button26.TabIndex = 27;
            this.button26.Text = "XP Per Kill";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(94, 45);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(84, 20);
            this.button25.TabIndex = 25;
            this.button25.Text = "Score Limit";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // xpperkill
            // 
            this.xpperkill.Location = new System.Drawing.Point(6, 71);
            this.xpperkill.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xpperkill.Name = "xpperkill";
            this.xpperkill.Size = new System.Drawing.Size(82, 20);
            this.xpperkill.TabIndex = 26;
            this.xpperkill.Value = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            // 
            // Misc3Tab
            // 
            this.Misc3Tab.Controls.Add(this.groupBox14);
            this.Misc3Tab.Controls.Add(this.groupBox13);
            this.Misc3Tab.Location = new System.Drawing.Point(4, 22);
            this.Misc3Tab.Name = "Misc3Tab";
            this.Misc3Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Misc3Tab.Size = new System.Drawing.Size(332, 167);
            this.Misc3Tab.TabIndex = 6;
            this.Misc3Tab.Text = "Misc3";
            this.Misc3Tab.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.checkerBoard);
            this.groupBox14.Controls.Add(this.checkBox19);
            this.groupBox14.Controls.Add(this.checkBox18);
            this.groupBox14.Controls.Add(this.checkBox17);
            this.groupBox14.Controls.Add(this.checkBox16);
            this.groupBox14.Location = new System.Drawing.Point(198, 6);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(128, 155);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Disable DPAD";
            // 
            // checkerBoard
            // 
            this.checkerBoard.AutoSize = true;
            this.checkerBoard.Checked = true;
            this.checkerBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkerBoard.Location = new System.Drawing.Point(6, 19);
            this.checkerBoard.Name = "checkerBoard";
            this.checkerBoard.Size = new System.Drawing.Size(123, 17);
            this.checkerBoard.TabIndex = 4;
            this.checkerBoard.Text = "Show Checkerboard";
            this.checkerBoard.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(6, 132);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(125, 17);
            this.checkBox19.TabIndex = 3;
            this.checkBox19.Text = "Disable DPAD-Down";
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(6, 109);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(111, 17);
            this.checkBox18.TabIndex = 2;
            this.checkBox18.Text = "Disable DPAD-Up";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(6, 86);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(122, 17);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "Disable DPAD-Right";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(6, 63);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(115, 17);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Text = "Disable DPAD-Left";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.button36);
            this.groupBox13.Controls.Add(this.button35);
            this.groupBox13.Controls.Add(this.checkBox15);
            this.groupBox13.Controls.Add(this.checkBox14);
            this.groupBox13.Controls.Add(this.checkBox13);
            this.groupBox13.Controls.Add(this.checkBox8);
            this.groupBox13.Location = new System.Drawing.Point(6, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(186, 155);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Random Functions";
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(6, 134);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(174, 20);
            this.button36.TabIndex = 26;
            this.button36.Text = "Fake 10th (In-Game)";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(6, 108);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(174, 20);
            this.button35.TabIndex = 25;
            this.button35.Text = "Fake Derank (In-Game)";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(6, 88);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(93, 17);
            this.checkBox15.TabIndex = 3;
            this.checkBox15.Text = "Prestige Cycle";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(6, 65);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(89, 17);
            this.checkBox14.TabIndex = 2;
            this.checkBox14.Text = "Disable Jump";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(6, 42);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(91, 17);
            this.checkBox13.TabIndex = 1;
            this.checkBox13.Text = "Disable Sprint";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(6, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(52, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "TBag";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // NewTab
            // 
            this.NewTab.Location = new System.Drawing.Point(4, 22);
            this.NewTab.Name = "NewTab";
            this.NewTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewTab.Size = new System.Drawing.Size(332, 167);
            this.NewTab.TabIndex = 7;
            this.NewTab.Text = "New";
            this.NewTab.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "All",
            "Client 0",
            "Client 1",
            "Client 2",
            "Client 3",
            "Client 4",
            "Client 5",
            "Client 6",
            "Client 7",
            "Client 8",
            "Client 9",
            "Client 10",
            "Client 11"});
            this.listBox1.Location = new System.Drawing.Point(358, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(6, 132);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(53, 17);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "Team";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabcontrol1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Revision";
            this.Load += new System.EventHandler(this.Form1_Load);
            StatsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.losses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killstreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestige)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ClientsTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallhack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fov)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TogglesTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.offhost.ResumeLayout(false);
            this.offhost.PerformLayout();
            this.tabcontrol1.ResumeLayout(false);
            this.Misc1Tab.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.Misc2Tab.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timelimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scorelimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpperkill)).EndInit();
            this.Misc3Tab.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.NumericUpDown score;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.NumericUpDown squad;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.NumericUpDown misses;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.NumericUpDown hits;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.NumericUpDown games;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.NumericUpDown losses;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown wins;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.NumericUpDown killstreak;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.NumericUpDown deaths;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown kills;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown xp;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown prestige;
        private System.Windows.Forms.TabPage ClientsTab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.NumericUpDown wallhack;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown fov;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.TabPage TogglesTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox offhost;
        private System.Windows.Forms.CheckBox uav;
        private System.Windows.Forms.CheckBox norecoil;
        private System.Windows.Forms.CheckBox chams;
        private System.Windows.Forms.CheckBox laser;
        private System.Windows.Forms.CheckBox redbox;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage Misc1Tab;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox poi;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.TextBox gt;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.ComboBox weap;
        private System.Windows.Forms.TabPage Misc2Tab;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.TextBox customdvar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.NumericUpDown timelimit;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.NumericUpDown jumpheight;
        private System.Windows.Forms.NumericUpDown scorelimit;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.NumericUpDown xpperkill;
        private System.Windows.Forms.TabPage Misc3Tab;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox checkerBoard;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.TabPage NewTab;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.CheckBox checkBox21;
    }
}

