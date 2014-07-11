namespace AplikacijaPI
{
    partial class FrmPregledIzvještaja
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDradninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popravakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.voziloTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.VoziloTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.voziloBindingSource, "registracijska_oznaka", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 197);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "Vozilo";
            this.voziloBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // t16_DBDataSet
            // 
            this.t16_DBDataSet.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.voziloBindingSource;
            this.comboBox3.DisplayMember = "registracijska_oznaka";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(151, 141);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(152, 24);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "registracijska_oznaka";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.korisnikBindingSource;
            this.comboBox2.DisplayMember = "ime";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 82);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.comboBox1.DataSource = this.korisnikBindingSource;
            this.comboBox1.DisplayMember = "sifra_zaposlenika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "sifra_zaposlenika";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(34, 197);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(49, 17);
            this.lbl4.TabIndex = 19;
            this.lbl4.Text = "Datum";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(36, 145);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 17);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "Vozilo";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(36, 82);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Klijent";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(36, 20);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 17);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "RadnikS";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(794, 467);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 28);
            this.btn1.TabIndex = 24;
            this.btn1.Text = "Glavni izbornik";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 25;
            this.button1.Text = "Pregled";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDradninalogDataGridViewTextBoxColumn,
            this.sifrazaposlenikaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.iDkorisnikaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.popravakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.radni_nalogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 192);
            this.dataGridView1.TabIndex = 26;
            // 
            // iDradninalogDataGridViewTextBoxColumn
            // 
            this.iDradninalogDataGridViewTextBoxColumn.DataPropertyName = "ID_radni_nalog";
            this.iDradninalogDataGridViewTextBoxColumn.HeaderText = "ID_radni_nalog";
            this.iDradninalogDataGridViewTextBoxColumn.Name = "iDradninalogDataGridViewTextBoxColumn";
            this.iDradninalogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifrazaposlenikaDataGridViewTextBoxColumn
            // 
            this.sifrazaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "sifra_zaposlenika";
            this.sifrazaposlenikaDataGridViewTextBoxColumn.HeaderText = "sifra_zaposlenika";
            this.sifrazaposlenikaDataGridViewTextBoxColumn.Name = "sifrazaposlenikaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            // 
            // iDkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.HeaderText = "ID_korisnika";
            this.iDkorisnikaDataGridViewTextBoxColumn.Name = "iDkorisnikaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // popravakDataGridViewTextBoxColumn
            // 
            this.popravakDataGridViewTextBoxColumn.DataPropertyName = "popravak";
            this.popravakDataGridViewTextBoxColumn.HeaderText = "popravak";
            this.popravakDataGridViewTextBoxColumn.Name = "popravakDataGridViewTextBoxColumn";
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
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.MarkaVozilaTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.Radni_nalogTableAdapter = this.radni_nalogTableAdapter;
            this.tableAdapterManager.stavkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = this.voziloTableAdapter;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = global::AplikacijaPI.Properties.Resources.poz33;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 508);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPregledIzvještaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPregledIzvještaja";
            this.Text = "FrmPregledIzvještaja";
            this.Load += new System.EventHandler(this.FrmPregledIzvještaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource radni_nalogBindingSource;
        private T16_DBDataSetTableAdapters.Radni_nalogTableAdapter radni_nalogTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDradninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popravakDataGridViewTextBoxColumn;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}