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
    public delegate void SendData(string files);

    public partial class ListFileForm : Form
    {
        private string sourcescriptfolder = string.Empty;
        private EDncrypt _ed;
        private List<string> _list = new List<string>();
        public event SendData SendMsgEvent;

        public ListFileForm()
        {
            InitializeComponent();
        }

        private void ListFileForm_Load(object sender, EventArgs e)
        {
            _ed = new EDncrypt(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\config.dat", "", null);
            _ed.StartDncrypt();

            if (!string.IsNullOrEmpty(_ed.DeContent))
            {
                //读取配置信息并反序列化
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ParamsModel));
                MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(_ed.DeContent));
                ParamsModel _pm = (ParamsModel)serializer.ReadObject(mStream);
                mStream.Close();
                mStream.Dispose();

                if (!String.IsNullOrEmpty(_pm.ScriptsFolder))
                {
                    sourcescriptfolder = _pm.ScriptsFolder;
                    Thread t = new Thread(new ParameterizedThreadStart(GetAllFiles));
                    t.Start(_pm.ScriptsFolder);
                }
            }
        }

        private void ListFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        public void GetAllFiles(object dirs)
        {
            DirectoryInfo dir = new DirectoryInfo(dirs.ToString());
            FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();
            
            this.Invoke((EventHandler)delegate
            {
                progressBar1.Maximum = fsinfos.Length;
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    if (fsinfo is DirectoryInfo)
                    {
                        //GetAllFiles(fsinfo.FullName);
                    }
                    else
                    {
                        progressBar1.Value++;
                        listBox1.Items.Add(fsinfo.Name.Replace(".psc", ""));
                    }
                }
            });
        }

        private void FreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 0;

            DirectoryInfo dir = new DirectoryInfo(sourcescriptfolder.ToString());
            FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();

            progressBar1.Maximum = fsinfos.Length;
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                if (fsinfo is DirectoryInfo)
                {
                    //GetAllFiles(fsinfo.FullName);
                }
                else
                {
                    progressBar1.Value++;
                    listBox1.Items.Add(fsinfo.Name.Replace(".psc", ""));
                }
            }
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("必须选择一个文件","提示");
                return;
            }
            SendMsgEvent(sourcescriptfolder + "\\" + listBox1.SelectedItem.ToString());
        }

        private void CompileFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
