namespace AplikacijaPI
{
    partial class FrmIspisKorisnickihPodataka
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
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t16_DBDataSet1 = new AplikacijaPI.T16_DBDataSet1();
            this.t16DBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSet1TableAdapters.KorisnikTableAdapter();
            this.t16_DBDataSet11 = new AplikacijaPI.T16_DBDataSet1();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazaposlenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16DBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.t16_DBDataSet1;
            // 
            // t16_DBDataSet1
            // 
            this.t16_DBDataSet1.DataSetName = "T16_DBDataSet1";
            this.t16_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t16DBDataSet1BindingSource
            // 
            this.t16DBDataSet1BindingSource.DataSource = this.t16_DBDataSet1;
            this.t16DBDataSet1BindingSource.Position = 0;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // t16_DBDataSet11
            // 
            this.t16_DBDataSet11.DataSetName = "T16_DBDataSet1";
            this.t16_DBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "Korisnik";
            this.korisnikBindingSource1.DataSource = this.t16_DBDataSet11;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(903, 27);
            this.fillBy1ToolStrip.TabIndex = 3;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkorisnikDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.tipkorisnikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.radnomjestoDataGridViewTextBoxColumn,
            this.sifrazaposlenikaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.korisnikBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(903, 328);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDkorisnikDataGridViewTextBoxColumn
            // 
            this.iDkorisnikDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.HeaderText = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.Name = "iDkorisnikDataGridViewTextBoxColumn";
            this.iDkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // tipkorisnikaDataGridViewTextBoxColumn
            // 
            this.tipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.HeaderText = "tip_korisnika";
            this.tipkorisnikaDataGridViewTextBoxColumn.Name = "tipkorisnikaDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            // 
            // radnomjestoDataGridViewTextBoxColumn
            // 
            this.radnomjestoDataGridViewTextBoxColumn.DataPropertyName = "radno_mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.HeaderText = "radno_mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.Name = "radnomjestoDataGridViewTextBoxColumn";
            // 
            // sifrazaposlenikaDataGridViewTextBoxColumn
            // 
            this.sifrazaposlenikaDataGridViewTextBoxColumn.DataPropertyName = "sifra_zaposlenika";
            this.sifrazaposlenikaDataGridViewTextBoxColumn.HeaderText = "sifra_zaposlenika";
            this.sifrazaposlenikaDataGridViewTextBoxColumn.Name = "sifrazaposlenikaDataGridViewTextBoxColumn";
            // 
            // FrmIspisKorisnickihPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Name = "FrmIspisKorisnickihPodataka";
            this.Text = "FrmIspisKorisnickihPodataka";
            this.Load += new System.EventHandler(this.FrmIspisKorisnickihPodataka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16DBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource t16DBDataSet1BindingSource;
        private T16_DBDataSet1 t16_DBDataSet1;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSet1TableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private T16_DBDataSet1 t16_DBDataSet11;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazaposlenikaDataGridViewTextBoxColumn;
    }
}