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
    public partial class UpdateCustomerForm : Form
    {
        private readonly int _customerIdToUpdate;

        /// <summary>
        /// This constructor initializes the UpdateCustomerForm with the ID of the customer to be updated.
        /// </summary>
        /// <param name="selectedCustomerId">The ID of the customer to be updated.</param>
        public UpdateCustomerForm(int selectedCustomerId)
        {
            InitializeComponent();
            _customerIdToUpdate = selectedCustomerId;

            PreFillCustomerData();
        }

        /// <summary>
        /// This method retrieves the existing customer data based on the provided customer ID
        /// and pre-fills the form fields with that data. It uses the GetCustomerById method 
        /// from the CustomerDB class to fetch the customer details and populates the text boxes
        /// accordingly. If the customer is not found or if an error occurs during data retrieval,
        /// it displays an appropriate error message and closes the form.
        /// </summary>
        private void PreFillCustomerData()
        {
            try
            {
                // get the specific customer using the method we just built!
                Customer existingCustomer = CustomerDB.GetCustomerById(_customerIdToUpdate);

                if (existingCustomer != null)
                {
                    // pre-fill the form fields with the existing customer data
                    txtName.Text = existingCustomer.Name;
                    txtEmail.Text = existingCustomer.Email;
                    txtDateOfBirth.Text = existingCustomer.DateOfBirth.ToShortDateString();

                }
                else
                {
                    MessageBox.Show("Customer not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// This event handler is triggered when the "Update Customer" button is clicked.
        /// It performs validation on the input fields (Name, Email, and Date of Birth) 
        /// to ensure they are not empty and that the email is in a valid format. If the 
        /// validation passes, it creates a new Customer object with the updated information 
        /// and calls the UpdateCustomer method from the CustomerDB class to save the changes 
        /// to the database. If any errors occur during this process, it displays an appropriate 
        /// error message to the user. Finally, if the update is successful, it closes the form.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtDateOfBirth.Text, out DateTime parsedDob))
            {
                MessageBox.Show("Please enter a valid date of birth.", "Validation Error");
                return;
            }

            // Build the updated customer object right away
            Customer updatedCustomer = new()
            {
                CustomerId = _customerIdToUpdate, 
                Name = txtName.Text,
                Email = txtEmail.Text,
                DateOfBirth = parsedDob
            };

            if (!updatedCustomer.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error");
                return;
            }

            try
            {
                CustomerDB.UpdateCustomer(updatedCustomer);
                MessageBox.Show("Customer updated successfully!", "Success");
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred while updating the customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
