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
    public partial class FrmPregledPopravaka : Form
    {
        public FrmPregledPopravaka()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPocetna poc = new FrmPocetna();
            poc.Show();
        }

        private void FrmPregledPopravaka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.t16_DBDataSet.Vozilo);
            // TODO: This line of code loads data into the 't16_DBDataSet.Radni_nalog' table. You can move, or remove it, as needed.
            this.radni_nalogTableAdapter.Fill(this.t16_DBDataSet.Radni_nalog);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();

            log.Show();
            this.Close();
        }
    }
}
