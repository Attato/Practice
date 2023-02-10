using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practice.Common
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=gogs.wsr.ru;Initial Catalog=TourAgency;User ID=User04;Password=User04");

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
