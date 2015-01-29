using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageSchool
{
    public partial class TeachersSearch : Form
    {
        public TeachersSearch()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.languageSchoolDataSet);

        }

        private void TeachersSearch_Load(object sender, EventArgs e)
        {
            this.teachers_EducationFieldsTableAdapter.Fill(this.languageSchoolDataSet._Teachers_EducationFields);
            this.teachersTableAdapter.Fill(this.languageSchoolDataSet.Teachers);
        }

        private void searchTerm_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection connectionTeachersSearch = CommonFormActions.CreateConnection("LanguageSchool");
            try
            {
                string selectTeachers = "SELECT * FROM Teachers WHERE PIN LIKE '%' + @Term + '%' or Name LIKE '%' + @Term + '%' or [Family Name] LIKE '%' + @Term + '%' or Address LIKE '%' + @Term + '%'";
                SqlParameter teachersTerm = new SqlParameter("@Term", SqlDbType.NVarChar);
                teachersTerm.Value = searchTerm.Text;
                SqlParameter[] parameters = new SqlParameter[1] { teachersTerm };
                DataTable personalDataTable = new DataTable();
                SqlCommand command = CommonFormActions.CreateCommand(connectionTeachersSearch, selectTeachers, parameters);
                using (connectionTeachersSearch)
                {
                    connectionTeachersSearch.Open();
                    command.ExecuteNonQuery();
                    personalDataTable = CommonFormActions.GetDataTable(connectionTeachersSearch, command);
                    connectionTeachersSearch.Close();
                }
                teachersDataGridView.DataSource = personalDataTable;               
                string selectTeachersEducation = "";
                DataTable educationDataTable = new DataTable();
                for (int row = 0; row < teachersDataGridView.Rows.Count - 1; row++)
                {
                    SqlConnection connectionEducationSearch = CommonFormActions.CreateConnection("LanguageSchool");
                    string currentPIN = teachersDataGridView.Rows[row].Cells[0].Value.ToString();
                    selectTeachersEducation = "SELECT tef.PIN, tef.Code, tef.Certificate FROM [Teachers-EducationFields] as tef WHERE tef.PIN = @PIN";
                    SqlParameter teachersEducParam = new SqlParameter("@PIN", SqlDbType.NVarChar);
                    teachersEducParam.Value = currentPIN;
                    SqlParameter[] parametersEducation = new SqlParameter[1] { teachersEducParam };
                    SqlCommand commandEduc = CommonFormActions.CreateCommand(connectionEducationSearch, selectTeachersEducation, parametersEducation);
                    using (connectionEducationSearch)
                    {
                        DataTable currentResults = CommonFormActions.GetDataTable(connectionEducationSearch, commandEduc);
                        educationDataTable.Merge(currentResults, true);  
                    }
                }
                teachers_EducationFieldsDataGridView.DataSource = educationDataTable;
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
                connectionTeachersSearch.Close();
            }
        }

        private void teachersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = teachersDataGridView.CurrentRow.Index;
            string currentTeacherPIN = teachersDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            if (currentTeacherPIN != "")
            {
                SqlConnection connectionForTeacher = CommonFormActions.CreateConnection("LanguageSchool");
                string selectTeacher = "SELECT * FROM Teachers WHERE PIN = @PIN";
                SqlParameter selectTeacherPIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                selectTeacherPIN.Value = currentTeacherPIN;
                SqlParameter[] selectTeacherParameters = new SqlParameter[1] {selectTeacherPIN};
                SqlCommand selectStudentCommand = CommonFormActions.CreateCommand(connectionForTeacher, selectTeacher, selectTeacherParameters);
                DataTable selectedTeacherDataTable = CommonFormActions.GetDataTable(connectionForTeacher, selectStudentCommand);
                teachersDataGridView.DataSource = selectedTeacherDataTable;

                SqlConnection connectionForEducation = CommonFormActions.CreateConnection("LanguageSchool");
                string selectEducation = "SELECT PIN, Code, Certificate FROM [Teachers-EducationFields] WHERE PIN = @PIN";
                SqlParameter selectEducationPIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                selectEducationPIN.Value = currentTeacherPIN;
                SqlParameter[] selectEducationParameters = new SqlParameter[1] { selectEducationPIN };
                SqlCommand selectEducationCommand = CommonFormActions.CreateCommand(connectionForEducation, selectEducation, selectEducationParameters);
                DataTable selectedEducationDataTable = CommonFormActions.GetDataTable(connectionForEducation, selectEducationCommand);
                teachers_EducationFieldsDataGridView.DataSource = selectedEducationDataTable;
            }
        }
    }
}
