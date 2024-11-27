using Db4oModels.Models;
using FeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillDb4O
{
    internal class FeedSinhVien
    {
        static internal void FeedStudent()
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

            IList<SinhVien> sinhVienList= new List<SinhVien>()
            {
                new SinhVien("S001", CS ,"Alice Johnson", "555-1234"),
                new SinhVien("S002", EE ,"Bob Smith", "555-5678"),
                new SinhVien("S003", PH ,"Charlie Brown", "555-9876"),
                new SinhVien("S004", MA ,"Diana White", "555-4321"),
                new SinhVien("S005", CS ,"Edward Davis", "555-8765"),
                new SinhVien("S006", EE ,"Fiona Green", "555-6543"),
                new SinhVien("S007", PH ,"George Harris", "555-2345"),
                new SinhVien("S008", MA ,"Hannah King", "555-3456"),
                new SinhVien("S009", CS ,"Iris Lee", "555-5679"),
                new SinhVien("S010", EE ,"Jack Taylor", "555-6780")
            };
            foreach(var s in sinhVienList)
            {
                GlobalDb4oAcces.StoreUpdate(s);
            }

        }

    }
}
