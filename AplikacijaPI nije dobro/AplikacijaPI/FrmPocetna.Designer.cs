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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetna));
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.picBoxNaziv = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNaziv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(61, 242);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(141, 49);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(277, 242);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(127, 52);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // picBoxNaziv
            // 
            this.picBoxNaziv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxNaziv.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBoxNaziv.ErrorImage")));
            this.picBoxNaziv.Image = global::AplikacijaPI.Properties.Resources.Bez_naslova;
            this.picBoxNaziv.Location = new System.Drawing.Point(-1, 0);
            this.picBoxNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxNaziv.Name = "picBoxNaziv";
            this.picBoxNaziv.Size = new System.Drawing.Size(498, 359);
            this.picBoxNaziv.TabIndex = 3;
            this.picBoxNaziv.TabStop = false;
            this.picBoxNaziv.Click += new System.EventHandler(this.picBoxNaziv_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(61, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 56);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Autoservis SNM";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picBoxNaziv);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPocetna";
            this.Text = "FrmPocetna";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNaziv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.PictureBox picBoxNaziv;
        private System.Windows.Forms.TextBox textBox1;
    }
}