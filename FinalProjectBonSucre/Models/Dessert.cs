using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.Models
{
    public class Dessert
    {
        public int DessertId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        // EC Validation: Ensure dessert has a name, price > 0, and category is not empty
        public bool IsValid(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(Name)) errorMessage += "Dessert name cannot be empty. \n";
            if (Price <= 0) errorMessage += "Price must be greater than zero. \n";
            if (string.IsNullOrWhiteSpace(Category)) errorMessage += "Category cannot be empty. \n";

            return string.IsNullOrEmpty(errorMessage);
        }
    }
}
