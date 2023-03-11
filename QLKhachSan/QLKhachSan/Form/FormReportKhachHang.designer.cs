
namespace QLKhachSan
{
    partial class FormReportKhachHang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLKhachSanDataSet = new QLKhachSan.QLKhachSanDataSet();
            this.qLKhachSanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKhachSan.ReportKhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1398, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKhachSanDataSetBindingSource
            // 
            this.qLKhachSanDataSetBindingSource.DataSource = this.qLKhachSanDataSet;
            this.qLKhachSanDataSetBindingSource.Position = 0;
            // 
            // FormReportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.FormReportKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private System.Windows.Forms.BindingSource qLKhachSanDataSetBindingSource;
    }
}