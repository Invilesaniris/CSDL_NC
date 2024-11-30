using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db4oModels.Models
{
    public class Khoa
    {
        public string maKh { get; set; }
        public string name { get; set; }
        public Khoa(string maKh, string name)
        {
            this.maKh = maKh;
            this.name = name;
        }
        public Khoa() { }
    }
}
