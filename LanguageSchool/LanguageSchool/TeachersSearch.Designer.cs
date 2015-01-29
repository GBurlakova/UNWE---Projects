namespace LanguageSchool
{
    partial class TeachersSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.languageSchoolDataSet = new LanguageSchool.LanguageSchoolDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new LanguageSchool.LanguageSchoolDataSetTableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager();
            this.teachers_EducationFieldsTableAdapter = new LanguageSchool.LanguageSchoolDataSetTableAdapters.Teachers_EducationFieldsTableAdapter();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.teachers_EducationFieldsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachers_EducationFieldsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_EducationFieldsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_EducationFieldsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(371, 24);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(216, 20);
            this.searchTerm.TabIndex = 1;
            this.searchTerm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTerm_KeyUp);
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
            this.tableAdapterManager.Teachers_EducationFieldsTableAdapter = this.teachers_EducationFieldsTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teachers_EducationFieldsTableAdapter
            // 
            this.teachers_EducationFieldsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Location = new System.Drawing.Point(123, 120);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.Size = new System.Drawing.Size(564, 220);
            this.teachersDataGridView.TabIndex = 3;
            this.teachersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachersDataGridView_CellClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Data";
            // 
            // teachers_EducationFieldsBindingSource
            // 
            this.teachers_EducationFieldsBindingSource.DataMember = "FK_Teachers-EducationFields_Teachers";
            this.teachers_EducationFieldsBindingSource.DataSource = this.teachersBindingSource;
            // 
            // teachers_EducationFieldsDataGridView
            // 
            this.teachers_EducationFieldsDataGridView.AutoGenerateColumns = false;
            this.teachers_EducationFieldsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachers_EducationFieldsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_EducationFieldsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.teachers_EducationFieldsDataGridView.DataSource = this.teachers_EducationFieldsBindingSource;
            this.teachers_EducationFieldsDataGridView.Location = new System.Drawing.Point(123, 456);
            this.teachers_EducationFieldsDataGridView.Name = "teachers_EducationFieldsDataGridView";
            this.teachers_EducationFieldsDataGridView.Size = new System.Drawing.Size(564, 145);
            this.teachers_EducationFieldsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "PIN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn6.HeaderText = "Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Certificate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Certificate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(335, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Education Data";
            // 
            // TeachersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teachers_EducationFieldsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teachersDataGridView);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.label1);
            this.Name = "TeachersSearch";
            this.Text = "TeachersAll";
            this.Load += new System.EventHandler(this.TeachersSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_EducationFieldsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_EducationFieldsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTerm;
        private LanguageSchoolDataSet languageSchoolDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private LanguageSchoolDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private LanguageSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LanguageSchoolDataSetTableAdapters.Teachers_EducationFieldsTableAdapter teachers_EducationFieldsTableAdapter;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource teachers_EducationFieldsBindingSource;
        private System.Windows.Forms.DataGridView teachers_EducationFieldsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label3;
    }
}