using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int chon = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDSSV.Items.Add("Nguyễn Văn A");
            lbDSSV.Items.Add("Nguyễn Văn B");
            lbDSSV.Items.Add("Nguyễn Văn C");
            lbDSSV.Items.Add("Nguyễn Văn D");
            lbDSSV.Items.Add("Nguyễn Văn E");
            cbKhoa.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception(" Họ tên chưa nhập");
                }
                string hoten = txtHoTen.Text;
                lbDSSV.Items.Add(hoten);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonSV_Click(object sender, EventArgs e)
        {
            if(chon != -1)
            {
                string hoten = lbDSSV.SelectedItem.ToString();
                string khoa = cbKhoa.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(khoa);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hoten });
                lvSVDuocChon.Items.Add(item);
                lbDSSV.Items.RemoveAt(lbDSSV.SelectedIndex);
                chon = -1;
            }    
        }

        private void btnChonAllSV_Click(object sender, EventArgs e)
        {
            int count = lbDSSV.Items.Count;
            for(int vt = 0; vt < count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString();
                string hoten = lbDSSV.Items[vt].ToString();
                ListViewItem item = new ListViewItem(khoa);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = hoten });
                lvSVDuocChon.Items.Add(item);
            }
            lbDSSV.Items.Clear();
        }

        private void btnXoa1SV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvSVDuocChon .Items)
            {
                if(item.Selected)
                {
                    lvSVDuocChon.Items.Remove(item);
                    lbDSSV.Items.Add(item.Text);
                }    
            }    
        }

        private void btnXoaAllSV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSVDuocChon.Items)
            {
                 lvSVDuocChon.Items.Remove(item);
                 lbDSSV.Items.Add(item.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
