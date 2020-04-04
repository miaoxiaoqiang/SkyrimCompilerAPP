using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    internal class CompilerEngine
    {
        /// <summary>
        /// 编译器名称
        /// </summary>
        static readonly string PapyrusCompilerName = "PapyrusCompiler.exe";
        /// <summary>
        /// 控制台输出信息
        /// </summary>
        static readonly TextWriter twOut = Console.Out;
        /// <summary>
        /// 控制台错误信息
        /// </summary>
        static readonly TextWriter twError = Console.Error;
        /// <summary>
        /// 所具有的最少参数个数
        /// </summary>
        private static readonly int minimumArgumentCount = 4;
        private RichTextBox richTextBox;
        private ParamsModel _pm;
        private List<string> _files;

        /// <summary>
        /// 初始化 <see cref="CompilerEngine"/> 类的新实例
        /// </summary>
        public CompilerEngine(RichTextBox ctb, ParamsModel paramsModel)
        {
            richTextBox = ctb;
            _pm = paramsModel;
        }

        public CompilerEngine(RichTextBox ctb, ParamsModel paramsModel, List<string> files)
        {
            richTextBox = ctb;
            _pm = paramsModel;
            _files = files;
        }

        /// <summary>
        /// 组合参数
        /// </summary>
        /// <param name="args"></param>
        static string PackageArguments(ParamsModel args)
        {
            StringBuilder sb = new StringBuilder();
            if (args.ComplieAruments.Count > 0)
            {
                foreach (var item in args.ComplieAruments)
                {
                    sb.Append(" " + item + "");
                }
            }

            sb.Append(" -f=\"" + args.Flags + "\"");
            sb.Append(" -i=\"" + args.ScriptsFolder + "\"");
            sb.Append(" -o=\"" + args.OutPutFolder + "\"");

            return sb.ToString();
        }

        /// <summary>
        /// 输出编译信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OutputWriter(object sender, DataReceivedEventArgs args)
        {
            //richTextBox.Clear();
            if (args.Data != null)
            {
                //twOut.WriteLine(args.Data);
                richTextBox.AppendText(args.Data);
                richTextBox.AppendText(Environment.NewLine);
                richTextBox.ScrollToCaret();
            }
        }

        /// <summary>
        /// 输出错误信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void ErrorWriter(object sender, DataReceivedEventArgs args)
        {
            //richTextBox.Clear();
            if (args.Data != null)
            {
                //twError.WriteLine(args.Data);
                richTextBox.AppendText(args.Data);
                richTextBox.AppendText(Environment.NewLine);
                richTextBox.ScrollToCaret();
            }
        }

        /// <summary>
        /// 编译器编译文件
        /// </summary>
        /// <param name="pm">参数实体</param>
        /// <param name="args">编译参数</param>
        internal void RunCompiler(FileTypeEnum fte)
        {
            string PapyrusCompilerEXE = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\" + PapyrusCompilerName;
            if (!File.Exists(PapyrusCompilerEXE))
            {
                richTextBox.Clear();
                richTextBox.AppendText("Papyrus Compiler: ERROR! Unable to find \"" + PapyrusCompilerName + "\" in \"" + PapyrusCompilerEXE.Substring(0, PapyrusCompilerEXE.LastIndexOf("\\") + 1) + "\"!");
                richTextBox.ScrollToCaret();
                return;
            }
            //else if(string.IsNullOrEmpty(_ed.DeContent))
            //{
            //    richTextBox.Clear();
            //    richTextBox.AppendText("Papyrus Compiler: Error! Unable to use compile function because no configuration information was found.");
            //    richTextBox.ScrollToCaret();
            //}
            //else if (args.Length < minimumArgumentCount)
            //{
            //    twError.WriteLine("Papyrus Compiler: ERROR! Expecting at least " + minimumArgumentCount + " arguments, but received only " + args.Length + "!");
            //    return;
            //}
            else
            {
                if (!File.Exists(PapyrusCompilerEXE))
                {
                    twError.WriteLine("Papyrus Compiler: ERROR! Unable to find \"" + PapyrusCompilerName + "\" in \"" + PapyrusCompilerEXE.Substring(0, PapyrusCompilerEXE.LastIndexOf("\\") + 1) + "\"!");
                    return;
                }

                if (fte == FileTypeEnum.File)
                {
                    foreach (var item in _files)
                    {
                        string arguments = " " + item + " " + PackageArguments(_pm);
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = PapyrusCompilerEXE,
                                Arguments = arguments,
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                CreateNoWindow = true
                            }
                        };
                        proc.EnableRaisingEvents = true;
                        proc.OutputDataReceived += new DataReceivedEventHandler(OutputWriter);
                        proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorWriter);
                        proc.Start();
                        proc.BeginOutputReadLine();
                        proc.BeginErrorReadLine();
                        proc.WaitForExit();
                        proc.Close();
                        proc.Dispose();
                    }
                }
                else
                {
                    string arguments = " " + _pm.PscFolder + " " + PackageArguments(_pm);
                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = PapyrusCompilerEXE,
                            Arguments = arguments,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            CreateNoWindow = true
                        }
                    };
                    proc.EnableRaisingEvents = true;
                    proc.OutputDataReceived += new DataReceivedEventHandler(OutputWriter);
                    proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorWriter);
                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();
                    proc.WaitForExit();
                    proc.Close();
                    proc.Dispose();
                }
            }
        }
    }
}
