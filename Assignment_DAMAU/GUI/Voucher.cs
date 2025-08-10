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
    public partial class Voucher: Form
    {
        SACHEntities3 db = new SACHEntities3(); 
        public Voucher()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var dsVoucher = db.KHUYENMAIs.Select(v => new
            {
                v.MA_KHUYENMAI,
                v.TEN_KHUYENMAI,
                v.PHANTRAMGIAM,
                v.NGAYBATDAU,
                v.NGAYKETTHUC
            }).ToList();
            dgvDanhSach.DataSource = dsVoucher;

            dgvDanhSach.Columns["MA_KHUYENMAI"].HeaderText = "Mã khuyến mãi";
            dgvDanhSach.Columns["TEN_KHUYENMAI"].HeaderText = "Tên khuyến mãi";
            dgvDanhSach.Columns["PHAMTRAMGIAM"].HeaderText = "Phần trăm giảm";
            dgvDanhSach.Columns["NGAYBATDAU"].HeaderText = "Ngày bắt đầu";
            dgvDanhSach.Columns["NGAYKETTHUC"].HeaderText = "Ngày kết thúc";
        }
        private void Voucher_Load(object sender, EventArgs e)
        {
            LoadData();
            if (CurrentUser.Role == "STAFF")
            {
                btnThem.Enabled = false;
                btnCapNhat.Enabled = false;
            }
        }
        public void Xoa()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtPhanTram.Clear();
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MA_KHUYENMAI"].Value.ToString();
                txtTen.Text = row.Cells["TEN_KHUYENMAI"].Value.ToString();
                txtPhanTram.Text = row.Cells["PHANTRAMGIAM"].Value.ToString();
                dtpBatDau.Value = Convert.ToDateTime(row.Cells["NGAYBATDAU"].Value);
                dtpKetThuc.Value = Convert.ToDateTime(row.Cells["NGAYKETTHUC"].Value);
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "" && txtPhanTram.Text != "")
            {
                string ma = txtMa.Text.Trim();

                var existing = db.KHUYENMAIs.FirstOrDefault(vc => vc.MA_KHUYENMAI == ma);
                if (existing != null)
                {
                    MessageBox.Show("Mã voucher đã tồn tại");
                    return;
                }

                KHUYENMAI v = new KHUYENMAI();
                v.MA_KHUYENMAI = ma;
                v.TEN_KHUYENMAI = txtTen.Text.Trim();
                v.PHANTRAMGIAM = decimal.Parse(txtPhanTram.Text);
                v.NGAYBATDAU = dtpBatDau.Value;
                v.NGAYKETTHUC = dtpKetThuc.Value;

                db.KHUYENMAIs.Add(v);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm voucher thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            var v = db.KHUYENMAIs.FirstOrDefault(x => x.MA_KHUYENMAI == ma);
            if (v != null)
            {
                v.TEN_KHUYENMAI = txtTen.Text.Trim();
                v.PHANTRAMGIAM = decimal.Parse(txtPhanTram.Text);
                v.NGAYBATDAU = dtpBatDau.Value;
                v.NGAYKETTHUC = dtpKetThuc.Value;

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật voucher thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã voucher để cập nhật");
            }
        }

        private void btnXoaBaoCao_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            var v = db.KHUYENMAIs.FirstOrDefault(x => x.MA_KHUYENMAI == ma);
            if (v != null)
            {
                db.KHUYENMAIs.Remove(v);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa voucher thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã voucher để xóa");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
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
