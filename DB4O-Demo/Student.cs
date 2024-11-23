using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace DB4O_Demo
{
    public partial class Student : Form
    {
        private IObjectContainer db4o;
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
            db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o");

            var result = db4o.Query<SinhVien>();
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
                    db4o.Store(sinhvien);
                }
                db4o.Commit();
            }
            db4o.Close();
        }

        // Phương thức tải dữ liệu vào DataGridView
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();
            using (IObjectContainer db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o"))
            {
                var sinhVienList = db4o.Query<SinhVien>();
                var khoaList = db4o.Query<Khoa>();

                foreach (var sv in sinhVienList)
                {
                    var khoa = khoaList.FirstOrDefault(k => k.maKh == sv.maKh);

                    string khoa_name = khoa != null ? khoa.name : "N/A";

                    dataGridView1.Rows.Add(sv.maSV, sv.nameSV, sv.phone, khoa_name);
                }
                db4o.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            maSV = dungeonTextBox1.Text;
            khoa = dungeonTextBox2.Text;
            hoten = dungeonTextBox3.Text;
            db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o");
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
                    dataGridView1.Rows.Add(sv.maSV, sv.nameSV,sv.phone, khoa_name);
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

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
