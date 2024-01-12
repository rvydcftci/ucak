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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        DatabaseConnection db = new DatabaseConnection();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Admin")
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                button7.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                OleDbCommand cmd = new OleDbCommand("Select * from Admin", db.Connection());
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;


                db.Connection().Close();
            }
            else if (comboBox1.Text=="Kullanıcılar")
            {

                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button7.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
                OleDbCommand cmd = new OleDbCommand("Select * from Kullanıcılar", db.Connection());
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else if (comboBox1.Text == "Satılan Bilet")
            {

                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button7.Visible = true;
                button6.Visible = false;
                button8.Visible = false;
                OleDbCommand cmd = new OleDbCommand("Select * from SatılanBilet", db.Connection());
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }

            else if (comboBox1.Text == "Uçuş Bilgileri")
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button7.Visible = false;
                button6.Visible = true;
                button8.Visible = true;
                OleDbCommand cmd = new OleDbCommand("Select * from UcusBilgiler", db.Connection());
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEkle ekle = new AdminEkle();
            ekle.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminSil sil = new AdminSil();
            sil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UcusEkle ekle = new UcusEkle();
            ekle.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UcusSil sil = new UcusSil();
            sil.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciSil sil = new KullaniciSil();
            sil.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SatilanBiletSil sil = new SatilanBiletSil();
            sil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenelGiris giris = new GenelGiris();
            giris.Show();
            this.Hide();
        }
    }
}
