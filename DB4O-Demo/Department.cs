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
using Db4objects.Db4o.Linq;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;
using Db4oModels.Models;
using DB4O_Demo.Ultilities;

namespace DB4O_Demo
{
    public partial class Department : Form
    {
        private IObjectContainer db4o_Depart;
        public Department()
        {
            InitializeComponent();
            loadGridView();
        }

        private void loadGridView()
        {
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(158, 12);
            g.DrawString("Danh sách khoa", font, brush, point);
        }

        private void LoadDataToDataGridView()
        {

            IList<Khoa> result = Database.Query(delegate (Khoa khoa)
            {
                return true;
            });
            foreach (var khoa in result)
            {
                dataGridView1.Rows.Add(khoa.maKh, khoa.name);
            }

        }

        private void FeedDataToDataGridView(IList<Khoa> datas)
        {
            dataGridView1.Rows.Clear();

            foreach (var khoa in datas)
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

        private void FindKhoaButton_Click(object sender, EventArgs e)
        {
            string tenKhoa = DepartmentNameTextBox.Text;
            string maKhoa = DepartmentIdTextBox.Text;

            IList<Khoa> result = Database.Query(delegate (Khoa khoa)
            {
                return (string.IsNullOrEmpty(tenKhoa) || khoa.name.Equals(tenKhoa)) &&
                (string.IsNullOrEmpty(maKhoa) || khoa.maKh.Equals(maKhoa));
                ;
            });

            FeedDataToDataGridView(result);



        }
    }
}
