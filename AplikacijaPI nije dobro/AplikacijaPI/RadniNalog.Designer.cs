namespace AplikacijaPI
{
    partial class RadniNalog
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
            System.Windows.Forms.Label iD_korisnikLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadniNalog));
            System.Windows.Forms.Label popravakLabel;
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.voziloTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.VoziloTableAdapter();
            this.radni_nalogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.radni_nalogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.fKVoziloKorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_korisnikComboBox = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.t16_DBDataSet1 = new AplikacijaPI.T16_DBDataSet();
            this.stavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.stavkaTableAdapter();
            this.popravakListBox = new System.Windows.Forms.ListBox();
            iD_korisnikLabel = new System.Windows.Forms.Label();
            popravakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).BeginInit();
            this.radni_nalogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVoziloKorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_korisnikLabel
            // 
            iD_korisnikLabel.AutoSize = true;
            iD_korisnikLabel.Location = new System.Drawing.Point(18, 438);
            iD_korisnikLabel.Name = "iD_korisnikLabel";
            iD_korisnikLabel.Size = new System.Drawing.Size(60, 13);
            iD_korisnikLabel.TabIndex = 29;
            iD_korisnikLabel.Text = "ID korisnik:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(18, 485);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(35, 13);
            this.lbl9.TabIndex = 17;
            this.lbl9.Text = "Vozilo";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(20, 330);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(37, 13);
            this.lbl6.TabIndex = 14;
            this.lbl6.Text = "Status";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(21, 265);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(32, 13);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Iznos";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(23, 206);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 13);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Datum";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(25, 142);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 13);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "OIB";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(22, 83);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "IDzaposlenika";
            // 
            // radni_nalogBindingSource
            // 
            this.radni_nalogBindingSource.DataMember = "Radni_nalog";
            this.radni_nalogBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // t16_DBDataSet
            // 
            this.t16_DBDataSet.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "ID_korisnika", true));
            this.textBox2.Location = new System.Drawing.Point(171, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "iznos", true));
            this.textBox3.Location = new System.Drawing.Point(171, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ID_korisnik", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.korisnikBindingSource, "ID_korisnik", true));
            this.comboBox1.DataSource = this.korisnikBindingSource;
            this.comboBox1.DisplayMember = "sifra_zaposlenika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "ID_korisnik";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "registracijska_oznaka", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voziloBindingSource, "ID_vozila", true));
            this.comboBox3.DataSource = this.voziloBindingSource;
            this.comboBox3.DisplayMember = "registracijska_oznaka";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(171, 485);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(147, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.ValueMember = "ID_vozila";
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "Vozilo";
            this.voziloBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "status", true));
            this.textBox4.Location = new System.Drawing.Point(171, 324);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 20);
            this.textBox4.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Glavni izbornik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radni_nalogTableAdapter
            // 
            this.radni_nalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dijelovi_uslugeTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.MarkaVozilaTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Radni_nalogTableAdapter = this.radni_nalogTableAdapter;
            this.tableAdapterManager.stavkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = this.voziloTableAdapter;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
            // 
            // radni_nalogBindingNavigator
            // 
            this.radni_nalogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.radni_nalogBindingNavigator.BindingSource = this.radni_nalogBindingSource;
            this.radni_nalogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.radni_nalogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.radni_nalogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.radni_nalogBindingNavigatorSaveItem});
            this.radni_nalogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.radni_nalogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.radni_nalogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.radni_nalogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.radni_nalogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.radni_nalogBindingNavigator.Name = "radni_nalogBindingNavigator";
            this.radni_nalogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.radni_nalogBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.radni_nalogBindingNavigator.TabIndex = 29;
            this.radni_nalogBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // radni_nalogBindingNavigatorSaveItem
            // 
            this.radni_nalogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.radni_nalogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("radni_nalogBindingNavigatorSaveItem.Image")));
            this.radni_nalogBindingNavigatorSaveItem.Name = "radni_nalogBindingNavigatorSaveItem";
            this.radni_nalogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.radni_nalogBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // fKVoziloKorisnikBindingSource
            // 
            this.fKVoziloKorisnikBindingSource.DataMember = "FK_Vozilo_Korisnik";
            this.fKVoziloKorisnikBindingSource.DataSource = this.korisnikBindingSource;
            // 
            // iD_korisnikComboBox
            // 
            this.iD_korisnikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ID_korisnik", true));
            this.iD_korisnikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.korisnikBindingSource, "ID_korisnik", true));
            this.iD_korisnikComboBox.DataSource = this.korisnikBindingSource1;
            this.iD_korisnikComboBox.DisplayMember = "ime";
            this.iD_korisnikComboBox.FormattingEnabled = true;
            this.iD_korisnikComboBox.Location = new System.Drawing.Point(171, 438);
            this.iD_korisnikComboBox.Name = "iD_korisnikComboBox";
            this.iD_korisnikComboBox.Size = new System.Drawing.Size(147, 21);
            this.iD_korisnikComboBox.TabIndex = 30;
            this.iD_korisnikComboBox.ValueMember = "ID_korisnik";
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "Korisnik";
            this.korisnikBindingSource1.DataSource = this.t16_DBDataSet;
            // 
            // t16_DBDataSet1
            // 
            this.t16_DBDataSet1.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkaBindingSource
            // 
            this.stavkaBindingSource.DataMember = "stavka";
            this.stavkaBindingSource.DataSource = this.t16_DBDataSet1;
            // 
            // stavkaTableAdapter
            // 
            this.stavkaTableAdapter.ClearBeforeFill = true;
            // 
            // popravakLabel
            // 
            popravakLabel.AutoSize = true;
            popravakLabel.Location = new System.Drawing.Point(18, 383);
            popravakLabel.Name = "popravakLabel";
            popravakLabel.Size = new System.Drawing.Size(55, 13);
            popravakLabel.TabIndex = 30;
            popravakLabel.Text = "popravak:";
            // 
            // popravakListBox
            // 
            this.popravakListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.radni_nalogBindingSource, "popravak", true));
            this.popravakListBox.DataSource = this.radni_nalogBindingSource;
            this.popravakListBox.DisplayMember = "popravak";
            this.popravakListBox.FormattingEnabled = true;
            this.popravakListBox.Location = new System.Drawing.Point(171, 365);
            this.popravakListBox.Name = "popravakListBox";
            this.popravakListBox.Size = new System.Drawing.Size(147, 56);
            this.popravakListBox.TabIndex = 31;
            this.popravakListBox.ValueMember = "popravak";
            // 
            // RadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 570);
            this.Controls.Add(popravakLabel);
            this.Controls.Add(this.popravakListBox);
            this.Controls.Add(iD_korisnikLabel);
            this.Controls.Add(this.iD_korisnikComboBox);
            this.Controls.Add(this.radni_nalogBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Name = "RadniNalog";
            this.Text = "RadniNalog";
            this.Load += new System.EventHandler(this.RadniNalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).EndInit();
            this.radni_nalogBindingNavigator.ResumeLayout(false);
            this.radni_nalogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKVoziloKorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource radni_nalogBindingSource;
        private T16_DBDataSetTableAdapters.Radni_nalogTableAdapter radni_nalogTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private T16_DBDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.BindingNavigator radni_nalogBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton radni_nalogBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource fKVoziloKorisnikBindingSource;
        private System.Windows.Forms.ComboBox iD_korisnikComboBox;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private T16_DBDataSet t16_DBDataSet1;
        private System.Windows.Forms.BindingSource stavkaBindingSource;
        private T16_DBDataSetTableAdapters.stavkaTableAdapter stavkaTableAdapter;
        private System.Windows.Forms.ListBox popravakListBox;
    }
}