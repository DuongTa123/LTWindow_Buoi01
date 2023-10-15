using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05_3
{
    public partial class Form1 : Form
    {
        
        string[] loaisanpham = { "Áo Nam", "Áo Nữ", "Vớ" };
        string[] donvitinh = { "Cái", "Đôi"};
        int rowchoose = 0;
        int rowindex = -1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = loaisanpham;
            cbDVTinh.DataSource = donvitinh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (txtMaSP.Text.Length <= 0)
                {
                    throw new Exception("Chưa Nhập Mã SP");
                }
                if (txtTenSP.Text.Length <= 2)
                {
                    throw new Exception(" Tên SP ít nhất 2 kí tự");
                }
                if (txtSoLuong.Text.Length <= 0)
                {
                    throw new Exception(" Số lượng sản phẩm ko hợp lệ");
                }
                if (int.Parse(txtGia.Text) < 1000)
                {
                    throw new Exception(" Giá ko hợp lệ ");
                }
               

                // Lấy thông tin
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string gia = txtGia.Text;
                string soluong = txtSoLuong.Text;
                string loaisp = cbLoaiSP.Text;
                string dvtinh = cbDVTinh.Text;
                int thanhtien = int.Parse(txtGia.Text) * int.Parse(txtSoLuong.Text);
                int row = dgvDanhSach.Rows.Add();
                // lưu data vào lưới
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["ThanhTien"].Value = thanhtien;
                dgvDanhSach.Rows[row].Cells["DVTinh"].Value = dvtinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            rowindex = e.RowIndex;
            if (rowindex != 1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();
                string loaisp = dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value.ToString();
                string dvitinh = dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value.ToString();
               
                int i = 0;
                while (i < loaisanpham.Length && loaisanpham[i] != loaisp 
                        && i < donvitinh.Length && donvitinh[i] != dvitinh)
                {
                    i++;
                }
                cbLoaiSP.SelectedIndex = i;
                cbDVTinh.SelectedIndex = i;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SP cần sửa");
                }
                if (txtMaSP.Text.Length <= 0)
                {
                    throw new Exception("Chưa Nhập Mã SP");
                }
                if (txtTenSP.Text.Length <= 2)
                {
                    throw new Exception(" Tên SP ít nhất 2 kí tự");
                }
                if (txtSoLuong.Text.Length <= 0)
                {
                    throw new Exception(" Số lượng sản phẩm ko hợp lệ");
                }
                if (int.Parse(txtGia.Text) < 1000)
                {
                    throw new Exception(" Giá ko hợp lệ ");
                }
                // Lấy thông tin
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string gia = txtGia.Text;
                string soluong = txtSoLuong.Text;
                string loaisp = cbLoaiSP.Text;
                string dvtinh = cbDVTinh.Text;
                int thanhtien = int.Parse(txtGia.Text) * int.Parse(txtSoLuong.Text);
                int row = dgvDanhSach.Rows.Add();
                // lưu data vào lưới
                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = thanhtien;
                dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value = dvtinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SP cần xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
