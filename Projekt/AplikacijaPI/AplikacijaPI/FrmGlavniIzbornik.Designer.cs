namespace AplikacijaPI
{
    partial class FrmGlavniIzbornik
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(22, 38);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(153, 46);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Pregled izvještaja";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(22, 103);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(153, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Unesi korisnika";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(22, 165);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(153, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Izradi radni nalog";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(22, 231);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(153, 39);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Unesi dio";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 346);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "FrmGlavniIzbornik";
            this.Text = "FrmGlavniIzbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;

    }
}