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
    public partial class FrmUnosDijelova : Form
    {
     //   private int kataloski_broj;

        public FrmUnosDijelova()
        {
            InitializeComponent();
        }
/*
        public FrmUnosDijelova(int kataloski_broj)
        {
            // TODO: Complete member initialization
          //  this.kataloski_broj = kataloski_broj;
        }
*/
        private void FrmUnosDijelova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't16_DBDataSet.Dijelovi_usluge' table. You can move, or remove it, as needed.
            this.dijelovi_uslugeTableAdapter.Fill(this.t16_DBDataSet.Dijelovi_usluge);
            // TODO: This line of code loads data into the 't16_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.t16_DBDataSet.Korisnik);
            dijelovi_uslugeBindingSource.AddNew();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornikPrijem glavni = new FrmGlavniIzbornikPrijem();
            glavni.Show();
            this.Close();
        }

       

        private void createNewEntry() {

            this.Validate();
            this.dijelovi_uslugeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
           // createNewEntry();
           // int kataloski_broj = (int)t16_DBDataSet.Dijelovi_usluge.Rows[0]["kataloski_broj"];
            //FrmUnosDijelova unos = new FrmUnosDijelova(kataloski_broj);
           // if (Editing) unos.Editing= true;
           // unos.ShowDialog();
        }

        private void spremi() {

            this.Validate();
            this.dijelovi_uslugeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t16_DBDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spremi();
            dijelovi_uslugeBindingSource.AddNew();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


     //   public bool Editing { get; set; }
    }
}