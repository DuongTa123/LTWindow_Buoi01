using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaDangAnhDuong_2119110313
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDN.Text.Trim();
            string matkhau = MaHoa.ToShA1(txtMK.Text.Trim());
            ThanhVienDao tvDAO = new ThanhVienDao();
            ThanhVien thanhvien = tvDAO.getRow(tendn, matkhau);
            if(thanhvien  == null)
            {
                lblThongBao.Text = "Tài Khoản Không Chính Xác";
            }    
            else
            {
                frmMain.thanhvien = thanhvien;
                this.Close();
            }    
        }
    }
}
