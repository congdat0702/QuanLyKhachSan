using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSan
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = connection.getConnectString();
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.tblkhachhang' table. You can move, or remove it, as needed.
            this.tblkhachhangTableAdapter2.Fill(this.qLKhachSanDataSet.tblkhachhang);

            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            listThanhToan.Items.Clear();
            ketnoi.Open();
            sql = @"Select makh, tenkh, ngaysinh, cmnd,sdt From tblkhachhang";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThanhToan.Items.Add(docdulieu[0].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnTKTMKH_Click(object sender, EventArgs e)
        {
            listThanhToan.Items.Clear();
            ketnoi.Open();
            sql = "Select makh, tenkh, ngaysinh, cmnd,sdt From tblkhachhang Where(makh like'%" + cbmaKH.Text+"%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThanhToan.Items.Add(docdulieu[0].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThanhToan.Items[i].SubItems.Add(docdulieu[4].ToString());
                txthotenTT.Text = docdulieu[1].ToString();
                i++;
            }
            ketnoi.Close();
        }


        private void btnTinhTienTT_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = "Select tblphieudatphong.mapd, DATEDIFF(day, CONVERT(date, tblphieudatphong.ngayden), GETDATE()), DATEDIFF(day, CONVERT(date, tblphieudatphong.ngayden), GETDATE()) * tblphieudatphong.sotiendat, GETDATE() From tblphieudatphong WHERE  (tblphieudatphong.makh= N'" + cbmaKH.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                lbPhongSo.Text = docdulieu[0].ToString();
                lbSoNgayO.Text = docdulieu[1].ToString();
                lbTongTienTT.Text = docdulieu[2].ToString();
                lbNgayTT.Text = docdulieu[3].ToString();
            }
            ketnoi.Close();
            ketnoi.Open();
            sql= "Select tblkhachhang.makh,tblkhachhang.tenkh  From tblkhachhang WHERE  (tblkhachhang.makh= N'" + cbmaKH.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                lbMaKH.Text = docdulieu[0].ToString();
                lbTenKH.Text = docdulieu[1].ToString();
                txthotenTT.Text = docdulieu[1].ToString();
            }
            ketnoi.Close();
        }
        private void listThanhToan_Click(object sender, EventArgs e)
        {
            cbmaKH.Text = listThanhToan.SelectedItems[0].SubItems[0].Text;
            txthotenTT.Text = listThanhToan.SelectedItems[0].SubItems[1].Text;

        }

        private void btnThoatTT_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (f ==DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
                ketnoi.Open();
                sql = @"Insert Into tblhoadon(mahd, ngaythanhtoan, tongtien, mapt, makh)    VALUES  (N'" + txtMaHD.Text + @"',N'" + lbNgayTT.Text + @"',N'" + lbTongTienTT.Text + @"',N'" + lbPhongSo.Text + @"',N'" + lbMaKH.Text + @"')";
                if (txtMaHD.Text==null)
            {
            }    
                thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thêm Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thêm Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ketnoi.Close();
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
