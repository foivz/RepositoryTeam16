namespace AplikacijaPI
{
    partial class korisnickiPodaci
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T16_DBDataSet1 = new AplikacijaPI.T16_DBDataSet1();
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikTableAdapter = new AplikacijaPI.T16_DBDataSet1TableAdapters.KorisnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.T16_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KorisnikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AplikacijaPI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 408);
            this.reportViewer1.TabIndex = 0;
            // 
            // T16_DBDataSet1
            // 
            this.T16_DBDataSet1.DataSetName = "T16_DBDataSet1";
            this.T16_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataMember = "Korisnik";
            this.KorisnikBindingSource.DataSource = this.T16_DBDataSet1;
            // 
            // KorisnikTableAdapter
            // 
            this.KorisnikTableAdapter.ClearBeforeFill = true;
            // 
            // korisnickiPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 404);
            this.Controls.Add(this.reportViewer1);
            this.Name = "korisnickiPodaci";
            this.Text = "korisnickiPodaci";
            this.Load += new System.EventHandler(this.korisnickiPodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T16_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private T16_DBDataSet1 T16_DBDataSet1;
        private T16_DBDataSet1TableAdapters.KorisnikTableAdapter KorisnikTableAdapter;
    }
}