﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB4O_Demo.Models
{
    internal class Diem
    {
        public SinhVien Student { get; set; }
        public double point { get; set; }
        public Monhoc Subject { get; set; }

        public Diem(SinhVien Student, Monhoc Subject, double point)
        {
            this.Student = Student;
            this.Subject = Subject;
            this.point = point;
        }
    }
}
