using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_DAMAU.DAL;

namespace Assignment_DAMAU.GUI
{
    public partial class ChiTiet: Form
    {
        SACHEntities3 db = new SACHEntities3();
        public ChiTiet()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            db = new SACHEntities3();
            dgvDanhSach.DataSource = db.HOADONCHITIETs
                                       .Include(s => s.SACH)
                                       .Include(s => s.HOADON)
                                       .Select(s => new
                                       {
                                           HoaDon = s.HOADON.MA_HOADON,
                                           TenSach = s.SACH.TEN_SACH,
                                           s.SOLUONG,
                                           s.DONGIA,
                                           TRANGTHAI = (s.HOADON.TRANGTHAI == false) ? "Chưa thanh toán" : "Đã thanh toán"
                                       }).ToList();

            cboMaHoaDon.DataSource = db.HOADONs.ToList();
            cboMaHoaDon.DisplayMember = "MA_HOADON";
            cboMaHoaDon.ValueMember = "MA_HOADON";

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


        }
        private int LayPhanTramGiamGia()
        {
            if (cboKhuyenMai.SelectedValue == null)
                return 0;

            string maKM = cboKhuyenMai.SelectedValue.ToString();
            var km = db.KHUYENMAIs.FirstOrDefault(k => k.MA_KHUYENMAI == maKM);
            return (int)(km?.PHANTRAMGIAM.GetValueOrDefault() ?? 0);
        }




        private void ChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Xoa()
        {
            cboMaHoaDon.SelectedIndex = -1;
            cboMaSach.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaHoaDon.SelectedValue != null && cboMaSach.SelectedValue != null && txtSoLuong.Text != "")
            {
                try
                {
                    string maHoaDon = cboMaHoaDon.SelectedValue.ToString();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboMaHoaDon.SelectedValue != null && cboMaSach.SelectedValue != null)
            {
                string maHoaDon = cboMaHoaDon.SelectedValue.ToString();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMaHoaDon.SelectedValue != null && cboMaSach.SelectedValue != null)
            {
                string maHoaDon = cboMaHoaDon.SelectedValue.ToString();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mahd = dgvDanhSach.Rows[e.RowIndex].Cells["HoaDon"].Value.ToString();
                string tensach = dgvDanhSach.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();

                var sach = db.SACHes.FirstOrDefault(s => s.TEN_SACH == tensach);
                if (sach != null)
                {
                    var ct = db.HOADONCHITIETs.FirstOrDefault(x => x.MA_HOADON == mahd && x.MA_SACH == sach.MA_SACH);
                    if (ct != null)
                    {
                        cboMaHoaDon.SelectedValue = ct.MA_HOADON;
                        cboMaSach.SelectedValue = ct.MA_SACH;
                        txtDonGia.Text = ct.DONGIA.ToString();
                        txtSoLuong.Text = ct.SOLUONG.ToString();
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //this.Hide();
            BanHang banHang = new BanHang();
            banHang.Show();
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            HoaDon hd = new HoaDon();
            hd.Show();
        }
    }
}
