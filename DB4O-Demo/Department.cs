using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB4O_Demo.Models;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;

namespace DB4O_Demo
{
    public partial class Department : Form
    {
        private IObjectContainer db4o_Depart;
        public Department()
        {
            InitializeComponent();
            CreatDeparment();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Danh sách khoa", font, brush, point);
        }
        private void CreatDeparment()
        {
            IList<Khoa> result = Database.Query(delegate(Khoa khoa)
            {
                return true;
            });

            if (!result.Any())
            {
                var khoaList = new List<Khoa>
                {
                    new Khoa("CNTT", "Khoa Công nghệ Thông tin"),
                    new Khoa("KTE", "Khoa Kinh tế"),
                    new Khoa("QTKD", "Khoa Quản trị Kinh doanh"),
                    new Khoa("NNA", "Khoa Ngôn ngữ Anh"),
                    new Khoa("KTD", "Khoa Kỹ thuật Điện"),
                    new Khoa("KT", "Khoa Kiến trúc"),
                    new Khoa("YD", "Khoa Y Dược"),
                    new Khoa("HH", "Khoa Hóa học"),
                    new Khoa("SH", "Khoa Sinh học"),
                    new Khoa("MT", "Khoa Môi trường")
                };
                foreach (var khoa in khoaList)
                {
                    Database.Store(khoa);
                }
                Database.Commit();
            }
        }
        private void LoadDataToDataGridView()
        {
            
            IList<Khoa> result = Database.Query(delegate(Khoa khoa)
            {
                return true;
            });
            foreach (var khoa in result)
            {
                dataGridView1.Rows.Add(khoa.maKh, khoa.name);
            }
            
        }

        private void Department_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Makh", "Mã khoa");
            dataGridView1.Columns.Add("name", "Khoa");
            LoadDataToDataGridView();
        }
    }
}
