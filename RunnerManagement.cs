using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RunnerManagement : Form
    {
        public RunnerManagement()
        {
            InitializeComponent();
        }

        private void RunnerManagement_Load(object sender, EventArgs e)
        {
            DataGridViewButtonCell[] buttons = new DataGridViewButtonCell[6];
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView1.Rows.Add();
            }
            for (int i = 0; i < 6; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = i+1.ToString() + "й";
                this.dataGridView1.Rows[i].Cells[1].Value = "runner";
                this.dataGridView1.Rows[i].Cells[2].Value = "run" + i+1.ToString() + "@runner.com";
                this.dataGridView1.Rows[i].Cells[3].Value = "Оплата подтверждена";
                buttons[i] = new DataGridViewButtonCell();
                buttons[i].Value = "edit";
                buttons[i].Tag = i;
                this.dataGridView1.Rows[i].Cells[4].Value = "edit";
                this.dataGridView1.Rows[i].Cells[4] = buttons[i];
            }
            
        }

        private void RunnerManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            onlytest onlytest = new onlytest();
        }
    }
}
