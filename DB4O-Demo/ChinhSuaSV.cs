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
    public partial class ChinhSuaSV : Form
    {
        private SinhVien sv;

        public ChinhSuaSV(SinhVien sv)
        {
            this.sv = sv;
            InitializeComponent();
        }

        private void ChinhSuaSV_Load(object sender, EventArgs e)
        {
            NametextBox.Text = sv.nameSV;
            MSSVtextBox.Text = sv.maSV;
            MSSVtextBox.ReadOnly = true;
            SDTtextBox.Text = sv.phone;

            IList<Khoa> allKhoa = Department.FindKhoa(null, null);
            KhoacomboBox.DataSource = allKhoa.ToList<Khoa>();
            KhoacomboBox.DisplayMember = "name";
            KhoacomboBox.ValueMember = "maKh";

            KhoacomboBox.IntegralHeight = false;
            KhoacomboBox.MaxDropDownItems = 4;
            KhoacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            KhoacomboBox.SelectedValue = sv.department.maKh;

        }

        private void ChinhSuaSVButton_Click(object sender, EventArgs e)
        {
            string name=NametextBox.Text;
            string phone = SDTtextBox.Text;
            string maKhoa = KhoacomboBox.SelectedValue.ToString();
            Khoa selectedKhoa = Department.FindExactKhoa(maKhoa)[0];

            bool hasError = false;

            //chekc if name is empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Tên không được để trống");
                hasError = true;
            }

            //chekc if phone is empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                hasError = true;
            }

            if (hasError)
            {
                return;
            }
            else
            {
                this.sv.nameSV = name;
                this.sv.phone = phone;
                this.sv.department = selectedKhoa;
                Database.Store(this.sv);
                Database.Commit();

                MessageBox.Show("Cập nhật thông tin sinh viên thành công");
            }


        }
    }
}
