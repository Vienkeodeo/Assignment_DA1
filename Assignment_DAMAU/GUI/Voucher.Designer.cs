namespace Assignment_DAMAU.GUI
{
    partial class Voucher
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
            this.btnXoaBaoCao = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbBang = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
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
            this.btnThoat.Location = new System.Drawing.Point(976, 610);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 86);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoaBaoCao);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(135, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 92);
            this.groupBox1.TabIndex = 23;
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
            // btnXoaBaoCao
            // 
            this.btnXoaBaoCao.Location = new System.Drawing.Point(295, 42);
            this.btnXoaBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaBaoCao.Name = "btnXoaBaoCao";
            this.btnXoaBaoCao.Size = new System.Drawing.Size(100, 28);
            this.btnXoaBaoCao.TabIndex = 2;
            this.btnXoaBaoCao.Text = "Xóa";
            this.btnXoaBaoCao.UseVisualStyleBackColor = true;
            this.btnXoaBaoCao.Click += new System.EventHandler(this.btnXoaBaoCao_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // grbBang
            // 
            this.grbBang.Controls.Add(this.dgvDanhSach);
            this.grbBang.Location = new System.Drawing.Point(135, 249);
            this.grbBang.Margin = new System.Windows.Forms.Padding(4);
            this.grbBang.Name = "grbBang";
            this.grbBang.Padding = new System.Windows.Forms.Padding(4);
            this.grbBang.Size = new System.Drawing.Size(969, 341);
            this.grbBang.TabIndex = 22;
            this.grbBang.TabStop = false;
            this.grbBang.Text = "Danh sách voucher";
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
            this.grbThongTin.Controls.Add(this.dtpKetThuc);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.dtpBatDau);
            this.grbThongTin.Controls.Add(this.txtPhanTram);
            this.grbThongTin.Controls.Add(this.txtTen);
            this.grbThongTin.Controls.Add(this.txtMa);
            this.grbThongTin.Controls.Add(this.lblNXB);
            this.grbThongTin.Controls.Add(this.lblTen);
            this.grbThongTin.Controls.Add(this.lblTacGia);
            this.grbThongTin.Controls.Add(this.lblMa);
            this.grbThongTin.Location = new System.Drawing.Point(135, 42);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Size = new System.Drawing.Size(969, 185);
            this.grbThongTin.TabIndex = 21;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin voucher";
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Location = new System.Drawing.Point(608, 117);
            this.dtpKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(265, 22);
            this.dtpKetThuc.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngày kết thúc";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Location = new System.Drawing.Point(165, 117);
            this.dtpBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(265, 22);
            this.dtpBatDau.TabIndex = 12;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhanTram.Location = new System.Drawing.Point(780, 50);
            this.txtPhanTram.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(161, 22);
            this.txtPhanTram.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(472, 49);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(161, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMa.Location = new System.Drawing.Point(131, 49);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(161, 22);
            this.txtMa.TabIndex = 6;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(668, 53);
            this.lblNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(100, 16);
            this.lblNXB.TabIndex = 5;
            this.lblNXB.Text = "Phần trăm giảm";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(341, 53);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(82, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên voucher";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(36, 119);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(88, 16);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "Ngày bắt đầu";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(36, 53);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(77, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã voucher";
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(840, 610);
            this.btnTroLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(128, 86);
            this.btnTroLai.TabIndex = 25;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBang);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Voucher";
            this.Text = "Voucher";
            this.Load += new System.EventHandler(this.Voucher_Load);
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
        private System.Windows.Forms.Button btnXoaBaoCao;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbBang;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnTroLai;
    }
}