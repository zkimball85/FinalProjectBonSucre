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
    public partial class UpdateDessertForm : Form
    {

        private readonly int _dessertIdToUpdate;



        public UpdateDessertForm(int dessertId)
        {
            InitializeComponent();

            _dessertIdToUpdate = dessertId;

            PopulateCategories();

            LoadDessertData();
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Cake");
            cmbCategory.Items.Add("Cookie");
            cmbCategory.Items.Add("Pastry");
            cmbCategory.Items.Add("Ice Cream");
            cmbCategory.Items.Add("Pie");
        }

        private void LoadDessertData()
        {
            // Implement SQL SELECT query here to get the dessert data based on _dessertIdToUpdate
            // Then pre-fill the text boxes with the retrieved data
            try
            {
                Dessert existingDessert = DessertDB.GetDessertById(_dessertIdToUpdate);

                if (existingDessert != null)
                {
                    // Pre-fill the form fields
                    txtName.Text = existingDessert.Name;
                    txtPrice.Text = existingDessert.Price.ToString();
                    cmbCategory.SelectedItem = existingDessert.Category;
                }
                else
                {
                    MessageBox.Show("Dessert not found. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading dessert data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void BtnUpdateDessert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid numerical price.", "Validation Error");
                return;
            }

            // Safely grab the category string
            string selectedCategory = cmbCategory.SelectedIndex != -1 ? cmbCategory.SelectedItem.ToString() : "";

            // Build the dessert object
            Dessert updateDessert = new()
            {
                DessertId = _dessertIdToUpdate,
                Name = txtName.Text,
                Price = price,
                Category = selectedCategory
            };

            if (!updateDessert.IsValid(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error");
                return;
            }

            try
            {
                DessertDB.UpdateDessert(updateDessert);
                MessageBox.Show("Dessert updated successfully!", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the dessert: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
