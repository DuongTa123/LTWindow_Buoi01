using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Tên SV không để trống");
                }
                string hoten = txtHoTen.Text;
                string masv = txtMSSV.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                int stt = 1;
                if (cbDuLich.Checked)
                {
                    sothich += "Du lịch";
                }
                if (cbTheThao.Checked)
                {
                    sothich += "Thể thao";
                }
                if (cbMuaSam.Checked)
                {
                    sothich += "Mua sắm";
                }
                if (sothich != null)
                {
                    sothich = "Sở thích: " + sothich;
                }
                txtDS.Text += stt + ". Họ tên:" + hoten + " Ngày sinh: " + ngaysinh + " Giơi tính: " + gioitinh + sothich + "\r\n";
                stt++;
            } catch(Exception ex)
            {
                txtDS.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDS.Text = "";
        }
    }
}
