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
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamsMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.PapyrusCompilerTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RankStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PapyrusCompilerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutPutGroupBox = new System.Windows.Forms.GroupBox();
            this.OutPutTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SearchMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PapyrusCompilerPanel.SuspendLayout();
            this.OutPutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.BuildMenuItem,
            this.设置ToolStripMenuItem,
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
            this.CreateMenuItemChild.Size = new System.Drawing.Size(100, 22);
            this.CreateMenuItemChild.Text = "新建";
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
            this.CompileMenuItemChild.Size = new System.Drawing.Size(180, 22);
            this.CompileMenuItemChild.Text = "编译";
            this.CompileMenuItemChild.Click += new System.EventHandler(this.CompileMenuItemChild_Click);
            // 
            // ClearInfoMenuItemChild
            // 
            this.ClearInfoMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("ClearInfoMenuItemChild.Image")));
            this.ClearInfoMenuItemChild.Name = "ClearInfoMenuItemChild";
            this.ClearInfoMenuItemChild.Size = new System.Drawing.Size(180, 22);
            this.ClearInfoMenuItemChild.Text = "清除编译信息";
            this.ClearInfoMenuItemChild.Click += new System.EventHandler(this.ClearInfoMenuItemChild_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParamsMenuItemChild});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // ParamsMenuItemChild
            // 
            this.ParamsMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("ParamsMenuItemChild.Image")));
            this.ParamsMenuItemChild.Name = "ParamsMenuItemChild";
            this.ParamsMenuItemChild.Size = new System.Drawing.Size(124, 22);
            this.ParamsMenuItemChild.Text = "参数设置";
            this.ParamsMenuItemChild.Click += new System.EventHandler(this.ParamsMenuItemChild_Click);
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
            this.PapyrusCompilerTextBox.Location = new System.Drawing.Point(38, 3);
            this.PapyrusCompilerTextBox.Name = "PapyrusCompilerTextBox";
            this.PapyrusCompilerTextBox.Size = new System.Drawing.Size(659, 253);
            this.PapyrusCompilerTextBox.TabIndex = 1;
            this.PapyrusCompilerTextBox.Text = "";
            this.PapyrusCompilerTextBox.VScroll += new System.EventHandler(this.PapyrusCompilerTextBox_VScroll);
            this.PapyrusCompilerTextBox.TextChanged += new System.EventHandler(this.PapyrusCompilerTextBox_TextChanged);
            this.PapyrusCompilerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PapyrusCompilerTextBox_KeyUp);
            this.PapyrusCompilerTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PapyrusCompilerTextBox_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.toolStripStatusLabel2,
            this.RankStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(554, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // RankStatus
            // 
            this.RankStatus.Name = "RankStatus";
            this.RankStatus.Size = new System.Drawing.Size(130, 17);
            this.RankStatus.Text = "当前：1行/1列，共0行";
            // 
            // PapyrusCompilerPanel
            // 
            this.PapyrusCompilerPanel.Controls.Add(this.panel1);
            this.PapyrusCompilerPanel.Controls.Add(this.PapyrusCompilerTextBox);
            this.PapyrusCompilerPanel.Location = new System.Drawing.Point(0, 28);
            this.PapyrusCompilerPanel.Name = "PapyrusCompilerPanel";
            this.PapyrusCompilerPanel.Size = new System.Drawing.Size(699, 259);
            this.PapyrusCompilerPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 253);
            this.panel1.TabIndex = 2;
            // 
            // OutPutGroupBox
            // 
            this.OutPutGroupBox.Controls.Add(this.OutPutTextBox);
            this.OutPutGroupBox.Location = new System.Drawing.Point(0, 293);
            this.OutPutGroupBox.Name = "OutPutGroupBox";
            this.OutPutGroupBox.Size = new System.Drawing.Size(699, 184);
            this.OutPutGroupBox.TabIndex = 4;
            this.OutPutGroupBox.TabStop = false;
            this.OutPutGroupBox.Text = "编译器输出";
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.OutPutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutPutTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.OutPutTextBox.Location = new System.Drawing.Point(3, 17);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.ReadOnly = true;
            this.OutPutTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutPutTextBox.Size = new System.Drawing.Size(693, 164);
            this.OutPutTextBox.TabIndex = 0;
            this.OutPutTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SearchMenuItemChild
            // 
            this.SearchMenuItemChild.Image = ((System.Drawing.Image)(resources.GetObject("SearchMenuItemChild.Image")));
            this.SearchMenuItemChild.Name = "SearchMenuItemChild";
            this.SearchMenuItemChild.Size = new System.Drawing.Size(180, 22);
            this.SearchMenuItemChild.Text = "搜索";
            this.SearchMenuItemChild.Click += new System.EventHandler(this.SearchMenuItemChild_Click);
            // 
            // PapyrusCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 498);
            this.Controls.Add(this.OutPutGroupBox);
            this.Controls.Add(this.PapyrusCompilerPanel);
            this.Controls.Add(this.statusStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PapyrusCompilerPanel.ResumeLayout(false);
            this.OutPutGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel RankStatus;
        private System.Windows.Forms.Panel PapyrusCompilerPanel;
        private System.Windows.Forms.GroupBox OutPutGroupBox;
        private System.Windows.Forms.RichTextBox OutPutTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamsMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItemChild;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem ClearInfoMenuItemChild;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItemChild;
    }
}