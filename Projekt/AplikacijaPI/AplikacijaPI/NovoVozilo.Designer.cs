namespace AplikacijaPI
{
    partial class NovoVozilo
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "VIN vozila";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(33, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(52, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "ID_model";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(33, 159);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(41, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Vlasnik";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(31, 213);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(101, 13);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Registarska oznaka";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(38, 263);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(28, 13);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "Boja";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(32, 307);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(99, 13);
            this.lbl6.TabIndex = 9;
            this.lbl6.Text = "Godina Proizvodnje";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(35, 359);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(38, 13);
            this.lbl7.TabIndex = 10;
            this.lbl7.Text = "Snaga";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(29, 404);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(82, 13);
            this.lbl8.TabIndex = 11;
            this.lbl8.Text = "Prva registracija";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 302);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(138, 356);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(138, 401);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 15;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(310, 448);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 23);
            this.btn1.TabIndex = 26;
            this.btn1.Text = "Glavni izbornik";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "NovoVozilo";
            this.Text = "NovoVozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
    }
}