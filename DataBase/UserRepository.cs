using Practice.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.DataBase
{
    public class UserRepository : IUserRepository
    {

        public Boolean CheckUser(string login, string password)
        {
            var loginUser = login;
            var passwordUser = password;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот пользователь уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
