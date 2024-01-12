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
    public partial class kayit : Form
    {
        DatabaseConnection conn = new DatabaseConnection();
        public kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Kullanıcılar(TcNo,Sifre,TelNo,IsimSoyisim,Mail,DogumTarihi) VALUES (@TcNo,@Sifre,@TelNo,@IsimSoyisim,@Mail,@DogumTarihi)",conn.Connection());
            cmd.Parameters.AddWithValue("@TcNo",maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@TelNo", maskedTextBox3.Text);
            cmd.Parameters.AddWithValue("@IsimSoyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@Mail", textBox1.Text);
            cmd.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            conn.Connection().Close();
            MessageBox.Show("Kayıt Başarıyla Olundu.");





            giris gr = new giris();
            gr.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris gr = new giris();
            gr.Show();
            this.Hide();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
