using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_DAMAU.DAL;

namespace Assignment_DAMAU.GUI
{
    public partial class KhachHang: Form
    {
        SACHEntities3 db = new SACHEntities3();
        public void LoadData()
        {
            var dsKhachHang = db.KHACHHANGs.Select(k => new
            {
                k.MA_KHACHHANG,
                k.HOTEN,
                k.EMAIL,
                k.SDT,
                k.DIACHI,
            }).ToList();
            dgvDanhSach.DataSource = dsKhachHang;
            dgvDanhSach.Columns["MA_KHACHHANG"].HeaderText = "Mã khách hàng";
            dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
            dgvDanhSach.Columns["EMAIL"].HeaderText = "Email";
            dgvDanhSach.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
        }
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void Xoa()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "" && txtSDT.Text != "")
            {
                try
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.MA_KHACHHANG = txtMa.Text;
                    kh.HOTEN = txtTen.Text;
                    kh.SDT = txtSDT.Text;
                    kh.EMAIL = txtEmail.Text;
                    kh.DIACHI = txtDiaChi.Text;

                    db.KHACHHANGs.Add(kh);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm khách hàng thành công");
                    Xoa();
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            var kh = db.KHACHHANGs.FirstOrDefault(x => x.MA_KHACHHANG == ma);
            if (kh != null)
            {
                kh.HOTEN = txtTen.Text;
                kh.SDT = txtSDT.Text;
                kh.EMAIL = txtEmail.Text;
                kh.DIACHI = txtDiaChi.Text;

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thông tin độc giả thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy độc giả cần cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            var kh = db.KHACHHANGs.FirstOrDefault(x => x.MA_KHACHHANG == ma);
            if (kh != null)
            {
                db.KHACHHANGs.Remove(kh);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa độc giả thành công");
                Xoa();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (tuKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            var ketQua = db.KHACHHANGs
                .Where(dg => dg.MA_KHACHHANG.Contains(tuKhoa) || dg.HOTEN.Contains(tuKhoa))
                .ToList();

            if (ketQua.Count > 0)
            {
                dgvDanhSach.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy độc giả phù hợp.");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                txtMa.Text = row.Cells["MA_KHACHHANG"].Value.ToString();
                txtTen.Text = row.Cells["HOTEN"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                if (row.Cells["EMAIL"].Value != null)
                {
                    txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                }
                else
                {
                    txtEmail.Text = ""; // hoặc gán giá trị mặc định
                }
                if (row.Cells["DIACHI"].Value != null)
                {
                    txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                }
                else
                {
                    txtDiaChi.Text = "";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(); 
            main.Show();
            this.Close();
        }
    }
}
