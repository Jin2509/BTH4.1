using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BT05
{
    public partial class Form2 : Form
    {
        public event Action SinhVienDaThem;

        private string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=QLSV;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string ten = txtTenSV.Text.Trim();
            string khoa = txtKhoa.Text.Trim();
            float diem;

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(khoa) || !float.TryParse(txtDiemTB.Text.Trim(), out diem))
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ dữ liệu.");
                return;
            }

            string query = "INSERT INTO SinhVien(MSSV, TenSV, Khoa, DiemTB) VALUES (@MSSV, @TenSV, @Khoa, @DiemTB)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MSSV", mssv);
                    cmd.Parameters.AddWithValue("@TenSV", ten);
                    cmd.Parameters.AddWithValue("@Khoa", khoa);
                    cmd.Parameters.AddWithValue("@DiemTB", diem);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công!");
                        SinhVienDaThem?.Invoke();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            txtMSSV.Clear();
            txtTenSV.Clear();
            txtKhoa.Items.Clear();
            txtDiemTB.Clear();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {
            string input = txtDiemTB.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!double.TryParse(input, out double number))
            {
                MessageBox.Show("Điểm phải là một số thực");
                return;
            }

            if (number < 0 || number > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng 0 đến 10!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
