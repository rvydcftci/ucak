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

    public partial class biletsec : Form
    {
        public static string nereden;
        public static string nereye;
        public static string tarih;
        public static string saat;
        public static string ucret;

        public biletsec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nereden= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nereye= dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
            tarih= dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
            saat= dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
            ucret= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            koltuksec gr = new koltuksec();
            gr.Show();
            this.Hide();
        }
        DatabaseConnection db = new DatabaseConnection();
        private void biletsec_Load(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand("Select * from UcusBilgiler where Nereden=?", db.Connection());
            cmd.Parameters.AddWithValue("?",biletbul.nereden);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;


            db.Connection().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletbul bilet = new biletbul();
            bilet.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
       

    }
}
