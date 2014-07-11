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
    public partial class FrmIzradaRadnogNaloga : Form
    {
        public FrmIzradaRadnogNaloga()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik glavni = new FrmGlavniIzbornik();
            glavni.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIzradaRacuna racun = new FrmIzradaRacuna();
            racun.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
