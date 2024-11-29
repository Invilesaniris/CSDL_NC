using Db4oModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DB4O_Demo.Ultilities.GlobalDb4oAccess;

namespace DB4O_Demo
{
    public partial class ThemKhoa : Form
    {
        private Form parrent;
        public ThemKhoa(Form parrent)
        {
            this.parrent = parrent;
            InitializeComponent();
        }

        private void ThemKhoaButton_Click(object sender, EventArgs e)
        {
            makhoaErrorLabel.Text = null;
            TenKhoaErrorLabel.Text = null;
            AddDepartmentErrorLabel.Text = null;

            string maKhoa = MaKhoaTextBox.Text;
            string tenKhoa = TenKhoaTextBox.Text;

            bool hasError = false;

            //check if input is left blank
            if (string.IsNullOrEmpty(maKhoa))
            {
                makhoaErrorLabel.Text = "Không được để trống";
                hasError = true;
            }
            if (string.IsNullOrEmpty(tenKhoa))
            {
                TenKhoaErrorLabel.Text = "Không được để trống";
                hasError = true;
            }

            //check if khoa already exist
            IList<Khoa> existedKhoa = Department.FindKhoa(null,maKhoa);
            if (existedKhoa.Count > 0)
            {
                AddDepartmentErrorLabel.Text = "Khoa đã tồn tại";
                hasError = true;
            }
            if (hasError)
                return;
            else
            {
                Database.Store(new Khoa(maKhoa, tenKhoa));
                Database.Commit();
                AddDepartmentErrorLabel.Text = "Thêm khoa thành công";
                AddDepartmentErrorLabel.ForeColor = Color.Green;
            }

        }

        private void ThemKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
