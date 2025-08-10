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
    public partial class TacGia: Form
    {
        SACHEntities3 db = new SACHEntities3();
        public void LoadData()
        {
            var dstg = db.TACGIAs.Select(t => new
            {
                t.MA_TACGIA,
                t.HOTEN
            }).ToList();
            dgvDanhSach.DataSource = dstg;
            dgvDanhSach.Columns["MA_TACGIA"].HeaderText = "Mã tác giả";
            dgvDanhSach.Columns["HOTEN"].HeaderText = "Họ tên";
        }
        public void Xoa()
        {
            txtMa.Clear();
            txtTen.Clear();
        }
        public TacGia()
        {
            InitializeComponent();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMa.Text = row.Cells["MA_TACGIA"].Value.ToString();
                txtTen.Text = row.Cells["HOTEN"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "")
            {
                try
                {
                    TACGIA tg = new TACGIA();
                    tg.MA_TACGIA = txtMa.Text;
                    tg.HOTEN = txtTen.Text;

                    db.TACGIAs.Add(tg);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm tác giả thành công");
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
            string ma = txtMa.Text;
            var tg = db.TACGIAs.FirstOrDefault(x => x.MA_TACGIA == ma);
            if (tg != null)
            {
                tg.HOTEN = txtTen.Text;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tác giả để cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            var tg = db.TACGIAs.FirstOrDefault(x => x.MA_TACGIA == ma);
            if (tg != null)
            {
                db.TACGIAs.Remove(tg);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa tác giả thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tác giả để xóa");
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

            var ketQua = db.TACGIAs
                .Where(tg => tg.MA_TACGIA.Contains(tuKhoa) || tg.HOTEN.Contains(tuKhoa))
                .ToList();

            if (ketQua.Count > 0)
            {
                dgvDanhSach.DataSource = ketQua;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tác giả phù hợp.");
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
