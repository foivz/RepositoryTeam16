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
    public partial class korisnickiPodaci : Form
    {
        public korisnickiPodaci()
        {
            InitializeComponent();
        }

        private void korisnickiPodaci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'T16_DBDataSet1.Korisnik' table. You can move, or remove it, as needed.
            this.KorisnikTableAdapter.Fill(this.T16_DBDataSet1.Korisnik);

            this.reportViewer1.RefreshReport();
            
            
        }
    }
}
