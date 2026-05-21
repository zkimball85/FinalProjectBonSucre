using FinalProjectBonSucre.DBAccess;
using FinalProjectBonSucre.Models;

namespace FinalProjectBonSucre
{
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
}
