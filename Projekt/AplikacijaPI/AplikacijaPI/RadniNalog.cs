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
    public partial class RadniNalog : Form
    {
        public RadniNalog()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmGlavniIzbornik glavni = new FrmGlavniIzbornik();
            glavni.Show();
            this.Close();
        }
    }
}
