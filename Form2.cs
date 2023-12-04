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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu regEv = new RunnerMenu();
            regEv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoordinatorMenu regEv = new CoordinatorMenu();
            regEv.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            agminisrtrator_menu regEv = new agminisrtrator_menu();
            regEv.Show();
        }
    }
}
