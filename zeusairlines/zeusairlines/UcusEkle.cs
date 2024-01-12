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
    public partial class UcusEkle : Form
    {
        public UcusEkle()
        {
            InitializeComponent();
        }
        DatabaseConnection db = new DatabaseConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into UcusBilgiler (Nereden,Nereye,Tarih,KalkisSaati,VarisSaati,Fiyat,UcusNo) values (@Nereden,@Nereye,@Tarih,@KalkisSaati,@VarisSaati,@Fiyat,@UcusNo)", db.Connection());
            cmd.Parameters.AddWithValue("@Nereden", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Nereye", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@Tarih", maskedTextBox4.Text);
            cmd.Parameters.AddWithValue("@KalkisSaati", maskedTextBox3.Text);
            cmd.Parameters.AddWithValue("@VarisSaati", maskedTextBox5.Text);
            cmd.Parameters.AddWithValue("@Fiyat", maskedTextBox6.Text);
            cmd.Parameters.AddWithValue("@UcusNo", maskedTextBox7.Text);

            cmd.ExecuteNonQuery();
            db.Connection().Close();
            MessageBox.Show("Uçuş Başarıyla Eklendi!");
            this.Hide();
        }

        private void UcusEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
