namespace AplikacijaPI
{
    partial class FrmLogin
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
            this.lblKorIme = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.lblLoz = new System.Windows.Forms.Label();
            this.txtLoz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(37, 33);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorIme.TabIndex = 0;
            this.lblKorIme.Text = "Korisnićko ime";
            this.lblKorIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(147, 30);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(130, 20);
            this.txtKorIme.TabIndex = 1;
            // 
            // lblLoz
            // 
            this.lblLoz.AutoSize = true;
            this.lblLoz.Location = new System.Drawing.Point(37, 96);
            this.lblLoz.Name = "lblLoz";
            this.lblLoz.Size = new System.Drawing.Size(44, 13);
            this.lblLoz.TabIndex = 2;
            this.lblLoz.Text = "Lozinka";
            // 
            // txtLoz
            // 
            this.txtLoz.Location = new System.Drawing.Point(148, 93);
            this.txtLoz.Name = "txtLoz";
            this.txtLoz.Size = new System.Drawing.Size(129, 20);
            this.txtLoz.TabIndex = 3;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 183);
            this.Controls.Add(this.txtLoz);
            this.Controls.Add(this.lblLoz);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblKorIme);
            this.Name = "FrmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label lblLoz;
        private System.Windows.Forms.TextBox txtLoz;
    }
}

