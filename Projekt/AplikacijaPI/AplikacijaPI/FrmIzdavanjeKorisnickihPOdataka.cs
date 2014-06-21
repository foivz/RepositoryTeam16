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
    public partial class FrmIzdavanjeKorisnickihPOdataka : Form
    {
        public FrmIzdavanjeKorisnickihPOdataka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik glavni = new FrmGlavniIzbornik();
            glavni.Show();
            this.Close();
        }
    }
}
