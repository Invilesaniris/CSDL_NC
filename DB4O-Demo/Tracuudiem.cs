using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;

namespace DB4O_Demo
{
    public partial class Tracuudiem : Form
    {
        private IObjectContainer db4o=Database;
        public Tracuudiem()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(215, 12);
            g.DrawString("Xem điểm", font, brush, point);
        }

        private void Tracuudiem_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MaSV", "Mã sinh viên");
            dataGridView1.Columns.Add("nameSV", "Họ tên");
            dataGridView1.Columns.Add("nameMh", "Môn học");
            dataGridView1.Columns.Add("diem", "Điểm");
            dataGridView1.Columns["nameMh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            dataGridView1.Rows.Clear();
            
            IList<Diem> diemList = db4o.Query(delegate(Diem diem)
            {
                return true;
            });
            //IList<SinhVien> sinhVienList = db4o.Query(delegate(SinhVien sv)
            //{
            //    return true;
            //});
            //IList<Monhoc> monhocList = db4o.Query(delegate(Monhoc monhoc)
            //{
            //    return true;
            //});

            foreach (Diem diem in diemList)
            {
                //var sinhVien = sinhVienList.FirstOrDefault(sv => sv.maSV == diem.MaSo);
                //var monhoc = monhocList.FirstOrDefault(mh => mh.MaMh == diem.MaMh);

                //if (sinhVien != null && monhoc != null)
                //{
                //    dataGridView1.Rows.Add(sinhVien.maSV, sinhVien.nameSV, monhoc.TenMh, diem.point);
                //}
                dataGridView1.Rows.Add(diem.Student.maSV, diem.Student.nameSV, diem.Subject.TenMh, diem.point);

            }

            
        }

        private void TimTraDiemButton_Click(object sender, EventArgs e)
        {
            string maSV = dungeonTextBox1.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.");
                return;
            }

            dataGridView1.Rows.Clear();

            //var diemList = db4o.Query<Diem>(d => d.MaSo == maSV);
            //get Diem of SinhVien with entered MaSV
            IList<Diem> diemList = db4o.Query(delegate (Diem diem)
            {
                return diem.Student.maSV.Equals(maSV);
            });

            //check if SinhVien with entered maSV exist
            IList<SinhVien> SearchSinhVien = db4o.Query(delegate (SinhVien sv)
            {
                return sv.maSV.Equals(maSV);
            });

            if (SearchSinhVien.Count == 0)
            {
                MessageBox.Show("Không tồn tại sinh viên với mã sinh viên này.");
                    
                return;
            }

            //var monhocList = db4o.Query<Monhoc>();
            //Display the search result
            foreach (var diem in diemList)
            {
                //var monhoc = monhocList.FirstOrDefault(mh => mh.MaMh == diem.MaMh);
                //if (monhoc != null)
                //{
                //    dataGridView1.Rows.Add(sinhVien.maSV, sinhVien.nameSV, monhoc.TenMh, diem.point);
                //}
                dataGridView1.Rows.Add(diem.Student.maSV, diem.Student.nameSV, diem.Subject.TenMh, diem.point);
            }
                
            
        }


        private void ResetTraDiemButton_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
