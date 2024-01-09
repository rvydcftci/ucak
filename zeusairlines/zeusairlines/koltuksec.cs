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
    public partial class koltuksec : Form
    {
        public koltuksec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            biletsec gr = new biletsec();
            gr.Show();
            this.Hide();
        }
    }
}
