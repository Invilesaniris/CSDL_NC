using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4O_Demo
{
    internal class Diem
    {
        public string MaSo;
        public double point;
        public int MaMh;
        public Diem(string MaSo, int MaMh,double point)
        {
            this.MaSo = MaSo;
            this.MaMh = MaMh;
            this.point = point;
        }
    }
}
