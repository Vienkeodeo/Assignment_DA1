namespace Assignment_DAMAU.GUI
{
    partial class BookForm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbBang = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbAnhSach = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(1354, 20);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 42);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(1107, 693);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(375, 92);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(247, 41);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(20, 44);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(203, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(107, 693);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 92);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(425, 42);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(295, 42);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(164, 42);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 42);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbBang
            // 
            this.grbBang.Controls.Add(this.dgvDanhSach);
            this.grbBang.Location = new System.Drawing.Point(107, 331);
            this.grbBang.Margin = new System.Windows.Forms.Padding(4);
            this.grbBang.Name = "grbBang";
            this.grbBang.Padding = new System.Windows.Forms.Padding(4);
            this.grbBang.Size = new System.Drawing.Size(969, 341);
            this.grbBang.TabIndex = 12;
            this.grbBang.TabStop = false;
            this.grbBang.Text = "Danh sách sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(8, 23);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.Size = new System.Drawing.Size(953, 309);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtDuongDanAnh);
            this.grbThongTin.Controls.Add(this.btnChonAnh);
            this.grbThongTin.Controls.Add(this.cboNCC);
            this.grbThongTin.Controls.Add(this.cboNXB);
            this.grbThongTin.Controls.Add(this.txtSoLuongTon);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.cboTheLoai);
            this.grbThongTin.Controls.Add(this.txtTenSach);
            this.grbThongTin.Controls.Add(this.txtGia);
            this.grbThongTin.Controls.Add(this.txtMaSach);
            this.grbThongTin.Controls.Add(this.lblNCC);
            this.grbThongTin.Controls.Add(this.lblTheLoai);
            this.grbThongTin.Controls.Add(this.lblNXB);
            this.grbThongTin.Controls.Add(this.lblTen);
            this.grbThongTin.Controls.Add(this.lblGia);
            this.grbThongTin.Controls.Add(this.lblMa);
            this.grbThongTin.Location = new System.Drawing.Point(107, 70);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Size = new System.Drawing.Size(1375, 238);
            this.grbThongTin.TabIndex = 11;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin sách";
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(1106, 121);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(160, 24);
            this.cboNCC.TabIndex = 16;
            // 
            // cboNXB
            // 
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(615, 121);
            this.cboNXB.Margin = new System.Windows.Forms.Padding(4);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(160, 24);
            this.cboNXB.TabIndex = 15;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongTon.Location = new System.Drawing.Point(131, 193);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(161, 22);
            this.txtSoLuongTon.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng tồn";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(1106, 47);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(160, 24);
            this.cboTheLoai.TabIndex = 12;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSach.Location = new System.Drawing.Point(615, 49);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(161, 22);
            this.txtTenSach.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Location = new System.Drawing.Point(131, 123);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(161, 22);
            this.txtGia.TabIndex = 7;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSach.Location = new System.Drawing.Point(131, 49);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(161, 22);
            this.txtMaSach.TabIndex = 6;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(1001, 124);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(90, 16);
            this.lblNCC.TabIndex = 5;
            this.lblNCC.Text = "Nhà cung cấp";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(1001, 51);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(56, 16);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "Thể loại";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(497, 124);
            this.lblNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(85, 16);
            this.lblNXB.TabIndex = 3;
            this.lblNXB.Text = "Nhà xuất bản";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(497, 53);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(63, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên sách";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(36, 124);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(28, 16);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(36, 53);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(58, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã sách";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1203, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbAnhSach
            // 
            this.pbAnhSach.Location = new System.Drawing.Point(1107, 354);
            this.pbAnhSach.Name = "pbAnhSach";
            this.pbAnhSach.Size = new System.Drawing.Size(375, 309);
            this.pbAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhSach.TabIndex = 17;
            this.pbAnhSach.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(489, 190);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(93, 27);
            this.btnChonAnh.TabIndex = 17;
            this.btnChonAnh.Text = "Chọn ảnh ";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuongDanAnh.Location = new System.Drawing.Point(615, 193);
            this.txtDuongDanAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.Size = new System.Drawing.Size(161, 22);
            this.txtDuongDanAnh.TabIndex = 18;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 820);
            this.Controls.Add(this.pbAnhSach);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBang);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbBang;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbAnhSach;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
    }
}