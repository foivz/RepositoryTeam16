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

        private void RadniNalog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet1.stavka' table. You can move, or remove it, as needed.
            this.stavkaTableAdapter.Fill(this.t16_DBDataSet1.stavka);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            // TODO: This line of code loads data into the 't16_DBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.t16_DBDataSet.Vozilo);
            // TODO: This line of code loads data into the 't16_DBDataSet.Radni_nalog' table. You can move, or remove it, as needed.
            this.radni_nalogTableAdapter.Fill(this.t16_DBDataSet.Radni_nalog);

            radni_nalogBindingSource.AddNew();


        }

        private void spremi()
        {

            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            spremi();
            radni_nalogBindingSource.AddNew();
        }
    }
}
