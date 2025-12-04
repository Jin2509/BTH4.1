namespace BT06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string src = textBox1.Text;
            string dest = textBox2.Text;

            if (!Directory.Exists(src))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!");
                return;
            }

            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }

            string[] files = Directory.GetFiles(src);
            int total = files.Length;

            progressBar1.Value = 0;
            progressBar1.Maximum = total;
            foreach(string file in files)
            {
                string filename = Path.GetFileName(file);
                string destFile = Path.Combine(dest, filename);

                toolStripStatusLabel1.Text = "Đang sao chép" + filename;
                File.Copy(file, destFile, true);
                progressBar1.Value += 1;
                Application.DoEvents();
            }
            toolStripStatusLabel1.Text = "Hoàn thành sao chép";
            MessageBox.Show("Đã sao chép xong!");
        }
    }
}
