using System;
using System.IO;
using System.Windows.Forms;
namespace Lab2_File_and_Stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
           try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên file
                    string fileName = ofd.SafeFileName;
                    string filePath = ofd.FileName;

                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        string path = fs.Name.ToString();
                        long fileSize = new FileInfo(filePath).Length;

                        string content;
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            content = sr.ReadToEnd();
                        }

                        int lineCount = File.ReadAllLines(filePath).Length;
                        int wordCount = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int charCount = content.Length;

                        txt_FileName.Text = $"{fileName}";
                        txt_Size.Text = $"{fileSize} bytes";
                        txt_URL.Text = $"{path}";
                        txt_LineCount.Text = $"{lineCount}";
                        txt_WordCount.Text = $"{wordCount}";
                        txt_CharacterCount.Text = $"{charCount}";
                        rtb_ReadFile.Text = $"{content}";
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }

}