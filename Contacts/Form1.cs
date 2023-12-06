using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List version 1.0\n Written by: Aman Bhaskar", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }

        private void contact_No_Label_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_CallLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_No_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void last_CallDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
