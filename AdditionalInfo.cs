using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBform;

namespace DBform
{
    public partial class AdditionalInfo : Form 
    {
        public static string ConnectStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = PrefektDB.accdb";
        private OleDbConnection Cor;

        public AdditionalInfo()
        {
            InitializeComponent();
            Cor = new OleDbConnection(ConnectStr);
            Cor.Open();
        }

        private void AdditionalInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iBLDatSet.AdditInf". При необходимости она может быть перемещена или удалена.
            this.additInfTableAdapter.Fill(this.iBLDatSet.AdditInf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prefektDBDataSet.Дополнительные_сведения". При необходимости она может быть перемещена или удалена.
            // this.дополнительные_сведенияTableAdapter.Fill(this.prefektDBDataSet.Дополнительные_сведения);


            StatusLabel.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дополнительныеСведенияBindingSource.EndEdit();
            this.дополнительные_сведенияTableAdapter.Update(this.prefektDBDataSet.Дополнительные_сведения);
            
            StatusLabel.Text = "Изменения сохранены";
            StatusLabel.ForeColor = Color.GreenYellow;
            StatusLabel.Visible = true;



        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void RmButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            StatusLabel.Text = "Строка удалена";
            StatusLabel.ForeColor = Color.PaleVioletRed;
            StatusLabel.Visible = true;

            string queryDrop = "DELETE FROM AdditInf";
            OleDbCommand cmdDrop = new OleDbCommand(queryDrop, Cor);
            cmdDrop.ExecuteNonQuery();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DBformMain nwe = new DBformMain();
            nwe.Show(); this.Hide();
        }

        private void ChTabliceButton_Click(object sender, EventArgs e)
        {
            SelectionTablice neform = new SelectionTablice();
            neform.Show();
            this.Hide();
        }

        private void AdditionalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cor.Close();
        }
    }
}
