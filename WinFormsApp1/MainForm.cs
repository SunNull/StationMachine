using CefSharp.WinForms;
using HelperHandler;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace StationMachine
{
    public partial class MainForm : Form
    {
        private KeyboardHookLib _keyBoardHook = null;
        private string url = "";
        public MainForm()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.KeyPreview = true;
            _keyBoardHook = new KeyboardHookLib();
            _keyBoardHook.InstallHook(this.KeyPress);
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _keyBoardHook.UninstallHook();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HelperLog.CreateShortcut("");
            if (ConfigurationManager.AppSettings["IsFirst"].ToString() == "true")
            {
                UPPassWordForm upw = new UPPassWordForm();
                upw.IsFirst = true;
                upw.ShowDialog();
                upw.Dispose();
            }
            url = System.Configuration.ConfigurationManager.AppSettings["UrlRelease"].ToString();
            //url = "http://mes.wxdingyi.com:8390";
            ChromiumWebBrowser webview = new ChromiumWebBrowser(url);
            webview.Dock = DockStyle.Fill;
            this.Controls.Add(webview);

        }

        public void KeyPress(KeyboardHookLib.HookStruct hookStruct, out bool handle)
        {
            handle = false; //预设不拦截任何键

            if (hookStruct.vkCode == 91) // 截获左win(开始菜单键)
            {
                handle = true;
            }

            if (hookStruct.vkCode == 92)// 截获右win
            {
                handle = true;
            }

            //截获Ctrl+Esc
            if (hookStruct.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control)
            {
                handle = true;
            }

            //截获Esc
            if (hookStruct.vkCode == (int)Keys.Escape)
            {
                handle = true;
                MessageForm f = new MessageForm();
                f.ShowDialog();
                f.Dispose();
            }

            //截获alt+f4
            if (hookStruct.vkCode == (int)Keys.F4 && (int)Control.ModifierKeys == (int)Keys.Alt)
            {
                handle = true;
            }

            //截获alt+tab
            if (hookStruct.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Alt)
            {
                handle = true;
            }

            //截获F1
            if (hookStruct.vkCode == (int)Keys.F1)
            {
                handle = true;
            }

            //截获Ctrl+Alt+Delete
            if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Delete)
            {
                handle = true;
            }
            //截获Ctrl+Alt+Delete
            if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Zoom)
            {
                handle = true;
            }
            //如果键A~Z
            //if (hookStruct.vkCode >= (int)Keys.A && hookStruct.vkCode <= (int)Keys.Z)
            //{
            //    //挡掉G键，想要挡掉哪些键就把下面的G换成那个要挡掉的键，同理可以挡多个
            //    if (hookStruct.vkCode == (int)Keys.D)
            //    {
            //        hookStruct.vkCode = (int)Keys.None; //设键为0
            //        handle = true;
            //    }

            //}

        }
    }
}
