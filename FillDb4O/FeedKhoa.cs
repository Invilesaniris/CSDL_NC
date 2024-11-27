using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4oModels.Models;

namespace FeedData
{
    internal class FeedKhoa
    {
        

        static internal void FeedDeparment()
        {
            var khoaList = new List<Khoa>
            {
                new Khoa("CS01", "Computer Science"),
                new Khoa("EE02", "Electrical Engineering"),
                new Khoa("PH04", "Physics"),
                new Khoa("MA06", "Mathematics")
            };
            foreach (var khoa in khoaList)
            {
                GlobalDb4oAcces.StoreUpdate(khoa);
            }
        }
    }
}
