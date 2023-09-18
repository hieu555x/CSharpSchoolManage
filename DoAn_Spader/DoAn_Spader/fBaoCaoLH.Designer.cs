namespace DoAn_Spader
{
    partial class fBaoCaoLH
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
            this.dataLopHoc = new DoAn_Spader.dataLopHoc();
            this.LOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTableAdapter = new DoAn_Spader.dataLopHocTableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LOPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(782, 726);
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
            // fBaoCaoLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 726);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoLH";
            this.Text = "Báo cáo các lớp học";
            this.Load += new System.EventHandler(this.fBaoCaoLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LOPBindingSource;
        private dataLopHoc dataLopHoc;
        private dataLopHocTableAdapters.LOPTableAdapter LOPTableAdapter;
    }
}