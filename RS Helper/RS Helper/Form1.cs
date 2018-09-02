using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RS_Helper
{
    public partial class RSHelper : Form
    {
        public static int EXPOffset = 0x0;

        KeyboardHook KH = new KeyboardHook();
        MouseHook MH = new MouseHook();

        int stepCount = 0;
        public static bool canDoScript = true;//0 = yes, 1 = no, 2 = waiting

        int x = 0, y = 0;

        public DateTime scriptStartTime;
        public DateTime MilisecondsSinceStart;
        public bool canContinueScriptWithTimer = true;
        public int WaitTime = 0;
        public RSHelper()
        {
            InitializeComponent();
            MH.Install();
            KH.KeyDown += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
            MH.RightButtonDown += new MouseHook.MouseHookCallback(RightButtonDown);
            MH.LeftButtonDown += new MouseHook.MouseHookCallback(LeftButtonDown);
        }

        void RightButtonDown(MouseHook.MSLLHOOKSTRUCT button)
        {

        }

        void LeftButtonDown(MouseHook.MSLLHOOKSTRUCT button)
        {

        }
        
        void keyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            if (MKState == state.Enabled && canContinueScriptWithTimer)
            {
                #region normalahk
                if (NormalAHK.Checked)
                {
                    if (!NormalAHKCheckbox.Checked)
                    {
                        switch (key)
                        {
                            case KeyboardHook.VKeys.KEY_Q:
                                //right click
                                RightClick();
                                break;
                            case KeyboardHook.VKeys.KEY_W:
                                //move down 36
                                SetMousePosition(activeX(), activeY() + (int)((14 * NormalAHKLine.Value) + 14));//36 for 2
                                break;
                            case KeyboardHook.VKeys.KEY_E:
                                //left click
                                LeftClick();
                                break;
                            case KeyboardHook.VKeys.KEY_R:
                                //move down 36
                                SetMousePosition(activeX(), activeY() - (int)((14 * NormalAHKLine.Value) + 14));//36 for 2
                                break;
                        }
                    }
                    else
                    {
                        switch (key)
                        {
                            case KeyboardHook.VKeys.NUMPAD5:
                                //right click
                                RightClick();
                                break;
                            case KeyboardHook.VKeys.NUMPAD2:
                                //move down 36
                                SetMousePosition(activeX(), activeY() + (int)((14 * NormalAHKLine.Value) + 14));//36 for 2
                                break;
                            case KeyboardHook.VKeys.NUMPAD0:
                                //left click
                                LeftClick();
                                break;
                            case KeyboardHook.VKeys.NUMPAD8:
                                //move down 36
                                SetMousePosition(activeX(), activeY() - (int)((14 * NormalAHKLine.Value) + 14));//36 for 2
                                break;
                        }
                    }
                }
                #endregion
                #region PrayFlicking
                else if (prayerFlick.Checked)
                {
                    switch (key)
                    {
                        case KeyboardHook.VKeys.NUMPAD0:
                            switch(stepCount)
                            {
                                case 0:
                                    if ((DateTime.Now - lastPrayerFlickTime).Milliseconds >= 550)
                                    {
                                        MoveAndClick(1475, 141);
                                        lastPrayerFlickTime = DateTime.Now;
                                        stepCount = 1;
                                    }
                                    break;
                                case 1:
                                    if ((DateTime.Now - lastPrayerFlickTime).Milliseconds >= 50)
                                    {
                                        MoveAndClick(1475, 141);
                                        lastPrayerFlickTime = DateTime.Now;
                                        stepCount = 0;
                                    }
                                    break;
                                default:
                                    stepCount = 0;
                                    break;

                            }
                            break;
                    }
                }
                #endregion
            }
        }

        DateTime lastPrayerFlickTime = DateTime.Now;

        void Wait(int milliseconds)
        {
            WaitTime = milliseconds;
            canContinueScriptWithTimer = false;
            scriptStartTime = DateTime.Now;
        }

        void MoveAndClick(int x, int y)
        {
            SetMousePosition(x, y);
            LeftClick();
        }
        void MoveAndRightClick(int x, int y)
        {
            SetMousePosition(x, y);
            RightClick();
        }
        void ClickSlot(int row, int column)
        {
            SetMousePosition(600 + (row * 38), 216 + (column * 38));
            LeftClick();
        }
        void RightClickSlot(int row, int column)
        {
            SetMousePosition(600 + (row * 38), 216 + (column * 38));
            RightClick();
        }

        void CleanHerbs()
        {
            ClickSlot(x, y);
            GetNextSlot();
        }

        void GetNextSlot()
        {
            x++;
            if (x > 3)
            {
                x = 0;
                y++;
            }
            if (y > 6)
                y = 0;
        }

        void DoBasket()
        {
            switch (stepCount)
            {
                case 0://click basket
                    SetMousePosition(346, 262);
                    break;
                case 1:
                    RightClick();
                    break;
                case 2://grab 4
                    SetMousePosition(326, 328);
                    break;
                case 3:
                    LeftClick();
                    break;
                case 4://click apple
                    SetMousePosition(389, 258);
                    break;
                case 5:
                    RightClick();
                    break;
                case 6://grab all
                    SetMousePosition(401, 356);
                    break;
                case 7:
                    LeftClick();
                    break;
                case 8://close window
                    SetMousePosition(504, 76);
                    break;
                case 9:
                    LeftClick();
                    break;
                case 10://fill first basket
                    SetMousePosition(605, 244);
                    break;
                case 11:
                    LeftClick();
                    break;
                case 12://fill second basket
                    SetMousePosition(645, 245);
                    break;
                case 13:
                    LeftClick();
                    break;
                case 14://fill third basket
                    SetMousePosition(685, 243);
                    break;
                case 15:
                    LeftClick();
                    break;
                case 16://fill fourth basket
                    SetMousePosition(725, 249);
                    break;
                case 17:
                    LeftClick();
                    break;
                case 18://find banker
                    SetMousePosition(376, 303);
                    break;
                case 19:
                    complete = false;
                    LeftClick();
                    System.Threading.Thread.Sleep(1000);
                    complete = true;
                    break;
                case 20://deposit inv
                    if (!complete)
                        stepCount = 19;
                    else
                        SetMousePosition(460, 374);
                    break;
                case 21:
                    complete = false;
                    LeftClick();
                    System.Threading.Thread.Sleep(200);
                    complete = true;
                    break;
                case 22:
                    if (!complete)
                        stepCount = 21;
                    else
                        stepCount = -1;
                    break;
            }
        }

        bool complete = true;

        void RightClick()
        {
            MH.MouseEvent(MouseHook.MouseEventFlags.RightDown);
            MH.MouseEvent(MouseHook.MouseEventFlags.RightUp);
        }

        void LeftClick()
        {
            MH.MouseEvent(MouseHook.MouseEventFlags.LeftDown);
            MH.MouseEvent(MouseHook.MouseEventFlags.LeftUp);
        }

        int activeX()
        {
            MH.MousePos = MH.GetCursorPosition();
            return MH.MousePos.X;
        }

        int activeY()
        {
            MH.MousePos = MH.GetCursorPosition();
            return MH.MousePos.Y;
        }

        public void SetMousePosition(int x, int y)
        {
            MH.MousePos = MH.GetCursorPosition();
            MH.MousePos.X = x;
            MH.MousePos.Y = y;
            MH.SetCursorPosition(MH.MousePos);
        }

        public enum state
        {
            Null,
            Enabled,
            Disabled
        } state MKState = state.Null;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (MKState)
            {
                case state.Null:
                    KH.Install();
                    MKState = state.Disabled;
                    goto case state.Disabled;
                case state.Enabled:
                    status.Text = "Disabled";
                    MKState = state.Disabled;
                    break;
                case state.Disabled:
                    status.Text = "Enabled";
                    MKState = state.Enabled;
                    break;
            }
        }

        private void NormalAHKCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalAHKCheckbox.Checked)
                NormalAHKCheckbox.Text = "Keys: (8, 5, 2, 0)";
            else
                NormalAHKCheckbox.Text = "Keys: (Q, W, E, R)";
        }

        private void herbloreoption_CheckedChanged(object sender, EventArgs e)
        {
            if (herbloreoption.Checked)
                herbloreoption.Text = "Make Potions";
            else if (!herbloreoption.Checked)
                herbloreoption.Text = "Clean Herbs";
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            MilisecondsSinceStart = DateTime.Now;

            if ((MilisecondsSinceStart - scriptStartTime).TotalMilliseconds >= WaitTime)
                canContinueScriptWithTimer = true;
        }
    }
}
