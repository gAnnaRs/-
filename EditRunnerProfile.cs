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
    public partial class EditRunnerProfile : Form
    {
        public EditRunnerProfile()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = OPF.FileName;
                pictureBox1.ImageLocation = OPF.FileName;
            }
        }

        private void EditRunnerProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu runMenu = new RunnerMenu();
            runMenu.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            RunnerMenu runMenu = new RunnerMenu();
            runMenu.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Manage_a_runner runMenu = new Manage_a_runner();
            runMenu.Show(); runMenu.Show();
        }
    }
}
