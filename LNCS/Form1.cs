using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNCS
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = Properties.Resources.disconnected;
            notifyIcon1.Text = "LNCS    未连接";
            statusLabel.Text = "未连接";
            ipLabel.Text = Funtion.GetLocalIP();
            runtimeLabel.Text = Funtion.runtime.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Icon = Funtion.isConnected ? Properties.Resources.connected : Properties.Resources.disconnected;
            notifyIcon1.Text = "LNCS" + (Funtion.isConnected ? "    已连接" : "    未连接");
            Funtion.runtime++; runtimeLabel.Text = Funtion.runtime.ToString();   //这里这么写会溢出的，要找时间重新写一下
        }
    }
}
