using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practice.dataBase;

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

            string queryString = $"insert into auth(Username, Password) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            if(textBox_login.TextLength != 0 && textBox_password.TextLength != 0)
            {

                if (CheckUser())
                {
                    return;
                }

                dataBase.openConnection();

                if (textBox_password.Text != textBox_login.Text)
                {
                    if(command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                        Auth auth = new Auth();
                        Hide();
                        auth.ShowDialog();
                    }

                    else {
                        MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataBase.closeConnection();
                }

                else
                {
                    MessageBox.Show("Вы не можете использовать логин в качестве пароля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private Boolean CheckUser()
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select UserID, Username, Password from auth where Username = '{login}' and Password = '{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

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

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
