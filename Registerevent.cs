﻿using System;
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
    public partial class Registerevent : Form
    {
        int money = 0;
        public Registerevent()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            money = 0;
            if (checkBox1.Checked)
            {
                money += 145;
            }
            if (checkBox2.Checked)
            {
                money += 75;
            }
            if (checkBox3.Checked)
            {
                money += 20;
            }
            label11.Text = "$" + money.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            money = 20;
            if (checkBox1.Checked)
            {
                money += 145;
            }
            if (checkBox2.Checked)
            {
                money += 75;
            }
            if (checkBox3.Checked)
            {
                money += 20;
            }
            label11.Text = "$" + money.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            money = 45;
            if (checkBox1.Checked)
            {
                money += 145;
            }
            if (checkBox2.Checked)
            {
                money += 75;
            }
            if (checkBox3.Checked)
            {
                money += 20;
            }
            label11.Text = "$" + money.ToString();
        }

        private void Registerevent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegConfirm regCon = new RegConfirm();
            regCon.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RunnerMenu rMenu = new RunnerMenu();
            rMenu.Show();
            this.Close();
            Form ifrm = Application.OpenForms[0];
            ifrm.Hide();
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
    }
}
