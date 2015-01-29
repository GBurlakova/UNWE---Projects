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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsAll studentsAll = new StudentsAll();
            studentsAll.MdiParent = this;
            studentsAll.StartPosition = FormStartPosition.CenterScreen;
            studentsAll.Show();
        }

        private void studentsByGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsByGroups studentsByGroups = new StudentsByGroups();
            studentsByGroups.MdiParent = this;
            studentsByGroups.StartPosition = FormStartPosition.CenterScreen;
            studentsByGroups.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsSearch studentsSearch = new StudentsSearch();
            studentsSearch.MdiParent = this;
            studentsSearch.StartPosition = FormStartPosition.CenterScreen;
            studentsSearch.Show();
        }

        private void addStudentToGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsAddToAGroup studentAdd = new StudentsAddToAGroup();
            studentAdd.MdiParent = this;
            studentAdd.StartPosition = FormStartPosition.CenterScreen;
            studentAdd.Show();
        }

        private void allTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersAll teachersAll = new TeachersAll();
            teachersAll.MdiParent = this;
            teachersAll.StartPosition = FormStartPosition.CenterScreen;
            teachersAll.Show();
        }

        private void teachersByGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersByGroups teachersByGroups = new TeachersByGroups();
            teachersByGroups.MdiParent = this;
            teachersByGroups.StartPosition = FormStartPosition.CenterScreen;
            teachersByGroups.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeachersSearch teachersSearch = new TeachersSearch();
            teachersSearch.MdiParent = this;
            teachersSearch.StartPosition = FormStartPosition.CenterScreen;
            teachersSearch.Show();
        }

        private void addTeacherToAGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersAssignGroup teacherAddToGroup = new TeachersAssignGroup();
            teacherAddToGroup.MdiParent = this;
            teacherAddToGroup.StartPosition = FormStartPosition.CenterScreen;
            teacherAddToGroup.Show();
        }

        private void addTeacherEducationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersAddEducation teacherAddEducation = new TeachersAddEducation();
            teacherAddEducation.MdiParent = this;
            teacherAddEducation.StartPosition = FormStartPosition.CenterScreen;
            teacherAddEducation.Show();
        }
    }
}
