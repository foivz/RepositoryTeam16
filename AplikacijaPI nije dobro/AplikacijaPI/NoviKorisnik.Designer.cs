namespace AplikacijaPI
{
    partial class NoviKorisnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviKorisnik));
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label tip_korisnikaLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_telefonaLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label sifra_zaposlenikaLabel;
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.korisnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.korisnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.tip_korisnikaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_telefonaTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            this.radno_mjestoTextBox = new System.Windows.Forms.TextBox();
            this.sifra_zaposlenikaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            oIBLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            tip_korisnikaLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            broj_telefonaLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            sifra_zaposlenikaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingNavigator)).BeginInit();
            this.korisnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t16_DBDataSet
            // 
            this.t16_DBDataSet.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dijelovi_uslugeTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.MarkaVozilaTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Radni_nalogTableAdapter = null;
            this.tableAdapterManager.stavkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = null;
            // 
            // korisnikBindingNavigator
            // 
            this.korisnikBindingNavigator.AddNewItem = null;
            this.korisnikBindingNavigator.BindingSource = this.korisnikBindingSource;
            this.korisnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.korisnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.korisnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.korisnikBindingNavigatorSaveItem});
            this.korisnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.korisnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.korisnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.korisnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.korisnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.korisnikBindingNavigator.Name = "korisnikBindingNavigator";
            this.korisnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.korisnikBindingNavigator.Size = new System.Drawing.Size(376, 25);
            this.korisnikBindingNavigator.TabIndex = 0;
            this.korisnikBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // korisnikBindingNavigatorSaveItem
            // 
            this.korisnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.korisnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("korisnikBindingNavigatorSaveItem.Image")));
            this.korisnikBindingNavigatorSaveItem.Name = "korisnikBindingNavigatorSaveItem";
            this.korisnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.korisnikBindingNavigatorSaveItem.Text = "Save Data";
            this.korisnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.korisnikBindingNavigatorSaveItem_Click);
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(21, 47);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 1;
            oIBLabel.Text = "OIB:";
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(131, 47);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(100, 20);
            this.oIBTextBox.TabIndex = 2;
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(21, 90);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(26, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(131, 87);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 4;
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(18, 135);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(46, 13);
            prezimeLabel.TabIndex = 5;
            prezimeLabel.Text = "prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(132, 128);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 6;
            // 
            // tip_korisnikaLabel
            // 
            tip_korisnikaLabel.AutoSize = true;
            tip_korisnikaLabel.Location = new System.Drawing.Point(18, 172);
            tip_korisnikaLabel.Name = "tip_korisnikaLabel";
            tip_korisnikaLabel.Size = new System.Drawing.Size(66, 13);
            tip_korisnikaLabel.TabIndex = 7;
            tip_korisnikaLabel.Text = "tip korisnika:";
            // 
            // tip_korisnikaTextBox
            // 
            this.tip_korisnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "tip_korisnika", true));
            this.tip_korisnikaTextBox.Location = new System.Drawing.Point(131, 165);
            this.tip_korisnikaTextBox.Name = "tip_korisnikaTextBox";
            this.tip_korisnikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tip_korisnikaTextBox.TabIndex = 8;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(18, 211);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(42, 13);
            adresaLabel.TabIndex = 9;
            adresaLabel.Text = "adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(131, 208);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 10;
            // 
            // broj_telefonaLabel
            // 
            broj_telefonaLabel.AutoSize = true;
            broj_telefonaLabel.Location = new System.Drawing.Point(18, 256);
            broj_telefonaLabel.Name = "broj_telefonaLabel";
            broj_telefonaLabel.Size = new System.Drawing.Size(68, 13);
            broj_telefonaLabel.TabIndex = 11;
            broj_telefonaLabel.Text = "broj telefona:";
            // 
            // broj_telefonaTextBox
            // 
            this.broj_telefonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "broj_telefona", true));
            this.broj_telefonaTextBox.Location = new System.Drawing.Point(131, 249);
            this.broj_telefonaTextBox.Name = "broj_telefonaTextBox";
            this.broj_telefonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.broj_telefonaTextBox.TabIndex = 12;
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(18, 296);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(43, 13);
            lozinkaLabel.TabIndex = 13;
            lozinkaLabel.Text = "lozinka:";
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "lozinka", true));
            this.lozinkaTextBox.Location = new System.Drawing.Point(131, 296);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lozinkaTextBox.TabIndex = 14;
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(21, 340);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(77, 13);
            korisnicko_imeLabel.TabIndex = 15;
            korisnicko_imeLabel.Text = "korisnicko ime:";
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "korisnicko_ime", true));
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(132, 337);
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnicko_imeTextBox.TabIndex = 16;
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(21, 376);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(70, 13);
            radno_mjestoLabel.TabIndex = 17;
            radno_mjestoLabel.Text = "radno mjesto:";
            // 
            // radno_mjestoTextBox
            // 
            this.radno_mjestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "radno_mjesto", true));
            this.radno_mjestoTextBox.Location = new System.Drawing.Point(131, 376);
            this.radno_mjestoTextBox.Name = "radno_mjestoTextBox";
            this.radno_mjestoTextBox.Size = new System.Drawing.Size(100, 20);
            this.radno_mjestoTextBox.TabIndex = 18;
            // 
            // sifra_zaposlenikaLabel
            // 
            sifra_zaposlenikaLabel.AutoSize = true;
            sifra_zaposlenikaLabel.Location = new System.Drawing.Point(21, 424);
            sifra_zaposlenikaLabel.Name = "sifra_zaposlenikaLabel";
            sifra_zaposlenikaLabel.Size = new System.Drawing.Size(88, 13);
            sifra_zaposlenikaLabel.TabIndex = 19;
            sifra_zaposlenikaLabel.Text = "sifra zaposlenika:";
            // 
            // sifra_zaposlenikaTextBox
            // 
            this.sifra_zaposlenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.sifra_zaposlenikaTextBox.Location = new System.Drawing.Point(132, 424);
            this.sifra_zaposlenikaTextBox.Name = "sifra_zaposlenikaTextBox";
            this.sifra_zaposlenikaTextBox.Size = new System.Drawing.Size(100, 20);
            this.sifra_zaposlenikaTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Izbriši";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = "Glavni izbornik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplikacijaPI.Properties.Resources.shadowcatcher_skoda3;
            this.pictureBox1.Location = new System.Drawing.Point(4, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 499);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(sifra_zaposlenikaLabel);
            this.Controls.Add(this.sifra_zaposlenikaTextBox);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.radno_mjestoTextBox);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.korisnicko_imeTextBox);
            this.Controls.Add(lozinkaLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(broj_telefonaLabel);
            this.Controls.Add(this.broj_telefonaTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(tip_korisnikaLabel);
            this.Controls.Add(this.tip_korisnikaTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.oIBTextBox);
            this.Controls.Add(this.korisnikBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.Load += new System.EventHandler(this.NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingNavigator)).EndInit();
            this.korisnikBindingNavigator.ResumeLayout(false);
            this.korisnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator korisnikBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton korisnikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox oIBTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox tip_korisnikaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_telefonaTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
        private System.Windows.Forms.TextBox radno_mjestoTextBox;
        private System.Windows.Forms.TextBox sifra_zaposlenikaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}