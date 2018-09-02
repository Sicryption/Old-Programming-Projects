using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRPCLib;
using JRPC_Client;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        Image currentImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Carepackage.bmp");
        int currentNum = -1;
        string finnishedList;
        string selectedModel = "carepackage_friendly_iw6";
        XRPC Jtag = new XRPC();
        JRPC Console = new JRPC();
        uint getPlayerState(uint clientNum)//TU8
        {
            return 0x8328F100 + (clientNum * 0x3600);
        }
        uint SP_script_model = 0x82414440;//TU8
        uint SV_LinkEntity = 0x824D96F0;//TU8
        uint SV_SetBrushModel = 0x824C2888;//TU8
        uint SV_UnLinkEntity = 0x824D9388;//TU8
        uint MapBrushModel = 0x83307200 + 0x7F80;
        uint G_Spawn = 0x8241B6C8; //TU8
        uint G_SetModel = 0x8241B1E8;//TU8
        bool ufo = false;
        Image[] pBox1 = new Image[30]; Image[] pBox2 = new Image[30]; Image[] pBox3 = new Image[30]; Image[] pBox4 = new Image[30]; Image[] pBox5 = new Image[30]; Image[] pBox6 = new Image[30]; Image[] pBox7 = new Image[30]; Image[] pBox8 = new Image[30]; Image[] pBox9 = new Image[30]; Image[] pBox10 = new Image[30]; Image[] pBox11 = new Image[30]; Image[] pBox12 = new Image[30]; Image[] pBox13 = new Image[30]; Image[] pBox14 = new Image[30]; Image[] pBox15 = new Image[30]; Image[] pBox16 = new Image[30]; Image[] pBox17 = new Image[30]; Image[] pBox18 = new Image[30]; Image[] pBox19 = new Image[30]; Image[] pBox20 = new Image[30]; Image[] pBox21 = new Image[30]; Image[] pBox22 = new Image[30]; Image[] pBox23 = new Image[30]; Image[] pBox24 = new Image[30]; Image[] pBox25 = new Image[30]; Image[] pBox26 = new Image[30]; Image[] pBox27 = new Image[30]; Image[] pBox28 = new Image[30]; Image[] pBox29 = new Image[30]; Image[] pBox30 = new Image[30]; Image[] pBox31 = new Image[30]; Image[] pBox32 = new Image[30]; Image[] pBox33 = new Image[30]; Image[] pBox34 = new Image[30]; Image[] pBox35 = new Image[30]; Image[] pBox36 = new Image[30]; Image[] pBox37 = new Image[30]; Image[] pBox38 = new Image[30]; Image[] pBox39 = new Image[30]; Image[] pBox40 = new Image[30]; Image[] pBox41 = new Image[30]; Image[] pBox42 = new Image[30]; Image[] pBox43 = new Image[30]; Image[] pBox44 = new Image[30]; Image[] pBox45 = new Image[30]; Image[] pBox46 = new Image[30]; Image[] pBox47 = new Image[30]; Image[] pBox48 = new Image[30]; Image[] pBox49 = new Image[30]; Image[] pBox50 = new Image[30]; Image[] pBox51 = new Image[30]; Image[] pBox52 = new Image[30]; Image[] pBox53 = new Image[30]; Image[] pBox54 = new Image[30]; Image[] pBox55 = new Image[30]; Image[] pBox56 = new Image[30]; Image[] pBox57 = new Image[30]; Image[] pBox58 = new Image[30]; Image[] pBox59 = new Image[30]; Image[] pBox60 = new Image[30]; Image[] pBox61 = new Image[30]; Image[] pBox62 = new Image[30]; Image[] pBox63 = new Image[30]; Image[] pBox64 = new Image[30]; Image[] pBox65 = new Image[30]; Image[] pBox66 = new Image[30]; Image[] pBox67 = new Image[30]; Image[] pBox68 = new Image[30]; Image[] pBox69 = new Image[30]; Image[] pBox70 = new Image[30]; Image[] pBox71 = new Image[30]; Image[] pBox72 = new Image[30]; Image[] pBox73 = new Image[30]; Image[] pBox74 = new Image[30]; Image[] pBox75 = new Image[30]; Image[] pBox76 = new Image[30]; Image[] pBox77 = new Image[30]; Image[] pBox78 = new Image[30]; Image[] pBox79 = new Image[30]; Image[] pBox80 = new Image[30]; Image[] pBox81 = new Image[30]; Image[] pBox82 = new Image[30]; Image[] pBox83 = new Image[30]; Image[] pBox84 = new Image[30]; Image[] pBox85 = new Image[30]; Image[] pBox86 = new Image[30]; Image[] pBox87 = new Image[30]; Image[] pBox88 = new Image[30]; Image[] pBox89 = new Image[30]; Image[] pBox90 = new Image[30]; Image[] pBox91 = new Image[30]; Image[] pBox92 = new Image[30]; Image[] pBox93 = new Image[30]; Image[] pBox94 = new Image[30]; Image[] pBox95 = new Image[30]; Image[] pBox96 = new Image[30]; Image[] pBox97 = new Image[30]; Image[] pBox98 = new Image[30]; Image[] pBox99 = new Image[30]; Image[] pBox100 = new Image[30]; Image[] pBox101 = new Image[30]; Image[] pBox102 = new Image[30]; Image[] pBox103 = new Image[30]; Image[] pBox104 = new Image[30]; Image[] pBox105 = new Image[30]; Image[] pBox106 = new Image[30]; Image[] pBox107 = new Image[30]; Image[] pBox108 = new Image[30]; Image[] pBox109 = new Image[30]; Image[] pBox110 = new Image[30]; Image[] pBox111 = new Image[30]; Image[] pBox112 = new Image[30]; Image[] pBox113 = new Image[30]; Image[] pBox114 = new Image[30]; Image[] pBox115 = new Image[30]; Image[] pBox116 = new Image[30]; Image[] pBox117 = new Image[30]; Image[] pBox118 = new Image[30]; Image[] pBox119 = new Image[30]; Image[] pBox120 = new Image[30]; Image[] pBox121 = new Image[30]; Image[] pBox122 = new Image[30]; Image[] pBox123 = new Image[30]; Image[] pBox124 = new Image[30]; Image[] pBox125 = new Image[30]; Image[] pBox126 = new Image[30]; Image[] pBox127 = new Image[30]; Image[] pBox128 = new Image[30]; Image[] pBox129 = new Image[30]; Image[] pBox130 = new Image[30]; Image[] pBox131 = new Image[30]; Image[] pBox132 = new Image[30]; Image[] pBox133 = new Image[30]; Image[] pBox134 = new Image[30]; Image[] pBox135 = new Image[30]; Image[] pBox136 = new Image[30]; Image[] pBox137 = new Image[30]; Image[] pBox138 = new Image[30]; Image[] pBox139 = new Image[30]; Image[] pBox140 = new Image[30]; Image[] pBox141 = new Image[30]; Image[] pBox142 = new Image[30]; Image[] pBox143 = new Image[30]; Image[] pBox144 = new Image[30]; Image[] pBox145 = new Image[30]; Image[] pBox146 = new Image[30]; Image[] pBox147 = new Image[30]; Image[] pBox148 = new Image[30]; Image[] pBox149 = new Image[30]; Image[] pBox150 = new Image[30]; Image[] pBox151 = new Image[30]; Image[] pBox152 = new Image[30]; Image[] pBox153 = new Image[30]; Image[] pBox154 = new Image[30]; Image[] pBox155 = new Image[30]; Image[] pBox156 = new Image[30]; Image[] pBox157 = new Image[30]; Image[] pBox158 = new Image[30]; Image[] pBox159 = new Image[30]; Image[] pBox160 = new Image[30]; Image[] pBox161 = new Image[30]; Image[] pBox162 = new Image[30]; Image[] pBox163 = new Image[30]; Image[] pBox164 = new Image[30]; Image[] pBox165 = new Image[30]; Image[] pBox166 = new Image[30]; Image[] pBox167 = new Image[30]; Image[] pBox168 = new Image[30]; Image[] pBox169 = new Image[30]; Image[] pBox170 = new Image[30]; Image[] pBox171 = new Image[30]; Image[] pBox172 = new Image[30]; Image[] pBox173 = new Image[30]; Image[] pBox174 = new Image[30]; Image[] pBox175 = new Image[30]; Image[] pBox176 = new Image[30]; Image[] pBox177 = new Image[30]; Image[] pBox178 = new Image[30]; Image[] pBox179 = new Image[30]; Image[] pBox180 = new Image[30]; Image[] pBox181 = new Image[30]; Image[] pBox182 = new Image[30]; Image[] pBox183 = new Image[30]; Image[] pBox184 = new Image[30]; Image[] pBox185 = new Image[30]; Image[] pBox186 = new Image[30]; Image[] pBox187 = new Image[30]; Image[] pBox188 = new Image[30]; Image[] pBox189 = new Image[30]; Image[] pBox190 = new Image[30]; Image[] pBox191 = new Image[30]; Image[] pBox192 = new Image[30]; Image[] pBox193 = new Image[30]; Image[] pBox194 = new Image[30]; Image[] pBox195 = new Image[30]; Image[] pBox196 = new Image[30]; Image[] pBox197 = new Image[30]; Image[] pBox198 = new Image[30]; Image[] pBox199 = new Image[30]; Image[] pBox200 = new Image[30];

        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            this.pictureBox1.Click += pictureBox_Click;
            this.pictureBox2.Click += pictureBox_Click;
            this.pictureBox3.Click += pictureBox_Click;
            this.pictureBox4.Click += pictureBox_Click;
            this.pictureBox5.Click += pictureBox_Click;
            this.pictureBox6.Click += pictureBox_Click;
            this.pictureBox7.Click += pictureBox_Click;
            this.pictureBox8.Click += pictureBox_Click;
            this.pictureBox9.Click += pictureBox_Click;
            this.pictureBox10.Click += pictureBox_Click;
            this.pictureBox11.Click += pictureBox_Click;
            this.pictureBox12.Click += pictureBox_Click;
            this.pictureBox13.Click += pictureBox_Click;
            this.pictureBox14.Click += pictureBox_Click;
            this.pictureBox15.Click += pictureBox_Click;
            this.pictureBox16.Click += pictureBox_Click;
            this.pictureBox17.Click += pictureBox_Click;
            this.pictureBox18.Click += pictureBox_Click;
            this.pictureBox19.Click += pictureBox_Click;
            this.pictureBox20.Click += pictureBox_Click;
            this.pictureBox21.Click += pictureBox_Click;
            this.pictureBox22.Click += pictureBox_Click;
            this.pictureBox23.Click += pictureBox_Click;
            this.pictureBox24.Click += pictureBox_Click;
            this.pictureBox25.Click += pictureBox_Click;
            this.pictureBox26.Click += pictureBox_Click;
            this.pictureBox27.Click += pictureBox_Click;
            this.pictureBox28.Click += pictureBox_Click;
            this.pictureBox29.Click += pictureBox_Click;
            this.pictureBox30.Click += pictureBox_Click;
            this.pictureBox31.Click += pictureBox_Click;
            this.pictureBox32.Click += pictureBox_Click;
            this.pictureBox33.Click += pictureBox_Click;
            this.pictureBox34.Click += pictureBox_Click;
            this.pictureBox35.Click += pictureBox_Click;
            this.pictureBox36.Click += pictureBox_Click;
            this.pictureBox37.Click += pictureBox_Click;
            this.pictureBox38.Click += pictureBox_Click;
            this.pictureBox39.Click += pictureBox_Click;
            this.pictureBox40.Click += pictureBox_Click;
            this.pictureBox41.Click += pictureBox_Click;
            this.pictureBox42.Click += pictureBox_Click;
            this.pictureBox43.Click += pictureBox_Click;
            this.pictureBox44.Click += pictureBox_Click;
            this.pictureBox45.Click += pictureBox_Click;
            this.pictureBox46.Click += pictureBox_Click;
            this.pictureBox47.Click += pictureBox_Click;
            this.pictureBox48.Click += pictureBox_Click;
            this.pictureBox49.Click += pictureBox_Click;
            this.pictureBox50.Click += pictureBox_Click;
            this.pictureBox51.Click += pictureBox_Click;
            this.pictureBox52.Click += pictureBox_Click;
            this.pictureBox53.Click += pictureBox_Click;
            this.pictureBox54.Click += pictureBox_Click;
            this.pictureBox55.Click += pictureBox_Click;
            this.pictureBox56.Click += pictureBox_Click;
            this.pictureBox57.Click += pictureBox_Click;
            this.pictureBox58.Click += pictureBox_Click;
            this.pictureBox59.Click += pictureBox_Click;
            this.pictureBox60.Click += pictureBox_Click;
            this.pictureBox61.Click += pictureBox_Click;
            this.pictureBox62.Click += pictureBox_Click;
            this.pictureBox63.Click += pictureBox_Click;
            this.pictureBox64.Click += pictureBox_Click;
            this.pictureBox65.Click += pictureBox_Click;
            this.pictureBox66.Click += pictureBox_Click;
            this.pictureBox67.Click += pictureBox_Click;
            this.pictureBox68.Click += pictureBox_Click;
            this.pictureBox69.Click += pictureBox_Click;
            this.pictureBox70.Click += pictureBox_Click;
            this.pictureBox71.Click += pictureBox_Click;
            this.pictureBox72.Click += pictureBox_Click;
            this.pictureBox73.Click += pictureBox_Click;
            this.pictureBox74.Click += pictureBox_Click;
            this.pictureBox75.Click += pictureBox_Click;
            this.pictureBox76.Click += pictureBox_Click;
            this.pictureBox77.Click += pictureBox_Click;
            this.pictureBox78.Click += pictureBox_Click;
            this.pictureBox79.Click += pictureBox_Click;
            this.pictureBox80.Click += pictureBox_Click;
            this.pictureBox81.Click += pictureBox_Click;
            this.pictureBox82.Click += pictureBox_Click;
            this.pictureBox83.Click += pictureBox_Click;
            this.pictureBox84.Click += pictureBox_Click;
            this.pictureBox85.Click += pictureBox_Click;
            this.pictureBox86.Click += pictureBox_Click;
            this.pictureBox87.Click += pictureBox_Click;
            this.pictureBox88.Click += pictureBox_Click;
            this.pictureBox89.Click += pictureBox_Click;
            this.pictureBox90.Click += pictureBox_Click;
            this.pictureBox91.Click += pictureBox_Click;
            this.pictureBox92.Click += pictureBox_Click;
            this.pictureBox93.Click += pictureBox_Click;
            this.pictureBox94.Click += pictureBox_Click;
            this.pictureBox95.Click += pictureBox_Click;
            this.pictureBox96.Click += pictureBox_Click;
            this.pictureBox97.Click += pictureBox_Click;
            this.pictureBox98.Click += pictureBox_Click;
            this.pictureBox99.Click += pictureBox_Click;
            this.pictureBox100.Click += pictureBox_Click;
            this.pictureBox101.Click += pictureBox_Click;
            this.pictureBox102.Click += pictureBox_Click;
            this.pictureBox103.Click += pictureBox_Click;
            this.pictureBox104.Click += pictureBox_Click;
            this.pictureBox105.Click += pictureBox_Click;
            this.pictureBox106.Click += pictureBox_Click;
            this.pictureBox107.Click += pictureBox_Click;
            this.pictureBox108.Click += pictureBox_Click;
            this.pictureBox109.Click += pictureBox_Click;
            this.pictureBox110.Click += pictureBox_Click;
            this.pictureBox111.Click += pictureBox_Click;
            this.pictureBox112.Click += pictureBox_Click;
            this.pictureBox113.Click += pictureBox_Click;
            this.pictureBox114.Click += pictureBox_Click;
            this.pictureBox115.Click += pictureBox_Click;
            this.pictureBox116.Click += pictureBox_Click;
            this.pictureBox117.Click += pictureBox_Click;
            this.pictureBox118.Click += pictureBox_Click;
            this.pictureBox119.Click += pictureBox_Click;
            this.pictureBox120.Click += pictureBox_Click;
            this.pictureBox121.Click += pictureBox_Click;
            this.pictureBox122.Click += pictureBox_Click;
            this.pictureBox123.Click += pictureBox_Click;
            this.pictureBox124.Click += pictureBox_Click;
            this.pictureBox125.Click += pictureBox_Click;
            this.pictureBox126.Click += pictureBox_Click;
            this.pictureBox127.Click += pictureBox_Click;
            this.pictureBox128.Click += pictureBox_Click;
            this.pictureBox129.Click += pictureBox_Click;
            this.pictureBox130.Click += pictureBox_Click;
            this.pictureBox131.Click += pictureBox_Click;
            this.pictureBox132.Click += pictureBox_Click;
            this.pictureBox133.Click += pictureBox_Click;
            this.pictureBox134.Click += pictureBox_Click;
            this.pictureBox135.Click += pictureBox_Click;
            this.pictureBox136.Click += pictureBox_Click;
            this.pictureBox137.Click += pictureBox_Click;
            this.pictureBox138.Click += pictureBox_Click;
            this.pictureBox139.Click += pictureBox_Click;
            this.pictureBox140.Click += pictureBox_Click;
            this.pictureBox141.Click += pictureBox_Click;
            this.pictureBox142.Click += pictureBox_Click;
            this.pictureBox143.Click += pictureBox_Click;
            this.pictureBox144.Click += pictureBox_Click;
            this.pictureBox145.Click += pictureBox_Click;
            this.pictureBox146.Click += pictureBox_Click;
            this.pictureBox147.Click += pictureBox_Click;
            this.pictureBox148.Click += pictureBox_Click;
            this.pictureBox149.Click += pictureBox_Click;
            this.pictureBox150.Click += pictureBox_Click;
            this.pictureBox151.Click += pictureBox_Click;
            this.pictureBox152.Click += pictureBox_Click;
            this.pictureBox153.Click += pictureBox_Click;
            this.pictureBox154.Click += pictureBox_Click;
            this.pictureBox155.Click += pictureBox_Click;
            this.pictureBox156.Click += pictureBox_Click;
            this.pictureBox157.Click += pictureBox_Click;
            this.pictureBox158.Click += pictureBox_Click;
            this.pictureBox159.Click += pictureBox_Click;
            this.pictureBox160.Click += pictureBox_Click;
            this.pictureBox161.Click += pictureBox_Click;
            this.pictureBox162.Click += pictureBox_Click;
            this.pictureBox163.Click += pictureBox_Click;
            this.pictureBox164.Click += pictureBox_Click;
            this.pictureBox165.Click += pictureBox_Click;
            this.pictureBox166.Click += pictureBox_Click;
            this.pictureBox167.Click += pictureBox_Click;
            this.pictureBox168.Click += pictureBox_Click;
            this.pictureBox169.Click += pictureBox_Click;
            this.pictureBox170.Click += pictureBox_Click;
            this.pictureBox171.Click += pictureBox_Click;
            this.pictureBox172.Click += pictureBox_Click;
            this.pictureBox173.Click += pictureBox_Click;
            this.pictureBox174.Click += pictureBox_Click;
            this.pictureBox175.Click += pictureBox_Click;
            this.pictureBox176.Click += pictureBox_Click;
            this.pictureBox177.Click += pictureBox_Click;
            this.pictureBox178.Click += pictureBox_Click;
            this.pictureBox179.Click += pictureBox_Click;
            this.pictureBox180.Click += pictureBox_Click;
            this.pictureBox181.Click += pictureBox_Click;
            this.pictureBox182.Click += pictureBox_Click;
            this.pictureBox183.Click += pictureBox_Click;
            this.pictureBox184.Click += pictureBox_Click;
            this.pictureBox185.Click += pictureBox_Click;
            this.pictureBox186.Click += pictureBox_Click;
            this.pictureBox187.Click += pictureBox_Click;
            this.pictureBox188.Click += pictureBox_Click;
            this.pictureBox189.Click += pictureBox_Click;
            this.pictureBox190.Click += pictureBox_Click;
            this.pictureBox191.Click += pictureBox_Click;
            this.pictureBox192.Click += pictureBox_Click;
            this.pictureBox193.Click += pictureBox_Click;
            this.pictureBox194.Click += pictureBox_Click;
            this.pictureBox195.Click += pictureBox_Click;
            this.pictureBox196.Click += pictureBox_Click;
            this.pictureBox197.Click += pictureBox_Click;
            this.pictureBox198.Click += pictureBox_Click;
            this.pictureBox199.Click += pictureBox_Click;
            this.pictureBox200.Click += pictureBox_Click;
        }

        private void floor_ValueChanged(object sender, EventArgs e)
        {
            if (floor.Value >= 15)
            {
                upAFloor.Enabled = false;
            }
            else if (floor.Value <= -15)
            {
                downAFloor.Enabled = false;
            }
            else
            {
                upAFloor.Enabled = true;
                downAFloor.Enabled = true;
            }
        }

        private void upAFloor_Click(object sender, EventArgs e)
        {
            saveFloor();
            floor.Value++;
            loadFloor();
        }

        private void downAFloor_Click(object sender, EventArgs e)
        {
            saveFloor();
            floor.Value--;
            loadFloor();
        }

        private void loadFloor()
        {
            pictureBox1.BackgroundImage = pBox1[(int)floor.Value + 15]; pictureBox2.BackgroundImage = pBox2[(int)floor.Value + 15]; pictureBox3.BackgroundImage = pBox3[(int)floor.Value + 15]; pictureBox4.BackgroundImage = pBox4[(int)floor.Value + 15]; pictureBox5.BackgroundImage = pBox5[(int)floor.Value + 15]; pictureBox6.BackgroundImage = pBox6[(int)floor.Value + 15]; pictureBox7.BackgroundImage = pBox7[(int)floor.Value + 15]; pictureBox8.BackgroundImage = pBox8[(int)floor.Value + 15]; pictureBox9.BackgroundImage = pBox9[(int)floor.Value + 15]; pictureBox10.BackgroundImage = pBox10[(int)floor.Value + 15]; pictureBox11.BackgroundImage = pBox11[(int)floor.Value + 15]; pictureBox12.BackgroundImage = pBox12[(int)floor.Value + 15]; pictureBox13.BackgroundImage = pBox13[(int)floor.Value + 15]; pictureBox14.BackgroundImage = pBox14[(int)floor.Value + 15]; pictureBox15.BackgroundImage = pBox15[(int)floor.Value + 15]; pictureBox16.BackgroundImage = pBox16[(int)floor.Value + 15]; pictureBox17.BackgroundImage = pBox17[(int)floor.Value + 15]; pictureBox18.BackgroundImage = pBox18[(int)floor.Value + 15]; pictureBox19.BackgroundImage = pBox19[(int)floor.Value + 15]; pictureBox20.BackgroundImage = pBox20[(int)floor.Value + 15]; pictureBox21.BackgroundImage = pBox21[(int)floor.Value + 15]; pictureBox22.BackgroundImage = pBox22[(int)floor.Value + 15]; pictureBox23.BackgroundImage = pBox23[(int)floor.Value + 15]; pictureBox24.BackgroundImage = pBox24[(int)floor.Value + 15]; pictureBox25.BackgroundImage = pBox25[(int)floor.Value + 15]; pictureBox26.BackgroundImage = pBox26[(int)floor.Value + 15]; pictureBox27.BackgroundImage = pBox27[(int)floor.Value + 15]; pictureBox28.BackgroundImage = pBox28[(int)floor.Value + 15]; pictureBox29.BackgroundImage = pBox29[(int)floor.Value + 15]; pictureBox30.BackgroundImage = pBox30[(int)floor.Value + 15]; pictureBox31.BackgroundImage = pBox31[(int)floor.Value + 15]; pictureBox32.BackgroundImage = pBox32[(int)floor.Value + 15]; pictureBox33.BackgroundImage = pBox33[(int)floor.Value + 15]; pictureBox34.BackgroundImage = pBox34[(int)floor.Value + 15]; pictureBox35.BackgroundImage = pBox35[(int)floor.Value + 15]; pictureBox36.BackgroundImage = pBox36[(int)floor.Value + 15]; pictureBox37.BackgroundImage = pBox37[(int)floor.Value + 15]; pictureBox38.BackgroundImage = pBox38[(int)floor.Value + 15]; pictureBox39.BackgroundImage = pBox39[(int)floor.Value + 15]; pictureBox40.BackgroundImage = pBox40[(int)floor.Value + 15]; pictureBox41.BackgroundImage = pBox41[(int)floor.Value + 15]; pictureBox42.BackgroundImage = pBox42[(int)floor.Value + 15]; pictureBox43.BackgroundImage = pBox43[(int)floor.Value + 15]; pictureBox44.BackgroundImage = pBox44[(int)floor.Value + 15]; pictureBox45.BackgroundImage = pBox45[(int)floor.Value + 15]; pictureBox46.BackgroundImage = pBox46[(int)floor.Value + 15]; pictureBox47.BackgroundImage = pBox47[(int)floor.Value + 15]; pictureBox48.BackgroundImage = pBox48[(int)floor.Value + 15]; pictureBox49.BackgroundImage = pBox49[(int)floor.Value + 15]; pictureBox50.BackgroundImage = pBox50[(int)floor.Value + 15]; pictureBox51.BackgroundImage = pBox51[(int)floor.Value + 15]; pictureBox52.BackgroundImage = pBox52[(int)floor.Value + 15]; pictureBox53.BackgroundImage = pBox53[(int)floor.Value + 15]; pictureBox54.BackgroundImage = pBox54[(int)floor.Value + 15]; pictureBox55.BackgroundImage = pBox55[(int)floor.Value + 15]; pictureBox56.BackgroundImage = pBox56[(int)floor.Value + 15]; pictureBox57.BackgroundImage = pBox57[(int)floor.Value + 15]; pictureBox58.BackgroundImage = pBox58[(int)floor.Value + 15]; pictureBox59.BackgroundImage = pBox59[(int)floor.Value + 15]; pictureBox60.BackgroundImage = pBox60[(int)floor.Value + 15]; pictureBox61.BackgroundImage = pBox61[(int)floor.Value + 15]; pictureBox62.BackgroundImage = pBox62[(int)floor.Value + 15]; pictureBox63.BackgroundImage = pBox63[(int)floor.Value + 15]; pictureBox64.BackgroundImage = pBox64[(int)floor.Value + 15]; pictureBox65.BackgroundImage = pBox65[(int)floor.Value + 15]; pictureBox66.BackgroundImage = pBox66[(int)floor.Value + 15]; pictureBox67.BackgroundImage = pBox67[(int)floor.Value + 15]; pictureBox68.BackgroundImage = pBox68[(int)floor.Value + 15]; pictureBox69.BackgroundImage = pBox69[(int)floor.Value + 15]; pictureBox70.BackgroundImage = pBox70[(int)floor.Value + 15]; pictureBox71.BackgroundImage = pBox71[(int)floor.Value + 15]; pictureBox72.BackgroundImage = pBox72[(int)floor.Value + 15]; pictureBox73.BackgroundImage = pBox73[(int)floor.Value + 15]; pictureBox74.BackgroundImage = pBox74[(int)floor.Value + 15]; pictureBox75.BackgroundImage = pBox75[(int)floor.Value + 15]; pictureBox76.BackgroundImage = pBox76[(int)floor.Value + 15]; pictureBox77.BackgroundImage = pBox77[(int)floor.Value + 15]; pictureBox78.BackgroundImage = pBox78[(int)floor.Value + 15]; pictureBox79.BackgroundImage = pBox79[(int)floor.Value + 15]; pictureBox80.BackgroundImage = pBox80[(int)floor.Value + 15]; pictureBox81.BackgroundImage = pBox81[(int)floor.Value + 15]; pictureBox82.BackgroundImage = pBox82[(int)floor.Value + 15]; pictureBox83.BackgroundImage = pBox83[(int)floor.Value + 15]; pictureBox84.BackgroundImage = pBox84[(int)floor.Value + 15]; pictureBox85.BackgroundImage = pBox85[(int)floor.Value + 15]; pictureBox86.BackgroundImage = pBox86[(int)floor.Value + 15]; pictureBox87.BackgroundImage = pBox87[(int)floor.Value + 15]; pictureBox88.BackgroundImage = pBox88[(int)floor.Value + 15]; pictureBox89.BackgroundImage = pBox89[(int)floor.Value + 15]; pictureBox90.BackgroundImage = pBox90[(int)floor.Value + 15]; pictureBox91.BackgroundImage = pBox91[(int)floor.Value + 15]; pictureBox92.BackgroundImage = pBox92[(int)floor.Value + 15]; pictureBox93.BackgroundImage = pBox93[(int)floor.Value + 15]; pictureBox94.BackgroundImage = pBox94[(int)floor.Value + 15]; pictureBox95.BackgroundImage = pBox95[(int)floor.Value + 15]; pictureBox96.BackgroundImage = pBox96[(int)floor.Value + 15]; pictureBox97.BackgroundImage = pBox97[(int)floor.Value + 15]; pictureBox98.BackgroundImage = pBox98[(int)floor.Value + 15]; pictureBox99.BackgroundImage = pBox99[(int)floor.Value + 15]; pictureBox100.BackgroundImage = pBox100[(int)floor.Value + 15]; pictureBox101.BackgroundImage = pBox101[(int)floor.Value + 15]; pictureBox102.BackgroundImage = pBox102[(int)floor.Value + 15]; pictureBox103.BackgroundImage = pBox103[(int)floor.Value + 15]; pictureBox104.BackgroundImage = pBox104[(int)floor.Value + 15]; pictureBox105.BackgroundImage = pBox105[(int)floor.Value + 15]; pictureBox106.BackgroundImage = pBox106[(int)floor.Value + 15]; pictureBox107.BackgroundImage = pBox107[(int)floor.Value + 15]; pictureBox108.BackgroundImage = pBox108[(int)floor.Value + 15]; pictureBox109.BackgroundImage = pBox109[(int)floor.Value + 15]; pictureBox110.BackgroundImage = pBox110[(int)floor.Value + 15]; pictureBox111.BackgroundImage = pBox111[(int)floor.Value + 15]; pictureBox112.BackgroundImage = pBox112[(int)floor.Value + 15]; pictureBox113.BackgroundImage = pBox113[(int)floor.Value + 15]; pictureBox114.BackgroundImage = pBox114[(int)floor.Value + 15]; pictureBox115.BackgroundImage = pBox115[(int)floor.Value + 15]; pictureBox116.BackgroundImage = pBox116[(int)floor.Value + 15]; pictureBox117.BackgroundImage = pBox117[(int)floor.Value + 15]; pictureBox118.BackgroundImage = pBox118[(int)floor.Value + 15]; pictureBox119.BackgroundImage = pBox119[(int)floor.Value + 15]; pictureBox120.BackgroundImage = pBox120[(int)floor.Value + 15]; pictureBox121.BackgroundImage = pBox121[(int)floor.Value + 15]; pictureBox122.BackgroundImage = pBox122[(int)floor.Value + 15]; pictureBox123.BackgroundImage = pBox123[(int)floor.Value + 15]; pictureBox124.BackgroundImage = pBox124[(int)floor.Value + 15]; pictureBox125.BackgroundImage = pBox125[(int)floor.Value + 15]; pictureBox126.BackgroundImage = pBox126[(int)floor.Value + 15]; pictureBox127.BackgroundImage = pBox127[(int)floor.Value + 15]; pictureBox128.BackgroundImage = pBox128[(int)floor.Value + 15]; pictureBox129.BackgroundImage = pBox129[(int)floor.Value + 15]; pictureBox130.BackgroundImage = pBox130[(int)floor.Value + 15]; pictureBox131.BackgroundImage = pBox131[(int)floor.Value + 15]; pictureBox132.BackgroundImage = pBox132[(int)floor.Value + 15]; pictureBox133.BackgroundImage = pBox133[(int)floor.Value + 15]; pictureBox134.BackgroundImage = pBox134[(int)floor.Value + 15]; pictureBox135.BackgroundImage = pBox135[(int)floor.Value + 15]; pictureBox136.BackgroundImage = pBox136[(int)floor.Value + 15]; pictureBox137.BackgroundImage = pBox137[(int)floor.Value + 15]; pictureBox138.BackgroundImage = pBox138[(int)floor.Value + 15]; pictureBox139.BackgroundImage = pBox139[(int)floor.Value + 15]; pictureBox140.BackgroundImage = pBox140[(int)floor.Value + 15]; pictureBox141.BackgroundImage = pBox141[(int)floor.Value + 15]; pictureBox142.BackgroundImage = pBox142[(int)floor.Value + 15]; pictureBox143.BackgroundImage = pBox143[(int)floor.Value + 15]; pictureBox144.BackgroundImage = pBox144[(int)floor.Value + 15]; pictureBox145.BackgroundImage = pBox145[(int)floor.Value + 15]; pictureBox146.BackgroundImage = pBox146[(int)floor.Value + 15]; pictureBox147.BackgroundImage = pBox147[(int)floor.Value + 15]; pictureBox148.BackgroundImage = pBox148[(int)floor.Value + 15]; pictureBox149.BackgroundImage = pBox149[(int)floor.Value + 15]; pictureBox150.BackgroundImage = pBox150[(int)floor.Value + 15]; pictureBox151.BackgroundImage = pBox151[(int)floor.Value + 15]; pictureBox152.BackgroundImage = pBox152[(int)floor.Value + 15]; pictureBox153.BackgroundImage = pBox153[(int)floor.Value + 15]; pictureBox154.BackgroundImage = pBox154[(int)floor.Value + 15]; pictureBox155.BackgroundImage = pBox155[(int)floor.Value + 15]; pictureBox156.BackgroundImage = pBox156[(int)floor.Value + 15]; pictureBox157.BackgroundImage = pBox157[(int)floor.Value + 15]; pictureBox158.BackgroundImage = pBox158[(int)floor.Value + 15]; pictureBox159.BackgroundImage = pBox159[(int)floor.Value + 15]; pictureBox160.BackgroundImage = pBox160[(int)floor.Value + 15]; pictureBox161.BackgroundImage = pBox161[(int)floor.Value + 15]; pictureBox162.BackgroundImage = pBox162[(int)floor.Value + 15]; pictureBox163.BackgroundImage = pBox163[(int)floor.Value + 15]; pictureBox164.BackgroundImage = pBox164[(int)floor.Value + 15]; pictureBox165.BackgroundImage = pBox165[(int)floor.Value + 15]; pictureBox166.BackgroundImage = pBox166[(int)floor.Value + 15]; pictureBox167.BackgroundImage = pBox167[(int)floor.Value + 15]; pictureBox168.BackgroundImage = pBox168[(int)floor.Value + 15]; pictureBox169.BackgroundImage = pBox169[(int)floor.Value + 15]; pictureBox170.BackgroundImage = pBox170[(int)floor.Value + 15]; pictureBox171.BackgroundImage = pBox171[(int)floor.Value + 15]; pictureBox172.BackgroundImage = pBox172[(int)floor.Value + 15]; pictureBox173.BackgroundImage = pBox173[(int)floor.Value + 15]; pictureBox174.BackgroundImage = pBox174[(int)floor.Value + 15]; pictureBox175.BackgroundImage = pBox175[(int)floor.Value + 15]; pictureBox176.BackgroundImage = pBox176[(int)floor.Value + 15]; pictureBox177.BackgroundImage = pBox177[(int)floor.Value + 15]; pictureBox178.BackgroundImage = pBox178[(int)floor.Value + 15]; pictureBox179.BackgroundImage = pBox179[(int)floor.Value + 15]; pictureBox180.BackgroundImage = pBox180[(int)floor.Value + 15]; pictureBox181.BackgroundImage = pBox181[(int)floor.Value + 15]; pictureBox182.BackgroundImage = pBox182[(int)floor.Value + 15]; pictureBox183.BackgroundImage = pBox183[(int)floor.Value + 15]; pictureBox184.BackgroundImage = pBox184[(int)floor.Value + 15]; pictureBox185.BackgroundImage = pBox185[(int)floor.Value + 15]; pictureBox186.BackgroundImage = pBox186[(int)floor.Value + 15]; pictureBox187.BackgroundImage = pBox187[(int)floor.Value + 15]; pictureBox188.BackgroundImage = pBox188[(int)floor.Value + 15]; pictureBox189.BackgroundImage = pBox189[(int)floor.Value + 15]; pictureBox190.BackgroundImage = pBox190[(int)floor.Value + 15]; pictureBox191.BackgroundImage = pBox191[(int)floor.Value + 15]; pictureBox192.BackgroundImage = pBox192[(int)floor.Value + 15]; pictureBox193.BackgroundImage = pBox193[(int)floor.Value + 15]; pictureBox194.BackgroundImage = pBox194[(int)floor.Value + 15]; pictureBox195.BackgroundImage = pBox195[(int)floor.Value + 15]; pictureBox196.BackgroundImage = pBox196[(int)floor.Value + 15]; pictureBox197.BackgroundImage = pBox197[(int)floor.Value + 15]; pictureBox198.BackgroundImage = pBox198[(int)floor.Value + 15]; pictureBox199.BackgroundImage = pBox199[(int)floor.Value + 15]; pictureBox200.BackgroundImage = pBox200[(int)floor.Value + 15];
        }

        private void saveFloor()
        {
            pBox1[(int)floor.Value + 15] = pictureBox1.BackgroundImage; pBox2[(int)floor.Value + 15] = pictureBox2.BackgroundImage; pBox3[(int)floor.Value + 15] = pictureBox3.BackgroundImage; pBox4[(int)floor.Value + 15] = pictureBox4.BackgroundImage; pBox5[(int)floor.Value + 15] = pictureBox5.BackgroundImage; pBox6[(int)floor.Value + 15] = pictureBox6.BackgroundImage; pBox7[(int)floor.Value + 15] = pictureBox7.BackgroundImage; pBox8[(int)floor.Value + 15] = pictureBox8.BackgroundImage; pBox9[(int)floor.Value + 15] = pictureBox9.BackgroundImage; pBox10[(int)floor.Value + 15] = pictureBox10.BackgroundImage; pBox11[(int)floor.Value + 15] = pictureBox11.BackgroundImage; pBox12[(int)floor.Value + 15] = pictureBox12.BackgroundImage; pBox13[(int)floor.Value + 15] = pictureBox13.BackgroundImage; pBox14[(int)floor.Value + 15] = pictureBox14.BackgroundImage; pBox15[(int)floor.Value + 15] = pictureBox15.BackgroundImage; pBox16[(int)floor.Value + 15] = pictureBox16.BackgroundImage; pBox17[(int)floor.Value + 15] = pictureBox17.BackgroundImage; pBox18[(int)floor.Value + 15] = pictureBox18.BackgroundImage; pBox19[(int)floor.Value + 15] = pictureBox19.BackgroundImage; pBox20[(int)floor.Value + 15] = pictureBox20.BackgroundImage; pBox21[(int)floor.Value + 15] = pictureBox21.BackgroundImage; pBox22[(int)floor.Value + 15] = pictureBox22.BackgroundImage; pBox23[(int)floor.Value + 15] = pictureBox23.BackgroundImage; pBox24[(int)floor.Value + 15] = pictureBox24.BackgroundImage; pBox25[(int)floor.Value + 15] = pictureBox25.BackgroundImage; pBox26[(int)floor.Value + 15] = pictureBox26.BackgroundImage; pBox27[(int)floor.Value + 15] = pictureBox27.BackgroundImage; pBox28[(int)floor.Value + 15] = pictureBox28.BackgroundImage; pBox29[(int)floor.Value + 15] = pictureBox29.BackgroundImage; pBox30[(int)floor.Value + 15] = pictureBox30.BackgroundImage; pBox31[(int)floor.Value + 15] = pictureBox31.BackgroundImage; pBox32[(int)floor.Value + 15] = pictureBox32.BackgroundImage; pBox33[(int)floor.Value + 15] = pictureBox33.BackgroundImage; pBox34[(int)floor.Value + 15] = pictureBox34.BackgroundImage; pBox35[(int)floor.Value + 15] = pictureBox35.BackgroundImage; pBox36[(int)floor.Value + 15] = pictureBox36.BackgroundImage; pBox37[(int)floor.Value + 15] = pictureBox37.BackgroundImage; pBox38[(int)floor.Value + 15] = pictureBox38.BackgroundImage; pBox39[(int)floor.Value + 15] = pictureBox39.BackgroundImage; pBox40[(int)floor.Value + 15] = pictureBox40.BackgroundImage; pBox41[(int)floor.Value + 15] = pictureBox41.BackgroundImage; pBox42[(int)floor.Value + 15] = pictureBox42.BackgroundImage; pBox43[(int)floor.Value + 15] = pictureBox43.BackgroundImage; pBox44[(int)floor.Value + 15] = pictureBox44.BackgroundImage; pBox45[(int)floor.Value + 15] = pictureBox45.BackgroundImage; pBox46[(int)floor.Value + 15] = pictureBox46.BackgroundImage; pBox47[(int)floor.Value + 15] = pictureBox47.BackgroundImage; pBox48[(int)floor.Value + 15] = pictureBox48.BackgroundImage; pBox49[(int)floor.Value + 15] = pictureBox49.BackgroundImage; pBox50[(int)floor.Value + 15] = pictureBox50.BackgroundImage; pBox51[(int)floor.Value + 15] = pictureBox51.BackgroundImage; pBox52[(int)floor.Value + 15] = pictureBox52.BackgroundImage; pBox53[(int)floor.Value + 15] = pictureBox53.BackgroundImage; pBox54[(int)floor.Value + 15] = pictureBox54.BackgroundImage; pBox55[(int)floor.Value + 15] = pictureBox55.BackgroundImage; pBox56[(int)floor.Value + 15] = pictureBox56.BackgroundImage; pBox57[(int)floor.Value + 15] = pictureBox57.BackgroundImage; pBox58[(int)floor.Value + 15] = pictureBox58.BackgroundImage; pBox59[(int)floor.Value + 15] = pictureBox59.BackgroundImage; pBox60[(int)floor.Value + 15] = pictureBox60.BackgroundImage; pBox61[(int)floor.Value + 15] = pictureBox61.BackgroundImage; pBox62[(int)floor.Value + 15] = pictureBox62.BackgroundImage; pBox63[(int)floor.Value + 15] = pictureBox63.BackgroundImage; pBox64[(int)floor.Value + 15] = pictureBox64.BackgroundImage; pBox65[(int)floor.Value + 15] = pictureBox65.BackgroundImage; pBox66[(int)floor.Value + 15] = pictureBox66.BackgroundImage; pBox67[(int)floor.Value + 15] = pictureBox67.BackgroundImage; pBox68[(int)floor.Value + 15] = pictureBox68.BackgroundImage; pBox69[(int)floor.Value + 15] = pictureBox69.BackgroundImage; pBox70[(int)floor.Value + 15] = pictureBox70.BackgroundImage; pBox71[(int)floor.Value + 15] = pictureBox71.BackgroundImage; pBox72[(int)floor.Value + 15] = pictureBox72.BackgroundImage; pBox73[(int)floor.Value + 15] = pictureBox73.BackgroundImage; pBox74[(int)floor.Value + 15] = pictureBox74.BackgroundImage; pBox75[(int)floor.Value + 15] = pictureBox75.BackgroundImage; pBox76[(int)floor.Value + 15] = pictureBox76.BackgroundImage; pBox77[(int)floor.Value + 15] = pictureBox77.BackgroundImage; pBox78[(int)floor.Value + 15] = pictureBox78.BackgroundImage; pBox79[(int)floor.Value + 15] = pictureBox79.BackgroundImage; pBox80[(int)floor.Value + 15] = pictureBox80.BackgroundImage; pBox81[(int)floor.Value + 15] = pictureBox81.BackgroundImage; pBox82[(int)floor.Value + 15] = pictureBox82.BackgroundImage; pBox83[(int)floor.Value + 15] = pictureBox83.BackgroundImage; pBox84[(int)floor.Value + 15] = pictureBox84.BackgroundImage; pBox85[(int)floor.Value + 15] = pictureBox85.BackgroundImage; pBox86[(int)floor.Value + 15] = pictureBox86.BackgroundImage; pBox87[(int)floor.Value + 15] = pictureBox87.BackgroundImage; pBox88[(int)floor.Value + 15] = pictureBox88.BackgroundImage; pBox89[(int)floor.Value + 15] = pictureBox89.BackgroundImage; pBox90[(int)floor.Value + 15] = pictureBox90.BackgroundImage; pBox91[(int)floor.Value + 15] = pictureBox91.BackgroundImage; pBox92[(int)floor.Value + 15] = pictureBox92.BackgroundImage; pBox93[(int)floor.Value + 15] = pictureBox93.BackgroundImage; pBox94[(int)floor.Value + 15] = pictureBox94.BackgroundImage; pBox95[(int)floor.Value + 15] = pictureBox95.BackgroundImage; pBox96[(int)floor.Value + 15] = pictureBox96.BackgroundImage; pBox97[(int)floor.Value + 15] = pictureBox97.BackgroundImage; pBox98[(int)floor.Value + 15] = pictureBox98.BackgroundImage; pBox99[(int)floor.Value + 15] = pictureBox99.BackgroundImage; pBox100[(int)floor.Value + 15] = pictureBox100.BackgroundImage; pBox101[(int)floor.Value + 15] = pictureBox101.BackgroundImage; pBox102[(int)floor.Value + 15] = pictureBox102.BackgroundImage; pBox103[(int)floor.Value + 15] = pictureBox103.BackgroundImage; pBox104[(int)floor.Value + 15] = pictureBox104.BackgroundImage; pBox105[(int)floor.Value + 15] = pictureBox105.BackgroundImage; pBox106[(int)floor.Value + 15] = pictureBox106.BackgroundImage; pBox107[(int)floor.Value + 15] = pictureBox107.BackgroundImage; pBox108[(int)floor.Value + 15] = pictureBox108.BackgroundImage; pBox109[(int)floor.Value + 15] = pictureBox109.BackgroundImage; pBox110[(int)floor.Value + 15] = pictureBox110.BackgroundImage; pBox111[(int)floor.Value + 15] = pictureBox111.BackgroundImage; pBox112[(int)floor.Value + 15] = pictureBox112.BackgroundImage; pBox113[(int)floor.Value + 15] = pictureBox113.BackgroundImage; pBox114[(int)floor.Value + 15] = pictureBox114.BackgroundImage; pBox115[(int)floor.Value + 15] = pictureBox115.BackgroundImage; pBox116[(int)floor.Value + 15] = pictureBox116.BackgroundImage; pBox117[(int)floor.Value + 15] = pictureBox117.BackgroundImage; pBox118[(int)floor.Value + 15] = pictureBox118.BackgroundImage; pBox119[(int)floor.Value + 15] = pictureBox119.BackgroundImage; pBox120[(int)floor.Value + 15] = pictureBox120.BackgroundImage; pBox121[(int)floor.Value + 15] = pictureBox121.BackgroundImage; pBox122[(int)floor.Value + 15] = pictureBox122.BackgroundImage; pBox123[(int)floor.Value + 15] = pictureBox123.BackgroundImage; pBox124[(int)floor.Value + 15] = pictureBox124.BackgroundImage; pBox125[(int)floor.Value + 15] = pictureBox125.BackgroundImage; pBox126[(int)floor.Value + 15] = pictureBox126.BackgroundImage; pBox127[(int)floor.Value + 15] = pictureBox127.BackgroundImage; pBox128[(int)floor.Value + 15] = pictureBox128.BackgroundImage; pBox129[(int)floor.Value + 15] = pictureBox129.BackgroundImage; pBox130[(int)floor.Value + 15] = pictureBox130.BackgroundImage; pBox131[(int)floor.Value + 15] = pictureBox131.BackgroundImage; pBox132[(int)floor.Value + 15] = pictureBox132.BackgroundImage; pBox133[(int)floor.Value + 15] = pictureBox133.BackgroundImage; pBox134[(int)floor.Value + 15] = pictureBox134.BackgroundImage; pBox135[(int)floor.Value + 15] = pictureBox135.BackgroundImage; pBox136[(int)floor.Value + 15] = pictureBox136.BackgroundImage; pBox137[(int)floor.Value + 15] = pictureBox137.BackgroundImage; pBox138[(int)floor.Value + 15] = pictureBox138.BackgroundImage; pBox139[(int)floor.Value + 15] = pictureBox139.BackgroundImage; pBox140[(int)floor.Value + 15] = pictureBox140.BackgroundImage; pBox141[(int)floor.Value + 15] = pictureBox141.BackgroundImage; pBox142[(int)floor.Value + 15] = pictureBox142.BackgroundImage; pBox143[(int)floor.Value + 15] = pictureBox143.BackgroundImage; pBox144[(int)floor.Value + 15] = pictureBox144.BackgroundImage; pBox145[(int)floor.Value + 15] = pictureBox145.BackgroundImage; pBox146[(int)floor.Value + 15] = pictureBox146.BackgroundImage; pBox147[(int)floor.Value + 15] = pictureBox147.BackgroundImage; pBox148[(int)floor.Value + 15] = pictureBox148.BackgroundImage; pBox149[(int)floor.Value + 15] = pictureBox149.BackgroundImage; pBox150[(int)floor.Value + 15] = pictureBox150.BackgroundImage; pBox151[(int)floor.Value + 15] = pictureBox151.BackgroundImage; pBox152[(int)floor.Value + 15] = pictureBox152.BackgroundImage; pBox153[(int)floor.Value + 15] = pictureBox153.BackgroundImage; pBox154[(int)floor.Value + 15] = pictureBox154.BackgroundImage; pBox155[(int)floor.Value + 15] = pictureBox155.BackgroundImage; pBox156[(int)floor.Value + 15] = pictureBox156.BackgroundImage; pBox157[(int)floor.Value + 15] = pictureBox157.BackgroundImage; pBox158[(int)floor.Value + 15] = pictureBox158.BackgroundImage; pBox159[(int)floor.Value + 15] = pictureBox159.BackgroundImage; pBox160[(int)floor.Value + 15] = pictureBox160.BackgroundImage; pBox161[(int)floor.Value + 15] = pictureBox161.BackgroundImage; pBox162[(int)floor.Value + 15] = pictureBox162.BackgroundImage; pBox163[(int)floor.Value + 15] = pictureBox163.BackgroundImage; pBox164[(int)floor.Value + 15] = pictureBox164.BackgroundImage; pBox165[(int)floor.Value + 15] = pictureBox165.BackgroundImage; pBox166[(int)floor.Value + 15] = pictureBox166.BackgroundImage; pBox167[(int)floor.Value + 15] = pictureBox167.BackgroundImage; pBox168[(int)floor.Value + 15] = pictureBox168.BackgroundImage; pBox169[(int)floor.Value + 15] = pictureBox169.BackgroundImage; pBox170[(int)floor.Value + 15] = pictureBox170.BackgroundImage; pBox171[(int)floor.Value + 15] = pictureBox171.BackgroundImage; pBox172[(int)floor.Value + 15] = pictureBox172.BackgroundImage; pBox173[(int)floor.Value + 15] = pictureBox173.BackgroundImage; pBox174[(int)floor.Value + 15] = pictureBox174.BackgroundImage; pBox175[(int)floor.Value + 15] = pictureBox175.BackgroundImage; pBox176[(int)floor.Value + 15] = pictureBox176.BackgroundImage; pBox177[(int)floor.Value + 15] = pictureBox177.BackgroundImage; pBox178[(int)floor.Value + 15] = pictureBox178.BackgroundImage; pBox179[(int)floor.Value + 15] = pictureBox179.BackgroundImage; pBox180[(int)floor.Value + 15] = pictureBox180.BackgroundImage; pBox181[(int)floor.Value + 15] = pictureBox181.BackgroundImage; pBox182[(int)floor.Value + 15] = pictureBox182.BackgroundImage; pBox183[(int)floor.Value + 15] = pictureBox183.BackgroundImage; pBox184[(int)floor.Value + 15] = pictureBox184.BackgroundImage; pBox185[(int)floor.Value + 15] = pictureBox185.BackgroundImage; pBox186[(int)floor.Value + 15] = pictureBox186.BackgroundImage; pBox187[(int)floor.Value + 15] = pictureBox187.BackgroundImage; pBox188[(int)floor.Value + 15] = pictureBox188.BackgroundImage; pBox189[(int)floor.Value + 15] = pictureBox189.BackgroundImage; pBox190[(int)floor.Value + 15] = pictureBox190.BackgroundImage; pBox191[(int)floor.Value + 15] = pictureBox191.BackgroundImage; pBox192[(int)floor.Value + 15] = pictureBox192.BackgroundImage; pBox193[(int)floor.Value + 15] = pictureBox193.BackgroundImage; pBox194[(int)floor.Value + 15] = pictureBox194.BackgroundImage; pBox195[(int)floor.Value + 15] = pictureBox195.BackgroundImage; pBox196[(int)floor.Value + 15] = pictureBox196.BackgroundImage; pBox197[(int)floor.Value + 15] = pictureBox197.BackgroundImage; pBox198[(int)floor.Value + 15] = pictureBox198.BackgroundImage; pBox199[(int)floor.Value + 15] = pictureBox199.BackgroundImage; pBox200[(int)floor.Value + 15] = pictureBox200.BackgroundImage;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            var r = (PictureBox)sender;
            currentNum++;
            if (selectedModel != "none" && selectedModel != null)
            {
                if (finnishedList != null)
                {
                    if (finnishedList.Contains("entity(" + selectedModel + ", " + ((float)r.Location.X) + ", " + ((float)r.Location.Y) + ", " + (float)((floor.Value * 30) + 25000) + ", 0, 90, 0);"))
                    {

                    }
                    else
                    {
                        finnishedList = finnishedList + Environment.NewLine + "entity(" + selectedModel + ", " + ((float)r.Location.X) + ", " + ((float)r.Location.Y) + ", " + (float)((floor.Value * 30) + 25000) + ", 0, 90, 0);" + Environment.NewLine;
                    }
                }
                else
                {
                    finnishedList = finnishedList + Environment.NewLine + "entity(" + selectedModel + ", " + ((float)r.Location.X) + ", " + ((float)r.Location.Y) + ", " + (float)((floor.Value * 30) + 25000) + ", 0, 90, 0);" + Environment.NewLine;
                }
            }
            else
            {
                try
                {
                    string[] models = new string[] { "carepackage_friendly_iw6", "mp_juggernaut_carepackage", "mp_fullbody_dog_a", "none" };
                    for (int n = 0; n == 3; n++)
                    {
                        if (finnishedList.Contains("entity(" + models[n] + ", " + ((float)r.Location.X) + ", " + ((float)r.Location.Y) + ", " + (float)((floor.Value * 30) + 25000) + ", 0, 90, 0);" + Environment.NewLine))
                        {
                            finnishedList = finnishedList.Replace("entity(" + models[n] + ", " + ((float)r.Location.X) + ", " + ((float)r.Location.Y) + ", " + (float)((floor.Value * 30) + 25000) + ", 0, 90, 0);" + Environment.NewLine, string.Empty);
                        }
                    }
                }
                catch
                {

                }
            }
            richTextBox1.Text = finnishedList;
            r.BackgroundImage = currentImage;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(richTextBox1.Text);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Console.activeConnection == false)
            {
                try
                {
                    Console.Connect();
                }
                catch
                {
                    
                }
            }
            if (Console.activeConnection == true)
            {
                try
                {
                    foreach (string str in this.richTextBox1.Lines)
                    {
                        if (str.Contains("entity(") && str.Contains(");"))
                        {
                            int startIndex = str.IndexOf("entity(");
                            if (startIndex >= 0)
                            {
                                startIndex += "entity(".Length;
                                int num10 = str.IndexOf(");", startIndex);
                                if (num10 >= 0)
                                {
                                    float num11;
                                    float num12;
                                    float num13;
                                    float num14;
                                    float num15;
                                    float num16;
                                    string[] strArray2 = str.Substring(startIndex, num10 - startIndex).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                    string model = strArray2[0];
                                    float.TryParse(strArray2[1].Trim(), out num11);
                                    float.TryParse(strArray2[2].Trim(), out num12);
                                    float.TryParse(strArray2[3].Trim(), out num13);
                                    float.TryParse(strArray2[4].Trim(), out num14);
                                    float.TryParse(strArray2[5].Trim(), out num15);
                                    float.TryParse(strArray2[6].Trim(), out num16);
                                    spawnEntityJRPC(num11, num12, num13, model, num14, num15, num16);
                                }
                            }
                        }
                        else if (str.Contains("sleep(") && str.Contains(");"))
                        {
                            int num17 = str.IndexOf("sleep(");
                            if (num17 >= 0)
                            {
                                num17 += "sleep(".Length;
                                int num18 = str.IndexOf(");", num17);
                                if (num18 >= 0)
                                {
                                    int num19;
                                    int.TryParse(str.Substring(num17, num18 - num17).Trim(), out num19);
                                    System.Threading.Thread.Sleep(num19);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to Connect to Console");
                }
            }
            else
            {
                MessageBox.Show("Unable to Connect to Console");
            }
        }

        public void spawnEntityJRPC(float x, float y, float z, string Model, float pitch, float yaw, float roll)
        {
            try
            {
                byte[] bytes = BitConverter.GetBytes(x);
                byte[] array = BitConverter.GetBytes(y);
                byte[] buffer3 = BitConverter.GetBytes(z);
                byte[] buffer4 = BitConverter.GetBytes(pitch);
                byte[] buffer5 = BitConverter.GetBytes(yaw);
                byte[] buffer6 = BitConverter.GetBytes(roll);
                Array.Reverse(bytes, 0, 4);
                Array.Reverse(array, 0, 4);
                Array.Reverse(buffer3, 0, 4);
                Array.Reverse(buffer4, 0, 4);
                Array.Reverse(buffer5, 0, 4);
                Array.Reverse(buffer6, 0, 4);
                uint entity = Console.CallUInt(G_Spawn, new object[0]);
                Console.Memory.SetMemory(entity + 0x138, bytes);
                Console.Memory.SetMemory(entity + 0x13c, array);
                Console.Memory.SetMemory(entity + 0x140, buffer3);
                Console.Memory.SetMemory(entity + 0x144, buffer4);
                Console.Memory.SetMemory(entity + 0x148, buffer5);
                Console.Memory.SetMemory(entity + 0x14c, buffer6);
                Console.CallUInt(G_SetModel, new object[] { entity, Model });
                Console.CallUInt(SP_script_model, new object[] { entity });
                System.Threading.Thread.Sleep(30);
                Console.CallUInt(SV_UnLinkEntity, entity);
                Console.Memory.SetMemory(entity + 0x101, new byte[] { 4 });
                byte[] memory = Console.Memory.GetMemory(MapBrushModel + 140, 4);
                Console.Memory.SetMemory(entity + 140, memory);
                Console.CallUInt(SV_SetBrushModel, entity);
                Console.Memory.SetMemory(entity + 0x11c, memory);
                Console.CallUInt(SV_LinkEntity, entity);
            }
            catch
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Friendly Carepackage":
                    currentImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Carepackage.bmp");
                    selectedModel = "carepackage_friendly_iw6";
                    break;
                case "Juggernaut Carepackage":
                    currentImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Juggernaut Carepackage.png");
                    selectedModel = "mp_juggernaut_carepackage";
                    break;
                case "Dog":
                    currentImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Dog.png");
                    selectedModel = "mp_fullbody_dog_a";
                    break;
                case "None":
                    currentImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Blank.png");
                    selectedModel = "none";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint neww = 0x0;
            switch (comboBox2.Text)
            {
                case "Chasm (mp_chasm)":
                    neww = 0xAA00;
                    break;
                case "Flooded (mp_flooded)":
                    neww = 0xCD00;
                    break;
                case "Freight (mp_frag)":
                    neww = 0xC800;
                    break;
                case "Octane (mp_dart)":
                    neww = 0xFF00;
                    break;
                case "Overlord (mp_zebra)":
                    neww = 0x9D80;
                    break;
                case "Prison Break (mp_prisonbreak)":
                    neww = 0x7F80;
                    break;
                case "Siege (mp_hashima)":
                    neww = 0xEB00;
                    break;
                case "Sovereign (mp_sovereign)":
                    neww = 0x11080;
                    break;
                case "Stormfront (mp_fahrenheit)":
                    neww = 0x19780;
                    break;
                case "Tremor (mp_lonestar)":
                    neww = 0xFC80;
                    break;
                case "Stone Haven (mp_skeleton)":
                    neww = 0x8480;
                    break;
                case "Warhawk (mp_warhawk)":
                    neww = 0xA000;
                    break;
                case "Whiteout (mp_snow)":
                    neww = 0xCA80;
                    break;
            }
            MapBrushModel = 0x83307200 + neww;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Console.activeConnection == false)
            {
                try
                {
                    Console.Connect();
                }
                catch
                {
                   
                }
            }
            if (Console.activeConnection == true)
            {
                if (ufo == false)
                {
                    Console.Memory.WriteInt32(getPlayerState((uint)numericUpDown1.Value) + 0x321C, 2);
                }
                else
                {
                    Console.Memory.WriteInt32(getPlayerState((uint)numericUpDown1.Value) + 0x321C, 0);
                }
            }
            else
            {
                MessageBox.Show("Unable to Connect to your Console");
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (Console.activeConnection == false)
            {
                try
                {
                    Console.Connect();
                }
                catch
                {
                    
                }
            }
            if (Console.activeConnection == true)
            {
                Console.CallFloat(getPlayerState((uint)numericUpDown1.Value) + 0x1c, (float)250);
                Console.CallFloat(getPlayerState((uint)numericUpDown1.Value) + 0x20, (float)250);
                Console.CallFloat(getPlayerState((uint)numericUpDown1.Value) + 0x24, (float)25000);
            }
            else
            {
                MessageBox.Show("Unable to Connect to your Console");
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
