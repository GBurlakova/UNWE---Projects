using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageSchool
{
    public partial class StudentsByGroups : Form
    {
        public StudentsByGroups()
        {
            InitializeComponent();
        }

        private void studentsBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.languageSchoolDataSet);

        }

        private void StudentsByGroups_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter1.Fill(this.languageSchoolDataSet.Students);
            this.students_GroupsTableAdapter.FillByStudentsGroups(this.languageSchoolDataSet._Students_Groups);
            students_GroupsDataGridView.DataSource = this.students_GroupsBindingSource;
        }
    }
}
