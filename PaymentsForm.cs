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
    public partial class PaymentsForm : Form
    {
        public static string ConnectStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = PrefektDB.accdb";
        private OleDbConnection Cor;

        public PaymentsForm()
        {
            InitializeComponent();
            Cor = new OleDbConnection(ConnectStr);
            Cor.Open();
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iBLDatSet.Payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.iBLDatSet.Payments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prefektDBDataSet.Выплаты". При необходимости она может быть перемещена или удалена.
           // this.выплатыTableAdapter.Fill(this.prefektDBDataSet.Выплаты);
          //  StatusLabel.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.paymentsTableAdapter.Update(this.iBLDatSet.Payments);
            StatusLabel.Text = "Изменения сохранены";
            StatusLabel.ForeColor = Color.GreenYellow;
            StatusLabel.Visible = true;

            string queryAdd = "INSERT INTO Payments (Number, id, Имя, Фамилия, [Имеет детей], [Соц-выплаты], [Пенсионные выплаты], [Пенс-выплаты]) VALUES("+ numberDataGridViewTextBoxColumn + ", '"+ idDataGridViewTextBoxColumn+"', '"+имяDataGridViewTextBoxColumn+"', '"+фамилияDataGridViewTextBoxColumn+"','"+имеетДетейDataGridViewCheckBoxColumn+"','"+соцвыплатыDataGridViewTextBoxColumn+"','"+количествоДетейDataGridViewTextBoxColumn+"','"+пенсионныеВыплатыDataGridViewCheckBoxColumn+"','"+пенсвыплатыDataGridViewTextBoxColumn+"')";

          //  OleDbCommand cmdAdd = new OleDbCommand(queryAdd, Cor);
         //   cmdAdd.ExecuteNonQuery();
            
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
            DBformMain weasd = new DBformMain();
            weasd.Show();this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectionTablice wew = new SelectionTablice();
            this.Hide(); wew.Show();
        }

        private void PaymentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.выплатыTableAdapter.Fill(this.prefektDBDataSet.Выплаты);
            Cor.Close();

        }
    }
}
