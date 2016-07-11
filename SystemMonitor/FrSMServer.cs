using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMonitor
{
    public partial class FrSMServer : Form
    {
        private int Port = 54321;
        private UdpClient udpClient;
        public ShowMessage myDelegate;
        private int totpc;
        private pcc[] pccoll = new pcc[100];
        private int maxtime;
        private Thread thread;
        private bool pooling = true;

        #region Marque Text Declaration
        //int XPos;
        //int YPos;
        #endregion
        
        public struct pcc
        {
            public string pcname;
            public string ipaddress;
            public string macaddress;
            public string state;
            public string description;
            public string location;
            public int delay;
            public int countdown;
        }

        public delegate void ShowMessage(string message);

        public class WOLClass : UdpClient
        {
            public void SetClientToBroadcastMode()
            {
                if (!Active)
                    return;
                Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 0);
            }
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                byte[] bytes;
                do
                {
                    IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, Port);
                    bytes = udpClient.Receive(ref remoteEP);
                }
                while (bytes.Length <= 0);
                Invoke((Delegate)myDelegate, (object)Encoding.ASCII.GetString(bytes));
            }
        }

        private void ShowMessageMethod(string message)
        {
            string str = message.Split(',')[1];
            for (int index = 0; index < totpc; ++index)
            {
                if (pccoll[index].ipaddress == str)
                    pccoll[index].countdown = 10;
            }
        }

        private void WakeFunction(string mac)
        {
            WOLClass wolClass = new WOLClass();
            wolClass.Connect(new IPAddress((long) uint.MaxValue),12287);
            wolClass.SetClientToBroadcastMode();
            int num = 0;
            byte[] dgram = new byte[1024];
            for (int index = 0; index < 6; ++index)
            {
                dgram[num++] = byte.MaxValue;
            }

            for (int index1 = 0; index1 < 16; ++index1)
            {
                int startIndex = 0;
                for (int index2 = 0; index2 < 6; ++index2)
                {
                    dgram[num++] = byte.Parse(mac.Substring(startIndex, 2), NumberStyles.HexNumber);
                    startIndex += 2;
                }
            }
            wolClass.Send(dgram, 1024);
        }
        private void SendUdp(string message, string ipAddr, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress address = IPAddress.Parse(ipAddr);
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            IPEndPoint ipEndPoint = new IPEndPoint(address, port);
            socket.SendTo(bytes, (EndPoint)ipEndPoint);
            socket.Close();
        }

        private void ShutDown(string ipAddress)
        {
            SendUdp("PLEASE@SHUT@DOWN", ipAddress, 12345);
        }

        private void Restart(string ipAddress)
        {
            SendUdp("PLEASE@RESTART@ME", ipAddress, 12345); 
        }

        private void RefreshGrid()
        {
            dgList.Rows.Clear();
                        
            for (int i = 0; i < totpc; ++i)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgList);
                row.Cells[1].Value = false;
                row.Cells[1].Value = pccoll[i].pcname;
                row.Cells[2].Value = pccoll[i].ipaddress;
                row.Cells[3].Value = pccoll[i].macaddress;
                row.Cells[4].Value = pccoll[i].state;
                row.Cells[5].Value = pccoll[i].description;
                dgList.Rows.Add(row);
            }            
        }

        public FrSMServer()
        {
            InitializeComponent();                       
        }

        private void FrSMServer_Load(object sender, EventArgs e)
        {
            StreamReader stream = File.OpenText("config.ini");
            int index = 0;
            while (!stream.EndOfStream)
            {
                string str = stream.ReadLine();
                string[] strArray1 = new string[10];
                string[] strArray2 = str.Split(',');               
                pccoll[index].pcname = strArray2[0];
                pccoll[index].ipaddress = strArray2[1];
                pccoll[index].macaddress = strArray2[2];
                pccoll[index].description = strArray2[3];
                int num = Convert.ToInt32(strArray2[4]);
                pccoll[index].countdown = 0;
                pccoll[index].delay = num;
                if (num > maxtime)
                {
                    maxtime = num;
                }
                ++index;
            }
            totpc = index;
            RefreshGrid();
            myDelegate = new ShowMessage(ShowMessageMethod);
            thread = new Thread(new ThreadStart(ReceiveMessage));
            thread.IsBackground = true;
            udpClient = new UdpClient(Port);
            thread.Start();

            #region Marque Text Initialization
            //XPos = label1.Location.X;
            //YPos = label1.Location.Y;
            #endregion

            #region Transparent All Cells
            //for (int x = 0; x < dgList.Rows.Count; x++)
            //{
            //    for (int y = 0; y < dgList.Rows[x].Cells.Count; y++)
            //    {
            //        dgList.Rows[x].Cells[y].Style.BackColor =
            //        System.Drawing.Color.Transparent;
            //        dgList.Rows[x].Cells[y].Style.ForeColor = Color.White;
            //    }
            //}
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pooling)
                return;
            for (int i = 0; i < totpc; ++i)
            {
                if (pccoll[i].countdown > 0)
                    --pccoll[i].countdown;
                pccoll[i].state = pccoll[i].countdown != 0 ? "ON" : "OFF";
                string str = pccoll[i].state;
                dgList.Rows[i].Cells[4].Value = str;
                if (str == "ON")
                    dgList.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(0,(int)byte.MaxValue, 0);
                if (str == "OFF")
                    dgList.Rows[i].Cells[4].Style.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                SendUdp(str, pccoll[i].ipaddress, 12345);
            }            
        }

        private void btnShutdownAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < totpc; i++)
            {
                ShutDown(pccoll[i].ipaddress);
            }
        }

        private void btnShutdownSelected_Click(object sender, EventArgs e)
        {   
            foreach (DataGridViewRow row in dgList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    ShutDown((string)row.Cells[2].Value);
                }             
            }
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgList.CurrentCell;
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                }
                dgList.EndEdit();
            }
        }

        private void btnRestartAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < totpc; i++)
            {
                Restart(pccoll[i].ipaddress);
            }
        }

        private void btnRestartSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgList.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    Restart((string)row.Cells[2].Value);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            #region Marque Text Timer
            //if (XPos <= 0)
            //{

            //    this.label1.Location = new System.Drawing.Point(this.Width, YPos);
            //    XPos = this.Width;
            //}
            //else
            //{
            //    this.label1.Location = new System.Drawing.Point(XPos, YPos);
            //    XPos -= 2;
            //}
            #endregion
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }        
    }
}
