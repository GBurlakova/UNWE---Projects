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
    public partial class TeachersAddEducation : Form
    {
        public TeachersAddEducation()
        {
            InitializeComponent();
        }

        private void TeacherShowEducation(SqlConnection connection, string PIN, DataGridView table)
        {
            string showEducationQuery = "SELECT ef.Name, tef.Certificate FROM " + 
                                        "EducationFields as ef INNER JOIN [Teachers-EducationFields] as tef ON " + 
                                        "ef.Code = tef.Code WHERE tef.PIN = @PIN";
            SqlParameter PINParam = new SqlParameter("@PIN", SqlDbType.NVarChar);
            PINParam.Value = PIN;
            SqlParameter[] parameters = new SqlParameter[1] { PINParam };
            SqlCommand showEducationCommand = CommonFormActions.CreateCommand(connection, showEducationQuery, parameters);
            DataTable showEducationDataTable = CommonFormActions.GetDataTable(connection, showEducationCommand);
            table.DataSource = showEducationDataTable;
        }

        private string GetCode(string name)
        {
            string getCode = "SELECT Code FROM EducationFields WHERE Name = @Name";
            SqlParameter nameParam = new SqlParameter("@Name", SqlDbType.NVarChar);
            nameParam.Value = name;
            SqlParameter[] parameters = new SqlParameter[1] { nameParam };
            //string getCode = "SELECT Code FROM EducationFields";
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            SqlCommand getCodeCommand = CommonFormActions.CreateCommand(connection, getCode, parameters);
            using (connection)
            {
                connection.Open();
                SqlDataReader reader = getCodeCommand.ExecuteReader();
                if (reader.Read())
                {
                    string code = reader.GetString(0);
                    return code;
                }
                else
                {
                    return "";
                }
            }

        }

        private void TeachersAddEducation_Load(object sender, EventArgs e)
        {
            string getFields = "SELECT Name FROM EducationFields";
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            SqlCommand getcFieldsCommand = CommonFormActions.CreateCommand(connection, getFields);
            HashSet<string> schedules = new HashSet<string>();
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = getcFieldsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string currentShedule = reader.GetString(0);
                        schedules.Add(currentShedule);
                    }
                    connection.Close();
                }
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
                connection.Close();
            }

            foreach (string item in schedules)
            {
                educationFields.Items.Add(item);
            }
        }

        private void findTeacher_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            try
            {
                string findATeacherQuery = "SELECT * FROM Teachers WHERE PIN = @PIN OR Name = @Name OR [Family Name] = @FName OR Address = @Address";
                //Parameters
                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = teacherPIN.Text;

                SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar);
                name.Value = teacherName.Text;

                SqlParameter fName = new SqlParameter("@FName", SqlDbType.NVarChar);
                fName.Value = teacherFName.Text;

                SqlParameter address = new SqlParameter("@Address", SqlDbType.NVarChar);
                address.Value = teacherAddress.Text;

                SqlParameter[] parameters = new SqlParameter[4] { PIN, name, fName, address };
                SqlCommand findTeacherCommand = CommonFormActions.CreateCommand(connection, findATeacherQuery, parameters);
                DataTable teacherDataTable = CommonFormActions.GetDataTable(connection, findTeacherCommand);
                teacher.DataSource = teacherDataTable;
                if (teacher.Rows.Count == 2)
                {
                    SqlConnection connectionShowEducation = CommonFormActions.CreateConnection("LanguageSchool");
                    string currentPIN = teacher.Rows[0].Cells[0].Value.ToString();
                    TeacherShowEducation(connectionShowEducation, currentPIN, teacherEducation);
                }
                else
                {
                    CommonFormActions.ShowMessage("Notice", "Please select a teacher to show education!");
                    teacherEducation.DataSource = null;
                }
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
                connection.Close();
            }
        }

        private void teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            int rowIndex = teacher.CurrentRow.Index;
            string currentTeacherPIN = teacher.Rows[rowIndex].Cells[0].Value.ToString();
            if (currentTeacherPIN != "")
            {
                string selectStudentQuery = "SELECT * FROM Teachers WHERE [PIN]=@PIN";
                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = currentTeacherPIN;
                SqlParameter[] parameters = new SqlParameter[1] { PIN };
                SqlCommand selectTeacherCommand = CommonFormActions.CreateCommand(connection, selectStudentQuery, parameters);
                DataTable selectedStudent = CommonFormActions.GetDataTable(connection, selectTeacherCommand);
                teacher.DataSource = selectedStudent;
                SqlConnection connectionShowEducation = CommonFormActions.CreateConnection("LanguageSchool");
                string currentPIN = teacher.Rows[0].Cells[0].Value.ToString();
                TeacherShowEducation(connectionShowEducation, currentPIN, teacherEducation);
            }
        }

        private void addEducation_Click(object sender, EventArgs e)
        {
            if (teacher.Rows.Count > 2)
            {
                CommonFormActions.ShowMessage("Notice", "Please select only one teacher before add education!");
            }
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            string addEducation = "INSERT INTO [Teachers-EducationFields] (PIN, Code, Certificate) VALUES (@PIN, @Code, @Certificate)";
            SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
            PIN.Value = teacher.Rows[0].Cells[0].Value.ToString();
            SqlParameter code = new SqlParameter("@Code", SqlDbType.NVarChar);
            string educationField = educationFields.Text;
            if (educationField != "")
	        {
                string codeStr = GetCode(educationField);
                if (codeStr != "")
                {
                    code.Value = codeStr;
                }
                else
                {
                    CommonFormActions.ShowMessage("Notice", "Please select corect education field!");
                    return;
                }
	        }
            else
	        {
                CommonFormActions.ShowMessage("Notice", "Please select education field first!");
                return;
	        }
            SqlParameter certificate = new SqlParameter("@Certificate", SqlDbType.NVarChar);
            if (certificate.Value != null)
            {
                certificate.Value = certificate.Value;
            }
            else
            {
                certificate.Value = "";
            }
            SqlParameter[] parameters = new SqlParameter[3] { PIN, code, certificate };
            SqlCommand addEducationCommand = CommonFormActions.CreateCommand(connection, addEducation, parameters);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = addEducationCommand.ExecuteReader();
                    reader.Close();
                    connection.Close();
                    SqlConnection connectionShowEducation = CommonFormActions.CreateConnection("LanguageSchool");
                    string currentPIN = teacher.Rows[0].Cells[0].Value.ToString();
                    TeacherShowEducation(connectionShowEducation, currentPIN, teacherEducation);
                    CommonFormActions.ShowMessage("Success", "Education information added successfully.");
                }
            }
            catch (SqlException ol)
            {
                if (ol.Number == 2627)
                {
                    CommonFormActions.ShowMessage("Notice", "Cannot finish because of duplicate information.");
                    return;
                }
                MessageBox.Show(ol.Number.ToString());
                connection.Close();
            }
        }
    }
}
