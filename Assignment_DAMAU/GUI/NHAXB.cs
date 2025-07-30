using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_DAMAU.DAL;

namespace Assignment_DAMAU.GUI
{
    public partial class NHAXB: Form
    {
        SACHEntities3 db = new SACHEntities3();
        public NHAXB()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var dsNXB = db.NXBs.ToList();
            dgvDanhSach.DataSource = dsNXB;
        }
        public void Xoa()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtTimKiem.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != "" && txtTenNXB.Text != "")
            {
                string ma = txtMaNXB.Text.Trim();
                var check = db.NXBs.FirstOrDefault(x => x.MA_NXB == ma);
                if (check != null)
                {
                    MessageBox.Show("Mã NXB đã tồn tại");
                    return;
                }

                NXB n = new NXB();
                n.MA_NXB = ma;
                n.TEN_NXB = txtTenNXB.Text;
                n.EMAIL = txtEmail.Text;
                n.SDT = txtSDT.Text.Trim();

                db.NXBs.Add(n);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm NXB thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
        private void NXB_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMaNXB.Text.Trim();
            var n = db.NXBs.FirstOrDefault(x => x.MA_NXB == ma);
            if (n != null)
            {
                n.TEN_NXB = txtTenNXB.Text.Trim();
                n.EMAIL = txtEmail.Text.Trim();
                n.SDT = txtSDT.Text.Trim();

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy NXB để cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNXB.Text.Trim();
            var n = db.NXBs.FirstOrDefault(x => x.MA_NXB == ma);
            if (n != null)
            {
                n.TEN_NXB = txtTenNXB.Text.Trim();
                n.EMAIL = txtEmail.Text.Trim();
                n.SDT = txtSDT.Text.Trim();

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công");
                Xoa();
            }
            else
            {
                MessageBox.Show("Không tìm thấy NXB để cập nhật");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells["MA_NXB"].Value.ToString();
                txtTenNXB.Text = row.Cells["TEN_NXB"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
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
