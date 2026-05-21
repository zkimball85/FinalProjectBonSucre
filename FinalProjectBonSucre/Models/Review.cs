using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public int DessertId { get; set; }
        public int Score { get; set; }

        // EC Validation: Ensure score is between 1 and 5
        public bool IsValid(out string errorMessage)
        {
            errorMessage = "";
            if (CustomerId <= 0) errorMessage += "A valid customer must be selected. \n";
            if (DessertId <= 0) errorMessage += "A valid dessert must be selected. \n";
            if (Score < 1 || Score > 5) errorMessage += "Score must be between 1 and 5. \n";

            return string.IsNullOrEmpty(errorMessage);
        }
    }
}
