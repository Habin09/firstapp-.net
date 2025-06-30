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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continue Login", "Login information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt2.Text);
        }
    }
}
