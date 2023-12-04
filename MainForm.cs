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
    public partial class MainForm : Form
    {      
        public MainForm()
        {
            InitializeComponent();
            endTimer.Text = TimeSpan.FromDays(18).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;

            var timer = new Timer() { Interval = 1000 };

            timer.Tick += (obj, args) =>
                endTimer.Text =
                    (TimeSpan.FromDays(18) - (DateTime.Now - startTime))
                    .ToString("dd\\:hh\\:mm");
            timer.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterAsRunner regRun = new RegisterAsRunner();
            regRun.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onlytest onlytest = new onlytest();
            onlytest.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                RegConfirm regRun = new RegConfirm();
                regRun.Show();
                this.Hide();
            
        }
    }
}
