using System.Data.SqlClient;

namespace Practice.dataBase
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=ATTATO\SQLEXPRESS;Initial Catalog=data;Integrated Security=True");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection ()
        {
            return sqlConnection;
        }
    }
}
