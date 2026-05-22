using FinalProjectBonSucre.DBAccess;
using FinalProjectBonSucre.Models;

namespace FinalProjectBonSucre
{

    /// <summary>
    /// The main form of the application. This form allows users to select a customer and a dessert, enter a review score,
    /// and submit that review to the database. It also loads the list of customers and desserts from the database
    /// when the form is initialized.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDessertDropdown();
            LoadCustomerDropdown();
        }

        /// <summary>
        /// This method loads the list of desserts from the database and binds it to the cmbDessert ComboBox.
        /// </summary>
        private void LoadDessertDropdown()
        {
            try
            {
                // 1. Get the list of desserts from the database
                List<Dessert> availableDesserts = DessertDB.GetAllDesserts();

                // 2. Bind the list to the ComboBox
                cmbDessert.DataSource = availableDesserts;

                // 3. Tell the ComboBox to show the Name property of the Dessert objects
                cmbDessert.DisplayMember = "Name";

                // 4. Tell the ComboBox to store the DessertId property in the background (for later retrieval)
                cmbDessert.ValueMember = "DessertId";

                // 5. Optionally, you can set the selected index to -1 to start with no selection
                cmbDessert.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading desserts: " + ex.Message, "Database Error");
            }
        }

        /// <summary>
        /// This method loads the list of customers from the database and binds it to the cmbCustomer ComboBox.
        /// </summary>
        private void LoadCustomerDropdown()
        {
            try
            {
                // 1. Get the list of customers from the database
                List<Customer> availableCustomers = CustomerDB.GetAllCustomers();

                // 2. Bind the list to the ComboBox
                cmbCustomer.DataSource = availableCustomers;

                // 3. Tell the ComboBox to show the Name property of the Customer objects
                cmbCustomer.DisplayMember = "Name";

                // 4. Tell the ComboBox to store the CustomerId property in the background (for later retrieval)
                cmbCustomer.ValueMember = "CustomerId";

                // 5. Optionally, you can set the selected index to -1 to start with no selection
                cmbCustomer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Database Error");
            }
        }

        /// <summary>
        /// Click event handler for the "Add Review" button. Validates user input, constructs a Review object, and sends it to the database.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddReview_Click(object sender, EventArgs e)
        {
            // Validate that both a customer and a dessert have been selected
            if (cmbCustomer.SelectedIndex == -1 || cmbDessert.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a customer and a dessert.", "Input Error");
                return;
            }

            // Validate score input
            if (!int.TryParse(txtScore.Text, out int score) || score < 1 || score > 5)
            {
                MessageBox.Show("Please enter a valid score between 1 and 5.", "Input Error");
                return;
            }

            // Build the Review object
            Review newReview = new Review
            {
                CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                DessertId = Convert.ToInt32(cmbDessert.SelectedValue),
                Score = score,
            };

            // Send the Review object to the database
            try
            {
                ReviewDB.AddReview(newReview);

                MessageBox.Show("Review added successfully.", "Success");

                // Clear the form so its ready for the next review
                cmbCustomer.SelectedIndex = -1;
                cmbDessert.SelectedIndex = -1;
                txtScore.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding review: " + ex.Message, "Database Error");
            }

        }

        /// <summary>
        /// Click Event Handler for the "Add New Customer" button. Opens the AddCustomerForm
        /// as a dialog, and then reloads the customer dropdown to reflect any new customers 
        /// that may have been added.
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddNewCustomerForm_Click(object sender, EventArgs e)
        {
            AddCustomerForm customerForm = new AddCustomerForm();

            customerForm.ShowDialog();

            LoadCustomerDropdown();
        }

        /// <summary>
        /// The Click Event Handler for the "Add New Dessert" button. Opens the AddDessertForm
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnAddNewDessertForm_Click(object sender, EventArgs e)
        {
            AddDessertForm dessertForm = new AddDessertForm();

            dessertForm.ShowDialog();

            LoadDessertDropdown();
        }
    }
}
