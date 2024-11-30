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
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;
using Db4oModels.Models;


namespace DB4O_Demo
{
    public partial class Subject : Form
    {
        private IObjectContainer db4o = Database;
        private string tenmon;
        private int mamon, sotiet;
        public Subject()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Danh sách môn học", font, brush, point);
        }



        // Xuat du lieu tu file ra dataGrid
        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();

            IList<Monhoc> result = db4o.Query(delegate (Monhoc mh)
            {
                return true;
            });

            foreach (var subject in result)
            {
                dataGridView1.Rows.Add(subject.MaMonHoc, subject.TenMh, subject.Credit, subject.Deparment.maKh);
            }

        }


        //Them cot cho dataGrid
        private void Monhoc_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaMh", "Mã môn học");
            dataGridView1.Columns.Add("TenMh", "Tên môn học");
            dataGridView1.Columns.Add("SoTiet", "Số tín chỉ");

            dataGridView1.Columns.Add("Khoa", "Mã khoa");
            dataGridView1.Columns["TenMh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoadDataToDataGridView();
        }

        // nut tim kiem.
        private void FindMonHocButton_Click(object sender, EventArgs e)
        {
            string maMH = dungeonTextBox1.Text;
            string tenMH = dungeonTextBox2.Text;
            string strCredit = dungeonTextBox3.Text;
            int credit;
            int.TryParse(strCredit, out credit);

            tenmon = dungeonTextBox2.Text;


            // Truy vấn các môn học dựa trên điều kiện đã nhập
            //var result = db4o.Query<Monhoc>(s =>
            //    (mamon == 0 || s.MaMh == mamon) &&
            //    (string.IsNullOrEmpty(tenmon) || s.TenMh == tenmon) &&
            //    (sotiet == 0 || s.SoTiet == sotiet)
            //);

            IList<Monhoc> result = db4o.Query(delegate (Monhoc monhoc)
            {
                return (monhoc.MaMonHoc.Equals(maMH) || maMH.Equals("")) &&
                (monhoc.TenMh.Equals(tenMH) || tenMH.Equals("")) &&
                (monhoc.Credit == credit || strCredit.Equals(""));
            });

            // Xóa các hàng cũ trong DataGridView trước khi thêm hàng mới
            dataGridView1.Rows.Clear();

            // Hiển thị kết quả truy vấn trong DataGridView
            foreach (var subject in result)
            {
                dataGridView1.Rows.Add(subject.MaMonHoc, subject.TenMh, subject.Credit, subject.Deparment.maKh);
            }

            // Nếu không tìm thấy kết quả nào
            if (!result.Any())
            {
                MessageBox.Show("Không tìm thấy môn học nào với thông tin đã nhập.");
            }

        }

        static public IList<Monhoc> FindSubject(string maMH, string tenMH, string strCredit, string maKhoa)
        {
            int credit;
            int.TryParse(strCredit, out credit);
            IList<Monhoc> result = Database.Query(delegate (Monhoc monhoc)
            {
                return (string.IsNullOrEmpty(maMH) || monhoc.MaMonHoc.Equals(maMH)) &&
                (string.IsNullOrEmpty(tenMH) || monhoc.TenMh.Equals(tenMH)) &&
                (string.IsNullOrEmpty(strCredit) || monhoc.Credit == credit) &&
                (string.IsNullOrEmpty(maKhoa) || (monhoc.Deparment != null || monhoc.Deparment.maKh.Equals(maKhoa)))
                ;
            });

            return result;
        }

        static public IList<Monhoc> FindExactSubject(string maMH, string tenMH, string strCredit, string maKhoa)
        {
            if (string.IsNullOrEmpty(maMH) && string.IsNullOrEmpty(tenMH)
                && string.IsNullOrEmpty(strCredit) && string.IsNullOrEmpty(maKhoa))
                return null;

            int credit;
            int.TryParse(strCredit, out credit);
            IList<Monhoc> result = Database.Query(delegate (Monhoc monhoc)
            {
                return (string.IsNullOrEmpty(maMH) || monhoc.MaMonHoc.Equals(maMH)) &&
                (string.IsNullOrEmpty(tenMH) || monhoc.TenMh.Equals(tenMH)) &&
                (string.IsNullOrEmpty(strCredit) || monhoc.Credit == credit) &&
                (string.IsNullOrEmpty(maKhoa) || (monhoc.Deparment != null || monhoc.Deparment.maKh.Equals(maKhoa)))
                ;
            });

            return result;
        }

        static public IList<Monhoc> FindSubjectByKhoa(string maKhoa)
        {
            IList<Monhoc> result = Database.Query(delegate (Monhoc monhoc)
            {
                return (monhoc.Deparment != null && monhoc.Deparment.maKh.Equals(maKhoa));
            });

            return result;

        }



        // Nut reset
        private void ResetFindMonHocButton_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            new AddMonHoc().ShowDialog();
        }
    }
}
