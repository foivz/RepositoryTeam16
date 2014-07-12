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
    public partial class GlavniIzbornikKlijent : Form
    {
        public GlavniIzbornikKlijent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPregledPopravaka pregled = new FrmPregledPopravaka();
            pregled.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }
    }
}
