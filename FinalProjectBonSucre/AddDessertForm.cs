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
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Dessert name cannot be empty.", "Validation Error");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid non-negative price.", "Validation Error");
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error");
                return;
            }

            try
            {
                Dessert newDessert = new Dessert
                {
                    Name = txtName.Text,
                    Price = price,
                    Category = cmbCategory.SelectedItem.ToString()
                };

                DessertDB.AddDessert(newDessert);

                MessageBox.Show("Dessert added successfully.", "Success");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding dessert: " + ex.Message);
            }
        }
    }
}
