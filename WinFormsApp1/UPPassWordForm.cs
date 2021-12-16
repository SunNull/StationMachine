using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace StationMachine
{
    public partial class UPPassWordForm : Form
    {
        public bool IsFirst = false;
        private string HttpAddress = string.Empty;
        public UPPassWordForm()
        {
            InitializeComponent();
            this.btnSure.Click += BtnSure_Click;
            this.Load += UPPassWordForm_Load;
            this.btnExist.Click += BtnExist_Click;
        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            if (btnExist.Text == "退出")
                Application.Exit();
            else
                this.Close();
        }

        private void UPPassWordForm_Load(object sender, EventArgs e)
        {
            IsFirst = (ConfigurationManager.AppSettings["IsFirst"].ToString() == "true" ? true : false);
            HttpAddress = ConfigurationManager.AppSettings["UrlRelease"].ToString();
            tbxHttpAdress.Text = HttpAddress;
            if (IsFirst)
            {
                tbxOldPassWord.Text = ConfigurationManager.AppSettings["ExitPassWord"].ToString();
                label2.Text = "初始密码";
            }
            else
                btnExist.Text = "取消";
        }

        private void run(Object obj)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }

        private void BtnSure_Click(object sender, EventArgs e)
        {
            if (!UpdatePassWord())
                return;
            if (tbxHttpAdress.Text != HttpAddress)
            {
                Application.ExitThread();
                Thread RestartThread = new Thread(new ParameterizedThreadStart(run));
                //object appName = Application.StartupPath;//获取应用程序路径和名称
                string apppathName = Application.ExecutablePath;//获取应用程序路径和名称
                apppathName = apppathName.Replace(".dll", ".exe");
                Thread.Sleep(100);
                RestartThread.Start(apppathName);
            }
            else
                this.Close();
        }

        private bool UpdatePassWord()
        {
            if (string.IsNullOrWhiteSpace(tbxHttpAdress.Text.Trim()))
            {
                MessageBox.Show("请配置网址！");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(tbxOldPassWord.Text.Trim()) || string.IsNullOrWhiteSpace(tbxNewPassWord.Text))
            {
                MessageBox.Show("密码不可为空！");
                return false;
            }
            else if (tbxOldPassWord.Text.Trim() != ConfigurationManager.AppSettings["ExitPassWord"].ToString())
            {
                MessageBox.Show("旧密码不正确！");
                this.tbxOldPassWord.Text = string.Empty;
                return false;
            }

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["ExitPassWord"].Value = tbxNewPassWord.Text;
            if (tbxHttpAdress.Text != HttpAddress)  //如果网址和已存储的网址不一样，需要更新网址配置
            {
                configuration.AppSettings.Settings["UrlRelease"].Value = tbxHttpAdress.Text;
            }
            if (IsFirst)
                configuration.AppSettings.Settings["IsFirst"].Value = "false";
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return true;
        }
    }
}
