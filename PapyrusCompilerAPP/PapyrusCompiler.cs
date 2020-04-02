using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    public partial class PapyrusCompiler : Form
    {
        private string filenamewithpath = "未命名";
        private string safefilename = "";
        private string createfilename = "";
        private readonly Encoding EncodeType = Encoding.UTF8;

        public PapyrusCompiler()
        {
            InitializeComponent();
        }

        private void PapyrusCompiler_Load(object sender, EventArgs e)
        {
            this.Text = "Script Edit";
        }

        private void PapyrusCompiler_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PapyrusCompiler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            this.Dispose();
            this.Close();
        }

        private void ExitMenuItemChild_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
                Application.Exit();
            }
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItemChild_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "脚本文件|*.psc|四元组文件|*.pas";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenamewithpath = openFileDialog1.FileName;
                //string ext = filenamewithpath.Substring(filenamewithpath.LastIndexOf(".") + 1);//获取文件格式
                safefilename = openFileDialog1.SafeFileName;
                using (FileStream fs = new FileStream(filenamewithpath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, EncodeType))
                    {
                        PapyrusCompilerTextBox.Text = sr.ReadToEnd();
                        this.Text = "Script Edit - " + safefilename;
                    }
                }
            }
            else
            {
                PapyrusCompilerTextBox.Clear();
                this.Text = "Script Edit";
            }
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveMenuItemChild_Click(object sender, EventArgs e)
        {
            if (this.Text == "Script Edit - 未命名")
            {
                saveFileDialog1.Filter = "脚本文件|*.psc|四元组文件|*.pas";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    createfilename = saveFileDialog1.FileName.ToString();
                    PapyrusCompilerTextBox.SaveFile(createfilename, RichTextBoxStreamType.PlainText);
                    using (FileStream fs = new FileStream(createfilename, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, EncodeType))
                        {
                            PapyrusCompilerTextBox.Text = sr.ReadToEnd();
                            this.Text = "Script Edit - " + createfilename.Substring(createfilename.LastIndexOf("\\") + 1);
                        }
                    }
                    MessageBox.Show("保存成功");
                }
            }
            else
            {
                if (this.Text != "Script Edit")
                {
                    PapyrusCompilerTextBox.SaveFile(filenamewithpath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("保存成功");
                }
            }
        }

        private void PapyrusCompilerTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowLineNo();
            //this.Text = "Script Edit - " + safefilename + "*";
        }

        /// <summary>
        ///  获取文本中(行和列)--光标位置
        /// </summary>
        private void Ranks()
        {
            /*  得到光标行第一个字符的索引，
             *  即从第1个字符开始到光标行的第1个字符索引*/
            int index = PapyrusCompilerTextBox.GetFirstCharIndexOfCurrentLine();
            /*得到光标行的行号,第1行从0开始计算，习惯上我们是从1开始计算，所以+1。 */
            int line = PapyrusCompilerTextBox.GetLineFromCharIndex(index) + 1;
            /*  SelectionStart得到光标所在位置的索引
             *  再减去
             *  当前行第一个字符的索引
             *  = 光标所在的列数(从0开始)  */
            int column = PapyrusCompilerTextBox.SelectionStart - index + 1;
            this.RankStatus.Text = string.Format("当前：{0}行/{1}列，共{2}行", line.ToString(), column.ToString(), PapyrusCompilerTextBox.Lines.Length);
        }

        /// <summary>
        /// 键盘按上、下、左、右键时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PapyrusCompilerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.Ranks();
        }

        /// <summary>
        /// 点击鼠标时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PapyrusCompilerTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ranks();
        }

        /// <summary>
        /// 编译或汇编文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompileMenuItemChild_Click(object sender, EventArgs e)
        {
            Action _ac = delegate () {
                CompilerEngine ce = new CompilerEngine(OutPutTextBox);
                ce.RunCompiler();
            };
            this.Invoke(_ac);
        }

        /// <summary>
        /// 浏览说明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenuItemChild_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0067 // 丢失范围之前释放对象
            AboutForm af = new AboutForm();
#pragma warning restore IDE0067 // 丢失范围之前释放对象
            af.ShowDialog(this);
        }

        /// <summary>
        /// 打开设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParamsMenuItemChild_Click(object sender, EventArgs e)
        {
#pragma warning disable IDE0067 // 丢失范围之前释放对象
            ParamsForm pf = new ParamsForm();
#pragma warning restore IDE0067 // 丢失范围之前释放对象
            pf.ShowDialog(this);
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        private void ShowLineNo()
        {
            //获得当前坐标信息
            Point p = this.PapyrusCompilerTextBox.Location;
            int crntFirstIndex = this.PapyrusCompilerTextBox.GetCharIndexFromPosition(p);
            int crntFirstLine = this.PapyrusCompilerTextBox.GetLineFromCharIndex(crntFirstIndex);
            Point crntFirstPos = this.PapyrusCompilerTextBox.GetPositionFromCharIndex(crntFirstIndex);

            p.Y += this.PapyrusCompilerTextBox.Height;

            int crntLastIndex = this.PapyrusCompilerTextBox.GetCharIndexFromPosition(p);
            int crntLastLine = this.PapyrusCompilerTextBox.GetLineFromCharIndex(crntLastIndex);
            Point crntLastPos = this.PapyrusCompilerTextBox.GetPositionFromCharIndex(crntLastIndex);

            //准备画图
            Graphics g = this.panel1.CreateGraphics();
            Font font = new Font(this.PapyrusCompilerTextBox.Font, this.PapyrusCompilerTextBox.Font.Style);
            SolidBrush brush = new SolidBrush(Color.Green);

            //画图开始
            //刷新画布
            //Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel1.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            brush.Color = Color.White;//重置画笔颜色

            //绘制行号
            int lineSpace = 0;

            if (crntFirstLine != crntLastLine)
            {
                lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            }

            else
            {
                lineSpace = Convert.ToInt32(this.PapyrusCompilerTextBox.Font.Size);
            }

            int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);//惊人的算法啊！！
            for (int i = crntLastLine; i >= crntFirstLine; i--)
            {
                g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }

            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        private void PapyrusCompilerTextBox_VScroll(object sender, EventArgs e)
        {
            ShowLineNo();
        }

        /// <summary>
        /// 新建文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateMenuItemChild_Click(object sender, EventArgs e)
        {
            PapyrusCompilerTextBox.Clear();
            this.Text = "Script Edit - 未命名";
        }

        private void ClearInfoMenuItemChild_Click(object sender, EventArgs e)
        {
            OutPutTextBox.Clear();
        }
    }
}
