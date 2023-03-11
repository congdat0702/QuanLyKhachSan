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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = connection.getConnectString();
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            listHoaDon.Items.Clear();
            ketnoi.Open();
            sql = @"Select mahd, ngaythanhtoan, tongtien, mapt, makh From tblhoadon";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listHoaDon.Items.Add(docdulieu[0].ToString());
                listHoaDon.Items[i].SubItems.Add(docdulieu[1].ToString());
                listHoaDon.Items[i].SubItems.Add(docdulieu[2].ToString());
                listHoaDon.Items[i].SubItems.Add(docdulieu[3].ToString());
                listHoaDon.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = listHoaDon.SelectedItems[0].SubItems[0].Text;
            txtNgayTT.Text = listHoaDon.SelectedItems[0].SubItems[1].Text;
            txtTongTien.Text = listHoaDon.SelectedItems[0].SubItems[2].Text;
            txtMaPhongHD.Text = listHoaDon.SelectedItems[0].SubItems[3].Text;
            txtMaKH.Text = listHoaDon.SelectedItems[0].SubItems[4].Text;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            listHoaDon.Items.Clear();
            ketnoi.Open();
            sql = @"Insert Into tblhoadon(mahd, ngaythanhtoan, tongtien, mapt, makh)    VALUES  (N'"+txtMaHD.Text+ @"',N'" + txtNgayTT.Text + @"',N'" + txtTongTien.Text + @"',N'" + txtMaPhongHD.Text + @"',N'" + txtMaKH.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            listHoaDon.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE tblhoadon SET mahd = N'"+txtMaHD.Text+@"', ngaythanhtoan = N'"+txtNgayTT.Text+@"', tongtien = N'"+txtTongTien.Text+@"', mapt=N'"+txtMaPhongHD.Text+@"', makh=N'"+txtMaKH.Text+@"'    WHERE   (mahd=N'"+txtMaHD.Text+@"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Sửa Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            listHoaDon.Items.Clear();
            ketnoi.Open();
            sql = @"Delete From tblhoadon  WHERE   (mahd=N'" + txtMaHD.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {
                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Xóa Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }
    }
}
