using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace StationMachine
{
    public static class HelperLog
    {
        public static void Writelog(string msg)
        {
            StreamWriter stream;
            //写入日志内容
            string path = AppDomain.CurrentDomain.BaseDirectory;
            //检查上传的物理路径是否存在，不存在则创建
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            stream = new StreamWriter(path + "\\log.txt", true, Encoding.Default);
            stream.Write(DateTime.Now.ToString() + ":" + msg);
            stream.Write("\r\n");
            stream.Flush();
            stream.Close();
        }

        /// <summary>
        /// 为当前正在运行的程序创建一个快捷方式。
        /// </summary>
        /// <param name="lnkFilePath">快捷方式的完全限定路径。</param>
        /// <param name="args">快捷方式启动程序时需要使用的参数。</param>
        public static void CreateShortcut(string args = "")
        {
            var shellType = Type.GetTypeFromProgID("WScript.Shell");
            dynamic shell = Activator.CreateInstance(shellType);
            var shortcut = shell.CreateShortcut(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop));
            shortcut.TargetPath = Assembly.GetEntryAssembly().Location;
            shortcut.Arguments = args;
            shortcut.WorkingDirectory = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            shortcut.Save();
        }
    }
}
