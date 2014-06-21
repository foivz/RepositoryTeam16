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
    public partial class FormAžuriranjeRadnihNaloga : Form
    {
        public FormAžuriranjeRadnihNaloga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPregledIzvještaja pregled = new FrmPregledIzvještaja();
            pregled.Show();
        }
    }
}
