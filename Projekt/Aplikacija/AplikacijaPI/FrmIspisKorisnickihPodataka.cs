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
    public partial class FrmIspisKorisnickihPodataka : Form
    {
        public FrmIspisKorisnickihPodataka()
        {
            InitializeComponent();
        }

        private void FrmIspisKorisnickihPodataka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet11.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet11.Korisnik);
            // TODO: This line of code loads data into the 't16_DBDataSet1.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet1.Korisnik);

        }




        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.korisnikTableAdapter.FillBy1(this.t16_DBDataSet1.Korisnik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // tu bi trebalo sad nekaj valjda ubaciti ili na neki drugi nacin da se mora odabrati 
            //jedan korisnik i isprintati taj jedan..ak ne tak onda deti izvjesce de su svi korisnici i kvit
        }
    }
}
