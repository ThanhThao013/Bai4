namespace Lab2_File_and_Stream
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
            btn_ReadFromFile_Click = new Button();
            lb_FileName = new Label();
            lb_Size = new Label();
            lb_URL = new Label();
            lb_LineCount = new Label();
            lb_WordCounts = new Label();
            lb_CharacterCount = new Label();
            txt_FileName = new TextBox();
            txt_Size = new TextBox();
            txt_URL = new TextBox();
            txt_LineCount = new TextBox();
            txt_WordCount = new TextBox();
            txt_CharacterCount = new TextBox();
            btn_Exit = new Button();
            rtb_ReadFile = new RichTextBox();
            SuspendLayout();
            // 
            // btn_ReadFromFile_Click
            // 
            btn_ReadFromFile_Click.BackColor = Color.DarkOrange;
            btn_ReadFromFile_Click.Location = new Point(24, 21);
            btn_ReadFromFile_Click.Name = "btn_ReadFromFile_Click";
            btn_ReadFromFile_Click.Size = new Size(354, 47);
            btn_ReadFromFile_Click.TabIndex = 0;
            btn_ReadFromFile_Click.Text = "Read from File";
            btn_ReadFromFile_Click.UseVisualStyleBackColor = false;
            btn_ReadFromFile_Click.Click += this.btn_ReadFromFile_Click;
            // 
            // lb_FileName
            // 
            lb_FileName.AutoSize = true;
            lb_FileName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_FileName.Location = new Point(24, 93);
            lb_FileName.Name = "lb_FileName";
            lb_FileName.Size = new Size(76, 19);
            lb_FileName.TabIndex = 1;
            lb_FileName.Text = "File name";
            // 
            // lb_Size
            // 
            lb_Size.AutoSize = true;
            lb_Size.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Size.Location = new Point(28, 148);
            lb_Size.Name = "lb_Size";
            lb_Size.Size = new Size(38, 19);
            lb_Size.TabIndex = 2;
            lb_Size.Text = "Size";
            // 
            // lb_URL
            // 
            lb_URL.AutoSize = true;
            lb_URL.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_URL.Location = new Point(28, 213);
            lb_URL.Name = "lb_URL";
            lb_URL.Size = new Size(42, 19);
            lb_URL.TabIndex = 3;
            lb_URL.Text = "URL";
            // 
            // lb_LineCount
            // 
            lb_LineCount.AutoSize = true;
            lb_LineCount.Location = new Point(24, 283);
            lb_LineCount.Name = "lb_LineCount";
            lb_LineCount.Size = new Size(83, 20);
            lb_LineCount.TabIndex = 4;
            lb_LineCount.Text = "Line Count ";
            // 
            // lb_WordCounts
            // 
            lb_WordCounts.AutoSize = true;
            lb_WordCounts.Location = new Point(23, 344);
            lb_WordCounts.Name = "lb_WordCounts";
            lb_WordCounts.Size = new Size(86, 20);
            lb_WordCounts.TabIndex = 5;
            lb_WordCounts.Text = "Word count";
            // 
            // lb_CharacterCount
            // 
            lb_CharacterCount.AutoSize = true;
            lb_CharacterCount.Location = new Point(24, 407);
            lb_CharacterCount.Name = "lb_CharacterCount";
            lb_CharacterCount.Size = new Size(113, 20);
            lb_CharacterCount.TabIndex = 6;
            lb_CharacterCount.Text = "Character count";
            // 
            // txt_FileName
            // 
            txt_FileName.Location = new Point(150, 93);
            txt_FileName.Multiline = true;
            txt_FileName.Name = "txt_FileName";
            txt_FileName.Size = new Size(228, 32);
            txt_FileName.TabIndex = 7;
            // 
            // txt_Size
            // 
            txt_Size.Location = new Point(150, 148);
            txt_Size.Multiline = true;
            txt_Size.Name = "txt_Size";
            txt_Size.Size = new Size(228, 27);
            txt_Size.TabIndex = 8;
            // 
            // txt_URL
            // 
            txt_URL.Location = new Point(150, 209);
            txt_URL.Multiline = true;
            txt_URL.Name = "txt_URL";
            txt_URL.Size = new Size(228, 31);
            txt_URL.TabIndex = 9;
            // 
            // txt_LineCount
            // 
            txt_LineCount.Location = new Point(150, 273);
            txt_LineCount.Multiline = true;
            txt_LineCount.Name = "txt_LineCount";
            txt_LineCount.Size = new Size(228, 30);
            txt_LineCount.TabIndex = 10;
            // 
            // txt_WordCount
            // 
            txt_WordCount.Location = new Point(150, 333);
            txt_WordCount.Multiline = true;
            txt_WordCount.Name = "txt_WordCount";
            txt_WordCount.Size = new Size(228, 31);
            txt_WordCount.TabIndex = 11;
            // 
            // txt_CharacterCount
            // 
            txt_CharacterCount.Location = new Point(150, 395);
            txt_CharacterCount.Multiline = true;
            txt_CharacterCount.Name = "txt_CharacterCount";
            txt_CharacterCount.Size = new Size(228, 32);
            txt_CharacterCount.TabIndex = 13;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Coral;
            btn_Exit.Location = new Point(28, 461);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(350, 47);
            btn_Exit.TabIndex = 14;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // rtb_ReadFile
            // 
            rtb_ReadFile.Location = new Point(424, 29);
            rtb_ReadFile.Name = "rtb_ReadFile";
            rtb_ReadFile.Size = new Size(444, 479);
            rtb_ReadFile.TabIndex = 15;
            rtb_ReadFile.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(880, 520);
            Controls.Add(rtb_ReadFile);
            Controls.Add(btn_Exit);
            Controls.Add(txt_CharacterCount);
            Controls.Add(txt_WordCount);
            Controls.Add(txt_LineCount);
            Controls.Add(txt_URL);
            Controls.Add(txt_Size);
            Controls.Add(txt_FileName);
            Controls.Add(lb_CharacterCount);
            Controls.Add(lb_WordCounts);
            Controls.Add(lb_LineCount);
            Controls.Add(lb_URL);
            Controls.Add(lb_Size);
            Controls.Add(lb_FileName);
            Controls.Add(btn_ReadFromFile_Click);
            Name = "Form1";
            Text = "Đọc thông tin FIle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ReadFromFile_Click;
        private Label lb_FileName;
        private Label lb_Size;
        private Label lb_URL;
        private Label lb_LineCount;
        private Label lb_WordCounts;
        private Label lb_CharacterCount;
        private TextBox txt_FileName;
        private TextBox txt_Size;
        private TextBox txt_URL;
        private TextBox txt_LineCount;
        private TextBox txt_WordCount;
        private TextBox txt_CharacterCount;
        private Button btn_Exit;
        private RichTextBox rtb_ReadFile;
    }
}
