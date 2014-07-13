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
    public partial class FrmUnosKorisnikaVozila : Form
    {
        public FrmUnosKorisnikaVozila()
        {
            InitializeComponent();
        }

        private void FrmUnosKorisnikaVozila_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornikPrijem glavni = new FrmGlavniIzbornikPrijem();
            glavni.Show();
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NoviKorisnik novikor = new NoviKorisnik();
            novikor.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NovoVozilo novovoz = new NovoVozilo();
            novovoz.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FrmIzdavanjeKorisnickihPodataka izdavanje = new FrmIzdavanjeKorisnickihPodataka();
            izdavanje.Show();

        }
    }
}
