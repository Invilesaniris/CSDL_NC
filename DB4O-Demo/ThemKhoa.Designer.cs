namespace DB4O_Demo
{
    partial class ThemKhoa
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
            ThemKhoaButton = new Button();
            MaKhoaTextBox = new TextBox();
            TenKhoaTextBox = new TextBox();
            makhoaErrorLabel = new Label();
            TenKhoaErrorLabel = new Label();
            label3 = new Label();
            AddDepartmentErrorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khoa:";
            // 
            // ThemKhoaButton
            // 
            ThemKhoaButton.Location = new Point(12, 151);
            ThemKhoaButton.Name = "ThemKhoaButton";
            ThemKhoaButton.Size = new Size(94, 29);
            ThemKhoaButton.TabIndex = 2;
            ThemKhoaButton.Text = "Thêm khoa";
            ThemKhoaButton.UseVisualStyleBackColor = true;
            ThemKhoaButton.Click += ThemKhoaButton_Click;
            // 
            // MaKhoaTextBox
            // 
            MaKhoaTextBox.Location = new Point(87, 18);
            MaKhoaTextBox.Name = "MaKhoaTextBox";
            MaKhoaTextBox.Size = new Size(125, 27);
            MaKhoaTextBox.TabIndex = 3;
            // 
            // TenKhoaTextBox
            // 
            TenKhoaTextBox.Location = new Point(89, 85);
            TenKhoaTextBox.Name = "TenKhoaTextBox";
            TenKhoaTextBox.Size = new Size(125, 27);
            TenKhoaTextBox.TabIndex = 4;
            // 
            // makhoaErrorLabel
            // 
            makhoaErrorLabel.AutoSize = true;
            makhoaErrorLabel.ForeColor = Color.Red;
            makhoaErrorLabel.Location = new Point(89, 57);
            makhoaErrorLabel.Name = "makhoaErrorLabel";
            makhoaErrorLabel.Size = new Size(0, 20);
            makhoaErrorLabel.TabIndex = 5;
            // 
            // TenKhoaErrorLabel
            // 
            TenKhoaErrorLabel.AutoSize = true;
            TenKhoaErrorLabel.ForeColor = Color.Red;
            TenKhoaErrorLabel.Location = new Point(89, 128);
            TenKhoaErrorLabel.Name = "TenKhoaErrorLabel";
            TenKhoaErrorLabel.Size = new Size(0, 20);
            TenKhoaErrorLabel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(131, 104);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // AddDepartmentErrorLabel
            // 
            AddDepartmentErrorLabel.AutoSize = true;
            AddDepartmentErrorLabel.ForeColor = Color.Red;
            AddDepartmentErrorLabel.Location = new Point(26, 199);
            AddDepartmentErrorLabel.Name = "AddDepartmentErrorLabel";
            AddDepartmentErrorLabel.Size = new Size(0, 20);
            AddDepartmentErrorLabel.TabIndex = 8;
            // 
            // ThemKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 228);
            Controls.Add(AddDepartmentErrorLabel);
            Controls.Add(label3);
            Controls.Add(TenKhoaErrorLabel);
            Controls.Add(makhoaErrorLabel);
            Controls.Add(TenKhoaTextBox);
            Controls.Add(MaKhoaTextBox);
            Controls.Add(ThemKhoaButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemKhoa";
            Text = "ThemKhoa";
            FormClosing += ThemKhoa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ThemKhoaButton;
        private TextBox MaKhoaTextBox;
        private TextBox TenKhoaTextBox;
        private Label makhoaErrorLabel;
        private Label TenKhoaErrorLabel;
        private Label label3;
        private Label AddDepartmentErrorLabel;
    }
}