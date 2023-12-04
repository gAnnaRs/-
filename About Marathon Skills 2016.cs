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
    public partial class About_Marathon_Skills_2016 : Form
    {
        public About_Marathon_Skills_2016()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            onlytest onlytest = new onlytest();
            onlytest.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interactive_map map = new Interactive_map();
            map.Show();

        }
    }
}
