using System;
using System.Windows.Forms;

namespace WakeOnLAN
{
    public partial class MainForm : Form
    {
        public MainForm(string macAddress)
        {
            InitializeComponent();
            tbMacAddress.Text = macAddress;
            tbMacAddress.SelectionStart = tbMacAddress.Text.Length;
        }

        private void btnWakeUp_Click(object sender, EventArgs e)
        {
            try
            {
                WakeOnLan.SendMagicPacket(tbMacAddress.Text);
                btnWakeUp.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wake on LAN failed!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
