namespace LanguageSchool
{
    partial class StudentsByGroups
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
            System.Windows.Forms.Label id_StudentLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label family_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsByGroups));
            this.languageSchoolDataSet = new LanguageSchool.LanguageSchoolDataSet();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter1 = new LanguageSchool.LanguageSchoolDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager1 = new LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager();
            this.students_GroupsTableAdapter = new LanguageSchool.LanguageSchoolDataSetTableAdapters.Students_GroupsTableAdapter();
            this.studentsBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.studentsBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_StudentTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.family_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.students_GroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_GroupsDataGridView = new System.Windows.Forms.DataGridView();
            id_StudentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            family_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1BindingNavigator)).BeginInit();
            this.studentsBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_GroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GroupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_StudentLabel
            // 
            id_StudentLabel.AutoSize = true;
            id_StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_StudentLabel.Location = new System.Drawing.Point(369, 73);
            id_StudentLabel.Name = "id_StudentLabel";
            id_StudentLabel.Size = new System.Drawing.Size(76, 15);
            id_StudentLabel.TabIndex = 1;
            id_StudentLabel.Text = "Id Student:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(369, 99);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // family_NameLabel
            // 
            family_NameLabel.AutoSize = true;
            family_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            family_NameLabel.Location = new System.Drawing.Point(369, 125);
            family_NameLabel.Name = "family_NameLabel";
            family_NameLabel.Size = new System.Drawing.Size(95, 15);
            family_NameLabel.TabIndex = 5;
            family_NameLabel.Text = "Family Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(369, 151);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(62, 15);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // languageSchoolDataSet
            // 
            this.languageSchoolDataSet.DataSetName = "LanguageSchoolDataSet";
            this.languageSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.languageSchoolDataSet;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BuildingsTableAdapter = null;
            this.tableAdapterManager1.CoursesTableAdapter = null;
            this.tableAdapterManager1.EducationFieldsTableAdapter = null;
            this.tableAdapterManager1.GroupsTableAdapter = null;
            this.tableAdapterManager1.Students_GroupsTableAdapter = this.students_GroupsTableAdapter;
            this.tableAdapterManager1.StudentsTableAdapter = this.studentsTableAdapter1;
            this.tableAdapterManager1.Teachers_EducationFieldsTableAdapter = null;
            this.tableAdapterManager1.TeachersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = LanguageSchool.LanguageSchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // students_GroupsTableAdapter
            // 
            this.students_GroupsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsBindingSource1BindingNavigator
            // 
            this.studentsBindingSource1BindingNavigator.AddNewItem = this.toolStripButton11;
            this.studentsBindingSource1BindingNavigator.BindingSource = this.studentsBindingSource1;
            this.studentsBindingSource1BindingNavigator.CountItem = this.toolStripLabel2;
            this.studentsBindingSource1BindingNavigator.DeleteItem = this.toolStripButton12;
            this.studentsBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.toolStripButton11,
            this.toolStripButton12,
            this.studentsBindingSource1BindingNavigatorSaveItem});
            this.studentsBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton7;
            this.studentsBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton10;
            this.studentsBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton9;
            this.studentsBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton8;
            this.studentsBindingSource1BindingNavigator.Name = "studentsBindingSource1BindingNavigator";
            this.studentsBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox2;
            this.studentsBindingSource1BindingNavigator.Size = new System.Drawing.Size(1091, 25);
            this.studentsBindingSource1BindingNavigator.TabIndex = 0;
            this.studentsBindingSource1BindingNavigator.Text = "bindingNavigator2";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Delete";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move first";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move next";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // studentsBindingSource1BindingNavigatorSaveItem
            // 
            this.studentsBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingSource1BindingNavigatorSaveItem.Image")));
            this.studentsBindingSource1BindingNavigatorSaveItem.Name = "studentsBindingSource1BindingNavigatorSaveItem";
            this.studentsBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // id_StudentTextBox1
            // 
            this.id_StudentTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource1, "Id Student", true));
            this.id_StudentTextBox1.Location = new System.Drawing.Point(484, 68);
            this.id_StudentTextBox1.Name = "id_StudentTextBox1";
            this.id_StudentTextBox1.Size = new System.Drawing.Size(236, 20);
            this.id_StudentTextBox1.TabIndex = 2;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource1, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(484, 94);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(236, 20);
            this.nameTextBox1.TabIndex = 4;
            // 
            // family_NameTextBox1
            // 
            this.family_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource1, "Family Name", true));
            this.family_NameTextBox1.Location = new System.Drawing.Point(484, 120);
            this.family_NameTextBox1.Name = "family_NameTextBox1";
            this.family_NameTextBox1.Size = new System.Drawing.Size(236, 20);
            this.family_NameTextBox1.TabIndex = 6;
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource1, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(484, 146);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(236, 20);
            this.addressTextBox1.TabIndex = 8;
            // 
            // students_GroupsBindingSource
            // 
            this.students_GroupsBindingSource.DataMember = "FK_Students-Groups_Students";
            this.students_GroupsBindingSource.DataSource = this.studentsBindingSource1;
            // 
            // students_GroupsDataGridView
            // 
            this.students_GroupsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.students_GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_GroupsDataGridView.Location = new System.Drawing.Point(30, 189);
            this.students_GroupsDataGridView.Name = "students_GroupsDataGridView";
            this.students_GroupsDataGridView.Size = new System.Drawing.Size(1038, 220);
            this.students_GroupsDataGridView.TabIndex = 9;
            // 
            // StudentsByGroups
            // 
            this.ClientSize = new System.Drawing.Size(1091, 429);
            this.Controls.Add(this.students_GroupsDataGridView);
            this.Controls.Add(id_StudentLabel);
            this.Controls.Add(this.id_StudentTextBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(family_NameLabel);
            this.Controls.Add(this.family_NameTextBox1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(this.studentsBindingSource1BindingNavigator);
            this.Name = "StudentsByGroups";
            this.Text = "Students by Groups";
            this.Load += new System.EventHandler(this.StudentsByGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1BindingNavigator)).EndInit();
            this.studentsBindingSource1BindingNavigator.ResumeLayout(false);
            this.studentsBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_GroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GroupsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_StudentTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox family_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private LanguageSchoolDataSet languageSchoolDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private LanguageSchoolDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter1;
        private LanguageSchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator studentsBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton studentsBindingSource1BindingNavigatorSaveItem;
        private LanguageSchoolDataSetTableAdapters.Students_GroupsTableAdapter students_GroupsTableAdapter;
        private System.Windows.Forms.TextBox id_StudentTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox family_NameTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.BindingSource students_GroupsBindingSource;
        private System.Windows.Forms.DataGridView students_GroupsDataGridView;
    }
}