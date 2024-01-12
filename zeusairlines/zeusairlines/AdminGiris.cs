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
    public partial class AdminGiris : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public int sifre;
        public string tc;
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Admin where TcNo=?", conn.Connection());
            cmd.Parameters.AddWithValue("?", maskedTextBox1.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sifre = Convert.ToInt32(dr["Sifre"]);
                tc = dr["TcNo"].ToString();
                
            }
            conn.Connection().Close();
            if (maskedTextBox1.Text == tc && maskedTextBox2.Text == sifre.ToString())
            {
                MessageBox.Show("Başarılı Giriş");
                AdminPanel panel = new AdminPanel();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenelGiris giris = new GenelGiris();
            giris.Show();
            this.Hide();
        }
    }
}
