using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_to_Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double Temperature1;
            double Temperature2;
            double Temperature3;
            double Output1;
            double Output2;
            double Output3;

            Temperature1 = Convert.ToInt32(txt8Am.Text);
            Temperature2 = Convert.ToInt32(txt12Pm.Text);
            Temperature3 = Convert.ToInt32(txt5Pm.Text);

            Output1 = (Temperature1 * 1.8 + 32);
            Output2 = (Temperature2 * 1.8 + 32);
            Output3 = (Temperature3 * 1.8 + 32);
            lblOutput8am.Text = "" + Output1;
            lbloutput12pm.Text = "" + Output2;
            lbloutput5pm.Text = "" + Output3;

            if (Output1 > 100)
            {
                lblHotAndCold.Visible = true;
                lblHotAndCold.Text = "That's hot!";
            }
            else if (Output1 < 32)
            {
                lblHotAndCold.Visible = true;
                lblHotAndCold.Text = "Thats Cold";
            }
            if  (Output2 > 100)
            {
                lblHotAndCold2.Visible = true;
                lblHotAndCold2.Text = "That's hot!";
            }
            else if (Output2 < 32)
            {
                lblHotAndCold2.Visible = true;
                lblHotAndCold2.Text = "Thats Cold";
            }
            if (Output3 > 100)
            {
                lblHotAndCold3.Visible = true;
                lblHotAndCold3.Text = "That's hot!";
            }
            else if (Output3 < 32)
            {
                lblHotAndCold3.Visible = true;
                lblHotAndCold3.Text = "Thats Cold";
            }



        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double Temperature1;
            double Temperature2;
            double Temperature3;
            double Output1;
            double Output2;
            double Output3;

            Temperature1 = Convert.ToInt32(txt8Am.Text);
            Temperature2 = Convert.ToInt32(txt12Pm.Text);
            Temperature3 = Convert.ToInt32(txt5Pm.Text);

            Output1 = (Temperature1 - 32) * 1.8;
            Output2 = (Temperature2 - 32) * 1.8;
            Output3 = (Temperature3 - 32) * 1.8;
            lblOutput8am.Text = "" + Output1;
            lbloutput12pm.Text = "" + Output2;
            lbloutput5pm.Text = "" + Output3;

            if (Output1 > 100)
            {
                lblHotAndCold.Visible = true;
                lblHotAndCold.Text = "That's hot!";
            }
            else if (Output1 < 32)
            {
                lblHotAndCold.Visible = true;
                lblHotAndCold.Text = "Thats Cold";
            }
            if (Output2 > 100)
            {
                lblHotAndCold2.Visible = true;
                lblHotAndCold2.Text = "That's hot!";
            }
            else if (Output2 < 32)
            {
                lblHotAndCold2.Visible = true;
                lblHotAndCold2.Text = "Thats Cold";
            }
            if (Output3 > 100)
            {
                lblHotAndCold3.Visible = true;
                lblHotAndCold3.Text = "That's hot!";
            }
            else if (Output3 < 32)
            {
                lblHotAndCold3.Visible = true;
                lblHotAndCold3.Text = "Thats Cold";
            }
        }
    }
}
