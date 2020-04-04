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
    public delegate void SendData(List<string> files);

    public partial class ListFileForm : Form
    {
        private string sourcescriptfolder = string.Empty;
        private EDncrypt _ed;
        private List<string> _list = new List<string>();
        public event SendData SendMsgEvent;
        public event SendData CompileMsgEvent;
        public SendMsgService _sms;

        public ListFileForm()
        {
            InitializeComponent();
        }

        private void ListFileForm_Load(object sender, EventArgs e)
        {
            if (_sms() != null)
            {
                sourcescriptfolder = _sms().ScriptsFolder;
                Thread t = new Thread(new ParameterizedThreadStart(GetAllFiles));
                t.Start(sourcescriptfolder);
            }
        }

        private void ListFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
            //this.Dispose();
            //this.Close();
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
            SendMsgEvent(new List<string>() { sourcescriptfolder + "\\" + listBox1.SelectedItem.ToString() });
        }

        private void CompileFiles_Click(object sender, EventArgs e)
        {
            List<string> _list = new List<string>();
            foreach (var item in listBox1.SelectedItems)
            {
                _list.Add(item.ToString());
            }
            CompileMsgEvent(_list);
        }
    }
}
