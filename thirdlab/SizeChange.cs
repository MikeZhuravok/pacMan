using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thirdlab
{
    public partial class SizeChange : Form
    {
        public Size returnable;
        public SizeChange()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            returnable = new Size(Int32.Parse(WidthBox.Text), Int32.Parse(HeightBox.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
