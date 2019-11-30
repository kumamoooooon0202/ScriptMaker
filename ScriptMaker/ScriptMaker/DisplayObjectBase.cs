using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class DisplayObjectBase
    {
        // 背景として読み込むあるいは対応するファイル名
        public string fileName = "";
        public CommonParam.DisplayMode display_mode = CommonParam.DisplayMode.None;
        public float scroll_speed_x;
        public float scroll_speed_y;
        public float fade_speed;
        public DisplayObjectBase(string filename)
        {
            this.fileName = filename;
        }
    }
}
