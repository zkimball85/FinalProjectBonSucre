using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectBonSucre.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        // EC Validation: Ensure email is in correct format
        public bool IsValid(out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrWhiteSpace(Name)) errorMessage += "Name cannot be empty. \n";
            if (string.IsNullOrWhiteSpace(Email)) errorMessage += "Email cannot be empty. \n";
            else if (!Email.Contains("@") || !Email.Contains(".")) errorMessage += "Email must be in a valid format. \n";
            if (DateOfBirth >= DateTime.Now) errorMessage += "Date of Birth must be in the past. \n";

            return string.IsNullOrEmpty(errorMessage);
        }
    }
}
