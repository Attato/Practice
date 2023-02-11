using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practice.UI;
using Practice.dataBase;

namespace Practice
{
    public partial class Auth : Form
    {
        DataBase database = new DataBase();
        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';

            textBox_login.MaxLength = 16;
            textBox_password.MaxLength = 25;
        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select UserID, Username, Password from auth where Username = '{login}' and Password = '{password}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

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
            Registration registration = new Registration();
            Hide();
            registration.ShowDialog();
            Show();
        }
    }
}
