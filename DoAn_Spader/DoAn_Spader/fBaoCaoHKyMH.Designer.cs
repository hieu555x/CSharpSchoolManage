namespace DoAn_Spader
{
    partial class fBaoCaoHKyMH
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
            this.fBaoCaoHKMH = new DoAn_Spader.fBaoCaoHKMH();
            this.KQ_HOC_KY_MON_HOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KQ_HOC_KY_MON_HOCTableAdapter = new DoAn_Spader.fBaoCaoHKMHTableAdapters.KQ_HOC_KY_MON_HOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fBaoCaoHKMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_HOC_KY_MON_HOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KQ_HOC_KY_MON_HOCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Spader.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1186, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // fBaoCaoHKMH
            // 
            this.fBaoCaoHKMH.DataSetName = "fBaoCaoHKMH";
            this.fBaoCaoHKMH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KQ_HOC_KY_MON_HOCBindingSource
            // 
            this.KQ_HOC_KY_MON_HOCBindingSource.DataMember = "KQ_HOC_KY_MON_HOC";
            this.KQ_HOC_KY_MON_HOCBindingSource.DataSource = this.fBaoCaoHKMH;
            // 
            // KQ_HOC_KY_MON_HOCTableAdapter
            // 
            this.KQ_HOC_KY_MON_HOCTableAdapter.ClearBeforeFill = true;
            // 
            // fBaoCaoHKyMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 675);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBaoCaoHKyMH";
            this.Text = "Kết quả học sinh theo môn học";
            this.Load += new System.EventHandler(this.fBaoCaoHKyMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fBaoCaoHKMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KQ_HOC_KY_MON_HOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KQ_HOC_KY_MON_HOCBindingSource;
        private fBaoCaoHKMH fBaoCaoHKMH;
        private fBaoCaoHKMHTableAdapters.KQ_HOC_KY_MON_HOCTableAdapter KQ_HOC_KY_MON_HOCTableAdapter;
    }
}