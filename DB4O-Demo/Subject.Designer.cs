namespace DB4O_Demo
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            button2 = new Button();
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
            dungeonTextBox1.Location = new Point(305, 102);
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
            dungeonTextBox2.Location = new Point(305, 171);
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
            label1.Location = new Point(205, 110);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Mã môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(203, 179);
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
            label3.Location = new Point(558, 110);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "Số tiết";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.DimGray;
            dungeonTextBox3.Location = new Point(654, 102);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(52, 33);
            dungeonTextBox3.TabIndex = 4;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(693, 168);
            button1.Name = "button1";
            button1.Size = new Size(111, 36);
            button1.TabIndex = 6;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 250);
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(558, 168);
            button2.Name = "button2";
            button2.Size = new Size(111, 36);
            button2.TabIndex = 20;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Monhoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 585);
            Controls.Add(button2);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dungeonTextBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dungeonTextBox2);
            Controls.Add(dungeonTextBox1);
            Name = "Monhoc";
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
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Button button2;
    }
}