using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class SelectModel
    {
        public class SelectMessage
        {
            // 選択肢に表示されるメッセージ
            public string message = "";
            // 選択された場合の飛び先
            public string jump = "";
        }
        // 選択リスト
        public List<SelectMessage> select_message = new List<SelectMessage>();
    }
    
}
