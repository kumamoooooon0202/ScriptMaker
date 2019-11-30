using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class SEModel
    {
        // SE の名前
        public string name = "";
        // ループ回数(0は無限ループ)
        public int loop_count = 0;
        // 次の SE を鳴らすまでの時間
        public float interval_time = 0;
    }
}
