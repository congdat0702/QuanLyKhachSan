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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = connection.getConnectString();
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void FormTTKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.tblkhachhang' table. You can move, or remove it, as needed.
            //this.tblkhachhangTableAdapter2.Fill(this.qLKhachSanDataSet.tblkhachhang);

            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"Select makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu From tblkhachhang";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThongThinKH.Items.Add(docdulieu[0].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[4].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[5].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"Select makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu From tblkhachhang Where(makh like'%" + cbMaKH.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listThongThinKH.Items.Add(docdulieu[0].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[1].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[2].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[3].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[4].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[5].ToString());
                listThongThinKH.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listThongThinKH_Click(object sender, EventArgs e)
        {
            txtMkh.Text = listThongThinKH.SelectedItems[0].SubItems[0].Text;
            txtTenkh.Text = listThongThinKH.SelectedItems[0].SubItems[1].Text;
            cbGioiTinh.Text = listThongThinKH.SelectedItems[0].SubItems[2].Text;
            txtNgaysinh.Text = listThongThinKH.SelectedItems[0].SubItems[3].Text;
            txtCmnd.Text = listThongThinKH.SelectedItems[0].SubItems[4].Text;
            txtDiachi.Text = listThongThinKH.SelectedItems[0].SubItems[5].Text;
            txtSodt.Text = listThongThinKH.SelectedItems[0].SubItems[6].Text;
        }

        private bool check_ThongTinThem()
        {
            if (txtMkh.Text == "" || txtTenkh.Text == "" || cbGioiTinh.Text == "" || txtNgaysinh.Text == ""
                || txtCmnd.Text == "" || txtDiachi.Text == "" || txtSodt.Text == "" || txtGhichu.Text == "")
                return false;
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            if (check_ThongTinThem() == true)
            {
                if (txtCmnd.Text.Length != 9)
                {
                    MessageBox.Show("Chứng minh thư phải có 9 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else if (txtSodt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else
                {
                    string sql_check = @"SELECT COUNT(*) FROM dbo.tblkhachhang WHERE cmnd = N'" + txtCmnd.Text + "' OR sdt = N'" + txtSodt.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql_check, ketnoi);
                    try
                    {
                        object result = null;
                        result = cmd.ExecuteScalar();
                        int kq = (result == null) ? 0 : Convert.ToInt32(result);
                        if (kq > 0)
                        {
                            MessageBox.Show("CMND hoặc Số điện thoại đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            
                            sql = @"Insert Into tblkhachhang(makh, tenkh, gioitinh, ngaysinh, cmnd, diachi, sdt, ghichu)    VALUES  (N'"
                                            + txtMkh.Text + @"',N'" + txtTenkh.Text + @"',N'" + cbGioiTinh.Text + @"',N'"
                                            + txtNgaysinh.Text + @"',N'" + txtCmnd.Text + @"',N'" + txtDiachi.Text + @"',N'"
                                            + txtSodt.Text + @"',N'" + txtGhichu.Text + @"')";
                            thuchien = new SqlCommand(sql, ketnoi);
                            try
                            {
                                thuchien.ExecuteNonQuery();
                                MessageBox.Show("Thành công", "Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }

                            catch
                            {
                                MessageBox.Show("Thêm thông tin không thành công");
                            }
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra\r\n" + ex.Message);
                    }
                }    
                
            } 
            else
            {
                MessageBox.Show("Các trường thông tin không được trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            ketnoi.Close();
            hienthi();
        }

        //private bool CheckValidate()
        //{

        //    long sdt;
        //    int cmnd;

        //    if (string.IsNullOrWhiteSpace(txtMkh.Text))
        //    {
        //        MessageBox.Show("Chưa nhập họ tên người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtTenkh.Text))
        //    {
        //        MessageBox.Show("Chưa nhập CMND người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(cbGioiTinh.Text))
        //    {
        //        MessageBox.Show("Chưa nhập CMND người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtNgaysinh.Text))
        //    {
        //        MessageBox.Show("Chưa nhập CMND người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    if (!(Int32.TryParse(txtCmnd.Text, out cmnd) && txtCmnd.Text.Length == 9))
        //    {
        //        MessageBox.Show("Nhập sai CMND người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtSodt.Text))
        //    {
        //        MessageBox.Show("Chưa nhập số điện thoại người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(txtDiachi.Text))
        //    {
        //        MessageBox.Show("Chưa nhập địa chỉ người tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    else
        //    {
        //        if ((Int64.TryParse(txtSodt.Text, out sdt) && (txtSodt.Text.Length >= 9 && txtSodt.Text.Length <= 10)))
        //        {
        //            return true;
        //        }

        //        else
        //        {
        //            MessageBox.Show("Nhập sai số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }
        //    }

        //}
        private void btnSua_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE tblkhachhang SET makh = N'" + txtMkh.Text + @"', tenkh = N'" + txtTenkh.Text + @"', gioitinh = N'" + cbGioiTinh.Text + @"', ngaysinh = N'" + txtNgaysinh.Text + @"', cmnd = N'" + txtCmnd.Text + @"', diachi = N'" + txtDiachi.Text + @"', sdt = N'" + txtSodt.Text + @"', ghichu = N'" + txtGhichu.Text + "'    WHERE   (makh = N'" + txtMkh.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Sửa Thông Tinh Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listThongThinKH.Items.Clear();
            ketnoi.Open();
            sql = "Delete From tblkhachhang  WHERE   (makh=N'" + txtMkh.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            try
            {

                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Xóa Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            ketnoi.Close();
            hienthi();
        }


        private void txtCmnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCmnd.Text.Length != 9)
                {
                    MessageBox.Show("Chứng minh thư phải có 9 số","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void txtCmnd_Leave(object sender, EventArgs e)
        {
            if (txtCmnd.Text.Length != 9)
            {
                MessageBox.Show("Chứng minh thư phải có 9 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSodt_Leave(object sender, EventArgs e)
        {
            if (txtSodt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void txtSodt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSodt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
