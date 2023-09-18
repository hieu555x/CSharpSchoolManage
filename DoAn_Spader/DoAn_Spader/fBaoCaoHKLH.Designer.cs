namespace DoAn_Spader
{
    partial class fBaoCaoHKLH
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
            this.KQ_HOC_KY_TONG_HOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataLopHoc = new DoAn_Spader.dataLopHoc();
            this.LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new DoAn_Spader.dataLopHocTableAdapters.LOPTableAdapter();
            this.dataHKLH = new DoAn_Spader.dataHKLH();
            this.KQ_HOC_KY_TONG_HOPTableAdapter = new DoAn_Spader.dataHKLHTableAdapters.KQ_HOC_KY_TONG_HOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_HOC_KY_TONG_HOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHKLH)).BeginInit();
            this.SuspendLayout();
            // 
            // KQ_HOC_KY_TONG_HOPBindingSource
            // 
            this.KQ_HOC_KY_TONG_HOPBindingSource.DataMember = "KQ_HOC_KY_TONG_HOP";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KQ_HOC_KY_TONG_HOPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1072, 629);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataLopHoc
            // 
            this.dataLopHoc.DataSetName = "dataLopHoc";
            this.dataLopHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LOPBindingSource
            // 
            this.LOPBindingSource.DataMember = "LOP";
            this.LOPBindingSource.DataSource = this.dataLopHoc;
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // dataHKLH
            // 
            this.dataHKLH.DataSetName = "dataHKLH";
            this.dataHKLH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KQ_HOC_KY_TONG_HOPTableAdapter
            // 
            this.KQ_HOC_KY_TONG_HOPTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCaoHKLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 629);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoHKLH";
            this.Text = "Báo cáo điểm học kỳ theo lớp học";
            this.Load += new System.EventHandler(this.fBaoCaoHKLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KQ_HOC_KY_TONG_HOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataHKLH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KQ_HOC_KY_TONG_HOPBindingSource;
        private System.Windows.Forms.BindingSource LOPBindingSource;
        private dataLopHoc dataLopHoc;
        private dataLopHocTableAdapters.LOPTableAdapter LOPTableAdapter;
        private dataHKLH dataHKLH;
        private dataHKLHTableAdapters.KQ_HOC_KY_TONG_HOPTableAdapter KQ_HOC_KY_TONG_HOPTableAdapter;
    }
}