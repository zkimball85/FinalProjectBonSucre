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
    public partial class AddDessertForm : Form
    {
        public AddDessertForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event handler is triggered when the "Save" button is clicked.
        /// It performs validation on the input fields, creates a new Dessert object,
        /// and attempts to save it to the database using the DessertDB class.
        /// If successful, it shows a success message and closes the form;
        /// if there's an error, it displays an error message.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnSaveDessert_Click(object sender, EventArgs e)
        {
            // EC Validation: Ensure all fields are filled out and valid before attempting to save
            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid numerical price.", "Validation Error");
                return;
            }

            // Safely grab the category text (if nothing is selected, pass a blank string)
            string selectedCategory = cmbCategory.SelectedIndex != -1 ? cmbCategory.SelectedItem.ToString() : "";

            // Build the new dessert object
            Dessert newDessert = new Dessert
            {
                Name = txtName.Text,
                Price = price,
                Category = selectedCategory
            };

            if (!newDessert.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error");
                return;
            }

            // If it makes it here, the data is perfect. Save it to the database
            try
            {
                DessertDB.AddDessert(newDessert);
                MessageBox.Show("Dessert added successfully.", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding dessert: " + ex.Message, "Database Error");
            }
        }
    }
}
