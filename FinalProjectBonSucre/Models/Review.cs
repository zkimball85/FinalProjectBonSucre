
namespace FinalProjectBonSucre.Models
{

    /// <summary>
    /// The Review class represents a customer's review of a dessert. 
    /// It contains properties for the review ID, customer ID, dessert ID,
    /// and the score given by the customer. The CustomerName property is 
    /// used for display purposes in the ListBox when showing reviews. 
    /// The IsValid method is included to validate the review data before 
    /// it is saved to the database, ensuring that a valid customer and 
    /// dessert are selected and that the score is between 1 and 5.
    /// </summary>
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerId { get; set; }
        public int DessertId { get; set; }
        public int Score { get; set; }

        public string? CustomerName { get; set; } // This property is used for display purposes in the ListBox

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
