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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                //Your insert code here
                string KorIme = comboBox1.Text;
                string lozinka = Convert.ToString(Baza.Instance.DohvatiVrijednost("select lozinka from Korisnik where korisnicko_ime='"+KorIme+"';"));
                string tip = Convert.ToString(Baza.Instance.DohvatiVrijednost("select tip_korisnika from Korisnik where korisnicko_ime='" + KorIme + "';"));
                string loz = Convert.ToString(txtLoz.Text);
            
                if (loz == lozinka && int.Parse(tip)==1)
            {
                FrmGlavniIzbornikPrijem glavniIzbornik = new FrmGlavniIzbornikPrijem();

                glavniIzbornik.Show();
            }

            else if (loz == lozinka && int.Parse(tip) == 2)
            {
                FrmGlavniIzbornikRadionica glavniIzbornik = new FrmGlavniIzbornikRadionica();

                glavniIzbornik.Show();
            }

            else if (loz == lozinka && int.Parse(tip) == 3)
            {
                FrmGlavniizbornikKlijent glavniIzbornik = new FrmGlavniizbornikKlijent();

                glavniIzbornik.Show();

               
            }

            else {
                MessageBox.Show("Pogresna lozinka pokušajte ponovo!");
            }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
