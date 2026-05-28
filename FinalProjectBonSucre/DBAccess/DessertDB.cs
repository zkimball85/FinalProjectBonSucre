using FinalProjectBonSucre.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.DBAccess
{
    public static class DessertDB
    {
        // Required methods
        /// <summary>
        /// Method to add a new dessert to the database.
        /// </summary>
        /// <param name="dessert">The dessert object to be added</param>
        public static void AddDessert(Dessert dessert)
        {
            // Implementation to add a dessert to the database
            string query = "INSERT INTO Desserts (Name, Price, Category) Values (@Name, @Price, @Category)";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", dessert.Name);
                cmd.Parameters.AddWithValue("@Price", dessert.Price);
                cmd.Parameters.AddWithValue("@Category", dessert.Category);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Method to retrieve all desserts from the database.
        /// </summary>
        /// <returns>A list of all desserts</returns>
        public static List<Dessert> GetAllDesserts()
        {
            // Implementation to retrieve all desserts from the database
            List<Dessert> desserts = new List<Dessert>();

            string query = "SELECT DessertId, Name, Price, Category FROM Desserts";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dessert d = new Dessert
                        {
                            DessertId = Convert.ToInt32(reader["DessertId"]),
                            Name = Convert.ToString(reader["Name"]),
                            Price = Convert.ToDouble(reader["Price"]),
                            Category = Convert.ToString(reader["Category"])
                        };

                        desserts.Add(d);
                    }
                }
            }
            return desserts;
        }

        // EC Methods
        /// <summary>
        /// Method to update an existing dessert's information in the database.
        /// </summary>
        /// <param name="dessert">The dessert object with updated information</param>
        /// <returns>True if the update was successful, false otherwise</returns>
        public static bool UpdateDessert(Dessert dessert)
        {
            // Implementation to update a dessert's information in the database
            string query = "UPDATE Desserts SET Name = @Name, Price = @Price, Category = @Category WHERE DessertId = @DessertId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", dessert.Name);
                cmd.Parameters.AddWithValue("@Price", dessert.Price);
                cmd.Parameters.AddWithValue("@Category", dessert.Category);
                cmd.Parameters.AddWithValue("@DessertId", dessert.DessertId);

                conn.Open();
                
                int rowsAffected = cmd.ExecuteNonQuery();

                // Return true if the update was successful
                return rowsAffected > 0; 
            }
        }

        /// <summary>
        /// Method to delete a dessert from the database using its ID.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert to be deleted</param>
        /// <returns>True if the delete was successful, false otherwise</returns>
        public static bool DeleteDessert(int dessertId)
        {
            // Implementation to delete a dessert from the database using its ID
            string query = @"DELETE FROM Reviews WHERE DessertId = @DessertId;
                             DELETE FROM Desserts WHERE DessertId = @DessertId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DessertId", dessertId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Return true if the delete was successful
                return rowsAffected > 0; 
            }
        }

        /// <summary>
        /// This method retrieves a dessert from the database using its ID. It returns the dessert object if found, or null if not found.
        /// </summary>
        /// <param name="dessertId">The ID of the dessert to retrieve.</param>
        /// <returns>The dessert object if found, or null if not found.</returns>
        public static Dessert GetDessertById(int dessertId)
        {
            Dessert foundDessert = null; 

            string query = "SELECT DessertId, Name, Price, Category FROM Desserts WHERE DessertId = @DessertId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DessertId", dessertId);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        foundDessert = new Dessert
                        {
                            DessertId = Convert.ToInt32(reader["DessertId"]),
                            Name = Convert.ToString(reader["Name"]),
                            Price = Convert.ToDouble(reader["Price"]),
                            Category = Convert.ToString(reader["Category"])
                        };
                    }
                }
            }
            return foundDessert;
        }
    }
}

