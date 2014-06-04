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
            this.lblRadnikS = new System.Windows.Forms.Label();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.txtRadnikS = new System.Windows.Forms.TextBox();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.txtVozilo = new System.Windows.Forms.TextBox();
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
            // txtRadnikS
            // 
            this.txtRadnikS.Location = new System.Drawing.Point(111, 45);
            this.txtRadnikS.Name = "txtRadnikS";
            this.txtRadnikS.Size = new System.Drawing.Size(91, 20);
            this.txtRadnikS.TabIndex = 3;
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(112, 85);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(89, 20);
            this.txtKlijent.TabIndex = 4;
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(112, 134);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(88, 20);
            this.txtVozilo.TabIndex = 5;
            // 
            // FrmPregledRadnihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 262);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.txtRadnikS);
            this.Controls.Add(this.lblVozilo);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.lblRadnikS);
            this.Name = "FrmPregledRadnihNaloga";
            this.Text = "FrmPregledRadnihNaloga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadnikS;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.TextBox txtRadnikS;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.TextBox txtVozilo;
    }
}