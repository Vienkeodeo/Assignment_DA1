using Assignment_DAMAU.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_DAMAU.GUI
{
    public partial class NhaCungCap : Form
    {
        SACHEntities3 db = new SACHEntities3();
        public NhaCungCap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var dsNCC = db.NHACUNGCAPs.Select(n => new
            {
                n.MA_NHACUNGCAP,
                n.TEN_NHACUNGCAP,
                n.DIACHI,
                n.SDT
            }).ToList();
            dgvDanhSach.DataSource = dsNCC;
        }
        public void Xoa()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtTimKiem.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text != "" && txtTenNCC.Text != "")
            {
                string ma = txtMaNCC.Text.Trim();
                var check = db.NHACUNGCAPs.FirstOrDefault(x => x.MA_NHACUNGCAP == ma);
                if (check != null)
                {
                    MessageBox.Show("Mã Nhà cung cấp đã tồn tại");
                    return;
                }

                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.MA_NHACUNGCAP = ma;
                ncc.TEN_NHACUNGCAP = txtTenNCC.Text.Trim();
                ncc.DIACHI = txtDiaChi.Text.Trim();
                ncc.SDT = txtDienThoai.Text.Trim();

                db.NHACUNGCAPs.Add(ncc);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm Nhà cung cấp thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();
            var ncc = db.NHACUNGCAPs.FirstOrDefault(x => x.MA_NHACUNGCAP == ma);
            if (ncc != null)
            {
                ncc.TEN_NHACUNGCAP = txtTenNCC.Text.Trim();
                ncc.DIACHI = txtDiaChi.Text.Trim();
                ncc.SDT = txtDienThoai.Text.Trim();

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy Nhà cung cấp để cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Text.Trim();
            var ncc = db.NHACUNGCAPs.FirstOrDefault(x => x.MA_NHACUNGCAP == ma);
            if (ncc != null)
            {
                db.NHACUNGCAPs.Remove(ncc);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Xóa thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy Nhà cung cấp để xóa");
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var dsNCC = db.NHACUNGCAPs
                          .Where(x => x.TEN_NHACUNGCAP.Contains(keyword) || x.MA_NHACUNGCAP.Contains(keyword))
                          .ToList();
            dgvDanhSach.DataSource = dsNCC;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MA_NHACUNGCAP"].Value.ToString();
                txtTenNCC.Text = row.Cells["TEN_NHACUNGCAP"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtDienThoai.Text = row.Cells["SDT"].Value.ToString();
            }
        }

        private void btnTroLai_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
