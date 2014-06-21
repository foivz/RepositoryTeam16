namespace AplikacijaPI
{
    partial class FrmUnosKorisnikaVozila
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(57, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 42);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Novi korisnik";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(56, 129);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(119, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Novo vozilo";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // FrmUnosKorisnikaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "FrmUnosKorisnikaVozila";
            this.Text = "FrmUnosKorisnikaVozila";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}