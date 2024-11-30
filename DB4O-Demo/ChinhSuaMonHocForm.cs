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
    public partial class ChinhSuaMonHocForm : Form
    {
        private Monhoc monhoc;

        public ChinhSuaMonHocForm(Monhoc monhoc)
        {
            this.monhoc = monhoc;
            InitializeComponent();
        }

        private void ChinhSuaMonHocForm_Load(object sender, EventArgs e)
        {
            MaMontextBox.Text = monhoc.MaMonHoc;
            MaMontextBox.ReadOnly = true;
            TenMontextBox.Text = monhoc.TenMh;
            SoTinChitextBox.Text = monhoc.Credit.ToString();

            IList<Khoa> khoaList = Department.FindKhoa(null, null);
            KhoacomboBox.DataSource = khoaList.ToList<Khoa>();
            KhoacomboBox.DisplayMember = "name";
            KhoacomboBox.ValueMember = "maKh";

            KhoacomboBox.IntegralHeight = false;
            KhoacomboBox.MaxDropDownItems = 4;
            KhoacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            KhoacomboBox.SelectedValue = monhoc.Deparment.maKh;

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            string maMon = MaMontextBox.Text;
            string tenMon = TenMontextBox.Text;
            string strCredit = SoTinChitextBox.Text;
            int credit;
            int.TryParse(strCredit, out credit);
            string selectedMaKhoa = KhoacomboBox.SelectedValue.ToString();
            Khoa selectedKhoa = Department.FindExactKhoa(selectedMaKhoa)[0];

            //check maMon
            if (string.IsNullOrEmpty(maMon))
            {
                MessageBox.Show("Mã môn không được để tróng");
                hasError = true;
            }
            // Check tenMon
            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Tên môn không được để trống");
                hasError = true;
            }

            // Check strCredit
            if (string.IsNullOrEmpty(strCredit))
            {
                MessageBox.Show("Số tín chỉ không được để trống");
                hasError = true;
            }
            if (hasError)
            {
                return;
            }
            else
            {
                this.monhoc.TenMh = tenMon;
                this.monhoc.Credit = credit;
                this.monhoc.Deparment = selectedKhoa;
                Database.Store(this.monhoc);
                Database.Commit();
                MessageBox.Show("Cập nhật môn học thành công");
            }
        }
    }
}
