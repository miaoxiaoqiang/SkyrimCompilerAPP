using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    public partial class ParamsForm : Form
    {
        private static readonly Dictionary<string, string> _ComplieDict = new Dictionary<string, string>();
        private static readonly Dictionary<string, string> _AssemblerDict = new Dictionary<string, string>();
        private EDncrypt _ed;

        static ParamsForm()
        {
            foreach (string v in Enum.GetNames(typeof(CompilerArguments)))
            {
                _ComplieDict.Add(v, GetDescription<CompilerArguments>((CompilerArguments)Enum.Parse(typeof(CompilerArguments), v)));
            }

            foreach (string v in Enum.GetNames(typeof(AssemblerArguments)))
            {
                _AssemblerDict.Add(v, GetDescription<AssemblerArguments>((AssemblerArguments)Enum.Parse(typeof(AssemblerArguments), v)));
            }
        }

        public ParamsForm()
        {
            InitializeComponent();
            foreach (var item in _ComplieDict)
            {
#pragma warning disable IDE0067 // 丢失范围之前释放对象
                ToolTip ttpSettings = new ToolTip
                {
                    InitialDelay = 200,
                    AutoPopDelay = 10 * 1000,
                    ReshowDelay = 200,
                    ShowAlways = true,
                    IsBalloon = true
                };
#pragma warning restore IDE0067 // 丢失范围之前释放对象
                CheckBox cb = new CheckBox
                {
                    Text = item.Key == "_" ? "-?" : "-" + item.Key,
                    Checked = false,
                    Width = 80
                };
                ttpSettings.SetToolTip(cb, item.Value);
                cb.Location = new Point();
                flowLayoutPanel1.Controls.Add(cb);
            }

            foreach (var item in _AssemblerDict)
            {
#pragma warning disable IDE0067 // 丢失范围之前释放对象
                ToolTip ttpSettings = new ToolTip
                {
                    InitialDelay = 200,
                    AutoPopDelay = 10 * 1000,
                    ReshowDelay = 200,
                    ShowAlways = true,
                    IsBalloon = true
                };
#pragma warning restore IDE0067 // 丢失范围之前释放对象
                CheckBox cb = new CheckBox
                {
                    Text = item.Key == "_" ? "-?" : "-" + item.Key,
                    Checked = false,
                    Width = 50
                };
                ttpSettings.SetToolTip(cb, item.Value);
                flowLayoutPanel2.Controls.Add(cb);
            }

            TargetType.SelectedIndex = 0;
        }

        private void ParamsForm_Load(object sender, EventArgs e)
        {
            _ed = new EDncrypt(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\config.dat", "", SaveProgressBar);
            _ed.StartDncrypt();
            if (!string.IsNullOrEmpty(_ed.DeContent))
            {
                //读取配置信息并反序列化
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ParamsModel));
                MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(_ed.DeContent));
                ParamsModel _pm = (ParamsModel)serializer.ReadObject(mStream);
                mStream.Close();
                mStream.Dispose();

                SouceSriptTextBox.Text = _pm.ScriptsFolder;
                OutScriptTextBox.Text = _pm.OutPutFolder;
                TargetType.SelectedItem = _pm.FileType;
                FlagsTextBox.Text = _pm.Flags;

                if (_pm.ComplieAruments.Count > 0)
                {
                    if (flowLayoutPanel1.HasChildren)
                    {
                        foreach (Control item in flowLayoutPanel1.Controls)
                        {
                            if (item is CheckBox)
                            {
                                CheckBox cb = item as CheckBox;
                                cb.Checked = _pm.ComplieAruments.Where(a=>a.Equals(cb.Text)).Any();
                            }
                        }
                    }
                }
                if (_pm.AssemblyAruments.Count > 0)
                {
                    if (flowLayoutPanel2.HasChildren)
                    {
                        foreach (Control item in flowLayoutPanel2.Controls)
                        {
                            if (item is CheckBox)
                            {
                                CheckBox cb = item as CheckBox;
                                cb.Checked = _pm.AssemblyAruments.Where(a => a.Equals(cb.Text)).Any();
                            }
                        }
                    }
                }
            }
        }

        private static string GetDescription<T>(T enumeration) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            Type type = enumeration.GetType();
            MemberInfo[] memInfo = type.GetMember(enumeration.ToString());
            if (null != memInfo && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (null != attrs && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumeration.ToString();
        }

        private void SoueceScriptButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                SouceSriptTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void OutScriptButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                OutScriptTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ParamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ParamsSaveButton_Click(object sender, EventArgs e)
        {
            ParamsModel pm = new ParamsModel
            {
                Flags = FlagsTextBox.Text,
                ScriptsFolder = SouceSriptTextBox.Text,
                OutPutFolder = OutScriptTextBox.Text,
                FileType = TargetType.Items[TargetType.SelectedIndex].ToString()
            };

            if (flowLayoutPanel1.HasChildren)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = item as CheckBox;
                        if (cb.Checked)
                        {
                            pm.ComplieAruments.Add(cb.Text);
                        }
                    }
                }
            }
            if (flowLayoutPanel2.HasChildren)
            {
                foreach (Control item in flowLayoutPanel2.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox cb = item as CheckBox;
                        if (cb.Checked)
                        {
                            pm.AssemblyAruments.Add(cb.Text);
                        }
                    }
                }
            }

            try
            {
                //序列化对象
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(pm.GetType());
                MemoryStream stream = new MemoryStream();
                serializer.WriteObject(stream, pm);
                byte[] dataBytes = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(dataBytes, 0, (int)stream.Length);
                stream.Close();
                stream.Dispose();
                Action _ac = delegate () {
                    _ed = new EDncrypt(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\config.dat", Encoding.UTF8.GetString(dataBytes), SaveProgressBar);
                    _ed.StartEncrypt();
                };
                this.Invoke(_ac);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
