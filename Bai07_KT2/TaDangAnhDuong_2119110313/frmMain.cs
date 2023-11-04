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
    public partial class frmMain : Form
    {
        public static ThanhVien thanhvien = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(thanhvien == null)
            {
                Form frmdn = new frmLogin();
                frmdn.ShowDialog();
            }  
            //if(thanhvien != null)
            //{
            //    ToolStripStatusLabelThanhVien.text = thanhvien.TenDN;
            //    tabControlMain.ImageList = LoadImagesList();
            //}    
        }
    }
}
