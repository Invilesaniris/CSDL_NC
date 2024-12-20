﻿using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB4O_Demo
{
    public partial class Menu : Form
    {
        private string nameAdmin;
        private Form parrentForm;

        public Menu(Form parrentForm)
        {
            this.parrentForm = parrentForm;
            InitializeComponent();

        }
        public Menu(string nameAd, Form parrentForm)
        {

            this.nameAdmin = nameAd;
            this.parrentForm = parrentForm;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.SplitterWidth = 1;
        }
        private void AddFormToPanel(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            form.BackColor = Color.White;
            panel.Controls.Add(form);
            form.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 20);
            Brush brush = Brushes.Black;
            PointF point = new PointF(159, 27);
            g.DrawString("Quản lý sinh viên", font, brush, point);
        }

        private void aloneButton4_Click(object sender, EventArgs e)
        {
            Nhapdiem nd = new Nhapdiem();
            AddFormToPanel(nd, panel3);
        }

        private void XemDiemButton_Click(object sender, EventArgs e)
        {
            Tracuudiem tr = new Tracuudiem();
            AddFormToPanel(tr, panel3);
        }

        private void MonHocButton_Click(object sender, EventArgs e)
        {
            Subject mh = new Subject();
            AddFormToPanel(mh, panel3);
        }

        private void KhoaButton_Click(object sender, EventArgs e)
        {
            Department kh = new Department();
            AddFormToPanel(kh, panel3);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //this.parrentForm.Show();
            this.Close();
        }

        private void QuanLySVButton_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            AddFormToPanel(st, panel3);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parrentForm.Show();
        }
    }
}
