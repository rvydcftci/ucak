using System;
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
    public partial class giris : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public int sifre;
        public string tc;

        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            biletbul gr = new biletbul();
            gr.Show();
            this.Hide();
            OleDbCommand cmd = new OleDbCommand("Select * From Kullanıcılar",conn.Connection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sifre = Convert.ToInt32(dr["Sifre"]);
                tc = dr["TcNo"].ToString();
            }
            conn.Connection().Close();
            if (maskedTextBox1.Text == tc && maskedTextBox2.Text == sifre.ToString()) {
                MessageBox.Show("Başarılı Giriş");
            } else
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit gr = new kayit();
            gr.Show();
            this.Hide();
        }
    }
}
