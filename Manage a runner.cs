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
    public partial class Manage_a_runner : Form
    {
        public Manage_a_runner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            certifacate_preview runMenu = new certifacate_preview();
            runMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditRunnerProfile runMenu = new EditRunnerProfile();
            runMenu.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            certifacate_preview runMenu = new certifacate_preview();
            runMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }
    }
}
