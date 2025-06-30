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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string gender = rdomale.Checked ? rdomale.Text : rdofemale.Text;
            List<string> selectedSubjects = new List<string>();
            if (chkenglish.Checked) selectedSubjects.Add(chkenglish.Text);
            if (chkmaths.Checked) selectedSubjects.Add(chkmaths.Text);
            if (chktamil.Checked) selectedSubjects.Add(chktamil.Text);
            string subjects = string.Join(", ", selectedSubjects);
            MessageBox.Show(
                $"Admission Number: {txtadmission.Text}\n" +
                $"First Name: {txtname.Text}\n" +
                $"Last Name: {txtlname.Text}\n" +
                $"Subjects: {subjects}\n" +
                $"Grade :{nudgrade.Text}\n" +
                $"Gender: {gender}",
                "Student Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
