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
    public partial class Rad : Form
    {
        public Rad()
        {
            InitializeComponent();
        }

        private void radni_nalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radni_nalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);

        }

        private void Rad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            //this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            // TODO: This line of code loads data into the 't16_DBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.t16_DBDataSet.Vozilo);
            // TODO: This line of code loads data into the 't16_DBDataSet.Radni_nalog' table. You can move, or remove it, as needed.
            this.radni_nalogTableAdapter.Fill(this.t16_DBDataSet.Radni_nalog);

        }
    }
}
