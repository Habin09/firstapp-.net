using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secondproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            String gender = rdomale.Checked ? rdomale.Text : rdofemale.Text;
            MessageBox.Show(
                $"Full Name :{txtname.Text}\n" +
                $"Gender :{gender}\n" +
                $"Address :{txtaddress.Text}\n" +
                $"Phone Number :{txtphone.Text}\n" +
                $"Email Address :{txtemail.Text}\n" +
                $"Id Number :{txtid.Text}", 
                "Employ Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Question
            );
        }
    }
}
