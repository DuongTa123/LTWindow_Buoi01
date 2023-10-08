
namespace Bai04_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDSSV = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnChonSV = new System.Windows.Forms.Button();
            this.btnXoa1SV = new System.Windows.Forms.Button();
            this.btnChonAllSV = new System.Windows.Forms.Button();
            this.btnXoaAllSV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvSVDuocChon = new System.Windows.Forms.ListView();
            this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(730, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(529, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(386, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDSSV);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // lbDSSV
            // 
            this.lbDSSV.FormattingEnabled = true;
            this.lbDSSV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDSSV.ItemHeight = 16;
            this.lbDSSV.Location = new System.Drawing.Point(6, 35);
            this.lbDSSV.Name = "lbDSSV";
            this.lbDSSV.Size = new System.Drawing.Size(240, 372);
            this.lbDSSV.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.btnChonSV);
            this.groupBox3.Controls.Add(this.btnXoa1SV);
            this.groupBox3.Controls.Add(this.btnChonAllSV);
            this.groupBox3.Controls.Add(this.btnXoaAllSV);
            this.groupBox3.Location = new System.Drawing.Point(270, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 420);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Khoa";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Quản trị kinh doanh",
            "Kế toán",
            "Công nghệ sửa chữa oto"});
            this.cbKhoa.Location = new System.Drawing.Point(6, 81);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(216, 24);
            this.cbKhoa.TabIndex = 8;
            // 
            // btnChonSV
            // 
            this.btnChonSV.Location = new System.Drawing.Point(49, 139);
            this.btnChonSV.Name = "btnChonSV";
            this.btnChonSV.Size = new System.Drawing.Size(130, 35);
            this.btnChonSV.TabIndex = 7;
            this.btnChonSV.Text = ">";
            this.btnChonSV.UseVisualStyleBackColor = true;
            this.btnChonSV.Click += new System.EventHandler(this.btnChonSV_Click);
            // 
            // btnXoa1SV
            // 
            this.btnXoa1SV.Location = new System.Drawing.Point(49, 279);
            this.btnXoa1SV.Name = "btnXoa1SV";
            this.btnXoa1SV.Size = new System.Drawing.Size(130, 35);
            this.btnXoa1SV.TabIndex = 6;
            this.btnXoa1SV.Text = "<";
            this.btnXoa1SV.UseVisualStyleBackColor = true;
            this.btnXoa1SV.Click += new System.EventHandler(this.btnXoa1SV_Click);
            // 
            // btnChonAllSV
            // 
            this.btnChonAllSV.Location = new System.Drawing.Point(49, 207);
            this.btnChonAllSV.Name = "btnChonAllSV";
            this.btnChonAllSV.Size = new System.Drawing.Size(130, 35);
            this.btnChonAllSV.TabIndex = 5;
            this.btnChonAllSV.Text = ">>";
            this.btnChonAllSV.UseVisualStyleBackColor = true;
            this.btnChonAllSV.Click += new System.EventHandler(this.btnChonAllSV_Click);
            // 
            // btnXoaAllSV
            // 
            this.btnXoaAllSV.Location = new System.Drawing.Point(49, 354);
            this.btnXoaAllSV.Name = "btnXoaAllSV";
            this.btnXoaAllSV.Size = new System.Drawing.Size(130, 35);
            this.btnXoaAllSV.TabIndex = 4;
            this.btnXoaAllSV.Text = "<<";
            this.btnXoaAllSV.UseVisualStyleBackColor = true;
            this.btnXoaAllSV.Click += new System.EventHandler(this.btnXoaAllSV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvSVDuocChon);
            this.groupBox4.Location = new System.Drawing.Point(504, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 420);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // lvSVDuocChon
            // 
            this.lvSVDuocChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.khoa,
            this.hoten});
            this.lvSVDuocChon.GridLines = true;
            this.lvSVDuocChon.HideSelection = false;
            this.lvSVDuocChon.Location = new System.Drawing.Point(6, 35);
            this.lvSVDuocChon.Name = "lvSVDuocChon";
            this.lvSVDuocChon.Size = new System.Drawing.Size(408, 372);
            this.lvSVDuocChon.TabIndex = 0;
            this.lvSVDuocChon.UseCompatibleStateImageBehavior = false;
            this.lvSVDuocChon.View = System.Windows.Forms.View.Details;
            // 
            // hoten
            // 
            this.hoten.DisplayIndex = 0;
            this.hoten.Text = "Họ Tên";
            this.hoten.Width = 205;
            // 
            // khoa
            // 
            this.khoa.DisplayIndex = 1;
            this.khoa.Text = "Khoa";
            this.khoa.Width = 205;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDSSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnChonSV;
        private System.Windows.Forms.Button btnXoa1SV;
        private System.Windows.Forms.Button btnChonAllSV;
        private System.Windows.Forms.Button btnXoaAllSV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvSVDuocChon;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader khoa;
    }
}

