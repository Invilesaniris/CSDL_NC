using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o;


namespace DB4O_Demo
{
    public partial class Subject : Form
    {
        private IObjectContainer db4o;
        private string tenmon;
        private int mamon, sotiet;
        public Subject()
        {
            InitializeComponent();
            CreatSubject();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Danh sách môn học", font, brush, point);
        }

        // Tạo đối tượng và thêm vào file.
        private void CreatSubject()
        {
            db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o");
            var result = db4o.Query<Monhoc>();
            if (!result.Any())
            {
                List<Monhoc> subjects = new List<Monhoc>
                {
                    new Monhoc(1, "Lập trình Cơ bản", 45),
                    new Monhoc(2, "Cấu trúc Dữ liệu và Giải thuật", 50),
                    new Monhoc(3, "Lập trình Hướng đối tượng", 45),
                    new Monhoc(4, "Cơ sở Dữ liệu", 40),
                    new Monhoc(5, "Mạng Máy tính", 35),
                    new Monhoc(6, "Hệ điều hành", 30),
                    new Monhoc(7, "Phát triển Web", 50),
                    new Monhoc(8, "An toàn Thông tin", 30),
                    new Monhoc(9, "Trí tuệ Nhân tạo", 40),
                    new Monhoc(10, "Học máy (Machine Learning)", 40)
                };
                foreach (var subject in subjects)
                {
                    db4o.Store(subject);
                }
                db4o.Commit();
                db4o.Close();
            }
            else
            {
                db4o.Close();
            }
        }


        // Xuat du lieu tu file ra dataGrid
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();
            using (IObjectContainer db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o"))
            {
                var result = db4o.Query<Monhoc>();

                foreach (var subject in result)
                {
                    dataGridView1.Rows.Add(subject.MaMh, subject.TenMh, subject.SoTiet);
                }
            }
            db4o.Close();
        }


        //Them cot cho dataGrid
        private void Monhoc_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaMh", "Mã môn học");
            dataGridView1.Columns.Add("TenMh", "Tên môn học");
            dataGridView1.Columns.Add("SoTiet", "Số tiết");
            dataGridView1.Columns["TenMh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoadDataToDataGridView();
        }

        // nut tim kiem.
        private void button1_Click(object sender, EventArgs e)
        {
            db4o = Db4oFactory.OpenFile("DB4O_DEMO.db4o");
            int.TryParse(dungeonTextBox1.Text, out mamon);
            int.TryParse(dungeonTextBox3.Text, out sotiet);
            tenmon = dungeonTextBox2.Text;

            if (!string.IsNullOrEmpty(tenmon) || mamon != 0 || sotiet != 0)
            {
                // Truy vấn các môn học dựa trên điều kiện đã nhập
                var result = db4o.Query<Monhoc>(s =>
                    (mamon == 0 || s.MaMh == mamon) &&
                    (string.IsNullOrEmpty(tenmon) || s.TenMh == tenmon) &&
                    (sotiet == 0 || s.SoTiet == sotiet)
                );

                // Xóa các hàng cũ trong DataGridView trước khi thêm hàng mới
                dataGridView1.Rows.Clear();

                // Hiển thị kết quả truy vấn trong DataGridView
                foreach (var subject in result)
                {
                    dataGridView1.Rows.Add(subject.MaMh, subject.TenMh, subject.SoTiet);
                }

                // Nếu không tìm thấy kết quả nào
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

        // Nut reset
        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
