using FinalProjectBonSucre.DBAccess;
using FinalProjectBonSucre.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectBonSucre
{
    public partial class ReviewForm : Form
    {
        private readonly Dessert _selectedDessert;
        private List<Review> _dessertReviews;
        public ReviewForm(Dessert dessertToReview)
        {
            InitializeComponent();
            _selectedDessert = dessertToReview;
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            try
            { 
                // This completely eliminates the need for raw SQL or connection strings in this form.
                List<ReviewDisplayItem> dessertReviews = ReviewDB.GetReviewsByDessert(_selectedDessert.DessertId);

                // Bind the data to the ListBox
                lstReviews.DataSource = null;
                lstReviews.DataSource = dessertReviews;

                // Tell the ListBox to display the customer's name
                lstReviews.DisplayMember = "FullReviewText";
            }
            catch (Exception ex)
            {
                // Always protect the load event from database crashes!
                MessageBox.Show("Error loading reviews: " + ex.Message, "Database Error");
            }
        }
    }
}
