using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBform
{
    public partial class Recordings : Form
    {

        private OleDbConnection connection = new OleDbConnection();

        public Recordings()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\1\source\repos\DBform\PrefektDB.accdb";
        }



        private void Recordings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iBLDatSet.Recs". При необходимости она может быть перемещена или удалена.
            this.recsTableAdapter.Fill(this.iBLDatSet.Recs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prefektDBDataSet.Записи". При необходимости она может быть перемещена или удалена.
            //this.записиTableAdapter.Fill(this.prefektDBDataSet.Записи);
            StatusLabel.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBformMain wsd = new DBformMain();
            wsd.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectionTablice qwe = new SelectionTablice();
            qwe.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            StatusLabel.Text = "Строка удалена";
            StatusLabel.ForeColor = Color.PaleVioletRed;
            StatusLabel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записиBindingSource.EndEdit();
            this.записиTableAdapter.Update(this.prefektDBDataSet.Записи);
            StatusLabel.Text = "Изменения сохранены";
            StatusLabel.ForeColor = Color.GreenYellow;
            StatusLabel.Visible = true;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
         //   command.CommandText = command.CommandText = string.Format(@"UPDATE Записи");
            
            connection.Close();


        }


    }
}
