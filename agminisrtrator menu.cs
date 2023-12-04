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
    public partial class agminisrtrator_menu : Form
    {
        public agminisrtrator_menu()
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

            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
