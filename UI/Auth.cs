using Practice.Common;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practice.UI;
using Practice.DataBase;

namespace Practice
{
    public partial class Auth : Form
    {
        IUserRepository userRepository;
        public Auth(IUserRepository userRepository)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';

            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainform = new MainForm();
                Hide();
                mainform.ShowDialog();
                Show();

            }

            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration(userRepository);
            Hide();
            registration.ShowDialog();
            Show();
        }
    }
}
