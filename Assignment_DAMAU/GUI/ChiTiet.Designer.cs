namespace Assignment_DAMAU.GUI
{
    partial class ChiTiet
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
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKhuyenMai = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(904, 640);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 94);
            this.btnThoat.TabIndex = 23;
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
            this.groupBox1.Location = new System.Drawing.Point(63, 640);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(563, 92);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(425, 42);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.grbBang.Location = new System.Drawing.Point(63, 278);
            this.grbBang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbBang.Name = "grbBang";
            this.grbBang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbBang.Size = new System.Drawing.Size(969, 341);
            this.grbBang.TabIndex = 21;
            this.grbBang.TabStop = false;
            this.grbBang.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(8, 23);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.Size = new System.Drawing.Size(953, 309);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.cboKhuyenMai);
            this.grbThongTin.Controls.Add(this.btnTinh);
            this.grbThongTin.Controls.Add(this.cboMaSach);
            this.grbThongTin.Controls.Add(this.cboMaHoaDon);
            this.grbThongTin.Controls.Add(this.txtDonGia);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.txtSoLuong);
            this.grbThongTin.Controls.Add(this.lblTheLoai);
            this.grbThongTin.Controls.Add(this.lblTen);
            this.grbThongTin.Controls.Add(this.lblMa);
            this.grbThongTin.Location = new System.Drawing.Point(63, 64);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTin.Size = new System.Drawing.Size(969, 167);
            this.grbThongTin.TabIndex = 20;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hóa đơn chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Khuyến mãi";
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.FormattingEnabled = true;
            this.cboKhuyenMai.Location = new System.Drawing.Point(461, 106);
            this.cboKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Size = new System.Drawing.Size(160, 24);
            this.cboKhuyenMai.TabIndex = 26;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTinh.Location = new System.Drawing.Point(780, 99);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cboMaSach.Location = new System.Drawing.Point(461, 48);
            this.cboMaSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(160, 24);
            this.cboMaSach.TabIndex = 13;
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(132, 47);
            this.cboMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(160, 24);
            this.cboMaHoaDon.TabIndex = 12;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(131, 107);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(161, 22);
            this.txtDonGia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(780, 49);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lblTen.Location = new System.Drawing.Point(364, 53);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(63, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên sách";
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
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThanhToan.Location = new System.Drawing.Point(768, 640);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 94);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuayLai.Location = new System.Drawing.Point(633, 640);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(128, 94);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 782);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBang);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChiTiet";
            this.Text = "ChiTiet";
            this.Load += new System.EventHandler(this.ChiTiet_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhuyenMai;
        private System.Windows.Forms.Button btnQuayLai;
    }
}