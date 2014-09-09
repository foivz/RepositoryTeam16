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
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label tip_korisnikaLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_telefonaLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label sifra_zaposlenikaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoviKorisnik));
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.korisnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.korisnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            this.tip_korisnikaTextBox = new System.Windows.Forms.TextBox();
            this.imeComboBox = new System.Windows.Forms.ComboBox();
            this.prezimeComboBox = new System.Windows.Forms.ComboBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_telefonaTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            this.radno_mjestoTextBox = new System.Windows.Forms.TextBox();
            this.sifra_zaposlenikaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            oIBLabel = new System.Windows.Forms.Label();
            tip_korisnikaLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(36, 68);
            oIBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(35, 17);
            oIBLabel.TabIndex = 1;
            oIBLabel.Text = "OIB:";
            // 
            // tip_korisnikaLabel
            // 
            tip_korisnikaLabel.AutoSize = true;
            tip_korisnikaLabel.Location = new System.Drawing.Point(36, 124);
            tip_korisnikaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tip_korisnikaLabel.Name = "tip_korisnikaLabel";
            tip_korisnikaLabel.Size = new System.Drawing.Size(87, 17);
            tip_korisnikaLabel.TabIndex = 3;
            tip_korisnikaLabel.Text = "tip korisnika:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(36, 167);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 5;
            imeLabel.Text = "ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(36, 222);
            prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(62, 17);
            prezimeLabel.TabIndex = 7;
            prezimeLabel.Text = "prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(41, 268);
            adresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(56, 17);
            adresaLabel.TabIndex = 9;
            adresaLabel.Text = "adresa:";
            // 
            // broj_telefonaLabel
            // 
            broj_telefonaLabel.AutoSize = true;
            broj_telefonaLabel.Location = new System.Drawing.Point(41, 311);
            broj_telefonaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            broj_telefonaLabel.Name = "broj_telefonaLabel";
            broj_telefonaLabel.Size = new System.Drawing.Size(91, 17);
            broj_telefonaLabel.TabIndex = 11;
            broj_telefonaLabel.Text = "broj telefona:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(36, 351);
            lozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(56, 17);
            lozinkaLabel.TabIndex = 13;
            lozinkaLabel.Text = "lozinka:";
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(36, 406);
            korisnicko_imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(101, 17);
            korisnicko_imeLabel.TabIndex = 15;
            korisnicko_imeLabel.Text = "korisnicko ime:";
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(31, 453);
            radno_mjestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(94, 17);
            radno_mjestoLabel.TabIndex = 17;
            radno_mjestoLabel.Text = "radno mjesto:";
            // 
            // sifra_zaposlenikaLabel
            // 
            sifra_zaposlenikaLabel.AutoSize = true;
            sifra_zaposlenikaLabel.Location = new System.Drawing.Point(31, 500);
            sifra_zaposlenikaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sifra_zaposlenikaLabel.Name = "sifra_zaposlenikaLabel";
            sifra_zaposlenikaLabel.Size = new System.Drawing.Size(118, 17);
            sifra_zaposlenikaLabel.TabIndex = 19;
            sifra_zaposlenikaLabel.Text = "sifra zaposlenika:";
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
            this.korisnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.korisnikBindingNavigator.Size = new System.Drawing.Size(604, 27);
            this.korisnikBindingNavigator.TabIndex = 0;
            this.korisnikBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // korisnikBindingNavigatorSaveItem
            // 
            this.korisnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.korisnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("korisnikBindingNavigatorSaveItem.Image")));
            this.korisnikBindingNavigatorSaveItem.Name = "korisnikBindingNavigatorSaveItem";
            this.korisnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.korisnikBindingNavigatorSaveItem.Text = "Save Data";
            this.korisnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.korisnikBindingNavigatorSaveItem_Click);
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(149, 64);
            this.oIBTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(132, 22);
            this.oIBTextBox.TabIndex = 2;
            // 
            // tip_korisnikaTextBox
            // 
            this.tip_korisnikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "tip_korisnika", true));
            this.tip_korisnikaTextBox.Location = new System.Drawing.Point(149, 121);
            this.tip_korisnikaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tip_korisnikaTextBox.Name = "tip_korisnikaTextBox";
            this.tip_korisnikaTextBox.Size = new System.Drawing.Size(132, 22);
            this.tip_korisnikaTextBox.TabIndex = 4;
            // 
            // imeComboBox
            // 
            this.imeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ime", true));
            this.imeComboBox.FormattingEnabled = true;
            this.imeComboBox.Location = new System.Drawing.Point(149, 164);
            this.imeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeComboBox.Name = "imeComboBox";
            this.imeComboBox.Size = new System.Drawing.Size(160, 24);
            this.imeComboBox.TabIndex = 6;
            // 
            // prezimeComboBox
            // 
            this.prezimeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "prezime", true));
            this.prezimeComboBox.FormattingEnabled = true;
            this.prezimeComboBox.Location = new System.Drawing.Point(149, 218);
            this.prezimeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezimeComboBox.Name = "prezimeComboBox";
            this.prezimeComboBox.Size = new System.Drawing.Size(160, 24);
            this.prezimeComboBox.TabIndex = 8;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(149, 265);
            this.adresaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(132, 22);
            this.adresaTextBox.TabIndex = 10;
            // 
            // broj_telefonaTextBox
            // 
            this.broj_telefonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "broj_telefona", true));
            this.broj_telefonaTextBox.Location = new System.Drawing.Point(149, 308);
            this.broj_telefonaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.broj_telefonaTextBox.Name = "broj_telefonaTextBox";
            this.broj_telefonaTextBox.Size = new System.Drawing.Size(132, 22);
            this.broj_telefonaTextBox.TabIndex = 12;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "lozinka", true));
            this.lozinkaTextBox.Location = new System.Drawing.Point(149, 342);
            this.lozinkaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(132, 22);
            this.lozinkaTextBox.TabIndex = 14;
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "korisnicko_ime", true));
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(153, 402);
            this.korisnicko_imeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(132, 22);
            this.korisnicko_imeTextBox.TabIndex = 16;
            // 
            // radno_mjestoTextBox
            // 
            this.radno_mjestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "radno_mjesto", true));
            this.radno_mjestoTextBox.Location = new System.Drawing.Point(149, 449);
            this.radno_mjestoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radno_mjestoTextBox.Name = "radno_mjestoTextBox";
            this.radno_mjestoTextBox.Size = new System.Drawing.Size(132, 22);
            this.radno_mjestoTextBox.TabIndex = 18;
            // 
            // sifra_zaposlenikaTextBox
            // 
            this.sifra_zaposlenikaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.sifra_zaposlenikaTextBox.Location = new System.Drawing.Point(153, 500);
            this.sifra_zaposlenikaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sifra_zaposlenikaTextBox.Name = "sifra_zaposlenikaTextBox";
            this.sifra_zaposlenikaTextBox.Size = new System.Drawing.Size(132, 22);
            this.sifra_zaposlenikaTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 556);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "Glavni izbornik";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 607);
            this.Controls.Add(this.button3);
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
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeComboBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeComboBox);
            this.Controls.Add(tip_korisnikaLabel);
            this.Controls.Add(this.tip_korisnikaTextBox);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.oIBTextBox);
            this.Controls.Add(this.korisnikBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.Load += new System.EventHandler(this.NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingNavigator)).EndInit();
            this.korisnikBindingNavigator.ResumeLayout(false);
            this.korisnikBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox tip_korisnikaTextBox;
        private System.Windows.Forms.ComboBox imeComboBox;
        private System.Windows.Forms.ComboBox prezimeComboBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_telefonaTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
        private System.Windows.Forms.TextBox radno_mjestoTextBox;
        private System.Windows.Forms.TextBox sifra_zaposlenikaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}