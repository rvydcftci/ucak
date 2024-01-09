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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
