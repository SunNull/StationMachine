using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace StationMachine
{
    public partial class UPPasswordurl : Form
    {
        public bool IsUpdatePassword = true;
        private string HttpAddress = string.Empty;
        public UPPasswordurl()
        {
            InitializeComponent();
            this.btnSure.Click += BtnSure_Click;
            this.Load += UPPasswordurl_Load;
            this.btnExist.Click += BtnExist_Click;
            this.KeyPreview = true;
            this.KeyDown += UPPasswordurl_KeyDown;
        }

        private void UPPasswordurl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!UpdatePassWord())
                    return;
                if (IsUpdatePassword)
                    this.Close();
                else if (tbxHttpAdress.Text != HttpAddress)
                {
                    Application.ExitThread();
                    Thread RestartThread = new Thread(new ParameterizedThreadStart(run));
                    //object appName = Application.StartupPath;//获取应用程序路径和名称
                    string apppathName = Application.ExecutablePath;//获取应用程序路径和名称
                    apppathName = apppathName.Replace(".dll", ".exe");
                    Thread.Sleep(100);
                    RestartThread.Start(apppathName);
                }
            }
        }

        private void UPPasswordurl_Load(object sender, EventArgs e)
        {
            if(IsUpdatePassword)
            {
                this.label1.Text = "新密码";
                this.tbxHttpAdress.PasswordChar = '*';
            }
            else
            {
                HttpAddress = ConfigurationManager.AppSettings["UrlRelease"].ToString();
                tbxHttpAdress.Text = HttpAddress;
            }
        }

        private void BtnExist_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(IsUpdatePassword)
                this.Close();
            else if (tbxHttpAdress.Text != HttpAddress)
            {
                Application.ExitThread();
                Thread RestartThread = new Thread(new ParameterizedThreadStart(run));
                //object appName = Application.StartupPath;//获取应用程序路径和名称
                string apppathName = Application.ExecutablePath;//获取应用程序路径和名称
                apppathName = apppathName.Replace(".dll", ".exe");
                Thread.Sleep(100);
                RestartThread.Start(apppathName);
            }
        }

        private bool UpdatePassWord()
        {
            if (!IsUpdatePassword&&string.IsNullOrWhiteSpace(tbxHttpAdress.Text.Trim()))
            {
                MessageBox.Show("请配置网址！");
                return false;
            }
            else if(IsUpdatePassword&& string.IsNullOrWhiteSpace(tbxHttpAdress.Text.Trim()))
            {
                MessageBox.Show("新密码不可为空！");
                return false;
            }
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (IsUpdatePassword)
                configuration.AppSettings.Settings["ExitPassWord"].Value = tbxHttpAdress.Text;
            else if (tbxHttpAdress.Text != HttpAddress)  //如果网址和已存储的网址不一样，需要更新网址配置
            {
                configuration.AppSettings.Settings["UrlRelease"].Value = tbxHttpAdress.Text;
            }
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return true;
        }
    }
}
