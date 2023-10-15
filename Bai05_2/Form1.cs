using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05_2
{

    public partial class Form1 : Form
    {
        string[] danhsachkhoa = { "CNTT", "QTKD", "DTVT" };
        int rowchoose = 0;
        int rowindex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = danhsachkhoa;        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (txtMSSV.Text.Length != 10)
                {
                    throw new Exception("MSSV phải đúng 10 kí tự");
                }
                if (this.checkMSSV(txtMSSV.Text)==false)
                {
                    throw new Exception("MSSV đã tồn tại");
                }
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }    
                if(!double.TryParse(txtDTB.Text, out diemtb))
                {
                    throw new Exception("Điểm Trung Bình Không Phải Số");
                }    
                // Lấy thông tin
                string masv = txtMSSV.Text;
                string hoten = txtHoTen.Text;
                
                string khoa = cbKhoa.Text;
                int row = dgvDanhSach.Rows.Add();
                // lưu data vào lưới
                dgvDanhSach.Rows[row].Cells["MSSV"].Value = masv;
                dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["DTB"].Value = diemtb;
                dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool checkMSSV(string masv)
        {
            if(dgvDanhSach.Rows.Count ==0)
            {
                return true;
            }    
            for(int row = 0; row < dgvDanhSach.Rows.Count -1; row++)
            {
                if(dgvDanhSach.Rows[row].Cells["MSSV"].Value.ToString()==masv)
                {
                    return false;
                }    
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if(rowindex !=1 && rowindex < dgvDanhSach.Rows.Count -1)
            {
                txtMSSV.Text = dgvDanhSach.Rows[rowindex].Cells["MSSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                txtDTB.Text = dgvDanhSach.Rows[rowindex].Cells["DTB"].Value.ToString();
                string tenkhoa = dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while(i<danhsachkhoa.Length && danhsachkhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbKhoa.SelectedIndex = i;
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex>=dgvDanhSach.Rows.Count -1)
                {
                    throw new Exception("Chưa chọn Sv cần sửa");
                }
                if (txtMSSV.Text.Length.Equals(10))
                {
                    throw new Exception("MSSV Phải đủ 10 kí tự");
                }
                if (this.checkMSSV(txtMSSV.Text) == false && txtMSSV.Text != dgvDanhSach.Rows[rowindex].Cells["MSSV"].Value.ToString())
                {
                    throw new Exception("MSSV đã tồn tại");
                }
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                if (!double.TryParse(txtDTB.Text, out diemtb))
                {
                    throw new Exception("Điểm Trung Bình Không Phải Số");
                }
                // Lấy thông tin
                string masv = txtMSSV.Text;
                string hoten = txtHoTen.Text;

                string khoa = cbKhoa.Text;
                int row = dgvDanhSach.Rows.Add();
                // lưu data vào lưới
                dgvDanhSach.Rows[rowindex].Cells["MSSV"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["DTB"].Value = diemtb;
                dgvDanhSach.Rows[rowindex].Cells["Khoa"].Value = khoa;
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
                    throw new Exception("Chưa chọn Sv cần xóa");
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
    }
}
