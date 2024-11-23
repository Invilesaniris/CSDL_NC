using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DB4O_Demo
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            this.Name = username;
            this.Password = password;
        }
        public override string ToString() {
            return $"Tên: {Name}, Mật khẩu: {Password}";
        }

    }
    
    
}
