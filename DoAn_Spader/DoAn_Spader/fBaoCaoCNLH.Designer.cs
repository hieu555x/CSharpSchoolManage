namespace DoAn_Spader
{
    partial class fBaoCaoCNLH
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
            this.dataCNLH = new DoAn_Spader.dataCNLH();
            this.KQ_CA_NAM_TONG_HOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KQ_CA_NAM_TONG_HOPTableAdapter = new DoAn_Spader.dataCNLHTableAdapters.KQ_CA_NAM_TONG_HOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataCNLH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_CA_NAM_TONG_HOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KQ_CA_NAM_TONG_HOPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1172, 712);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataCNLH
            // 
            this.dataCNLH.DataSetName = "dataCNLH";
            this.dataCNLH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KQ_CA_NAM_TONG_HOPBindingSource
            // 
            this.KQ_CA_NAM_TONG_HOPBindingSource.DataMember = "KQ_CA_NAM_TONG_HOP";
            this.KQ_CA_NAM_TONG_HOPBindingSource.DataSource = this.dataCNLH;
            // 
            // KQ_CA_NAM_TONG_HOPTableAdapter
            // 
            this.KQ_CA_NAM_TONG_HOPTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCaoCNLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 712);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoCNLH";
            this.Text = "Kết quả tổng hợp cả năm của học sinh";
            this.Load += new System.EventHandler(this.fBaoCaoCNLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCNLH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_CA_NAM_TONG_HOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KQ_CA_NAM_TONG_HOPBindingSource;
        private dataCNLH dataCNLH;
        private dataCNLHTableAdapters.KQ_CA_NAM_TONG_HOPTableAdapter KQ_CA_NAM_TONG_HOPTableAdapter;
    }
}