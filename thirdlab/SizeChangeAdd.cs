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
    public partial class SizeChangeAdd : Form
    {
        public Size returnable;
        string _path;
        public Image Icons;
        Image returnble { 
            set 
            {
                if (Icons.Size.Height != returnable.Height / 20)
                    Icons = value;
            } 
        }
        public SizeChangeAdd()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            int height;
            if (Int32.TryParse(WidthBox.Text, out height))
            {
                returnable = new Size(height, height);
                returnble = Image.FromFile(_path);
                DialogResult = DialogResult.OK;
            }
        }

        private void OpeFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog1.FileName;
                checkBox1.Checked = true;
            }
        }
    }
}
