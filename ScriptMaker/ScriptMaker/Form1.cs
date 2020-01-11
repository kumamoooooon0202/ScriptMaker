using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //foreach (var i in Enumerable.Range(0, 256))
            //{
            //    FlagComboBox.Items.Add("flag" + i.ToString("000"));
            //}
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

        
        /// <summary>
        /// 選択コマンドで文字の変更があった際に呼び出される
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelecTextBox_TextChanged(object sender, EventArgs e)
        {
            // 選択コマンドのテキストに書かれた行数を取得する
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

        /// <summary>
        /// 選択コマンドの「登録」
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAgreeButton_Click(object sender, EventArgs e)
        {
            // 選択テキストの行数取得
            var selectText = SelectTextBox.Text.Replace("\r\n", "\n");
            var str = selectText.Split('\n');
            var lineCount = selectText.Count();
            // 選択のクラスを準備
            var selectModel = new SelectModel();
            // テキスト行数分のJsonコマンドを取得
            foreach (var i in Enumerable.Range(0, lineCount))
            {
                var selectMessage = new SelectModel.SelectMessage();
                selectMessage.message = str[i];
                var cBox = _selectComboBox[i].comboBox;
                selectMessage.jump = cBox.Items[cBox.SelectedIndex].ToString();
                selectModel.select_message.Add(selectMessage);
            }
            // Jsonに変更する
            var jsonText = JsonConvert.SerializeObject(selectModel);
            // 保存
            SetCommandScript("select", jsonText);
        }

        /// <summary>
        /// キー待ち
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyWaitAgreeButton_Click(object sender, EventArgs e)
        {
            var keyWait = new KeyWaitModel();
            var jsonText = JsonConvert.SerializeObject(keyWait);
            // 保存
            SetCommandScript("key_wait", jsonText);
        }

        /// <summary>
        /// 時間待ち
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeWaitAgreeButton_Click(object sender, EventArgs e)
        {
            var waitModel = new WaitModel();
            waitModel.timer = (float)WaitTimeNumericUpDown.Value;
            var jsonText = JsonConvert.SerializeObject(waitModel);
            // 保存
            SetCommandScript("wait_time", jsonText);
        }

        /// <summary>
        /// 終了コマンド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndAgreeButton_Click(object sender, EventArgs e)
        {
            var endModel = new EndModel();
            var jsonText = JsonConvert.SerializeObject(endModel);
            // 保存
            SetCommandScript("end", jsonText);
        }

        /// <summary>
        /// フラグの登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlagAgreeButton_Click(object sender, EventArgs e)
        {
            var flagModel = new FlagModel();
            AgreeFunctionWithComboBox("Flag", FlagComboBox, () =>
            {
                flagModel.name = FlagComboBox.Items[FlagComboBox.SelectedIndex].ToString();
                flagModel.mode = (int)FlagNumericUpDown.Value;
                return JsonConvert.SerializeObject(flagModel);
            });
        }


        private void ScriptLoadFileSelectButton_Click(object sender, EventArgs e)
        {
            if(ScriptLoadOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = ScriptLoadOpenFileDialog.FileName;
                ScriptLoadTextBox.Text = Path.GetFileName(fileName);
            }
        }

        /// <summary>
        /// スクリプトファイルの登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScriptLoadAgreeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScriptLoadTextBox.Text)) return;
            var loadModel = new LoadModel();
            loadModel.load_name = ScriptLoadTextBox.Text;
            var jsonText = JsonConvert.SerializeObject(loadModel);
            // 保存
            SetCommandScript("load_script", jsonText);
        }

        /// <summary>
        /// イベントの登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventAgreeButton_Click(object sender, EventArgs e)
        {
            var eventModel = new EventModel();
            AgreeFunctionWithComboBox("event", EventComboBox, () =>
            {
                eventModel.name = FlagComboBox.Items[FlagComboBox.SelectedIndex].ToString();
                return JsonConvert.SerializeObject(eventModel);
            });
        }

        private void AgreeFunctionWithComboBox(string name, ComboBox cbox, System.Func<string> callback)
        {
            // 登録が一件もない場合なにもしない
            // 何も選択していない場合も何もしない
            if (cbox.Items.Count == 0 || cbox.SelectedIndex < 0) return;
            // 保存
            SetCommandScript(name, callback);
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (!cbox.Items.Contains(SeComboBox.Text))
                    cbox.Items.Add(SeComboBox.Text);
            }
        }

        private void SeAgreeButton_Click(object sender, EventArgs e)
        {
            var seModel = new SEModel();
            AgreeFunctionWithComboBox("se", SeComboBox, () =>
            {
                seModel.name = SeComboBox.Items[SeComboBox.SelectedIndex].ToString();
                return JsonConvert.SerializeObject(seModel);
            });
        }
    }
}
