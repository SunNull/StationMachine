using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace StationMachine
{
    public partial class MessageForm : Form
    {

        public MessageForm()
        {
            InitializeComponent();
            lbl2.Text = "";
            this.tbx.Focus();
            this.btncancel.Click += Btncancel_Click;
            this.btnok.Click += Btnok_Click;
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;
            this.btnUppass.Click += BtnUppass_Click;
            this.btnupdateurl.Click += Btnupdateurl_Click;
        }

        private void Btnupdateurl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.tbx.Text) && (this.tbx.Text == ConfigurationManager.AppSettings["MainPassWord"].ToString() || this.tbx.Text == ConfigurationManager.AppSettings["ExitPassWord"].ToString()))
            {
                UPPasswordurl upr = new UPPasswordurl();
                upr.IsUpdatePassword = false;
                upr.ShowDialog();
                upr.Dispose();
            }
            else
            {
                lbl2.Text = "请输入正确的授权码!";
                lbl2.ForeColor = Color.Red;
                this.tbx.Text = string.Empty;
                this.tbx.Focus();
            }
        }

        private void BtnUppass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.tbx.Text) && (this.tbx.Text == ConfigurationManager.AppSettings["MainPassWord"].ToString() || this.tbx.Text == ConfigurationManager.AppSettings["ExitPassWord"].ToString()))
            {
                UPPasswordurl upr = new UPPasswordurl();
                upr.IsUpdatePassword = true;
                upr.ShowDialog();
                upr.Dispose();
                this.Close();
            }
            else
            {
                lbl2.Text = "请输入正确的授权码!";
                lbl2.ForeColor = Color.Red;
                this.tbx.Text = string.Empty;
                this.tbx.Focus();
            }
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.tbx.Text) && (this.tbx.Text == ConfigurationManager.AppSettings["MainPassWord"].ToString()|| this.tbx.Text == ConfigurationManager.AppSettings["ExitPassWord"].ToString()))
                {
                    Application.Exit();
                }
                else
                {
                    lbl2.Text = "请输入正确的授权码!";
                    lbl2.ForeColor = Color.Red;
                    this.tbx.Text = string.Empty;
                    this.tbx.Focus();
                }
            }
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.tbx.Text)&&this.tbx.Text=="123456")
            {
                Application.Exit();
            }
            else
            {
                lbl2.Text = "请输入正确的授权码!";
                lbl2.ForeColor = Color.Red;
                this.tbx.Text = string.Empty;
                this.tbx.Focus();
            }
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
