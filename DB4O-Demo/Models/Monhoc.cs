using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DB4O_Demo.Models
{
    internal class Monhoc
    {
        public Khoa Deparment { get; set; }

        public int SoTiet { get; set; }

        public string TenMh { get; set; }
        
        public string MaMonHoc { get; set; }

        public Monhoc(string maMH, string tenMh, int sotiet, Khoa Department)
        {
            this.MaMonHoc = maMH;
            this.TenMh = tenMh;
            this.SoTiet = sotiet;
            this.Deparment = Deparment;
        }
    }
}