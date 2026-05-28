using FinalProjectBonSucre.DBAccess;
using FinalProjectBonSucre.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectBonSucre
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handles the click event for the "Save Customer" button.
        /// It performs validation on the input fields to ensure that all required
        /// information is provided and valid before attempting to save the new 
        /// customer to the database. If validation passes, it creates a new 
        /// Customer object, populates it with the input data, and calls the 
        /// AddCustomer method from the CustomerDB class to save it.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            // EC Validation: Ensure all fields are filled out and valid before attempting to save
            if (!DateTime.TryParse(txtDateOfBirth.Text, out DateTime dateOfBirth))
            {
                MessageBox.Show("Please enter a valid date of birth (e.g., MM/DD/YYYY).", "Validation Error");
                return;
            }

            Customer newCustomer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                DateOfBirth = dateOfBirth
            };

            if (!newCustomer.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error");
                return;
            }

            try
            {
                CustomerDB.AddCustomer(newCustomer);
                MessageBox.Show("Customer added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message, "Database Error");
            }
        }
    }
}
