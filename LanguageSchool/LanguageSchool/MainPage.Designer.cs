namespace LanguageSchool
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsByGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersByGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToAGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherEducationInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(730, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStudentsToolStripMenuItem,
            this.studentsByGroupsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.addStudentToGroupToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // allStudentsToolStripMenuItem
            // 
            this.allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            this.allStudentsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.allStudentsToolStripMenuItem.Text = "All Students";
            this.allStudentsToolStripMenuItem.Click += new System.EventHandler(this.allStudentsToolStripMenuItem_Click);
            // 
            // studentsByGroupsToolStripMenuItem
            // 
            this.studentsByGroupsToolStripMenuItem.Name = "studentsByGroupsToolStripMenuItem";
            this.studentsByGroupsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.studentsByGroupsToolStripMenuItem.Text = "Students by Groups";
            this.studentsByGroupsToolStripMenuItem.Click += new System.EventHandler(this.studentsByGroupsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addStudentToGroupToolStripMenuItem
            // 
            this.addStudentToGroupToolStripMenuItem.Name = "addStudentToGroupToolStripMenuItem";
            this.addStudentToGroupToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addStudentToGroupToolStripMenuItem.Text = "Add Student to a Group";
            this.addStudentToGroupToolStripMenuItem.Click += new System.EventHandler(this.addStudentToGroupToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTeachersToolStripMenuItem,
            this.teachersByGroupsToolStripMenuItem,
            this.searchToolStripMenuItem1,
            this.addTeacherInformationToolStripMenuItem});
            this.teachersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // allTeachersToolStripMenuItem
            // 
            this.allTeachersToolStripMenuItem.Name = "allTeachersToolStripMenuItem";
            this.allTeachersToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.allTeachersToolStripMenuItem.Text = "All Teachers";
            this.allTeachersToolStripMenuItem.Click += new System.EventHandler(this.allTeachersToolStripMenuItem_Click);
            // 
            // teachersByGroupsToolStripMenuItem
            // 
            this.teachersByGroupsToolStripMenuItem.Name = "teachersByGroupsToolStripMenuItem";
            this.teachersByGroupsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.teachersByGroupsToolStripMenuItem.Text = "Teachers by Groups";
            this.teachersByGroupsToolStripMenuItem.Click += new System.EventHandler(this.teachersByGroupsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // addTeacherInformationToolStripMenuItem
            // 
            this.addTeacherInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherToAGroupToolStripMenuItem,
            this.addTeacherEducationInformationToolStripMenuItem});
            this.addTeacherInformationToolStripMenuItem.Name = "addTeacherInformationToolStripMenuItem";
            this.addTeacherInformationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addTeacherInformationToolStripMenuItem.Text = "Add Teacher Information";
            // 
            // addTeacherToAGroupToolStripMenuItem
            // 
            this.addTeacherToAGroupToolStripMenuItem.Name = "addTeacherToAGroupToolStripMenuItem";
            this.addTeacherToAGroupToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.addTeacherToAGroupToolStripMenuItem.Text = "Assign Group";
            this.addTeacherToAGroupToolStripMenuItem.Click += new System.EventHandler(this.addTeacherToAGroupToolStripMenuItem_Click);
            // 
            // addTeacherEducationInformationToolStripMenuItem
            // 
            this.addTeacherEducationInformationToolStripMenuItem.Name = "addTeacherEducationInformationToolStripMenuItem";
            this.addTeacherEducationInformationToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.addTeacherEducationInformationToolStripMenuItem.Text = "Add Teacher Education Information";
            this.addTeacherEducationInformationToolStripMenuItem.Click += new System.EventHandler(this.addTeacherEducationInformationToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 21);
            this.toolStripMenuItem1.Text = "Groups";
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsByGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersByGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addTeacherInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToAGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeacherEducationInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
    }
}