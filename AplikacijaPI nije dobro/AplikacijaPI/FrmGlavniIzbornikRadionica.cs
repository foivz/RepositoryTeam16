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
    public partial class FrmGlavniIzbornikRadionica : Form
    {
        public FrmGlavniIzbornikRadionica()
        {
            InitializeComponent();
        }

        private void FrmGlavniIzbornikRadionica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPregledRadnihNaloga pregled = new FrmPregledRadnihNaloga();
            pregled.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
