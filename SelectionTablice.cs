using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBform;


namespace DBform
{
    public partial class SelectionTablice : Form
    {
        public SelectionTablice()
        {
            InitializeComponent();
        }

        private void SelectionTablice_Load(object sender, EventArgs e)
        {

        }

        private void ChPaymentsTab_Click(object sender, EventArgs e)
        {
            PaymentsForm wesad = new PaymentsForm();
            this.Hide(); wesad.Show();
        }

        private void ChAdditionalInfTab_Click(object sender, EventArgs e)
        {
            AdditionalInfo openForm = new AdditionalInfo();
            openForm.Show();
            this.Hide();
        }

        private void ChRecordingsTab_Click(object sender, EventArgs e)
        {
            Recordings sad = new Recordings();
            this.Hide(); sad.Show();
        }

        private void ChPersDataTab_Click(object sender, EventArgs e)
        {
            PersonalData wed = new PersonalData();
            this.Hide(); wed.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DBformMain op = new DBformMain();
            this.Hide(); op.Show();
        }

        private void AplClosingButton_Click(object sender, EventArgs e)
        {
            this.Close(); Dispose();
        }

        private void ChangeDataLogButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RDGVButton_Click(object sender, EventArgs e)
        {

        }
    }
}
