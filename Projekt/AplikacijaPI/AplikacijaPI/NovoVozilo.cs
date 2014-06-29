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
    public partial class NovoVozilo : Form
    {
        public NovoVozilo()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmUnosKorisnikaVozila unos = new FrmUnosKorisnikaVozila();
            unos.Show();
            this.Close();
        }

        private void NovoVozilo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.t16_DBDataSet.Model);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            // TODO: This line of code loads data into the 't16_DBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.t16_DBDataSet.Vozilo);
            voziloBindingSource.AddNew();

        }


        private void spremi()
        {

            this.Validate();
            this.voziloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spremi();
            voziloBindingSource.AddNew();
        }
    }
}
