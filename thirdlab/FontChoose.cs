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
    public partial class FontChoose : Form
    {
        public Font FontChoosen;
        public FontChoose()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int a = (int)sizeUpDown.Value;
            if (a == 0)
            {
                MessageBox.Show("Размер должен быть больше нуля");
                DialogResult = DialogResult.No;
            }
            FontChoosen = new Font(fontListBox.Text, (int)sizeUpDown.Value);
            DialogResult = DialogResult.Yes;
        }
    }
}
