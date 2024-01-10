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
        int selectedSeat;
        bool koltukSecildiMi=false;

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
        private void SelectSeat()
        {
            switch (selectedSeat)
            {
                case 1:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button3.Enabled = false;
                    }
                    break;
                case 2:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button4.Enabled = false;
                    }
                    break;
                case 3:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button5.Enabled = false;
                    }
                    break;
                case 4:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button6.Enabled = false;
                    }
                    break;
                case 5:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button7.Enabled = false;
                    }
                    break;
                case 6:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button8.Enabled = false;
                    }
                    break;
                case 7:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button9.Enabled = false;
                    }
                    break;
                case 8:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button10.Enabled = false;
                    }
                    break;
                case 9:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button11.Enabled = false;
                    }
                    break;
                case 10:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button12.Enabled = false;
                    }
                    break;
                case 11:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button13.Enabled = false;
                    }
                    break;
                case 12:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button14.Enabled = false;
                    }
                    break;
                case 13:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button15.Enabled = false;
                    }
                    break;
                case 14:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button16.Enabled = false;
                    }
                    break;
                case 15:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button17.Enabled = false;
                    }
                    break;
                case 16:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button18.Enabled = false;
                    }
                    break;
                case 17:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button19.Enabled = false;
                    }
                    break;
                case 18:
                    if (koltukSecildiMi)
                    {
                        SetSeat();
                        button20.Enabled = false;
                    }
                    break;

                    
                default:
                    break;
            }
        }
        private void SetSeat()
        {
            MessageBox.Show("Seçilen Koltuk"+selectedSeat+" iyi uçuşlar dileriz");
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            selectedSeat = 1;
            koltukSecildiMi = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedSeat = 2;
            koltukSecildiMi = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedSeat = 3;
            koltukSecildiMi = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectedSeat = 4;
            koltukSecildiMi = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedSeat = 5;
            koltukSecildiMi = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedSeat = 6;
            koltukSecildiMi = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectedSeat = 7;
            koltukSecildiMi = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedSeat = 8;
            koltukSecildiMi = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectedSeat = 9;
            koltukSecildiMi = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            selectedSeat = 10;
            koltukSecildiMi = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            selectedSeat = 11;
            koltukSecildiMi = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            selectedSeat = 12;
            koltukSecildiMi = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            selectedSeat = 13;
            koltukSecildiMi = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            selectedSeat = 14;
            koltukSecildiMi = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selectedSeat = 15;
            koltukSecildiMi = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selectedSeat = 16;
            koltukSecildiMi = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selectedSeat = 17;
            koltukSecildiMi = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selectedSeat = 18;
            koltukSecildiMi = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectSeat();
        }
    }
}
