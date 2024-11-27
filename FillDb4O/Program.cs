// See https://aka.ms/new-console-template for more information

using Db4oModels.Models;
using FeedData;
using FillDb4O;

FeedKhoa.FeedDeparment();
FeedSubject.FeedMonHoc();
FeedSinhVien.FeedStudent();
FeedGrade.FeedDiem();


//Khoa CS = GlobalDb4oAcces.DelegateSQL<Khoa>(delegate (Khoa khoa) {
//    return khoa.maKh.Equals("CS01");
//})[0];

//Console.WriteLine(CS.name);
