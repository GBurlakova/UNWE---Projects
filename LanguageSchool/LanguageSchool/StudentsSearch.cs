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
    public partial class StudentsSearch : Form
    {
        public StudentsSearch()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.languageSchoolDataSet);

        }

        private void studentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.languageSchoolDataSet);

        }

        private void StudentsSingleSearch_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.languageSchoolDataSet.Students);
        }

        private void searchTerm_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection connection = CommonFormActions.CreateConnection("LanguageSchool");
            try
            {
                string query = "SELECT * FROM Students WHERE [Id Student] LIKE '%' + @Term + '%' or Name LIKE '%' + @Term + '%' or [Family Name] LIKE '%' + @Term + '%' or Address LIKE '%' + @Term + '%'";
                SqlParameter term = new SqlParameter("@Term", SqlDbType.NVarChar);
                term.Value = searchTerm.Text;
                SqlParameter[] parameters = new SqlParameter[1] { term };
                SqlCommand command = CommonFormActions.CreateCommand(connection, query, parameters);
                DataTable data = CommonFormActions.GetDataTable(connection, command);
                studentsDataGridView.DataSource = data;
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
                connection.Close();
            }
        }
    }
}
