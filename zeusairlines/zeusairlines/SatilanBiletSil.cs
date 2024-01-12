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
    public partial class SatilanBiletSil : Form
    {
        public SatilanBiletSil()
        {
            InitializeComponent();
        }
        DatabaseConnection db = new DatabaseConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from SatılanBilet where BiletNo=?", db.Connection());
            cmd.Parameters.AddWithValue("?", maskedTextBox2.Text);

            cmd.ExecuteNonQuery();
            db.Connection().Close();
            MessageBox.Show("Bilet Başarıyla Silindi!");
            this.Hide();
        }
    }
}
