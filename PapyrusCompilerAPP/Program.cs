using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!APPFunction.GetDotNetVersion("4.7"))
            {
                MessageBox.Show(".Net Framework版本不能低于4.7", "错误");
                Environment.Exit(Environment.ExitCode);
                //Process.Start(@"_framework4.5.2.exe").WaitForExit(); //一直等待，直到Framework安装完成
                //if (APPFunction.GetDotNetVersion("4.5"))
                //{
                //    Process.Start(@"你的程序.exe");
                //}
            }

            Process[] MyProcesses = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.ModuleName));
            if (MyProcesses.Length > 1)
            {
                MessageBox.Show("当前程序已经运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }

            if (!Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("必须在64位系统下运行", "错误");
                Environment.Exit(Environment.ExitCode);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PapyrusCompiler());
        }
    }
}
