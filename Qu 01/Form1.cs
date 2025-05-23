using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Contact_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Check if fields are empty
            if (name == "" || phone == "")
            {
                MessageBox.Show("Please enter both Name and Phone Number.", "Input Error");
                return;
            }

            // Check if phone number is exactly 10 digits
            long number;
            if (phone.Length != 10 || !long.TryParse(phone, out number))
            {
                MessageBox.Show("Phone number must be exactly 10 digits and contain only numbers.", "Phone Number Error");
                return;
            }

            lstDisplay.Items.Add(name + " - " + phone);
            txtName.Clear();
            txtPhone.Clear();
        }
    }
}

