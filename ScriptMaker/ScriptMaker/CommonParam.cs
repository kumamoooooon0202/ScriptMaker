using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMaker
{
    class CommonParam
    {
        public enum DisplayMode 
        { 
            None = 0,
            FadeIn,
            FadeOut,
            SclollIn,
            ScrollOut,
            DispOn,
            DispOff,
            Scroll,
            DisplayModeMax
        }        

        public enum FlagCompareType
        {
            Equal = 0,      // =
            NotEqual,       // !=
            Greater,        // >
            GreaterThan,    // >=
            Less,           // <
            LessThan,       // <=
            And,            // &&
            Or,             // ||
            FlagCompareTypeMax
        }

        public enum SoundType
        {
            Play = 0,
            Stop,
            FadeIn,
            FadeOut,
            SoundTypeMax
        }

        public enum SoundLoopType
        {
            Continue = 0,
            Start,
            SoundLoopTypeMax
        }

        static public Dictionary<string, FlagCompareType> FlagCompParams =
            new Dictionary<string, FlagCompareType>()
            {
                {"==", FlagCompareType.Equal        },
                {"!=", FlagCompareType.NotEqual     },
                { ">", FlagCompareType.Greater      },
                {">=", FlagCompareType.GreaterThan  },
                { "<", FlagCompareType.Less         },
                {"<=", FlagCompareType.LessThan     },
                {"$$", FlagCompareType.And          },
                {"||", FlagCompareType.Or           },
            };
    }

}
