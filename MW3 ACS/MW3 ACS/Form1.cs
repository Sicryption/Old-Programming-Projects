using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;

namespace MW3_ACS
{
    public partial class Form1 : Form
    {
        IXboxConsole xbc;
        /*
        EXAMPLE USAGE (Will set squad points to 1500):

        uint clientIndex = ??;
        SetStat<int>(clientIndex, 0x4C2C, 1500);
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public uint DataBuffer;
        public uint CommandSize;
        public uint MessageLength;
        public bool Overflowed;

        public void msg_t()
        {
            CommandSize = 0x400;
            DataBuffer = xbc.AllocateMemory(CommandSize);
            MessageLength = 0;
            Overflowed = false;
        }

        private void UpdateOverflowedBoolean()
        {
            if (MessageLength > CommandSize)
            {
                Overflowed = true;
            }
        }

        public void Append<T>(T value, bool littleEndian = false)
        {
            Type t = typeof(T);

            if (!IsValidType(t))
            {
                throw new Exception("msg_t.AppendMessage: Invalid type!");
            }

            if (t == typeof(bool))
            {
                xbc.WriteInt32(DataBuffer + MessageLength, ((bool)(object)value == true) ? 1 : 0);
                MessageLength += 4;
            }
            else if (t == typeof(string))
            {
                xbc.WriteString
                xbc.WriteString(DataBuffer + MessageLength, (string)(object)value, false);
                MessageLength += (uint)Encoding.UTF8.GetBytes((string)(object)value).Length;
            }
            else if (t == typeof(byte[]))
            {
                byte[] bytes = (byte[])(object)value;
                xbc.SetMemory(DataBuffer + MessageLength, bytes);
                MessageLength += (uint)bytes.Length;
            }
            else if (t == typeof(byte))
            {
                xbc.WriteByte(DataBuffer + MessageLength, (byte)(object)value);
                MessageLength += 1;
            }
            else
            {
                var bytes = typeof(BitConverter)
                    .GetMethod("GetBytes", new Type[] { value.GetType() })
                    .Invoke(null, new object[] { value });

                byte[] data = (byte[])(object)bytes;
                if (!littleEndian) Array.Reverse(data);

                xbc.SetMemory(DataBuffer + MessageLength, data);
                MessageLength += (uint)data.Length;
            }

            UpdateOverflowedBoolean();
        }

        public byte[] GetBytes()
        {
            if (Overflowed)
            {
                throw new Exception("msg_t.GetBytes: Message overflowed buffer!");
            }

            byte[] bytes = new byte[0x18];
            BitHelper.WriteUInt32(bytes, 0x00, 0);
            BitHelper.WriteUInt32(bytes, 0x04, 0);
            BitHelper.WriteUInt32(bytes, 0x08, DataBuffer);
            BitHelper.WriteUInt32(bytes, 0x0C, 0);
            BitHelper.WriteUInt32(bytes, 0x10, CommandSize);
            BitHelper.WriteUInt32(bytes, 0x14, MessageLength);
            return bytes;
        }

        public uint Client_s(uint clientIndex)
        {
            uint r9 = 0x834C0480;
            uint r8 = 0x205E90;
            uint r10 = 0x68B80;
            uint r11 = xbc.ReadUInt32(r9 + r8);
            r10 = clientIndex * r10;
            return r10 + r11;
        }

        public void SV_SendClientStatMessage(uint clientIndex, msg_t msg)
        {
            uint addy = xbc.AllocateMemory((uint)0x18);
            xbc.SetMemory(addy, msg.GetBytes());
            xbc.Call<uint>(0x822CCF38, Client_s(clientIndex), 1, addy);
            xbc.FreeMemory(addy);
        }

        public uint SV_GetClientStatEntry(uint clientIndex)
        {
            return xbc.Call<uint>(0x822C4DA8, clientIndex);
        }

        private void SetStat(uint clientIndex, uint index, byte[] value)//may not work
        {
            Append<byte>(0x5A);
            Append<byte>(0x00);
            Append<ushort>((ushort)(value.Length + 6));
            Append<byte>(0x47);
            Append<uint>(index);
            Append<byte>((byte)value.Length);
            Append<byte[]>(value);

            SV_SendClientStatMessage(clientIndex, msg);
        }

        private bool IsValidType(Type t)
        {
            if (t == typeof(bool) || t == typeof(byte) || t == typeof(short) || t == typeof(int) ||
                t == typeof(long) || t == typeof(ushort) || t == typeof(uint) || t == typeof(ulong) ||
                t == typeof(float) || t == typeof(double) || t == typeof(string) || t == typeof(byte[]))
            {
                return true;
            }
            return false;
        }

        public void SetStat<T>(uint index, T value, bool littleEndian = true)
        {
            Type t = typeof(T);

            if (!IsValidType(t))
            {
                throw new Exception("Client.SetStat: Invalid type!");
            }

            if (t == typeof(string))
            {
                string str = (string)(object)value;
                SetStat(index, Encoding.UTF8.GetBytes(str));
                return;
            }
            else if (t == typeof(byte[]))
            {
                SetStat(index, (byte[])(object)value);
                return;
            }
            else if (t == typeof(byte))
            {
                SetStat(index, new byte[] { (byte)(object)value });
                return;
            }

            var bytes = typeof(BitConverter)
                .GetMethod("GetBytes", new Type[] { value.GetType() })
                .Invoke(null, new object[] { value });

            if (!littleEndian) Array.Reverse((byte[])bytes);
            SetStat(index, (byte[])bytes);
        }

        public byte[] GetStat(uint clientIndex, uint index, uint length)
        {
            return xbc.GetMemory(SV_GetClientStatEntry(clientIndex) + index, length);
        }
    }
}
