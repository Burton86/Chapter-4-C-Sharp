using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission
{
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int AdmissionTest;
            double GPA;

            GPA = Convert.ToDouble(txtGPA.Text);
            AdmissionTest = Convert.ToInt32(txtTestScore.Text);

            if (GPA >= 3.0 && AdmissionTest >= 60)
            {
                lblQualfication.Text = "Accept";
            }
            else if (GPA <= 3.0 && AdmissionTest >= 80)
            {
                lblQualfication.Text = "Accept";
            }
            else
            {
                lblQualfication.Text = "Reject";
            }
        }
    }
}
