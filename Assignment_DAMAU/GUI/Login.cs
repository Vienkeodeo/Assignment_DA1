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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            using (var db = new SACHEntities3())
            {
                var user = db.PhanQuyens
                             .FirstOrDefault(u => u.USERNAME == username && u.PASSWORD == password);

                if (user != null)
                {
                    CurrentUser.Username = user.USERNAME;
                    CurrentUser.Role = user.ROLE;

                    // Mở form chính
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
