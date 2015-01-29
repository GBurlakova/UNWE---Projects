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
    public partial class StudentsAll : Form
    {
        public StudentsAll()
        {
            InitializeComponent();
        }

        private void All_Students_Load(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Students;", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        allStudentsTable.DataSource = dt;
                    }
                    else
                    {
                        CommonFormActions.ShowMessage("No Results", "No results to show");
                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                }
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            if (allStudentsTable.CurrentRow.Index > -1)
            {

                string query = "INSERT INTO Students (Name, [Family Name], Address) VALUES(@Name, @FName, @Address)";

                SqlParameter studentName = new SqlParameter("@Name", SqlDbType.NVarChar);
                studentName.Value = allStudentsTable.CurrentRow.Cells[1].Value;

                SqlParameter studentFamilyName = new SqlParameter("@FName", SqlDbType.NVarChar);
                studentFamilyName.Value = allStudentsTable.CurrentRow.Cells[2].Value;

                SqlParameter studentAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                studentAddress.Value = allStudentsTable.CurrentRow.Cells[3].Value;

                SqlParameter[] parameters = new SqlParameter[3] { studentName, studentFamilyName, studentAddress };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    CommonFormActions.ShowMessage("Success", "New student added successfully.");
                    CommonFormActions.UpdateDataGrid(connection, "Students", allStudentsTable);
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                    connection.Close();
                }
            }
        }

        private void updStudent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            if (allStudentsTable.CurrentRow.Index > -1)
            {
                string query = "UPDATE Students SET Name = @Name, [Family Name] = @FName, Address = @Address WHERE [Id Student] = @IdStudent";
                SqlParameter studentId = new SqlParameter("@IdStudent", SqlDbType.Int);
                studentId.Value = allStudentsTable.CurrentRow.Cells[0].Value;

                SqlParameter studentName = new SqlParameter("@Name", SqlDbType.NVarChar);
                studentName.Value = allStudentsTable.CurrentRow.Cells[1].Value;

                SqlParameter studentFamilyName = new SqlParameter("@FName", SqlDbType.NVarChar);
                studentFamilyName.Value = allStudentsTable.CurrentRow.Cells[2].Value;

                SqlParameter studentAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                studentAddress.Value = allStudentsTable.CurrentRow.Cells[3].Value;

                SqlParameter[] parameters = new SqlParameter[4] { studentId, studentName, studentFamilyName, studentAddress };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    CommonFormActions.ShowMessage("Success", "Student updated successfully.");
                    CommonFormActions.UpdateDataGrid(connection, "Students", allStudentsTable);
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                    connection.Close();
                }
            }
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            if (allStudentsTable.CurrentRow.Index > -1)
            {
                string query = "DELETE FROM Students WHERE [Id Student] = @IdStudent";
                SqlParameter idStudent = new SqlParameter("@IdStudent", SqlDbType.Int);
                idStudent.Value = allStudentsTable.CurrentRow.Cells[0].Value;
                SqlParameter[] parameters = new SqlParameter[1] { idStudent };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    CommonFormActions.ShowMessage("Success", "Student removed successfully");
                    CommonFormActions.UpdateDataGrid(connection, "Students", allStudentsTable);
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                    connection.Close();
                }
            }
        }
    }
 }
