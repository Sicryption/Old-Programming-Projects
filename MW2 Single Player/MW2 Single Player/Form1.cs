using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Binarysharp;

namespace MW2_Single_Player
{
    public partial class Form1 : Form
    {
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_OPERATION = 0x0008;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess,
               bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
          byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr parentWindow, IntPtr previousChildWindow, string windowClass, string windowTitle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr window, out int process);

        int PROCESS_ALL_ACCESS = 0x1F0FFF;
        IntPtr baseAddress = (IntPtr)0x400000;

        public Process mw2;
        IntPtr processHandle;
        bool connected { get { return openProcess(); } }
        
        public bool openProcess()
        {
            var list = Process.GetProcessesByName("iw4sp");

            if (list.Count() > 0)
                mw2 = list[0];

            if (mw2 == null)
                return false;

            processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, mw2.Id);
            
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Status: " + (connected ? "connected" : "disconnected");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WriteMemory();
        }

        public void WriteMemory()
        {
            Binarysharp.MemoryManagement.MemorySharp ms = new Binarysharp.MemoryManagement.MemorySharp(14300);
            var v = ms.Read<Byte>((IntPtr)0x271f08);

                Console.WriteLine(v);
        }
    }
}