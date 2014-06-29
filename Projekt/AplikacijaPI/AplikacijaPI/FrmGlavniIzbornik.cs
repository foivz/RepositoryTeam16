using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaPI
{
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmPregledIzvještaja pregledIzvještaja = new FrmPregledIzvještaja();
         //   pregledIzvještaja.MdiParent = this;
            pregledIzvještaja.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmUnosKorisnikaVozila unoskorisnikavozila = new FrmUnosKorisnikaVozila();
        //    unoskorisnikavozila.MdiParent = this;
            unoskorisnikavozila.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RadniNalog izradaradnognaloga = new RadniNalog();
         //   izradaradnognaloga.MdiParent = this;

            izradaradnognaloga.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FrmUnosDijelova unosdijelova = new FrmUnosDijelova();
        //    unosdijelova.MdiParent=this;
            unosdijelova.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
