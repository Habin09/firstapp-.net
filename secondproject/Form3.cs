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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txt2.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continue Login", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
