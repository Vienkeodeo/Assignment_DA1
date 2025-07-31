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
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            BookForm f1 = new BookForm();
            this.Hide();  
            f1.Show();    
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            NhanVienForm nhanVien = new NhanVienForm();
            nhanVien.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            this.Close();
            TacGia tacGia = new TacGia();
            tacGia.Show();
        }
        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Close();
            Voucher voucher = new Voucher();
            voucher.Show();
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            this.Close();
            NHAXB nHAXB = new NHAXB();
            nHAXB.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào: {CurrentUser.Username.ToString().ToUpper()}";

            if (CurrentUser.Role == "STAFF")
            {
                btnNhanVien.Enabled = false;
                btnTacGia.Enabled = false;
                btnVoucher.Enabled = false;
                btnNXB.Enabled = false;
                btnTacGia.Enabled = false;           
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
