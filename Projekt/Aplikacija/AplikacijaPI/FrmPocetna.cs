using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AplikacijaPI
{
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            
            login.Show();
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBoxNaziv_Click(object sender, EventArgs e)
        {

        }

        private void FrmPocetna_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void FrmPocetna_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmPocetna_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FrmPocetna_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmPocetna_KeyDown);
        }
        public void FrmPocetna_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="F1")
            {
                System.Diagnostics.Process.Start(@"KorisnickaDokumentacija.docx");
            }
        }

        
    }
}
