using System;
using System.Windows.Forms;

namespace Practice.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tourAgencyDataSet.Hotel". При необходимости она может быть перемещена или удалена.
            this.hotelTableAdapter.Fill(this.tourAgencyDataSet.Hotel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practiceDataSet.register". При необходимости она может быть перемещена или удалена.
            //this.registerTableAdapter.Fill(this.practiceDataSet.register);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
