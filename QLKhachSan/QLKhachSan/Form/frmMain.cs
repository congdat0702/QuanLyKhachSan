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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MainEnabled();
        }

        private void MainEnabled()
        {
            mnstripHeThong.Enabled = true;
            mnstripQLKhachHang.Enabled = true;
            mnitemDanhSachKH.Enabled = true;
            mnitemDatPhong.Enabled = true;
            mnitemDanhSachHD.Enabled = true;
            mnitemThanhToan.Enabled = true;
        }
        private void MainNoEnabled()
        {
            mnstripHeThong.Enabled = false;
            mnstripQLKhachHang.Enabled = false;
            mnitemDanhSachKH.Enabled = false;
            mnitemDatPhong.Enabled = false;
            mnitemDanhSachHD.Enabled = false;
            mnitemThanhToan.Enabled = false;

        }

        public void mnitemThongTinKH_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKhachHang = new FormKhachHang();
            frmKhachHang.ShowDialog();
        }

        private void mnitemThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan ftt = new frmThanhToan();
            ftt.ShowDialog();
        }

        private void mnitemDatPhong_Click(object sender, EventArgs e)
        {
            FormDatPhong fdp = new FormDatPhong();
            fdp.ShowDialog();
        }


        private void mnitemPhong_Click(object sender, EventArgs e)
        {
            FormPhong ph = new FormPhong();
            ph.ShowDialog();
        }

        private void mnitemHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }


        private void mnitemDoiMK_Click(object sender, EventArgs e)
        {
            FormDoiMK dmk = new FormDoiMK();
            dmk.ShowDialog();
        }

        private void mnitemDangXuat_Click(object sender, EventArgs e)
        {
            MainNoEnabled();
            FormLogin dn = new FormLogin();
            dn.ShowDialog();
            Hide();
        }

        private void mnitemThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (f == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void mnstripTroGiup_Click(object sender, EventArgs e)
        {
            FormThongTin frmThongTin = new FormThongTin();
            frmThongTin.ShowDialog();
        }

        private void mnstripHeThong_Click(object sender, EventArgs e)
        {

        }

        private void mnitemDanhSachKH_Click(object sender, EventArgs e)
        {
            FormReportKhachHang frmThongTin = new FormReportKhachHang();
            frmThongTin.ShowDialog();
        }

        private void mnitemDanhSachHD_Click(object sender, EventArgs e)
        {
            FormReportHoaDon frmThongTin = new FormReportHoaDon();
            frmThongTin.ShowDialog();
        }
    }
}
