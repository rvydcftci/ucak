﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace zeusairlines
{
    public partial class biletbul : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public static string nereden;
        public biletbul()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            nereden = comboBox1.Text;
            biletsec bilet = new biletsec();
            this.Hide();
            bilet.Show();
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris gr = new giris();
            gr.Show();
            this.Hide();
        }

        private void biletbul_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
            else
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
        }
    }
}
