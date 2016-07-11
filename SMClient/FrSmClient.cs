using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SMClient.Properties;

namespace SMClient
{
    public partial class FrSmClient : Form
    {
        #region Declaration

        private const int Port = 12345;
        public ShowMessage MyDelegate;
        private UdpClient _udpClient;
        private Thread _thread;

        #endregion

        public FrSmClient()
        {
            InitializeComponent();
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                byte[] bytes;
                do
                {
                    IPEndPoint remoteEp = new IPEndPoint(IPAddress.Any, Port);
                    bytes = _udpClient.Receive(ref remoteEp);
                } while (bytes.Length <= 0);
                this.Invoke((Delegate) this.MyDelegate,
                    (object) Encoding.ASCII.GetString(bytes));
            }
        }

        private void ShutDownMe()
        {
            Process.Start("shutdown", "/s /f /t 5");
        }

        private void RestartMe()
        {
            Process.Start("shutdown", "/r /f /t 5");
        }

        private void ShowMessageMethod(string message)
        {
            if (message == "PLEASE@SHUT@DOWN")
                ShutDownMe();
            if (message != "PLEASE@RESTART@ME")
                return;
            RestartMe();            
        }

        private void SendUdp(string message, string ipAddress, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress address = IPAddress.Parse(ipAddress);
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            IPEndPoint ipEndPoint = new IPEndPoint(address, port);
            socket.SendTo(bytes, (EndPoint) ipEndPoint);
            socket.Close();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendUdp("$GUE," + Settings.Default.MyIp + ",A*", Settings.Default.SvrIp, 54321);            
        }

        public delegate void ShowMessage(string message);

        private void FrSmClient_Load(object sender, EventArgs e)
        {
            txtMyIp.Text = Settings.Default.MyIp.ToString();
            txtServerIp.Text = Settings.Default.SvrIp.ToString();
            MyDelegate = new ShowMessage(ShowMessageMethod);
            _thread = new Thread(new ThreadStart(ReceiveMessage));
            _thread.IsBackground = true;
            _udpClient = new UdpClient(Port);
            _thread.Start();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            ShutDownMe();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartMe();
        }

        private void FrSmClient_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }        

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrSettings form = new FrSettings();
            form.ShowDialog();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
