namespace DB4O_Demo
{
    partial class Department
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
            panel2 = new Panel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            label1 = new Label();
            DepartmentNameTextBox = new TextBox();
            label2 = new Label();
            DepartmentIdTextBox = new TextBox();
            FindKhoaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(457, 387);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(158, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 47);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(158, 65);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(589, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 3;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 87);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên khoa:";
            // 
            // DepartmentNameTextBox
            // 
            DepartmentNameTextBox.Location = new Point(125, 83);
            DepartmentNameTextBox.Name = "DepartmentNameTextBox";
            DepartmentNameTextBox.Size = new Size(125, 27);
            DepartmentNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã khoa:";
            // 
            // DepartmentIdTextBox
            // 
            DepartmentIdTextBox.Location = new Point(400, 85);
            DepartmentIdTextBox.Name = "DepartmentIdTextBox";
            DepartmentIdTextBox.Size = new Size(125, 27);
            DepartmentIdTextBox.TabIndex = 7;
            // 
            // FindKhoaButton
            // 
            FindKhoaButton.Location = new Point(577, 83);
            FindKhoaButton.Name = "FindKhoaButton";
            FindKhoaButton.Size = new Size(94, 29);
            FindKhoaButton.TabIndex = 8;
            FindKhoaButton.Text = "Tìm khoa";
            FindKhoaButton.UseVisualStyleBackColor = true;
            FindKhoaButton.Click += FindKhoaButton_Click;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 585);
            Controls.Add(FindKhoaButton);
            Controls.Add(DepartmentIdTextBox);
            Controls.Add(label2);
            Controls.Add(DepartmentNameTextBox);
            Controls.Add(label1);
            Controls.Add(metroDivider1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Name = "Department";
            Text = "Khoa";
            Load += Department_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Label label1;
        private TextBox DepartmentNameTextBox;
        private Label label2;
        private TextBox DepartmentIdTextBox;
        private Button FindKhoaButton;
    }
}