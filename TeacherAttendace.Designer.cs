namespace TeacherAttendance_withDB
{
    partial class TeacherAttendace
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.dGVAttendacnce = new System.Windows.Forms.DataGridView();
            this.tBComment = new System.Windows.Forms.TextBox();
            this.cBCourse = new System.Windows.Forms.ComboBox();
            this.cBTeacher = new System.Windows.Forms.ComboBox();
            this.cBRoom = new System.Windows.Forms.ComboBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.dTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.dTPLeaveTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttendacnce)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Attendance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leave Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teacher Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room/Lab";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Commenr";
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(655, 207);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 24);
            this.btInsert.TabIndex = 8;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // dGVAttendacnce
            // 
            this.dGVAttendacnce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAttendacnce.Location = new System.Drawing.Point(12, 258);
            this.dGVAttendacnce.Name = "dGVAttendacnce";
            this.dGVAttendacnce.Size = new System.Drawing.Size(846, 247);
            this.dGVAttendacnce.TabIndex = 9;
            // 
            // tBComment
            // 
            this.tBComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBComment.Location = new System.Drawing.Point(186, 208);
            this.tBComment.Name = "tBComment";
            this.tBComment.Size = new System.Drawing.Size(457, 24);
            this.tBComment.TabIndex = 10;
            // 
            // cBCourse
            // 
            this.cBCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCourse.FormattingEnabled = true;
            this.cBCourse.Location = new System.Drawing.Point(595, 80);
            this.cBCourse.Name = "cBCourse";
            this.cBCourse.Size = new System.Drawing.Size(135, 26);
            this.cBCourse.TabIndex = 14;
            // 
            // cBTeacher
            // 
            this.cBTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTeacher.FormattingEnabled = true;
            this.cBTeacher.Location = new System.Drawing.Point(595, 119);
            this.cBTeacher.Name = "cBTeacher";
            this.cBTeacher.Size = new System.Drawing.Size(135, 26);
            this.cBTeacher.TabIndex = 15;
            // 
            // cBRoom
            // 
            this.cBRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRoom.FormattingEnabled = true;
            this.cBRoom.Location = new System.Drawing.Point(595, 159);
            this.cBRoom.Name = "cBRoom";
            this.cBRoom.Size = new System.Drawing.Size(135, 26);
            this.cBRoom.TabIndex = 16;
            // 
            // dTPDate
            // 
            this.dTPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDate.Location = new System.Drawing.Point(186, 81);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(142, 24);
            this.dTPDate.TabIndex = 17;
            // 
            // dTPStartTime
            // 
            this.dTPStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPStartTime.Location = new System.Drawing.Point(186, 121);
            this.dTPStartTime.Name = "dTPStartTime";
            this.dTPStartTime.Size = new System.Drawing.Size(142, 24);
            this.dTPStartTime.TabIndex = 18;
            // 
            // dTPLeaveTime
            // 
            this.dTPLeaveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPLeaveTime.Location = new System.Drawing.Point(186, 161);
            this.dTPLeaveTime.Name = "dTPLeaveTime";
            this.dTPLeaveTime.Size = new System.Drawing.Size(142, 24);
            this.dTPLeaveTime.TabIndex = 19;
            // 
            // TeacherAttendace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 517);
            this.Controls.Add(this.dTPLeaveTime);
            this.Controls.Add(this.dTPStartTime);
            this.Controls.Add(this.dTPDate);
            this.Controls.Add(this.cBRoom);
            this.Controls.Add(this.cBTeacher);
            this.Controls.Add(this.cBCourse);
            this.Controls.Add(this.tBComment);
            this.Controls.Add(this.dGVAttendacnce);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherAttendace";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TeacherAttendace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAttendacnce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.DataGridView dGVAttendacnce;
        private System.Windows.Forms.TextBox tBComment;
        private System.Windows.Forms.ComboBox cBCourse;
        private System.Windows.Forms.ComboBox cBTeacher;
        private System.Windows.Forms.ComboBox cBRoom;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.DateTimePicker dTPStartTime;
        private System.Windows.Forms.DateTimePicker dTPLeaveTime;
    }
}

