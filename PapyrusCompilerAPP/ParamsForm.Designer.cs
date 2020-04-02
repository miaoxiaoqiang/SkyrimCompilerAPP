namespace LightPapyrusCompiler
{
    partial class ParamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TargetType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlagsTextBox = new System.Windows.Forms.TextBox();
            this.SouceSriptTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SoueceScriptButton = new System.Windows.Forms.Button();
            this.OutScriptButton = new System.Windows.Forms.Button();
            this.OutScriptTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ParamsSaveButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SaveProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标类型：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编译参数";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 72);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // TargetType
            // 
            this.TargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetType.FormattingEnabled = true;
            this.TargetType.Items.AddRange(new object[] {
            "文件",
            "文件夹"});
            this.TargetType.Location = new System.Drawing.Point(76, 66);
            this.TargetType.Name = "TargetType";
            this.TargetType.Size = new System.Drawing.Size(63, 20);
            this.TargetType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "源脚本目录：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "标志：";
            // 
            // FlagsTextBox
            // 
            this.FlagsTextBox.Location = new System.Drawing.Point(192, 66);
            this.FlagsTextBox.Name = "FlagsTextBox";
            this.FlagsTextBox.Size = new System.Drawing.Size(148, 21);
            this.FlagsTextBox.TabIndex = 6;
            this.FlagsTextBox.Text = "TESV_Papyrus_Flags.flg";
            // 
            // SouceSriptTextBox
            // 
            this.SouceSriptTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SouceSriptTextBox.Location = new System.Drawing.Point(92, 14);
            this.SouceSriptTextBox.Name = "SouceSriptTextBox";
            this.SouceSriptTextBox.ReadOnly = true;
            this.SouceSriptTextBox.Size = new System.Drawing.Size(229, 21);
            this.SouceSriptTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "编译输出目录：";
            // 
            // SoueceScriptButton
            // 
            this.SoueceScriptButton.Location = new System.Drawing.Point(327, 12);
            this.SoueceScriptButton.Name = "SoueceScriptButton";
            this.SoueceScriptButton.Size = new System.Drawing.Size(75, 23);
            this.SoueceScriptButton.TabIndex = 9;
            this.SoueceScriptButton.Text = "选择";
            this.SoueceScriptButton.UseVisualStyleBackColor = true;
            this.SoueceScriptButton.Click += new System.EventHandler(this.SoueceScriptButton_Click);
            // 
            // OutScriptButton
            // 
            this.OutScriptButton.Location = new System.Drawing.Point(327, 39);
            this.OutScriptButton.Name = "OutScriptButton";
            this.OutScriptButton.Size = new System.Drawing.Size(75, 23);
            this.OutScriptButton.TabIndex = 10;
            this.OutScriptButton.Text = "选择";
            this.OutScriptButton.UseVisualStyleBackColor = true;
            this.OutScriptButton.Click += new System.EventHandler(this.OutScriptButton_Click);
            // 
            // OutScriptTextBox
            // 
            this.OutScriptTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutScriptTextBox.Location = new System.Drawing.Point(101, 41);
            this.OutScriptTextBox.Name = "OutScriptTextBox";
            this.OutScriptTextBox.ReadOnly = true;
            this.OutScriptTextBox.Size = new System.Drawing.Size(217, 21);
            this.OutScriptTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ParamsSaveButton);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.FlagsTextBox);
            this.groupBox2.Controls.Add(this.OutScriptButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OutScriptTextBox);
            this.groupBox2.Controls.Add(this.TargetType);
            this.groupBox2.Controls.Add(this.SoueceScriptButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SouceSriptTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 253);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "psc→pex⇌pas";
            // 
            // ParamsSaveButton
            // 
            this.ParamsSaveButton.Location = new System.Drawing.Point(347, 64);
            this.ParamsSaveButton.Name = "ParamsSaveButton";
            this.ParamsSaveButton.Size = new System.Drawing.Size(55, 23);
            this.ParamsSaveButton.TabIndex = 12;
            this.ParamsSaveButton.Text = "保存";
            this.ParamsSaveButton.UseVisualStyleBackColor = true;
            this.ParamsSaveButton.Click += new System.EventHandler(this.ParamsSaveButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(0, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 64);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "汇编参数";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(396, 44);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SaveProgressBar
            // 
            this.SaveProgressBar.Name = "SaveProgressBar";
            this.SaveProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 279);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamsForm";
            this.Text = "基本参数配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParamsForm_FormClosing);
            this.Load += new System.EventHandler(this.ParamsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TargetType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FlagsTextBox;
        private System.Windows.Forms.TextBox SouceSriptTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SoueceScriptButton;
        private System.Windows.Forms.Button OutScriptButton;
        private System.Windows.Forms.TextBox OutScriptTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ParamsSaveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar SaveProgressBar;
    }
}