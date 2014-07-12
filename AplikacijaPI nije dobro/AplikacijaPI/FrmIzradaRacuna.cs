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
    public partial class FrmIzradaRacuna : Form
    {
        public FrmIzradaRacuna()
        {
            InitializeComponent();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik glavni = new FrmGlavniIzbornik();
            glavni.Show();
            this.Close();
        }

        private void FrmIzradaRacuna_Load(object sender, EventArgs e)
        {

        }
    }
}
