using DB4O_Demo.Models;
using Db4objects.Db4o;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;

namespace DB4O_Demo
{
    public partial class LogIn : Form
    {
        private String username;
        private String password;

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text; 
            password = textBox2.Text;
            try
            {
                IList<UserAccount> result = Database.Query(delegate (UserAccount user)
                {
                    return user.Name.Equals(username) && user.Password.Equals(password);
                });

                if (result.Any())
                {
                    Menu menu = new Menu(username);
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
