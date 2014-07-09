namespace AplikacijaPI
{
    partial class FrmIzdavanjeKorisnickihPOdataka
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "RadnikP";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(29, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Klijent";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(29, 156);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(75, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Korisnićko ime";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(29, 201);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(44, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Lozinka";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.comboBox1.DataSource = this.korisnikBindingSource;
            this.comboBox1.DisplayMember = "sifra_zaposlenika";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ime", true));
            this.comboBox2.DataSource = this.korisnikBindingSource;
            this.comboBox2.DisplayMember = "prezime";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "korisnicko_ime", true));
            this.textBox1.Location = new System.Drawing.Point(119, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "lozinka", true));
            this.textBox2.Location = new System.Drawing.Point(119, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Glavni izbornik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
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
            // FrmIzdavanjeKorisnickihPOdataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 332);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "FrmIzdavanjeKorisnickihPOdataka";
            this.Text = "FrmIzdavanjeKorisnickihPOdataka";
            this.Load += new System.EventHandler(this.FrmIzdavanjeKorisnickihPOdataka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private T16_DBDataSet t16_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private T16_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private T16_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}