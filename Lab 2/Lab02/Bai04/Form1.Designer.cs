namespace Bai04
{
    partial class Form1
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
            this.btWriteFile = new System.Windows.Forms.Button();
            this.btReadFile = new System.Windows.Forms.Button();
            this.tbWName = new System.Windows.Forms.TextBox();
            this.tbWID = new System.Windows.Forms.TextBox();
            this.tbWPhone = new System.Windows.Forms.TextBox();
            this.tbWCourse1 = new System.Windows.Forms.TextBox();
            this.tbWCourse2 = new System.Windows.Forms.TextBox();
            this.tbWCourse3 = new System.Windows.Forms.TextBox();
            this.tbWAverage = new System.Windows.Forms.TextBox();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.tbRID = new System.Windows.Forms.TextBox();
            this.tbRPhone = new System.Windows.Forms.TextBox();
            this.tbRCourse1 = new System.Windows.Forms.TextBox();
            this.tbRCourse2 = new System.Windows.Forms.TextBox();
            this.tbRCourse3 = new System.Windows.Forms.TextBox();
            this.tbRAverage = new System.Windows.Forms.TextBox();
            this.btAddFile = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btWriteFile
            // 
            this.btWriteFile.Location = new System.Drawing.Point(19, 12);
            this.btWriteFile.Name = "btWriteFile";
            this.btWriteFile.Size = new System.Drawing.Size(322, 44);
            this.btWriteFile.TabIndex = 0;
            this.btWriteFile.Text = "Write to a File";
            this.btWriteFile.UseVisualStyleBackColor = true;
            this.btWriteFile.Click += new System.EventHandler(this.btWriteFile_Click);
            // 
            // btReadFile
            // 
            this.btReadFile.Location = new System.Drawing.Point(822, 12);
            this.btReadFile.Name = "btReadFile";
            this.btReadFile.Size = new System.Drawing.Size(322, 44);
            this.btReadFile.TabIndex = 1;
            this.btReadFile.Text = "Button to read a File";
            this.btReadFile.UseVisualStyleBackColor = true;
            this.btReadFile.Click += new System.EventHandler(this.btReadFile_Click);
            // 
            // tbWName
            // 
            this.tbWName.Location = new System.Drawing.Point(19, 78);
            this.tbWName.Name = "tbWName";
            this.tbWName.Size = new System.Drawing.Size(196, 22);
            this.tbWName.TabIndex = 2;
            // 
            // tbWID
            // 
            this.tbWID.Location = new System.Drawing.Point(19, 141);
            this.tbWID.Name = "tbWID";
            this.tbWID.Size = new System.Drawing.Size(196, 22);
            this.tbWID.TabIndex = 3;
            // 
            // tbWPhone
            // 
            this.tbWPhone.Location = new System.Drawing.Point(19, 209);
            this.tbWPhone.Name = "tbWPhone";
            this.tbWPhone.Size = new System.Drawing.Size(196, 22);
            this.tbWPhone.TabIndex = 4;
            // 
            // tbWCourse1
            // 
            this.tbWCourse1.Location = new System.Drawing.Point(19, 274);
            this.tbWCourse1.Name = "tbWCourse1";
            this.tbWCourse1.Size = new System.Drawing.Size(196, 22);
            this.tbWCourse1.TabIndex = 5;
            // 
            // tbWCourse2
            // 
            this.tbWCourse2.Location = new System.Drawing.Point(19, 341);
            this.tbWCourse2.Name = "tbWCourse2";
            this.tbWCourse2.Size = new System.Drawing.Size(196, 22);
            this.tbWCourse2.TabIndex = 6;
            // 
            // tbWCourse3
            // 
            this.tbWCourse3.Location = new System.Drawing.Point(19, 411);
            this.tbWCourse3.Name = "tbWCourse3";
            this.tbWCourse3.Size = new System.Drawing.Size(196, 22);
            this.tbWCourse3.TabIndex = 7;
            // 
            // tbWAverage
            // 
            this.tbWAverage.Location = new System.Drawing.Point(19, 482);
            this.tbWAverage.Name = "tbWAverage";
            this.tbWAverage.Size = new System.Drawing.Size(196, 22);
            this.tbWAverage.TabIndex = 8;
            // 
            // tbRName
            // 
            this.tbRName.Location = new System.Drawing.Point(822, 78);
            this.tbRName.Name = "tbRName";
            this.tbRName.Size = new System.Drawing.Size(196, 22);
            this.tbRName.TabIndex = 9;
            // 
            // tbRID
            // 
            this.tbRID.Location = new System.Drawing.Point(822, 141);
            this.tbRID.Name = "tbRID";
            this.tbRID.Size = new System.Drawing.Size(196, 22);
            this.tbRID.TabIndex = 10;
            // 
            // tbRPhone
            // 
            this.tbRPhone.Location = new System.Drawing.Point(822, 209);
            this.tbRPhone.Name = "tbRPhone";
            this.tbRPhone.Size = new System.Drawing.Size(196, 22);
            this.tbRPhone.TabIndex = 11;
            // 
            // tbRCourse1
            // 
            this.tbRCourse1.Location = new System.Drawing.Point(822, 274);
            this.tbRCourse1.Name = "tbRCourse1";
            this.tbRCourse1.Size = new System.Drawing.Size(196, 22);
            this.tbRCourse1.TabIndex = 12;
            // 
            // tbRCourse2
            // 
            this.tbRCourse2.Location = new System.Drawing.Point(822, 341);
            this.tbRCourse2.Name = "tbRCourse2";
            this.tbRCourse2.Size = new System.Drawing.Size(196, 22);
            this.tbRCourse2.TabIndex = 13;
            // 
            // tbRCourse3
            // 
            this.tbRCourse3.Location = new System.Drawing.Point(822, 411);
            this.tbRCourse3.Name = "tbRCourse3";
            this.tbRCourse3.Size = new System.Drawing.Size(196, 22);
            this.tbRCourse3.TabIndex = 14;
            // 
            // tbRAverage
            // 
            this.tbRAverage.Location = new System.Drawing.Point(822, 482);
            this.tbRAverage.Name = "tbRAverage";
            this.tbRAverage.Size = new System.Drawing.Size(196, 22);
            this.tbRAverage.TabIndex = 15;
            // 
            // btAddFile
            // 
            this.btAddFile.Location = new System.Drawing.Point(76, 543);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(196, 35);
            this.btAddFile.TabIndex = 16;
            this.btAddFile.Text = "Add";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(822, 543);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(107, 35);
            this.btBack.TabIndex = 17;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1037, 543);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(107, 35);
            this.btNext.TabIndex = 18;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Course 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Course 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Course 3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Average";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1067, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Average";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1059, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Course 3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1059, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Course 2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1059, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Course 1";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1083, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Phone";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1116, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1087, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(974, 552);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(19, 20);
            this.lbCount.TabIndex = 33;
            this.lbCount.Text = "1";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(363, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 576);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.tbRAverage);
            this.Controls.Add(this.tbRCourse3);
            this.Controls.Add(this.tbRCourse2);
            this.Controls.Add(this.tbRCourse1);
            this.Controls.Add(this.tbRPhone);
            this.Controls.Add(this.tbRID);
            this.Controls.Add(this.tbRName);
            this.Controls.Add(this.tbWAverage);
            this.Controls.Add(this.tbWCourse3);
            this.Controls.Add(this.tbWCourse2);
            this.Controls.Add(this.tbWCourse1);
            this.Controls.Add(this.tbWPhone);
            this.Controls.Add(this.tbWID);
            this.Controls.Add(this.tbWName);
            this.Controls.Add(this.btReadFile);
            this.Controls.Add(this.btWriteFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lab02_Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWriteFile;
        private System.Windows.Forms.Button btReadFile;
        private System.Windows.Forms.TextBox tbWName;
        private System.Windows.Forms.TextBox tbWID;
        private System.Windows.Forms.TextBox tbWPhone;
        private System.Windows.Forms.TextBox tbWCourse1;
        private System.Windows.Forms.TextBox tbWCourse2;
        private System.Windows.Forms.TextBox tbWCourse3;
        private System.Windows.Forms.TextBox tbWAverage;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.TextBox tbRID;
        private System.Windows.Forms.TextBox tbRPhone;
        private System.Windows.Forms.TextBox tbRCourse1;
        private System.Windows.Forms.TextBox tbRCourse2;
        private System.Windows.Forms.TextBox tbRCourse3;
        private System.Windows.Forms.TextBox tbRAverage;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

