using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_DAMAU.DAL;

namespace Assignment_DAMAU.GUI
{
    public partial class HoaDon : Form
    {
        SACHEntities3 db = new SACHEntities3();
        
        public HoaDon()
        {
            InitializeComponent();
        }
        public void LoadComboBox()
        {

            cboNhanVien.DataSource = db.NHANVIENs
                .Select(nv => new
                {
                    MA_NV = nv.MA_NV,
                    HoTen = nv.HO + " " + nv.TEN
                })
                .ToList();

            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MA_NV";
        }
        public void LoadData()
        {
            cboMaSach.DataSource = db.SACHes.ToList();
            cboMaSach.DisplayMember = "TEN_SACH";
            cboMaSach.ValueMember = "MA_SACH";


            var today = DateTime.Today;
            var khuyenMaiList = db.KHUYENMAIs
                                  .Where(k => k.NGAYBATDAU <= today && k.NGAYKETTHUC >= today)
                                  .ToList();




            dgvDanhSach.DataSource = db.HOADONs.Include(s => s.KHACHHANG)
                                   .Include(s => s.NHANVIEN)
                                   .Include(s => s.KHUYENMAI)
                                   .Select(s => new
                                   {
                                       MaHoaDon = s.MA_HOADON,
                                       NgayLap = s.NGAYLAP,
                                       TenNhanVien = s.NHANVIEN.HO + " " + s.NHANVIEN.TEN,
                                       TrangThai = (s.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán",
                                       TenKhachHang = s.KHACHHANG.HOTEN,
                                       TenKhuyenMai = s.KHUYENMAI.TEN_KHUYENMAI,
                                       TongTien = s.TONGTIEN
                                   }).ToList();

            cboMaSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaSach.AutoCompleteSource = AutoCompleteSource.ListItems;

            dgvDanhSach.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvDanhSach.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDanhSach.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDanhSach.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDanhSach.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvDanhSach.Columns["TenKhuyenMai"].HeaderText = "Tên Khuyến Mãi";
            dgvDanhSach.Columns["TongTien"].HeaderText = "Tổng Tiền";
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD = dgvDanhSach.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                var hd = db.HOADONs.FirstOrDefault(s => s.MA_HOADON == maHD);
                txtMaHD.Text = hd.MA_HOADON;
                dtpNgayLap.Value = DateTime.Parse(hd.NGAYLAP.ToString());
                cboNhanVien.SelectedValue = hd.MA_NV;
                txtTrangThai.Text = (hd.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán";
                txtmahoadon.Text = maHD;
                if (hd.KHUYENMAI == null)
                {
                    txtVoucher.Text = "";
                }
                else
                {
                    txtVoucher.Text = hd.KHUYENMAI.TEN_KHUYENMAI.ToString();
                }

                txtTongTien.Text = hd.TONGTIEN.ToString();
                txtTenKH.Text = hd.KHACHHANG.HOTEN;
                txtSDTKhach.Text = hd.KHACHHANG.SDT;

                var gioHang = db.HOADONCHITIETs
                .Include(x => x.HOADON)
                .Include(x => x.SACH)
                .Where(s => s.MA_HOADON == maHD)
                .Select(s => new
                {
                    s.HOADON.MA_HOADON,
                    s.SACH.TEN_SACH,
                    s.SOLUONG,
                    s.SACH.GIA,
                    THANHTIEN = s.DONGIA
                }).ToList();

                dgvGioHang.DataSource = gioHang;

                // Tính tổng tiền gốc từ giỏ hàng
                decimal tongGioHang = decimal.Parse(gioHang.Sum(item => item.THANHTIEN).ToString());

                // Tính tiền đã giảm
                decimal daGiam = (tongGioHang -decimal.Parse(hd.TONGTIEN.ToString().ToString()));
                txtDaGiam.Text = daGiam.ToString("N0");


                dgvGioHang.DataSource = db.HOADONCHITIETs.Include(x => x.HOADON)
                .Include(x => x.SACH).Where(s => s.MA_HOADON == maHD).Select(s => new
                {
                    MaHoaDon = s.HOADON.MA_HOADON,
                    TenSach = s.SACH.TEN_SACH,
                    SoLuong = s.SOLUONG,
                    Gia = s.SACH.GIA,
                    ThanhTien = s.DONGIA
                }).ToList();

                dgvGioHang.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgvGioHang.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvGioHang.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvGioHang.Columns["Gia"].HeaderText = "Giá";
                dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            }
        }
        private void Xoa()
        {
            txtTenKH.Clear();
            txtSDTKhach.Clear();
            txtMaHD.Clear();
            dtpNgayLap.Value = DateTime.Now;
            cboNhanVien.SelectedIndex = -1;
            txtTrangThai.Clear();
            txtVoucher.Clear();
            txtDaGiam.Clear();
            txtTongTien.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            var hd = db.HOADONs.Include(h => h.HOADONCHITIETs)
                               .FirstOrDefault(h => h.MA_HOADON == maHD);
            if (hd != null)
            {
                db.HOADONCHITIETs.RemoveRange(hd.HOADONCHITIETs);
                db.HOADONs.Remove(hd);
                db.SaveChanges();
                LoadData();
                Xoa();
                MessageBox.Show("Xóa hóa đơn thành công");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            var hd = db.HOADONs.FirstOrDefault(h => h.MA_HOADON == maHD);
            if (hd != null)
            {
                hd.NGAYLAP = dtpNgayLap.Value;
                hd.MA_NV = cboNhanVien.SelectedValue.ToString();
                db.SaveChanges();
                LoadData();
                Xoa();
                MessageBox.Show("Cập nhật hóa đơn thành công");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
            LoadData();
            cboNhanVien.SelectedIndex = -1;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }


        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mahd = dgvGioHang.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                string tensach = dgvGioHang.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();

                var sach = db.SACHes.FirstOrDefault(s => s.TEN_SACH == tensach);
                if (sach != null)
                {
                    var ct = db.HOADONCHITIETs.FirstOrDefault(x => x.MA_HOADON == mahd && x.MA_SACH == sach.MA_SACH);
                    if (ct != null)
                    {
                        cboMaSach.SelectedValue = ct.MA_SACH;
                        txtDonGia.Text = ct.DONGIA.ToString();
                        txtSoLuong.Text = ct.SOLUONG.ToString();
                    }
                }
            }
        }

        private void LocHoaDonTheoKhoangNgay(DateTime tuNgay, DateTime denNgay)
        {
            var dsHoaDon = db.HOADONs
                .Where(h => DbFunctions.TruncateTime(h.NGAYLAP) >= tuNgay.Date
                         && DbFunctions.TruncateTime(h.NGAYLAP) <= denNgay.Date)
                .Include(s => s.KHACHHANG)
                .Include(s => s.NHANVIEN)
                .Include(s => s.KHUYENMAI)
                .Select(s => new
                {
                    MaHoaDon = s.MA_HOADON,
                    NgayLap = s.NGAYLAP,
                    TenNhanVien = s.NHANVIEN.HO + " " + s.NHANVIEN.TEN,
                    TrangThai = (s.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán",
                    TenKhachHang = s.KHACHHANG.HOTEN,
                    TenKhuyenMai = s.KHUYENMAI.TEN_KHUYENMAI,
                    TongTien = s.TONGTIEN
                }).ToList();

            dgvDanhSach.DataSource = dsHoaDon;
            dgvDanhSach.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvDanhSach.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDanhSach.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDanhSach.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDanhSach.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvDanhSach.Columns["TenKhuyenMai"].HeaderText = "Tên Khuyến Mãi";
            dgvDanhSach.Columns["TongTien"].HeaderText = "Tổng Tiền";
        }

        private void txtSDTKhach_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDTKhach.Text.Trim();

            // Chỉ kiểm tra nếu độ dài đủ
            if (sdt.Length >= 9)
            {
                using (var db = new SACHEntities3())
                {
                    var khach = db.KHACHHANGs.FirstOrDefault(k => k.SDT == sdt);
                    if (khach != null)
                    {
                        txtTenKH.Text = khach.HOTEN;
                    }
                    else
                    {
                        txtTenKH.Text = ""; // Không tìm thấy thì xóa
                    }
                }
            }
            else
            {
                txtTenKH.Text = ""; // Nếu chưa đủ số thì xóa luôn
            }
        }

        private void btnLocKhoangNgay_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                return;
            }

            LocHoaDonTheoKhoangNgay(tuNgay, denNgay);
        }

        private void cboNhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboNhanVien.SelectedIndex == -1)
                return;

            string maNV = cboNhanVien.SelectedValue.ToString();

            var hoaDonNhanVien = db.HOADONs
                .Where(h => h.MA_NV == maNV)
                .Include(h => h.KHACHHANG)
                .Include(h => h.NHANVIEN)
                .Include(h => h.KHUYENMAI)
                .Select(h => new
                {
                    MaHoaDon = h.MA_HOADON,
                    NgayLap = h.NGAYLAP,
                    TenNhanVien = h.NHANVIEN.HO + " " + h.NHANVIEN.TEN,
                    TrangThai = (h.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán",
                    TenKhachHang = h.KHACHHANG.HOTEN,
                    TenKhuyenMai = h.KHUYENMAI.TEN_KHUYENMAI,
                    TongTien = h.TONGTIEN
                }).ToList();

            dgvDanhSach.DataSource = hoaDonNhanVien;


            dgvDanhSach.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dgvDanhSach.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDanhSach.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDanhSach.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvDanhSach.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvDanhSach.Columns["TenKhuyenMai"].HeaderText = "Tên Khuyến Mãi";
            dgvDanhSach.Columns["TongTien"].HeaderText = "Tổng Tiền";
        }
    }
}
