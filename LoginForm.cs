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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            logEndTimer.Text = TimeSpan.FromDays(18).ToString();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;

            var timer = new Timer() { Interval = 1000 };

            timer.Tick += (obj, args) =>
                logEndTimer.Text =
                    (TimeSpan.FromDays(18) - (DateTime.Now - startTime))
                    .ToString("dd\\:hh\\:mm");
            timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Owner = this;
            var x = this.Location.X + (this.Width - form2.Width) / 2;
            var y = this.Location.Y + (this.Height - form2.Height) / 2;
            form2.Location = new Point(x, y);
            form2.Show();
        }
    }
}
