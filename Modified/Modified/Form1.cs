using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XRPCLib;

namespace Modified
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        XRPC Jtag = new XRPC();
        string COD4 = "COD 4: Modern Warfare";
        string WAW = "COD 5: World at War";
        string MW2 = "COD 6: Modern Warfare 2";
        string BO = "COD 7: Black Ops";
        string MW3 = "COD 8: Modern Warfare 3";
        string BO2 = "COD 9: Black Ops 2";
        string Ghosts = "COD 10: Ghosts";
        string activeGame;
        public Form1()
        {
            InitializeComponent();
            refreshText(COD4);
        }

        private void renameButtons(string[] labelNames)
        {
            for(int r = 0; r < 14; r++)
            {
                switch (r)
                {
                    case 0:
                        option1Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option1Label.Text = "Unavailable";
                            option1Label.Enabled = false;
                            option1Button.Enabled = false;
                            option1Value.Enabled = false;
                        }
                        else
                        {
                            option1Label.Enabled = true;
                            option1Button.Enabled = true;
                            option1Value.Enabled = true;
                        }
                        break;
                    case 1:
                        option2Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option2Label.Text = "Unavailable";
                            option2Label.Enabled = false;
                            option2Button.Enabled = false;
                            option2Value.Enabled = false;
                        }
                        else
                        {
                            option2Label.Enabled = true;
                            option2Button.Enabled = true;
                            option2Value.Enabled = true;
                        }
                        break;
                    case 2:
                        option3Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option3Label.Text = "Unavailable";
                            option3Label.Enabled = false;
                            option3Button.Enabled = false;
                            option3Value.Enabled = false;
                        }
                        else
                        {
                            option3Label.Enabled = true;
                            option3Button.Enabled = true;
                            option3Value.Enabled = true;
                        }
                        break;
                    case 3:
                        option4Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option4Label.Text = "Unavailable";
                            option4Label.Enabled = false;
                            option4Button.Enabled = false;
                            option4Value.Enabled = false;
                        }
                        else
                        {
                            option4Label.Enabled = true;
                            option4Button.Enabled = true;
                            option4Value.Enabled = true;
                        }
                        break;
                    case 4:
                        option5Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option5Label.Text = "Unavailable";
                            option5Label.Enabled = false;
                            option5Button.Enabled = false;
                            option5Value.Enabled = false;
                        }
                        else
                        {
                            option5Label.Enabled = true;
                            option5Button.Enabled = true;
                            option5Value.Enabled = true;
                        }
                        break;
                    case 5:
                        option6Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option6Label.Text = "Unavailable";
                            option6Label.Enabled = false;
                            option6Button.Enabled = false;
                            option6Value.Enabled = false;
                        }
                        else
                        {
                            option6Label.Enabled = true;
                            option6Button.Enabled = true;
                            option6Value.Enabled = true;
                        }
                        break;
                    case 6:
                        option7Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option7Label.Text = "Unavailable";
                            option7Label.Enabled = false;
                            option7Button.Enabled = false;
                            option7Value.Enabled = false;
                        }
                        else
                        {
                            option7Label.Enabled = true;
                            option7Button.Enabled = true;
                            option7Value.Enabled = true;
                        }
                        break;
                    case 7:
                        option8Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option8Label.Text = "Unavailable";
                            option8Label.Enabled = false;
                            option8Button.Enabled = false;
                            option8Value.Enabled = false;
                        }
                        else
                        {
                            option8Label.Enabled = true;
                            option8Button.Enabled = true;
                            option8Value.Enabled = true;
                        }
                        break;
                    case 8:
                        option9Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option9Label.Text = "Unavailable";
                            option9Label.Enabled = false;
                            option9Button.Enabled = false;
                            option9Value.Enabled = false;
                        }
                        else
                        {
                            option9Label.Enabled = true;
                            option9Button.Enabled = true;
                            option9Value.Enabled = true;
                        }
                        break;
                    case 9:
                        option10Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option10Label.Text = "Unavailable";
                            option10Label.Enabled = false;
                            option10Button.Enabled = false;
                            option10Value.Enabled = false;
                        }
                        else
                        {
                            option10Label.Enabled = true;
                            option10Button.Enabled = true;
                            option10Value.Enabled = true;
                        }
                        break;
                    case 10:
                        option11Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option11Label.Text = "Unavailable";
                            option11Label.Enabled = false;
                            option11Button.Enabled = false;
                            option11Value.Enabled = false;
                        }
                        else
                        {
                            option11Label.Enabled = true;
                            option11Button.Enabled = true;
                            option11Value.Enabled = true;
                        }
                        break;
                    case 11:
                        option12Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option12Label.Text = "Unavailable";
                            option12Label.Enabled = false;
                            option12Button.Enabled = false;
                            option12Value.Enabled = false;
                        }
                        else
                        {
                            option12Label.Enabled = true;
                            option12Button.Enabled = true;
                            option12Value.Enabled = true;
                        }
                        break;
                    case 12:
                        option13Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option13Label.Text = "Unavailable";
                            option13Label.Enabled = false;
                            option13Button.Enabled = false;
                            option13Value.Enabled = false;
                        }
                        else
                        {
                            option13Label.Enabled = true;
                            option13Button.Enabled = true;
                            option13Value.Enabled = true;
                        }
                        break;
                    case 13:
                        option14Label.Text = labelNames[r];
                        if (labelNames[r] == null)
                        {
                            option14Label.Text = "Unavailable";
                            option14Label.Enabled = false;
                            option14Button.Enabled = false;
                            option14Value.Enabled = false;
                        }
                        else
                        {
                            option14Label.Enabled = true;
                            option14Button.Enabled = true;
                            option14Value.Enabled = true;
                        }
                        break;
                }
            }
        }

        private void refreshText(string game)
        {
            for (int i = 0; i < 7; i++)
            {
                switch(i)
                {
                    case 0:
                        buttonX1.Text = COD4;
                        buttonX1.TextColor = Color.Black;
                        break;
                    case 1:
                        buttonX2.Text = WAW;
                        buttonX2.TextColor = Color.Black;
                        break;
                    case 2:
                        buttonX3.Text = MW2;
                        buttonX3.TextColor = Color.Black;
                        break;
                    case 3:
                        buttonX4.Text = BO;
                        buttonX4.TextColor = Color.Black;
                        break;
                    case 4:
                        buttonX5.Text = MW3;
                        buttonX5.TextColor = Color.Black;
                        break;
                    case 5:
                        buttonX6.Text = BO2;
                        buttonX6.TextColor = Color.Black;
                        break;
                    case 6:
                        buttonX7.Text = Ghosts;
                        buttonX7.TextColor = Color.Black;
                        break;
                    default:
                        break;
                }
            }
            switch (game)
            {
                case "COD 4: Modern Warfare":
                    buttonX1.TextColor = Color.Green;
                    buttonX1.Text = "[ " + COD4 + " ]";
                    activeGame = COD4;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", null, null });
                    this.Size = new Size(475, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                case "COD 5: World at War":
                    buttonX2.TextColor = Color.Green;
                    buttonX2.Text = "[ " + WAW + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Zombies";
                    activeGame = WAW;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", null, null });
                    this.Size = new Size(705, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                case "COD 6: Modern Warfare 2":
                    buttonX3.TextColor = Color.Green;
                    buttonX3.Text = "[ " + MW2 + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Option 2";
                    activeGame = MW2;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", "Killstreaks", null });
                    this.Size = new Size(475, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                case "COD 7: Black Ops":
                    buttonX4.TextColor = Color.Green;
                    buttonX4.Text = "[ " + BO + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Zombies";
                    activeGame = BO;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", "COD Points", null });
                    this.Size = new Size(705, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                case "COD 8: Modern Warfare 3":
                    buttonX5.TextColor = Color.Green;
                    buttonX5.Text = "[ " + MW3 + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Survival";
                    activeGame = MW3;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", "Prestige Tokens", "Double XP/Weap" });
                    this.Size = new Size(705, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                case "COD 9: Black Ops 2":
                    buttonX6.TextColor = Color.Green;
                    buttonX6.Text = "[ " + BO2 + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Zombies";
                    activeGame = BO2;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", "Prestige Tokens", null });
                    this.Size = new Size(705, 485);
                    break;
                case "COD 10: Ghosts":
                    buttonX7.TextColor = Color.Green;
                    buttonX7.Text = "[ " + Ghosts + " ]";
                    groupBox2.Text = "Multiplayer";
                    groupBox3.Text = "Extinction";
                    activeGame = Ghosts;
                    renameButtons(new string[] { "Prestige", "XP", "Score", "Kills", "Deaths", "Headshots", "Assists", "Hits", "Misses", "Wins", "Losses", "Time Played", "Squad Points", null });
                    this.Size = new Size(705, 485);
                    panel1.Size = new Size(452, 485);
                    break;
                default:
                    break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            refreshText(COD4);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            refreshText(WAW);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            refreshText(MW2);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            refreshText(BO);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            refreshText(MW3);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            refreshText(BO2);
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            refreshText(Ghosts);
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {

        }

        private void buttonX40_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection)
                {
                    ConnectionStatus.Text = "Connection Status: Successful";
                    ConnectionStatus.ForeColor = Color.Green;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                }
                else
                {
                    ConnectionStatus.Text = "Connection Status: Failed";
                    ConnectionStatus.ForeColor = Color.Red;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
            catch
            {
                ConnectionStatus.Text = "Connection Status: Failed";
                ConnectionStatus.ForeColor = Color.Red;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }
    }
}