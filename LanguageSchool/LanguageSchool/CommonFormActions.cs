using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageSchool
{
    class CommonFormActions
    {
        //Private method to create SQL con
        public static SqlConnection CreateConnection(string database)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=GABY-PC\SQLEXPRESS;Initial Catalog=" + database + ";Integrated Security=True";
            return connection;
        }

        //Update data field after any SQL operation
        public static void UpdateDataGrid(SqlConnection connection, string table, DataGridView dataGrid)
        {
            using (connection)
            {
                string query = "SELECT * FROM " + table;
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        dataGrid.DataSource = data;
                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message.ToString());
                }
            }
        }

        //Shows a message
        public static void ShowMessage(string caption, string message)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, button);
        }

        //Create Command
        public static SqlCommand CreateCommand(SqlConnection connection, string query, SqlParameter[] parameters = null)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            if (parameters != null)
            {
                for (int param = 0; param < parameters.Length; param++)
                {
                    command.Parameters.Add(parameters[param]);
                }
            }
            return command;
        }

        //Get Data Table
        public static DataTable GetDataTable(SqlConnection connection, SqlCommand command)
        {
            using (connection)
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
