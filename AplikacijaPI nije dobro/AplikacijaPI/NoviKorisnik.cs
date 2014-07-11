﻿using System;
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
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmUnosKorisnikaVozila unos = new FrmUnosKorisnikaVozila();
            unos.Show();
            this.Close();
        }

        private void NoviKorisnik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            korisnikBindingSource.AddNew();
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
            korisnikBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.korisnikBindingSource.RemoveCurrent();
        }




    }
}