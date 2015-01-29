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
    public partial class StudentsAddToAGroup : Form
    {
        public StudentsAddToAGroup()
        {
            InitializeComponent();
        }

        private void StudentsAddToAGroup_Load(object sender, EventArgs e)
        {
            string getSchedules = "SELECT Schedule FROM Groups";
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            SqlCommand getcShedulesCommand = CommonFormActions.CreateCommand(connection, getSchedules);
            HashSet<string> schedules = new HashSet<string>();
            try
            {
                using (connection)
                {
                    SqlDataReader reader = getcShedulesCommand.ExecuteReader();
                    while (reader.HasRows)
                    {
                        string currentShedule = reader.GetString(0);
                        schedules.Add(currentShedule);
                    }
                    reader.Close();
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

        private void findStudent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            try
            {
                string findStudentQuery = "SELECT * FROM Students WHERE Name=@Name OR [Family Name]=@FName OR Address=@Address";

                SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar);
                name.Value = studentName.Text;

                SqlParameter fName = new SqlParameter("@FName", SqlDbType.NVarChar);
                fName.Value = studentFName.Text;

                SqlParameter address = new SqlParameter("@Address", SqlDbType.NVarChar);
                address.Value = studentAddress.Text;

                SqlParameter[] parameters = new SqlParameter[3] {name, fName, address};

                SqlCommand findStudentCommand = CommonFormActions.CreateCommand(connection, findStudentQuery, parameters);
                student.DataSource = CommonFormActions.GetDataTable(connection, findStudentCommand);
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
                connection.Close();
            }
        }

        private void student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            int rowIndex = student.CurrentRow.Index;
            string currentStudentId = student.Rows[rowIndex].Cells[0].Value.ToString();
            if (currentStudentId != "")
            {
                string selectStudentQuery = "SELECT * FROM Students WHERE [Id Student]=@IdStudent";
                SqlParameter studentId = new SqlParameter("@IdStudent", SqlDbType.NVarChar);
                studentId.Value = currentStudentId;
                SqlParameter[] parameters = new SqlParameter[1] { studentId };
                SqlCommand selectStudentCommand = CommonFormActions.CreateCommand(connection, selectStudentQuery, parameters);
                using (connection)
                {
                    DataTable selectedStudent = CommonFormActions.GetDataTable(connection, selectStudentCommand);
                    student.DataSource = selectedStudent;
                }
            }
        }

        private void findGroup_Click(object sender, EventArgs e)
        {

            string findGroupQuery = "SELECT * FROM Groups WHERE [Start Date] >= @StartDate AND " +
                                    "Schedule = @Shedule AND [Start Time] >= @StartTime";

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

        private void enroll_Click(object sender, EventArgs e)
        {
            if (group.Rows.Count > 1 && student.Rows.Count > 1)
            {
                if (student.Rows.Count > 2)
                {
                    CommonFormActions.ShowMessage("Notice", "PLease selcet only one student!");
                    return;
                }

                if (group.Rows.Count > 2)
                {
                    CommonFormActions.ShowMessage("Notice", "Please select only one group!");
                    return;
                }

                string enrolStudentQuery = "INSERT INTO [Students-Groups] ([Id Student], [Id Group]) VALUES(@IdStudent, @IdGroup)";

                //Parameters
                SqlParameter idStudent = new SqlParameter("@IdStudent", SqlDbType.Int);
                idStudent.Value = student.Rows[0].Cells[0].Value;

                SqlParameter idGroup = new SqlParameter("@IdGroup", SqlDbType.Int);
                idGroup.Value = group.Rows[0].Cells[0].Value;

                SqlParameter[] parameters = new SqlParameter[2] { idStudent, idGroup };

                SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
                SqlCommand enrollStudentCommand = CommonFormActions.CreateCommand(connection, enrolStudentQuery, parameters);
                using (connection)
                {
                    SqlDataReader reader = enrollStudentCommand.ExecuteReader();
                    reader.Close();
                }
                CommonFormActions.ShowMessage("Success", "Student enrolled successfully");
            }
            else
            {
                CommonFormActions.ShowMessage("Notice", "Please select student and group!");
            }
        }
    }
}
