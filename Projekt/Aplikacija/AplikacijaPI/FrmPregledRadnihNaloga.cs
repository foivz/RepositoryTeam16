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
    public partial class FrmPregledRadnihNaloga : Form
    {
        public FrmPregledRadnihNaloga()
        {
            InitializeComponent();
        }

        private void radni_nalogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.radni_nalogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);

        }

        private void FrmPregledRadnih_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Radni_nalog' table. You can move, or remove it, as needed.
            this.radni_nalogTableAdapter.Fill(this.t16_DBDataSet.Radni_nalog);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }
    }
}
