using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Db4oModels.Models
{
    public class Monhoc
    {
        public Khoa Deparment { get; set; }

        public int Credit { get; set; }

        public string TenMh { get; set; }
        
        public string MaMonHoc { get; set; }

        public Monhoc(string maMH, string tenMh, int credit, Khoa Department)
        {
            this.MaMonHoc = maMH;
            this.TenMh = tenMh;
            this.Credit = credit;
            this.Deparment = Deparment;
        }
    }
}