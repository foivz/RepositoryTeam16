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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            
            login.Show();
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBoxNaziv_Click(object sender, EventArgs e)
        {

        }
    }
}
