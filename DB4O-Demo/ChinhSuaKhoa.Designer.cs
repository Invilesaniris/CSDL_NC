namespace DB4O_Demo
{
    partial class ChinhSuaKhoa
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
            label3 = new Label();
            TenKhoaErrorLabel = new Label();
            makhoaErrorLabel = new Label();
            TenKhoaTextBox = new TextBox();
            MaKhoaTextBox = new TextBox();
            ChinhKhoaButton = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(131, 92);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 15;
            // 
            // TenKhoaErrorLabel
            // 
            TenKhoaErrorLabel.AutoSize = true;
            TenKhoaErrorLabel.ForeColor = Color.Red;
            TenKhoaErrorLabel.Location = new Point(89, 116);
            TenKhoaErrorLabel.Name = "TenKhoaErrorLabel";
            TenKhoaErrorLabel.Size = new Size(0, 20);
            TenKhoaErrorLabel.TabIndex = 14;
            // 
            // makhoaErrorLabel
            // 
            makhoaErrorLabel.AutoSize = true;
            makhoaErrorLabel.ForeColor = Color.Red;
            makhoaErrorLabel.Location = new Point(89, 45);
            makhoaErrorLabel.Name = "makhoaErrorLabel";
            makhoaErrorLabel.Size = new Size(0, 20);
            makhoaErrorLabel.TabIndex = 13;
            // 
            // TenKhoaTextBox
            // 
            TenKhoaTextBox.Location = new Point(89, 73);
            TenKhoaTextBox.Name = "TenKhoaTextBox";
            TenKhoaTextBox.Size = new Size(125, 27);
            TenKhoaTextBox.TabIndex = 12;
            // 
            // MaKhoaTextBox
            // 
            MaKhoaTextBox.Location = new Point(87, 6);
            MaKhoaTextBox.Name = "MaKhoaTextBox";
            MaKhoaTextBox.Size = new Size(125, 27);
            MaKhoaTextBox.TabIndex = 11;
            // 
            // ChinhKhoaButton
            // 
            ChinhKhoaButton.Location = new Point(12, 139);
            ChinhKhoaButton.Name = "ChinhKhoaButton";
            ChinhKhoaButton.Size = new Size(94, 29);
            ChinhKhoaButton.TabIndex = 10;
            ChinhKhoaButton.Text = "Chỉnh sửa";
            ChinhKhoaButton.UseVisualStyleBackColor = true;
            ChinhKhoaButton.Click += ChinhKhoaButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên khoa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã khoa:";
            // 
            // ChinhSuaKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 198);
            Controls.Add(label3);
            Controls.Add(TenKhoaErrorLabel);
            Controls.Add(makhoaErrorLabel);
            Controls.Add(TenKhoaTextBox);
            Controls.Add(MaKhoaTextBox);
            Controls.Add(ChinhKhoaButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChinhSuaKhoa";
            Text = "ChinhSuaKhoa";
            Load += ChinhSuaKhoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label TenKhoaErrorLabel;
        private Label makhoaErrorLabel;
        private TextBox TenKhoaTextBox;
        private TextBox MaKhoaTextBox;
        private Button ChinhKhoaButton;
        private Label label2;
        private Label label1;
    }
}