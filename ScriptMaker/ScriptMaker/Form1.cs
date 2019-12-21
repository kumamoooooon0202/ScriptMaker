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
        #region 変数エリア
        class SelectObjPack
        {
            public ComboBox comboBox;
            public Label label;
        }
        private int _selectLineCount = 0;
        private List<SelectObjPack> _selectComboBox = new List<SelectObjPack>();

        #endregion



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
            // 何もしない
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text)) { return; }
            // 保存するデータのクラスを生成する
            var messageModel = new MessageModel();
            // テキストエリアに書かれたテキストを改行で分割する
            messageModel.message = MessageTextBox.Text.Split('\n')
                .Where(m => !string.IsNullOrWhiteSpace(m))
                .ToList();
            SetCommandScript("messege", messageModel);
        }

        /// <summary>
        /// 名前の登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameAgreeButton_Click(object sender, EventArgs e)
        {
            SetCommandScript("name", NameTextBox.Text);
        }

        /// <summary>
        /// スクリプトのリストボックスに登録する関数
        /// </summary>
        /// <param name="jsonText">登録するテキスト</param>
        /// <param name="isAdd">追加処理にするかどうかのフラグ</param>
        private void SetScript(string jsonText, bool isAdd = false)
        {
            // 追加の場合単純に登録するだけでOK
            if (isAdd || ScriptListBox.SelectedIndex < 0)
            {
                ScriptListBox.Items.Add(jsonText);
            }
            else
            {
                ScriptListBox.Items.Insert(ScriptListBox.SelectedIndex, jsonText);
            }
        }

        /// <summary>
        /// ラベルの登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelAgreeButton_Click(object sender, EventArgs e)
        {
            // ラベルに何も記載されていなければ何もしない
            if (string.IsNullOrWhiteSpace(LabelTextBox.Text)) { return; }

            // コンボボックスにすでに登録されているなら何もしない
            if (!AddComboBox(JumpComboBox, LabelTextBox.Text)) { return; }

            // コンボボックスにラベルを登録する
            JumpComboBox.Items.Add(LabelTextBox.Text);
            // 選択のコンボボックスに追加
            _selectComboBox.ForEach(s => s.comboBox.Items.Add(LabelTextBox.Text));
            SetCommandScript("label", LabelTextBox.Text);
        }

        /// <summary>
        /// 所定のコンボボックスに文字列を追加する
        /// </summary>
        /// <param name="cb">対象のコンボボックス</param>
        /// <param name="text">登録する文字列</param>
        /// <returns>登録が成功したら true, 失敗したら false</returns>
        private bool AddComboBox(ComboBox cb, string text)
        {
            if (cb.Items.Contains(text))
            {
                // 注意のメッセージボックスを表示して処理を抜ける
                MessageBox.Show("すでに同じラベルがありますが\n別のラベルを設定してください");
                return false;
            }
            return true;
        }


        private void JumpAgreeButton_Click(object sender, EventArgs e)
        {
            // コンボボックスのデータが存在しない場合は何もしない
            if (JumpComboBox.Items.Count == 0) { return; }
            var jumpText = JumpComboBox.Items[JumpComboBox.SelectedIndex].ToString();
            SetCommandScript("jump", jumpText);
        }

        private void SetCommandScript(string commandName, object target)
        {
            // 登録するコマンドパッケージを生成する
            var commandPack = new CommandPack();

            // コマンド名は messege とする
            commandPack.command = commandName;
            commandPack.pack_data = JsonConvert.SerializeObject(target);
            var jsonText = JsonConvert.SerializeObject(commandPack);
            SetScript(jsonText);

        }

        /// <summary>
        /// 選択でのラベル生成
        /// </summary>
        /// <param name="message">もとになるメッセージ</param>
        /// <returns>加工したメッセージ</returns>
        private string SelectLabelConv(string message)
        {
            var labelText = message;
            if (labelText.Count() > 20)
            {
                labelText = labelText.Substring(0, 20) + "....";
            }
            return "「" + message + "」を選択した場合の飛び先";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void SelecTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectText = SelectTextBox.Text.Replace("\r\n", "\n");
            var str = selectText.Split('\n');
            var lineCount = selectText.Count();
            if (_selectLineCount < lineCount)
            {
                _selectLineCount = lineCount;
                var selectPack = new SelectObjPack();
                selectPack.comboBox = new ComboBox();
                selectPack.comboBox.Location = new Point(300, _selectLineCount * 40);
                selectPack.comboBox.Items.AddRange(JumpComboBox.Items.Cast<string>().ToArray());
                selectPack.label = new Label();
                selectPack.label.Location = new Point(20, _selectLineCount * 40);
                selectPack.label.Width = 260;
                selectPack.label.Text = SelectLabelConv(str[_selectLineCount - 1]);
                _selectComboBox.Add(selectPack);
                SelectGroupBox.Controls.Add(selectPack.comboBox);
                SelectGroupBox.Controls.Add(selectPack.label);
            }
            else if (_selectLineCount > lineCount)
            {
                _selectLineCount = lineCount;
                SelectGroupBox.Controls.Remove(_selectComboBox[_selectLineCount].comboBox);
                SelectGroupBox.Controls.Remove(_selectComboBox[_selectLineCount].label);
                _selectComboBox.RemoveAt(_selectLineCount);
                foreach (var i in Enumerable.Range(0, str.Count()))
                {
                    _selectComboBox[i].label.Text = SelectLabelConv(str[i]);
                }
            }
            else
            {
                _selectLineCount = lineCount;
                SelectGroupBox.Controls.Remove(_selectComboBox[_selectLineCount].comboBox);
                SelectGroupBox.Controls.Remove(_selectComboBox[_selectLineCount].label);
                _selectComboBox.RemoveAt(_selectLineCount);
                foreach (var i in Enumerable.Range(0, str.Count()))
                {
                    _selectComboBox[i].label.Text = SelectLabelConv(str[i]);
                }
            }
        }
    }
}
