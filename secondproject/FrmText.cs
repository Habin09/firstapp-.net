using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondproject
{
    public partial class FrmText : Form
    {
        public FrmText()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtname.Text, "My information", MessageBoxButtons.OKCancel);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is " + txtname.Text, "my information", MessageBoxButtons.OKCancel);
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
