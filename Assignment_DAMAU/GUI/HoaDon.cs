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

            cboNhanVien.DataSource = db.NHANVIENs.ToList();
            cboNhanVien.DisplayMember = "TEN";
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

            cboKhuyenMai.DataSource = khuyenMaiList;
            cboKhuyenMai.DisplayMember = "TEN_KHUYENMAI";
            cboKhuyenMai.ValueMember = "MA_KHUYENMAI";
            cboKhuyenMai.SelectedIndex = -1;






            dgvDanhSach.DataSource = db.HOADONs.Include(s => s.KHACHHANG)
                                   .Include(s => s.NHANVIEN)
                                   .Include(s => s.KHUYENMAI)
                                   .Select(s => new
                                   {
                                       s.MA_HOADON,
                                       s.NGAYLAP,
                                       TENNHANVIEN = s.NHANVIEN.HO + " " + s.NHANVIEN.TEN,
                                       TRANGTHAI = (s.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán",
                                       TENKHACHHANG = s.KHACHHANG.HOTEN,
                                       TONGTIEN = s.TONGTIEN
                                   }).ToList();
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
                string maHD = dgvDanhSach.Rows[e.RowIndex].Cells["MA_HOADON"].Value.ToString();
                var hd = db.HOADONs.FirstOrDefault(s => s.MA_HOADON == maHD);
                txtMaHD.Text = hd.MA_HOADON;
                dtpNgayLap.Value = DateTime.Parse(hd.NGAYLAP.ToString());
                cboNhanVien.SelectedValue = hd.MA_NV;
                txtTrangThai.Text = (hd.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán";
                txtmahoadon.Text = maHD;
                txtTongTien.Text = hd.TONGTIEN.ToString();
                txtTenKH.Text = hd.KHACHHANG.HOTEN;
                txtSDTKhach.Text = hd.KHACHHANG.SDT;
                if (hd.TRANGTHAI == true)
                {
                    btnCapNhat.Enabled = false;
                    btnUpDate.Enabled = false;
                    btnThemSach.Enabled = false;
                }



                dgvGioHang.DataSource = db.HOADONCHITIETs.Include(x => x.HOADON)
                .Include(x => x.SACH).Where(s => s.MA_HOADON == maHD).Select(s => new
                {
                    s.HOADON.MA_HOADON,
                    s.SACH.TEN_SACH,
                    s.SOLUONG,
                    s.SACH.GIA,
                    THANHTIEN = s.DONGIA 
                }).ToList();
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHD.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã hóa đơn");
                    return;
                }

                string sdt = txtSDTKhach.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string maKH;

                // Nếu nhập đủ cả họ tên và SDT → xử lý tạo/tìm khách hàng
                if (!string.IsNullOrEmpty(sdt) && sdt.Length >= 3)
                {
                    // Tìm khách theo SDT
                    var khach = db.KHACHHANGs.FirstOrDefault(k => k.SDT == sdt);

                    if (khach != null)
                    {
                        // Khách đã tồn tại
                        maKH = khach.MA_KHACHHANG;
                    }
                    else
                    {
                        // Tạo mã khách theo 3 số cuối SDT
                        maKH = "KH" + sdt.Substring(sdt.Length - 3);

                        // Tránh trùng mã
                        int count = 1;
                        string originalMaKH = maKH;
                        while (db.KHACHHANGs.Any(k => k.MA_KHACHHANG == maKH))
                        {
                            maKH = originalMaKH + count.ToString();
                            count++;
                        }

                        // Thêm khách hàng mới
                        KHACHHANG newKH = new KHACHHANG
                        {
                            MA_KHACHHANG = maKH,
                            HOTEN = tenKH,
                            SDT = sdt
                        };
                        db.KHACHHANGs.Add(newKH);
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm khách hàng mới");
                    }
                }
                else
                {
                    maKH = "0000";
                }

                // Tạo hóa đơn
                HOADON hd = new HOADON
                {
                    MA_HOADON = txtMaHD.Text,
                    NGAYLAP = dtpNgayLap.Value,
                    MA_NV = cboNhanVien.SelectedValue.ToString(),
                    MA_KHACHHANG = maKH,
                    TRANGTHAI = false,
                    TONGTIEN = 0
                };

                db.HOADONs.Add(hd);
                db.SaveChanges();
                LoadData();
                Xoa();
                MessageBox.Show("Thêm hóa đơn thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            var hd = db.HOADONs.Include(h => h.HOADONCHITIETs)
                               .FirstOrDefault(h => h.MA_HOADON == maHD);
            if (hd != null)
            {
                // Xóa chi tiết trước nếu có
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

        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string sdt = txtSDTKhach.Text.Trim();
            var kh = db.KHACHHANGs.FirstOrDefault(k => k.SDT == sdt);
            if (kh != null)
            {
                MessageBox.Show("Khách hàng đã tồn tại.");
                return;
            }

            kh = new KHACHHANG
            {
                MA_KHACHHANG = "KH" + sdt.Substring(sdt.Length - 3),
                HOTEN = txtTenKH.Text,
                SDT = sdt
            };

            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
            MessageBox.Show("Đã lưu khách hàng mới.");
        }
        private int LayPhanTramGiamGia()
        {
            if (cboKhuyenMai.SelectedValue == null)
                return 0;

            string maKM = cboKhuyenMai.SelectedValue.ToString();
            var km = db.KHUYENMAIs.FirstOrDefault(k => k.MA_KHUYENMAI == maKM);
            return (int)(km?.PHANTRAMGIAM.GetValueOrDefault() ?? 0);
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text != null && cboMaSach.SelectedValue != null && txtSoLuong.Text != "")
            {
                try
                {
                    string maHoaDon = txtmahoadon.Text;
                    string maSach = cboMaSach.SelectedValue.ToString();

                    var existing = db.HOADONCHITIETs.FirstOrDefault(x => x.MA_HOADON == maHoaDon && x.MA_SACH == maSach);
                    if (existing != null)
                    {
                        MessageBox.Show("Bản ghi đã tồn tại");
                        return;
                    }


                    var sach = db.SACHes.FirstOrDefault(s => s.MA_SACH == maSach);
                    if (sach == null)
                    {
                        MessageBox.Show("Không tìm thấy sách");
                        return;
                    }

                    HOADONCHITIET ct = new HOADONCHITIET();
                    ct.MA_HOADON = maHoaDon;
                    ct.MA_SACH = maSach;
                    ct.SOLUONG = int.Parse(txtSoLuong.Text);
                    if (ct.SOLUONG > sach.SOLUONGTON)
                    {
                        MessageBox.Show("Số lượng tồn không đủ để bán");
                        return;
                    }

                    int soLuong = int.Parse(txtSoLuong.Text);
                    int giam = LayPhanTramGiamGia();
                    int giaGoc = (int)sach.GIA * soLuong;
                    int giaSauGiam = giaGoc - (giaGoc * giam / 100);
                    ct.DONGIA = giaSauGiam;

                    sach.SOLUONGTON = sach.SOLUONGTON - ct.SOLUONG;

                    db.HOADONCHITIETs.Add(ct);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                    Xoa();
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mahd = dgvGioHang.Rows[e.RowIndex].Cells["MA_HOADON"].Value.ToString();
                string tensach = dgvGioHang.Rows[e.RowIndex].Cells["TEN_SACH"].Value.ToString();

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

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string maSach = cboMaSach.SelectedValue.ToString();
            var sach = db.SACHes.FirstOrDefault(s => s.MA_SACH == maSach);
            try
            {
                int soLuong = int.Parse(txtSoLuong.Text);
                int giaGoc = (int)sach.GIA * soLuong;
                int giam = LayPhanTramGiamGia();
                int giaSauGiam = giaGoc - (giaGoc * giam / 100);
                txtDonGia.Text = giaSauGiam.ToString();
            }
            catch
            {
                MessageBox.Show("Kiểm tra số lượng");
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text != null && cboMaSach.SelectedValue != null)
            {
                string maHoaDon = txtmahoadon.Text.ToString();
                string maSach = cboMaSach.SelectedValue.ToString();

                var ct = db.HOADONCHITIETs.FirstOrDefault(x => x.MA_HOADON == maHoaDon && x.MA_SACH == maSach);
                if (ct != null)
                {
                    ct.SOLUONG = int.Parse(txtSoLuong.Text);
                    if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
                    {
                        MessageBox.Show("Số lượng phải là số nguyên dương");
                        return;
                    }
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công");
                    Xoa();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để cập nhật");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text != null && cboMaSach.SelectedValue != null)
            {
                string maHoaDon = txtmahoadon.Text.ToString();
                string maSach = cboMaSach.SelectedValue.ToString();

                var ct = db.HOADONCHITIETs.FirstOrDefault(x => x.MA_HOADON == maHoaDon && x.MA_SACH == maSach);
                if (ct != null)
                {
                    db.HOADONCHITIETs.Remove(ct);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xóa thành công");
                    Xoa();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa");
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSach.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán.");
                    return;
                }
                var dlg = MessageBox.Show(
                    "Bạn có chắc chắn muốn thanh toán hóa đơn này không?",
                    "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dlg != DialogResult.Yes)
                    return;
                string maHD = dgvDanhSach.SelectedRows[0].Cells["MA_HOADON"].Value.ToString();
                var hoaDon = db.HOADONs.FirstOrDefault(h => h.MA_HOADON == maHD);
                if (hoaDon != null)
                {
                    hoaDon.TRANGTHAI = true;
                    db.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!");
                    LoadData();

                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
