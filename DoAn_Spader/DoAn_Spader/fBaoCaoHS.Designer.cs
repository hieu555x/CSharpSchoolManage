namespace DoAn_Spader
{
    partial class fBaoCaoHS
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
            this.HOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HocSinh = new DoAn_Spader.HocSinh();
            this.KQ_HOC_KY_TONG_HOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOCSINHTableAdapter = new DoAn_Spader.HocSinhTableAdapters.HOCSINHTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // HOCSINHBindingSource
            // 
            this.HOCSINHBindingSource.DataMember = "HOCSINH";
            this.HOCSINHBindingSource.DataSource = this.HocSinh;
            // 
            // HocSinh
            // 
            this.HocSinh.DataSetName = "HocSinh";
            this.HocSinh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            // 
            // HOCSINHTableAdapter
            // 
            this.HOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOCSINHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1465, 629);
            this.reportViewer1.TabIndex = 0;
            // 
            // fBaoCaoHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 629);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoHS";
            this.Text = "Báo cáo danh sách học sinh";
            this.Load += new System.EventHandler(this.fBaoCaoHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_HOC_KY_TONG_HOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource KQ_HOC_KY_TONG_HOPBindingSource;
        private System.Windows.Forms.BindingSource HOCSINHBindingSource;
        private HocSinh HocSinh;
        private HocSinhTableAdapters.HOCSINHTableAdapter HOCSINHTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}