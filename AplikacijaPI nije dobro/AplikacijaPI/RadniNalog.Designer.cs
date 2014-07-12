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
            System.Windows.Forms.Label sifra_zaposlenikaLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label iznosLabel;
            System.Windows.Forms.Label iD_korisnikaLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label popravakLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadniNalog));
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.stavkaTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.stavkaTableAdapter();
            this.radni_nalogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.radni_nalogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.popravakTextBox = new System.Windows.Forms.TextBox();
            this.stavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            sifra_zaposlenikaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            iD_korisnikaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            popravakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).BeginInit();
            this.radni_nalogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sifra_zaposlenikaLabel
            // 
            sifra_zaposlenikaLabel.AutoSize = true;
            sifra_zaposlenikaLabel.Location = new System.Drawing.Point(12, 67);
            sifra_zaposlenikaLabel.Name = "sifra_zaposlenikaLabel";
            sifra_zaposlenikaLabel.Size = new System.Drawing.Size(88, 13);
            sifra_zaposlenikaLabel.TabIndex = 1;
            sifra_zaposlenikaLabel.Text = "sifra zaposlenika:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(12, 113);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(39, 13);
            datumLabel.TabIndex = 3;
            datumLabel.Text = "datum:";
            // 
            // iznosLabel
            // 
            iznosLabel.AutoSize = true;
            iznosLabel.Location = new System.Drawing.Point(12, 160);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(34, 13);
            iznosLabel.TabIndex = 5;
            iznosLabel.Text = "iznos:";
            // 
            // iD_korisnikaLabel
            // 
            iD_korisnikaLabel.AutoSize = true;
            iD_korisnikaLabel.Location = new System.Drawing.Point(12, 209);
            iD_korisnikaLabel.Name = "iD_korisnikaLabel";
            iD_korisnikaLabel.Size = new System.Drawing.Size(66, 13);
            iD_korisnikaLabel.TabIndex = 7;
            iD_korisnikaLabel.Text = "ID korisnika:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(13, 255);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "status:";
            // 
            // popravakLabel
            // 
            popravakLabel.AutoSize = true;
            popravakLabel.Location = new System.Drawing.Point(13, 298);
            popravakLabel.Name = "popravakLabel";
            popravakLabel.Size = new System.Drawing.Size(55, 13);
            popravakLabel.TabIndex = 11;
            popravakLabel.Text = "popravak:";
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
            this.tableAdapterManager.Dijelovi_uslugeTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.MarkaVozilaTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Radni_nalogTableAdapter = this.radni_nalogTableAdapter;
            this.tableAdapterManager.stavkaTableAdapter = this.stavkaTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = null;
            // 
            // stavkaTableAdapter
            // 
            this.stavkaTableAdapter.ClearBeforeFill = true;
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
            this.radni_nalogBindingNavigator.Size = new System.Drawing.Size(432, 25);
            this.radni_nalogBindingNavigator.TabIndex = 0;
            this.radni_nalogBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // radni_nalogBindingNavigatorSaveItem
            // 
            this.radni_nalogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.radni_nalogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("radni_nalogBindingNavigatorSaveItem.Image")));
            this.radni_nalogBindingNavigatorSaveItem.Name = "radni_nalogBindingNavigatorSaveItem";
            this.radni_nalogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.radni_nalogBindingNavigatorSaveItem.Text = "Save Data";
            this.radni_nalogBindingNavigatorSaveItem.Click += new System.EventHandler(this.radni_nalogBindingNavigatorSaveItem_Click);
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radni_nalogBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(134, 113);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 4;
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "iznos", true));
            this.iznosTextBox.Location = new System.Drawing.Point(134, 160);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(100, 20);
            this.iznosTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(134, 255);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 10;
            // 
            // popravakTextBox
            // 
            this.popravakTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "popravak", true));
            this.popravakTextBox.Location = new System.Drawing.Point(134, 295);
            this.popravakTextBox.Name = "popravakTextBox";
            this.popravakTextBox.Size = new System.Drawing.Size(100, 20);
            this.popravakTextBox.TabIndex = 12;
            // 
            // stavkaBindingSource
            // 
            this.stavkaBindingSource.DataMember = "stavka";
            this.stavkaBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // stavkaDataGridView
            // 
            this.stavkaDataGridView.AutoGenerateColumns = false;
            this.stavkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.stavkaDataGridView.DataSource = this.stavkaBindingSource;
            this.stavkaDataGridView.Location = new System.Drawing.Point(34, 374);
            this.stavkaDataGridView.Name = "stavkaDataGridView";
            this.stavkaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.stavkaDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kataloski_broj";
            this.dataGridViewTextBoxColumn1.HeaderText = "kataloski_broj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "Glavni izbornik";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.radni_nalogBindingSource, "sifra_zaposlenika", true));
            this.comboBox1.DataSource = this.radni_nalogBindingSource;
            this.comboBox1.DisplayMember = "sifra_zaposlenika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "sifra_zaposlenika";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.radni_nalogBindingSource, "ID_korisnika", true));
            this.comboBox2.DataSource = this.radni_nalogBindingSource;
            this.comboBox2.DisplayMember = "ID_korisnika";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "ID_korisnika";
            // 
            // RadniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 662);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stavkaDataGridView);
            this.Controls.Add(popravakLabel);
            this.Controls.Add(this.popravakTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(iD_korisnikaLabel);
            this.Controls.Add(iznosLabel);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(sifra_zaposlenikaLabel);
            this.Controls.Add(this.radni_nalogBindingNavigator);
            this.Name = "RadniNalog";
            this.Text = "RadniNalog";
            this.Load += new System.EventHandler(this.RadniNalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingNavigator)).EndInit();
            this.radni_nalogBindingNavigator.ResumeLayout(false);
            this.radni_nalogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaDataGridView)).EndInit();
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
        private T16_DBDataSetTableAdapters.stavkaTableAdapter stavkaTableAdapter;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox popravakTextBox;
        private System.Windows.Forms.BindingSource stavkaBindingSource;
        private System.Windows.Forms.DataGridView stavkaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;

    }
}