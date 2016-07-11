using System;
using System.Windows.Forms;
using SMClient.Properties;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SMClient
{
    public partial class FrSettings : Form
    {
        public FrSettings()
        {
            InitializeComponent();
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.MyIp = txtMyIp.Text;
            Settings.Default.SvrIp = txtServerIp.Text;
            Settings.Default.Save();
            MessageBox.Show("Successfully saved. Relaunch SM Client to take effect", "SM Client", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            Close();
        }

        private void FrSettings_Load(object sender, EventArgs e)
        {
            string ipAdd = GetLocalIPv4(string.IsNullOrEmpty(GetLocalIPv4(NetworkInterfaceType.Ethernet))
                ? NetworkInterfaceType.Wireless80211
                : NetworkInterfaceType.Ethernet);
            txtMyIp.Text = ipAdd;
            txtServerIp.Text = Settings.Default.SvrIp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
