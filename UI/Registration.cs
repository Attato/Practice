using Practice.Common;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice.UI
{
    public partial class Registration : Form
    {
        DataBase dataBase = new DataBase();

        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            string queryString = $"insert into register(login_user, password_user) values ('{login}', '{password}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            if(textBox_login.TextLength != 0 && textBox_password.TextLength != 0)
            {
                if (checkUser())
                {
                    return;
                }

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Auth auth = new Auth();
                    Hide();
                    auth.ShowDialog();
                }

                else {
                    MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            dataBase.closeConnection();
        }

        // Проверка нет ли юзера в базе данных
        private Boolean checkUser()
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
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
