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

        private int _dessertIdToUpdate;



        public UpdateDessertForm(int dessertId)
        {
            InitializeComponent();

            _dessertIdToUpdate = dessertId;
        }

        // TODO: Add method that uses _dessertIdToUpdate to do a SQL SELECT query and pre-fill the text boxes so the user sees the old data
        public void LoadDessertData()
        {
            // Implement SQL SELECT query here to get the dessert data based on _dessertIdToUpdate
            // Then pre-fill the text boxes with the retrieved data
            string query = "SELECT Name, Price, Category FROM Desserts WHERE Id = @DessertId";


        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateDessert_Click(object sender, EventArgs e)
        {
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
            try
            {
                Dessert updateDessert = new Dessert
                {
                    DessertId = _dessertIdToUpdate,
                    Name = txtName.Text,
                    Price = price,
                    Category = cmbCategory.SelectedItem.ToString()
                };

                DessertDB.UpdateDessert(updateDessert);

                MessageBox.Show("Dessert updated successfully!", "Success");

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred while updating the dessert.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
