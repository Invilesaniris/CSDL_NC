﻿namespace DB4O_Demo
{
    partial class Subject
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
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            FindMonHocButton = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            ResetFindMonHocButton = new Button();
            AddSubjectButton = new Button();
            ModifyMonHocButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.DimGray;
            dungeonTextBox1.Location = new Point(104, 86);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 33);
            dungeonTextBox1.TabIndex = 0;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // dungeonTextBox2
            // 
            dungeonTextBox2.BackColor = Color.Transparent;
            dungeonTextBox2.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox2.EdgeColor = Color.White;
            dungeonTextBox2.Font = new Font("Tahoma", 11F);
            dungeonTextBox2.ForeColor = Color.DimGray;
            dungeonTextBox2.Location = new Point(104, 155);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(169, 33);
            dungeonTextBox2.TabIndex = 1;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(4, 94);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Mã môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(2, 163);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên môn";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(357, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Số tín chỉ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.DimGray;
            dungeonTextBox3.Location = new Point(453, 86);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(52, 33);
            dungeonTextBox3.TabIndex = 4;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // FindMonHocButton
            // 
            FindMonHocButton.Font = new Font("Segoe UI", 11F);
            FindMonHocButton.Location = new Point(492, 152);
            FindMonHocButton.Name = "FindMonHocButton";
            FindMonHocButton.Size = new Size(111, 36);
            FindMonHocButton.TabIndex = 6;
            FindMonHocButton.Text = "Lọc";
            FindMonHocButton.UseVisualStyleBackColor = true;
            FindMonHocButton.Click += FindMonHocButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(589, 298);
            dataGridView1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Location = new Point(171, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 47);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(171, 65);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(589, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 19;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // ResetFindMonHocButton
            // 
            ResetFindMonHocButton.Font = new Font("Segoe UI", 11F);
            ResetFindMonHocButton.Location = new Point(357, 152);
            ResetFindMonHocButton.Name = "ResetFindMonHocButton";
            ResetFindMonHocButton.Size = new Size(111, 36);
            ResetFindMonHocButton.TabIndex = 20;
            ResetFindMonHocButton.Text = "Reset";
            ResetFindMonHocButton.UseVisualStyleBackColor = true;
            ResetFindMonHocButton.Click += ResetFindMonHocButton_Click;
            // 
            // AddSubjectButton
            // 
            AddSubjectButton.Location = new Point(627, 250);
            AddSubjectButton.Name = "AddSubjectButton";
            AddSubjectButton.Size = new Size(192, 47);
            AddSubjectButton.TabIndex = 21;
            AddSubjectButton.Text = "Thêm môn học";
            AddSubjectButton.UseVisualStyleBackColor = true;
            AddSubjectButton.Click += AddSubjectButton_Click;
            // 
            // ModifyMonHocButton
            // 
            ModifyMonHocButton.Location = new Point(627, 344);
            ModifyMonHocButton.Name = "ModifyMonHocButton";
            ModifyMonHocButton.Size = new Size(192, 47);
            ModifyMonHocButton.TabIndex = 22;
            ModifyMonHocButton.Text = "Chỉnh sửa";
            ModifyMonHocButton.UseVisualStyleBackColor = true;
            ModifyMonHocButton.Click += ModifyMonHocButton_Click;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 585);
            Controls.Add(ModifyMonHocButton);
            Controls.Add(AddSubjectButton);
            Controls.Add(ResetFindMonHocButton);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(FindMonHocButton);
            Controls.Add(label3);
            Controls.Add(dungeonTextBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dungeonTextBox2);
            Controls.Add(dungeonTextBox1);
            Name = "Subject";
            Text = "Môn học";
            Load += Monhoc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
        private Button FindMonHocButton;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Button ResetFindMonHocButton;
        private Button AddSubjectButton;
        private Button ModifyMonHocButton;
    }
}