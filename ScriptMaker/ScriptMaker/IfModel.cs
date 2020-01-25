using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class IfModel
    {
        public class CheckFlag
        {
            // 比較するフラグ名
            public string name = "";
            // 比較対象
            public string flag_type;
            // 比較するフラグの数
            public int flagNum = 0;
        }
        // 比較する総フラグ数
        public int flag_count;
        // 比較フラグメント
        public List<CheckFlag> flags = new List<CheckFlag>();
        // フラグ間の比較方法リスト
        public List<string> flagCompare = new List<string>();
        // すべてが真の場合にジャンプする場所
        public Jump jump = null;

    }
}
