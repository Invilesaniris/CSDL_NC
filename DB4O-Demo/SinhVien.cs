using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4O_Demo
{
    internal class SinhVien
    {
        public string nameSV;
        public string phone;
        public string maSV;
        public string maKh;
        public SinhVien(string maSV, string maKh,string nameSV, string phone)
        {
            this.maSV = maSV;
            this.maKh = maKh;
            this.nameSV = nameSV;
            this.phone = phone;
        }
    }
}
