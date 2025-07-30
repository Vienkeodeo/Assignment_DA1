namespace Assignment_DAMAU.GUI
{
    partial class HoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbBang = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTKhach = new System.Windows.Forms.TextBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(1662, 893);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 94);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(49, 895);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 92);
            this.groupBox1.TabIndex = 26;
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
            this.grbBang.Location = new System.Drawing.Point(45, 440);
            this.grbBang.Margin = new System.Windows.Forms.Padding(4);
            this.grbBang.Name = "grbBang";
            this.grbBang.Padding = new System.Windows.Forms.Padding(4);
            this.grbBang.Size = new System.Drawing.Size(772, 421);
            this.grbBang.TabIndex = 25;
            this.grbBang.TabStop = false;
            this.grbBang.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSach.Location = new System.Drawing.Point(4, 23);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.Size = new System.Drawing.Size(764, 394);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSDTKhach);
            this.groupBox2.Location = new System.Drawing.Point(45, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 149);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemKH.Location = new System.Drawing.Point(476, 99);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(176, 32);
            this.btnThemKH.TabIndex = 4;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Location = new System.Drawing.Point(476, 48);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(176, 22);
            this.txtTenKH.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "SĐT";
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDTKhach.Location = new System.Drawing.Point(132, 48);
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(176, 22);
            this.txtSDTKhach.TabIndex = 17;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtTongTien);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.cboNhanVien);
            this.grbThongTin.Controls.Add(this.txtTrangThai);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.dtpNgayLap);
            this.grbThongTin.Controls.Add(this.txtMaHD);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.lblMa);
            this.grbThongTin.Location = new System.Drawing.Point(45, 41);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Size = new System.Drawing.Size(772, 236);
            this.grbThongTin.TabIndex = 24;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hóa đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(476, 186);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(176, 22);
            this.txtTongTien.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng tiền";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(476, 47);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(176, 24);
            this.cboNhanVien.TabIndex = 15;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrangThai.Location = new System.Drawing.Point(132, 188);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(176, 22);
            this.txtTrangThai.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trạng thái";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(132, 119);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(256, 22);
            this.dtpNgayLap.TabIndex = 12;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Location = new System.Drawing.Point(132, 51);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(176, 22);
            this.txtMaHD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(36, 53);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(78, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã hóa đơn";
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(1525, 893);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(128, 94);
            this.btnTroLai.TabIndex = 29;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvGioHang);
            this.groupBox4.Location = new System.Drawing.Point(825, 285);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(969, 576);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giỏ hàng";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGioHang.Location = new System.Drawing.Point(4, 23);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.Size = new System.Drawing.Size(961, 549);
            this.dgvGioHang.TabIndex = 0;
            this.dgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDel);
            this.groupBox5.Controls.Add(this.btnUpDate);
            this.groupBox5.Controls.Add(this.btnThemSach);
            this.groupBox5.Controls.Add(this.txtmahoadon);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cboKhuyenMai);
            this.groupBox5.Controls.Add(this.btnTinh);
            this.groupBox5.Controls.Add(this.cboMaSach);
            this.groupBox5.Controls.Add(this.txtDonGia);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtSoLuong);
            this.groupBox5.Controls.Add(this.lblTheLoai);
            this.groupBox5.Controls.Add(this.lblTen);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(825, 41);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(969, 236);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin hóa đơn chi tiết";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(780, 190);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(161, 35);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpDate.Location = new System.Drawing.Point(612, 192);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(161, 35);
            this.btnUpDate.TabIndex = 34;
            this.btnUpDate.Text = "Cập nhật";
            this.btnUpDate.UseVisualStyleBackColor = false;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemSach.Location = new System.Drawing.Point(780, 149);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(161, 36);
            this.btnThemSach.TabIndex = 33;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmahoadon.Location = new System.Drawing.Point(131, 50);
            this.txtmahoadon.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.ReadOnly = true;
            this.txtmahoadon.Size = new System.Drawing.Size(161, 22);
            this.txtmahoadon.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Khuyến mãi";
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(452, 105);
            this.cboKhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(160, 24);
            this.cboKhuyenMai.TabIndex = 26;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTinh.Location = new System.Drawing.Point(612, 149);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(161, 36);
            this.btnTinh.TabIndex = 25;
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(452, 47);
            this.cboMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(160, 24);
            this.cboMaSach.TabIndex = 13;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(131, 107);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(161, 22);
            this.txtDonGia.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng tiền";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(780, 49);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(161, 22);
            this.txtSoLuong.TabIndex = 9;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(679, 53);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(60, 16);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "Số lượng";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(355, 52);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(63, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThanhToan.Location = new System.Drawing.Point(1389, 893);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 94);
            this.btnThanhToan.TabIndex = 33;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 1015);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBang);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbBang;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTKhach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.Button btnThanhToan;
    }
}