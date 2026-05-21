using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.DBAccess
{
    public static class ReviewDB
    {
        // Required method
        public static void AddReview(Review review)
        {
            // Implementation to add a review to the database
        }

        // EC Method
        public static List<ReviewDisplayItem> GetReviewsByDessert(int dessertId)
        {
            // Implementation to retrieve reviews for a specific dessert from the database
            return new List<ReviewDisplayItem>();
        }
    }

    public class ReviewDisplayItem
    {
        public string CustomerName { get; set; }
        public string DessertName { get; set; }
        public double DessertPrice { get; set; }
        public int Score { get; set; }
    }
}
