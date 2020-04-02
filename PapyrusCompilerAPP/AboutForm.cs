using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            AboutRichTextBox.AppendText("说明");
            AboutRichTextBox.AppendText(Environment.NewLine);
            AboutRichTextBox.Select(0,2);
            AboutRichTextBox.SelectionColor = Color.Blue;
            AboutRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            AboutRichTextBox.AppendText("   本工具为轻量的Skyrim游戏脚本编译器，能够简单地编辑和编译脚本。本界面采用了" +
                "CreationKit程序自带的脚本编辑器界面，旨在帮助大家熟悉界面。当然你也可以使用CreationKit程序自带的脚本编辑器编辑脚本，也可使用游戏根目录中的Papyrus Compiler文件夹自带的命令行模式编译脚本。" +
                "无论使用哪一种取决于你的想法。");
            AboutRichTextBox.AppendText(Environment.NewLine);
            int index = AboutRichTextBox.TextLength;
            AboutRichTextBox.AppendText("   警告：本工具仅适用于学习和娱乐，切勿在商业上使用。否则后果自负。");
            AboutRichTextBox.Select(index + 6, 29);
            AboutRichTextBox.SelectionColor = Color.Red;
            AboutRichTextBox.AppendText(Environment.NewLine);
            AboutRichTextBox.SelectionStart = 1;
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
