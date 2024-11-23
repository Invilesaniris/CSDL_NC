namespace DB4O_Demo
{
    partial class Nhapdiem
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            dungeonTextBox1 = new ReaLTaiizor.Controls.DungeonTextBox();
            dungeonTextBox2 = new ReaLTaiizor.Controls.DungeonTextBox();
            panel2 = new Panel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            dungeonTextBox3 = new ReaLTaiizor.Controls.DungeonTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(217, 126);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(271, 229);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 4;
            label3.Text = "Mã môn\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(295, 331);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 8;
            label5.Text = "Điểm";
            // 
            // airButton1
            // 
            airButton1.BackColor = Color.White;
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 10F);
            airButton1.Image = null;
            airButton1.Location = new Point(566, 406);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(124, 34);
            airButton1.TabIndex = 14;
            airButton1.Text = "Nhập";
            airButton1.Transparent = false;
            airButton1.Click += airButton1_Click;
            // 
            // dungeonTextBox1
            // 
            dungeonTextBox1.BackColor = Color.Transparent;
            dungeonTextBox1.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox1.EdgeColor = Color.White;
            dungeonTextBox1.Font = new Font("Tahoma", 11F);
            dungeonTextBox1.ForeColor = Color.Black;
            dungeonTextBox1.Location = new Point(382, 321);
            dungeonTextBox1.MaxLength = 32767;
            dungeonTextBox1.Multiline = false;
            dungeonTextBox1.Name = "dungeonTextBox1";
            dungeonTextBox1.ReadOnly = false;
            dungeonTextBox1.Size = new Size(64, 33);
            dungeonTextBox1.TabIndex = 15;
            dungeonTextBox1.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox1.UseSystemPasswordChar = false;
            // 
            // dungeonTextBox2
            // 
            dungeonTextBox2.BackColor = Color.Transparent;
            dungeonTextBox2.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox2.EdgeColor = Color.White;
            dungeonTextBox2.Font = new Font("Tahoma", 11F);
            dungeonTextBox2.ForeColor = Color.Black;
            dungeonTextBox2.Location = new Point(382, 116);
            dungeonTextBox2.MaxLength = 32767;
            dungeonTextBox2.Multiline = false;
            dungeonTextBox2.Name = "dungeonTextBox2";
            dungeonTextBox2.ReadOnly = false;
            dungeonTextBox2.Size = new Size(172, 33);
            dungeonTextBox2.TabIndex = 16;
            dungeonTextBox2.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox2.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(173, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 47);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(173, 65);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(589, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 18;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // dungeonTextBox3
            // 
            dungeonTextBox3.BackColor = Color.Transparent;
            dungeonTextBox3.BorderColor = Color.FromArgb(180, 180, 180);
            dungeonTextBox3.EdgeColor = Color.White;
            dungeonTextBox3.Font = new Font("Tahoma", 11F);
            dungeonTextBox3.ForeColor = Color.Black;
            dungeonTextBox3.Location = new Point(382, 219);
            dungeonTextBox3.MaxLength = 32767;
            dungeonTextBox3.Multiline = false;
            dungeonTextBox3.Name = "dungeonTextBox3";
            dungeonTextBox3.ReadOnly = false;
            dungeonTextBox3.Size = new Size(172, 33);
            dungeonTextBox3.TabIndex = 19;
            dungeonTextBox3.TextAlignment = HorizontalAlignment.Left;
            dungeonTextBox3.UseSystemPasswordChar = false;
            // 
            // Nhapdiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 452);
            Controls.Add(dungeonTextBox3);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(dungeonTextBox2);
            Controls.Add(dungeonTextBox1);
            Controls.Add(airButton1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Nhapdiem";
            Text = "Nhập điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox2;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.DungeonTextBox dungeonTextBox3;
    }
}