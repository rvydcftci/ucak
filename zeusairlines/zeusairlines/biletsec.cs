using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zeusairlines
{
    public partial class biletsec : Form
    {
        public biletsec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koltuksec gr = new koltuksec();
            gr.Show();
            this.Hide();
        }

        private void biletsec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zeusairlinesDataSet.UcusBilgiler' table. You can move, or remove it, as needed.
            this.ucusBilgilerTableAdapter.Fill(this.zeusairlinesDataSet.UcusBilgiler);
            // TODO: This line of code loads data into the 'zeusairlinesDataSet1.UcusBilgiler' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'ucusDataSet.UcusBilgiler' table. You can move, or remove it, as needed.
            
            
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
