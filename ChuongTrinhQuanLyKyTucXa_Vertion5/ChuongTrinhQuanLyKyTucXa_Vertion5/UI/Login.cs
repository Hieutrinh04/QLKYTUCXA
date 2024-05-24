using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5
{
    public partial class Login : Form
    {
        private DashBroad dbs;

        public Login()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Đây là chỗ để xử lý sự kiện thay đổi văn bản nếu cần
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra tên người dùng và mật khẩu nhập vào có khớp với giá trị mong đợi không
            if (username == "hieu" && password == "pass")
            {
                // Nếu thông tin đăng nhập đúng, tạo và hiển thị form DashBroad
                dbs = new DashBroad();
                dbs.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                // Nếu thông tin đăng nhập sai, hiển thị hộp thoại thông báo và đặt con trỏ vào trường mật khẩu
                MessageBox.Show("Vui lòng nhập đúng thông tin đăng nhập", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                txtPassword.SelectAll(); // Chọn toàn bộ văn bản trong ô mật khẩu để người dùng có thể nhập lại dễ dàng
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Đây là chỗ để xử lý sự kiện tải nếu cần
        }
    }
}
