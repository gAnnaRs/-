using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class onlytest : Form
    {
        public onlytest()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BMI_calculator bmi = new BMI_calculator();
            bmi.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            How_long_is_a_marathon about = new How_long_is_a_marathon();
            about.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About_Marathon_Skills_2016 bmi = new About_Marathon_Skills_2016();
            bmi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BMR_calculator bmr = new BMR_calculator(); 
            bmr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyRapeReaults MRR = new MyRapeReaults();
            MRR.Show();
        }
    }
}
