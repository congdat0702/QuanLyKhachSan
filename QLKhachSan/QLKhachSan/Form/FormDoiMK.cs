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
using System.Data;

namespace QLKhachSan
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection ketnoi = new SqlConnection(connection.getConnectString());
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) From tbluser Where username= N'"+txtTenDN.Text+"' and password= N'"+txtMkc.Text+"'",ketnoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtMkm.Text == txtMkm2.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Update tbluser set password = N'"+txtMkm.Text+"' Where username= N'"+txtTenDN.Text+ "' and password = N'" + txtMkc.Text +"'", ketnoi);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Thành công", "Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    errorProvider1.SetError(txtMkm, "Bạn chưa điền mật khẩu !");
                    errorProvider1.SetError(txtMkm2, "Mật khẩu mới chưa đúng !");
                }
            }
            else
            {
                errorProvider1.SetError(txtTenDN, "Tên đăng nhập sai !");
                errorProvider1.SetError(txtMkc, "Mật khẩu cũ sai !");
            }
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
