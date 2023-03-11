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
    public partial class FormReportHoaDon : Form
    {
      
        public FormReportHoaDon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.tblhoadon' table. You can move, or remove it, as needed.
           // this.tblhoadonTableAdapter.Fill(this.qLKhachSanDataSet.tblhoadon);


            QLKhachSanEntities DB = new QLKhachSanEntities();

            string DATE = DateTime.Now.ToString("dd/MM/yyyy"); 
         //  qLKhachSanDataSetBindingSource.DataSource = DB.tblhoadon.Where(x=>x.ngaythanhtoan.Contains(DATE)).ToList();
            qLKhachSanDataSetBindingSource.DataSource = DB.tblhoadon.ToList();
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Date",DATE) 
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
