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
            this.messagePage = new System.Windows.Forms.TabPage();
            this.namePage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileNameSelectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPage = new System.Windows.Forms.TabPage();
            this.jumpPage = new System.Windows.Forms.TabPage();
            this.selectPage = new System.Windows.Forms.TabPage();
            this.ifPage = new System.Windows.Forms.TabPage();
            this.keywaitPage = new System.Windows.Forms.TabPage();
            this.waiotPage = new System.Windows.Forms.TabPage();
            this.endPage = new System.Windows.Forms.TabPage();
            this.bgPage = new System.Windows.Forms.TabPage();
            this.charactorPage = new System.Windows.Forms.TabPage();
            this.itenPage = new System.Windows.Forms.TabPage();
            this.flagPage = new System.Windows.Forms.TabPage();
            this.bgmPage = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabPage18 = new System.Windows.Forms.TabPage();
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
            this.ScriptTabControl.Controls.Add(this.messagePage);
            this.ScriptTabControl.Controls.Add(this.namePage);
            this.ScriptTabControl.Controls.Add(this.labelPage);
            this.ScriptTabControl.Controls.Add(this.jumpPage);
            this.ScriptTabControl.Controls.Add(this.selectPage);
            this.ScriptTabControl.Controls.Add(this.ifPage);
            this.ScriptTabControl.Controls.Add(this.keywaitPage);
            this.ScriptTabControl.Controls.Add(this.waiotPage);
            this.ScriptTabControl.Controls.Add(this.endPage);
            this.ScriptTabControl.Controls.Add(this.bgPage);
            this.ScriptTabControl.Controls.Add(this.charactorPage);
            this.ScriptTabControl.Controls.Add(this.itenPage);
            this.ScriptTabControl.Controls.Add(this.flagPage);
            this.ScriptTabControl.Controls.Add(this.bgmPage);
            this.ScriptTabControl.Controls.Add(this.tabPage15);
            this.ScriptTabControl.Controls.Add(this.tabPage16);
            this.ScriptTabControl.Controls.Add(this.tabPage17);
            this.ScriptTabControl.Controls.Add(this.tabPage18);
            this.ScriptTabControl.Location = new System.Drawing.Point(396, 130);
            this.ScriptTabControl.Name = "ScriptTabControl";
            this.ScriptTabControl.SelectedIndex = 0;
            this.ScriptTabControl.Size = new System.Drawing.Size(407, 345);
            this.ScriptTabControl.TabIndex = 2;
            // 
            // messagePage
            // 
            this.messagePage.Location = new System.Drawing.Point(4, 22);
            this.messagePage.Name = "messagePage";
            this.messagePage.Padding = new System.Windows.Forms.Padding(3);
            this.messagePage.Size = new System.Drawing.Size(399, 319);
            this.messagePage.TabIndex = 0;
            this.messagePage.Text = "messagepage";
            this.messagePage.UseVisualStyleBackColor = true;
            // 
            // namePage
            // 
            this.namePage.Location = new System.Drawing.Point(4, 22);
            this.namePage.Name = "namePage";
            this.namePage.Padding = new System.Windows.Forms.Padding(3);
            this.namePage.Size = new System.Drawing.Size(399, 319);
            this.namePage.TabIndex = 1;
            this.namePage.Text = "名前";
            this.namePage.UseVisualStyleBackColor = true;
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
            // FileNameSelectButton
            // 
            this.FileNameSelectButton.Location = new System.Drawing.Point(355, 39);
            this.FileNameSelectButton.Name = "FileNameSelectButton";
            this.FileNameSelectButton.Size = new System.Drawing.Size(27, 23);
            this.FileNameSelectButton.TabIndex = 2;
            this.FileNameSelectButton.Text = "...";
            this.FileNameSelectButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 19);
            this.textBox1.TabIndex = 1;
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
            // labelPage
            // 
            this.labelPage.Location = new System.Drawing.Point(4, 22);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(399, 319);
            this.labelPage.TabIndex = 2;
            this.labelPage.Text = "ラベル";
            this.labelPage.UseVisualStyleBackColor = true;
            // 
            // jumpPage
            // 
            this.jumpPage.Location = new System.Drawing.Point(4, 22);
            this.jumpPage.Name = "jumpPage";
            this.jumpPage.Size = new System.Drawing.Size(399, 319);
            this.jumpPage.TabIndex = 3;
            this.jumpPage.Text = "ジャンプ";
            this.jumpPage.UseVisualStyleBackColor = true;
            // 
            // selectPage
            // 
            this.selectPage.Location = new System.Drawing.Point(4, 22);
            this.selectPage.Name = "selectPage";
            this.selectPage.Size = new System.Drawing.Size(399, 319);
            this.selectPage.TabIndex = 4;
            this.selectPage.Text = "選択肢";
            this.selectPage.UseVisualStyleBackColor = true;
            // 
            // ifPage
            // 
            this.ifPage.Location = new System.Drawing.Point(4, 22);
            this.ifPage.Name = "ifPage";
            this.ifPage.Size = new System.Drawing.Size(399, 319);
            this.ifPage.TabIndex = 5;
            this.ifPage.Text = "条件分岐";
            this.ifPage.UseVisualStyleBackColor = true;
            // 
            // keywaitPage
            // 
            this.keywaitPage.Location = new System.Drawing.Point(4, 22);
            this.keywaitPage.Name = "keywaitPage";
            this.keywaitPage.Size = new System.Drawing.Size(399, 319);
            this.keywaitPage.TabIndex = 6;
            this.keywaitPage.Text = "tabPage7";
            this.keywaitPage.UseVisualStyleBackColor = true;
            // 
            // waiotPage
            // 
            this.waiotPage.Location = new System.Drawing.Point(4, 22);
            this.waiotPage.Name = "waiotPage";
            this.waiotPage.Size = new System.Drawing.Size(399, 319);
            this.waiotPage.TabIndex = 7;
            this.waiotPage.Text = "tabPage8";
            this.waiotPage.UseVisualStyleBackColor = true;
            // 
            // endPage
            // 
            this.endPage.Location = new System.Drawing.Point(4, 22);
            this.endPage.Name = "endPage";
            this.endPage.Size = new System.Drawing.Size(399, 319);
            this.endPage.TabIndex = 8;
            this.endPage.Text = "終了";
            this.endPage.UseVisualStyleBackColor = true;
            // 
            // bgPage
            // 
            this.bgPage.Location = new System.Drawing.Point(4, 22);
            this.bgPage.Name = "bgPage";
            this.bgPage.Size = new System.Drawing.Size(399, 319);
            this.bgPage.TabIndex = 9;
            this.bgPage.Text = "背景";
            this.bgPage.UseVisualStyleBackColor = true;
            // 
            // charactorPage
            // 
            this.charactorPage.Location = new System.Drawing.Point(4, 22);
            this.charactorPage.Name = "charactorPage";
            this.charactorPage.Size = new System.Drawing.Size(399, 319);
            this.charactorPage.TabIndex = 10;
            this.charactorPage.Text = "キャラクター";
            this.charactorPage.UseVisualStyleBackColor = true;
            // 
            // itenPage
            // 
            this.itenPage.Location = new System.Drawing.Point(4, 22);
            this.itenPage.Name = "itenPage";
            this.itenPage.Size = new System.Drawing.Size(399, 319);
            this.itenPage.TabIndex = 11;
            this.itenPage.Text = "アイテム";
            this.itenPage.UseVisualStyleBackColor = true;
            // 
            // flagPage
            // 
            this.flagPage.Location = new System.Drawing.Point(4, 22);
            this.flagPage.Name = "flagPage";
            this.flagPage.Size = new System.Drawing.Size(399, 319);
            this.flagPage.TabIndex = 12;
            this.flagPage.Text = "フラグ設定";
            this.flagPage.UseVisualStyleBackColor = true;
            // 
            // bgmPage
            // 
            this.bgmPage.Location = new System.Drawing.Point(4, 22);
            this.bgmPage.Name = "bgmPage";
            this.bgmPage.Size = new System.Drawing.Size(399, 319);
            this.bgmPage.TabIndex = 13;
            this.bgmPage.Text = "BGM";
            this.bgmPage.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(399, 319);
            this.tabPage15.TabIndex = 14;
            this.tabPage15.Text = "tabPage15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(399, 319);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "tabPage16";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(399, 319);
            this.tabPage17.TabIndex = 16;
            this.tabPage17.Text = "tabPage17";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // tabPage18
            // 
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(399, 319);
            this.tabPage18.TabIndex = 17;
            this.tabPage18.Text = "tabPage18";
            this.tabPage18.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage messagePage;
        private System.Windows.Forms.TabPage namePage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FileNameSelectButton;
        private System.Windows.Forms.TabPage labelPage;
        private System.Windows.Forms.TabPage jumpPage;
        private System.Windows.Forms.TabPage selectPage;
        private System.Windows.Forms.TabPage ifPage;
        private System.Windows.Forms.TabPage keywaitPage;
        private System.Windows.Forms.TabPage waiotPage;
        private System.Windows.Forms.TabPage endPage;
        private System.Windows.Forms.TabPage bgPage;
        private System.Windows.Forms.TabPage charactorPage;
        private System.Windows.Forms.TabPage itenPage;
        private System.Windows.Forms.TabPage flagPage;
        private System.Windows.Forms.TabPage bgmPage;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TabPage tabPage18;
    }
}

