namespace BT05
{
    partial class Form2
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
            txtMSSV = new TextBox();
            txtTenSV = new TextBox();
            txtKhoa = new ComboBox();
            txtDiemTB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 55);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 114);
            label2.Name = "label2";
            label2.Size = new Size(187, 38);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 180);
            label3.Name = "label3";
            label3.Size = new Size(84, 38);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 246);
            label4.Name = "label4";
            label4.Size = new Size(235, 38);
            label4.TabIndex = 3;
            label4.Text = "Điểm trung bình";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(351, 66);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(279, 27);
            txtMSSV.TabIndex = 4;
            txtMSSV.TextChanged += txtMSSV_TextChanged;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(353, 125);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(279, 27);
            txtTenSV.TabIndex = 5;
            // 
            // txtKhoa
            // 
            txtKhoa.FormattingEnabled = true;
            txtKhoa.Items.AddRange(new object[] { "Công nghệ phần mềm", "Mạng máy tính và truyền thông dữ liệu", "Khoa học máy tính", "Kỹ thuật máy tính", "Hệ thống thông tin ", "Kỹ thuật thông tin" });
            txtKhoa.Location = new Point(353, 180);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(279, 28);
            txtKhoa.TabIndex = 6;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(357, 257);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(177, 27);
            txtDiemTB.TabIndex = 7;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(431, 335);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 8;
            button1.Text = "Thêm mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 224, 192);
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(635, 339);
            button2.Name = "button2";
            button2.Size = new Size(120, 45);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDiemTB);
            Controls.Add(txtKhoa);
            Controls.Add(txtTenSV);
            Controls.Add(txtMSSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập liệu sinh viên";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMSSV;
        private TextBox txtTenSV;
        private ComboBox txtKhoa;
        private TextBox txtDiemTB;
        private Button button1;
        private Button button2;
    }
}