
namespace QLKhachSan
{
    partial class FormReportHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.qLKhachSanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSanDataSet = new QLKhachSan.QLKhachSanDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // qLKhachSanDataSetBindingSource
            // 
            this.qLKhachSanDataSetBindingSource.DataSource = this.qLKhachSanDataSet;
            this.qLKhachSanDataSetBindingSource.Position = 0;
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.qLKhachSanDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKhachSan.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1089, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportHoaDon";
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource qLKhachSanDataSetBindingSource;
        private QLKhachSanDataSet qLKhachSanDataSet;
    }
}