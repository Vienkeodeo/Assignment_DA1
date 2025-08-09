using Assignment_DAMAU.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_DAMAU.GUI
{
    public partial class BanHang : Form
    {
        SACHEntities3 db = new SACHEntities3();
        public BanHang()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var today = DateTime.Today;
            var khuyenMaiList = db.KHUYENMAIs
                                  .Where(k => k.NGAYBATDAU <= today && k.NGAYKETTHUC >= today)
                                  .ToList();

            cboKhuyenMai.DataSource = khuyenMaiList;
            cboKhuyenMai.DisplayMember = "TEN_KHUYENMAI";
            cboKhuyenMai.ValueMember = "MA_KHUYENMAI";
            cboKhuyenMai.SelectedIndex = -1;

            cboSach.DataSource = db.SACHes.ToList();
            cboSach.DisplayMember = "TEN_SACH";
            cboSach.ValueMember = "MA_SACH";
            cboSach.SelectedIndex = -1;

            cboNhanVien.DataSource = db.NHANVIENs.ToList();
            cboNhanVien.DisplayMember = "TEN";
            cboNhanVien.ValueMember = "MA_NV";
            cboNhanVien.SelectedIndex = -1;

            cboSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSach.AutoCompleteSource = AutoCompleteSource.ListItems;

            var sdtList = db.KHACHHANGs.Select(k => k.SDT).ToList();
            AutoCompleteStringCollection sdtSource = new AutoCompleteStringCollection();
            sdtSource.AddRange(sdtList.ToArray());
            txtSDT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSDT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSDT.AutoCompleteCustomSource = sdtSource;
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public class ChiTietGioHang
        {
            public string MA_SACH { get; set; }
            public string TEN_SACH { get; set; }
            public int SOLUONG { get; set; }
            public decimal GIA { get; set; }
            public decimal THANHTIEN => SOLUONG * GIA;
        }
        private List<ChiTietGioHang> gioHang = new List<ChiTietGioHang>();

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            var sach = (SACH)cboSach.SelectedItem;
            int soLuong;

            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }
            if (soLuong > sach.SOLUONGTON)
            {
                MessageBox.Show("Không đủ hàng trong kho.");
                return;
            }
            var existing = gioHang.FirstOrDefault(x => x.MA_SACH == sach.MA_SACH);
            if (existing != null)
            {
                existing.SOLUONG += soLuong;
            }
            else
            {
                gioHang.Add(new ChiTietGioHang
                {
                    MA_SACH = sach.MA_SACH,
                    TEN_SACH = sach.TEN_SACH,
                    SOLUONG = soLuong,
                    GIA = (int)sach.GIA
                });
            }

            CapNhatGioHang();
            CapNhatTienGiam();
        }
        private void CapNhatGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang.Select(g => new
            {
                g.MA_SACH,
                g.TEN_SACH,
                g.SOLUONG,
                g.GIA,
                g.THANHTIEN
            }).ToList();

            decimal tong = gioHang.Sum(x => x.THANHTIEN);
            int giam = LayPhanTramGiamGia();
            decimal tongSauGiam = tong - tong * giam / 100;

            txtTongTien.Text = tongSauGiam.ToString();
        }
        private int LayPhanTramGiamGia()
        {
            if (cboKhuyenMai.SelectedValue == null)
                return 0;

            string maKM = cboKhuyenMai.SelectedValue.ToString();
            var km = db.KHUYENMAIs.FirstOrDefault(k => k.MA_KHUYENMAI == maKM);
            return (int)(km?.PHANTRAMGIAM.GetValueOrDefault() ?? 0);
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.");
                return;
            }
            if (cboNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.");
                return;
            }

            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    string sdt = txtSDT.Text.Trim();
                    string tenKH = txtTenKH.Text.Trim();
                    string maKH;

                    // 1. Xử lý khách hàng
                    if (!string.IsNullOrEmpty(sdt) && sdt.Length >= 3)
                    {
                        var khach = db.KHACHHANGs.FirstOrDefault(k => k.SDT == sdt);
                        if (khach != null)
                        {
                            maKH = khach.MA_KHACHHANG;
                        }
                        else
                        {
                            maKH = "KH" + sdt.Substring(sdt.Length - 3);
                            int count = 1;
                            string originalMaKH = maKH;
                            while (db.KHACHHANGs.Any(k => k.MA_KHACHHANG == maKH))
                            {
                                maKH = originalMaKH + count.ToString();
                                count++;
                            }

                            KHACHHANG newKH = new KHACHHANG
                            {
                                MA_KHACHHANG = maKH,
                                HOTEN = tenKH,
                                SDT = sdt
                            };
                            db.KHACHHANGs.Add(newKH);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        // Khách vãng lai
                        maKH = "0000";
                    }

                    // 2. Tạo hóa đơn
                    HOADON hd = new HOADON
                    {
                        MA_HOADON = TaoMaHoaDonTuDong(),
                        MA_KHACHHANG = maKH,
                        MA_NV = cboNhanVien.SelectedValue.ToString(),
                        NGAYLAP = DateTime.Now,
                        TRANGTHAI = true,
                        TONGTIEN = decimal.Parse(txtTongTien.Text.Replace(",", "").Replace(".", "").Replace(" đ", "").Trim())
                    };
                    db.HOADONs.Add(hd);
                    db.SaveChanges();

                    // 3. Thêm chi tiết hóa đơn và cập nhật tồn kho
                    foreach (var item in gioHang)
                    {
                        HOADONCHITIET ct = new HOADONCHITIET
                        {
                            MA_HOADON = hd.MA_HOADON,
                            MA_SACH = item.MA_SACH,
                            SOLUONG = item.SOLUONG,
                            DONGIA = item.GIA * item.SOLUONG
                        };
                        db.HOADONCHITIETs.Add(ct);

                        var sach = db.SACHes.Find(item.MA_SACH);
                        if (sach == null)
                            throw new Exception("Sách không tồn tại: " + item.MA_SACH);
                        if (sach.SOLUONGTON < item.SOLUONG)
                            throw new Exception("Sách '" + sach.TEN_SACH + "' không đủ số lượng tồn.");

                        sach.SOLUONGTON -= item.SOLUONG;
                    }

                    db.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Thanh toán thành công!");
                    LamMoiForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Thanh toán thất bại: " + ex.Message);
                }
            }
        }
        private string TaoMaHoaDonTuDong()
        {
            string maMoi;
            int so = 1;

            while (true)
            {
                maMoi = "HD" + so.ToString("D3");
                bool daTonTai = db.HOADONs.Any(h => h.MA_HOADON == maMoi);
                if (!daTonTai)
                    break;
                so++;
            }

            return maMoi;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length >= 9)
            {
                var kh = db.KHACHHANGs.FirstOrDefault(k => k.SDT == sdt);
                txtTenKH.Text = kh != null ? kh.HOTEN : "";
            }
            else
            {
                txtTenKH.Text = "";
            }
        }
        private void Xoa()
        {
            txtTenKH.Clear();
            txtSDT.Clear();
            cboNhanVien.SelectedIndex = -1;
        }
        public void LamMoiForm()
        {
            Xoa();
            LoadData();
        }
        private decimal tinhTongTien()
        {
            decimal tong = gioHang.Sum(item => item.THANHTIEN);
            int giam = LayPhanTramGiamGia();
            return tong - tong * giam / 100;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal tongTienTruocGiam = gioHang.Sum(item => item.THANHTIEN);
            int phanTramGiam = LayPhanTramGiamGia();

            decimal tienGiam = tongTienTruocGiam * phanTramGiam / 100;
            decimal tongTienSauGiam = tongTienTruocGiam - tienGiam;

            txtTongTien.Text = tongTienSauGiam.ToString("N0");
        }
        private void CapNhatTienGiam()
        {
            decimal tong = gioHang.Sum(item => item.THANHTIEN);
            int giam = LayPhanTramGiamGia();
            decimal soTienGiam = tong * giam / 100;

            txtSoTienGiam.Text = $"{soTienGiam:N0} đ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
                return;
            }

            string maSach = dgvGioHang.CurrentRow.Cells["MA_SACH"].Value.ToString();
            var item = gioHang.FirstOrDefault(g => g.MA_SACH == maSach);
            if (item != null)
            {
                gioHang.Remove(item);
                CapNhatGioHang();
                CapNhatTienGiam();
            }
        }
    }
}
