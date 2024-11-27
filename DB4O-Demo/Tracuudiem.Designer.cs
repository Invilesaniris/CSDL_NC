namespace DB4O_Demo
{
    partial class Tracuudiem
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
            label1 = new Label();
            TimTraDiemButton = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            ResetNhapDiemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.Black;
            dungeonTextBox1.Location = new Point(316, 91);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(169, 33);
            dungeonTextBox1.TabIndex = 1;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(151, 91);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 2;
            label1.Text = "Mã số sinh viên";
            // 
            // TimTraDiemButton
            // 
            TimTraDiemButton.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimTraDiemButton.ForeColor = SystemColors.ActiveCaptionText;
            TimTraDiemButton.Location = new Point(668, 90);
            TimTraDiemButton.Name = "TimTraDiemButton";
            TimTraDiemButton.Size = new Size(82, 34);
            TimTraDiemButton.TabIndex = 3;
            TimTraDiemButton.Text = "Tìm";
            TimTraDiemButton.UseVisualStyleBackColor = true;
            TimTraDiemButton.Click += TimTraDiemButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(161, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(589, 393);
            dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(161, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 47);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(161, 56);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(589, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 20;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // ResetNhapDiemButton
            // 
            ResetNhapDiemButton.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetNhapDiemButton.ForeColor = SystemColors.ActiveCaptionText;
            ResetNhapDiemButton.Location = new Point(564, 90);
            ResetNhapDiemButton.Name = "ResetNhapDiemButton";
            ResetNhapDiemButton.Size = new Size(82, 34);
            ResetNhapDiemButton.TabIndex = 21;
            ResetNhapDiemButton.Text = "Reset";
            ResetNhapDiemButton.UseVisualStyleBackColor = true;
            ResetNhapDiemButton.Click += ResetTraDiemButton_Click;
            // 
            // Tracuudiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 585);
            Controls.Add(ResetNhapDiemButton);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(TimTraDiemButton);
            Controls.Add(label1);
            Controls.Add(dungeonTextBox1);
            Name = "Tracuudiem";
            Text = "Tra cứu điểm";
            Load += Tracuudiem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private Label label1;
        private Button TimTraDiemButton;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Button ResetNhapDiemButton;
    }
}