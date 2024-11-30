namespace DB4O_Demo
{
    partial class ChinhSuaSV
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
            NametextBox = new TextBox();
            MSSVtextBox = new TextBox();
            SDTtextBox = new TextBox();
            KhoacomboBox = new ComboBox();
            ChinhSuaSVButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Khoa:";
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(141, 9);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(125, 27);
            NametextBox.TabIndex = 4;
            // 
            // MSSVtextBox
            // 
            MSSVtextBox.Location = new Point(141, 50);
            MSSVtextBox.Name = "MSSVtextBox";
            MSSVtextBox.Size = new Size(125, 27);
            MSSVtextBox.TabIndex = 5;
            // 
            // SDTtextBox
            // 
            SDTtextBox.Location = new Point(141, 93);
            SDTtextBox.Name = "SDTtextBox";
            SDTtextBox.Size = new Size(125, 27);
            SDTtextBox.TabIndex = 6;
            // 
            // KhoacomboBox
            // 
            KhoacomboBox.FormattingEnabled = true;
            KhoacomboBox.Location = new Point(141, 138);
            KhoacomboBox.Name = "KhoacomboBox";
            KhoacomboBox.Size = new Size(151, 28);
            KhoacomboBox.TabIndex = 7;
            // 
            // ChinhSuaSVButton
            // 
            ChinhSuaSVButton.Location = new Point(12, 187);
            ChinhSuaSVButton.Name = "ChinhSuaSVButton";
            ChinhSuaSVButton.Size = new Size(94, 29);
            ChinhSuaSVButton.TabIndex = 8;
            ChinhSuaSVButton.Text = "Chỉnh sửa";
            ChinhSuaSVButton.UseVisualStyleBackColor = true;
            ChinhSuaSVButton.Click += ChinhSuaSVButton_Click;
            // 
            // ChinhSuaSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 317);
            Controls.Add(ChinhSuaSVButton);
            Controls.Add(KhoacomboBox);
            Controls.Add(SDTtextBox);
            Controls.Add(MSSVtextBox);
            Controls.Add(NametextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChinhSuaSV";
            Text = "ChinhSuaSV";
            Load += ChinhSuaSV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NametextBox;
        private TextBox MSSVtextBox;
        private TextBox SDTtextBox;
        private ComboBox KhoacomboBox;
        private Button ChinhSuaSVButton;
    }
}