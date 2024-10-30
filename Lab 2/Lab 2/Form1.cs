using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Có thể thêm mã xử lý nếu cần
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm mã khởi tạo hoặc thiết lập giao diện ở đây nếu cần
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Sử dụng thuộc tính SafeFileName để lấy tên file
                    string name = openFileDialog.SafeFileName;

                    // Đọc nội dung file bằng StreamReader
                    using (Stream stream = openFileDialog.OpenFile())  // Sử dụng Stream thay vì FileStream
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string fileContent = reader.ReadToEnd();
                        DisplayFileInfo(openFileDialog.FileName, name, fileContent);  // Thay đổi để sử dụng FileName
                    }
                }
            }
        }

        private void DisplayFileInfo(string filePath, string fileName, string fileContent)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            txt_FileName.Text = fileName;
            txt_Size.Text = $"{fileInfo.Length} bytes";
            txt_URL.Text = fileInfo.FullName;

            // Hiển thị nội dung file
            txt_Content.Text = fileContent;

            int lineCount = fileContent.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int wordCount = fileContent.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = fileContent.Length;

            txt_LineCount.Text = lineCount.ToString();
            txt_WordCount.Text = wordCount.ToString();
            txt_CharCount.Text = charCount.ToString();
        }

        private void lb_CharCount_Click(object sender, EventArgs e)
        {
            // Có thể thêm mã xử lý nếu cần
        }
    }
}
