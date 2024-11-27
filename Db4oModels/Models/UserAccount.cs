using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Db4oModels.Models
{
    public class UserAccount
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public UserAccount(string username, string password)
        {
            Name = username;
            Password = password;
        }
        public override string ToString()
        {
            return $"Tên: {Name}, Mật khẩu: {Password}";
        }

    }


}
