using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;
using Db4oModels.Models;
using System.Security.Cryptography.X509Certificates;

namespace DB4O_Demo
{
    public partial class Student : Form
    {
        private string maSV, khoa, hoten;

        public Student()
        {
            InitializeComponent();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 19);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Thông tin sinh viên", font, brush, point);
        }

        

        // Phương thức tải dữ liệu vào DataGridView
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();

            IList<SinhVien> sinhVienList = Database.Query(delegate (SinhVien sv)
            {
                return true;
            });


            foreach (var sv in sinhVienList)
            {

                string khoa_name = (sv.department != null) ? sv.department.name : "N/A";
                string makhoa = (sv.department != null) ? sv.department.maKh : "N/A";

                dataGridView1.Rows.Add(sv.maSV, sv.nameSV, sv.phone, khoa_name, makhoa);
            }

        }

        private void Student_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaSV", "Mã sinh viên");
            dataGridView1.Columns.Add("NameSV", "Họ tên");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("KhoaName", "Khoa");
            dataGridView1.Columns.Add("MaKhoa", "Mã khoa");
            dataGridView1.Columns["KhoaName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoadDataToDataGridView();
        }


        // Tìm kiếm
        private void TimKiemSVButton_Click(object sender, EventArgs e)
        {
            maSV = dungeonTextBox1.Text;
            khoa = dungeonTextBox2.Text;
            hoten = dungeonTextBox3.Text;
            var db4o = Database;
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(khoa) || string.IsNullOrEmpty(hoten))
            {
                //var result = db4o.Query<SinhVien>(s =>
                //    (string.IsNullOrEmpty(maSV) || s.maSV == maSV) &&
                //    (string.IsNullOrEmpty(khoa) || s.maKh == khoa) &&
                //    (string.IsNullOrEmpty(hoten) || s.nameSV == hoten)
                //);

                IList<SinhVien> result = db4o.Query(delegate (SinhVien sv)
                {
                    return (sv.maSV.Equals(maSV) || (string.IsNullOrEmpty(maSV)) &&
                    (sv.department.maKh.Equals(khoa) || string.IsNullOrEmpty(khoa)) &&
                    (sv.nameSV.Equals(hoten) || (string.IsNullOrEmpty(hoten))));
                });

                dataGridView1.Rows.Clear();
                foreach (var sv in result)
                {

                    string khoa_name = (sv.department != null) ? sv.department.name : "N/A";
                    string makhoa = (sv.department != null) ? sv.department.maKh : "N/A";

                    dataGridView1.Rows.Add(sv.maSV, sv.nameSV, sv.phone, khoa_name, makhoa);
                }

                if (!result.Any())
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào với thông tin đã nhập.");
                }

            }
            else
            {

                LoadDataToDataGridView();
            }
        }

        private void ResetThemSVButton_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        static public IList<SinhVien> FindSinhVien(string maSV, string khoa, string hoten)
        {
            IList < SinhVien > result = Database.Query(delegate (SinhVien sv)
            {
                return (sv.maSV.Equals(maSV) || (string.IsNullOrEmpty(maSV)) &&
                (sv.department.maKh.Equals(khoa) || string.IsNullOrEmpty(khoa)) &&
                (sv.nameSV.Equals(hoten) || (string.IsNullOrEmpty(hoten))));
            });
            return result;
        }

        static public IList<SinhVien> FindSinhVienByKhoa(string khoa)
        {
            IList<SinhVien> result = Database.Query(delegate (SinhVien sv)
            {
                return
                (sv.department != null && sv.department.maKh.Equals(khoa));
            });
            return result;
        }

        private void ThemSVButton_Click(object sender, EventArgs e)
        {
            ///
        }
    }
}
