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
    public partial class TeachersAssignGroup : Form
    {
        public TeachersAssignGroup()
        {
            InitializeComponent();
        }

        private void TeacherAddToAGroup_Load(object sender, EventArgs e)
        {
            string getSchedules = "SELECT Schedule FROM Groups";
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            SqlCommand getcShedulesCommand = CommonFormActions.CreateCommand(connection, getSchedules);
            HashSet<string> schedules = new HashSet<string>();
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = getcShedulesCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string currentShedule = reader.GetString(1);
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
                schedule.Items.Add(item);
            }
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "yyyy-MM-dd";
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
            }
        }

        private void findGroup_Click(object sender, EventArgs e)
        {
            string findGroupQuery = "SELECT * FROM Groups WHERE [Start Date] >= @StartDate AND " +
                                    "Schedule = @Shedule AND [Start Time] >= @StartTime AND PIN IS NULL";

            //Parameters 
            SqlParameter date = new SqlParameter("@StartDate", SqlDbType.Date);
            date.Value = startDate.Value.ToShortDateString();

            SqlParameter weekSchedule = new SqlParameter("@Shedule", SqlDbType.NVarChar);
            weekSchedule.Value = schedule.Text;

            SqlParameter time = new SqlParameter("@StartTime", SqlDbType.Time);
            time.Value = startTime.Value.TimeOfDay;

            SqlParameter[] parameters = new SqlParameter[3] { date, weekSchedule, time};

            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            SqlCommand findGroupCommad = CommonFormActions.CreateCommand(connection, findGroupQuery, parameters);
            DataTable groups = CommonFormActions.GetDataTable(connection, findGroupCommad);
            group.DataSource = groups;
        }

        private void group_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            int rowIndex = group.CurrentRow.Index;
            int currentGroupId = 0;
            bool isId = int.TryParse(group.Rows[rowIndex].Cells[0].Value.ToString(), out currentGroupId);
            if (isId)
            {
                string selectGroupQuery = "SELECT * FROM Groups WHERE [Id Group]=@IdGroup";
                SqlParameter groupId = new SqlParameter("@IdGroup", SqlDbType.Int);
                groupId.Value = currentGroupId;
                SqlParameter[] parameters = new SqlParameter[1] { groupId };
                SqlCommand selectGroupCommand = CommonFormActions.CreateCommand(connection, selectGroupQuery, parameters);
                DataTable selectedGroup = CommonFormActions.GetDataTable(connection, selectGroupCommand);
                group.DataSource = selectedGroup;
            }
        }

        private void assingn_Click(object sender, EventArgs e)
        {
            if (group.Rows.Count > 1 && teacher.Rows.Count > 1)
            {
                if (teacher.Rows.Count > 2)
                {
                    CommonFormActions.ShowMessage("Notice", "PLease selcet only one teacher!");
                    return;
                }

                if (group.Rows.Count > 2)
                {
                    CommonFormActions.ShowMessage("Notice", "Please select only one group!");
                    return;
                }

                string assignGroupQuery = "UPDATE Groups SET PIN = @PIN WHERE [Id Group] = @IdGroup";


                //Parameters
                SqlParameter idGroup = new SqlParameter("@IdGroup", SqlDbType.Int);
                idGroup.Value = group.Rows[0].Cells[0].Value;

                SqlParameter PIN = new SqlParameter("@PIN", SqlDbType.NVarChar);
                PIN.Value = teacher.Rows[0].Cells[0].Value;

                SqlParameter[] parameters = new SqlParameter[2] { idGroup, PIN };

                SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
                SqlCommand assignGroupCommand = CommonFormActions.CreateCommand(connection, assignGroupQuery, parameters);
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = assignGroupCommand.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
                CommonFormActions.ShowMessage("Success", "Group assigned successfully.");
            }
            else
            {
                CommonFormActions.ShowMessage("Notice", "Please select teacher and group!");
            }
        }
    }
}
