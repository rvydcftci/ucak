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
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletbul bilet = new biletbul();
            bilet.Show();
            this.Hide();
        }
    }
}
