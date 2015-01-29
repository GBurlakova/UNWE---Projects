namespace LanguageSchool
{
    partial class TeachersAll
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
            this.components = new System.ComponentModel.Container();
            this.languageSchoolDataSet = new LanguageSchool.LanguageSchoolDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new LanguageSchool.LanguageSchoolDataSetTableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager();
            this.allTeachersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTeacher = new System.Windows.Forms.Button();
            this.updTeacher = new System.Windows.Forms.Button();
            this.remTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTeachersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // languageSchoolDataSet
            // 
            this.languageSchoolDataSet.DataSetName = "LanguageSchoolDataSet";
            this.languageSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.languageSchoolDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingsTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.EducationFieldsTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.Students_GroupsTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.Teachers_EducationFieldsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // allTeachersTable
            // 
            this.allTeachersTable.AutoGenerateColumns = false;
            this.allTeachersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allTeachersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTeachersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.allTeachersTable.DataSource = this.teachersBindingSource;
            this.allTeachersTable.Location = new System.Drawing.Point(63, 123);
            this.allTeachersTable.Name = "allTeachersTable";
            this.allTeachersTable.Size = new System.Drawing.Size(577, 220);
            this.allTeachersTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "PIN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Family Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Family Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // addTeacher
            // 
            this.addTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacher.Location = new System.Drawing.Point(27, 25);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Size = new System.Drawing.Size(147, 38);
            this.addTeacher.TabIndex = 2;
            this.addTeacher.Text = "Add Teacher";
            this.addTeacher.UseVisualStyleBackColor = true;
            this.addTeacher.Click += new System.EventHandler(this.addTeacher_Click);
            // 
            // updTeacher
            // 
            this.updTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updTeacher.Location = new System.Drawing.Point(261, 25);
            this.updTeacher.Name = "updTeacher";
            this.updTeacher.Size = new System.Drawing.Size(147, 38);
            this.updTeacher.TabIndex = 3;
            this.updTeacher.Text = "Update Teacher";
            this.updTeacher.UseVisualStyleBackColor = true;
            this.updTeacher.Click += new System.EventHandler(this.updTeacher_Click);
            // 
            // remTeacher
            // 
            this.remTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remTeacher.Location = new System.Drawing.Point(527, 25);
            this.remTeacher.Name = "remTeacher";
            this.remTeacher.Size = new System.Drawing.Size(147, 38);
            this.remTeacher.TabIndex = 4;
            this.remTeacher.Text = "Remove Teacher";
            this.remTeacher.UseVisualStyleBackColor = true;
            this.remTeacher.Click += new System.EventHandler(this.remTeacher_Click);
            // 
            // TeachersAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 355);
            this.Controls.Add(this.remTeacher);
            this.Controls.Add(this.updTeacher);
            this.Controls.Add(this.addTeacher);
            this.Controls.Add(this.allTeachersTable);
            this.Name = "TeachersAll";
            this.Text = "TeachersSearch";
            this.Load += new System.EventHandler(this.TeachersSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTeachersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LanguageSchoolDataSet languageSchoolDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private LanguageSchoolDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private LanguageSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView allTeachersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button addTeacher;
        private System.Windows.Forms.Button updTeacher;
        private System.Windows.Forms.Button remTeacher;
    }
}