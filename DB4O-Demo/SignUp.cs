using Db4objects.Db4o.Linq;
using System;
using System.Windows.Forms;
using Db4objects.Db4o;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;
using Db4oModels.Models;

namespace DB4O_Demo
{
    public partial class SignUp : Form
    {
        private string UserAccountname;
        private string password;
        private string confirm_pass;

        

        public SignUp()
        {
            InitializeComponent();
        }

        // Phương thức kiểm tra để in thông tin người dùng
        public string Check(IObjectContainer db)
        {
            string s = "";
            var result = Database.Query(delegate(UserAccount user)
            {
                return true;
            });
            foreach (UserAccount UserAccount in result)
            {
                s += UserAccount.Name + " " + UserAccount.Password + Environment.NewLine;
            }
            return s;
        }

        private void TaoTaiKhoanButton_Click(object sender, EventArgs e)
        {
            string UserAccountname = textBox1.Text;
            string password = textBox2.Text;
            string confirm_pass = textBox3.Text;

            if (!string.IsNullOrEmpty(UserAccountname) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm_pass))
            {
                // Kiểm tra người dùng đã tồn tại
                IList<UserAccount> existingUserAccounts = Database.Query(delegate (UserAccount u)
                {
                    return u.Name == UserAccountname;
                });
                if (existingUserAccounts.Any())
                {
                    MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.");
                    return;
                }

                // Kiểm tra khớp mật khẩu và xác nhận mật khẩu
                if (password != confirm_pass)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                    return;
                }

                // Thêm người dùng mới
                UserAccount newUserAccount = new UserAccount(UserAccountname, password);
                Database.Store(newUserAccount);
                Database.Commit();
                MessageBox.Show("Đăng ký thành công!");

                // Ẩn form đăng ký và hiện form đăng nhập
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
            this.Close();
        }
    }
}


