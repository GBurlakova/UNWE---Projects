namespace LanguageSchool
{
    partial class StudentsAll
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
            this.allStudentsTable = new System.Windows.Forms.DataGridView();
            this.addStudent = new System.Windows.Forms.Button();
            this.updStudent = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // allStudentsTable
            // 
            this.allStudentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allStudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allStudentsTable.Location = new System.Drawing.Point(55, 76);
            this.allStudentsTable.Name = "allStudentsTable";
            this.allStudentsTable.Size = new System.Drawing.Size(515, 251);
            this.allStudentsTable.TabIndex = 0;
            // 
            // addStudent
            // 
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.Location = new System.Drawing.Point(29, 27);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(129, 33);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // updStudent
            // 
            this.updStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updStudent.Location = new System.Drawing.Point(237, 27);
            this.updStudent.Name = "updStudent";
            this.updStudent.Size = new System.Drawing.Size(124, 33);
            this.updStudent.TabIndex = 2;
            this.updStudent.Text = "Update Student";
            this.updStudent.UseVisualStyleBackColor = true;
            this.updStudent.Click += new System.EventHandler(this.updStudent_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeStudent.Location = new System.Drawing.Point(464, 27);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(123, 33);
            this.removeStudent.TabIndex = 3;
            this.removeStudent.Text = "Remove Student";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // StudentsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 339);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.updStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.allStudentsTable);
            this.Name = "StudentsAll";
            this.Text = "All Students";
            this.Load += new System.EventHandler(this.All_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allStudentsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allStudentsTable;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button updStudent;
        private System.Windows.Forms.Button removeStudent;
    }
}