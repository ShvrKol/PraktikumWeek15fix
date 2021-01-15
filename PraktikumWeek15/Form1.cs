using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Subtotal = "";


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxfnb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxfnb.SelectedItem.ToString() == "Ayam Bakar")
            {
                labelprc.Text = "15000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng")
            {
                labelprc.Text = "10000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng Special")
            {
                labelprc.Text = "12000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng Pete")
            {
                labelprc.Text = "15000";
            }
            radioButtonjumbo_CheckedChanged(sender, e);
            radioButtonnormal_CheckedChanged(sender, e);
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            if (listBoxfnb.Items.Count == 0) 
            {
                MessageBox.Show("Please Choose Menu!");
            }
            else
            {
                var formbaru = new Form2();
                formbaru.ShowDialog();
            }         
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            listBoxprice.Items.RemoveAt(listBoxfnb.SelectedIndex);
            listBoxfnb.Items.RemoveAt(listBoxfnb.SelectedIndex);
            Deletebutton();
        }

        private void Deletebutton()
        {
            if (listBoxfnb.Items.Count == 0)
            {
                buttondelete.Enabled = false;
            }
            else
            {
                buttondelete.Enabled = true;
            }
        }

        private void radioButtonBev_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBev.Checked == true)
            {
                comboBoxfnb.Items.Add("Es Teh");
                comboBoxfnb.Items.Add("Teh Hangat");
                comboBoxfnb.Items.Add("Nutrisari");
                comboBoxfnb.Items.Add("Aqua");
                panelbev.Visible = panelbev.Enabled;
            }
            else
            {
                comboBoxfnb.Items.Clear();
                panelbev.Hide();
            }
        }

        private void radioButtonfood_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonfood.Checked == true)
            {
                comboBoxfnb.Items.Add("Nasi Goreng");
                comboBoxfnb.Items.Add("Nasi Goreng Special");
                comboBoxfnb.Items.Add("Nasi Goreng Pete");
                comboBoxfnb.Items.Add("Ayam Bakar");             
            }
            else
            {
                comboBoxfnb.Items.Clear();
            }
        }

        private void radioButtonnormal_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxfnb.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true)
            {
                labelprc.Text = "5000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true)
            {
                labelprc.Text = "3000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true)
            {
                labelprc.Text = "6000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true)
            {
                labelprc.Text = "2000";
            }
        }

        private void radioButtonjumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxfnb.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true)
            {
                labelprc.Text = "7000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true)
            {
                labelprc.Text = "5000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true)
            {
                labelprc.Text = "10000";
            }
            if (comboBoxfnb.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true)
            {
                labelprc.Text = "5000";
            }
        }

        private void buttonbuy_Click(object sender, EventArgs e)
        {
            listBoxfnb.Items.Add(comboBoxfnb.SelectedItem);
            if (comboBoxfnb.SelectedItem.ToString() == "Ayam Bakar") listBoxprice.Items.Add(15000);
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng") listBoxprice.Items.Add(10000);
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng Special") listBoxprice.Items.Add(12000);
            if (comboBoxfnb.SelectedItem.ToString() == "Nasi Goreng Pete") listBoxprice.Items.Add(15000);
            if (comboBoxfnb.SelectedItem.ToString() == "Es Teh" && radioButtonjumbo.Checked == true) listBoxprice.Items.Add(7000);
            if (comboBoxfnb.SelectedItem.ToString() == "Teh Hangat" && radioButtonjumbo.Checked == true) listBoxprice.Items.Add(5000);
            if (comboBoxfnb.SelectedItem.ToString() == "Nutrisari" && radioButtonjumbo.Checked == true) listBoxprice.Items.Add(10000);
            if (comboBoxfnb.SelectedItem.ToString() == "Aqua" && radioButtonjumbo.Checked == true) listBoxprice.Items.Add(5000);
            if (comboBoxfnb.SelectedItem.ToString() == "Es Teh" && radioButtonnormal.Checked == true) listBoxprice.Items.Add(5000);
            if (comboBoxfnb.SelectedItem.ToString() == "Teh Hangat" && radioButtonnormal.Checked == true) listBoxprice.Items.Add(3000);
            if (comboBoxfnb.SelectedItem.ToString() == "Nutrisari" && radioButtonnormal.Checked == true) listBoxprice.Items.Add(6000);
            if (comboBoxfnb.SelectedItem.ToString() == "Aqua" && radioButtonnormal.Checked == true) listBoxprice.Items.Add(2000);
            Subtotal = listBoxprice.Items.ToString();
            Deletebutton();
        }
    }
}
