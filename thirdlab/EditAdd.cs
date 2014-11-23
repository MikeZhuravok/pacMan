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
    public partial class EditAdd : Form
    {
        CustomAdduction CA;
        public EditAdd(CustomAdduction a)
        {
            InitializeComponent();
            CA = a;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CA.first = (string)listBox1.SelectedValue;
            CA.second = (string)listBox2.SelectedValue;
            DialogResult = DialogResult.OK;
        }
    }
}
