using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBform
{
    public partial class DBformMain : Form
    {
        public DBformMain()
        {
            InitializeComponent();
        }

        private void DBformMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void ChTabButton_Click(object sender, EventArgs e)
        {
            SelectionTablice openForm = new SelectionTablice();
            openForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm sbb = new LoginForm();
            sbb.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm nf = new RegistrationForm();
            nf.Show();
            this.Hide();
        }
    }
}
