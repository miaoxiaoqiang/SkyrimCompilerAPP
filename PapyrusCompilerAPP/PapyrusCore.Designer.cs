namespace LightPapyrusCompiler
{
    partial class PapyrusCore
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
            this.TabControlContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutPutTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PapyrusCompilerTextBox = new System.Windows.Forms.RichTextBox();
            this.TabControlContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlContainer
            // 
            this.TabControlContainer.Controls.Add(this.tabPage1);
            this.TabControlContainer.Controls.Add(this.tabPage2);
            this.TabControlContainer.Location = new System.Drawing.Point(3, 2);
            this.TabControlContainer.Name = "TabControlContainer";
            this.TabControlContainer.SelectedIndex = 0;
            this.TabControlContainer.Size = new System.Drawing.Size(682, 441);
            this.TabControlContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "编译";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutPutTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编译输出";
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
            this.OutPutTextBox.Size = new System.Drawing.Size(656, 138);
            this.OutPutTextBox.TabIndex = 0;
            this.OutPutTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PapyrusCompilerTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 242);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 236);
            this.panel2.TabIndex = 0;
            // 
            // PapyrusCompilerTextBox
            // 
            this.PapyrusCompilerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PapyrusCompilerTextBox.Location = new System.Drawing.Point(35, 4);
            this.PapyrusCompilerTextBox.Name = "PapyrusCompilerTextBox";
            this.PapyrusCompilerTextBox.Size = new System.Drawing.Size(625, 235);
            this.PapyrusCompilerTextBox.TabIndex = 1;
            this.PapyrusCompilerTextBox.Text = "";
            this.PapyrusCompilerTextBox.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.PapyrusCompilerTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PapyrusCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PapyrusCore";
            this.Text = "PapyrusCore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PapyrusCore_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PapyrusCore_FormClosed);
            this.Load += new System.EventHandler(this.PapyrusCore_Load);
            this.TabControlContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox OutPutTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox PapyrusCompilerTextBox;
    }
}