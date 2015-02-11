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
            this.btnPrijava.Location = new System.Drawing.Point(46, 91);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(106, 40);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(208, 91);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(95, 42);
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
            this.picBoxNaziv.Name = "picBoxNaziv";
            this.picBoxNaziv.Size = new System.Drawing.Size(374, 292);
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
            this.textBox1.Location = new System.Drawing.Point(46, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 45);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Autoservis SNM";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.picBoxNaziv);
            this.KeyPreview = true;
            this.Name = "FrmPocetna";
            this.Text = "FrmPocetna";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPocetna_KeyDown_1);
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