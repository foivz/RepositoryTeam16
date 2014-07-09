namespace AplikacijaPI
{
    partial class FrmPregledRadnihNaloga
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
            this.lblRadnikS = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.VoziloTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.iDradninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popravakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadnikS
            // 
            this.lblRadnikS.AutoSize = true;
            this.lblRadnikS.Location = new System.Drawing.Point(26, 48);
            this.lblRadnikS.Name = "lblRadnikS";
            this.lblRadnikS.Size = new System.Drawing.Size(73, 13);
            this.lblRadnikS.TabIndex = 0;
            this.lblRadnikS.Text = "Radnik Servis";
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(30, 85);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(35, 13);
            this.lblKlijent.TabIndex = 1;
            this.lblKlijent.Text = "Klijent";
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(26, 135);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(35, 13);
            this.lblVozilo.TabIndex = 2;
            this.lblVozilo.Text = "Vozilo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ažururaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.comboBox1.DataSource = this.korisnikBindingSource;
            this.comboBox1.DisplayMember = "sifra_zaposlenika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "sifra_zaposlenika";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.korisnikBindingSource;
            this.comboBox2.DisplayMember = "ime";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "ime";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "registracijska_oznaka", true));
            this.comboBox3.DataSource = this.voziloBindingSource;
            this.comboBox3.DisplayMember = "registracijska_oznaka";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(110, 132);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(122, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "registracijska_oznaka";
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
            this.tableAdapterManager.Radni_nalogTableAdapter = this.radni_nalogTableAdapter;
            this.tableAdapterManager.stavkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = this.voziloTableAdapter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 201);
            this.dataGridView1.TabIndex = 10;
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
            // FrmPregledRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.lblRadnikS);
            this.Name = "FrmPregledRadnihNaloga";
            this.Text = "FrmPregledRadnihNaloga";
            this.Load += new System.EventHandler(this.FrmPregledRadnihNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadnikS;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private T16_DBDataSetTableAdapters.VoziloTableAdapter voziloTableAdapter;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private T16_DBDataSetTableAdapters.Radni_nalogTableAdapter radni_nalogTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource radni_nalogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDradninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazaposlenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popravakDataGridViewTextBoxColumn;
    }
}