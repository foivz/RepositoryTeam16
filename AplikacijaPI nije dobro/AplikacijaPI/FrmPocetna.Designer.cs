namespace AplikacijaPI
{
    partial class FrmPocetna
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.picBoxNaziv = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNaziv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(39, 205);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(106, 40);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(201, 205);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(95, 42);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // picBoxNaziv
            // 
            this.picBoxNaziv.Location = new System.Drawing.Point(69, 42);
            this.picBoxNaziv.Name = "picBoxNaziv";
            this.picBoxNaziv.Size = new System.Drawing.Size(194, 84);
            this.picBoxNaziv.TabIndex = 3;
            this.picBoxNaziv.TabStop = false;
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 285);
            this.Controls.Add(this.picBoxNaziv);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Name = "FrmPocetna";
            this.Text = "FrmPocetna";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNaziv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.PictureBox picBoxNaziv;
    }
}