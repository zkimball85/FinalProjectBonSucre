namespace FinalProjectBonSucre.DBAccess
{
    public static class CustomerDB
    {
        // Required methods
        public static void AddCustomer(CustomerDB customer)
        {
            // Implementation to add a customer to the database
        }

        public static List<Customer> GetAllCustomers()
        {
            // Implementation to retrieve all customers from the database
            return new List<Customer>();
        }

        // EC Methods
        public static void UpdateCustomer(Customer customer)
        {
            // Implementation to update a customer's information in the database
        }

        public static void DeleteCustomer(int customerId)
        {
            // Implementation to delete a customer from the database using their ID
        }
    }
}
