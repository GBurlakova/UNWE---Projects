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
    public partial class TeachersByGroups : Form
    {
        public TeachersByGroups()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.languageSchoolDataSet);

        }

        private void TeachersByGroups_Load(object sender, EventArgs e)
        {
            this.teachersTableAdapter.Fill(this.languageSchoolDataSet.Teachers);
            this.groupsTableAdapter.Fill(this.languageSchoolDataSet.Groups);
            this.groupsDataGridView.DataSource = this.groupsBindingSource; 
        }
    }
}
