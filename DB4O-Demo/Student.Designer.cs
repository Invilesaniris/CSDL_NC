namespace DB4O_Demo
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(685, 355);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(461, 185);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(743, 185);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(609, 185);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.DimGray;
            dungeonTextBox1.Location = new Point(238, 117);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 33);
            dungeonTextBox1.TabIndex = 4;
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
            dungeonTextBox2.Location = new Point(595, 117);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(169, 33);
            dungeonTextBox2.TabIndex = 5;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.DimGray;
            dungeonTextBox3.Location = new Point(238, 183);
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
            label1.Location = new Point(142, 125);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 7;
            label1.Text = "Mã số SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(162, 191);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(504, 125);
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
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 585);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dungeonTextBox3);
            Controls.Add(dungeonTextBox2);
            Controls.Add(dungeonTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Panel panel2;
    }
}