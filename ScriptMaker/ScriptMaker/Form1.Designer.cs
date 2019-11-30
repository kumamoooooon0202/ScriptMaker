namespace ScriptMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScriptListBox = new System.Windows.Forms.ListBox();
            this.ScriptTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FileNameSelectButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.ScriptTabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filefToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filefToolStripMenuItem
            // 
            this.filefToolStripMenuItem.Name = "filefToolStripMenuItem";
            this.filefToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.filefToolStripMenuItem.Text = "ファイル(&F)";
            this.filefToolStripMenuItem.Click += new System.EventHandler(this.filefToolStripMenuItem_Click);
            // 
            // ScriptListBox
            // 
            this.ScriptListBox.FormattingEnabled = true;
            this.ScriptListBox.ItemHeight = 12;
            this.ScriptListBox.Location = new System.Drawing.Point(13, 28);
            this.ScriptListBox.Name = "ScriptListBox";
            this.ScriptListBox.Size = new System.Drawing.Size(377, 448);
            this.ScriptListBox.TabIndex = 1;
            // 
            // ScriptTabControl
            // 
            this.ScriptTabControl.Controls.Add(this.tabPage1);
            this.ScriptTabControl.Controls.Add(this.tabPage2);
            this.ScriptTabControl.Location = new System.Drawing.Point(396, 130);
            this.ScriptTabControl.Name = "ScriptTabControl";
            this.ScriptTabControl.SelectedIndex = 0;
            this.ScriptTabControl.Size = new System.Drawing.Size(407, 345);
            this.ScriptTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileNameSelectButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(400, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "保存ファイル名";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "保存先";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 19);
            this.textBox1.TabIndex = 1;
            // 
            // FileNameSelectButton
            // 
            this.FileNameSelectButton.Location = new System.Drawing.Point(355, 39);
            this.FileNameSelectButton.Name = "FileNameSelectButton";
            this.FileNameSelectButton.Size = new System.Drawing.Size(27, 23);
            this.FileNameSelectButton.TabIndex = 2;
            this.FileNameSelectButton.Text = "...";
            this.FileNameSelectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ScriptTabControl);
            this.Controls.Add(this.ScriptListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ScriptTabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filefToolStripMenuItem;
        private System.Windows.Forms.ListBox ScriptListBox;
        private System.Windows.Forms.TabControl ScriptTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FileNameSelectButton;
    }
}

