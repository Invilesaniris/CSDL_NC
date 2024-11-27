using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o.Internal.CS.Messages;
using Db4oModels.Models;
using FeedData;

namespace FillDb4O
{
    internal class FeedGrade
    {
        static internal void FeedDiem()
        {

            SinhVien sv1 = GlobalDb4oAcces.DelegateSQL<SinhVien>(delegate (SinhVien sv)
            {
                return sv.maSV.Equals("S001");
            })[0];

            SinhVien sv2 = GlobalDb4oAcces.DelegateSQL<SinhVien>(delegate (SinhVien sv)
            {
                return sv.maSV.Equals("S002");
            })[0];

            SinhVien sv3 = GlobalDb4oAcces.DelegateSQL<SinhVien>(delegate (SinhVien sv)
            {
                return sv.maSV.Equals("S003");
            })[0];

            Monhoc mh1 = GlobalDb4oAcces.DelegateSQL<Monhoc>(delegate (Monhoc mh)
            {
                return mh.MaMonHoc.Equals("CS101");
            })[0];
            Monhoc mh2 = GlobalDb4oAcces.DelegateSQL<Monhoc>(delegate (Monhoc mh)
            {
                return mh.MaMonHoc.Equals("CS102");
            })[0];
            Monhoc mh3 = GlobalDb4oAcces.DelegateSQL<Monhoc>(delegate (Monhoc mh)
            {
                return mh.MaMonHoc.Equals("EE101");
            })[0];



            IList<Diem> diemList = new List<Diem>()
            {
                new Diem(sv1, mh1, 8),
                new Diem(sv2, mh2, 3),
                new Diem(sv3, mh3, 6),
            };

            foreach(Diem diem in diemList)
            {
                GlobalDb4oAcces.StoreUpdate(diem);
            }
        }


    }
}
