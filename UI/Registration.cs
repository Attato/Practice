using Practice.Common;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practice.DataBase;

namespace Practice.UI
{
    public partial class Registration : Form
    {
        IUserRepository userRepository;

        public Registration(IUserRepository userRepository)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.userRepository = userRepository;
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


            if(textBox_login.TextLength != 0 && textBox_password.TextLength != 0)
            {
                if (userRepository.CheckUser(textBox_login.Text, textBox_password.Text))
                {
                    return;
                }

                else {
                    MessageBox.Show("Аккаунт не создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }
    }
}
