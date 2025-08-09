using Assignment_DAMAU.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_DAMAU.GUI
{
    public partial class BookForm: Form
    {
        SACHEntities3 db = new SACHEntities3();
        private byte[] ImageToByteArray(PictureBox pb)
        {
            if (pb.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(pb.Image))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                }
                return ms.ToArray();
            }
        }

        private void ByteArrayToImage(byte[] data, PictureBox pb)
        {
            if (data == null)
            {
                pb.Image = null;
                return;
            }
            using (MemoryStream ms = new MemoryStream(data))
            {
                pb.Image = new Bitmap(Image.FromStream(ms));
            }
        }
        public void LoadData()
        {
            dgvDanhSach.DataSource = db.SACHes.Include(s => s.THELOAI)
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

            var sach = db.SACHes.ToList();
            txtTenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenSach.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection tenSachCollection = new AutoCompleteStringCollection();
            tenSachCollection.AddRange(sach.Select(s => s.TEN_SACH).ToArray());

            txtTenSach.AutoCompleteCustomSource = tenSachCollection;

            var dsTheLoai = db.THELOAIs.ToList();
            cboTheLoai.DataSource = dsTheLoai;
            cboTheLoai.DisplayMember = "TEN_THELOAI";
            cboTheLoai.ValueMember = "MA_THELOAI";

            var dsNXB = db.NXBs.ToList();
            cboNXB.DataSource = dsNXB;
            cboNXB.DisplayMember = "TEN_NXB";
            cboNXB.ValueMember = "MA_NXB";

            var dsNhaCungCap = db.NHACUNGCAPs.ToList();
            cboNCC.DataSource = dsNhaCungCap;
            cboNCC.DisplayMember = "TEN_NHACUNGCAP";
            cboNCC.ValueMember = "MA_NHACUNGCAP";
        }

        public BookForm()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtTenSach.Text != "" && cboTheLoai.SelectedIndex >= 0 && txtGia.Text != ""
               && cboNXB.SelectedIndex >= 0  && cboNCC.SelectedIndex >= 0)
            {
                try
                {
                    SACH sach = new SACH();
                    sach.MA_SACH = txtMaSach.Text;
                    sach.TEN_SACH = txtTenSach.Text;
                    sach.MA_THELOAI = cboTheLoai.SelectedValue.ToString();
                    sach.MA_NXB = cboNXB.SelectedValue.ToString();
                    sach.MA_NHACUNGCAP = cboNCC.SelectedValue.ToString();
                    sach.SOLUONGTON = int.Parse(txtSoLuongTon.Text);
                    sach.GIA = decimal.Parse(txtSoLuongTon.Text);
                    sach.ANH = ImageToByteArray(pbAnhSach);


                    db.SACHes.Add(sach);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Thêm sách thành công");
                    Xoa();
                }
                catch
                {
                    MessageBox.Show("Kiểm tra dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ dữ liệu");
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                var sach = db.SACHes.FirstOrDefault(s => s.MA_SACH == txtMaSach.Text);
                if (sach != null)
                {
                    sach.TEN_SACH = txtTenSach.Text;
                    sach.MA_THELOAI = cboTheLoai.SelectedValue.ToString();
                    sach.MA_NXB = cboNXB.SelectedValue.ToString();
                    sach.MA_NHACUNGCAP = cboNCC.SelectedValue.ToString();
                    sach.SOLUONGTON = int.Parse(txtSoLuongTon.Text);
                    sach.GIA = decimal.Parse(txtGia.Text);
                    sach.ANH = ImageToByteArray(pbAnhSach);


                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật sách thành công");
                    Xoa();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sách để cập nhật");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sách cần cập nhật");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                var sach = db.SACHes.FirstOrDefault(s => s.MA_SACH == txtMaSach.Text);
                if (sach != null)
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.SACHes.Remove(sach);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa sách thành công");
                        Xoa();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sách để xóa");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sách cần xóa");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Xoa();
        }
        public void Xoa()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoLuongTon.Clear();
            txtGia.Clear();
            cboTheLoai.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
            cboNCC.SelectedIndex = -1;
            txtTimKiem.Clear();
            pbAnhSach.Image = null;
            txtDuongDanAnh.Clear();

            LoadData();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                string maSach = dgvDanhSach.Rows[e.RowIndex].Cells["MA_SACH"].Value.ToString();
                var sach = db.SACHes.FirstOrDefault(s => s.MA_SACH == maSach);
                if (sach != null)
                {
                    txtMaSach.Text = sach.MA_SACH;
                    txtTenSach.Text = sach.TEN_SACH;
                    txtGia.Text = sach.GIA.ToString();
                    txtSoLuongTon.Text = sach.SOLUONGTON.ToString();

                    cboNXB.SelectedValue = sach.MA_NXB;
                    cboTheLoai.SelectedValue = sach.MA_THELOAI;
                    cboNCC.SelectedValue = sach.MA_NHACUNGCAP;

                    if (sach.ANH != null)
                    {
                        using (MemoryStream ms = new MemoryStream(sach.ANH))
                        {
                            pbAnhSach.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbAnhSach.Image = null; // Không có ảnh
                    }
                    if (sach.ANH != null)
                    {
                        ByteArrayToImage(sach.ANH, pbAnhSach);
                        txtDuongDanAnh.Text = "[Ảnh từ cơ sở dữ liệu]";
                    }
                    else
                    {
                        pbAnhSach.Image = null;
                        txtDuongDanAnh.Clear();
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();  
            main.Show();
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load ảnh an toàn bằng cách copy
                using (var tempImg = Image.FromFile(ofd.FileName))
                {
                    pbAnhSach.Image = new Bitmap(tempImg);
                }
                pbAnhSach.SizeMode = PictureBoxSizeMode.Zoom;
                txtDuongDanAnh.Text = ofd.FileName; // Hiện đường dẫn ảnh
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text.Trim();

            if (!string.IsNullOrEmpty(tenSach))
            {
                var sach = db.SACHes.FirstOrDefault(s => s.TEN_SACH == tenSach);
                if (sach != null)
                {
                    txtMaSach.Text = sach.MA_SACH;
                    txtGia.Text = sach.GIA.ToString();
                    txtSoLuongTon.Text = sach.SOLUONGTON.ToString();

                    cboTheLoai.SelectedValue = sach.MA_THELOAI;
                    cboNXB.SelectedValue = sach.MA_NXB;
                    cboNCC.SelectedValue = sach.MA_NHACUNGCAP;

                    if (sach.ANH != null)
                    {
                        ByteArrayToImage(sach.ANH, pbAnhSach);
                        txtDuongDanAnh.Text = "[Ảnh từ cơ sở dữ liệu]";
                    }
                    else
                    {
                        pbAnhSach.Image = null;
                        txtDuongDanAnh.Clear();
                    }
                }
            }
        }
    }
}
