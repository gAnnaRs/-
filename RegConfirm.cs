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
    public partial class RegConfirm : Form
    {
        public RegConfirm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerMenu RMenu = new RunnerMenu();
            RMenu.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
