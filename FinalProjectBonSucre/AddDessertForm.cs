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

        private void btnSaveDessert_Click(object sender, EventArgs e)
        {
            try
            {
                Dessert newDessert = new Dessert
                {
                    Name = txtName.Text,
                    Price = Convert.ToDouble(txtPrice.Text),
                    Category = Convert.ToString(cmbCategory.SelectedItem)
                };

                DessertDB.AddDessert(newDessert);

                MessageBox.Show("Dessert added successfully!");

                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error adding dessert. Please check your input and try again.");
            }
        }
    }
}
