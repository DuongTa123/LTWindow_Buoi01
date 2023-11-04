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
    public partial class Form1 : Form
    {
        string[] DSLoaiSach = { "Công nghệ thông tin", "Kế toán", "Kỹ năng sống" };
        string[] DSNgonNgu = { "Tiếng Việt", "Tiếng Anh"};
        int rowchoose = 0;
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDS();
        }
        private void loadDS()
        {
            cbLoaiSach.DataSource = DSLoaiSach;
            cbNgonNgu.DataSource = DSNgonNgu;
            cbLoaiSach.SelectedItem = 0;
            cbNgonNgu.SelectedItem = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSach.Text.Length <=0)
                {
                    throw new Exception("Chưa nhập tên sách");
                }
                if (txtTacGia.Text.Length < 2)
                {
                    throw new Exception("Họ Tên Tác Giả ít nhất 2 kí tự");
                }
                // Lấy thông tin
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string loaisach = cbLoaiSach.Text;
                string ngonngu = cbNgonNgu.Text;
                // lưu data vào lưới
                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowindex].Cells["TenSach"].Value = tensach;
                dgvDanhSach.Rows[rowindex].Cells["TacGia"].Value = tacgia;
                dgvDanhSach.Rows[rowindex].Cells["TenLoaiSach"].Value = loaisach;
                dgvDanhSach.Rows[rowindex].Cells["NgonNgu"].Value = ngonngu;
                dgvDanhSach.Rows[rowindex].Cells["MaSach"].Value = dgvDanhSach.Rows.Count-1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa Chọn Sách cần sửa");
                }
                if (txtTenSach.Text.Length <= 0)
                {
                    throw new Exception("Chưa nhập tên sách");
                }
                if (txtTacGia.Text.Length < 2)
                {
                    throw new Exception("Họ Tên Tác Giả ít nhất 2 kí tự");
                }
                // Lấy thông tin
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string loaisach = cbLoaiSach.Text;
                string ngonngu = cbNgonNgu.Text;
                // lưu data vào lưới
                int rowindex = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[rowchoose].Cells["TenSach"].Value = tensach;
                dgvDanhSach.Rows[rowchoose].Cells["TacGia"].Value = tacgia;
                dgvDanhSach.Rows[rowchoose].Cells["TenLoaiSach"].Value = loaisach;
                dgvDanhSach.Rows[rowchoose].Cells["NgonNgu"].Value = ngonngu;
               
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
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa Chọn Sách cần xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa Chọn Sách");
                }
                rowchoose = e.RowIndex;
                txtTenSach.Text = dgvDanhSach.Rows[rowchoose].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dgvDanhSach.Rows[rowchoose].Cells["TacGia"].Value.ToString();
                cbLoaiSach.Text = dgvDanhSach.Rows[rowchoose].Cells["TenLoaiSach"].Value.ToString();
                cbNgonNgu.Text = dgvDanhSach.Rows[rowchoose].Cells["NgonNgu"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
