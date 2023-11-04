
namespace TaDangAnhDuong_2119110313
{
    partial class frmMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabQuanLysach = new System.Windows.Forms.TabControl();
            this.TapLoaiSach = new System.Windows.Forms.TabPage();
            this.tabSach = new System.Windows.Forms.TabPage();
            this.tabThanhVien = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabQuanLysach.SuspendLayout();
            this.TapLoaiSach.SuspendLayout();
            this.tabSach.SuspendLayout();
            this.tabThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai});
            this.dataGridView1.Location = new System.Drawing.Point(6, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 306);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabQuanLysach
            // 
            this.tabQuanLysach.Controls.Add(this.TapLoaiSach);
            this.tabQuanLysach.Controls.Add(this.tabSach);
            this.tabQuanLysach.Controls.Add(this.tabThanhVien);
            this.tabQuanLysach.Location = new System.Drawing.Point(1, 0);
            this.tabQuanLysach.Name = "tabQuanLysach";
            this.tabQuanLysach.SelectedIndex = 0;
            this.tabQuanLysach.Size = new System.Drawing.Size(920, 527);
            this.tabQuanLysach.TabIndex = 7;
            // 
            // TapLoaiSach
            // 
            this.TapLoaiSach.Controls.Add(this.label8);
            this.TapLoaiSach.Controls.Add(this.label7);
            this.TapLoaiSach.Controls.Add(this.textBox8);
            this.TapLoaiSach.Controls.Add(this.textBox7);
            this.TapLoaiSach.Controls.Add(this.button9);
            this.TapLoaiSach.Controls.Add(this.button10);
            this.TapLoaiSach.Controls.Add(this.button11);
            this.TapLoaiSach.Controls.Add(this.button12);
            this.TapLoaiSach.Controls.Add(this.dataGridView1);
            this.TapLoaiSach.Location = new System.Drawing.Point(4, 25);
            this.TapLoaiSach.Name = "TapLoaiSach";
            this.TapLoaiSach.Padding = new System.Windows.Forms.Padding(3);
            this.TapLoaiSach.Size = new System.Drawing.Size(912, 498);
            this.TapLoaiSach.TabIndex = 0;
            this.TapLoaiSach.Text = "Loại Sách";
            this.TapLoaiSach.UseVisualStyleBackColor = true;
            // 
            // tabSach
            // 
            this.tabSach.Controls.Add(this.groupBox1);
            this.tabSach.Controls.Add(this.button5);
            this.tabSach.Controls.Add(this.button6);
            this.tabSach.Controls.Add(this.button7);
            this.tabSach.Controls.Add(this.button8);
            this.tabSach.Controls.Add(this.dataGridView2);
            this.tabSach.Location = new System.Drawing.Point(4, 25);
            this.tabSach.Name = "tabSach";
            this.tabSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabSach.Size = new System.Drawing.Size(912, 498);
            this.tabSach.TabIndex = 1;
            this.tabSach.Text = "Sách";
            this.tabSach.UseVisualStyleBackColor = true;
            // 
            // tabThanhVien
            // 
            this.tabThanhVien.Controls.Add(this.button4);
            this.tabThanhVien.Controls.Add(this.button3);
            this.tabThanhVien.Controls.Add(this.button2);
            this.tabThanhVien.Controls.Add(this.button1);
            this.tabThanhVien.Controls.Add(this.label2);
            this.tabThanhVien.Controls.Add(this.label1);
            this.tabThanhVien.Controls.Add(this.textBox2);
            this.tabThanhVien.Controls.Add(this.textBox1);
            this.tabThanhVien.Controls.Add(this.dataGridView3);
            this.tabThanhVien.Location = new System.Drawing.Point(4, 25);
            this.tabThanhVien.Name = "tabThanhVien";
            this.tabThanhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanhVien.Size = new System.Drawing.Size(912, 498);
            this.tabThanhVien.TabIndex = 2;
            this.tabThanhVien.Text = "Thành Viên";
            this.tabThanhVien.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.MaLoaiSach,
            this.NamXB});
            this.dataGridView2.Location = new System.Drawing.Point(3, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(902, 292);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTV,
            this.TenDN,
            this.MatKhau});
            this.dataGridView3.Location = new System.Drawing.Point(7, 136);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(898, 352);
            this.dataGridView3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(783, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(789, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(538, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 35);
            this.button6.TabIndex = 11;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(281, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 139);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tác Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Loại";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(325, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(570, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(322, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(570, 26);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(322, 22);
            this.textBox6.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(790, 123);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 35);
            this.button9.TabIndex = 16;
            this.button9.Text = "Thoát";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(539, 123);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 35);
            this.button10.TabIndex = 15;
            this.button10.Text = "Sửa";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(282, 123);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 35);
            this.button11.TabIndex = 14;
            this.button11.Text = "Xóa";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 123);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(99, 35);
            this.button12.TabIndex = 13;
            this.button12.Text = "Thêm";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(169, 24);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(603, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(169, 66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(603, 22);
            this.textBox8.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã Loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên Loại";
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên Loại ";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // TacGia
            // 
            this.TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            // 
            // MaLoaiSach
            // 
            this.MaLoaiSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiSach.DataPropertyName = "MaLoai";
            this.MaLoaiSach.HeaderText = "Mã Loại";
            this.MaLoaiSach.MinimumWidth = 6;
            this.MaLoaiSach.Name = "MaLoaiSach";
            // 
            // NamXB
            // 
            this.NamXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamXB.DataPropertyName = "NamXB";
            this.NamXB.HeaderText = "Năm Xuất Bản";
            this.NamXB.MinimumWidth = 6;
            this.NamXB.Name = "NamXB";
            // 
            // MaTV
            // 
            this.MaTV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTV.DataPropertyName = "MaTV";
            this.MaTV.HeaderText = "Mã Thành Viên";
            this.MaTV.MinimumWidth = 6;
            this.MaTV.Name = "MaTV";
            // 
            // TenDN
            // 
            this.TenDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDN.DataPropertyName = "TenDN";
            this.TenDN.HeaderText = "Tên Đăng Nhập";
            this.TenDN.MinimumWidth = 6;
            this.TenDN.Name = "TenDN";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 525);
            this.Controls.Add(this.tabQuanLysach);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabQuanLysach.ResumeLayout(false);
            this.TapLoaiSach.ResumeLayout(false);
            this.TapLoaiSach.PerformLayout();
            this.tabSach.ResumeLayout(false);
            this.tabThanhVien.ResumeLayout(false);
            this.tabThanhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabQuanLysach;
        private System.Windows.Forms.TabPage TapLoaiSach;
        private System.Windows.Forms.TabPage tabSach;
        private System.Windows.Forms.TabPage tabThanhVien;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}

