using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.DBAccess
{
    public static class DessertDB
    {
        // Required methods
        public static void AddDessert(DessertDB dessert)
        {
            // Implementation to add a dessert to the database
        }

        public static List<Dessert> GetAllDesserts()
        {
            // Implementation to retrieve all desserts from the database
            return new List<Dessert>();
        }

        // EC Methods
        public static void UpdateDessert(Dessert dessert)
        {
            // Implementation to update a dessert's information in the database
        }

        public static void DeleteDessert(int dessertId)
        {
            // Implementation to delete a dessert from the database using its ID
        }
    }
}
