using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db4oModels.Models
{
    public class SinhVien
    {
        public string nameSV { get; set; }
        public string phone { get; set; }
        public string maSV { get; set; }
        public Khoa department { get; set; }

        public SinhVien(string maSV, Khoa deparment, string nameSV, string phone)
        {
            this.maSV = maSV;
            this.department= deparment;
            this.nameSV = nameSV;
            this.phone = phone;
        }
    }
}
