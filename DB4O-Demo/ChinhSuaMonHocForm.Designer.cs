namespace DB4O_Demo
{
    partial class ChinhSuaMonHocForm
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
            ModifyButton = new Button();
            KhoacomboBox = new ComboBox();
            SoTinChitextBox = new TextBox();
            TenMontextBox = new TextBox();
            MaMontextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ModifyButton
            // 
            ModifyButton.Location = new Point(16, 195);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(94, 29);
            ModifyButton.TabIndex = 17;
            ModifyButton.Text = "Chỉnh sửa";
            ModifyButton.UseVisualStyleBackColor = true;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // KhoacomboBox
            // 
            KhoacomboBox.FormattingEnabled = true;
            KhoacomboBox.Location = new Point(107, 128);
            KhoacomboBox.Name = "KhoacomboBox";
            KhoacomboBox.Size = new Size(125, 28);
            KhoacomboBox.TabIndex = 16;
            // 
            // SoTinChitextBox
            // 
            SoTinChitextBox.Location = new Point(107, 82);
            SoTinChitextBox.Name = "SoTinChitextBox";
            SoTinChitextBox.Size = new Size(125, 27);
            SoTinChitextBox.TabIndex = 15;
            // 
            // TenMontextBox
            // 
            TenMontextBox.Location = new Point(107, 46);
            TenMontextBox.Name = "TenMontextBox";
            TenMontextBox.Size = new Size(125, 27);
            TenMontextBox.TabIndex = 14;
            // 
            // MaMontextBox
            // 
            MaMontextBox.Location = new Point(107, 9);
            MaMontextBox.Name = "MaMontextBox";
            MaMontextBox.Size = new Size(125, 27);
            MaMontextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 12;
            label4.Text = "Khoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Số tín chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên môn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã môn";
            // 
            // ChinhSuaMonHocForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 303);
            Controls.Add(ModifyButton);
            Controls.Add(KhoacomboBox);
            Controls.Add(SoTinChitextBox);
            Controls.Add(TenMontextBox);
            Controls.Add(MaMontextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChinhSuaMonHocForm";
            Text = "ChinhSuaMonHocForm";
            Load += ChinhSuaMonHocForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ModifyButton;
        private ComboBox KhoacomboBox;
        private TextBox SoTinChitextBox;
        private TextBox TenMontextBox;
        private TextBox MaMontextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}