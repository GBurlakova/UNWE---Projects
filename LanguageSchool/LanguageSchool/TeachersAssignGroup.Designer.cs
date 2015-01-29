namespace LanguageSchool
{
    partial class TeachersAssignGroup
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
            this.teacherPIN = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.teacherAddress = new System.Windows.Forms.TextBox();
            this.teacherFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findTeacher = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.findGroup = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.DataGridView();
            this.assingn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherPIN
            // 
            this.teacherPIN.Location = new System.Drawing.Point(33, 56);
            this.teacherPIN.Name = "teacherPIN";
            this.teacherPIN.Size = new System.Drawing.Size(138, 20);
            this.teacherPIN.TabIndex = 0;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(228, 56);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(143, 20);
            this.teacherName.TabIndex = 1;
            // 
            // teacherAddress
            // 
            this.teacherAddress.Location = new System.Drawing.Point(590, 56);
            this.teacherAddress.Name = "teacherAddress";
            this.teacherAddress.Size = new System.Drawing.Size(138, 20);
            this.teacherAddress.TabIndex = 2;
            // 
            // teacherFName
            // 
            this.teacherFName.Location = new System.Drawing.Point(410, 56);
            this.teacherFName.Name = "teacherFName";
            this.teacherFName.Size = new System.Drawing.Size(140, 20);
            this.teacherFName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PIN";
            // 
            // findTeacher
            // 
            this.findTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTeacher.Location = new System.Drawing.Point(766, 45);
            this.findTeacher.Name = "findTeacher";
            this.findTeacher.Size = new System.Drawing.Size(125, 39);
            this.findTeacher.TabIndex = 5;
            this.findTeacher.Text = "Find Teacher";
            this.findTeacher.UseVisualStyleBackColor = true;
            this.findTeacher.Click += new System.EventHandler(this.findTeacher_Click);
            // 
            // teacher
            // 
            this.teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher.Location = new System.Drawing.Point(85, 109);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(643, 123);
            this.teacher.TabIndex = 6;
            this.teacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(263, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Family Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(631, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(33, 317);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(156, 20);
            this.startDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(351, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Shedule";
            // 
            // schedule
            // 
            this.schedule.FormattingEnabled = true;
            this.schedule.Location = new System.Drawing.Point(309, 316);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(151, 21);
            this.schedule.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(631, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Start Time";
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(590, 313);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(156, 20);
            this.startTime.TabIndex = 22;
            this.startTime.Value = new System.DateTime(2014, 9, 3, 8, 30, 0, 0);
            // 
            // findGroup
            // 
            this.findGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findGroup.Location = new System.Drawing.Point(364, 380);
            this.findGroup.Name = "findGroup";
            this.findGroup.Size = new System.Drawing.Size(121, 30);
            this.findGroup.TabIndex = 23;
            this.findGroup.Text = "Find a Group";
            this.findGroup.UseVisualStyleBackColor = true;
            this.findGroup.Click += new System.EventHandler(this.findGroup_Click);
            // 
            // group
            // 
            this.group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.group.Location = new System.Drawing.Point(33, 441);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(883, 101);
            this.group.TabIndex = 24;
            this.group.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.group_CellClick);
            // 
            // assingn
            // 
            this.assingn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.assingn.Location = new System.Drawing.Point(373, 581);
            this.assingn.Name = "assingn";
            this.assingn.Size = new System.Drawing.Size(121, 30);
            this.assingn.TabIndex = 25;
            this.assingn.Text = "Assign Group";
            this.assingn.UseVisualStyleBackColor = true;
            this.assingn.Click += new System.EventHandler(this.assingn_Click);
            // 
            // TeacherAddToAGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 643);
            this.Controls.Add(this.assingn);
            this.Controls.Add(this.group);
            this.Controls.Add(this.findGroup);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.findTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherFName);
            this.Controls.Add(this.teacherAddress);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.teacherPIN);
            this.Name = "TeacherAddToAGroup";
            this.Text = "TeacherAddToAGroup";
            this.Load += new System.EventHandler(this.TeacherAddToAGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teacherPIN;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.TextBox teacherAddress;
        private System.Windows.Forms.TextBox teacherFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findTeacher;
        private System.Windows.Forms.DataGridView teacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox schedule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Button findGroup;
        private System.Windows.Forms.DataGridView group;
        private System.Windows.Forms.Button assingn;
    }
}