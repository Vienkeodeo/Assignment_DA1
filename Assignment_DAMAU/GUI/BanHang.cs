using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_DAMAU.DAL;

namespace Assignment_DAMAU.GUI
{
    public partial class BanHang : Form
    {
        SACHEntities3 db = new SACHEntities3();
        public void LoadHoaDon()
        {
            dgvHoaDon.DataSource = db.HOADONs
                                    .Include(s => s.NHANVIEN)
                                    .Include(s => s.KHACHHANG)
                                    .Include(s => s.KHUYENMAI)
                                    .Where(s => s.TRANGTHAI == false)
                                    .Select(s => new
                                    {
                                        s.MA_HOADON,
                                        TenNhanVien = s.NHANVIEN.HO + " " + s.NHANVIEN.TEN,
                                        TenKhachHang = s.KHACHHANG.HOTEN,
                                        s.NGAYLAP,
                                    }).ToList();
        }
        public void LoadKhachHang()
        {
            cboKhachHang.DataSource = db.KHACHHANGs.Select(x => new
            {
                x.MA_KHACHHANG,
                TenKhachHang = x.HOTEN + " " + x.SDT
            }).ToList();
            cboKhachHang.DisplayMember = "HOTEN";
            cboKhachHang.ValueMember = "MA_KHACHHANG";
        }
        public void LoadNhanVien()
        {
            cboNhanVien.DataSource = db.NHANVIENs.Select(x => new
            {
                x.MA_NV,
                TenNhanVien = x.TEN + " " + x.HO
            }).ToList();
            cboNhanVien.DisplayMember = "TEN";
            cboNhanVien.ValueMember = "MA_NV";
        }
        public void LoadSach()
        {
            dgvSanPham.DataSource = db.SACHes.Include(s => s.THELOAI)
                                              .Include(s => s.NHACUNGCAP)
                                              .Include(s => s.NXB)
                                              .Where(s => s.TEN_SACH.Contains(txtTimKiem.Text))
                                              .Select(s => new
                                              {
                                                  s.MA_SACH,
                                                  s.TEN_SACH,
                                                  s.GIA,
                                                  s.SOLUONGTON,
                                                  NXB = s.NXB.TEN_NXB,
                                                  THELOAI = s.THELOAI.TEN_THELOAI,
                                                  NHACUNGCAP = s.NHACUNGCAP.TEN_NHACUNGCAP
                                              }).ToList();
        }
        public BanHang()
        {
            InitializeComponent();
        }
        public void TongTien()
        {
            decimal Tien = 0;
            if (dgvGioHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvGioHang.Rows)
                {
                    var cellValue = decimal.Parse(r.Cells["DonGia"].Value.ToString());
                    Tien = Tien + cellValue;
                }
            }
            lblhienthiTien.Text = Tien.ToString();
        }
        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadSach();
            LoadKhachHang();
            LoadNhanVien();
        }
        public void LoadChiTiet(string maHD)
        {
            
            dgvGioHang.DataSource = db.HOADONCHITIETs
                                      .Include(x => x.SACH)
                                      .Where(x => x.MA_HOADON == maHD)
                                      .ToList()
                                      .Select(x => new
                                      {
                                          x.HOADON.MA_HOADON,
                                          x.SACH.TEN_SACH,
                                          x.SOLUONG,
                                          x.DONGIA,
                                      }).ToList();
            cboKhachHang.SelectedValue = db.HOADONs.Where(hd => hd.MA_HOADON == maHD).Select(hd => hd.MA_KHACHHANG).FirstOrDefault();
            cboNhanVien.SelectedValue = db.HOADONs.Where(hd => hd.MA_HOADON == maHD).Select(hd => hd.MA_NV).FirstOrDefault();
            TongTien();
        }
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mahd = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            LoadChiTiet(mahd);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtKhachDua.Text) < decimal.Parse(lblhienthiTien.Text))
                {
                    MessageBox.Show("Khách chưa đưa đủ tiền");
                }
                else
                {
                    txtTienTra.Text = ((decimal.Parse(txtKhachDua.Text) - decimal.Parse(lblhienthiTien.Text)).ToString()) + " đ";
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra dữ liệu");
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtKhachDua.Text) < decimal.Parse(lblhienthiTien.Text))
                {
                    MessageBox.Show("Khách chưa đưa đủ tiền");
                    return;
                }
                if (dgvHoaDon.SelectedRows.Count == 0)
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
                string maHD = dgvHoaDon.SelectedRows[0].Cells["MA_HOADON"].Value.ToString();
                var hoaDon = db.HOADONs.FirstOrDefault(h => h.MA_HOADON == maHD);
                if (hoaDon != null)
                {
                    hoaDon.TRANGTHAI = true;
                    db.SaveChanges();
                    MessageBox.Show("Thanh toán thành công!");
                    LoadHoaDon();
                    
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = null;
            lblhienthiTien.Text = "0";
            txtTienTra.Text = "";
            txtKhachDua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadSach();
            LoadKhachHang();
            LoadNhanVien();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
