namespace WindowsFormsApplication6
{
    partial class CorRev
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
            pregameGTCycleThread.Abort();
            ingamegtcyclethread.Abort();
            tbagthread.Abort();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorRev));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.Settings = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.Multiplayer = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.buttonX59 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX56 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonX19 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX17 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX16 = new DevComponents.DotNetBar.ButtonX();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBoxX6 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.buttonX15 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX14 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX13 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX11 = new DevComponents.DotNetBar.ButtonX();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.slider6 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider11 = new DevComponents.DotNetBar.Controls.Slider();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.slider5 = new DevComponents.DotNetBar.Controls.Slider();
            this.checkBoxX4 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.slider4 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider3 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider2 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider1 = new DevComponents.DotNetBar.Controls.Slider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label91 = new System.Windows.Forms.Label();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.switchButton6 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label6 = new System.Windows.Forms.Label();
            this.switchButton22 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton8 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton5 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label8 = new System.Windows.Forms.Label();
            this.switchButton10 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label10 = new System.Windows.Forms.Label();
            this.switchButton7 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.switchButton2 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label92 = new System.Windows.Forms.Label();
            this.buttonX60 = new DevComponents.DotNetBar.ButtonX();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.switchButton23 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.label66 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.switchButton16 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.switchButton24 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchButton9 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.Extinction = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.buttonX33 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX34 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX35 = new DevComponents.DotNetBar.ButtonX();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label70 = new System.Windows.Forms.Label();
            this.switchButton21 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.switchButton11 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton12 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton13 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton14 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton15 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton17 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton18 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton19 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switchButton20 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label72 = new System.Windows.Forms.Label();
            this.slider13 = new DevComponents.DotNetBar.Controls.Slider();
            this.label71 = new System.Windows.Forms.Label();
            this.slider12 = new DevComponents.DotNetBar.Controls.Slider();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBoxX7 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX8 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX10 = new DevComponents.DotNetBar.ButtonX();
            this.slider7 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider8 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider9 = new DevComponents.DotNetBar.Controls.Slider();
            this.slider10 = new DevComponents.DotNetBar.Controls.Slider();
            this.ribbonPanel7 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.ribbonPanel10 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel11 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.clanTag = new System.Windows.Forms.TextBox();
            this.buttonX52 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonX49 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flip = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonX48 = new DevComponents.DotNetBar.ButtonX();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.NumericUpDown();
            this.y = new System.Windows.Forms.NumericUpDown();
            this.z = new System.Windows.Forms.NumericUpDown();
            this.yaw = new System.Windows.Forms.NumericUpDown();
            this.pitch = new System.Windows.Forms.NumericUpDown();
            this.roll = new System.Windows.Forms.NumericUpDown();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.buttonX42 = new DevComponents.DotNetBar.ButtonX();
            this.codeGen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.buttonX43 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX44 = new DevComponents.DotNetBar.ButtonX();
            this.tx = new System.Windows.Forms.NumericUpDown();
            this.ty = new System.Windows.Forms.NumericUpDown();
            this.buttonX54 = new DevComponents.DotNetBar.ButtonX();
            this.models = new System.Windows.Forms.ComboBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.buttonX38 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX39 = new DevComponents.DotNetBar.ButtonX();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.buttonX45 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX46 = new DevComponents.DotNetBar.ButtonX();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown28 = new System.Windows.Forms.NumericUpDown();
            this.Except = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.numericUpDown29 = new System.Windows.Forms.NumericUpDown();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown34 = new System.Windows.Forms.NumericUpDown();
            this.ExceptNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.buttonX40 = new DevComponents.DotNetBar.ButtonX();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.buttonX41 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.ribbonPanel9 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.buttonX87 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX58 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.buttonX57 = new DevComponents.DotNetBar.ButtonX();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.buttonX86 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX85 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX84 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX83 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX82 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.checkerBoard = new System.Windows.Forms.CheckBox();
            this.buttonX81 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX80 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX77 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX78 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX79 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.buttonX75 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX76 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX73 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX74 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX71 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX72 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.buttonX70 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX69 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX68 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.buttonX67 = new DevComponents.DotNetBar.ButtonX();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.buttonX66 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.buttonX65 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX64 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX63 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX62 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX61 = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.buttonX37 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.LightYellow = new System.Windows.Forms.Button();
            this.YaleBlue = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Grey = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Default = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.ribbonPanel6 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.buttonX36 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.button56 = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonX26 = new DevComponents.DotNetBar.ButtonX();
            this.label45 = new System.Windows.Forms.Label();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.buttonX50 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX47 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX55 = new DevComponents.DotNetBar.ButtonX();
            this.circularProgress2 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.buttonX21 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX53 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX51 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX18 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX29 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX30 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX31 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX32 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX25 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX27 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX28 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX23 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX24 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX22 = new DevComponents.DotNetBar.ButtonX();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown30 = new System.Windows.Forms.NumericUpDown();
            this.button54 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.ribbonPanel8 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.Stats = new DevComponents.DotNetBar.RibbonTabItem();
            this.Text1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.Gamertag = new DevComponents.DotNetBar.RibbonTabItem();
            this.mis = new DevComponents.DotNetBar.RibbonTabItem();
            this.Premium = new DevComponents.DotNetBar.RibbonTabItem();
            this.label54 = new System.Windows.Forms.Label();
            this.buttonX20 = new DevComponents.DotNetBar.ButtonX();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gclient = new DevComponents.DotNetBar.ButtonX();
            this.Misc = new DevComponents.DotNetBar.RibbonTabItem();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.MOTD = new System.Windows.Forms.TextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.ribbonPanel7.SuspendLayout();
            this.ribbonPanel10.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ty)).BeginInit();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExceptNum)).BeginInit();
            this.groupBox21.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ribbonPanel9.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            this.groupBox30.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.ribbonPanel6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            this.buttonX55.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMerge = false;
            this.ribbonControl1.AutoExpand = false;
            this.ribbonControl1.AutoKeyboardExpand = false;
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel7);
            this.ribbonControl1.Controls.Add(this.ribbonPanel9);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel6);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel8);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.Multiplayer,
            this.Extinction});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MdiSystemItemVisible = false;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 598);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.Image = ((System.Drawing.Image)(resources.GetObject("applicationButton1.Image")));
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 0;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.applicationButton1.Text = "&File";
            this.applicationButton1.Click += new System.EventHandler(this.applicationButton1_Click);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.BackColor = System.Drawing.Color.White;
            this.itemContainer1.BackgroundStyle.BackColor2 = System.Drawing.Color.White;
            this.itemContainer1.BackgroundStyle.BackgroundImageAlpha = ((byte)(0));
            this.itemContainer1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemContainer1.BackgroundStyle.BorderColor = System.Drawing.Color.Black;
            this.itemContainer1.BackgroundStyle.BorderColor2 = System.Drawing.Color.Black;
            this.itemContainer1.BackgroundStyle.BorderColorLight = System.Drawing.Color.Black;
            this.itemContainer1.BackgroundStyle.BorderColorLight2 = System.Drawing.Color.Black;
            this.itemContainer1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemContainer1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemContainer1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = -2;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem4,
            this.buttonItem3,
            this.buttonItem6,
            this.Settings,
            this.buttonItem7,
            this.buttonItem1});
            this.itemContainer1.TitlePosition = DevComponents.DotNetBar.eTitlePosition.Bottom;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.BackColor = System.Drawing.Color.White;
            this.itemContainer1.TitleStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.itemContainer1.TitleStyle.BorderBottomColor = System.Drawing.Color.Black;
            this.itemContainer1.TitleStyle.BorderColor = System.Drawing.Color.Black;
            this.itemContainer1.TitleStyle.BorderColor2 = System.Drawing.Color.White;
            this.itemContainer1.TitleStyle.BorderColorLight = System.Drawing.Color.White;
            this.itemContainer1.TitleStyle.BorderColorLight2 = System.Drawing.Color.White;
            this.itemContainer1.TitleStyle.BorderLeftColor = System.Drawing.Color.White;
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer1.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.itemContainer1.TitleStyle.TextColor = System.Drawing.Color.Transparent;
            this.itemContainer1.TitleStyle.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.itemContainer1.TitleStyle.TextShadowColor = System.Drawing.Color.Black;
            this.itemContainer1.TitleStyle.TextShadowOffset = new System.Drawing.Point(0, -5);
            this.itemContainer1.TitleText = "___________________\r\nUnsigned Nation";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = global::Delusion.Properties.Resources.Recurrence_32x32;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "Connect";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = global::Delusion.Properties.Resources.NewWizard_32x32_4;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.StopPulseOnMouseOver = false;
            this.buttonItem4.SubItemsExpandWidth = 24;
            this.buttonItem4.Text = "Troubleshoot";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = global::Delusion.Properties.Resources.Save_32x32;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 24;
            this.buttonItem3.Text = "Donate";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Image = global::Delusion.Properties.Resources.Preview_32x32;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "DieselGaming";
            this.buttonItem6.Click += new System.EventHandler(this.buttonItem6_Click);
            // 
            // Settings
            // 
            this.Settings.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.Settings.Image = global::Delusion.Properties.Resources.Customization_32x32;
            this.Settings.Name = "Settings";
            this.Settings.SubItemsExpandWidth = 124;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // buttonItem7
            // 
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Image = global::Delusion.Properties.Resources.Find_32x32;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "Check for Updates";
            this.buttonItem7.Click += new System.EventHandler(this.buttonItem7_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::Delusion.Properties.Resources.Index_32x32;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 24;
            this.buttonItem1.Text = "Credits";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // Multiplayer
            // 
            this.Multiplayer.Checked = true;
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Panel = this.ribbonPanel1;
            this.Multiplayer.Text = "Multiplayer";
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.buttonX59);
            this.ribbonPanel1.Controls.Add(this.buttonX56);
            this.ribbonPanel1.Controls.Add(this.groupBox9);
            this.ribbonPanel1.Controls.Add(this.groupBox8);
            this.ribbonPanel1.Controls.Add(this.groupBox6);
            this.ribbonPanel1.Controls.Add(this.groupBox2);
            this.ribbonPanel1.Controls.Add(this.groupBox1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(800, 573);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Click += new System.EventHandler(this.ribbonPanel1_Click);
            // 
            // buttonX59
            // 
            this.buttonX59.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX59.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX59.Enabled = false;
            this.buttonX59.Location = new System.Drawing.Point(13, 4);
            this.buttonX59.Name = "buttonX59";
            this.buttonX59.Size = new System.Drawing.Size(89, 31);
            this.buttonX59.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX59.TabIndex = 29;
            this.buttonX59.Text = "Reset All Client";
            this.buttonX59.Click += new System.EventHandler(this.buttonX59_Click);
            // 
            // buttonX56
            // 
            this.buttonX56.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX56.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX56.Enabled = false;
            this.buttonX56.Location = new System.Drawing.Point(107, 4);
            this.buttonX56.Name = "buttonX56";
            this.buttonX56.Size = new System.Drawing.Size(80, 31);
            this.buttonX56.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX56.TabIndex = 27;
            this.buttonX56.Text = "Reset Others";
            this.buttonX56.Click += new System.EventHandler(this.buttonX56_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.buttonX19);
            this.groupBox9.Controls.Add(this.buttonX17);
            this.groupBox9.Controls.Add(this.buttonX16);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.label37);
            this.groupBox9.Controls.Add(this.checkBoxX6);
            this.groupBox9.Controls.Add(this.comboBox2);
            this.groupBox9.Controls.Add(this.comboBox3);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(193, 396);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(432, 131);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Weapons and Models";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // buttonX19
            // 
            this.buttonX19.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX19.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX19.Location = new System.Drawing.Point(438, 42);
            this.buttonX19.Name = "buttonX19";
            this.buttonX19.Size = new System.Drawing.Size(159, 38);
            this.buttonX19.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX19.TabIndex = 36;
            this.buttonX19.Text = "Default";
            // 
            // buttonX17
            // 
            this.buttonX17.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX17.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX17.Location = new System.Drawing.Point(9, 100);
            this.buttonX17.Name = "buttonX17";
            this.buttonX17.Size = new System.Drawing.Size(417, 25);
            this.buttonX17.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX17.TabIndex = 46;
            this.buttonX17.Text = "Send";
            this.buttonX17.Click += new System.EventHandler(this.buttonX17_Click);
            // 
            // buttonX16
            // 
            this.buttonX16.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX16.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX16.Location = new System.Drawing.Point(92, 43);
            this.buttonX16.Name = "buttonX16";
            this.buttonX16.Size = new System.Drawing.Size(334, 25);
            this.buttonX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX16.TabIndex = 45;
            this.buttonX16.Text = "Send";
            this.buttonX16.Click += new System.EventHandler(this.buttonX16_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(6, 73);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 13);
            this.label38.TabIndex = 44;
            this.label38.Text = "Models";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(6, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 13);
            this.label37.TabIndex = 43;
            this.label37.Text = "Weapons";
            // 
            // checkBoxX6
            // 
            // 
            // 
            // 
            this.checkBoxX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX6.Location = new System.Drawing.Point(6, 48);
            this.checkBoxX6.Name = "checkBoxX6";
            this.checkBoxX6.Size = new System.Drawing.Size(66, 13);
            this.checkBoxX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX6.TabIndex = 42;
            this.checkBoxX6.Text = " Akimbo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(92, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(334, 21);
            this.comboBox2.TabIndex = 41;
            this.comboBox2.Text = "void";
            // 
            // comboBox3
            // 
            this.comboBox3.Items.AddRange(new object[] {
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
            this.comboBox3.Location = new System.Drawing.Point(92, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(334, 21);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.Text = "smoke_grenade_mp";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this.label33);
            this.groupBox8.Controls.Add(this.label34);
            this.groupBox8.Controls.Add(this.label35);
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Controls.Add(this.buttonX15);
            this.groupBox8.Controls.Add(this.buttonX14);
            this.groupBox8.Controls.Add(this.buttonX13);
            this.groupBox8.Controls.Add(this.buttonX12);
            this.groupBox8.Controls.Add(this.buttonX11);
            this.groupBox8.Controls.Add(this.numericUpDown5);
            this.groupBox8.Controls.Add(this.numericUpDown4);
            this.groupBox8.Controls.Add(this.numericUpDown3);
            this.groupBox8.Controls.Add(this.numericUpDown2);
            this.groupBox8.Controls.Add(this.comboBox1);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(193, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(432, 187);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Game Settings";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(6, 127);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 42;
            this.label32.Text = "Score Limit";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(6, 102);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 13);
            this.label33.TabIndex = 41;
            this.label33.Text = "Time Limit";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(6, 77);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 13);
            this.label34.TabIndex = 40;
            this.label34.Text = "Nuke Timer";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(6, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 13);
            this.label35.TabIndex = 39;
            this.label35.Text = "XP Per Kill";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(7, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 38;
            this.label36.Text = "Gametype";
            // 
            // buttonX15
            // 
            this.buttonX15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX15.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX15.Location = new System.Drawing.Point(340, 124);
            this.buttonX15.Name = "buttonX15";
            this.buttonX15.Size = new System.Drawing.Size(87, 20);
            this.buttonX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX15.TabIndex = 37;
            this.buttonX15.Text = "Send";
            this.buttonX15.Click += new System.EventHandler(this.buttonX15_Click);
            // 
            // buttonX14
            // 
            this.buttonX14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX14.Location = new System.Drawing.Point(340, 99);
            this.buttonX14.Name = "buttonX14";
            this.buttonX14.Size = new System.Drawing.Size(87, 20);
            this.buttonX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX14.TabIndex = 36;
            this.buttonX14.Text = "Send";
            this.buttonX14.Click += new System.EventHandler(this.buttonX14_Click);
            // 
            // buttonX13
            // 
            this.buttonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX13.Location = new System.Drawing.Point(340, 74);
            this.buttonX13.Name = "buttonX13";
            this.buttonX13.Size = new System.Drawing.Size(87, 20);
            this.buttonX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX13.TabIndex = 35;
            this.buttonX13.Text = "Send";
            this.buttonX13.Click += new System.EventHandler(this.buttonX13_Click);
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX12.Location = new System.Drawing.Point(340, 49);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Size = new System.Drawing.Size(86, 20);
            this.buttonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX12.TabIndex = 34;
            this.buttonX12.Text = "Send";
            this.buttonX12.Click += new System.EventHandler(this.buttonX12_Click);
            // 
            // buttonX11
            // 
            this.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX11.Location = new System.Drawing.Point(6, 149);
            this.buttonX11.Name = "buttonX11";
            this.buttonX11.Size = new System.Drawing.Size(421, 25);
            this.buttonX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX11.TabIndex = 33;
            this.buttonX11.Text = "Force Host";
            this.buttonX11.Click += new System.EventHandler(this.buttonX11_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(86, 124);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(247, 20);
            this.numericUpDown5.TabIndex = 32;
            this.numericUpDown5.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(86, 99);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(247, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(86, 74);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(247, 20);
            this.numericUpDown3.TabIndex = 30;
            this.numericUpDown3.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(86, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(247, 20);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Domination",
            "Team Deathmatch",
            "Free for All",
            "Search and Destroy",
            "Search and Rescue",
            "Kill Confirmed",
            "Demolition",
            "Blitz",
            "Infected",
            "Hunted",
            "Grind",
            "Cranked",
            "Safeguard",
            "Hunted FFA"});
            this.comboBox1.Location = new System.Drawing.Point(86, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Domination";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.Controls.Add(this.label69);
            this.groupBox6.Controls.Add(this.slider6);
            this.groupBox6.Controls.Add(this.slider11);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.slider5);
            this.groupBox6.Controls.Add(this.checkBoxX4);
            this.groupBox6.Controls.Add(this.checkBoxX3);
            this.groupBox6.Controls.Add(this.buttonX9);
            this.groupBox6.Controls.Add(this.slider4);
            this.groupBox6.Controls.Add(this.slider3);
            this.groupBox6.Controls.Add(this.slider2);
            this.groupBox6.Controls.Add(this.slider1);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(193, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(432, 199);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sliders";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Location = new System.Drawing.Point(6, 140);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(38, 13);
            this.label67.TabIndex = 40;
            this.label67.Text = "Speed";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Location = new System.Drawing.Point(6, 120);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(73, 13);
            this.label69.TabIndex = 39;
            this.label69.Text = "Crosshair Size";
            // 
            // slider6
            // 
            // 
            // 
            // 
            this.slider6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider6.Location = new System.Drawing.Point(52, 140);
            this.slider6.Maximum = 20;
            this.slider6.Minimum = 1;
            this.slider6.Name = "slider6";
            this.slider6.Size = new System.Drawing.Size(371, 19);
            this.slider6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider6.TabIndex = 38;
            this.slider6.Text = " ";
            this.slider6.Value = 1;
            this.slider6.ValueChanged += new System.EventHandler(this.slider6_ValueChanged);
            // 
            // slider11
            // 
            // 
            // 
            // 
            this.slider11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider11.Location = new System.Drawing.Point(52, 120);
            this.slider11.Maximum = 562;
            this.slider11.Minimum = 512;
            this.slider11.Name = "slider11";
            this.slider11.Size = new System.Drawing.Size(371, 19);
            this.slider11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider11.TabIndex = 37;
            this.slider11.Text = " ";
            this.slider11.Value = 520;
            this.slider11.ValueChanged += new System.EventHandler(this.slider11_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(6, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "UAV Size";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(6, 80);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Fall Damage";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(6, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "Jump Height";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(6, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 33;
            this.label24.Text = "FOV";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(6, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Wallhack";
            // 
            // slider5
            // 
            // 
            // 
            // 
            this.slider5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider5.Location = new System.Drawing.Point(52, 100);
            this.slider5.Maximum = 4;
            this.slider5.Minimum = 1;
            this.slider5.Name = "slider5";
            this.slider5.Size = new System.Drawing.Size(371, 19);
            this.slider5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider5.TabIndex = 29;
            this.slider5.Text = " ";
            this.slider5.Value = 1;
            this.slider5.ValueChanged += new System.EventHandler(this.slider5_ValueChanged);
            // 
            // checkBoxX4
            // 
            // 
            // 
            // 
            this.checkBoxX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX4.Location = new System.Drawing.Point(385, 80);
            this.checkBoxX4.Name = "checkBoxX4";
            this.checkBoxX4.Size = new System.Drawing.Size(41, 13);
            this.checkBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX4.TabIndex = 28;
            this.checkBoxX4.Text = "x10";
            this.checkBoxX4.CheckedChanged += new System.EventHandler(this.checkBoxX4_CheckedChanged);
            // 
            // checkBoxX3
            // 
            // 
            // 
            // 
            this.checkBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX3.Location = new System.Drawing.Point(385, 60);
            this.checkBoxX3.Name = "checkBoxX3";
            this.checkBoxX3.Size = new System.Drawing.Size(41, 13);
            this.checkBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX3.TabIndex = 27;
            this.checkBoxX3.Text = "x10";
            this.checkBoxX3.CheckedChanged += new System.EventHandler(this.checkBoxX3_CheckedChanged);
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(6, 165);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(420, 25);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 24;
            this.buttonX9.Text = "Default";
            this.buttonX9.Click += new System.EventHandler(this.buttonX9_Click);
            // 
            // slider4
            // 
            // 
            // 
            // 
            this.slider4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider4.Location = new System.Drawing.Point(52, 80);
            this.slider4.Maximum = 1000;
            this.slider4.Name = "slider4";
            this.slider4.Size = new System.Drawing.Size(333, 19);
            this.slider4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider4.TabIndex = 3;
            this.slider4.Text = " ";
            this.slider4.Value = 39;
            this.slider4.ValueChanged += new System.EventHandler(this.slider4_ValueChanged);
            // 
            // slider3
            // 
            // 
            // 
            // 
            this.slider3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider3.Location = new System.Drawing.Point(52, 60);
            this.slider3.Maximum = 1000;
            this.slider3.Name = "slider3";
            this.slider3.Size = new System.Drawing.Size(333, 19);
            this.slider3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider3.TabIndex = 2;
            this.slider3.Value = 39;
            this.slider3.ValueChanged += new System.EventHandler(this.slider3_ValueChanged);
            // 
            // slider2
            // 
            // 
            // 
            // 
            this.slider2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider2.Location = new System.Drawing.Point(52, 40);
            this.slider2.Maximum = 130;
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(371, 19);
            this.slider2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider2.TabIndex = 1;
            this.slider2.Text = " ";
            this.slider2.Value = 65;
            this.slider2.ValueChanged += new System.EventHandler(this.slider2_ValueChanged);
            // 
            // slider1
            // 
            // 
            // 
            // 
            this.slider1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider1.Location = new System.Drawing.Point(52, 20);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(373, 19);
            this.slider1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider1.TabIndex = 0;
            this.slider1.Text = " ";
            this.slider1.Value = 4;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label91);
            this.groupBox2.Controls.Add(this.buttonX2);
            this.groupBox2.Controls.Add(this.switchButton6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.switchButton22);
            this.groupBox2.Controls.Add(this.switchButton8);
            this.groupBox2.Controls.Add(this.switchButton5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.switchButton10);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.switchButton7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offhost/Local Client Toggles";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.Transparent;
            this.label91.Location = new System.Drawing.Point(4, 21);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(44, 13);
            this.label91.TabIndex = 36;
            this.label91.Text = "Redbox";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Location = new System.Drawing.Point(0, 0);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(0, 0);
            this.buttonX2.TabIndex = 6;
            // 
            // switchButton6
            // 
            // 
            // 
            // 
            this.switchButton6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton6.Location = new System.Drawing.Point(100, 142);
            this.switchButton6.Name = "switchButton6";
            this.switchButton6.Size = new System.Drawing.Size(62, 27);
            this.switchButton6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton6.TabIndex = 11;
            this.switchButton6.ValueChanged += new System.EventHandler(this.switchButton6_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(5, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "No Recoil";
            // 
            // switchButton22
            // 
            // 
            // 
            // 
            this.switchButton22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton22.Location = new System.Drawing.Point(100, 18);
            this.switchButton22.Name = "switchButton22";
            this.switchButton22.Size = new System.Drawing.Size(62, 27);
            this.switchButton22.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton22.TabIndex = 35;
            this.switchButton22.ValueChanged += new System.EventHandler(this.switchButton22_ValueChanged);
            // 
            // switchButton8
            // 
            // 
            // 
            // 
            this.switchButton8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton8.Location = new System.Drawing.Point(100, 173);
            this.switchButton8.Name = "switchButton8";
            this.switchButton8.Size = new System.Drawing.Size(62, 27);
            this.switchButton8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton8.TabIndex = 21;
            this.switchButton8.ValueChanged += new System.EventHandler(this.switchButton8_ValueChanged);
            // 
            // switchButton5
            // 
            // 
            // 
            // 
            this.switchButton5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton5.Location = new System.Drawing.Point(100, 111);
            this.switchButton5.Name = "switchButton5";
            this.switchButton5.Size = new System.Drawing.Size(62, 27);
            this.switchButton5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton5.TabIndex = 9;
            this.switchButton5.ValueChanged += new System.EventHandler(this.switchButton5_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(5, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Third Person";
            // 
            // switchButton10
            // 
            // 
            // 
            // 
            this.switchButton10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton10.Location = new System.Drawing.Point(100, 80);
            this.switchButton10.Name = "switchButton10";
            this.switchButton10.Size = new System.Drawing.Size(62, 27);
            this.switchButton10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton10.TabIndex = 21;
            this.switchButton10.ValueChanged += new System.EventHandler(this.switchButton10_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(5, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Laser";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // switchButton7
            // 
            // 
            // 
            // 
            this.switchButton7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton7.Location = new System.Drawing.Point(100, 49);
            this.switchButton7.Name = "switchButton7";
            this.switchButton7.Size = new System.Drawing.Size(62, 27);
            this.switchButton7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton7.TabIndex = 23;
            this.switchButton7.ValueChanged += new System.EventHandler(this.switchButton7_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(4, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Thermal Players";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "UAV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.switchButton2);
            this.groupBox1.Controls.Add(this.label92);
            this.groupBox1.Controls.Add(this.buttonX60);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.switchButton23);
            this.groupBox1.Controls.Add(this.buttonX3);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label93);
            this.groupBox1.Controls.Add(this.switchButton16);
            this.groupBox1.Controls.Add(this.buttonX1);
            this.groupBox1.Controls.Add(this.switchButton24);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.switchButton9);
            this.groupBox1.Controls.Add(this.switchButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Only All Client Toggles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Redbox";
            // 
            // switchButton2
            // 
            // 
            // 
            // 
            this.switchButton2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton2.Location = new System.Drawing.Point(99, 179);
            this.switchButton2.Name = "switchButton2";
            this.switchButton2.Size = new System.Drawing.Size(62, 27);
            this.switchButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton2.TabIndex = 42;
            this.switchButton2.ValueChanged += new System.EventHandler(this.switchButton2_ValueChanged);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.Location = new System.Drawing.Point(4, 152);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(81, 13);
            this.label92.TabIndex = 38;
            this.label92.Text = "Fully Auto Guns";
            // 
            // buttonX60
            // 
            this.buttonX60.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX60.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX60.Location = new System.Drawing.Point(7, 240);
            this.buttonX60.Name = "buttonX60";
            this.buttonX60.Size = new System.Drawing.Size(154, 25);
            this.buttonX60.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX60.TabIndex = 39;
            this.buttonX60.Text = "Send";
            this.buttonX60.Click += new System.EventHandler(this.buttonX60_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Normal",
            "No-Clip",
            "UFO",
            "Freeze"});
            this.comboBox7.Location = new System.Drawing.Point(7, 213);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(154, 21);
            this.comboBox7.TabIndex = 41;
            this.comboBox7.Text = "Normal";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // switchButton23
            // 
            // 
            // 
            // 
            this.switchButton23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton23.Location = new System.Drawing.Point(99, 147);
            this.switchButton23.Name = "switchButton23";
            this.switchButton23.Size = new System.Drawing.Size(62, 27);
            this.switchButton23.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton23.TabIndex = 37;
            this.switchButton23.ValueChanged += new System.EventHandler(this.switchButton23_ValueChanged);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Location = new System.Drawing.Point(0, 0);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(0, 0);
            this.buttonX3.TabIndex = 39;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Location = new System.Drawing.Point(4, 88);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(51, 13);
            this.label66.TabIndex = 34;
            this.label66.Text = "Invisibility";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Transparent;
            this.label93.Location = new System.Drawing.Point(4, 121);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(82, 13);
            this.label93.TabIndex = 36;
            this.label93.Text = "Unlimited Ammo";
            // 
            // switchButton16
            // 
            // 
            // 
            // 
            this.switchButton16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton16.Location = new System.Drawing.Point(99, 83);
            this.switchButton16.Name = "switchButton16";
            this.switchButton16.Size = new System.Drawing.Size(62, 27);
            this.switchButton16.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton16.TabIndex = 33;
            this.switchButton16.ValueChanged += new System.EventHandler(this.switchButton16_ValueChanged_1);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Location = new System.Drawing.Point(0, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(0, 0);
            this.buttonX1.TabIndex = 40;
            // 
            // switchButton24
            // 
            // 
            // 
            // 
            this.switchButton24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton24.Location = new System.Drawing.Point(99, 116);
            this.switchButton24.Name = "switchButton24";
            this.switchButton24.Size = new System.Drawing.Size(62, 27);
            this.switchButton24.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton24.TabIndex = 35;
            this.switchButton24.ValueChanged += new System.EventHandler(this.switchButton24_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(4, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tiny Crosshairs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Godmode";
            // 
            // switchButton9
            // 
            // 
            // 
            // 
            this.switchButton9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton9.Location = new System.Drawing.Point(99, 51);
            this.switchButton9.Name = "switchButton9";
            this.switchButton9.Size = new System.Drawing.Size(62, 27);
            this.switchButton9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton9.TabIndex = 19;
            this.switchButton9.ValueChanged += new System.EventHandler(this.switchButton9_ValueChanged);
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(99, 19);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Size = new System.Drawing.Size(62, 27);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 1;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // Extinction
            // 
            this.Extinction.Name = "Extinction";
            this.Extinction.Panel = this.ribbonPanel2;
            this.Extinction.Text = "Extinction";
            this.Extinction.Click += new System.EventHandler(this.Extinction_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.groupBox11);
            this.ribbonPanel2.Controls.Add(this.groupBox3);
            this.ribbonPanel2.Controls.Add(this.groupBox4);
            this.ribbonPanel2.Controls.Add(this.groupBox7);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(800, 573);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.buttonX33);
            this.groupBox11.Controls.Add(this.buttonX34);
            this.groupBox11.Controls.Add(this.buttonX35);
            this.groupBox11.Controls.Add(this.label51);
            this.groupBox11.Controls.Add(this.label52);
            this.groupBox11.Controls.Add(this.checkBoxX1);
            this.groupBox11.Controls.Add(this.comboBox4);
            this.groupBox11.Controls.Add(this.comboBox5);
            this.groupBox11.Enabled = false;
            this.groupBox11.Location = new System.Drawing.Point(193, 189);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(432, 134);
            this.groupBox11.TabIndex = 38;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Weapons and Models";
            // 
            // buttonX33
            // 
            this.buttonX33.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX33.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX33.Location = new System.Drawing.Point(438, 42);
            this.buttonX33.Name = "buttonX33";
            this.buttonX33.Size = new System.Drawing.Size(159, 38);
            this.buttonX33.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX33.TabIndex = 36;
            this.buttonX33.Text = "Default";
            // 
            // buttonX34
            // 
            this.buttonX34.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX34.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX34.Location = new System.Drawing.Point(9, 100);
            this.buttonX34.Name = "buttonX34";
            this.buttonX34.Size = new System.Drawing.Size(417, 25);
            this.buttonX34.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX34.TabIndex = 46;
            this.buttonX34.Text = "Send";
            this.buttonX34.Click += new System.EventHandler(this.buttonX34_Click);
            // 
            // buttonX35
            // 
            this.buttonX35.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX35.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX35.Location = new System.Drawing.Point(92, 43);
            this.buttonX35.Name = "buttonX35";
            this.buttonX35.Size = new System.Drawing.Size(334, 25);
            this.buttonX35.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX35.TabIndex = 45;
            this.buttonX35.Text = "Send";
            this.buttonX35.Click += new System.EventHandler(this.buttonX35_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Location = new System.Drawing.Point(6, 73);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 13);
            this.label51.TabIndex = 44;
            this.label51.Text = "Models";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Location = new System.Drawing.Point(6, 20);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 13);
            this.label52.TabIndex = 43;
            this.label52.Text = "Weapons";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(6, 48);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(66, 13);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 42;
            this.checkBoxX1.Text = " Akimbo";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(92, 73);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(334, 21);
            this.comboBox4.TabIndex = 41;
            this.comboBox4.Text = "void";
            // 
            // comboBox5
            // 
            this.comboBox5.Items.AddRange(new object[] {
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
            this.comboBox5.Location = new System.Drawing.Point(92, 17);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(334, 21);
            this.comboBox5.TabIndex = 34;
            this.comboBox5.Text = "smoke_grenade_mp";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonX4);
            this.groupBox3.Controls.Add(this.buttonX5);
            this.groupBox3.Controls.Add(this.buttonX6);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 131);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fun Mods";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(10, 86);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(153, 25);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Text = "Fully Automatic Guns";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(10, 55);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(153, 25);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 4;
            this.buttonX5.Text = "Red Boxes";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Location = new System.Drawing.Point(9, 24);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(153, 25);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 3;
            this.buttonX6.Text = "Unlimited Ammo";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label70);
            this.groupBox4.Controls.Add(this.switchButton21);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.switchButton11);
            this.groupBox4.Controls.Add(this.switchButton12);
            this.groupBox4.Controls.Add(this.switchButton13);
            this.groupBox4.Controls.Add(this.switchButton14);
            this.groupBox4.Controls.Add(this.switchButton15);
            this.groupBox4.Controls.Add(this.switchButton17);
            this.groupBox4.Controls.Add(this.switchButton18);
            this.groupBox4.Controls.Add(this.switchButton19);
            this.groupBox4.Controls.Add(this.switchButton20);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 320);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toggles";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Location = new System.Drawing.Point(5, 290);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(51, 13);
            this.label70.TabIndex = 38;
            this.label70.Text = "Invisibility";
            // 
            // switchButton21
            // 
            // 
            // 
            // 
            this.switchButton21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton21.Location = new System.Drawing.Point(100, 285);
            this.switchButton21.Name = "switchButton21";
            this.switchButton21.Size = new System.Drawing.Size(62, 27);
            this.switchButton21.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton21.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(5, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Laser";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(5, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Thermal Players";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(5, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Third Person";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(5, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tiny Crosshair";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(5, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "No Recoil";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(5, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Freeze";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(5, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "UFO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(5, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "No-Clip";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(5, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Godmode";
            // 
            // switchButton11
            // 
            // 
            // 
            // 
            this.switchButton11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton11.Location = new System.Drawing.Point(100, 255);
            this.switchButton11.Name = "switchButton11";
            this.switchButton11.Size = new System.Drawing.Size(62, 27);
            this.switchButton11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton11.TabIndex = 23;
            this.switchButton11.ValueChanged += new System.EventHandler(this.switchButton11_ValueChanged);
            // 
            // switchButton12
            // 
            // 
            // 
            // 
            this.switchButton12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton12.Location = new System.Drawing.Point(100, 225);
            this.switchButton12.Name = "switchButton12";
            this.switchButton12.Size = new System.Drawing.Size(62, 27);
            this.switchButton12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton12.TabIndex = 21;
            this.switchButton12.ValueChanged += new System.EventHandler(this.switchButton12_ValueChanged);
            // 
            // switchButton13
            // 
            // 
            // 
            // 
            this.switchButton13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton13.Location = new System.Drawing.Point(100, 195);
            this.switchButton13.Name = "switchButton13";
            this.switchButton13.Size = new System.Drawing.Size(62, 27);
            this.switchButton13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton13.TabIndex = 21;
            this.switchButton13.ValueChanged += new System.EventHandler(this.switchButton13_ValueChanged);
            // 
            // switchButton14
            // 
            // 
            // 
            // 
            this.switchButton14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton14.Location = new System.Drawing.Point(100, 165);
            this.switchButton14.Name = "switchButton14";
            this.switchButton14.Size = new System.Drawing.Size(62, 27);
            this.switchButton14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton14.TabIndex = 19;
            this.switchButton14.ValueChanged += new System.EventHandler(this.switchButton14_ValueChanged);
            // 
            // switchButton15
            // 
            // 
            // 
            // 
            this.switchButton15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton15.Location = new System.Drawing.Point(100, 135);
            this.switchButton15.Name = "switchButton15";
            this.switchButton15.Size = new System.Drawing.Size(62, 27);
            this.switchButton15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton15.TabIndex = 11;
            this.switchButton15.ValueChanged += new System.EventHandler(this.switchButton15_ValueChanged);
            // 
            // switchButton17
            // 
            // 
            // 
            // 
            this.switchButton17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton17.Location = new System.Drawing.Point(100, 105);
            this.switchButton17.Name = "switchButton17";
            this.switchButton17.Size = new System.Drawing.Size(62, 27);
            this.switchButton17.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton17.TabIndex = 7;
            this.switchButton17.ValueChanged += new System.EventHandler(this.switchButton17_ValueChanged);
            // 
            // switchButton18
            // 
            // 
            // 
            // 
            this.switchButton18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton18.Location = new System.Drawing.Point(100, 75);
            this.switchButton18.Name = "switchButton18";
            this.switchButton18.Size = new System.Drawing.Size(62, 27);
            this.switchButton18.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton18.TabIndex = 5;
            this.switchButton18.ValueChanged += new System.EventHandler(this.switchButton18_ValueChanged);
            // 
            // switchButton19
            // 
            // 
            // 
            // 
            this.switchButton19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton19.Location = new System.Drawing.Point(100, 45);
            this.switchButton19.Name = "switchButton19";
            this.switchButton19.Size = new System.Drawing.Size(62, 27);
            this.switchButton19.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton19.TabIndex = 3;
            this.switchButton19.ValueChanged += new System.EventHandler(this.switchButton19_ValueChanged);
            // 
            // switchButton20
            // 
            // 
            // 
            // 
            this.switchButton20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton20.Location = new System.Drawing.Point(100, 15);
            this.switchButton20.Name = "switchButton20";
            this.switchButton20.Size = new System.Drawing.Size(62, 27);
            this.switchButton20.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton20.TabIndex = 1;
            this.switchButton20.ValueChanged += new System.EventHandler(this.switchButton20_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label72);
            this.groupBox7.Controls.Add(this.slider13);
            this.groupBox7.Controls.Add(this.label71);
            this.groupBox7.Controls.Add(this.slider12);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.checkBoxX7);
            this.groupBox7.Controls.Add(this.checkBoxX8);
            this.groupBox7.Controls.Add(this.buttonX10);
            this.groupBox7.Controls.Add(this.slider7);
            this.groupBox7.Controls.Add(this.slider8);
            this.groupBox7.Controls.Add(this.slider9);
            this.groupBox7.Controls.Add(this.slider10);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(193, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(432, 181);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sliders";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Location = new System.Drawing.Point(6, 120);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 13);
            this.label72.TabIndex = 43;
            this.label72.Text = "Speed";
            // 
            // slider13
            // 
            // 
            // 
            // 
            this.slider13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider13.Location = new System.Drawing.Point(52, 120);
            this.slider13.Maximum = 20;
            this.slider13.Minimum = 1;
            this.slider13.Name = "slider13";
            this.slider13.Size = new System.Drawing.Size(371, 19);
            this.slider13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider13.TabIndex = 42;
            this.slider13.Text = " ";
            this.slider13.Value = 1;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Location = new System.Drawing.Point(6, 100);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(73, 13);
            this.label71.TabIndex = 41;
            this.label71.Text = "Crosshair Size";
            // 
            // slider12
            // 
            // 
            // 
            // 
            this.slider12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider12.Location = new System.Drawing.Point(52, 100);
            this.slider12.Maximum = 562;
            this.slider12.Minimum = 512;
            this.slider12.Name = "slider12";
            this.slider12.Size = new System.Drawing.Size(371, 19);
            this.slider12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider12.TabIndex = 40;
            this.slider12.Text = " ";
            this.slider12.Value = 520;
            this.slider12.ValueChanged += new System.EventHandler(this.slider12_ValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(6, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 13);
            this.label28.TabIndex = 39;
            this.label28.Text = "Fall Damage";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(6, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 13);
            this.label29.TabIndex = 38;
            this.label29.Text = "Jump Height";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(6, 40);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 37;
            this.label30.Text = "FOV";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(6, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 36;
            this.label31.Text = "Wallhack";
            // 
            // checkBoxX7
            // 
            // 
            // 
            // 
            this.checkBoxX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX7.Location = new System.Drawing.Point(385, 80);
            this.checkBoxX7.Name = "checkBoxX7";
            this.checkBoxX7.Size = new System.Drawing.Size(41, 13);
            this.checkBoxX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX7.TabIndex = 28;
            this.checkBoxX7.Text = "x10";
            this.checkBoxX7.CheckedChanged += new System.EventHandler(this.checkBoxX7_CheckedChanged);
            // 
            // checkBoxX8
            // 
            // 
            // 
            // 
            this.checkBoxX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX8.Location = new System.Drawing.Point(385, 60);
            this.checkBoxX8.Name = "checkBoxX8";
            this.checkBoxX8.Size = new System.Drawing.Size(41, 13);
            this.checkBoxX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX8.TabIndex = 27;
            this.checkBoxX8.Text = "x10";
            this.checkBoxX8.CheckedChanged += new System.EventHandler(this.checkBoxX8_CheckedChanged);
            // 
            // buttonX10
            // 
            this.buttonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX10.Location = new System.Drawing.Point(12, 150);
            this.buttonX10.Name = "buttonX10";
            this.buttonX10.Size = new System.Drawing.Size(420, 25);
            this.buttonX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX10.TabIndex = 24;
            this.buttonX10.Text = "Default";
            this.buttonX10.Click += new System.EventHandler(this.buttonX10_Click);
            // 
            // slider7
            // 
            // 
            // 
            // 
            this.slider7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider7.Location = new System.Drawing.Point(52, 80);
            this.slider7.Maximum = 1000;
            this.slider7.Name = "slider7";
            this.slider7.Size = new System.Drawing.Size(333, 19);
            this.slider7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider7.TabIndex = 3;
            this.slider7.Text = " ";
            this.slider7.Value = 39;
            this.slider7.ValueChanged += new System.EventHandler(this.slider7_ValueChanged);
            // 
            // slider8
            // 
            // 
            // 
            // 
            this.slider8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider8.Location = new System.Drawing.Point(52, 60);
            this.slider8.Maximum = 1000;
            this.slider8.Name = "slider8";
            this.slider8.Size = new System.Drawing.Size(333, 19);
            this.slider8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider8.TabIndex = 2;
            this.slider8.Value = 39;
            this.slider8.ValueChanged += new System.EventHandler(this.slider8_ValueChanged);
            // 
            // slider9
            // 
            // 
            // 
            // 
            this.slider9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider9.Location = new System.Drawing.Point(52, 40);
            this.slider9.Maximum = 130;
            this.slider9.Name = "slider9";
            this.slider9.Size = new System.Drawing.Size(371, 19);
            this.slider9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider9.TabIndex = 1;
            this.slider9.Text = " ";
            this.slider9.Value = 65;
            this.slider9.ValueChanged += new System.EventHandler(this.slider9_ValueChanged);
            // 
            // slider10
            // 
            // 
            // 
            // 
            this.slider10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.slider10.Location = new System.Drawing.Point(52, 20);
            this.slider10.Name = "slider10";
            this.slider10.Size = new System.Drawing.Size(371, 19);
            this.slider10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.slider10.TabIndex = 0;
            this.slider10.Text = " ";
            this.slider10.Value = 4;
            this.slider10.ValueChanged += new System.EventHandler(this.slider10_ValueChanged);
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel7.Controls.Add(this.groupBox32);
            this.ribbonPanel7.Controls.Add(this.groupBox23);
            this.ribbonPanel7.Controls.Add(this.groupBox22);
            this.ribbonPanel7.Controls.Add(this.groupBox20);
            this.ribbonPanel7.Controls.Add(this.groupBox19);
            this.ribbonPanel7.Controls.Add(this.groupBox18);
            this.ribbonPanel7.Controls.Add(this.groupBox21);
            this.ribbonPanel7.Controls.Add(this.groupBox5);
            this.ribbonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel7.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel7.Size = new System.Drawing.Size(800, 573);
            // 
            // 
            // 
            this.ribbonPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel7.TabIndex = 7;
            // 
            // groupBox32
            // 
            this.groupBox32.Location = new System.Drawing.Point(796, 3);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(149, 100);
            this.groupBox32.TabIndex = 41;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "groupBox32";
            // 
            // ribbonPanel10
            // 
            this.ribbonPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel10.Controls.Add(this.ribbonBar1);
            this.ribbonPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel10.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel10.Name = "ribbonPanel10";
            this.ribbonPanel10.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel10.Size = new System.Drawing.Size(143, 98);
            // 
            // 
            // 
            this.ribbonPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel10.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel10.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel10.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanel11
            // 
            this.ribbonPanel11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel11.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel11.Name = "ribbonPanel11";
            this.ribbonPanel11.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel11.Size = new System.Drawing.Size(75, 20);
            // 
            // 
            // 
            this.ribbonPanel11.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel11.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel11.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel11.TabIndex = 2;
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.Transparent;
            this.groupBox23.Controls.Add(this.clanTag);
            this.groupBox23.Controls.Add(this.buttonX52);
            this.groupBox23.Enabled = false;
            this.groupBox23.Location = new System.Drawing.Point(418, 212);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(207, 69);
            this.groupBox23.TabIndex = 40;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Clantag Editor";
            // 
            // clanTag
            // 
            this.clanTag.Location = new System.Drawing.Point(6, 16);
            this.clanTag.MaxLength = 4;
            this.clanTag.Name = "clanTag";
            this.clanTag.Size = new System.Drawing.Size(194, 20);
            this.clanTag.TabIndex = 45;
            this.clanTag.Text = "{<3}";
            this.clanTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonX52
            // 
            this.buttonX52.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX52.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX52.Location = new System.Drawing.Point(6, 41);
            this.buttonX52.Name = "buttonX52";
            this.buttonX52.Size = new System.Drawing.Size(195, 21);
            this.buttonX52.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX52.TabIndex = 44;
            this.buttonX52.Text = "Send";
            this.buttonX52.Click += new System.EventHandler(this.buttonX52_Click_1);
            // 
            // groupBox22
            // 
            this.groupBox22.BackColor = System.Drawing.Color.Transparent;
            this.groupBox22.Controls.Add(this.checkBox1);
            this.groupBox22.Controls.Add(this.buttonX49);
            this.groupBox22.Enabled = false;
            this.groupBox22.Location = new System.Drawing.Point(418, 158);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(207, 47);
            this.groupBox22.TabIndex = 39;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Ban Bypass";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(159, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Adv";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonX49
            // 
            this.buttonX49.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX49.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX49.Location = new System.Drawing.Point(6, 19);
            this.buttonX49.Name = "buttonX49";
            this.buttonX49.Size = new System.Drawing.Size(147, 21);
            this.buttonX49.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX49.TabIndex = 44;
            this.buttonX49.Text = "Ban Bypass";
            this.buttonX49.Click += new System.EventHandler(this.buttonX49_Click_1);
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.Color.Transparent;
            this.groupBox20.Controls.Add(this.richTextBox1);
            this.groupBox20.Controls.Add(this.flip);
            this.groupBox20.Controls.Add(this.label79);
            this.groupBox20.Controls.Add(this.label78);
            this.groupBox20.Controls.Add(this.label77);
            this.groupBox20.Controls.Add(this.label86);
            this.groupBox20.Controls.Add(this.numericUpDown1);
            this.groupBox20.Controls.Add(this.buttonX48);
            this.groupBox20.Controls.Add(this.label84);
            this.groupBox20.Controls.Add(this.label83);
            this.groupBox20.Controls.Add(this.label80);
            this.groupBox20.Controls.Add(this.label81);
            this.groupBox20.Controls.Add(this.label82);
            this.groupBox20.Controls.Add(this.label76);
            this.groupBox20.Controls.Add(this.label75);
            this.groupBox20.Controls.Add(this.x);
            this.groupBox20.Controls.Add(this.y);
            this.groupBox20.Controls.Add(this.z);
            this.groupBox20.Controls.Add(this.yaw);
            this.groupBox20.Controls.Add(this.pitch);
            this.groupBox20.Controls.Add(this.roll);
            this.groupBox20.Controls.Add(this.comboBox8);
            this.groupBox20.Controls.Add(this.buttonX42);
            this.groupBox20.Controls.Add(this.codeGen);
            this.groupBox20.Controls.Add(this.buttonX43);
            this.groupBox20.Controls.Add(this.buttonX44);
            this.groupBox20.Controls.Add(this.tx);
            this.groupBox20.Controls.Add(this.ty);
            this.groupBox20.Controls.Add(this.buttonX54);
            this.groupBox20.Controls.Add(this.models);
            this.groupBox20.Enabled = false;
            this.groupBox20.Location = new System.Drawing.Point(13, 287);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(607, 217);
            this.groupBox20.TabIndex = 38;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Entity Spawning (Thanks XeX Golden even though you cracked/released this tool)";
            this.groupBox20.Enter += new System.EventHandler(this.groupBox20_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(233, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(367, 119);
            this.richTextBox1.TabIndex = 69;
            this.richTextBox1.Text = "";
            // 
            // flip
            // 
            this.flip.AutoSize = true;
            this.flip.Location = new System.Drawing.Point(561, 180);
            this.flip.Name = "flip";
            this.flip.Size = new System.Drawing.Size(42, 17);
            this.flip.TabIndex = 68;
            this.flip.Text = "Flip";
            this.flip.UseVisualStyleBackColor = true;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(8, 100);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(14, 13);
            this.label79.TabIndex = 67;
            this.label79.Text = "Z";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(8, 74);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(14, 13);
            this.label78.TabIndex = 66;
            this.label78.Text = "Y";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(8, 49);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(14, 13);
            this.label77.TabIndex = 65;
            this.label77.Text = "X";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(439, 182);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(59, 13);
            this.label86.TabIndex = 64;
            this.label86.Text = "Steps High";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(504, 179);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 62;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonX48
            // 
            this.buttonX48.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX48.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX48.Location = new System.Drawing.Point(330, 171);
            this.buttonX48.Name = "buttonX48";
            this.buttonX48.Size = new System.Drawing.Size(103, 35);
            this.buttonX48.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX48.TabIndex = 61;
            this.buttonX48.Text = "Spawn Staircase";
            this.buttonX48.Click += new System.EventHandler(this.buttonX48_Click_1);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(237, 182);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(35, 13);
            this.label84.TabIndex = 60;
            this.label84.Text = "Width";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(134, 182);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(40, 13);
            this.label83.TabIndex = 59;
            this.label83.Text = "Length";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(115, 99);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(25, 13);
            this.label80.TabIndex = 58;
            this.label80.Text = "Roll";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(115, 73);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(31, 13);
            this.label81.TabIndex = 57;
            this.label81.Text = "Pitch";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(115, 48);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(28, 13);
            this.label82.TabIndex = 56;
            this.label82.Text = "Yaw";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(197, 23);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(28, 13);
            this.label76.TabIndex = 52;
            this.label76.Text = "Map";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(2, 23);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(41, 13);
            this.label75.TabIndex = 51;
            this.label75.Text = "Models";
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.White;
            this.x.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.x.InterceptArrowKeys = false;
            this.x.Location = new System.Drawing.Point(30, 46);
            this.x.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.x.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(69, 20);
            this.x.TabIndex = 35;
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.Color.White;
            this.y.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.y.InterceptArrowKeys = false;
            this.y.Location = new System.Drawing.Point(30, 72);
            this.y.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.y.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(69, 20);
            this.y.TabIndex = 36;
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.White;
            this.z.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.z.InterceptArrowKeys = false;
            this.z.Location = new System.Drawing.Point(30, 98);
            this.z.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.z.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(69, 20);
            this.z.TabIndex = 37;
            this.z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yaw
            // 
            this.yaw.BackColor = System.Drawing.Color.White;
            this.yaw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yaw.InterceptArrowKeys = false;
            this.yaw.Location = new System.Drawing.Point(158, 46);
            this.yaw.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.yaw.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.yaw.Name = "yaw";
            this.yaw.Size = new System.Drawing.Size(69, 20);
            this.yaw.TabIndex = 38;
            this.yaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pitch
            // 
            this.pitch.BackColor = System.Drawing.Color.White;
            this.pitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pitch.InterceptArrowKeys = false;
            this.pitch.Location = new System.Drawing.Point(158, 72);
            this.pitch.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pitch.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(69, 20);
            this.pitch.TabIndex = 39;
            this.pitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roll
            // 
            this.roll.BackColor = System.Drawing.Color.White;
            this.roll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roll.InterceptArrowKeys = false;
            this.roll.Location = new System.Drawing.Point(158, 98);
            this.roll.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.roll.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(69, 20);
            this.roll.TabIndex = 40;
            this.roll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "mp_chasm",
            "mp_dart",
            "mp_fahrenheit",
            "mp_flooded",
            "mp_frag",
            "mp_hashima",
            "mp_lonestar",
            "mp_prisonbreak",
            "mp_skeleton",
            "mp_snow",
            "mp_sovereign",
            "mp_strikezone",
            "mp_warhawk",
            "mp_zebra"});
            this.comboBox8.Location = new System.Drawing.Point(233, 20);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(157, 21);
            this.comboBox8.TabIndex = 3;
            this.comboBox8.Text = "mp_prisonbreak";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // buttonX42
            // 
            this.buttonX42.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX42.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX42.Location = new System.Drawing.Point(88, 130);
            this.buttonX42.Name = "buttonX42";
            this.buttonX42.Size = new System.Drawing.Size(64, 35);
            this.buttonX42.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX42.TabIndex = 42;
            this.buttonX42.Text = "Spawn Entity";
            this.buttonX42.Click += new System.EventHandler(this.buttonX42_Click);
            // 
            // codeGen
            // 
            // 
            // 
            // 
            this.codeGen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codeGen.Location = new System.Drawing.Point(158, 123);
            this.codeGen.Name = "codeGen";
            this.codeGen.Size = new System.Drawing.Size(69, 36);
            this.codeGen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.codeGen.TabIndex = 45;
            this.codeGen.Text = "Gen Code";
            this.codeGen.CheckedChanged += new System.EventHandler(this.codeGen_CheckedChanged);
            // 
            // buttonX43
            // 
            this.buttonX43.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX43.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX43.Location = new System.Drawing.Point(10, 130);
            this.buttonX43.Name = "buttonX43";
            this.buttonX43.Size = new System.Drawing.Size(72, 35);
            this.buttonX43.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX43.TabIndex = 41;
            this.buttonX43.Text = "Get Player Position";
            this.buttonX43.Click += new System.EventHandler(this.buttonX43_Click);
            // 
            // buttonX44
            // 
            this.buttonX44.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX44.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX44.Location = new System.Drawing.Point(396, 20);
            this.buttonX44.Name = "buttonX44";
            this.buttonX44.Size = new System.Drawing.Size(205, 21);
            this.buttonX44.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX44.TabIndex = 44;
            this.buttonX44.Text = "Spawn from Code";
            this.buttonX44.Click += new System.EventHandler(this.buttonX44_Click);
            // 
            // tx
            // 
            this.tx.BackColor = System.Drawing.Color.White;
            this.tx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx.InterceptArrowKeys = false;
            this.tx.Location = new System.Drawing.Point(180, 180);
            this.tx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(51, 20);
            this.tx.TabIndex = 49;
            this.tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tx.ValueChanged += new System.EventHandler(this.tx_ValueChanged);
            // 
            // ty
            // 
            this.ty.BackColor = System.Drawing.Color.White;
            this.ty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ty.InterceptArrowKeys = false;
            this.ty.Location = new System.Drawing.Point(278, 180);
            this.ty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(46, 20);
            this.ty.TabIndex = 50;
            this.ty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonX54
            // 
            this.buttonX54.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX54.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX54.Location = new System.Drawing.Point(11, 171);
            this.buttonX54.Name = "buttonX54";
            this.buttonX54.Size = new System.Drawing.Size(117, 35);
            this.buttonX54.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX54.TabIndex = 46;
            this.buttonX54.Text = "Spawn Carepackage Wall";
            this.buttonX54.Click += new System.EventHandler(this.buttonX54_Click);
            // 
            // models
            // 
            this.models.FormattingEnabled = true;
            this.models.Items.AddRange(new object[] {
            "carepackage_enemy_iw6",
            "carepackage_friendly_iw6",
            "com_plasticcase_green_big_us_dirt",
            "mp_fullbody_dog_a",
            "mp_juggernaut_carepackage",
            "mp_juggernaut_carepackage_dummy",
            "mp_juggernaut_carepackage_red",
            "prop_dogtags_foe_iw6",
            "prop_flag_iw6_federation",
            "prop_flag_iw6_ghost",
            "weapon_riot_shield_jug_iw6"});
            this.models.Location = new System.Drawing.Point(43, 19);
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(150, 21);
            this.models.TabIndex = 2;
            this.models.Text = "carepackage_friendly_iw6";
            // 
            // groupBox19
            // 
            this.groupBox19.BackColor = System.Drawing.Color.Transparent;
            this.groupBox19.Controls.Add(this.buttonX38);
            this.groupBox19.Controls.Add(this.buttonX39);
            this.groupBox19.Controls.Add(this.textBox2);
            this.groupBox19.Enabled = false;
            this.groupBox19.Location = new System.Drawing.Point(275, 85);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(350, 67);
            this.groupBox19.TabIndex = 36;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "FPS (Thanks Nicholasbroo)";
            // 
            // buttonX38
            // 
            this.buttonX38.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX38.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX38.Location = new System.Drawing.Point(3, 24);
            this.buttonX38.Name = "buttonX38";
            this.buttonX38.Size = new System.Drawing.Size(168, 25);
            this.buttonX38.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX38.TabIndex = 42;
            this.buttonX38.Text = "Show FPS";
            this.buttonX38.Click += new System.EventHandler(this.buttonX38_Click);
            // 
            // buttonX39
            // 
            this.buttonX39.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX39.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX39.Location = new System.Drawing.Point(176, 40);
            this.buttonX39.Name = "buttonX39";
            this.buttonX39.Size = new System.Drawing.Size(168, 21);
            this.buttonX39.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX39.TabIndex = 43;
            this.buttonX39.Text = "Send";
            this.buttonX39.Click += new System.EventHandler(this.buttonX39_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "Custom FPS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox18
            // 
            this.groupBox18.BackColor = System.Drawing.Color.Transparent;
            this.groupBox18.Controls.Add(this.label89);
            this.groupBox18.Controls.Add(this.label85);
            this.groupBox18.Controls.Add(this.label87);
            this.groupBox18.Controls.Add(this.label88);
            this.groupBox18.Controls.Add(this.buttonX45);
            this.groupBox18.Controls.Add(this.buttonX46);
            this.groupBox18.Controls.Add(this.numericUpDown18);
            this.groupBox18.Controls.Add(this.numericUpDown28);
            this.groupBox18.Controls.Add(this.Except);
            this.groupBox18.Controls.Add(this.numericUpDown29);
            this.groupBox18.Controls.Add(this.radioButton3);
            this.groupBox18.Controls.Add(this.radioButton4);
            this.groupBox18.Controls.Add(this.numericUpDown34);
            this.groupBox18.Controls.Add(this.ExceptNum);
            this.groupBox18.Enabled = false;
            this.groupBox18.Location = new System.Drawing.Point(12, 158);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(400, 123);
            this.groupBox18.TabIndex = 37;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Teleportation";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(45, 73);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(96, 13);
            this.label89.TabIndex = 59;
            this.label89.Text = "Times to Tele-Trap";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(257, 23);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(14, 13);
            this.label85.TabIndex = 58;
            this.label85.Text = "Z";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(139, 23);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(14, 13);
            this.label87.TabIndex = 57;
            this.label87.Text = "Y";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(17, 23);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(14, 13);
            this.label88.TabIndex = 56;
            this.label88.Text = "X";
            // 
            // buttonX45
            // 
            this.buttonX45.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX45.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX45.Location = new System.Drawing.Point(11, 96);
            this.buttonX45.Name = "buttonX45";
            this.buttonX45.Size = new System.Drawing.Size(182, 21);
            this.buttonX45.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX45.TabIndex = 44;
            this.buttonX45.Text = "Get Player Coordinates";
            this.buttonX45.Click += new System.EventHandler(this.buttonX45_Click);
            // 
            // buttonX46
            // 
            this.buttonX46.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX46.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX46.Location = new System.Drawing.Point(211, 96);
            this.buttonX46.Name = "buttonX46";
            this.buttonX46.Size = new System.Drawing.Size(179, 21);
            this.buttonX46.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX46.TabIndex = 44;
            this.buttonX46.Text = "Set Coordinates";
            this.buttonX46.Click += new System.EventHandler(this.buttonX46_Click);
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.BackColor = System.Drawing.Color.White;
            this.numericUpDown18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown18.InterceptArrowKeys = false;
            this.numericUpDown18.Location = new System.Drawing.Point(58, 20);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown18.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown18.TabIndex = 34;
            this.numericUpDown18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown28
            // 
            this.numericUpDown28.BackColor = System.Drawing.Color.White;
            this.numericUpDown28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown28.InterceptArrowKeys = false;
            this.numericUpDown28.Location = new System.Drawing.Point(177, 20);
            this.numericUpDown28.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown28.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown28.Name = "numericUpDown28";
            this.numericUpDown28.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown28.TabIndex = 35;
            this.numericUpDown28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Except
            // 
            // 
            // 
            // 
            this.Except.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Except.Location = new System.Drawing.Point(232, 69);
            this.Except.Name = "Except";
            this.Except.Size = new System.Drawing.Size(61, 23);
            this.Except.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Except.TabIndex = 46;
            this.Except.Text = "Except";
            // 
            // numericUpDown29
            // 
            this.numericUpDown29.BackColor = System.Drawing.Color.White;
            this.numericUpDown29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown29.InterceptArrowKeys = false;
            this.numericUpDown29.Location = new System.Drawing.Point(303, 20);
            this.numericUpDown29.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown29.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown29.Name = "numericUpDown29";
            this.numericUpDown29.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown29.TabIndex = 36;
            this.numericUpDown29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(98, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 17);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Teleport Once";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(211, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 17);
            this.radioButton4.TabIndex = 38;
            this.radioButton4.Text = "Tele-Trap";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // numericUpDown34
            // 
            this.numericUpDown34.BackColor = System.Drawing.Color.White;
            this.numericUpDown34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown34.InterceptArrowKeys = false;
            this.numericUpDown34.Location = new System.Drawing.Point(149, 70);
            this.numericUpDown34.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown34.Name = "numericUpDown34";
            this.numericUpDown34.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown34.TabIndex = 40;
            this.numericUpDown34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown34.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ExceptNum
            // 
            this.ExceptNum.BackColor = System.Drawing.Color.White;
            this.ExceptNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExceptNum.InterceptArrowKeys = false;
            this.ExceptNum.Location = new System.Drawing.Point(293, 71);
            this.ExceptNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ExceptNum.Name = "ExceptNum";
            this.ExceptNum.Size = new System.Drawing.Size(42, 20);
            this.ExceptNum.TabIndex = 47;
            this.ExceptNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox21
            // 
            this.groupBox21.BackColor = System.Drawing.Color.Transparent;
            this.groupBox21.Controls.Add(this.comboBox6);
            this.groupBox21.Controls.Add(this.buttonX40);
            this.groupBox21.Controls.Add(this.textBox54);
            this.groupBox21.Controls.Add(this.buttonX41);
            this.groupBox21.Enabled = false;
            this.groupBox21.Location = new System.Drawing.Point(272, 2);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(353, 77);
            this.groupBox21.TabIndex = 34;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Custom CMD/Vision";
            this.groupBox21.Enter += new System.EventHandler(this.groupBox21_Enter);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "ac130",
            "ac130_enhanced_mp",
            "ac130_inverted",
            "af_caves_indoors",
            "af_caves_indoors_breachroom",
            "af_caves_indoors_overlook",
            "af_caves_indoors_skylight",
            "af_caves_indoors_steamroom",
            "af_caves_indoors_steamroom_dark",
            "af_caves_outdoors",
            "af_caves_outdoors_airstrip",
            "af_chase_ending_noshock",
            "af_chase_indoors",
            "af_chase_indoors_2",
            "af_chase_indoors_3",
            "af_chase_outdoors",
            "af_chase_outdoors_2",
            "af_chase_outdoors_3",
            "aftermath",
            "aftermath_dying",
            "aftermath_hurt",
            "aftermath_nodesat",
            "aftermath_pain",
            "aftermath_walking",
            "airplane",
            "airport",
            "airport_death",
            "airport_exterior",
            "airport_green",
            "airport_intro",
            "airport_stairs",
            "ambush",
            "arcadia",
            "arcadia_checkpoint",
            "arcadia_golfcourse",
            "arcadia_house",
            "arcadia_house2",
            "arcadia_secondbridge",
            "arcadia_secondstreet",
            "arcadia_wrekage",
            "armada",
            "armada_ground",
            "armada_sound",
            "armada_tvs",
            "armada_water",
            "bigcity_destroyed",
            "//black and white",
            "black_bw",
            "blackout",
            "blackout_darkness",
            "blackout_nvg",
            "blacktest",
            "bog",
            "bog_a",
            "bog_a_sunrise",
            "bog_b",
            "boneyard",
            "boneyard_flyby",
            "boneyard_ride",
            "boneyard_steer",
            "bridge",
            "cargoship",
            "//The explosion on CoD4 in the container ship turns everything red",
            "cargoship_blast",
            "cargoship_indoor",
            "cargoship_indoor2",
            "cheat_bw",
            "cheat_bw_contrast",
            "cheat_bw_invert",
            "cheat_bw_invert_contrast",
            "cheat_chaplinnight",
            "cheat_contrast",
            "cheat_invert",
            "cheat_invert_contrast",
            "cliffhanger",
            "cliffhanger_extreme",
            "cliffhanger_heavy",
            "cliffhanger_snowmobile",
            "co_break",
            "co_overgrown",
            "cobra_down",
            "cobra_sunset1",
            "cobra_sunset2",
            "cobra_sunset3",
            "cobrapilot",
            "contingency",
            "contingency_thermal_inverted",
            "coup",
            "coup_hit",
            "coup_sunblind",
            "dc_whitehouse_interior",
            "dc_whitehouse_lawn",
            "dc_whitehouse_roof",
            "dc_whitehouse_tunnel",
            "dcburning_bunker",
            "dcburning_commerce",
            "dcburning_crash",
            "dcburning_heliride",
            "dcburning_rooftops",
            "dcburning_trnches",
            "dcemp",
            "dcemp_emp",
            "dcemp_iss",
            "dcemp_iss_death",
            "dcemp_office",
            "dcemp_parking",
            "dcemp_parking_lighting",
            "dcemp_postemp",
            "dcemp_postemp2",
            "dcemp_tunnels",
            "//Use this to reset any vision you\'ve used (Single Player)",
            "default ",
            "//Use this to reset any vision you\'ve used (MultiPlayer)",
            "Default_mp ",
            "default_night",
            "default_night_mp",
            "downtown_la",
            "end_game",
            "end_game2",
            "estate",
            "estate_ambush_clearing",
            "estate_birchfield",
            "estate_dragplayer",
            "estate_finalfield",
            "estate_forest",
            "estate_forset_clearing",
            "estate_hilltop",
            "estate_house_approach",
            "estate_house_backyard",
            "estate_house_interior",
            "estate_throwplayer",
            "exterior_concept",
            "favela",
            "favela_alleys",
            "favela_chase",
            "favela_ending",
            "favela_escape",
            "favela_escape_chopperjump",
            "favela_escape_market",
            "favela_escape_playerfall_recovery",
            "favela_escape_radiotower",
            "favela_escape_rooftops",
            "favela_escape_soccerfield",
            "favela_escape_soccerfield_buildings",
            "favela_escape_solorun_buildings",
            "favela_escape_solorun_nearend",
            "favela_escape_street",
            "favela_hill",
            "favela_shanty",
            "favela_torture",
            "firingrange",
            "grayscale ",
            "gulag",
            "gulag_circle",
            "gulag_ending",
            "gulag_flyin",
            "gulag_hallways",
            "gulag_nvg",
            "helicopter_ride",
            "hunted",
            "hunted_crash",
            "icbm",
            "icbm_interior",
            "icbm_launch",
            "icbm_sunrise0",
            "icbm_sunrise1",
            "icbm_sunrise2",
            "icbm_sunrise3",
            "icbm_sunrise4",
            "interior_concept",
            "introscreen",
            "invasion",
            "invasion_alley",
            "invasion_nates_roof",
            "invasion_near_convoy",
            "invasion_stripmall",
            "invasion_suburban_streets",
            "invasion_yards",
            "jeepride",
            "jeepride_cobra",
            "jeepride_flyaway",
            "jeepride_tunnel",
            "jeepride_zak",
            "killhouse",
            "launchfacility",
            "launchfacility_a",
            "launchfacility_b",
            "missilecam",
            "mp_backlot",
            "mp_bloc",
            "mp_bog",
            "mp_brecourt",
            "mp_broadcase",
            "mp_carentan",
            "mp_cargoship",
            "mp_character_room",
            "mp_citystreets",
            "mp_convoy",
            "mp_countdown",
            "mp_crash",
            "mp_crash_damage",
            "mp_creek",
            "mp_creek_ss",
            "mp_crossfire",
            "mp_derail",
            "mp_downtown_la",
            "mp_dusk",
            "mp_fahrenheit",
            "mp_fahrenheit_storm_exterior_dark",
            "mp_farm",
            "mp_favela",
            "mp_firingrange",
            "mp_flooded",
            "mp_flooded_vision_set_cg_helo",
            "mp_flooded_vision_set_garage",
            "mp_flooded_vision_set_garage_water",
            "mp_flooded_vision_set_interior_ng",
            "mp_flooded_vision_set_ng",
            "mp_frag",
            "mp_hashima",
            "mp_hashima_interiors",
            "mp_highrise",
            "mp_hill",
            "mp_killhouse",
            "mp_lonestar",
            "mp_nightshift",
            "mp_oilrig",
            "mp_overgrown",
            "mp_pipeline",
            "mp_quarry",
            "mp_riverwalk",
            "mp_shipment",
            "mp_showdown",
            "mp_skidrow",
            "mp_strike",
            "mp_strikezone_bridge",
            "mp_strikezone_flash",
            "mp_strikezone_interior",
            "mp_strikezone_stadium_bar",
            "mp_suburbia",
            "mp_trailer",
            "mp_vacant",
            "mp_verdict",
            "mp_warhawk",
            "mp_warhawk_interior",
            "mpintro",
            "mpintro_dart",
            "mpnuke",
            "mpnuke_aftermath",
            "mpoutro",
            "nate_test",
            "near_death",
            "near_death_mp",
            "oilrig_exterior_deck0",
            "oilrig_exterior_deck1",
            "oilrig_exterior_deck2",
            "oilrig_exterior_deck3",
            "oilrig_exterior_deck4",
            "oilrig_exterior_heli",
            "oilrig_interior",
            "oilrig_interior2",
            "oilrig_underwater",
            "overwatch",
            "overwatch_nv",
            "parabolic",
            "roadkill",
            "roadkill_ambush",
            "roadkill_dismount_building",
            "roadkill_ending",
            "roadkill_inside_school",
            "roadkill_left_school",
            "roadkill_town_normal",
            "roadkill_town_smokey",
            "roadkill_walking_to_school",
            "school",
            "scoutsniper",
            "seaknight_assault",
            "//This one could be cool",
            "sepia",
            "slomo_breach",
            "sniperescape",
            "sniperescape_glow_off",
            "sniperescape_outside",
            "so_bridge",
            "strike",
            "thermal_mp",
            "thermal_snowlevel_mp",
            "trainer_pit",
            "trainer_start",
            "tulsa",
            "village_assauilt",
            "village_defend",
            "wetwork",
            "whitehouse"});
            this.comboBox6.Location = new System.Drawing.Point(180, 20);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(167, 21);
            this.comboBox6.TabIndex = 32;
            this.comboBox6.Text = "ac130";
            // 
            // buttonX40
            // 
            this.buttonX40.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX40.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX40.Location = new System.Drawing.Point(180, 46);
            this.buttonX40.Name = "buttonX40";
            this.buttonX40.Size = new System.Drawing.Size(168, 24);
            this.buttonX40.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX40.TabIndex = 44;
            this.buttonX40.Text = "Send Vision";
            this.buttonX40.Click += new System.EventHandler(this.buttonX40_Click);
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(6, 20);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(168, 20);
            this.textBox54.TabIndex = 0;
            this.textBox54.Text = "g_knockback 1000000";
            this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonX41
            // 
            this.buttonX41.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX41.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX41.Location = new System.Drawing.Point(6, 46);
            this.buttonX41.Name = "buttonX41";
            this.buttonX41.Size = new System.Drawing.Size(168, 24);
            this.buttonX41.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX41.TabIndex = 45;
            this.buttonX41.Text = "Custom Command";
            this.buttonX41.Click += new System.EventHandler(this.buttonX41_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label74);
            this.groupBox5.Controls.Add(this.label73);
            this.groupBox5.Controls.Add(this.buttonX8);
            this.groupBox5.Controls.Add(this.textBox23);
            this.groupBox5.Controls.Add(this.buttonX7);
            this.groupBox5.Controls.Add(this.textBox72);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(12, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 148);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mapname/Gametype";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(6, 81);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(55, 13);
            this.label74.TabIndex = 43;
            this.label74.Text = "Gametype";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(6, 16);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(54, 13);
            this.label73.TabIndex = 42;
            this.label73.Text = "Mapname";
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Location = new System.Drawing.Point(5, 59);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(241, 19);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.TabIndex = 41;
            this.buttonX8.Text = "Set Mapname";
            this.buttonX8.Click += new System.EventHandler(this.buttonX8_Click);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(5, 33);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(241, 20);
            this.textBox23.TabIndex = 34;
            this.textBox23.Text = "^1Chaos ^2is ^3a ^4boss";
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Location = new System.Drawing.Point(5, 123);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(241, 19);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX7.TabIndex = 40;
            this.buttonX7.Text = "Set Gametype";
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(5, 97);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(241, 20);
            this.textBox72.TabIndex = 37;
            this.textBox72.Text = "^1Chaos ^2is ^3a ^4boss";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel9.Controls.Add(this.groupBox24);
            this.ribbonPanel9.Controls.Add(this.groupBox31);
            this.ribbonPanel9.Controls.Add(this.groupBox30);
            this.ribbonPanel9.Controls.Add(this.groupBox29);
            this.ribbonPanel9.Controls.Add(this.groupBox28);
            this.ribbonPanel9.Controls.Add(this.groupBox27);
            this.ribbonPanel9.Controls.Add(this.groupBox26);
            this.ribbonPanel9.Controls.Add(this.groupBox25);
            this.ribbonPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel9.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel9.Size = new System.Drawing.Size(957, 595);
            // 
            // 
            // 
            this.ribbonPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel9.TabIndex = 9;
            this.ribbonPanel9.Visible = false;
            // 
            // groupBox24
            // 
            this.groupBox24.BackColor = System.Drawing.Color.Transparent;
            this.groupBox24.Controls.Add(this.buttonX87);
            this.groupBox24.Controls.Add(this.buttonX58);
            this.groupBox24.Enabled = false;
            this.groupBox24.Location = new System.Drawing.Point(446, 317);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(179, 79);
            this.groupBox24.TabIndex = 7;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Explosive Bullets";
            // 
            // buttonX87
            // 
            this.buttonX87.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX87.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX87.Location = new System.Drawing.Point(6, 48);
            this.buttonX87.Name = "buttonX87";
            this.buttonX87.Size = new System.Drawing.Size(167, 23);
            this.buttonX87.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX87.TabIndex = 7;
            this.buttonX87.Text = "Activate";
            this.buttonX87.Click += new System.EventHandler(this.buttonX87_Click);
            // 
            // buttonX58
            // 
            this.buttonX58.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX58.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX58.Location = new System.Drawing.Point(5, 19);
            this.buttonX58.Name = "buttonX58";
            this.buttonX58.Size = new System.Drawing.Size(167, 23);
            this.buttonX58.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX58.TabIndex = 6;
            this.buttonX58.Text = "Activate";
            this.buttonX58.Click += new System.EventHandler(this.buttonX58_Click_1);
            // 
            // groupBox31
            // 
            this.groupBox31.BackColor = System.Drawing.Color.Transparent;
            this.groupBox31.Controls.Add(this.buttonX57);
            this.groupBox31.Controls.Add(this.numericUpDown19);
            this.groupBox31.Controls.Add(this.buttonX86);
            this.groupBox31.Controls.Add(this.buttonX85);
            this.groupBox31.Controls.Add(this.buttonX84);
            this.groupBox31.Controls.Add(this.buttonX83);
            this.groupBox31.Controls.Add(this.buttonX82);
            this.groupBox31.Enabled = false;
            this.groupBox31.Location = new System.Drawing.Point(229, 178);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(211, 196);
            this.groupBox31.TabIndex = 6;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Health";
            // 
            // buttonX57
            // 
            this.buttonX57.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX57.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX57.Location = new System.Drawing.Point(5, 135);
            this.buttonX57.Name = "buttonX57";
            this.buttonX57.Size = new System.Drawing.Size(200, 23);
            this.buttonX57.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX57.TabIndex = 12;
            this.buttonX57.Text = "Default Health";
            this.buttonX57.Click += new System.EventHandler(this.buttonX57_Click);
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(108, 165);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown19.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown19.TabIndex = 11;
            // 
            // buttonX86
            // 
            this.buttonX86.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX86.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX86.Location = new System.Drawing.Point(5, 164);
            this.buttonX86.Name = "buttonX86";
            this.buttonX86.Size = new System.Drawing.Size(97, 23);
            this.buttonX86.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX86.TabIndex = 10;
            this.buttonX86.Text = "Custom Health: ";
            this.buttonX86.Click += new System.EventHandler(this.buttonX86_Click);
            // 
            // buttonX85
            // 
            this.buttonX85.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX85.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX85.Location = new System.Drawing.Point(6, 106);
            this.buttonX85.Name = "buttonX85";
            this.buttonX85.Size = new System.Drawing.Size(200, 23);
            this.buttonX85.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX85.TabIndex = 9;
            this.buttonX85.Text = "Negative Health";
            this.buttonX85.Click += new System.EventHandler(this.buttonX85_Click);
            // 
            // buttonX84
            // 
            this.buttonX84.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX84.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX84.Location = new System.Drawing.Point(6, 77);
            this.buttonX84.Name = "buttonX84";
            this.buttonX84.Size = new System.Drawing.Size(200, 23);
            this.buttonX84.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX84.TabIndex = 8;
            this.buttonX84.Text = "Unoticable Max Health";
            this.buttonX84.Click += new System.EventHandler(this.buttonX84_Click);
            // 
            // buttonX83
            // 
            this.buttonX83.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX83.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX83.Location = new System.Drawing.Point(6, 48);
            this.buttonX83.Name = "buttonX83";
            this.buttonX83.Size = new System.Drawing.Size(200, 23);
            this.buttonX83.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX83.TabIndex = 7;
            this.buttonX83.Text = "Triple Health";
            this.buttonX83.Click += new System.EventHandler(this.buttonX83_Click);
            // 
            // buttonX82
            // 
            this.buttonX82.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX82.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX82.Location = new System.Drawing.Point(5, 19);
            this.buttonX82.Name = "buttonX82";
            this.buttonX82.Size = new System.Drawing.Size(200, 23);
            this.buttonX82.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX82.TabIndex = 6;
            this.buttonX82.Text = "Double Health";
            this.buttonX82.Click += new System.EventHandler(this.buttonX82_Click);
            // 
            // groupBox30
            // 
            this.groupBox30.BackColor = System.Drawing.Color.Transparent;
            this.groupBox30.Controls.Add(this.checkerBoard);
            this.groupBox30.Controls.Add(this.buttonX81);
            this.groupBox30.Controls.Add(this.buttonX80);
            this.groupBox30.Controls.Add(this.buttonX77);
            this.groupBox30.Controls.Add(this.buttonX78);
            this.groupBox30.Controls.Add(this.buttonX79);
            this.groupBox30.Enabled = false;
            this.groupBox30.Location = new System.Drawing.Point(446, 123);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(179, 188);
            this.groupBox30.TabIndex = 5;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Disable Dpad (Thanks Bitwise)";
            // 
            // checkerBoard
            // 
            this.checkerBoard.AutoSize = true;
            this.checkerBoard.Location = new System.Drawing.Point(6, 164);
            this.checkerBoard.Name = "checkerBoard";
            this.checkerBoard.Size = new System.Drawing.Size(118, 17);
            this.checkerBoard.TabIndex = 6;
            this.checkerBoard.Text = "With Checkerboard";
            this.checkerBoard.UseVisualStyleBackColor = true;
            this.checkerBoard.CheckedChanged += new System.EventHandler(this.checkerBoard_CheckedChanged);
            // 
            // buttonX81
            // 
            this.buttonX81.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX81.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX81.Location = new System.Drawing.Point(6, 135);
            this.buttonX81.Name = "buttonX81";
            this.buttonX81.Size = new System.Drawing.Size(167, 23);
            this.buttonX81.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX81.TabIndex = 5;
            this.buttonX81.Text = "Disable Dpad";
            this.buttonX81.Click += new System.EventHandler(this.buttonX81_Click);
            // 
            // buttonX80
            // 
            this.buttonX80.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX80.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX80.Location = new System.Drawing.Point(6, 106);
            this.buttonX80.Name = "buttonX80";
            this.buttonX80.Size = new System.Drawing.Size(167, 23);
            this.buttonX80.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX80.TabIndex = 4;
            this.buttonX80.Text = "Disable Down on Dpad";
            this.buttonX80.Click += new System.EventHandler(this.buttonX80_Click);
            // 
            // buttonX77
            // 
            this.buttonX77.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX77.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX77.Location = new System.Drawing.Point(5, 77);
            this.buttonX77.Name = "buttonX77";
            this.buttonX77.Size = new System.Drawing.Size(167, 23);
            this.buttonX77.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX77.TabIndex = 3;
            this.buttonX77.Text = "Disable Up on Dpad";
            this.buttonX77.Click += new System.EventHandler(this.buttonX77_Click);
            // 
            // buttonX78
            // 
            this.buttonX78.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX78.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX78.Location = new System.Drawing.Point(6, 48);
            this.buttonX78.Name = "buttonX78";
            this.buttonX78.Size = new System.Drawing.Size(167, 23);
            this.buttonX78.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX78.TabIndex = 2;
            this.buttonX78.Text = "Disable Right on Dpad";
            this.buttonX78.Click += new System.EventHandler(this.buttonX78_Click);
            // 
            // buttonX79
            // 
            this.buttonX79.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX79.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX79.Location = new System.Drawing.Point(6, 19);
            this.buttonX79.Name = "buttonX79";
            this.buttonX79.Size = new System.Drawing.Size(167, 23);
            this.buttonX79.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX79.TabIndex = 1;
            this.buttonX79.Text = "Disable Left on Dpad";
            this.buttonX79.Click += new System.EventHandler(this.buttonX79_Click);
            // 
            // groupBox29
            // 
            this.groupBox29.BackColor = System.Drawing.Color.Transparent;
            this.groupBox29.Controls.Add(this.buttonX75);
            this.groupBox29.Controls.Add(this.buttonX76);
            this.groupBox29.Controls.Add(this.buttonX73);
            this.groupBox29.Controls.Add(this.buttonX74);
            this.groupBox29.Controls.Add(this.buttonX71);
            this.groupBox29.Controls.Add(this.buttonX72);
            this.groupBox29.Enabled = false;
            this.groupBox29.Location = new System.Drawing.Point(12, 178);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(211, 196);
            this.groupBox29.TabIndex = 4;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Unknown (Thanks Bitwise)";
            // 
            // buttonX75
            // 
            this.buttonX75.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX75.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX75.Location = new System.Drawing.Point(6, 164);
            this.buttonX75.Name = "buttonX75";
            this.buttonX75.Size = new System.Drawing.Size(200, 23);
            this.buttonX75.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX75.TabIndex = 10;
            this.buttonX75.Text = "Enable Jump";
            this.buttonX75.Click += new System.EventHandler(this.buttonX75_Click);
            // 
            // buttonX76
            // 
            this.buttonX76.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX76.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX76.Location = new System.Drawing.Point(6, 135);
            this.buttonX76.Name = "buttonX76";
            this.buttonX76.Size = new System.Drawing.Size(200, 23);
            this.buttonX76.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX76.TabIndex = 9;
            this.buttonX76.Text = "Disable Jump";
            this.buttonX76.Click += new System.EventHandler(this.buttonX76_Click);
            // 
            // buttonX73
            // 
            this.buttonX73.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX73.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX73.Location = new System.Drawing.Point(5, 106);
            this.buttonX73.Name = "buttonX73";
            this.buttonX73.Size = new System.Drawing.Size(200, 23);
            this.buttonX73.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX73.TabIndex = 8;
            this.buttonX73.Text = "Enable Sprint";
            this.buttonX73.Click += new System.EventHandler(this.buttonX73_Click);
            // 
            // buttonX74
            // 
            this.buttonX74.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX74.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX74.Location = new System.Drawing.Point(5, 77);
            this.buttonX74.Name = "buttonX74";
            this.buttonX74.Size = new System.Drawing.Size(200, 23);
            this.buttonX74.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX74.TabIndex = 7;
            this.buttonX74.Text = "Disable Sprint";
            this.buttonX74.Click += new System.EventHandler(this.buttonX74_Click);
            // 
            // buttonX71
            // 
            this.buttonX71.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX71.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX71.Location = new System.Drawing.Point(5, 48);
            this.buttonX71.Name = "buttonX71";
            this.buttonX71.Size = new System.Drawing.Size(200, 23);
            this.buttonX71.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX71.TabIndex = 6;
            this.buttonX71.Text = "Tbag Off";
            this.buttonX71.Click += new System.EventHandler(this.buttonX71_Click);
            // 
            // buttonX72
            // 
            this.buttonX72.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX72.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX72.Location = new System.Drawing.Point(5, 19);
            this.buttonX72.Name = "buttonX72";
            this.buttonX72.Size = new System.Drawing.Size(200, 23);
            this.buttonX72.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX72.TabIndex = 5;
            this.buttonX72.Text = "Tbag On";
            this.buttonX72.Click += new System.EventHandler(this.buttonX72_Click);
            // 
            // groupBox28
            // 
            this.groupBox28.BackColor = System.Drawing.Color.Transparent;
            this.groupBox28.Controls.Add(this.buttonX70);
            this.groupBox28.Controls.Add(this.buttonX69);
            this.groupBox28.Controls.Add(this.buttonX68);
            this.groupBox28.Enabled = false;
            this.groupBox28.Location = new System.Drawing.Point(446, 8);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(179, 109);
            this.groupBox28.TabIndex = 3;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Cycles";
            // 
            // buttonX70
            // 
            this.buttonX70.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX70.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX70.Location = new System.Drawing.Point(5, 77);
            this.buttonX70.Name = "buttonX70";
            this.buttonX70.Size = new System.Drawing.Size(167, 23);
            this.buttonX70.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX70.TabIndex = 3;
            this.buttonX70.Text = "In-Game GT Off";
            this.buttonX70.Click += new System.EventHandler(this.buttonX70_Click);
            // 
            // buttonX69
            // 
            this.buttonX69.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX69.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX69.Location = new System.Drawing.Point(6, 48);
            this.buttonX69.Name = "buttonX69";
            this.buttonX69.Size = new System.Drawing.Size(167, 23);
            this.buttonX69.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX69.TabIndex = 2;
            this.buttonX69.Text = "Pre-Game GT Cycle Off";
            this.buttonX69.Click += new System.EventHandler(this.buttonX69_Click);
            // 
            // buttonX68
            // 
            this.buttonX68.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX68.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX68.Location = new System.Drawing.Point(6, 19);
            this.buttonX68.Name = "buttonX68";
            this.buttonX68.Size = new System.Drawing.Size(167, 23);
            this.buttonX68.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX68.TabIndex = 1;
            this.buttonX68.Text = "Prestige Cycle Off";
            this.buttonX68.Click += new System.EventHandler(this.buttonX68_Click);
            // 
            // groupBox27
            // 
            this.groupBox27.BackColor = System.Drawing.Color.Transparent;
            this.groupBox27.Controls.Add(this.buttonX67);
            this.groupBox27.Controls.Add(this.textBox4);
            this.groupBox27.Controls.Add(this.textBox3);
            this.groupBox27.Enabled = false;
            this.groupBox27.Location = new System.Drawing.Point(229, 8);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(211, 110);
            this.groupBox27.TabIndex = 2;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "XUID";
            // 
            // buttonX67
            // 
            this.buttonX67.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX67.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX67.Location = new System.Drawing.Point(5, 69);
            this.buttonX67.Name = "buttonX67";
            this.buttonX67.Size = new System.Drawing.Size(200, 33);
            this.buttonX67.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX67.TabIndex = 2;
            this.buttonX67.Text = "Spoof";
            this.buttonX67.Click += new System.EventHandler(this.buttonX67_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "XUID Here";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Pre-Game GT Here";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox26
            // 
            this.groupBox26.BackColor = System.Drawing.Color.Transparent;
            this.groupBox26.Controls.Add(this.buttonX66);
            this.groupBox26.Enabled = false;
            this.groupBox26.Location = new System.Drawing.Point(229, 124);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(211, 48);
            this.groupBox26.TabIndex = 1;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Modified Killstreaks";
            // 
            // buttonX66
            // 
            this.buttonX66.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX66.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX66.Location = new System.Drawing.Point(6, 16);
            this.buttonX66.Name = "buttonX66";
            this.buttonX66.Size = new System.Drawing.Size(200, 23);
            this.buttonX66.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX66.TabIndex = 1;
            this.buttonX66.Text = "Assault to Support";
            this.buttonX66.Click += new System.EventHandler(this.buttonX66_Click);
            // 
            // groupBox25
            // 
            this.groupBox25.BackColor = System.Drawing.Color.Transparent;
            this.groupBox25.Controls.Add(this.buttonX65);
            this.groupBox25.Controls.Add(this.buttonX64);
            this.groupBox25.Controls.Add(this.buttonX63);
            this.groupBox25.Controls.Add(this.buttonX62);
            this.groupBox25.Controls.Add(this.buttonX61);
            this.groupBox25.Enabled = false;
            this.groupBox25.Location = new System.Drawing.Point(12, 8);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(211, 164);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Gametypes";
            // 
            // buttonX65
            // 
            this.buttonX65.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX65.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX65.Location = new System.Drawing.Point(5, 132);
            this.buttonX65.Name = "buttonX65";
            this.buttonX65.Size = new System.Drawing.Size(200, 23);
            this.buttonX65.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX65.TabIndex = 4;
            this.buttonX65.Text = "Maze";
            this.buttonX65.Click += new System.EventHandler(this.buttonX65_Click);
            // 
            // buttonX64
            // 
            this.buttonX64.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX64.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX64.Enabled = false;
            this.buttonX64.Location = new System.Drawing.Point(5, 103);
            this.buttonX64.Name = "buttonX64";
            this.buttonX64.Size = new System.Drawing.Size(200, 23);
            this.buttonX64.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX64.TabIndex = 3;
            this.buttonX64.Text = "Indiana Jones";
            // 
            // buttonX63
            // 
            this.buttonX63.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX63.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX63.Enabled = false;
            this.buttonX63.Location = new System.Drawing.Point(5, 74);
            this.buttonX63.Name = "buttonX63";
            this.buttonX63.Size = new System.Drawing.Size(200, 23);
            this.buttonX63.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX63.TabIndex = 2;
            this.buttonX63.Text = "Frisbee";
            // 
            // buttonX62
            // 
            this.buttonX62.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX62.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX62.Enabled = false;
            this.buttonX62.Location = new System.Drawing.Point(5, 45);
            this.buttonX62.Name = "buttonX62";
            this.buttonX62.Size = new System.Drawing.Size(200, 23);
            this.buttonX62.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX62.TabIndex = 1;
            this.buttonX62.Text = "Grifball";
            // 
            // buttonX61
            // 
            this.buttonX61.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX61.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX61.Enabled = false;
            this.buttonX61.Location = new System.Drawing.Point(5, 16);
            this.buttonX61.Name = "buttonX61";
            this.buttonX61.Size = new System.Drawing.Size(200, 23);
            this.buttonX61.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX61.TabIndex = 0;
            this.buttonX61.Text = "Dodgeball";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel5.Controls.Add(this.groupBox12);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(957, 595);
            // 
            // 
            // 
            this.ribbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Transparent;
            this.groupBox12.Controls.Add(this.buttonX37);
            this.groupBox12.Controls.Add(this.groupBox13);
            this.groupBox12.Controls.Add(this.groupBox14);
            this.groupBox12.Controls.Add(this.radioButton5);
            this.groupBox12.Controls.Add(this.radioButton6);
            this.groupBox12.Controls.Add(this.textBox30);
            this.groupBox12.Enabled = false;
            this.groupBox12.Location = new System.Drawing.Point(12, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(613, 456);
            this.groupBox12.TabIndex = 39;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Gamertag";
            // 
            // buttonX37
            // 
            this.buttonX37.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX37.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX37.Location = new System.Drawing.Point(6, 70);
            this.buttonX37.Name = "buttonX37";
            this.buttonX37.Size = new System.Drawing.Size(598, 25);
            this.buttonX37.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX37.TabIndex = 37;
            this.buttonX37.Text = "Send";
            this.buttonX37.Click += new System.EventHandler(this.buttonX37_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.LightYellow);
            this.groupBox13.Controls.Add(this.YaleBlue);
            this.groupBox13.Controls.Add(this.Black);
            this.groupBox13.Controls.Add(this.Red);
            this.groupBox13.Controls.Add(this.Grey);
            this.groupBox13.Controls.Add(this.Blue);
            this.groupBox13.Controls.Add(this.Default);
            this.groupBox13.Controls.Add(this.White);
            this.groupBox13.Controls.Add(this.Green);
            this.groupBox13.Controls.Add(this.Cyan);
            this.groupBox13.Controls.Add(this.Yellow);
            this.groupBox13.Controls.Add(this.Pink);
            this.groupBox13.Enabled = false;
            this.groupBox13.Location = new System.Drawing.Point(6, 260);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(598, 156);
            this.groupBox13.TabIndex = 26;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Colors";
            // 
            // LightYellow
            // 
            this.LightYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LightYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LightYellow.BackgroundImage")));
            this.LightYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LightYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightYellow.ForeColor = System.Drawing.Color.Black;
            this.LightYellow.Location = new System.Drawing.Point(434, 86);
            this.LightYellow.Name = "LightYellow";
            this.LightYellow.Size = new System.Drawing.Size(60, 60);
            this.LightYellow.TabIndex = 33;
            this.LightYellow.UseVisualStyleBackColor = false;
            this.LightYellow.Click += new System.EventHandler(this.LightYellow_Click);
            // 
            // YaleBlue
            // 
            this.YaleBlue.BackColor = System.Drawing.Color.DarkBlue;
            this.YaleBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YaleBlue.BackgroundImage")));
            this.YaleBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YaleBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YaleBlue.ForeColor = System.Drawing.Color.Black;
            this.YaleBlue.Location = new System.Drawing.Point(368, 86);
            this.YaleBlue.Name = "YaleBlue";
            this.YaleBlue.Size = new System.Drawing.Size(60, 60);
            this.YaleBlue.TabIndex = 32;
            this.YaleBlue.UseVisualStyleBackColor = false;
            this.YaleBlue.Click += new System.EventHandler(this.YaleBlue_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Black.BackgroundImage")));
            this.Black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.ForeColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(302, 86);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(60, 60);
            this.Black.TabIndex = 31;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Red.BackgroundImage")));
            this.Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.ForeColor = System.Drawing.Color.Black;
            this.Red.Location = new System.Drawing.Point(104, 20);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(60, 60);
            this.Red.TabIndex = 18;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Grey
            // 
            this.Grey.BackColor = System.Drawing.Color.Gray;
            this.Grey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grey.BackgroundImage")));
            this.Grey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Grey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grey.ForeColor = System.Drawing.Color.Black;
            this.Grey.Location = new System.Drawing.Point(434, 20);
            this.Grey.Name = "Grey";
            this.Grey.Size = new System.Drawing.Size(60, 60);
            this.Grey.TabIndex = 30;
            this.Grey.UseVisualStyleBackColor = false;
            this.Grey.Click += new System.EventHandler(this.Grey_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Blue.BackgroundImage")));
            this.Blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.ForeColor = System.Drawing.Color.Black;
            this.Blue.Location = new System.Drawing.Point(104, 86);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(60, 60);
            this.Blue.TabIndex = 19;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Default
            // 
            this.Default.BackColor = System.Drawing.Color.Silver;
            this.Default.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Default.BackgroundImage")));
            this.Default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Default.ForeColor = System.Drawing.Color.Black;
            this.Default.Location = new System.Drawing.Point(368, 20);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(60, 60);
            this.Default.TabIndex = 29;
            this.Default.UseVisualStyleBackColor = false;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // White
            // 
            this.White.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.ForeColor = System.Drawing.Color.Black;
            this.White.Location = new System.Drawing.Point(302, 20);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(60, 60);
            this.White.TabIndex = 28;
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Lime;
            this.Green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Green.BackgroundImage")));
            this.Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.ForeColor = System.Drawing.Color.Black;
            this.Green.Location = new System.Drawing.Point(170, 20);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(60, 60);
            this.Green.TabIndex = 21;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Cyan
            // 
            this.Cyan.BackColor = System.Drawing.Color.Cyan;
            this.Cyan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cyan.BackgroundImage")));
            this.Cyan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cyan.ForeColor = System.Drawing.Color.Black;
            this.Cyan.Location = new System.Drawing.Point(170, 86);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(60, 60);
            this.Cyan.TabIndex = 22;
            this.Cyan.UseVisualStyleBackColor = false;
            this.Cyan.Click += new System.EventHandler(this.Cyan_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Yellow.BackgroundImage")));
            this.Yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.ForeColor = System.Drawing.Color.Black;
            this.Yellow.Location = new System.Drawing.Point(236, 20);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(60, 60);
            this.Yellow.TabIndex = 23;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.Pink;
            this.Pink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pink.BackgroundImage")));
            this.Pink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pink.ForeColor = System.Drawing.Color.Black;
            this.Pink.Location = new System.Drawing.Point(236, 86);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(60, 60);
            this.Pink.TabIndex = 24;
            this.Pink.UseVisualStyleBackColor = false;
            this.Pink.Click += new System.EventHandler(this.Pink_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.Transparent;
            this.groupBox14.Controls.Add(this.button22);
            this.groupBox14.Controls.Add(this.button25);
            this.groupBox14.Controls.Add(this.button28);
            this.groupBox14.Controls.Add(this.button31);
            this.groupBox14.Controls.Add(this.button29);
            this.groupBox14.Controls.Add(this.button30);
            this.groupBox14.Controls.Add(this.button26);
            this.groupBox14.Controls.Add(this.button27);
            this.groupBox14.Controls.Add(this.button23);
            this.groupBox14.Controls.Add(this.button24);
            this.groupBox14.Controls.Add(this.button19);
            this.groupBox14.Controls.Add(this.button20);
            this.groupBox14.Controls.Add(this.button21);
            this.groupBox14.Controls.Add(this.button18);
            this.groupBox14.Controls.Add(this.button17);
            this.groupBox14.Controls.Add(this.button16);
            this.groupBox14.Enabled = false;
            this.groupBox14.Location = new System.Drawing.Point(6, 105);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(598, 149);
            this.groupBox14.TabIndex = 25;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Buttons";
            // 
            // button22
            // 
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Image = global::Delusion.Properties.Resources.DPAG_Right;
            this.button22.Location = new System.Drawing.Point(500, 83);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 60);
            this.button22.TabIndex = 17;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button25
            // 
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Image = global::Delusion.Properties.Resources.DPAD_Left;
            this.button25.Location = new System.Drawing.Point(434, 83);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 60);
            this.button25.TabIndex = 16;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button28
            // 
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Image = global::Delusion.Properties.Resources.DPAD_Down;
            this.button28.Location = new System.Drawing.Point(500, 16);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(60, 60);
            this.button28.TabIndex = 15;
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button31
            // 
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Image = global::Delusion.Properties.Resources.DPAD_Up;
            this.button31.Location = new System.Drawing.Point(434, 16);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(60, 60);
            this.button31.TabIndex = 14;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button29
            // 
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Image = global::Delusion.Properties.Resources.Start;
            this.button29.Location = new System.Drawing.Point(368, 17);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(60, 60);
            this.button29.TabIndex = 13;
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Image = global::Delusion.Properties.Resources.Back;
            this.button30.Location = new System.Drawing.Point(302, 17);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(60, 60);
            this.button30.TabIndex = 12;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button26
            // 
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Image = global::Delusion.Properties.Resources.RS;
            this.button26.Location = new System.Drawing.Point(236, 83);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(60, 60);
            this.button26.TabIndex = 10;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Image = global::Delusion.Properties.Resources.Y;
            this.button27.Location = new System.Drawing.Point(236, 17);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(60, 60);
            this.button27.TabIndex = 9;
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button23
            // 
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Image = global::Delusion.Properties.Resources.LS;
            this.button23.Location = new System.Drawing.Point(170, 83);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 60);
            this.button23.TabIndex = 7;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Image = global::Delusion.Properties.Resources.X;
            this.button24.Location = new System.Drawing.Point(170, 17);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 60);
            this.button24.TabIndex = 6;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button19
            // 
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Image = global::Delusion.Properties.Resources.RT;
            this.button19.Location = new System.Drawing.Point(368, 83);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 5;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Image = global::Delusion.Properties.Resources.RB;
            this.button20.Location = new System.Drawing.Point(104, 83);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 60);
            this.button20.TabIndex = 4;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Image = global::Delusion.Properties.Resources.B;
            this.button21.Location = new System.Drawing.Point(104, 17);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 60);
            this.button21.TabIndex = 3;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Image = global::Delusion.Properties.Resources.LT;
            this.button18.Location = new System.Drawing.Point(302, 83);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 60);
            this.button18.TabIndex = 2;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Image = global::Delusion.Properties.Resources.LB;
            this.button17.Location = new System.Drawing.Point(38, 83);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 60);
            this.button17.TabIndex = 1;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Image = global::Delusion.Properties.Resources.A;
            this.button16.Location = new System.Drawing.Point(38, 17);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 60);
            this.button16.TabIndex = 0;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(328, 48);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Pre-Game";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(217, 48);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "In-Game";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(6, 20);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(598, 20);
            this.textBox30.TabIndex = 0;
            this.textBox30.Text = "New Gamertag Here";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel6.Controls.Add(this.groupBox15);
            this.ribbonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel6.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel6.Size = new System.Drawing.Size(957, 595);
            // 
            // 
            // 
            this.ribbonPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel6.TabIndex = 6;
            this.ribbonPanel6.Visible = false;
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Transparent;
            this.groupBox15.Controls.Add(this.numericUpDown17);
            this.groupBox15.Controls.Add(this.label53);
            this.groupBox15.Controls.Add(this.buttonX36);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Controls.Add(this.groupBox17);
            this.groupBox15.Controls.Add(this.radioButton1);
            this.groupBox15.Controls.Add(this.radioButton2);
            this.groupBox15.Controls.Add(this.textBox1);
            this.groupBox15.Enabled = false;
            this.groupBox15.Location = new System.Drawing.Point(12, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(613, 455);
            this.groupBox15.TabIndex = 40;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Gamertag";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(446, 46);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown17.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown17.TabIndex = 38;
            this.numericUpDown17.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown17.ValueChanged += new System.EventHandler(this.numericUpDown17_ValueChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(347, 48);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(87, 13);
            this.label53.TabIndex = 37;
            this.label53.Text = "Number of Times";
            // 
            // buttonX36
            // 
            this.buttonX36.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX36.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX36.Location = new System.Drawing.Point(6, 70);
            this.buttonX36.Name = "buttonX36";
            this.buttonX36.Size = new System.Drawing.Size(598, 25);
            this.buttonX36.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX36.TabIndex = 36;
            this.buttonX36.Text = "Send";
            this.buttonX36.Click += new System.EventHandler(this.buttonX36_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.BackColor = System.Drawing.Color.Transparent;
            this.groupBox16.Controls.Add(this.button1);
            this.groupBox16.Controls.Add(this.button2);
            this.groupBox16.Controls.Add(this.button3);
            this.groupBox16.Controls.Add(this.button4);
            this.groupBox16.Controls.Add(this.button5);
            this.groupBox16.Controls.Add(this.button6);
            this.groupBox16.Controls.Add(this.button7);
            this.groupBox16.Controls.Add(this.button8);
            this.groupBox16.Controls.Add(this.button9);
            this.groupBox16.Controls.Add(this.button10);
            this.groupBox16.Controls.Add(this.button11);
            this.groupBox16.Controls.Add(this.button12);
            this.groupBox16.Enabled = false;
            this.groupBox16.Location = new System.Drawing.Point(6, 260);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(598, 156);
            this.groupBox16.TabIndex = 26;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Colors";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(434, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(368, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(302, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(104, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(434, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(104, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 19;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(368, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 29;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(302, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 28;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(170, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 21;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Cyan;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(170, 86);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 22;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Yellow;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(236, 20);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 23;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Pink;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(236, 86);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 24;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.BackColor = System.Drawing.Color.Transparent;
            this.groupBox17.Controls.Add(this.button13);
            this.groupBox17.Controls.Add(this.button14);
            this.groupBox17.Controls.Add(this.button32);
            this.groupBox17.Controls.Add(this.button33);
            this.groupBox17.Controls.Add(this.button34);
            this.groupBox17.Controls.Add(this.button35);
            this.groupBox17.Controls.Add(this.button36);
            this.groupBox17.Controls.Add(this.button37);
            this.groupBox17.Controls.Add(this.button38);
            this.groupBox17.Controls.Add(this.button39);
            this.groupBox17.Controls.Add(this.button40);
            this.groupBox17.Controls.Add(this.button41);
            this.groupBox17.Controls.Add(this.button42);
            this.groupBox17.Controls.Add(this.button55);
            this.groupBox17.Controls.Add(this.button56);
            this.groupBox17.Controls.Add(this.button57);
            this.groupBox17.Enabled = false;
            this.groupBox17.Location = new System.Drawing.Point(6, 105);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(598, 149);
            this.groupBox17.TabIndex = 25;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Buttons";
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::Delusion.Properties.Resources.DPAG_Right;
            this.button13.Location = new System.Drawing.Point(500, 83);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 17;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Image = global::Delusion.Properties.Resources.DPAD_Left;
            this.button14.Location = new System.Drawing.Point(434, 83);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 16;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button32
            // 
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Image = global::Delusion.Properties.Resources.DPAD_Down;
            this.button32.Location = new System.Drawing.Point(500, 16);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(60, 60);
            this.button32.TabIndex = 15;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Image = global::Delusion.Properties.Resources.DPAD_Up;
            this.button33.Location = new System.Drawing.Point(434, 16);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(60, 60);
            this.button33.TabIndex = 14;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Image = global::Delusion.Properties.Resources.Start;
            this.button34.Location = new System.Drawing.Point(368, 17);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(60, 60);
            this.button34.TabIndex = 13;
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Image = global::Delusion.Properties.Resources.Back;
            this.button35.Location = new System.Drawing.Point(302, 17);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(60, 60);
            this.button35.TabIndex = 12;
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Image = global::Delusion.Properties.Resources.RS;
            this.button36.Location = new System.Drawing.Point(236, 83);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(60, 60);
            this.button36.TabIndex = 10;
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Image = global::Delusion.Properties.Resources.Y;
            this.button37.Location = new System.Drawing.Point(236, 17);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(60, 60);
            this.button37.TabIndex = 9;
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Image = global::Delusion.Properties.Resources.LS;
            this.button38.Location = new System.Drawing.Point(170, 83);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(60, 60);
            this.button38.TabIndex = 7;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Image = global::Delusion.Properties.Resources.X;
            this.button39.Location = new System.Drawing.Point(170, 17);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(60, 60);
            this.button39.TabIndex = 6;
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Image = global::Delusion.Properties.Resources.RT;
            this.button40.Location = new System.Drawing.Point(368, 83);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(60, 60);
            this.button40.TabIndex = 5;
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Image = global::Delusion.Properties.Resources.RB;
            this.button41.Location = new System.Drawing.Point(104, 83);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(60, 60);
            this.button41.TabIndex = 4;
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Image = global::Delusion.Properties.Resources.B;
            this.button42.Location = new System.Drawing.Point(104, 17);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(60, 60);
            this.button42.TabIndex = 3;
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // button55
            // 
            this.button55.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button55.Image = global::Delusion.Properties.Resources.LT;
            this.button55.Location = new System.Drawing.Point(302, 83);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(60, 60);
            this.button55.TabIndex = 2;
            this.button55.UseVisualStyleBackColor = true;
            this.button55.Click += new System.EventHandler(this.button55_Click);
            // 
            // button56
            // 
            this.button56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button56.Image = global::Delusion.Properties.Resources.LB;
            this.button56.Location = new System.Drawing.Point(38, 83);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(60, 60);
            this.button56.TabIndex = 1;
            this.button56.UseVisualStyleBackColor = true;
            this.button56.Click += new System.EventHandler(this.button56_Click);
            // 
            // button57
            // 
            this.button57.BackColor = System.Drawing.Color.Transparent;
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Image = global::Delusion.Properties.Resources.A;
            this.button57.Location = new System.Drawing.Point(38, 17);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(60, 60);
            this.button57.TabIndex = 0;
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.button57_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(198, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Center";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(87, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Killfeed";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Text Here";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.groupBox10);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(957, 595);
            // 
            // 
            // 
            this.ribbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Transparent;
            this.groupBox10.Controls.Add(this.buttonX26);
            this.groupBox10.Controls.Add(this.label45);
            this.groupBox10.Controls.Add(this.numericUpDown16);
            this.groupBox10.Controls.Add(this.buttonX50);
            this.groupBox10.Controls.Add(this.buttonX47);
            this.groupBox10.Controls.Add(this.buttonX55);
            this.groupBox10.Controls.Add(this.buttonX21);
            this.groupBox10.Controls.Add(this.buttonX53);
            this.groupBox10.Controls.Add(this.buttonX51);
            this.groupBox10.Controls.Add(this.buttonX18);
            this.groupBox10.Controls.Add(this.buttonX29);
            this.groupBox10.Controls.Add(this.buttonX30);
            this.groupBox10.Controls.Add(this.buttonX31);
            this.groupBox10.Controls.Add(this.buttonX32);
            this.groupBox10.Controls.Add(this.buttonX25);
            this.groupBox10.Controls.Add(this.buttonX27);
            this.groupBox10.Controls.Add(this.buttonX28);
            this.groupBox10.Controls.Add(this.buttonX23);
            this.groupBox10.Controls.Add(this.buttonX24);
            this.groupBox10.Controls.Add(this.buttonX22);
            this.groupBox10.Controls.Add(this.label50);
            this.groupBox10.Controls.Add(this.label49);
            this.groupBox10.Controls.Add(this.label48);
            this.groupBox10.Controls.Add(this.label47);
            this.groupBox10.Controls.Add(this.label46);
            this.groupBox10.Controls.Add(this.label44);
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Controls.Add(this.label42);
            this.groupBox10.Controls.Add(this.label41);
            this.groupBox10.Controls.Add(this.label40);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.numericUpDown12);
            this.groupBox10.Controls.Add(this.numericUpDown30);
            this.groupBox10.Controls.Add(this.button54);
            this.groupBox10.Controls.Add(this.button53);
            this.groupBox10.Controls.Add(this.button52);
            this.groupBox10.Controls.Add(this.button51);
            this.groupBox10.Controls.Add(this.button43);
            this.groupBox10.Controls.Add(this.button44);
            this.groupBox10.Controls.Add(this.button45);
            this.groupBox10.Controls.Add(this.button46);
            this.groupBox10.Controls.Add(this.button47);
            this.groupBox10.Controls.Add(this.button48);
            this.groupBox10.Controls.Add(this.button49);
            this.groupBox10.Controls.Add(this.button50);
            this.groupBox10.Controls.Add(this.numericUpDown15);
            this.groupBox10.Controls.Add(this.numericUpDown13);
            this.groupBox10.Controls.Add(this.numericUpDown14);
            this.groupBox10.Controls.Add(this.numericUpDown11);
            this.groupBox10.Controls.Add(this.numericUpDown10);
            this.groupBox10.Controls.Add(this.numericUpDown9);
            this.groupBox10.Controls.Add(this.numericUpDown8);
            this.groupBox10.Controls.Add(this.numericUpDown7);
            this.groupBox10.Controls.Add(this.numericUpDown6);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(12, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(613, 455);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Stats";
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // buttonX26
            // 
            this.buttonX26.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX26.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX26.Location = new System.Drawing.Point(356, 313);
            this.buttonX26.Name = "buttonX26";
            this.buttonX26.Size = new System.Drawing.Size(80, 20);
            this.buttonX26.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX26.TabIndex = 108;
            this.buttonX26.Text = "Send";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label45.Location = new System.Drawing.Point(8, 313);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(140, 20);
            this.label45.TabIndex = 107;
            this.label45.Text = "Extinction Prestige";
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(184, 313);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown16.TabIndex = 106;
            this.numericUpDown16.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonX50
            // 
            this.buttonX50.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX50.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX50.Location = new System.Drawing.Point(475, 409);
            this.buttonX50.Name = "buttonX50";
            this.buttonX50.Size = new System.Drawing.Size(126, 37);
            this.buttonX50.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX50.TabIndex = 105;
            this.buttonX50.Text = "All Squad Members    Level 60";
            this.buttonX50.Click += new System.EventHandler(this.buttonX50_Click_1);
            // 
            // buttonX47
            // 
            this.buttonX47.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX47.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX47.Location = new System.Drawing.Point(270, 339);
            this.buttonX47.Name = "buttonX47";
            this.buttonX47.Size = new System.Drawing.Size(80, 49);
            this.buttonX47.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX47.TabIndex = 104;
            this.buttonX47.Text = "Unlock All";
            this.buttonX47.Click += new System.EventHandler(this.buttonX47_Click_1);
            // 
            // buttonX55
            // 
            this.buttonX55.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX55.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX55.Controls.Add(this.circularProgress2);
            this.buttonX55.Location = new System.Drawing.Point(356, 339);
            this.buttonX55.Name = "buttonX55";
            this.buttonX55.Size = new System.Drawing.Size(80, 49);
            this.buttonX55.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX55.TabIndex = 103;
            this.buttonX55.Text = "Send All Stats";
            this.buttonX55.Click += new System.EventHandler(this.buttonX55_Click);
            // 
            // circularProgress2
            // 
            // 
            // 
            // 
            this.circularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress2.Location = new System.Drawing.Point(67, 47);
            this.circularProgress2.Name = "circularProgress2";
            this.circularProgress2.Size = new System.Drawing.Size(75, 23);
            this.circularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress2.TabIndex = 0;
            // 
            // buttonX21
            // 
            this.buttonX21.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX21.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX21.Location = new System.Drawing.Point(356, 26);
            this.buttonX21.Name = "buttonX21";
            this.buttonX21.Size = new System.Drawing.Size(80, 20);
            this.buttonX21.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX21.TabIndex = 86;
            this.buttonX21.Text = "Send";
            this.buttonX21.Click += new System.EventHandler(this.buttonX21_Click);
            // 
            // buttonX53
            // 
            this.buttonX53.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX53.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX53.Location = new System.Drawing.Point(184, 339);
            this.buttonX53.Name = "buttonX53";
            this.buttonX53.Size = new System.Drawing.Size(80, 49);
            this.buttonX53.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX53.TabIndex = 101;
            this.buttonX53.Text = "Max Stats";
            this.buttonX53.Click += new System.EventHandler(this.buttonX53_Click);
            // 
            // buttonX51
            // 
            this.buttonX51.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX51.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX51.Location = new System.Drawing.Point(98, 339);
            this.buttonX51.Name = "buttonX51";
            this.buttonX51.Size = new System.Drawing.Size(80, 49);
            this.buttonX51.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX51.TabIndex = 100;
            this.buttonX51.Text = "Legit Stats";
            this.buttonX51.Click += new System.EventHandler(this.buttonX51_Click);
            // 
            // buttonX18
            // 
            this.buttonX18.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX18.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX18.Location = new System.Drawing.Point(12, 339);
            this.buttonX18.Name = "buttonX18";
            this.buttonX18.Size = new System.Drawing.Size(80, 49);
            this.buttonX18.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX18.TabIndex = 99;
            this.buttonX18.Text = "Reset Stats";
            this.buttonX18.Click += new System.EventHandler(this.buttonX18_Click_2);
            // 
            // buttonX29
            // 
            this.buttonX29.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX29.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX29.Location = new System.Drawing.Point(356, 287);
            this.buttonX29.Name = "buttonX29";
            this.buttonX29.Size = new System.Drawing.Size(80, 20);
            this.buttonX29.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX29.TabIndex = 97;
            this.buttonX29.Text = "Send";
            this.buttonX29.Click += new System.EventHandler(this.buttonX29_Click);
            // 
            // buttonX30
            // 
            this.buttonX30.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX30.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX30.Location = new System.Drawing.Point(356, 261);
            this.buttonX30.Name = "buttonX30";
            this.buttonX30.Size = new System.Drawing.Size(80, 20);
            this.buttonX30.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX30.TabIndex = 96;
            this.buttonX30.Text = "Send";
            this.buttonX30.Click += new System.EventHandler(this.buttonX30_Click);
            // 
            // buttonX31
            // 
            this.buttonX31.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX31.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX31.Location = new System.Drawing.Point(356, 235);
            this.buttonX31.Name = "buttonX31";
            this.buttonX31.Size = new System.Drawing.Size(80, 20);
            this.buttonX31.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX31.TabIndex = 95;
            this.buttonX31.Text = "Send";
            this.buttonX31.Click += new System.EventHandler(this.buttonX31_Click);
            // 
            // buttonX32
            // 
            this.buttonX32.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX32.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX32.Location = new System.Drawing.Point(356, 209);
            this.buttonX32.Name = "buttonX32";
            this.buttonX32.Size = new System.Drawing.Size(80, 20);
            this.buttonX32.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX32.TabIndex = 94;
            this.buttonX32.Text = "Send";
            this.buttonX32.Click += new System.EventHandler(this.buttonX32_Click);
            // 
            // buttonX25
            // 
            this.buttonX25.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX25.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX25.Location = new System.Drawing.Point(356, 183);
            this.buttonX25.Name = "buttonX25";
            this.buttonX25.Size = new System.Drawing.Size(80, 20);
            this.buttonX25.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX25.TabIndex = 93;
            this.buttonX25.Text = "Send";
            this.buttonX25.Click += new System.EventHandler(this.buttonX25_Click);
            // 
            // buttonX27
            // 
            this.buttonX27.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX27.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX27.Location = new System.Drawing.Point(356, 157);
            this.buttonX27.Name = "buttonX27";
            this.buttonX27.Size = new System.Drawing.Size(80, 20);
            this.buttonX27.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX27.TabIndex = 91;
            this.buttonX27.Text = "Send";
            this.buttonX27.Click += new System.EventHandler(this.buttonX27_Click);
            // 
            // buttonX28
            // 
            this.buttonX28.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX28.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX28.Location = new System.Drawing.Point(356, 131);
            this.buttonX28.Name = "buttonX28";
            this.buttonX28.Size = new System.Drawing.Size(80, 20);
            this.buttonX28.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX28.TabIndex = 90;
            this.buttonX28.Text = "Send";
            this.buttonX28.Click += new System.EventHandler(this.buttonX28_Click);
            // 
            // buttonX23
            // 
            this.buttonX23.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX23.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX23.Location = new System.Drawing.Point(356, 105);
            this.buttonX23.Name = "buttonX23";
            this.buttonX23.Size = new System.Drawing.Size(80, 20);
            this.buttonX23.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX23.TabIndex = 89;
            this.buttonX23.Text = "Send";
            this.buttonX23.Click += new System.EventHandler(this.buttonX23_Click);
            // 
            // buttonX24
            // 
            this.buttonX24.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX24.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX24.Location = new System.Drawing.Point(356, 78);
            this.buttonX24.Name = "buttonX24";
            this.buttonX24.Size = new System.Drawing.Size(80, 20);
            this.buttonX24.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX24.TabIndex = 88;
            this.buttonX24.Text = "Send";
            this.buttonX24.Click += new System.EventHandler(this.buttonX24_Click);
            // 
            // buttonX22
            // 
            this.buttonX22.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX22.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX22.Location = new System.Drawing.Point(356, 52);
            this.buttonX22.Name = "buttonX22";
            this.buttonX22.Size = new System.Drawing.Size(80, 20);
            this.buttonX22.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX22.TabIndex = 87;
            this.buttonX22.Text = "Send";
            this.buttonX22.Click += new System.EventHandler(this.buttonX22_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label50.Location = new System.Drawing.Point(8, 287);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(104, 20);
            this.label50.TabIndex = 85;
            this.label50.Text = "Squad Points";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label49.Location = new System.Drawing.Point(8, 261);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 20);
            this.label49.TabIndex = 84;
            this.label49.Text = "Misses";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label48.Location = new System.Drawing.Point(10, 235);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(37, 20);
            this.label48.TabIndex = 83;
            this.label48.Text = "Hits";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label47.Location = new System.Drawing.Point(10, 209);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(51, 20);
            this.label47.TabIndex = 82;
            this.label47.Text = "Score";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label46.Location = new System.Drawing.Point(8, 183);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(94, 20);
            this.label46.TabIndex = 81;
            this.label46.Text = "Time Played";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label44.Location = new System.Drawing.Point(8, 157);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(60, 20);
            this.label44.TabIndex = 79;
            this.label44.Text = "Losses";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label43.Location = new System.Drawing.Point(8, 131);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 20);
            this.label43.TabIndex = 78;
            this.label43.Text = "Wins";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label42.Location = new System.Drawing.Point(8, 105);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(61, 20);
            this.label42.TabIndex = 77;
            this.label42.Text = "Deaths";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label41.Location = new System.Drawing.Point(8, 78);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 20);
            this.label41.TabIndex = 76;
            this.label41.Text = "Killstreak";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label40.Location = new System.Drawing.Point(8, 52);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(36, 20);
            this.label40.TabIndex = 75;
            this.label40.Text = "Kills";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(8, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "XP";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(184, 26);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown12.TabIndex = 68;
            this.numericUpDown12.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown30
            // 
            this.numericUpDown30.Location = new System.Drawing.Point(184, 287);
            this.numericUpDown30.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown30.Name = "numericUpDown30";
            this.numericUpDown30.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown30.TabIndex = 65;
            this.numericUpDown30.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // button54
            // 
            this.button54.BackColor = System.Drawing.Color.White;
            this.button54.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button54.BackgroundImage")));
            this.button54.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button54.ForeColor = System.Drawing.Color.White;
            this.button54.Location = new System.Drawing.Point(541, 342);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(60, 60);
            this.button54.TabIndex = 64;
            this.button54.Text = "11th";
            this.button54.UseVisualStyleBackColor = false;
            this.button54.Click += new System.EventHandler(this.button54_Click);
            // 
            // button53
            // 
            this.button53.BackColor = System.Drawing.Color.White;
            this.button53.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button53.BackgroundImage")));
            this.button53.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button53.ForeColor = System.Drawing.Color.Black;
            this.button53.Location = new System.Drawing.Point(541, 277);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(60, 60);
            this.button53.TabIndex = 63;
            this.button53.UseVisualStyleBackColor = false;
            this.button53.Click += new System.EventHandler(this.button53_Click);
            // 
            // button52
            // 
            this.button52.BackColor = System.Drawing.Color.White;
            this.button52.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button52.BackgroundImage")));
            this.button52.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.ForeColor = System.Drawing.Color.Black;
            this.button52.Location = new System.Drawing.Point(541, 210);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(60, 60);
            this.button52.TabIndex = 62;
            this.button52.UseVisualStyleBackColor = false;
            this.button52.Click += new System.EventHandler(this.button52_Click);
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.White;
            this.button51.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button51.BackgroundImage")));
            this.button51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.ForeColor = System.Drawing.Color.Black;
            this.button51.Location = new System.Drawing.Point(541, 79);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(60, 60);
            this.button51.TabIndex = 61;
            this.button51.UseVisualStyleBackColor = false;
            this.button51.Click += new System.EventHandler(this.button51_Click);
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.White;
            this.button43.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button43.BackgroundImage")));
            this.button43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.ForeColor = System.Drawing.Color.Black;
            this.button43.Location = new System.Drawing.Point(541, 145);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(60, 60);
            this.button43.TabIndex = 40;
            this.button43.UseVisualStyleBackColor = false;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.White;
            this.button44.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button44.BackgroundImage")));
            this.button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.ForeColor = System.Drawing.Color.Black;
            this.button44.Location = new System.Drawing.Point(475, 211);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(60, 60);
            this.button44.TabIndex = 39;
            this.button44.UseVisualStyleBackColor = false;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.White;
            this.button45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button45.BackgroundImage")));
            this.button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.ForeColor = System.Drawing.Color.Black;
            this.button45.Location = new System.Drawing.Point(475, 14);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(60, 60);
            this.button45.TabIndex = 33;
            this.button45.UseVisualStyleBackColor = false;
            this.button45.Click += new System.EventHandler(this.button45_Click);
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.White;
            this.button46.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button46.BackgroundImage")));
            this.button46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button46.ForeColor = System.Drawing.Color.Black;
            this.button46.Location = new System.Drawing.Point(475, 80);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(60, 60);
            this.button46.TabIndex = 34;
            this.button46.UseVisualStyleBackColor = false;
            this.button46.Click += new System.EventHandler(this.button46_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.White;
            this.button47.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button47.BackgroundImage")));
            this.button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.ForeColor = System.Drawing.Color.Black;
            this.button47.Location = new System.Drawing.Point(541, 14);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(60, 60);
            this.button47.TabIndex = 38;
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.White;
            this.button48.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button48.BackgroundImage")));
            this.button48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.ForeColor = System.Drawing.Color.Black;
            this.button48.Location = new System.Drawing.Point(475, 146);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(60, 60);
            this.button48.TabIndex = 37;
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.White;
            this.button49.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button49.BackgroundImage")));
            this.button49.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.ForeColor = System.Drawing.Color.Black;
            this.button49.Location = new System.Drawing.Point(475, 277);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(60, 60);
            this.button49.TabIndex = 35;
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.White;
            this.button50.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button50.BackgroundImage")));
            this.button50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.ForeColor = System.Drawing.Color.Black;
            this.button50.Location = new System.Drawing.Point(475, 343);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(60, 60);
            this.button50.TabIndex = 36;
            this.button50.UseVisualStyleBackColor = false;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(184, 78);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown15.TabIndex = 45;
            this.numericUpDown15.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(184, 261);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown13.TabIndex = 43;
            this.numericUpDown13.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown13.ValueChanged += new System.EventHandler(this.numericUpDown13_ValueChanged);
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(184, 235);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown14.TabIndex = 41;
            this.numericUpDown14.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(184, 209);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown11.TabIndex = 37;
            this.numericUpDown11.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(184, 183);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown10.TabIndex = 35;
            this.numericUpDown10.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(184, 157);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown9.TabIndex = 33;
            this.numericUpDown9.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(184, 131);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown8.TabIndex = 31;
            this.numericUpDown8.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(184, 105);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown7.TabIndex = 29;
            this.numericUpDown7.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(184, 52);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown6.TabIndex = 27;
            this.numericUpDown6.Value = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel8.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel8.Size = new System.Drawing.Size(800, 598);
            // 
            // 
            // 
            this.ribbonPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel8.TabIndex = 8;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(800, 598);
            // 
            // 
            // 
            this.ribbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // Stats
            // 
            this.Stats.Name = "Stats";
            this.Stats.Panel = this.ribbonPanel3;
            this.Stats.Text = "Stats";
            this.Stats.Click += new System.EventHandler(this.Stats_Click);
            // 
            // Text1
            // 
            this.Text1.Name = "Text1";
            this.Text1.Panel = this.ribbonPanel6;
            this.Text1.Text = "Text";
            this.Text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // Gamertag
            // 
            this.Gamertag.Name = "Gamertag";
            this.Gamertag.Panel = this.ribbonPanel5;
            this.Gamertag.Text = "Gamertag";
            this.Gamertag.Click += new System.EventHandler(this.Gamertag_Click);
            // 
            // mis
            // 
            this.mis.Checked = true;
            this.mis.Name = "mis";
            this.mis.Panel = this.ribbonPanel7;
            this.mis.Text = "Misc";
            this.mis.Click += new System.EventHandler(this.mis_Click);
            // 
            // Premium
            // 
            this.Premium.Name = "Premium";
            this.Premium.Panel = this.ribbonPanel9;
            this.Premium.Text = "Premium";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 22);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(0, 13);
            this.label54.TabIndex = 0;
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // buttonX20
            // 
            this.buttonX20.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX20.Enabled = false;
            this.buttonX20.Location = new System.Drawing.Point(714, 342);
            this.buttonX20.Name = "buttonX20";
            this.buttonX20.Size = new System.Drawing.Size(75, 33);
            this.buttonX20.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX20.TabIndex = 36;
            this.buttonX20.Text = "Kick Client";
            this.buttonX20.Click += new System.EventHandler(this.buttonX20_Click);
            // 
            // superTabControl1
            // 
            this.superTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(0, 150);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.superTabControl1.SelectedTabIndex = 6;
            this.superTabControl1.Size = new System.Drawing.Size(250, 350);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 16;
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem14,
            this.buttonItem15,
            this.buttonItem16,
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4,
            this.buttonItem17,
            this.buttonItem18,
            this.controlContainerItem1});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel4.BackgroundImage")));
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(155, 350);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.KeyTips = "H";
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Help";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel3.BackgroundImage")));
            this.superTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(155, 350);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.KeyTips = "P";
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Print";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel2.BackgroundImage")));
            this.superTabControlPanel2.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(155, 350);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.KeyTips = "N";
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "New";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("superTabControlPanel1.BackgroundImage")));
            this.superTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(95, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(155, 350);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.KeyTips = "R";
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Recent";
            // 
            // buttonItem14
            // 
            this.buttonItem14.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem14.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem14.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem14.Image")));
            this.buttonItem14.ImagePaddingHorizontal = 18;
            this.buttonItem14.ImagePaddingVertical = 10;
            this.buttonItem14.KeyTips = "S";
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Stretch = true;
            this.buttonItem14.Text = "Save";
            // 
            // buttonItem15
            // 
            this.buttonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem15.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
            this.buttonItem15.ImagePaddingHorizontal = 18;
            this.buttonItem15.ImagePaddingVertical = 10;
            this.buttonItem15.KeyTips = "O";
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.Stretch = true;
            this.buttonItem15.Text = "Open";
            // 
            // buttonItem16
            // 
            this.buttonItem16.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem16.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
            this.buttonItem16.ImagePaddingHorizontal = 18;
            this.buttonItem16.ImagePaddingVertical = 10;
            this.buttonItem16.KeyTips = "C";
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.Stretch = true;
            this.buttonItem16.Text = "Close";
            // 
            // buttonItem17
            // 
            this.buttonItem17.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem17.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
            this.buttonItem17.ImagePaddingHorizontal = 18;
            this.buttonItem17.ImagePaddingVertical = 10;
            this.buttonItem17.KeyTips = "T";
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.Stretch = true;
            this.buttonItem17.Text = "Options";
            // 
            // buttonItem18
            // 
            this.buttonItem18.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem18.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
            this.buttonItem18.ImagePaddingHorizontal = 18;
            this.buttonItem18.ImagePaddingVertical = 10;
            this.buttonItem18.KeyTips = "X";
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.Stretch = true;
            this.buttonItem18.Text = "Exit";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Client -1: All Clients"});
            this.listBox1.Location = new System.Drawing.Point(631, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 303);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // gclient
            // 
            this.gclient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.gclient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.gclient.Enabled = false;
            this.gclient.Location = new System.Drawing.Point(631, 342);
            this.gclient.Name = "gclient";
            this.gclient.Size = new System.Drawing.Size(75, 33);
            this.gclient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gclient.TabIndex = 38;
            this.gclient.Text = "Get Clients";
            this.gclient.Click += new System.EventHandler(this.gclient_Click);
            // 
            // Misc
            // 
            this.Misc.Name = "Misc";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 39;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(35, 23);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(17, 13);
            this.label64.TabIndex = 41;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(154, 22);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(17, 13);
            this.label63.TabIndex = 42;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(280, 23);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(17, 13);
            this.label62.TabIndex = 43;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(47, 74);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(96, 13);
            this.label65.TabIndex = 45;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(199, 23);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(28, 13);
            this.label55.TabIndex = 1;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(7, 49);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 13);
            this.label56.TabIndex = 4;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(7, 75);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(17, 13);
            this.label57.TabIndex = 5;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(7, 101);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(17, 13);
            this.label58.TabIndex = 6;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(113, 49);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(31, 13);
            this.label59.TabIndex = 7;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(113, 75);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(34, 13);
            this.label60.TabIndex = 8;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(113, 101);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(28, 13);
            this.label61.TabIndex = 9;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(89, 182);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(17, 13);
            this.label68.TabIndex = 47;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(163, 182);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(17, 13);
            this.label39.TabIndex = 48;
            // 
            // MOTD
            // 
            this.MOTD.BackColor = System.Drawing.Color.White;
            this.MOTD.Location = new System.Drawing.Point(631, 381);
            this.MOTD.Multiline = true;
            this.MOTD.Name = "MOTD";
            this.MOTD.ReadOnly = true;
            this.MOTD.Size = new System.Drawing.Size(159, 103);
            this.MOTD.TabIndex = 30;
            this.MOTD.Text = "Unable to retrieve update notes.";
            this.MOTD.TextChanged += new System.EventHandler(this.MOTD_TextChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // CorRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.MOTD);
            this.Controls.Add(this.gclient);
            this.Controls.Add(this.buttonX20);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.Name = "CorRev";
            this.Text = "Delusion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ribbonPanel7.ResumeLayout(false);
            this.ribbonPanel10.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ty)).EndInit();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExceptNum)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ribbonPanel9.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.ribbonPanel6.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            this.buttonX55.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.RibbonTabItem Multiplayer;
        private DevComponents.DotNetBar.RibbonTabItem Extinction;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem Stats;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonTabItem Gamertag;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel6;
        private DevComponents.DotNetBar.RibbonTabItem Text1;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX4;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX3;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.Controls.Slider slider4;
        private DevComponents.DotNetBar.Controls.Slider slider3;
        private DevComponents.DotNetBar.Controls.Slider slider2;
        private DevComponents.DotNetBar.Controls.Slider slider1;
        private DevComponents.DotNetBar.Controls.Slider slider5;
        private System.Windows.Forms.GroupBox groupBox7;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX7;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX8;
        private DevComponents.DotNetBar.ButtonX buttonX10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private DevComponents.DotNetBar.Controls.Slider slider7;
        private DevComponents.DotNetBar.Controls.Slider slider8;
        private DevComponents.DotNetBar.Controls.Slider slider9;
        private DevComponents.DotNetBar.Controls.Slider slider10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton11;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton12;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton13;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton14;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton15;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton17;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton18;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton19;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton20;
        private System.Windows.Forms.GroupBox groupBox8;
        private DevComponents.DotNetBar.ButtonX buttonX15;
        private DevComponents.DotNetBar.ButtonX buttonX14;
        private DevComponents.DotNetBar.ButtonX buttonX13;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private DevComponents.DotNetBar.ButtonX buttonX11;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX6;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevComponents.DotNetBar.ButtonX buttonX17;
        private DevComponents.DotNetBar.ButtonX buttonX16;
        private DevComponents.DotNetBar.ButtonX buttonX20;
        private DevComponents.DotNetBar.ButtonX buttonX19;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.NumericUpDown numericUpDown30;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private DevComponents.DotNetBar.ButtonX buttonX29;
        private DevComponents.DotNetBar.ButtonX buttonX30;
        private DevComponents.DotNetBar.ButtonX buttonX31;
        private DevComponents.DotNetBar.ButtonX buttonX32;
        private DevComponents.DotNetBar.ButtonX buttonX25;
        private DevComponents.DotNetBar.ButtonX buttonX27;
        private DevComponents.DotNetBar.ButtonX buttonX28;
        private DevComponents.DotNetBar.ButtonX buttonX23;
        private DevComponents.DotNetBar.ButtonX buttonX24;
        private DevComponents.DotNetBar.ButtonX buttonX22;
        private DevComponents.DotNetBar.ButtonX buttonX21;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox11;
        private DevComponents.DotNetBar.ButtonX buttonX33;
        private DevComponents.DotNetBar.ButtonX buttonX34;
        private DevComponents.DotNetBar.ButtonX buttonX35;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private DevComponents.DotNetBar.ButtonX buttonX37;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button LightYellow;
        private System.Windows.Forms.Button YaleBlue;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Grey;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Cyan;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.GroupBox groupBox15;
        private DevComponents.DotNetBar.ButtonX buttonX36;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button55;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.Label label53;
        private DevComponents.DotNetBar.ButtonX gclient;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label69;
        private DevComponents.DotNetBar.Controls.Slider slider6;
        private DevComponents.DotNetBar.Controls.Slider slider11;
        private System.Windows.Forms.Label label70;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton21;
        private System.Windows.Forms.Label label72;
        private DevComponents.DotNetBar.Controls.Slider slider13;
        private System.Windows.Forms.Label label71;
        private DevComponents.DotNetBar.Controls.Slider slider12;
        private DevComponents.DotNetBar.ButtonX buttonX53;
        private DevComponents.DotNetBar.ButtonX buttonX51;
        private DevComponents.DotNetBar.ButtonX buttonX18;
        private System.Windows.Forms.Label label66;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton7;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton10;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton8;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton9;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton6;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton5;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.ButtonX buttonX55;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress2;
        private DevComponents.DotNetBar.ButtonItem Settings;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.RibbonTabItem Misc;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.ComboBox comboBox6;
        private DevComponents.DotNetBar.ButtonX buttonX40;
        private DevComponents.DotNetBar.ButtonX buttonX41;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.NumericUpDown numericUpDown28;
        private System.Windows.Forms.NumericUpDown numericUpDown29;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.NumericUpDown numericUpDown34;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private DevComponents.DotNetBar.ButtonX buttonX45;
        private DevComponents.DotNetBar.ButtonX buttonX46;
        private System.Windows.Forms.Label label65;
        private DevComponents.DotNetBar.Controls.CheckBoxX Except;
        private System.Windows.Forms.NumericUpDown ExceptNum;
        private System.Windows.Forms.TextBox textBox2;
        private DevComponents.DotNetBar.ButtonX buttonX38;
        private DevComponents.DotNetBar.ButtonX buttonX39;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox models;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown x;
        private System.Windows.Forms.NumericUpDown y;
        private System.Windows.Forms.NumericUpDown z;
        private System.Windows.Forms.NumericUpDown yaw;
        private System.Windows.Forms.NumericUpDown pitch;
        private System.Windows.Forms.NumericUpDown roll;
        private DevComponents.DotNetBar.ButtonX buttonX43;
        private DevComponents.DotNetBar.ButtonX buttonX42;
        private DevComponents.DotNetBar.ButtonX buttonX44;
        private DevComponents.DotNetBar.Controls.CheckBoxX codeGen;
        private DevComponents.DotNetBar.ButtonX buttonX54;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.NumericUpDown tx;
        private System.Windows.Forms.NumericUpDown ty;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel8;
        private DevComponents.DotNetBar.RibbonTabItem mis;
        private DevComponents.DotNetBar.ButtonX buttonX50;
        private DevComponents.DotNetBar.ButtonX buttonX47;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevComponents.DotNetBar.ButtonX buttonX48;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.CheckBox flip;
        private System.Windows.Forms.GroupBox groupBox22;
        private DevComponents.DotNetBar.ButtonX buttonX49;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox clanTag;
        private DevComponents.DotNetBar.ButtonX buttonX52;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label91;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton22;
        private System.Windows.Forms.Label label92;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton23;
        private System.Windows.Forms.Label label93;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton24;
        private DevComponents.DotNetBar.ButtonX buttonX26;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private DevComponents.DotNetBar.ButtonX buttonX56;
        private DevComponents.DotNetBar.ButtonX buttonX59;
        private DevComponents.DotNetBar.ButtonX buttonX60;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.GroupBox groupBox25;
        private DevComponents.DotNetBar.ButtonX buttonX65;
        private DevComponents.DotNetBar.ButtonX buttonX64;
        private DevComponents.DotNetBar.ButtonX buttonX63;
        private DevComponents.DotNetBar.ButtonX buttonX62;
        private DevComponents.DotNetBar.ButtonX buttonX61;
        private DevComponents.DotNetBar.RibbonTabItem Premium;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.TextBox textBox3;
        private DevComponents.DotNetBar.ButtonX buttonX66;
        private System.Windows.Forms.TextBox textBox4;
        private DevComponents.DotNetBar.ButtonX buttonX67;
        private System.Windows.Forms.TextBox MOTD;
        private System.Windows.Forms.GroupBox groupBox28;
        private DevComponents.DotNetBar.ButtonX buttonX70;
        private DevComponents.DotNetBar.ButtonX buttonX69;
        private DevComponents.DotNetBar.ButtonX buttonX68;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox29;
        private DevComponents.DotNetBar.ButtonX buttonX75;
        private DevComponents.DotNetBar.ButtonX buttonX76;
        private DevComponents.DotNetBar.ButtonX buttonX73;
        private DevComponents.DotNetBar.ButtonX buttonX74;
        private DevComponents.DotNetBar.ButtonX buttonX71;
        private DevComponents.DotNetBar.ButtonX buttonX72;
        private System.Windows.Forms.GroupBox groupBox30;
        private DevComponents.DotNetBar.ButtonX buttonX81;
        private DevComponents.DotNetBar.ButtonX buttonX80;
        private DevComponents.DotNetBar.ButtonX buttonX77;
        private DevComponents.DotNetBar.ButtonX buttonX78;
        private DevComponents.DotNetBar.ButtonX buttonX79;
        private System.Windows.Forms.CheckBox checkerBoard;
        private System.Windows.Forms.GroupBox groupBox31;
        private DevComponents.DotNetBar.ButtonX buttonX82;
        private System.Windows.Forms.NumericUpDown numericUpDown19;
        private DevComponents.DotNetBar.ButtonX buttonX86;
        private DevComponents.DotNetBar.ButtonX buttonX85;
        private DevComponents.DotNetBar.ButtonX buttonX84;
        private DevComponents.DotNetBar.ButtonX buttonX83;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton2;
        private DevComponents.DotNetBar.ButtonX buttonX57;
        private System.Windows.Forms.GroupBox groupBox24;
        private DevComponents.DotNetBar.ButtonX buttonX58;
        private DevComponents.DotNetBar.ButtonX buttonX87;
        private System.Windows.Forms.GroupBox groupBox32;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel10;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel11;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
    }
}

