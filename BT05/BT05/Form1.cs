using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        private string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=QLSV;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        void LoadListView()
        {
            listView1.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM SinhVien";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int stt = 1;

                    while (rd.Read())
                    {
                        ListViewItem item = new ListViewItem("");
                        item.SubItems.Add(stt.ToString());
                        item.SubItems.Add(rd["MSSV"].ToString());
                        item.SubItems.Add(rd["TenSV"].ToString());
                        item.SubItems.Add(rd["Khoa"].ToString());
                        item.SubItems.Add(rd["DiemTB"].ToString());

                        listView1.Items.Add(item);
                        stt++;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.SinhVienDaThem += LoadListView;
            f2.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string keyword = toolStripTextBox1.Text.Trim();

            LoadStudentData(keyword);
        }

        private void LoadStudentData(string searchKeyword = null)
        {
            listView1.Items.Clear();

            string query = "SELECT MSSV, TenSV, Khoa, DiemTB FROM SinhVien";
            string keyword = "%" + searchKeyword + "%";

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query += " WHERE TenSV COLLATE SQL_Latin1_General_CP1_CI_AS LIKE @Keyword";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@Keyword", keyword);
                        }

                        conn.Open();
                        int stt = 1;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem("");
                                item.SubItems.Add(stt.ToString());
                                item.SubItems.Add(reader["MSSV"].ToString());
                                item.SubItems.Add(reader["TenSV"].ToString());
                                item.SubItems.Add(reader["Khoa"].ToString());
                                item.SubItems.Add(reader["DiemTB"].ToString());

                                listView1.Items.Add(item);
                                stt++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải/tìm kiếm dữ liệu: " + ex.Message);
            }
        }


        private void CleanupStudentData(string mssvToDelete)
        {
            string query = "DELETE FROM SinhVien WHERE MSSV = @MSSV";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@MSSV", mssvToDelete);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"Đã xóa sinh viên MSSV: {mssvToDelete} khỏi CSDL thành công.");
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy sinh viên MSSV: {mssvToDelete} để xóa.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Lỗi khóa ngoại: Sinh viên này có dữ liệu liên quan ở các bảng khác. Vui lòng xóa dữ liệu liên quan trước.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi CSDL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định trong quá trình dọn dẹp: " + ex.Message);
            }
        }
    }
}
