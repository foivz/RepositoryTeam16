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
    public partial class FrmUnosDijelova : Form
    {
        public FrmUnosDijelova()
        {
            InitializeComponent();
        }

        private void FrmUnosDijelova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Dijelovi_usluge' table. You can move, or remove it, as needed.
            this.dijelovi_uslugeTableAdapter.Fill(this.t16_DBDataSet.Dijelovi_usluge);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik glavni = new FrmGlavniIzbornik();
            glavni.Show();
            this.Close();
        }
    }
}
