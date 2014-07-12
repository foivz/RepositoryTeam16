namespace AplikacijaPI
{
    partial class FrmPregledPopravaka
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
            System.Windows.Forms.Label iD_vozilaLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label popravakLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.radni_nalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radni_nalogTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.Radni_nalogTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.sifra_zaposlenikaComboBox = new System.Windows.Forms.ComboBox();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.iD_vozilaComboBox = new System.Windows.Forms.ComboBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.popravakTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            sifra_zaposlenikaLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            iznosLabel = new System.Windows.Forms.Label();
            iD_vozilaLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            popravakLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.VoziloTableAdapter = null;
            // 
            // sifra_zaposlenikaLabel
            // 
            sifra_zaposlenikaLabel.AutoSize = true;
            sifra_zaposlenikaLabel.Location = new System.Drawing.Point(73, 49);
            sifra_zaposlenikaLabel.Name = "sifra_zaposlenikaLabel";
            sifra_zaposlenikaLabel.Size = new System.Drawing.Size(88, 13);
            sifra_zaposlenikaLabel.TabIndex = 14;
            sifra_zaposlenikaLabel.Text = "sifra zaposlenika:";
            // 
            // sifra_zaposlenikaComboBox
            // 
            this.sifra_zaposlenikaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "sifra_zaposlenika", true));
            this.sifra_zaposlenikaComboBox.FormattingEnabled = true;
            this.sifra_zaposlenikaComboBox.Location = new System.Drawing.Point(167, 46);
            this.sifra_zaposlenikaComboBox.Name = "sifra_zaposlenikaComboBox";
            this.sifra_zaposlenikaComboBox.Size = new System.Drawing.Size(121, 21);
            this.sifra_zaposlenikaComboBox.TabIndex = 15;
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Location = new System.Drawing.Point(72, 113);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(39, 13);
            datumLabel.TabIndex = 15;
            datumLabel.Text = "datum:";
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radni_nalogBindingSource, "datum", true));
            this.datumDateTimePicker.Location = new System.Drawing.Point(117, 109);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDateTimePicker.TabIndex = 16;
            // 
            // iznosLabel
            // 
            iznosLabel.AutoSize = true;
            iznosLabel.Location = new System.Drawing.Point(17, 155);
            iznosLabel.Name = "iznosLabel";
            iznosLabel.Size = new System.Drawing.Size(34, 13);
            iznosLabel.TabIndex = 16;
            iznosLabel.Text = "iznos:";
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "iznos", true));
            this.iznosTextBox.Location = new System.Drawing.Point(57, 152);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(100, 20);
            this.iznosTextBox.TabIndex = 17;
            // 
            // iD_vozilaLabel
            // 
            iD_vozilaLabel.AutoSize = true;
            iD_vozilaLabel.Location = new System.Drawing.Point(60, 203);
            iD_vozilaLabel.Name = "iD_vozilaLabel";
            iD_vozilaLabel.Size = new System.Drawing.Size(51, 13);
            iD_vozilaLabel.TabIndex = 17;
            iD_vozilaLabel.Text = "ID vozila:";
            // 
            // iD_vozilaComboBox
            // 
            this.iD_vozilaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "ID_vozila", true));
            this.iD_vozilaComboBox.FormattingEnabled = true;
            this.iD_vozilaComboBox.Location = new System.Drawing.Point(117, 200);
            this.iD_vozilaComboBox.Name = "iD_vozilaComboBox";
            this.iD_vozilaComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_vozilaComboBox.TabIndex = 18;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(65, 249);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 18;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(109, 246);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 19;
            // 
            // popravakLabel
            // 
            popravakLabel.AutoSize = true;
            popravakLabel.Location = new System.Drawing.Point(109, 285);
            popravakLabel.Name = "popravakLabel";
            popravakLabel.Size = new System.Drawing.Size(55, 13);
            popravakLabel.TabIndex = 19;
            popravakLabel.Text = "popravak:";
            // 
            // popravakTextBox
            // 
            this.popravakTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radni_nalogBindingSource, "popravak", true));
            this.popravakTextBox.Location = new System.Drawing.Point(170, 282);
            this.popravakTextBox.Name = "popravakTextBox";
            this.popravakTextBox.Size = new System.Drawing.Size(100, 20);
            this.popravakTextBox.TabIndex = 20;
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(80, 24);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(77, 13);
            korisnicko_imeLabel.TabIndex = 20;
            korisnicko_imeLabel.Text = "korisnicko ime:";
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "korisnicko_ime", true));
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(163, 21);
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnicko_imeTextBox.TabIndex = 21;
            // 
            // FrmPregledPopravaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 344);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.korisnicko_imeTextBox);
            this.Controls.Add(popravakLabel);
            this.Controls.Add(this.popravakTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(iD_vozilaLabel);
            this.Controls.Add(this.iD_vozilaComboBox);
            this.Controls.Add(iznosLabel);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumDateTimePicker);
            this.Controls.Add(sifra_zaposlenikaLabel);
            this.Controls.Add(this.sifra_zaposlenikaComboBox);
            this.Controls.Add(this.button1);
            this.Name = "FrmPregledPopravaka";
            this.Text = "FrmPregledPopravaka";
            this.Load += new System.EventHandler(this.FrmPregledPopravaka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radni_nalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource radni_nalogBindingSource;
        private T16_DBDataSetTableAdapters.Radni_nalogTableAdapter radni_nalogTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sifra_zaposlenikaComboBox;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.ComboBox iD_vozilaComboBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox popravakTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
    }
}