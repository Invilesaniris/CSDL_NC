namespace DB4O_Demo
{
    partial class AddMonHoc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MaMontextBox = new TextBox();
            TenMontextBox = new TextBox();
            SoTinChitextBox = new TextBox();
            KhoacomboBox = new ComboBox();
            ThemButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã môn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Số tín chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 3;
            label4.Text = "Khoa";
            // 
            // MaMontextBox
            // 
            MaMontextBox.Location = new Point(107, 9);
            MaMontextBox.Name = "MaMontextBox";
            MaMontextBox.Size = new Size(125, 27);
            MaMontextBox.TabIndex = 4;
            // 
            // TenMontextBox
            // 
            TenMontextBox.Location = new Point(107, 46);
            TenMontextBox.Name = "TenMontextBox";
            TenMontextBox.Size = new Size(125, 27);
            TenMontextBox.TabIndex = 5;
            // 
            // SoTinChitextBox
            // 
            SoTinChitextBox.Location = new Point(107, 82);
            SoTinChitextBox.Name = "SoTinChitextBox";
            SoTinChitextBox.Size = new Size(125, 27);
            SoTinChitextBox.TabIndex = 6;
            // 
            // KhoacomboBox
            // 
            KhoacomboBox.FormattingEnabled = true;
            KhoacomboBox.Location = new Point(107, 128);
            KhoacomboBox.Name = "KhoacomboBox";
            KhoacomboBox.Size = new Size(125, 28);
            KhoacomboBox.TabIndex = 7;
            // 
            // ThemButton
            // 
            ThemButton.Location = new Point(16, 195);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(94, 29);
            ThemButton.TabIndex = 8;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = true;
            ThemButton.Click += ThemButton_Click;
            // 
            // AddMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 290);
            Controls.Add(ThemButton);
            Controls.Add(KhoacomboBox);
            Controls.Add(SoTinChitextBox);
            Controls.Add(TenMontextBox);
            Controls.Add(MaMontextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMonHoc";
            Text = "Thêm môn học";
            Load += AddMonHoc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox MaMontextBox;
        private TextBox TenMontextBox;
        private TextBox SoTinChitextBox;
        private ComboBox KhoacomboBox;
        private Button ThemButton;
    }
}