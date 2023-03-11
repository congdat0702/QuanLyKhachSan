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
    public partial class FormPhong : Form
    {
        public frmMain frmMain;

        private SqlDataAdapter adapter;
        private DataSet dataset;
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            LoadComboLoai();
            LoadDataPhong();
            LoadDataLoaiPhong();
        }

        private void LoadDataPhong()
        {
            SqlCommand cmd = new SqlCommand("DSPhong", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvp.DataSource = tb;
            gvp.ClearSelection();

        }
        private void LoadComboLoai()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tblloaiphong]", DataBase.GetConnection());
            dataset = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            if (dataset.Tables["maloai"]!=null)
            {
                dataset.Tables["maloai"].Clear();
            }
            adapter.Fill(dataset,"maloai");
            cbLoaiPhong.DataSource = dataset.Tables["maloai"];
            cbLoaiPhong.DisplayMember = "maloai";
           

        }
        private void ReadDataPhong()
        {
            if (gvp.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = gvp.SelectedRows[0];            
            txtMaphong.Text = row.Cells["Mã phòng"].Value.ToString();
        }
        private void LoadDataLoaiPhong()
        {
            SqlCommand cmd = new SqlCommand("DSLoaiPhong", DataBase.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            gvlp.DataSource = tb;
            gvlp.ClearSelection();
        }

    }
}
