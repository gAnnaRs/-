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
    public partial class RunnerMenu : Form
    {
        public RunnerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunnerMenu_Load(object sender, EventArgs e)
        {

        }

        private void RunnerMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            Registerevent regEv = new Registerevent();
            regEv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            EditRunnerProfile editProfile = new EditRunnerProfile();
            editProfile.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            EditRunnerProfile editProfile = new EditRunnerProfile();
            editProfile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            MyRapeReaults rapeRel = new MyRapeReaults();
            rapeRel.Show();
        }
    }
}
