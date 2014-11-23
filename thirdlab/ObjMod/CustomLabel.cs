using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdlab.ObjMod
{
    [Serializable]
    public class CustomLabel
    {
        public string Name;
        public Point LeftTop;
        public Font CustomFont;
        public CustomLabel() { }
    }
}
