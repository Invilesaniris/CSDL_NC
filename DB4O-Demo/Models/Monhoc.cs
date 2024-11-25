using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DB4O_Demo.Models
{
    internal class Monhoc
    {
        public int MaMh { get; set; }

        public int SoTiet { get; set; }

        public string TenMh { get; set; }
        public Monhoc(int maMh, string tenMh, int sotiet)
        {
            MaMh = maMh;
            TenMh = tenMh;
            SoTiet = sotiet;
        }
    }
}