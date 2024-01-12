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
    public partial class AdminSil : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public AdminSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("delete * from Admin where TcNo=?", db.Connection());
            cmd.Parameters.AddWithValue("?", maskedTextBox1.Text);
            cmd.ExecuteNonQuery();
            db.Connection().Close();
            MessageBox.Show("Admin Başarıyla Silindi!");
            this.Hide();
        }

        private void AdminSil_Load(object sender, EventArgs e)
        {

        }
    }
}
