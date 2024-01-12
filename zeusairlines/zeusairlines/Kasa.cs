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
    public partial class Kasa : Form
    {
        private bool atistirmalikIkram = false;
        private bool icecekIkram = false;
        private bool ekstraYemek = false;
        private int ekstraBagaj=0;
        private int kasa;

        DatabaseConnection db = new DatabaseConnection();
        public Kasa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            koltuksec sec = new koltuksec();
            sec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atistirmalikIkram = true;
            kasa += 100;
            MessageBox.Show("Ekstra Atıştırmalık Eklendi! +100TL");
            button2.Enabled = false;
            textBox6.Text = kasa.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            icecekIkram = true;
            kasa += 100;
            MessageBox.Show("Ekstra İçecek Eklendi! +100TL");
            button3.Enabled = false;
            textBox6.Text = kasa.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ekstraYemek = true;
            kasa += 300;
            MessageBox.Show("Ekstra Yemek Eklendi! +300TL");
            button4.Enabled = false;
            textBox6.Text = kasa.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekstraBagaj += 10;
            kasa += 200;
            MessageBox.Show("Ekstra Bagaj Eklendi! Ekstra Bagaj Hakkınız = "+ekstraBagaj);
            button5.Enabled = false;
            textBox6.Text = kasa.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ekstraBagaj += 30;
            kasa += 500;
            MessageBox.Show("Ekstra Bagaj Eklendi! Ekstra Bagaj Hakkınız = "+ekstraBagaj);
            button6.Enabled = false;
            textBox6.Text = kasa.ToString();
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            kasa = Convert.ToInt32(biletsec.ucret);
            textBox6.Text = kasa.ToString();

            textBox1.Text = biletsec.nereden;
            textBox2.Text = biletsec.nereye;
            textBox3.Text = biletsec.tarih;
            textBox4.Text = biletsec.saat;
            textBox5.Text = biletsec.ucret;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(10000,99999);
            OleDbCommand cmd = new OleDbCommand("insert into SatılanBilet (AdSoyad,Nereden,Nereye,Tarih,Saat,Ucret,EkstraBagaj,AtistirmalikIkram,IcecekIkram,Yemek,BiletNo) values (@AdSoyad,@Nereden,@Nereye,@Tarih,@Saat,@Ucret,@EkstraBagaj,@AtistirmalikIkram,@IcecekIkram,@Yemek,@BiletNo)",db.Connection());
            cmd.Parameters.AddWithValue("@AdSoyad",giris.isimSoyisim);
            cmd.Parameters.AddWithValue("@Nereden", biletsec.nereden);
            cmd.Parameters.AddWithValue("@Nereye", biletsec.nereye);
            cmd.Parameters.AddWithValue("@Tarih", biletsec.tarih);
            cmd.Parameters.AddWithValue("@Saat", biletsec.saat);
            cmd.Parameters.AddWithValue("@Ucret", kasa);
            cmd.Parameters.AddWithValue("@EkstraBagaj", ekstraBagaj);
            cmd.Parameters.AddWithValue("@AtistirmalikIkram", atistirmalikIkram);
            cmd.Parameters.AddWithValue("@IcecekIkram", icecekIkram);
            cmd.Parameters.AddWithValue("@Yemek", ekstraYemek);
            cmd.Parameters.AddWithValue("@BiletNo", random);

            cmd.ExecuteNonQuery();
            db.Connection().Close();
            MessageBox.Show("Ödeme Başarıyla Alındı!");
            giris Giriş = new giris();
            Giriş.Show();
            this.Hide();
        }
    }
}
