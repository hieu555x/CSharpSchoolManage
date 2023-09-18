namespace DoAn_Spader
{
    partial class fBaoCaoGV
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
            this.dataGiaoVien = new DoAn_Spader.dataGiaoVien();
            this.GIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GIAOVIENTableAdapter = new DoAn_Spader.dataGiaoVienTableAdapters.GIAOVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GIAOVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(947, 699);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataGiaoVien
            // 
            this.dataGiaoVien.DataSetName = "dataGiaoVien";
            this.dataGiaoVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GIAOVIENBindingSource
            // 
            this.GIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.GIAOVIENBindingSource.DataSource = this.dataGiaoVien;
            // 
            // GIAOVIENTableAdapter
            // 
            this.GIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCaoGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 699);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoGV";
            this.Text = "Báo cáo danh sách giáo viên";
            this.Load += new System.EventHandler(this.fBaoCaoGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIAOVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GIAOVIENBindingSource;
        private dataGiaoVien dataGiaoVien;
        private dataGiaoVienTableAdapters.GIAOVIENTableAdapter GIAOVIENTableAdapter;
    }
}