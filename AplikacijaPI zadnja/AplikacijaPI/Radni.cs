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
    public partial class Radni : Form
    {
        public Radni()
        {
            InitializeComponent();
        }

        private void radni_nalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radni_nalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);

        }

        private void Radni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Dijelovi_usluge' table. You can move, or remove it, as needed.
            this.dijelovi_uslugeTableAdapter.Fill(this.t16_DBDataSet.Dijelovi_usluge);
            // TODO: This line of code loads data into the 't16_DBDataSet.stavka' table. You can move, or remove it, as needed.
            this.stavkaTableAdapter.Fill(this.t16_DBDataSet.stavka);
            // TODO: This line of code loads data into the 't16_DBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.t16_DBDataSet.Vozilo);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            // TODO: This line of code loads data into the 't16_DBDataSet.Radni_nalog' table. You can move, or remove it, as needed.
            this.radni_nalogTableAdapter.Fill(this.t16_DBDataSet.Radni_nalog);

        }

        private void spremi()
        {

            this.Validate();
            this.stavkaBindingSource.EndEdit();
            this.radni_nalogBindingSource.EndEdit();
            this.voziloBindingSource.EndEdit();
            this.korisnikBindingSource.EndEdit();
           // this.korisnikBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornikPrijem glavni = new FrmGlavniIzbornikPrijem();
            glavni.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spremi();
            radni_nalogBindingSource.AddNew();

        }
    }
}
