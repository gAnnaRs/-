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
    public partial class MyRapeReaults : Form
    {
        public MyRapeReaults()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            CoordinatorMenu coordMenu = new CoordinatorMenu();
            coordMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu runMenu = new RunnerMenu();
            runMenu.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyRapeReaults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();        
        }
    }
}
