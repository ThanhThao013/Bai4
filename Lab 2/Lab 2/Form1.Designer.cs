namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_FileName = new TextBox();
            lb_FileName = new Label();
            btn_ReadFromFile = new Button();
            lb_Size = new Label();
            lb_URL = new Label();
            lb_LineCount = new Label();
            lb_WordCount = new Label();
            lb_CharCount = new Label();
            txt_Size = new TextBox();
            txt_URL = new TextBox();
            txt_LineCount = new TextBox();
            txt_WordCount = new TextBox();
            txt_CharCount = new TextBox();
            btn_Exit = new Button();
            txt_Content = new TextBox();
            SuspendLayout();
            // 
            // txt_FileName
            // 
            txt_FileName.Location = new Point(152, 87);
            txt_FileName.Name = "txt_FileName";
            txt_FileName.Size = new Size(230, 27);
            txt_FileName.TabIndex = 0;
            // 
            // lb_FileName
            // 
            lb_FileName.AutoSize = true;
            lb_FileName.BackColor = Color.FromArgb(255, 128, 128);
            lb_FileName.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_FileName.ForeColor = Color.Black;
            lb_FileName.Location = new Point(26, 95);
            lb_FileName.Name = "lb_FileName";
            lb_FileName.Size = new Size(86, 19);
            lb_FileName.TabIndex = 1;
            lb_FileName.Text = "File Name";
            lb_FileName.Click += label1_Click;
            // 
            // btn_ReadFromFile
            // 
            btn_ReadFromFile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ReadFromFile.Location = new Point(12, 12);
            btn_ReadFromFile.Name = "btn_ReadFromFile";
            btn_ReadFromFile.Size = new Size(370, 49);
            btn_ReadFromFile.TabIndex = 2;
            btn_ReadFromFile.Text = "Read From File";
            btn_ReadFromFile.UseVisualStyleBackColor = true;
            btn_ReadFromFile.Click += btn_ReadFromFile_Click;
            // 
            // lb_Size
            // 
            lb_Size.AutoSize = true;
            lb_Size.BackColor = Color.FromArgb(255, 128, 128);
            lb_Size.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Size.ForeColor = Color.Black;
            lb_Size.Location = new Point(26, 144);
            lb_Size.Name = "lb_Size";
            lb_Size.Size = new Size(38, 19);
            lb_Size.TabIndex = 3;
            lb_Size.Text = "Size";
            // 
            // lb_URL
            // 
            lb_URL.AutoSize = true;
            lb_URL.BackColor = Color.FromArgb(255, 128, 128);
            lb_URL.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_URL.ForeColor = Color.Black;
            lb_URL.Location = new Point(26, 197);
            lb_URL.Name = "lb_URL";
            lb_URL.Size = new Size(44, 19);
            lb_URL.TabIndex = 4;
            lb_URL.Text = "URL";
            // 
            // lb_LineCount
            // 
            lb_LineCount.AutoSize = true;
            lb_LineCount.BackColor = Color.FromArgb(255, 128, 128);
            lb_LineCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_LineCount.ForeColor = Color.Black;
            lb_LineCount.Location = new Point(26, 239);
            lb_LineCount.Name = "lb_LineCount";
            lb_LineCount.Size = new Size(92, 19);
            lb_LineCount.TabIndex = 5;
            lb_LineCount.Text = "Line Count";
            // 
            // lb_WordCount
            // 
            lb_WordCount.AutoSize = true;
            lb_WordCount.BackColor = Color.FromArgb(255, 128, 128);
            lb_WordCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_WordCount.ForeColor = Color.Black;
            lb_WordCount.Location = new Point(26, 290);
            lb_WordCount.Name = "lb_WordCount";
            lb_WordCount.Size = new Size(99, 19);
            lb_WordCount.TabIndex = 6;
            lb_WordCount.Text = "Word Count";
            // 
            // lb_CharCount
            // 
            lb_CharCount.AutoSize = true;
            lb_CharCount.BackColor = Color.FromArgb(255, 128, 128);
            lb_CharCount.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_CharCount.ForeColor = Color.Black;
            lb_CharCount.Location = new Point(17, 346);
            lb_CharCount.Name = "lb_CharCount";
            lb_CharCount.Size = new Size(129, 19);
            lb_CharCount.TabIndex = 7;
            lb_CharCount.Text = "Character count";
            lb_CharCount.Click += lb_CharCount_Click;
            // 
            // txt_Size
            // 
            txt_Size.Location = new Point(152, 140);
            txt_Size.Name = "txt_Size";
            txt_Size.Size = new Size(230, 27);
            txt_Size.TabIndex = 8;
            // 
            // txt_URL
            // 
            txt_URL.Location = new Point(152, 189);
            txt_URL.Name = "txt_URL";
            txt_URL.Size = new Size(230, 27);
            txt_URL.TabIndex = 9;
            // 
            // txt_LineCount
            // 
            txt_LineCount.Location = new Point(152, 235);
            txt_LineCount.Name = "txt_LineCount";
            txt_LineCount.Size = new Size(230, 27);
            txt_LineCount.TabIndex = 10;
            // 
            // txt_WordCount
            // 
            txt_WordCount.Location = new Point(152, 282);
            txt_WordCount.Name = "txt_WordCount";
            txt_WordCount.Size = new Size(230, 27);
            txt_WordCount.TabIndex = 11;
            // 
            // txt_CharCount
            // 
            txt_CharCount.Location = new Point(152, 338);
            txt_CharCount.Name = "txt_CharCount";
            txt_CharCount.Size = new Size(230, 27);
            txt_CharCount.TabIndex = 12;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Lime;
            btn_Exit.BackgroundImageLayout = ImageLayout.None;
            btn_Exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = SystemColors.ControlText;
            btn_Exit.Location = new Point(12, 392);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(370, 46);
            btn_Exit.TabIndex = 13;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_Content
            // 
            txt_Content.BackColor = Color.IndianRed;
            txt_Content.Location = new Point(406, 12);
            txt_Content.Multiline = true;
            txt_Content.Name = "txt_Content";
            txt_Content.Size = new Size(382, 426);
            txt_Content.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Content);
            Controls.Add(btn_Exit);
            Controls.Add(txt_CharCount);
            Controls.Add(txt_WordCount);
            Controls.Add(txt_LineCount);
            Controls.Add(txt_URL);
            Controls.Add(txt_Size);
            Controls.Add(lb_CharCount);
            Controls.Add(lb_WordCount);
            Controls.Add(lb_LineCount);
            Controls.Add(lb_URL);
            Controls.Add(lb_Size);
            Controls.Add(btn_ReadFromFile);
            Controls.Add(lb_FileName);
            Controls.Add(txt_FileName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_FileName;
        private Label lb_FileName;
        private Button btn_ReadFromFile;
        private Label lb_Size;
        private Label lb_URL;
        private Label lb_LineCount;
        private Label lb_WordCount;
        private Label lb_CharCount;
        private TextBox txt_Size;
        private TextBox txt_URL;
        private TextBox txt_LineCount;
        private TextBox txt_WordCount;
        private TextBox txt_CharCount;
        private Button btn_Exit;
        private TextBox txt_Content;
    }
}
