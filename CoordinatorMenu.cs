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
    public partial class CoordinatorMenu : Form
    {
        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
            RunnerManagement runManage = new RunnerManagement();
            runManage.Show();
        }

        private void CoordinatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
