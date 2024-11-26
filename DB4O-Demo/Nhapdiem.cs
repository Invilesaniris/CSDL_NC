﻿using System;
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
using static DB4O_Demo.Ultilities.GlobalDb4oAccess; 

namespace DB4O_Demo
{
    public partial class Nhapdiem : Form
    {
        private IObjectContainer db4o= Database;
        public Nhapdiem()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(195, 12);
            g.DrawString("Nhập điểm", font, brush, point);
        }

        private void NhapDiemButton_Click(object sender, EventArgs e)
        {
            string maSV = dungeonTextBox2.Text;
            double diem;
            double.TryParse(dungeonTextBox1.Text, out diem);

            int maMh;
            int.TryParse(dungeonTextBox3.Text, out maMh);

            if (string.IsNullOrEmpty(maSV) && diem==0 && maMh == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                
                IList<SinhVien> sv_list = db4o.Query(delegate(SinhVien sv)
                {
                    return sv.maSV.Equals(maSV);
                });

                if (sv_list.Any())
                {
                    foreach (var sv in sv_list)
                    {
                        var monhoc_list = db4o.Query<Monhoc>(mh => mh.MaMh == maMh);
                        if (monhoc_list.Any())
                        {
                            var diem_list = db4o.Query<Diem>(d => d.MaSo == maSV && d.MaMh == maMh);
                            if (diem_list.Any()) 
                            {
                                // cập nhật điểm
                                foreach (var diem_item in diem_list)
                                {
                                    diem_item.point = diem;
                                    db4o.Store(diem_item);   // Lưu lại thông tin đã cập nhật
                                }
                                MessageBox.Show("Cập nhật điểm thành công");
                            }
                            else
                            {                                
                                // thêm điểm
                                Diem diem1 = new Diem(maSV, maMh, diem);
                                db4o.Store(diem1);
                                MessageBox.Show("Nhập thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại môn học");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại sinh viên");
                }
            }
        }
    }
}
