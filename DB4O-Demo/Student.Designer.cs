﻿namespace DB4O_Demo
{
    partial class Student
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
            dataGridView1 = new DataGridView();
            ThemSVButton = new Button();
            TimKiemSVButton = new Button();
            ResetThemSVButton = new Button();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            panel2 = new Panel();
            button1 = new Button();
            KhoacomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(685, 355);
            dataGridView1.TabIndex = 0;
            // 
            // ThemSVButton
            // 
            ThemSVButton.Location = new Point(703, 183);
            ThemSVButton.Name = "ThemSVButton";
            ThemSVButton.Size = new Size(132, 52);
            ThemSVButton.TabIndex = 1;
            ThemSVButton.Text = "Thêm";
            ThemSVButton.UseVisualStyleBackColor = true;
            ThemSVButton.Click += ThemSVButton_Click;
            // 
            // TimKiemSVButton
            // 
            TimKiemSVButton.Location = new Point(448, 126);
            TimKiemSVButton.Name = "TimKiemSVButton";
            TimKiemSVButton.Size = new Size(94, 29);
            TimKiemSVButton.TabIndex = 2;
            TimKiemSVButton.Text = "Tìm kiếm";
            TimKiemSVButton.UseVisualStyleBackColor = true;
            TimKiemSVButton.Click += TimKiemSVButton_Click;
            // 
            // ResetThemSVButton
            // 
            ResetThemSVButton.Location = new Point(314, 126);
            ResetThemSVButton.Name = "ResetThemSVButton";
            ResetThemSVButton.Size = new Size(94, 29);
            ResetThemSVButton.TabIndex = 3;
            ResetThemSVButton.Text = "Reset";
            ResetThemSVButton.UseVisualStyleBackColor = true;
            ResetThemSVButton.Click += ResetThemSVButton_Click;
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.DimGray;
            dungeonTextBox1.Location = new Point(106, 87);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 33);
            dungeonTextBox1.TabIndex = 4;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.DimGray;
            dungeonTextBox3.Location = new Point(106, 122);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(169, 33);
            dungeonTextBox3.TabIndex = 6;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(10, 95);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 7;
            label1.Text = "Mã số SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(13, 132);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(312, 95);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 9;
            label3.Text = "Mã khoa";
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(175, 77);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(589, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 21;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(175, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 47);
            panel2.TabIndex = 20;
            panel2.Paint += panel2_Paint_1;
            // 
            // button1
            // 
            button1.Location = new Point(703, 280);
            button1.Name = "button1";
            button1.Size = new Size(132, 52);
            button1.TabIndex = 22;
            button1.Text = "Chỉnh sửa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KhoacomboBox
            // 
            KhoacomboBox.FormattingEnabled = true;
            KhoacomboBox.Location = new Point(403, 95);
            KhoacomboBox.Name = "KhoacomboBox";
            KhoacomboBox.Size = new Size(151, 28);
            KhoacomboBox.TabIndex = 23;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 585);
            Controls.Add(KhoacomboBox);
            Controls.Add(button1);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dungeonTextBox3);
            Controls.Add(dungeonTextBox1);
            Controls.Add(ResetThemSVButton);
            Controls.Add(TimKiemSVButton);
            Controls.Add(ThemSVButton);
            Controls.Add(dataGridView1);
            Name = "Student";
            Text = "Sinh sien";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ThemSVButton;
        private Button TimKiemSVButton;
        private Button ResetThemSVButton;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Panel panel2;
        private Button button1;
        private ComboBox KhoacomboBox;
    }
}