using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdlab.ObjMod
{
    [Serializable]
    class Skin
    {
        public CustomLabel Score;
        public CustomAdduction adduct;
        public CustomButton Start, Edit;
        public CustomPanel panel;
        public Skin() { }
    }
}
