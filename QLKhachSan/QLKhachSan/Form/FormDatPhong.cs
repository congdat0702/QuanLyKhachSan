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
using System.Collections;

namespace QLKhachSan
{

    public partial class FormDatPhong : Form
    {
        private SqlDataAdapter adapter;
        private DataSet dataset;

        public double tongtien;
        public FormKhachHang frmKH;
        public frmMain frmMain;
        public string maphieudat;
        public string khachhang = "";

        public FormDatPhong()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = connection.getConnectString();
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            LoadComboKH();
            LoadCTKH();
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
            hienthiLP();

    }
        public void hienthi()
        {
            listDanhSachDP.Items.Clear();
            ketnoi.Open();
            sql = @"Select mapd, makh, ngayden, sotiendat, songuoi From tblphieudatphong";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listDanhSachDP.Items.Add(docdulieu[0].ToString());
                listDanhSachDP.Items[i].SubItems.Add(docdulieu[1].ToString());
                listDanhSachDP.Items[i].SubItems.Add(docdulieu[2].ToString());
                listDanhSachDP.Items[i].SubItems.Add(docdulieu[3].ToString());
                listDanhSachDP.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }
        public void hienthiLP()
        {
            listDSLoaiPhong.Items.Clear();
            ketnoi.Open();
            sql = @"Select maloai, songuoi, gia From tblloaiphong";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listDSLoaiPhong.Items.Add(docdulieu[0].ToString());
                listDSLoaiPhong.Items[i].SubItems.Add(docdulieu[1].ToString());
                listDSLoaiPhong.Items[i].SubItems.Add(docdulieu[2].ToString());
                i++;
            }
            ketnoi.Close();
        }
        private void LoadComboKH()
        {
            SqlCommand cmd = new SqlCommand("SELECT makh, tenkh FROM tblkhachhang", DataBase.GetConnection());
            dataset = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            if (dataset.Tables != null)
            {
                dataset.Tables.Clear();
            }
            adapter.Fill(dataset, "makh");
            cbkh.DataSource = dataset.Tables["makh"];
            cbkh.DisplayMember = "tenkh";
            cbkh.ValueMember = "makh";
            
        }
       

        private void cbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSonguoi.Clear();
            txtTienphong.Clear();

            SqlCommand cmd = new SqlCommand("TimKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", cbkh.SelectedValue.ToString());
            adapter = new SqlDataAdapter(cmd);
            dataset = new DataSet();
            if (dataset.Tables != null)
            {
                dataset.Tables.Clear();
            }
            adapter.Fill(dataset);
            LoadCTKH();
        }
        public void LoadCTKH()
        {
            string makh = cbkh.SelectedValue.ToString();
            txtSonguoi.Clear();
            txtTienphong.Clear();
           
            SqlCommand cmd = new SqlCommand("TimKH", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
               
            }
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DatPhong", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            if (txtmapd.Text != "" && txtSonguoi.Text != "")
            {
                cmd.Parameters.AddWithValue("@mapd", txtmapd.Text);
                cmd.Parameters.AddWithValue("@makh", cbkh.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ngayden", txtNgayDen.Text);
                cmd.Parameters.AddWithValue("@ngaydi", txtNgayDi.Text);
                cmd.Parameters.AddWithValue("@sotiendat", txtTienphong.Text);
                cmd.Parameters.AddWithValue("@tinhtrang", "chờ");
                cmd.Parameters.AddWithValue("@songuoi", txtSonguoi.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Thành công", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (SqlException exc)
                {
                    if (exc.Number == 2627)
                    {
                        MessageBox.Show("Mã Phòng Đã Tồn Tại", "Đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xác định:\n" + exc.Message, "Lỗi" + exc.Number, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void listDSLoaiPhong_Click(object sender, EventArgs e)
        {
            txtTienphong.Text = listDSLoaiPhong.SelectedItems[0].SubItems[2].Text;
            txtSonguoi.Text = listDSLoaiPhong.SelectedItems[0].SubItems[1].Text;
        }
    }
}
