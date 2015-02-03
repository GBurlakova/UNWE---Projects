namespace ChildrenCanteen.Common
{
    using System.Data.SqlClient;

    public static class CommonDatabaseActions
    {
        public static readonly string ServerName = @"GABY-PC\SQLEXPRESS";

        public static SqlConnection CreateDatabaseConnection(string databaseName)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=" + ServerName + "; Initial Catalog=" +
                databaseName + ";Integrated Security=True; Pooling=False";
            return connection;
        }
    }
}
