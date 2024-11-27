using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4oModels.Models;
using FeedData;

namespace FillDb4O
{
    internal class FeedSubject
    {
        static internal void FeedMonHoc()
        {
            Khoa CS = GlobalDb4oAcces.DelegateSQL<Khoa>(delegate (Khoa khoa){
                return khoa.maKh.Equals("CS01");
            })[0];
            Khoa EE = GlobalDb4oAcces.DelegateSQL<Khoa>(delegate (Khoa khoa){
                return khoa.maKh.Equals("EE02");
            })[0];
            Khoa PH = GlobalDb4oAcces.DelegateSQL<Khoa>(delegate (Khoa khoa){
                return khoa.maKh.Equals("PH04");
            })[0];
            Khoa MA = GlobalDb4oAcces.DelegateSQL<Khoa>(delegate (Khoa khoa){
                return khoa.maKh.Equals("MA06");
            })[0];

            IList<Monhoc> monHocList = new List<Monhoc>()
            {
                new Monhoc("CS101", "Introduction to Computer Science", 3, CS),
                new Monhoc("CS102", "Data Structures and Algorithms", 4, CS),
                new Monhoc("CS103", "Operating Systems", 4, CS),

                new Monhoc("EE101", "Circuits and Systems", 3, EE),
                new Monhoc("EE102", "Digital Signal Processing", 3, EE),
                new Monhoc("EE103", "Microelectronics and Semiconductor Devices", 4, EE),

                new Monhoc("PH101", "Classical Mechanics", 3, PH),
                new Monhoc("PH102", "Electromagnetism", 3, PH),
                new Monhoc("PH103", "Quantum Mechanics", 4, PH),

                new Monhoc("MA101", "Calculus I", 3, MA),
                new Monhoc("MA102", "Calculus II", 3, MA),
                new Monhoc("MA103", "Linear Algebra", 3, MA),
                new Monhoc("MA104", "Discrete Mathematics", 3, MA)
            };

            GlobalDb4oAcces.StoreUpdate(monHocList);

        }

    }
}
