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
    public partial class BMI_calculator : Form
    {
        double weight, height, BMI;
        int gender, bmiLocation, arrowLocation;



        public BMI_calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gender = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            height = Double.Parse(textBox1.Text);
            weight = Double.Parse(textBox2.Text);
            
            if (gender == 1)
            {
                pictureBox1.ImageLocation = "../../картинки/man.png";
            }
            else
            {
                pictureBox1.ImageLocation = "../../картинки/woman.png"; ;
            }
            BMI = Math.Round(weight / (Math.Pow(height / 100, 2)), 1);
            if(BMI < 40)
            {
                label9.Text = BMI.ToString();

                bmiLocation = Convert.ToInt32(370 + BMI * 5.625);
                arrowLocation = Convert.ToInt32(380 + BMI * 5.625);

                label9.Location = new Point(bmiLocation, 330);
                label15.Location = new Point(arrowLocation, 350);
            }
            else
            {
                label9.Text = ">40";

                label9.Location = new Point(720, 330);
                label15.Location = new Point(730, 350);
            }

            if (BMI >= 0 && BMI < 16)
            {
                label16.Text = "Недостаточный";
            }
            else if (BMI >= 16 && BMI < 25)
            {
                label16.Text = "Здоровый";
            }
            else if (BMI >= 25 && BMI < 35)
            {
                label16.Text = "Избыточный";
            }
            else label16.Text = "Ожирение";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            onlytest onlytest = new onlytest();
        }
    }
}
