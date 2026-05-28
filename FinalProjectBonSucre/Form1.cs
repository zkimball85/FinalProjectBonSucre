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
        private void BtnAddReview_Click(object sender, EventArgs e)
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
            Review newReview = new()
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
        private void BtnAddNewCustomerForm_Click(object sender, EventArgs e)
        {
            AddCustomerForm customerForm = new();

            customerForm.ShowDialog();

            LoadCustomerDropdown();
        }

        /// <summary>
        /// The Click Event Handler for the "Add New Dessert" button. Opens the AddDessertForm
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnAddNewDessertForm_Click(object sender, EventArgs e)
        {
            AddDessertForm dessertForm = new();

            dessertForm.ShowDialog();

            LoadDessertDropdown();
        }

        /// <summary>
        /// The Click Event handler for the "Delete Dessert" button. Validates that a dessert is selected, confirms the deletion with the user,
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnDeleteDessertForm_Click(object sender, EventArgs e)
        {
            if (cmbDessert.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a dessert from the dropdown to delete.", "No Selection");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this dessert?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int dessertIdToDelete = Convert.ToInt32(cmbDessert.SelectedValue);

                    DessertDB.DeleteDessert(dessertIdToDelete);

                    MessageBox.Show("Dessert deleted successfully.");

                    LoadDessertDropdown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting dessert: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// The Click Event handler for the "Delete Customer" button. Validates that a customer is selected, confirms the deletion with the user,
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnDeleteCustomerForm_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer from the dropdown to delete.", "No Selection");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int customerIdToDelete = Convert.ToInt32(cmbCustomer.SelectedValue);

                    CustomerDB.DeleteCustomer(customerIdToDelete);

                    MessageBox.Show("Customer deleted successfully.");

                    LoadCustomerDropdown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// The Click Event handler for the "Update Dessert" button. Validates that a dessert is selected, and then opens the UpdateDessertForm,
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnUpdateDessertForm_Click(object sender, EventArgs e)
        {
            if (cmbDessert.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a dessert from the dropdown to update.", "No Selection");
                return;
            }

            // Grab the selected dessert's ID from the ComboBox
            int selectedDessertId = Convert.ToInt32(cmbDessert.SelectedValue);

            // Open the new form and hand it the selected dessert's ID so it knows which dessert to update
            UpdateDessertForm updateForm = new(selectedDessertId);
            updateForm.ShowDialog();

            // refresh the dropdown when they finish updating
            LoadDessertDropdown();
        }

        /// <summary>
        /// The Click Event handler for the "Update Customer" button. Validates that a customer is selected, and then opens the UpdateCustomerForm. 
        /// </summary>
        /// <param name="sender">The control that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void BtnUpdateCustomerForm_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer from the dropdown to update.", "No Selection");
                return;
            }

            // Grab the Id of the selected customer from the ComboBox
            int selectedCustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);

            // Open the new form and hand it the selected customer's ID so it knows which customer to update
            UpdateCustomerForm updateForm = new(selectedCustomerId);
            updateForm.ShowDialog();

            // refresh the dropdown when they finish updating
            LoadCustomerDropdown();
        }

        private void BtnViewReviews_Click(object sender, EventArgs e)
        {
            // Check if the user actually highlighted a row in the dessert dropdown
            if (cmbDessert.SelectedIndex != -1 && cmbDessert.SelectedItem != null)
            {
                try
                {
                    Dessert selectedDessert = (Dessert)cmbDessert.SelectedItem;
                    ReviewForm reviewPage = new(selectedDessert);
                    reviewPage.ShowDialog();
                }
                catch (Exception ex)
                {
                    // Catches any database errors that happen while the ReviewForm is trying to load
                    MessageBox.Show("Error loading reviews: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a dessert from the dropdown list.", "No Dessert Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
