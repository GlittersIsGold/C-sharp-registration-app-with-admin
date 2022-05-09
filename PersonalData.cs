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
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        private void PersonalData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iBLDatSet.PersData". При необходимости она может быть перемещена или удалена.
            this.persDataTableAdapter.Fill(this.iBLDatSet.PersData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prefektDBDataSet.Личные_данные". При необходимости она может быть перемещена или удалена.
          //  this.личные_данныеTableAdapter.Fill(this.prefektDBDataSet.Личные_данные);
            StatusLabel.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.личныеДанныеBindingSource.EndEdit();
            this.личные_данныеTableAdapter.Update(this.prefektDBDataSet.Личные_данные);
            StatusLabel.Text = "Изменения сохранены";
            StatusLabel.ForeColor = Color.GreenYellow;
            StatusLabel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            StatusLabel.Text = "Строка удалена";
            StatusLabel.ForeColor = Color.PaleVioletRed;
            StatusLabel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectionTablice asdg = new SelectionTablice();
            this.Hide(); asdg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBformMain op = new DBformMain();
            this.Hide(); op.Show();
        }
    }
}
