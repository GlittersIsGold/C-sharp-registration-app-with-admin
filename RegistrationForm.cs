using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DBform;

namespace DBform
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxSelectionCount = 14;
            monthCalendar1.ShowToday = true;
            StatusLab.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "" || textBox2.Text =="" || textBox3.Text == "")||(textBox4.Text == "" || textBox5.Text=="" || textBox6.Text=="") 
                
                || monthCalendar1.SelectionRange.Start.ToLongDateString() == "" || (string)this.listBox1.SelectedItem == "" || checkedListBox1.Text == ""
                )
            
            {
                StatusLab.Visible = true;
                StatusLab.ForeColor = Color.DarkRed;
                StatusLab.Text = "Заполните данные";
            } 


            
            else
            {


                TotalForm asd = new TotalForm();
                asd.Show();

                asd.label12.Text = (string)this.monthCalendar1.SelectionRange.Start.ToShortDateString();
                asd.label13.Text = (string)this.listBox1.SelectedItem;
                asd.label15.Text = checkedListBox1.Text;
                asd.phoneLabel.Text = this.textBox5.Text;
                this.Hide();

                
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBformMain opd = new DBformMain();
            opd.Show(); Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
