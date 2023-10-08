using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem mon01 = new ListViewItem(new string[] { "1", "Cafe đen đá","25000" });
            ListViewItem mon02 = new ListViewItem(new string[] { "2", "Cafe sữa đá", "35000" });
            ListViewItem mon03 = new ListViewItem(new string[] { "3", "Bạc sĩu", "40000" });


            // Thêm các sinh viên vào ListView
            lvDSMon.Items.AddRange(new ListViewItem[] { mon01, mon02, mon03 });

            // Tự động thích ứng độ rộng cột với nội dung
            lvDSMon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDSMon.Items)
            {
                if (item.Selected)
                {
                    if (lvDSMon.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedItem = lvDSMon.SelectedItems[0];

                        // Lấy thông tin món đã chọn
                        string tenmon = selectedItem.SubItems[0].Text;
                        decimal gia = decimal.Parse(selectedItem.SubItems[1].Text);
                        string ban = cbBan.SelectedItem?.ToString();
                        int soluong = (int)nudSoLuong.Value;

                        // Thêm món đã chọn cùng với giá chú vào ListView đặt món
                       // ListViewItem selectedFoodItem = new ListViewItem(new[] { tenmon, gia.ToString(), ban, soluong });
                       // lvDSDatMon.Items.Add(selectedFoodItem);
                    }


                }
            }
            
        }
    }
}
