namespace LightPapyrusCompiler
{
    partial class PapyrusCompiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PapyrusCompiler));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearInfoMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.PapyrusCompilerTextBox = new System.Windows.Forms.RichTextBox();
            this.PapyrusCompilerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutPutGroupBox = new System.Windows.Forms.GroupBox();
            this.OutPutTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.PapyrusCompilerPanel.SuspendLayout();
            this.OutPutGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.BuildMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItemChild,
            this.OpenFileMenuItemChild,
            this.SaveMenuItemChild,
            this.ExitMenuItemChild});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(44, 21);
            this.FileMenuItem.Text = "文件";
            // 
            // CreateMenuItemChild
            // 
            this.CreateMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("CreateMenuItemChild.Image")));
            this.CreateMenuItemChild.Name = "CreateMenuItemChild";
            this.CreateMenuItemChild.Size = new System.Drawing.Size(180, 22);
            this.CreateMenuItemChild.Text = "新建";
            this.CreateMenuItemChild.Visible = false;
            this.CreateMenuItemChild.Click += new System.EventHandler(this.CreateMenuItemChild_Click);
            // 
            // OpenFileMenuItemChild
            // 
            this.OpenFileMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileMenuItemChild.Image")));
            this.OpenFileMenuItemChild.Name = "OpenFileMenuItemChild";
            this.OpenFileMenuItemChild.Size = new System.Drawing.Size(100, 22);
            this.OpenFileMenuItemChild.Text = "打开";
            this.OpenFileMenuItemChild.Click += new System.EventHandler(this.OpenFileMenuItemChild_Click);
            // 
            // SaveMenuItemChild
            // 
            this.SaveMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenuItemChild.Image")));
            this.SaveMenuItemChild.Name = "SaveMenuItemChild";
            this.SaveMenuItemChild.Size = new System.Drawing.Size(100, 22);
            this.SaveMenuItemChild.Text = "保存";
            this.SaveMenuItemChild.Click += new System.EventHandler(this.SaveMenuItemChild_Click);
            // 
            // ExitMenuItemChild
            // 
            this.ExitMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("ExitMenuItemChild.Image")));
            this.ExitMenuItemChild.Name = "ExitMenuItemChild";
            this.ExitMenuItemChild.Size = new System.Drawing.Size(100, 22);
            this.ExitMenuItemChild.Text = "退出";
            this.ExitMenuItemChild.Click += new System.EventHandler(this.ExitMenuItemChild_Click);
            // 
            // BuildMenuItem
            // 
            this.BuildMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompileMenuItemChild,
            this.ClearInfoMenuItemChild,
            this.SearchMenuItemChild});
            this.BuildMenuItem.Name = "BuildMenuItem";
            this.BuildMenuItem.Size = new System.Drawing.Size(44, 21);
            this.BuildMenuItem.Text = "功能";
            // 
            // CompileMenuItemChild
            // 
            this.CompileMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("CompileMenuItemChild.Image")));
            this.CompileMenuItemChild.Name = "CompileMenuItemChild";
            this.CompileMenuItemChild.Size = new System.Drawing.Size(148, 22);
            this.CompileMenuItemChild.Text = "编译";
            this.CompileMenuItemChild.Click += new System.EventHandler(this.CompileMenuItemChild_Click);
            // 
            // ClearInfoMenuItemChild
            // 
            this.ClearInfoMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("ClearInfoMenuItemChild.Image")));
            this.ClearInfoMenuItemChild.Name = "ClearInfoMenuItemChild";
            this.ClearInfoMenuItemChild.Size = new System.Drawing.Size(148, 22);
            this.ClearInfoMenuItemChild.Text = "清除编译信息";
            this.ClearInfoMenuItemChild.Click += new System.EventHandler(this.ClearInfoMenuItemChild_Click);
            // 
            // SearchMenuItemChild
            // 
            this.SearchMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("SearchMenuItemChild.Image")));
            this.SearchMenuItemChild.Name = "SearchMenuItemChild";
            this.SearchMenuItemChild.Size = new System.Drawing.Size(180, 22);
            this.SearchMenuItemChild.Text = "搜索源码";
            this.SearchMenuItemChild.Click += new System.EventHandler(this.SearchMenuItemChild_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItemChild});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpMenuItem.Text = "帮助";
            // 
            // AboutMenuItemChild
            // 
            this.AboutMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("AboutMenuItemChild.Image")));
            this.AboutMenuItemChild.Name = "AboutMenuItemChild";
            this.AboutMenuItemChild.Size = new System.Drawing.Size(100, 22);
            this.AboutMenuItemChild.Text = "关于";
            this.AboutMenuItemChild.Click += new System.EventHandler(this.AboutMenuItemChild_Click);
            // 
            // PapyrusCompilerTextBox
            // 
            this.PapyrusCompilerTextBox.Location = new System.Drawing.Point(41, 3);
            this.PapyrusCompilerTextBox.Name = "PapyrusCompilerTextBox";
            this.PapyrusCompilerTextBox.Size = new System.Drawing.Size(629, 239);
            this.PapyrusCompilerTextBox.TabIndex = 1;
            this.PapyrusCompilerTextBox.Text = "";
            this.PapyrusCompilerTextBox.VScroll += new System.EventHandler(this.PapyrusCompilerTextBox_VScroll);
            this.PapyrusCompilerTextBox.TextChanged += new System.EventHandler(this.PapyrusCompilerTextBox_TextChanged);
            this.PapyrusCompilerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PapyrusCompilerTextBox_KeyUp);
            this.PapyrusCompilerTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PapyrusCompilerTextBox_MouseUp);
            // 
            // PapyrusCompilerPanel
            // 
            this.PapyrusCompilerPanel.Controls.Add(this.panel1);
            this.PapyrusCompilerPanel.Controls.Add(this.PapyrusCompilerTextBox);
            this.PapyrusCompilerPanel.Location = new System.Drawing.Point(6, 6);
            this.PapyrusCompilerPanel.Name = "PapyrusCompilerPanel";
            this.PapyrusCompilerPanel.Size = new System.Drawing.Size(673, 245);
            this.PapyrusCompilerPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 239);
            this.panel1.TabIndex = 2;
            // 
            // OutPutGroupBox
            // 
            this.OutPutGroupBox.Controls.Add(this.OutPutTextBox);
            this.OutPutGroupBox.Location = new System.Drawing.Point(6, 257);
            this.OutPutGroupBox.Name = "OutPutGroupBox";
            this.OutPutGroupBox.Size = new System.Drawing.Size(673, 178);
            this.OutPutGroupBox.TabIndex = 4;
            this.OutPutGroupBox.TabStop = false;
            this.OutPutGroupBox.Text = "编译输出";
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.OutPutTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.OutPutTextBox.Location = new System.Drawing.Point(6, 17);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.ReadOnly = true;
            this.OutPutTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutPutTextBox.Size = new System.Drawing.Size(664, 155);
            this.OutPutTextBox.TabIndex = 0;
            this.OutPutTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 467);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.PapyrusCompilerPanel);
            this.tabPage1.Controls.Add(this.OutPutGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "编译";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "psc源码目录";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(9, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "pex输出目录";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(6, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(567, 21);
            this.textBox2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "选择";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(6, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(567, 21);
            this.textBox3.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(6, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标志";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(6, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(648, 21);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(6, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(672, 96);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "编译参数";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flowLayoutPanel2);
            this.groupBox6.Location = new System.Drawing.Point(6, 275);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(672, 72);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "反汇编参数";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 66);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(660, 46);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编译指定目录下的所有psc";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(9, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(480, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(582, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "编译";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "保存";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PapyrusCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PapyrusCompiler";
            this.Text = "Skyrim脚本编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PapyrusCompiler_FormClosing);
            this.Load += new System.EventHandler(this.PapyrusCompiler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PapyrusCompilerPanel.ResumeLayout(false);
            this.OutPutGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem BuildMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompileMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItemChild;
        private System.Windows.Forms.RichTextBox PapyrusCompilerTextBox;
        private System.Windows.Forms.Panel PapyrusCompilerPanel;
        private System.Windows.Forms.GroupBox OutPutGroupBox;
        private System.Windows.Forms.RichTextBox OutPutTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItemChild;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItemChild;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}