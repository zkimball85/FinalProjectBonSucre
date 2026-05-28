using FinalProjectBonSucre.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            _dessertReviews = [];

            // 1. Fetch the reviews from the database for the selected dessert
            string connectionString = "Data Source = ZACS_WINDOWS; Initial Catalog = BonSucre; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False; Command Timeout = 30";

            using (SqlConnection conn = new(connectionString))
            {
                string query = 
                    @"SELECT 
                            r.ReviewId,
                            r.CustomerId,
                            r.DessertId,
                            r.Score,
                            c.Name AS CustomerName 
                        FROM Reviews r 
                        JOIN Customers c ON r.CustomerId = c.CustomerId 
                        WHERE r.DessertId = @DessertId, 
                        INSERT INTO Reviews (CustomerId, DessertId, Score, date) 
                        VALUES (@CustomerId, @DessertId, @Score, GETDATE())";

                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@DessertId", _selectedDessert.DessertId);
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Review currentReview = new()
                    {
                        ReviewId = Convert.ToInt32(reader["ReviewId"]),
                        CustomerId = Convert.ToInt32(reader["CustomerId"]),
                        DessertId = Convert.ToInt32(reader["DessertId"]),
                        Score = Convert.ToInt32(reader["Score"]),
                        CustomerName = reader["CustomerName"].ToString()
                    };

                    _dessertReviews.Add(currentReview);

                }
            }
            // Bind the manually built list to the ListBox
            lstReviews.DataSource = null;
            lstReviews.DataSource = _dessertReviews;
            lstReviews.DisplayMember = "CustomerName";

        }
    }
}
