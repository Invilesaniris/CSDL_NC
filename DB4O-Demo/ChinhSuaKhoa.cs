using Db4objects.Db4o;
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
    public partial class ChinhSuaKhoa : Form
    {
        private Khoa khoa;
        public ChinhSuaKhoa(Khoa khoa)
        {
            this.khoa = khoa;
            InitializeComponent();
        }

        private void ChinhSuaKhoa_Load(object sender, EventArgs e)
        {
            ChinhSuaKhoa form = sender as ChinhSuaKhoa;
            MaKhoaTextBox.Text = khoa.maKh;
            TenKhoaTextBox.Text = khoa.name;
            MaKhoaTextBox.ReadOnly = true;
        }

        private void ChinhKhoaButton_Click(object sender, EventArgs e)
        {

            IObjectSet khoaList = Database.QueryByExample(this.khoa);

            //check if khoa exist
            if (khoaList.Count==0)
            {
                MessageBox.Show("Khoa không tồn tại");
            }
            else
            {
                Khoa tmp = khoaList[0] as Khoa;
                tmp.name = TenKhoaTextBox.Text;
                Database.Store(tmp);
                Database.Commit();
                MessageBox.Show("Cập nhật thành công");
            }

            this.Close();
        }
    }
}
