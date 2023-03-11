using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKhachSan
{
    public partial class FormReportKhachHang : Form
    {
        public FormReportKhachHang()
        {
            InitializeComponent();
        }

        private void FormReportKhachHang_Load(object sender, EventArgs e)
        {
            QLKhachSanEntities DB = new QLKhachSanEntities();

            string DATE = DateTime.Now.ToString("dd/MM/yyyy");

            // var HDS= DB.tblhoadon.Where(x => x.ngaythanhtoan.Contains(DATE)).Select(X=>X.makh).Distinct().ToList();
            //var HDS = DB.tblhoadon.Select(X => X.makh).Distinct().ToList();
            //  qL/KhachSanDataSetBindingSource.DataSource = DB.tblkhachhang.Where(X => HDS.Contains(X.makh)).ToList();
            //   Customers dsCustomers = GetData("select top 20 * from customers");
            ReportDataSource datasource = new ReportDataSource("DataSet1", DB.tblkhachhang.ToList());

            qLKhachSanDataSetBindingSource.DataSource = DB.tblkhachhang.ToList();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Date",DATE)
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

        }
    }
}
