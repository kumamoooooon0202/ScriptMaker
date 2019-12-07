using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ScriptMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filefToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 最初に実行されるので必要な処理はここで行う
        }

        private void ScriptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageAgreeButton_Click(object sender, EventArgs e)
        {
            // テキストに何も書かれていないか、スペースだけしかない場合は
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text)) { return; }
            // 登録するコマンドパッケージを生成する
            var commandPack = new CommandPack();
            // コマンド名は message とする
            commandPack.command = "message";
            // 保存するデータのクラスを生成する
            var messageModel = new MessageModel();
            // テキストエリアに書かれたテキストを改行で分割する
            messageModel.message = MessageTextBox.Text.Split('\n')
                .Where(m => !string.IsNullOrWhiteSpace(m))
                .ToList();
            commandPack.pack_data = JsonConvert.SerializeObject(messageModel);
            var jsonText = JsonConvert.SerializeObject(commandPack);
            ScriptListBox.Items.Add(jsonText);
        }
    }
}
