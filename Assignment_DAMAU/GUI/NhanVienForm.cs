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
    public partial class NhanVienForm: Form
    {
        SACHEntities3 db = new SACHEntities3();
        public void LoadData()
        {
            dgvDanhSach.DataSource = db.NHANVIENs
                                                 .Where(s => s.TEN.Contains(txtTimKiem.Text))
                                                 .Select(s => new
                                                 {
                                                     s.MA_NV,
                                                     HOvaTEN = s.HO + " " + s.TEN,
                                                     s.NGAYSINH,
                                                     s.DIACHI,
                                                     s.SDT,
                                                     s.EMAIL,
                                                 }).ToList();
            dgvDanhSach.Columns["MA_NV"].HeaderText = "Mã nhân viên";
            dgvDanhSach.Columns["HovaTen"].HeaderText = "Họ tên";
            dgvDanhSach.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvDanhSach.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvDanhSach.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDanhSach.Columns["EMAIL"].HeaderText = "Email";
        }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtHoNV.Text != "" && txtTenNV.Text != ""
            && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                try
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MA_NV = txtMaNV.Text;
                    nv.HO = txtHoNV.Text;
                    nv.TEN = txtTenNV.Text;
                    nv.NGAYSINH = dtpNgaySinh.Value;
                    nv.DIACHI = txtDiaChi.Text;
                    nv.SDT = txtSDT.Text;
                    nv.EMAIL = txtEmail.Text;

                    db.NHANVIENs.Add(nv);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm nhân viên thành công");
                    Xoa();
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtHoNV.Text != "" && txtTenNV.Text != ""  && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                try
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MA_NV = txtMaNV.Text;
                    nv.HO = txtHoNV.Text;
                    nv.TEN = txtTenNV.Text;
                    nv.NGAYSINH = dtpNgaySinh.Value;
                    nv.DIACHI = txtDiaChi.Text;
                    nv.SDT = txtSDT.Text;
                    nv.EMAIL = txtEmail.Text;

                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm nhân viên thành công");
                    Xoa();
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            var nv = db.NHANVIENs.FirstOrDefault(x => x.MA_NV == ma);
            if (nv != null)
            {
                db.NHANVIENs.Remove(nv);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa nhân viên thành công");
                Xoa();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        public void Xoa()
        {
            txtMaNV.Clear();
            txtHoNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = DateTime.Today;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string manv = dgvDanhSach.Rows[e.RowIndex].Cells["MA_NV"].Value.ToString();
                var nv = db.NHANVIENs.FirstOrDefault(s => s.MA_NV == manv);
                if (nv != null)
                {
                    txtMaNV.Text = nv.MA_NV;
                    txtHoNV.Text = nv.HO;
                    txtTenNV.Text = nv.TEN;
                    dtpNgaySinh.Value = nv.NGAYSINH ?? DateTime.Today;  
                    txtSDT.Text = nv.SDT;
                    txtEmail.Text = nv.EMAIL;
                    txtDiaChi.Text = nv.DIACHI;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (tuKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                LoadData();
            }

            if (dgvDanhSach.Rows.Count > 0)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp.");
                return;
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
