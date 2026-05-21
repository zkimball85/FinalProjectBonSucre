using FinalProjectBonSucre.Models;
using Microsoft.Data.SqlClient;

namespace FinalProjectBonSucre.DBAccess
{
    public static class CustomerDB
    {
        // Required methods
        /// <summary>
        /// Method to add a new customer to the database. 
        /// </summary>
        /// <param name="customer">The customer object to be added</param>
        public static void AddCustomer(Customer customer)
        {
            // Implementation to add a customer to the database
            string query = "INSERT INTO Customers (Name, Email, DateOfBirth) Values (@Name, @Email, @DateOfBirth)";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Method to retrieve all customers from the database and return them as a list of Customer objects.
        /// </summary>
        /// <returns>List of Customer objects</returns>
        public static List<Customer> GetAllCustomers()
        {
            // Implementation to retrieve all customers from the database
            List<Customer> customers = new List<Customer>();
            string query = "SELECT CustomerId, Name, Email, DateOfBirth FROM Customers";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer();
                        c.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                        c.Name = Convert.ToString(reader["Name"]);
                        c.Email = Convert.ToString(reader["Email"]);
                        c.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                        customers.Add(c);
                    }
                }
            }
            return customers;
        }

        // EC Methods
        /// <summary>
        /// Method to update a customer's information in the database. 
        /// </summary>
        /// <param name="customer">The customer object containing updated information</param>
        public static void UpdateCustomer(Customer customer)
        {
            // Implementation to update a customer's information in the database
            string query = "UPDATE Customers SET Name = @Name, Email = @Email, DateOfBirth = @DateOfBirth WHERE CustomerId = @CustomerId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("DateOfBirth", customer.DateOfBirth);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Method to delete a customer from the database using their ID.
        /// </summary>
        /// <param name="customerId">The ID of the customer to delete</param>
        public static void DeleteCustomer(int customerId)
        {
            // Implementation to delete a customer from the database using their ID
            string query = "DELETE FROM Customers WHERE CustomerId = @CustomerId";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
