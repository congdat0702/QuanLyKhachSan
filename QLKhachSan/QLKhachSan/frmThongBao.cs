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
    public partial class frmThongBao : Form
    {
        public frmThongBao()
        {
            InitializeComponent();
        }
        private void frmThongBao_Load(object sender, EventArgs e)
        {
            ptbThongbao.Image = QLKhachSan.Properties.Resources.thongbaoBT;
        }
    }
}
