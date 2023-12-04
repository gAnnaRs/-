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
    public partial class RegisterAsRunner : Form
    {
        public RegisterAsRunner()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel2.Show();
            this.panel1.Hide();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel2.Visible == true)
            {
                panel2.Hide();
                panel1.Show();
            }
            else this.Close();
        }

        private void RegisterAsRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.panel2.Hide();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registerevent regCon = new Registerevent();
            regCon.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if(OPF.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = OPF.FileName;
                pictureBox1.ImageLocation = OPF.FileName;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

            onlytest onlytest = new onlytest();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
