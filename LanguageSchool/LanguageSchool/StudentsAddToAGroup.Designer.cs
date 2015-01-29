namespace LanguageSchool
{
    partial class StudentsAddToAGroup
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
            this.student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findGroup = new System.Windows.Forms.Button();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.DataGridView();
            this.findStudent = new System.Windows.Forms.Button();
            this.studentFName = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.enroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student.Location = new System.Drawing.Point(102, 97);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(412, 88);
            this.student.TabIndex = 0;
            this.student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shedule";
            // 
            // schedule
            // 
            this.schedule.FormattingEnabled = true;
            this.schedule.Location = new System.Drawing.Point(266, 248);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(121, 21);
            this.schedule.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(502, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // findGroup
            // 
            this.findGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findGroup.Location = new System.Drawing.Point(266, 286);
            this.findGroup.Name = "findGroup";
            this.findGroup.Size = new System.Drawing.Size(121, 30);
            this.findGroup.TabIndex = 7;
            this.findGroup.Text = "Find a Group";
            this.findGroup.UseVisualStyleBackColor = true;
            this.findGroup.Click += new System.EventHandler(this.findGroup_Click);
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(376, 49);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(138, 20);
            this.studentAddress.TabIndex = 9;
            // 
            // group
            // 
            this.group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.group.Location = new System.Drawing.Point(12, 336);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(675, 101);
            this.group.TabIndex = 10;
            this.group.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.group_CellClick);
            // 
            // findStudent
            // 
            this.findStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findStudent.Location = new System.Drawing.Point(546, 42);
            this.findStudent.Name = "findStudent";
            this.findStudent.Size = new System.Drawing.Size(130, 31);
            this.findStudent.TabIndex = 11;
            this.findStudent.Text = "Find a Student";
            this.findStudent.UseVisualStyleBackColor = true;
            this.findStudent.Click += new System.EventHandler(this.findStudent_Click);
            // 
            // studentFName
            // 
            this.studentFName.Location = new System.Drawing.Point(204, 49);
            this.studentFName.Name = "studentFName";
            this.studentFName.Size = new System.Drawing.Size(138, 20);
            this.studentFName.TabIndex = 12;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(32, 49);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(138, 20);
            this.studentName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(70, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Family Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(414, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(48, 249);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(156, 20);
            this.startDate.TabIndex = 17;
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(466, 245);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(156, 20);
            this.startTime.TabIndex = 18;
            this.startTime.Value = new System.DateTime(2014, 9, 3, 8, 30, 0, 0);
            // 
            // enroll
            // 
            this.enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enroll.Location = new System.Drawing.Point(266, 472);
            this.enroll.Name = "enroll";
            this.enroll.Size = new System.Drawing.Size(121, 30);
            this.enroll.TabIndex = 19;
            this.enroll.Text = "Enroll Student";
            this.enroll.UseVisualStyleBackColor = true;
            this.enroll.Click += new System.EventHandler(this.enroll_Click);
            // 
            // StudentsAddToAGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 524);
            this.Controls.Add(this.enroll);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentFName);
            this.Controls.Add(this.findStudent);
            this.Controls.Add(this.group);
            this.Controls.Add(this.studentAddress);
            this.Controls.Add(this.findGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student);
            this.Name = "StudentsAddToAGroup";
            this.Text = "Students Add to a Group";
            this.Load += new System.EventHandler(this.StudentsAddToAGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox schedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findGroup;
        private System.Windows.Forms.TextBox studentAddress;
        private System.Windows.Forms.DataGridView group;
        private System.Windows.Forms.Button findStudent;
        private System.Windows.Forms.TextBox studentFName;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Button enroll;
    }
}