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
    public partial class BMR_calculator : Form
    {
        double weight, height, year, gender, BMR;




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            onlytest onlytest = new onlytest();
        }

        public BMR_calculator()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            height = double.Parse(textBox1.Text);
            weight = double.Parse(textBox2.Text);
            year = double.Parse(textBox3.Text);

            BMR = (weight * 13.4) + (4.8 * height) - (5.7 * year);
            string strBMRJ = BMR.ToString();
            label19.Text = strBMRJ;
        }
    }
}
