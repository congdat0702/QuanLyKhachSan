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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection kenoi = new SqlConnection(connection.getConnectString());
            string userName = txttenDangnhap.Text;
            string passWord = txtmatKhau.Text;
            if (userName == null || userName.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passWord == null || passWord.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            kenoi.Open();
            string sql = "Select * From tbluser Where username='" + userName + "' and password='" + passWord + "'";
            SqlCommand thuchien = new SqlCommand(sql, kenoi);
            SqlDataReader docdl = thuchien.ExecuteReader();
            if (docdl.Read())
            {
                MessageBox.Show("Đăng nhập thành công!\nXin chào " + userName, "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frmMain = new frmMain();
                frmMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            kenoi.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
