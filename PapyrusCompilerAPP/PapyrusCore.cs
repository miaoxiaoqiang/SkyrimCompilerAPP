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
    public partial class PapyrusCore : Form
    {
        public PapyrusCore()
        {
            InitializeComponent();
        }

        private void PapyrusCore_Load(object sender, EventArgs e)
        {

        }

        private void PapyrusCore_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PapyrusCore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            this.Dispose();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ShowLineNo();
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            ShowLineNo();
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
            Graphics g = this.panel2.CreateGraphics();
            Font font = new Font(this.PapyrusCompilerTextBox.Font, this.PapyrusCompilerTextBox.Font.Style);
            SolidBrush brush = new SolidBrush(Color.Green);

            //画图开始
            //刷新画布
            //Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel2.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel2.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
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

            int brushX = this.panel2.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
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
    }
}
