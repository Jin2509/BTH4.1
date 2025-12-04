using System.Runtime.InteropServices;

namespace BT04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                tscComboBox1.Items.Add(font.Name);
            }

            int[] sizes = { 8, 9, 10, 11, 12, 13, 14, 16, 18, 20, 22, 24, 26, 28, 36, 42 };
            foreach (int s in sizes)
            {
                tscComboBox2.Items.Add(s.ToString());
            }

            tscComboBox1.Text = "Tahoma";
            tscComboBox2.Text = "14";

            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "RTF Files|*.rtf|Text Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FilterIndex == 1)
                {
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                }
                else
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "RTF Files|*.rtf| Text Files|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FilterIndex == 1)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "RTF Files|*.rtf| Text Files|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FilterIndex == 1)
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font fn = richTextBox1.SelectionFont;
            FontStyle newS = fn.Style ^ FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(fn, newS);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font fn = richTextBox1.SelectionFont;

            FontStyle newS = fn.Style ^ FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(fn, newS);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font fn = richTextBox1.SelectionFont;

            FontStyle newS = fn.Style ^ FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(fn, newS);
        }

        private void tscComboBox2_Click(object sender, EventArgs e)
        {
            float size = float.Parse(tscComboBox2.Text);
            richTextBox1.Font = new Font(tscComboBox2.Text, size);
        }

        private void tscComboBox1_Click(object sender, EventArgs e)
        {
            if (tscComboBox1.SelectedItem != null)
            {
                float size = float.Parse(tscComboBox2.Text);
                richTextBox1.Font = new Font(tscComboBox1.Text, size);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog a = new FontDialog();

            a.Font = richTextBox1.SelectionFont ?? richTextBox1.Font;

            if(a.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = a.Font;
                richTextBox1.SelectionColor = a.Color;
            }
        }
    }
}
