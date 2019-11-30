using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class BGMModel
    {
        // BGM の名前(id)
        public string name = "";
        // BGM の状態
        public CommonParam.SoundType sound_type = CommonParam.SoundType.Play;
        // 同じ BGM をリクエストした時の挙動
        public CommonParam.SoundLoopType loop_type = CommonParam.SoundLoopType.Continue;
    }
}
