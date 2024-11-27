using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DB4O_Demo.Models;
using Db4objects.Db4o;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;

namespace DB4O_Demo
{
    public partial class Student : Form
    {
        private string maSV, khoa, hoten;

        public Student()
        {
            InitializeComponent();
            creatSV();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 19);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Thông tin sinh viên", font, brush, point);
        }

        private void creatSV()
        {


            IList<SinhVien> result = Database.Query(delegate (SinhVien sv)
            {
                return true;
            });

            if (!result.Any())
            {
                List<SinhVien> svList = new List<SinhVien>
                {
                    new SinhVien("1", "CNTT", "Nguyễn Văn A", "0901234567"),
                    new SinhVien("2", "MT", "Lê Thị B", "0902345678"),
                    new SinhVien("3", "KTE", "Trần Văn C", "0903456789"),
                    new SinhVien("4", "CNTT", "Phạm Thị D", "0904567890"),
                    new SinhVien("5","QTKD", "Hoàng Văn E", "0905678901"),
                    new SinhVien("6", "KTD", "Ngô Thị F", "0906789012"),
                    new SinhVien("7", "MT", "Đặng Văn G", "0907890123"),
                    new SinhVien("8", "SH", "Vũ Thị H", "0908901234"),
                    new SinhVien("9", "MT", "Dương Văn I", "0909012345"),
                    new SinhVien("10", "SH", "Bùi Thị K", "0910123456")
                };

                // Lưu danh sách sinh viên vào DB4O
                foreach (var sinhvien in svList)
                {
                    Database.Store(sinhvien);
                }
                Database.Commit();
            }
        }

        // Phương thức tải dữ liệu vào DataGridView
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();

            IList<SinhVien> sinhVienList = Database.Query(delegate (SinhVien sv)
            {
                return true;
            });

            IList<Khoa> khoaList = Database.Query(delegate (Khoa khoa)
            {
                return true;
            });

            foreach (var sv in sinhVienList)
            {
                var khoa = khoaList.FirstOrDefault(k => k.maKh == sv.maKh);

                string khoa_name = khoa != null ? khoa.name : "N/A";

                dataGridView1.Rows.Add(sv.maSV, sv.nameSV, sv.phone, khoa_name);
            }

        }

        private void Student_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaSV", "Mã sinh viên");
            dataGridView1.Columns.Add("NameSV", "Họ tên");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("KhoaName", "Khoa");
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
                var result = db4o.Query<SinhVien>(s =>
                    (string.IsNullOrEmpty(maSV) || s.maSV == maSV) &&
                    (string.IsNullOrEmpty(khoa) || s.maKh == khoa) &&
                    (string.IsNullOrEmpty(hoten) || s.nameSV == hoten)
                );

                dataGridView1.Rows.Clear();
                var khoa_query = db4o.Query<Khoa>();
                foreach (var sv in result)
                {
                    var khoa = khoa_query.FirstOrDefault(k => k.maKh == sv.maKh);
                    string khoa_name = khoa != null ? khoa.name : "N/A";
                    dataGridView1.Rows.Add(sv.maSV, sv.nameSV, sv.phone, khoa_name);
                }

                if (!result.Any())
                {
                    MessageBox.Show("Không tìm thấy môn học nào với thông tin đã nhập.");
                }
                db4o.Close();
            }
            else
            {
                db4o.Close();
                LoadDataToDataGridView();
            }
        }

        private void ResetThemSVButton_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void ThemSVButton_Click(object sender, EventArgs e)
        {
            ///
        }
    }
}
