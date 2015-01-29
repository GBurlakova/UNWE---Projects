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
    public partial class TeachersAll : Form
    {
        public TeachersAll()
        {
            InitializeComponent();
        }

        SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
        private void TeachersSearch_Load(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Teachers", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        allTeachersTable.DataSource = dt;
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

        private void addTeacher_Click(object sender, EventArgs e)
        {
            if (allTeachersTable.CurrentRow.Index > -1)
            {

                string query = "INSERT INTO Teachers (PIN, Name, [Family Name], Address) VALUES(@PIN, @Name, @FName, @Address)";

                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = allTeachersTable.CurrentRow.Cells[0].Value;

                SqlParameter teacherName = new SqlParameter("@Name", SqlDbType.NVarChar);
                teacherName.Value = allTeachersTable.CurrentRow.Cells[1].Value;

                SqlParameter teacherFamilyName = new SqlParameter("@FName", SqlDbType.NVarChar);
                teacherFamilyName.Value = allTeachersTable.CurrentRow.Cells[2].Value;

                SqlParameter teacherAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                teacherAddress.Value = allTeachersTable.CurrentRow.Cells[3].Value;

                SqlParameter[] parameters = new SqlParameter[4] { PIN, teacherName, teacherFamilyName, teacherAddress };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    CommonFormActions.ShowMessage("Success", "New teacher added successfully.");
                    CommonFormActions.UpdateDataGrid(connection, "Teachers", allTeachersTable); 
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                    connection.Close();
                }
            }
        }

        private void updTeacher_Click(object sender, EventArgs e)
        {
            if (allTeachersTable.CurrentRow.Index > -1)
            {
                string query = "UPDATE Teachers SET PIN = @PIN, Name = @Name, [Family Name] = @FName, Address = @Address WHERE [PIN] = @PIN";
                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = allTeachersTable.CurrentRow.Cells[0].Value;

                SqlParameter teacherName = new SqlParameter("@Name", SqlDbType.NVarChar);
                teacherName.Value = allTeachersTable.CurrentRow.Cells[1].Value;

                SqlParameter teacherFamilyName = new SqlParameter("@FName", SqlDbType.NVarChar);
                teacherFamilyName.Value = allTeachersTable.CurrentRow.Cells[2].Value;

                SqlParameter teacherAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                teacherAddress.Value = allTeachersTable.CurrentRow.Cells[3].Value;

                SqlParameter[] parameters = new SqlParameter[4] { PIN, teacherName, teacherFamilyName, teacherAddress };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();
                    }
                    CommonFormActions.ShowMessage("Success", "Teacher updated successfully.");
                    CommonFormActions.UpdateDataGrid(connection, "Teachers", allTeachersTable);
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                    connection.Close();
                }
            }
        }

        private void remTeacher_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            if (allTeachersTable.CurrentRow.Index > -1)
            {
                string query = "DELETE FROM Teachers WHERE PIN = @PIN";
                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = allTeachersTable.CurrentRow.Cells[0].Value;
                SqlParameter[] parameters = new SqlParameter[1] { PIN };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                try
                {
                    using (connection)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close(); 
                    }
                    CommonFormActions.ShowMessage("Success", "Teacher removed successfully");
                    CommonFormActions.UpdateDataGrid(connection, "Teachers", allTeachersTable);
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
