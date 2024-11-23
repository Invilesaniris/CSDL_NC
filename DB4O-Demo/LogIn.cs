using Db4objects.Db4o;
namespace DB4O_Demo
{
    public partial class LogIn : Form
    {
        private IObjectContainer db = Db4oFactory.OpenFile("DB4O_DEMO.db4o");
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
                var result = db.Query<User>(user => user.Name == username && user.Password == password);

                if (result.Any())
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Menu menu = new Menu(username);
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
                }
            }
            finally
            {
                db.Close();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(db);
            this.Hide();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
