﻿namespace AplikacijaPI
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
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t16_DBDataSet = new AplikacijaPI.T16_DBDataSet();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.korisnikTableAdapter = new AplikacijaPI.T16_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new AplikacijaPI.T16_DBDataSetTableAdapters.TableAdapterManager();
            this.korisnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.korisnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oIBTextBox = new System.Windows.Forms.TextBox();
            oIBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingNavigator)).BeginInit();
            this.korisnikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.t16_DBDataSet;
            // 
            // t16_DBDataSet
            // 
            this.t16_DBDataSet.DataSetName = "T16_DBDataSet";
            this.t16_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(29, 93);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(24, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Ime";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ime", true));
            this.textBox2.Location = new System.Drawing.Point(123, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(29, 144);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(44, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Prezime";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "prezime", true));
            this.textBox3.Location = new System.Drawing.Point(123, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(29, 198);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(40, 13);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Adresa";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(29, 241);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(66, 13);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "Broj telefona";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "adresa", true));
            this.textBox4.Location = new System.Drawing.Point(123, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "broj_telefona", true));
            this.textBox5.Location = new System.Drawing.Point(123, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 20);
            this.textBox5.TabIndex = 9;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(29, 290);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(75, 13);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Korisnićko ime";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(29, 328);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 13);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "Lozinka";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(29, 373);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(73, 13);
            this.lbl8.TabIndex = 12;
            this.lbl8.Text = "Radno Mjesto";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(29, 414);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(87, 13);
            this.lbl9.TabIndex = 13;
            this.lbl9.Text = "Šifra zaposlenika";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "korisnicko_ime", true));
            this.textBox6.Location = new System.Drawing.Point(123, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "lozinka", true));
            this.textBox7.Location = new System.Drawing.Point(123, 328);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "radno_mjesto", true));
            this.textBox8.Location = new System.Drawing.Point(123, 370);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 20);
            this.textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "sifra_zaposlenika", true));
            this.textBox9.Location = new System.Drawing.Point(123, 411);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(158, 20);
            this.textBox9.TabIndex = 17;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(298, 453);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 23);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "Glavni izbornik";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.korisnikBindingNavigator.Size = new System.Drawing.Size(433, 25);
            this.korisnikBindingNavigator.TabIndex = 27;
            this.korisnikBindingNavigator.Text = "bindingNavigator1";
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
            // korisnikBindingNavigatorSaveItem
            // 
            this.korisnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.korisnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("korisnikBindingNavigatorSaveItem.Image")));
            this.korisnikBindingNavigatorSaveItem.Name = "korisnikBindingNavigatorSaveItem";
            this.korisnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.korisnikBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(29, 56);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 27;
            oIBLabel.Text = "OIB:";
            // 
            // oIBTextBox
            // 
            this.oIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "OIB", true));
            this.oIBTextBox.Location = new System.Drawing.Point(123, 56);
            this.oIBTextBox.Name = "oIBTextBox";
            this.oIBTextBox.Size = new System.Drawing.Size(158, 20);
            this.oIBTextBox.TabIndex = 28;
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 496);
            this.Controls.Add(oIBLabel);
            this.Controls.Add(this.oIBTextBox);
            this.Controls.Add(this.korisnikBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl2);
            this.Name = "NoviKorisnik";
            this.Text = "NoviKorisnik";
            this.Load += new System.EventHandler(this.NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t16_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingNavigator)).EndInit();
            this.korisnikBindingNavigator.ResumeLayout(false);
            this.korisnikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
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
    }
}