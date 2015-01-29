namespace LanguageSchool
{
    partial class TeachersAddEducation
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.DataGridView();
            this.findTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherFName = new System.Windows.Forms.TextBox();
            this.teacherAddress = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.teacherPIN = new System.Windows.Forms.TextBox();
            this.educationFields = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherEducation = new System.Windows.Forms.DataGridView();
            this.addEducation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.certificate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(672, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(473, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Family Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // teacher
            // 
            this.teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher.Location = new System.Drawing.Point(126, 116);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(643, 123);
            this.teacher.TabIndex = 16;
            this.teacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_CellClick);
            // 
            // findTeacher
            // 
            this.findTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTeacher.Location = new System.Drawing.Point(807, 52);
            this.findTeacher.Name = "findTeacher";
            this.findTeacher.Size = new System.Drawing.Size(125, 39);
            this.findTeacher.TabIndex = 15;
            this.findTeacher.Text = "Find Teacher";
            this.findTeacher.UseVisualStyleBackColor = true;
            this.findTeacher.Click += new System.EventHandler(this.findTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "PIN";
            // 
            // teacherFName
            // 
            this.teacherFName.Location = new System.Drawing.Point(451, 63);
            this.teacherFName.Name = "teacherFName";
            this.teacherFName.Size = new System.Drawing.Size(140, 20);
            this.teacherFName.TabIndex = 13;
            // 
            // teacherAddress
            // 
            this.teacherAddress.Location = new System.Drawing.Point(631, 63);
            this.teacherAddress.Name = "teacherAddress";
            this.teacherAddress.Size = new System.Drawing.Size(138, 20);
            this.teacherAddress.TabIndex = 12;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(269, 63);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(143, 20);
            this.teacherName.TabIndex = 11;
            // 
            // teacherPIN
            // 
            this.teacherPIN.Location = new System.Drawing.Point(74, 63);
            this.teacherPIN.Name = "teacherPIN";
            this.teacherPIN.Size = new System.Drawing.Size(138, 20);
            this.teacherPIN.TabIndex = 10;
            // 
            // educationFields
            // 
            this.educationFields.FormattingEnabled = true;
            this.educationFields.Location = new System.Drawing.Point(74, 476);
            this.educationFields.Name = "educationFields";
            this.educationFields.Size = new System.Drawing.Size(212, 21);
            this.educationFields.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(391, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Current Education";
            // 
            // teacherEducation
            // 
            this.teacherEducation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teacherEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherEducation.Location = new System.Drawing.Point(269, 298);
            this.teacherEducation.Name = "teacherEducation";
            this.teacherEducation.Size = new System.Drawing.Size(368, 130);
            this.teacherEducation.TabIndex = 22;
            // 
            // addEducation
            // 
            this.addEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEducation.Location = new System.Drawing.Point(651, 465);
            this.addEducation.Name = "addEducation";
            this.addEducation.Size = new System.Drawing.Size(227, 39);
            this.addEducation.TabIndex = 23;
            this.addEducation.Text = "Add Education Information";
            this.addEducation.UseVisualStyleBackColor = true;
            this.addEducation.Click += new System.EventHandler(this.addEducation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(391, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Current Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(112, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Current Education";
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(336, 476);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(228, 20);
            this.certificate.TabIndex = 26;
            // 
            // TeachersAddEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 538);
            this.Controls.Add(this.certificate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addEducation);
            this.Controls.Add(this.teacherEducation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.educationFields);
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
            this.Name = "TeachersAddEducation";
            this.Text = "Teachers Add Education";
            this.Load += new System.EventHandler(this.TeachersAddEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherEducation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView teacher;
        private System.Windows.Forms.Button findTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacherFName;
        private System.Windows.Forms.TextBox teacherAddress;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.TextBox teacherPIN;
        private System.Windows.Forms.ComboBox educationFields;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView teacherEducation;
        private System.Windows.Forms.Button addEducation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox certificate;
    }
}