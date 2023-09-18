namespace DoAn_Spader
{
    partial class fBaoCaoCNMH
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
            this.dataCNMH = new DoAn_Spader.dataCNMH();
            this.KQ_CA_NAM_MON_HOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KQ_CA_NAM_MON_HOCTableAdapter = new DoAn_Spader.dataCNMHTableAdapters.KQ_CA_NAM_MON_HOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataCNMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_CA_NAM_MON_HOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KQ_CA_NAM_MON_HOCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1071, 678);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataCNMH
            // 
            this.dataCNMH.DataSetName = "dataCNMH";
            this.dataCNMH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KQ_CA_NAM_MON_HOCBindingSource
            // 
            this.KQ_CA_NAM_MON_HOCBindingSource.DataMember = "KQ_CA_NAM_MON_HOC";
            this.KQ_CA_NAM_MON_HOCBindingSource.DataSource = this.dataCNMH;
            // 
            // KQ_CA_NAM_MON_HOCTableAdapter
            // 
            this.KQ_CA_NAM_MON_HOCTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCaoCNMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 678);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoCNMH";
            this.Text = "Kết quả cả năm theo môn học";
            this.Load += new System.EventHandler(this.fBaoCaoCNMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCNMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_CA_NAM_MON_HOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KQ_CA_NAM_MON_HOCBindingSource;
        private dataCNMH dataCNMH;
        private dataCNMHTableAdapters.KQ_CA_NAM_MON_HOCTableAdapter KQ_CA_NAM_MON_HOCTableAdapter;
    }
}