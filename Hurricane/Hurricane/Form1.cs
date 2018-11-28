using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double speed;
            int Cat1 = 74;
            int Cat2 = 96;
            int Cat3 = 111;
            int Cat4 = 130;
            int Cat5 = 157;
            speed = Convert.ToDouble(txtWindSpeed.Text);

            if (speed < Cat1)
            {
                lblOutPut.Text = "Not a Hurricane";
            }
            else if (speed >= Cat1 && speed < Cat2)
            {
                lblOutPut.Text = "Category 1 Hurricane";
            }
            else if (speed >= Cat2 && speed < Cat3)
            {
                lblOutPut.Text = "Category 2 Hurricane";
            }
            else if (speed >= Cat3 && speed < Cat4)
            {
                lblOutPut.Text = "Category 3 Hurricane";
            }
            else if (speed >= Cat4 && speed < Cat5)
            {
                lblOutPut.Text = "Category 4 Hurricane";
            }
            else if (speed >= Cat5)
            {
                lblOutPut.Text = "Category 5 Hurricane";
            }





        }
    }
}