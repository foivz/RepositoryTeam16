namespace AplikacijaPI
{
    partial class Radni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radni));
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label iznosLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label popravakLabel;
            System.Windows.Forms.Label iD_vozilaLabel;
            System.Windows.Forms.Label iD_korisnikLabel;
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.radni_nalogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.radni_nalogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.popravakTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.VoziloTableAdapter();
            this.iD_korisnikComboBox = new System.Windows.Forms.ComboBox();
            this.iD_vozilaComboBox = new System.Windows.Forms.ComboBox();
            this.stavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.stavkaTableAdapter();
            this.stavkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dijeloviuslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dijelovi_uslugeTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Dijelovi_uslugeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            datumLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            popravakLabel = new System.Windows.Forms.Label();
            iD_vozilaLabel = new System.Windows.Forms.Label();
            iD_korisnikLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).BeginInit();
            this.radni_nalogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijeloviuslugeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t16_DBDataSet
            // 
            this.t16_DBDataSet.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radni_nalogBindingSource
            // 
            this.radni_nalogBindingSource.DataMember = "Radni_nalog";
            this.radni_nalogBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // radni_nalogTableAdapter
            // 
            this.radni_nalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dijelovi_uslugeTableAdapter = this.dijelovi_uslugeTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.MarkaVozilaTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Radni_nalogTableAdapter = this.radni_nalogTableAdapter;
            this.tableAdapterManager.stavkaTableAdapter = this.stavkaTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = this.voziloTableAdapter;
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
            this.radni_nalogBindingNavigator.Size = new System.Drawing.Size(467, 25);
            this.radni_nalogBindingNavigator.TabIndex = 0;
            this.radni_nalogBindingNavigator.Text = "bindingNavigator1";
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
            // radni_nalogBindingNavigatorSaveItem
            // 
            this.radni_nalogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.radni_nalogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("radni_nalogBindingNavigatorSaveItem.Image")));
            this.radni_nalogBindingNavigatorSaveItem.Name = "radni_nalogBindingNavigatorSaveItem";
            this.radni_nalogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.radni_nalogBindingNavigatorSaveItem.Text = "Save Data";
            this.radni_nalogBindingNavigatorSaveItem.Click += new System.EventHandler(this.radni_nalogBindingNavigatorSaveItem_Click);
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(21, 116);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(39, 13);
            datumLabel.TabIndex = 3;
            datumLabel.Text = "datum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radni_nalogBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(156, 110);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 4;
            // 
            // iznosLabel
            // 
            iznosLabel.AutoSize = true;
            iznosLabel.Location = new System.Drawing.Point(21, 156);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(34, 13);
            iznosLabel.TabIndex = 5;
            iznosLabel.Text = "iznos:";
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "iznos", true));
            this.iznosTextBox.Location = new System.Drawing.Point(156, 153);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(100, 20);
            this.iznosTextBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(21, 236);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(156, 233);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 10;
            // 
            // popravakLabel
            // 
            popravakLabel.AutoSize = true;
            popravakLabel.Location = new System.Drawing.Point(21, 278);
            popravakLabel.Name = "popravakLabel";
            popravakLabel.Size = new System.Drawing.Size(55, 13);
            popravakLabel.TabIndex = 11;
            popravakLabel.Text = "popravak:";
            // 
            // popravakTextBox
            // 
            this.popravakTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "popravak", true));
            this.popravakTextBox.Location = new System.Drawing.Point(156, 271);
            this.popravakTextBox.Name = "popravakTextBox";
            this.popravakTextBox.Size = new System.Drawing.Size(100, 20);
            this.popravakTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Glavni izbornik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iD_vozilaLabel
            // 
            iD_vozilaLabel.AutoSize = true;
            iD_vozilaLabel.Location = new System.Drawing.Point(25, 197);
            iD_vozilaLabel.Name = "iD_vozilaLabel";
            iD_vozilaLabel.Size = new System.Drawing.Size(51, 13);
            iD_vozilaLabel.TabIndex = 15;
            iD_vozilaLabel.Text = "ID vozila:";
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
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "Vozilo";
            this.voziloBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
            // 
            // iD_korisnikLabel
            // 
            iD_korisnikLabel.AutoSize = true;
            iD_korisnikLabel.Location = new System.Drawing.Point(16, 63);
            iD_korisnikLabel.Name = "iD_korisnikLabel";
            iD_korisnikLabel.Size = new System.Drawing.Size(60, 13);
            iD_korisnikLabel.TabIndex = 16;
            iD_korisnikLabel.Text = "ID korisnik:";
            // 
            // iD_korisnikComboBox
            // 
            this.iD_korisnikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ID_korisnik", true));
            this.iD_korisnikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voziloBindingSource, "vlasnik", true));
            this.iD_korisnikComboBox.DataSource = this.voziloBindingSource;
            this.iD_korisnikComboBox.DisplayMember = "vlasnik";
            this.iD_korisnikComboBox.FormattingEnabled = true;
            this.iD_korisnikComboBox.Location = new System.Drawing.Point(156, 63);
            this.iD_korisnikComboBox.Name = "iD_korisnikComboBox";
            this.iD_korisnikComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_korisnikComboBox.TabIndex = 17;
            this.iD_korisnikComboBox.ValueMember = "vlasnik";
            // 
            // iD_vozilaComboBox
            // 
            this.iD_vozilaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "ID_vozila", true));
            this.iD_vozilaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.voziloBindingSource, "ID_vozila", true));
            this.iD_vozilaComboBox.DataSource = this.voziloBindingSource;
            this.iD_vozilaComboBox.DisplayMember = "registracijska_oznaka";
            this.iD_vozilaComboBox.FormattingEnabled = true;
            this.iD_vozilaComboBox.Location = new System.Drawing.Point(156, 194);
            this.iD_vozilaComboBox.Name = "iD_vozilaComboBox";
            this.iD_vozilaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_vozilaComboBox.TabIndex = 16;
            this.iD_vozilaComboBox.ValueMember = "ID_vozila";
            // 
            // stavkaBindingSource
            // 
            this.stavkaBindingSource.DataMember = "stavka";
            this.stavkaBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // stavkaTableAdapter
            // 
            this.stavkaTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaDataGridView
            // 
            this.stavkaDataGridView.AllowUserToOrderColumns = true;
            this.stavkaDataGridView.AutoGenerateColumns = false;
            this.stavkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.stavkaDataGridView.DataSource = this.stavkaBindingSource;
            this.stavkaDataGridView.Location = new System.Drawing.Point(39, 310);
            this.stavkaDataGridView.Name = "stavkaDataGridView";
            this.stavkaDataGridView.Size = new System.Drawing.Size(300, 178);
            this.stavkaDataGridView.TabIndex = 17;
            // 
            // dijeloviuslugeBindingSource
            // 
            this.dijeloviuslugeBindingSource.DataMember = "Dijelovi_usluge";
            this.dijeloviuslugeBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // dijelovi_uslugeTableAdapter
            // 
            this.dijelovi_uslugeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kataloski_broj";
            this.dataGridViewTextBoxColumn1.DataSource = this.dijeloviuslugeBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "kataloski_broj";
            this.dataGridViewTextBoxColumn1.HeaderText = "kataloski_broj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "kataloski_broj";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_radni_nalog";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_radni_nalog";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kolicina";
            this.dataGridViewTextBoxColumn3.HeaderText = "kolicina";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Radni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 618);
            this.Controls.Add(this.stavkaDataGridView);
            this.Controls.Add(iD_korisnikLabel);
            this.Controls.Add(this.iD_korisnikComboBox);
            this.Controls.Add(iD_vozilaLabel);
            this.Controls.Add(this.iD_vozilaComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(popravakLabel);
            this.Controls.Add(this.popravakTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(iznosLabel);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(this.radni_nalogBindingNavigator);
            this.Name = "Radni";
            this.Text = "Radni";
            this.Load += new System.EventHandler(this.Radni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).EndInit();
            this.radni_nalogBindingNavigator.ResumeLayout(false);
            this.radni_nalogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijeloviuslugeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource radni_nalogBindingSource;
        private T16_DBDataSetTableAdapters.Radni_nalogTableAdapter radni_nalogTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox popravakTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.ComboBox iD_korisnikComboBox;
        private T16_DBDataSetTableAdapters.stavkaTableAdapter stavkaTableAdapter;
        private System.Windows.Forms.ComboBox iD_vozilaComboBox;
        private System.Windows.Forms.BindingSource stavkaBindingSource;
        private System.Windows.Forms.DataGridView stavkaDataGridView;
        private T16_DBDataSetTableAdapters.Dijelovi_uslugeTableAdapter dijelovi_uslugeTableAdapter;
        private System.Windows.Forms.BindingSource dijeloviuslugeBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}