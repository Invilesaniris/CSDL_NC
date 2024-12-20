﻿using Db4objects.Db4o.Internal;

namespace DB4O_Demo
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            XemDiemButton = new ReaLTaiizor.Controls.AloneButton();
            panel5 = new Panel();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            panel2 = new Panel();
            aloneButton4 = new ReaLTaiizor.Controls.AloneButton();
            MonHocButton = new ReaLTaiizor.Controls.AloneButton();
            KhoaButton = new ReaLTaiizor.Controls.AloneButton();
            QuanLySVButton = new ReaLTaiizor.Controls.AloneButton();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(XemDiemButton);
            splitContainer1.Panel1.Controls.Add(panel5);
            splitContainer1.Panel1.Controls.Add(materialDivider1);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(aloneButton4);
            splitContainer1.Panel1.Controls.Add(MonHocButton);
            splitContainer1.Panel1.Controls.Add(KhoaButton);
            splitContainer1.Panel1.Controls.Add(QuanLySVButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(224, 224, 224);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1251, 692);
            splitContainer1.SplitterDistance = 284;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // XemDiemButton
            // 
            XemDiemButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            XemDiemButton.BackColor = Color.Transparent;
            XemDiemButton.EnabledCalc = true;
            XemDiemButton.Font = new Font("Segoe UI", 9F);
            XemDiemButton.ForeColor = Color.Black;
            XemDiemButton.Location = new Point(62, 563);
            XemDiemButton.Name = "XemDiemButton";
            XemDiemButton.Size = new Size(150, 53);
            XemDiemButton.TabIndex = 6;
            XemDiemButton.Text = "Xem điểm";
            XemDiemButton.Click += XemDiemButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.user;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(40, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(63, 72);
            panel5.TabIndex = 5;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialDivider1.BackColor = Color.DimGray;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(27, 12);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(217, 110);
            materialDivider1.TabIndex = 4;
            materialDivider1.Text = "materialDivider1";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackgroundImage = Properties.Resources.logout;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(0, 653);
            panel2.Name = "panel2";
            panel2.Size = new Size(32, 39);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // aloneButton4
            // 
            aloneButton4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            aloneButton4.BackColor = Color.Transparent;
            aloneButton4.EnabledCalc = true;
            aloneButton4.Font = new Font("Segoe UI", 9F);
            aloneButton4.ForeColor = Color.Black;
            aloneButton4.Location = new Point(62, 470);
            aloneButton4.Name = "aloneButton4";
            aloneButton4.Size = new Size(150, 47);
            aloneButton4.TabIndex = 3;
            aloneButton4.Text = "Nhập điểm";
            aloneButton4.Click += aloneButton4_Click;
            // 
            // MonHocButton
            // 
            MonHocButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MonHocButton.BackColor = Color.Transparent;
            MonHocButton.EnabledCalc = true;
            MonHocButton.Font = new Font("Segoe UI", 9F);
            MonHocButton.ForeColor = Color.Black;
            MonHocButton.Location = new Point(62, 378);
            MonHocButton.Name = "MonHocButton";
            MonHocButton.Size = new Size(150, 48);
            MonHocButton.TabIndex = 2;
            MonHocButton.Text = "Môn học";
            MonHocButton.Click += MonHocButton_Click;
            // 
            // KhoaButton
            // 
            KhoaButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            KhoaButton.BackColor = Color.Transparent;
            KhoaButton.EnabledCalc = true;
            KhoaButton.Font = new Font("Segoe UI", 9F);
            KhoaButton.ForeColor = Color.Black;
            KhoaButton.Location = new Point(62, 291);
            KhoaButton.Name = "KhoaButton";
            KhoaButton.Size = new Size(150, 45);
            KhoaButton.TabIndex = 1;
            KhoaButton.Text = "Khoa";
            KhoaButton.Click += KhoaButton_Click;
            // 
            // QuanLySVButton
            // 
            QuanLySVButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            QuanLySVButton.BackColor = Color.Transparent;
            QuanLySVButton.EnabledCalc = true;
            QuanLySVButton.Font = new Font("Segoe UI", 9F);
            QuanLySVButton.ForeColor = Color.Black;
            QuanLySVButton.Location = new Point(62, 193);
            QuanLySVButton.Name = "QuanLySVButton";
            QuanLySVButton.Size = new Size(150, 55);
            QuanLySVButton.TabIndex = 0;
            QuanLySVButton.Text = "Quản lý sinh viên";
            QuanLySVButton.Click += QuanLySVButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Location = new Point(32, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(931, 632);
            panel3.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 692);
            Controls.Add(splitContainer1);
            Name = "Menu";
            Text = "Quản lý thông tin";
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.AloneButton QuanLySVButton;
        private ReaLTaiizor.Controls.AloneButton MonHocButton;
        private ReaLTaiizor.Controls.AloneButton KhoaButton;
        private ReaLTaiizor.Controls.AloneButton aloneButton4;
        private Panel panel2;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private Panel panel5;
        private ReaLTaiizor.Controls.AloneButton XemDiemButton;
    }
}