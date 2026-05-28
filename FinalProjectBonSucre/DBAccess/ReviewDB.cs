using FinalProjectBonSucre.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.DBAccess
{
    public static class ReviewDB
    {
        // Required method
        /// <summary>
        /// Method to add a review to the database.
        /// </summary>
        /// <param name="review">The review to add.</param>
        public static void AddReview(Review review)
        {
            // Implementation to add a review to the database
            string query = "INSERT INTO Reviews (CustomerId, DessertId, Score, Date) Values (@CustomerId, @DessertId, @Score, GETDATE())";

            using SqlConnection conn = DBConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@CustomerId", review.CustomerId);
            cmd.Parameters.AddWithValue("@DessertId", review.DessertId);
            cmd.Parameters.AddWithValue("@Score", review.Score);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // EC Method
        /// <summary>
        /// Method to retrieve reviews for a specific dessert, including customer name, dessert name, price, and score.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert for which to retrieve reviews.</param>
        /// <returns>A list of review display items.</returns>
        public static List<ReviewDisplayItem> GetReviewsByDessert(int dessertId)
        {
            // Implementation to retrieve reviews for a specific dessert from the database
            List<ReviewDisplayItem> displayItems = new List<ReviewDisplayItem>();

            // INNER JOIN query to get customer name, dessert name, price, and score
            string query = @"
                SELECT      c.Name          AS CustomerName, d.Name AS DessertName, d.Price AS DessertPrice, r.Score
                FROM        Reviews r
                INNER JOIN  Customers c     ON r.CustomerId = c.Id
                INNER JOIN  Desserts d      ON r.DessertId = d.Id
                WHERE       r.DessertId = @DessertId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DessertId", dessertId);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                { 
                    while (reader.Read())
                    {
                        ReviewDisplayItem item = new ReviewDisplayItem();
                        item.CustomerName = Convert.ToString(reader["CustomerName"]);
                        item.DessertName = Convert.ToString(reader["DessertName"]);
                        item.DessertPrice = Convert.ToDouble(reader["DessertPrice"]);
                        item.Score = Convert.ToInt32(reader["Score"]);

                        displayItems.Add(item);
                    }
                }
            }
            return displayItems;
        }
    }

    /// <summary>
    /// Method to represent a review display item, which includes customer name, dessert name, price, and score. This is used for displaying reviews in the UI.
    /// </summary>
    public class ReviewDisplayItem
    {
        public string CustomerName { get; set; }
        public string DessertName { get; set; }
        public double DessertPrice { get; set; }
        public int Score { get; set; }
    }
}
