namespace CustomerApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            RefreshCustomerData();
        }

        private void RefreshCustomerData()
        {
            List<Customer> customers = databaseManager.GetAllCustomers();

            dataGridCustomers.Rows.Clear();

            foreach (Customer customer in customers)
            {
                dataGridCustomers.Rows.Add(customer.Id, customer.Name, customer.Address, customer.City, customer.PostCode, customer.HomePhoneNumber, customer.MobileNumber);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int selectedCustomerId = GetSelectedCustomerId();

            if (selectedCustomerId > 0)
            {
                var confirmResult = MessageBox.Show("Do you want to delete the selected customer?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (!databaseManager.DeleteCustomer(selectedCustomerId))
                    {
                        MessageBox.Show(string.Format("Error deleting selected customer (id = {0})", selectedCustomerId), "Error");
                    }
                    else
                    {
                        RefreshCustomerData();
                    }
                }
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddUpdateCustomerForm addUpdateCustomerForm = new AddUpdateCustomerForm(true);

            if (addUpdateCustomerForm.ShowDialog() == DialogResult.OK)
            {
                // Save the customer data
                Customer customer = new Customer();
                customer = addUpdateCustomerForm.UpdatedCustomer;

                databaseManager.AddCustomer(customer);

                RefreshCustomerData();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer? customer = GetSelectedCustomer();

            if (customer != null)
            {
                AddUpdateCustomerForm addUpdateCustomerForm = new AddUpdateCustomerForm(customer);

                if (addUpdateCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    // Save the customer data
                    customer = addUpdateCustomerForm.UpdatedCustomer;

                    if (!databaseManager.EditCustomer(customer))
                    {
                        MessageBox.Show(string.Format("Error updating selected customer (id = {0})", customer.Id), "Error");
                    }
                    else
                    {
                        RefreshCustomerData();
                    }
                }
            }
        }

        private int GetSelectedCustomerId()
        {
            return dataGridCustomers.CurrentRow != null ? (int)dataGridCustomers.CurrentRow.Cells[0].Value : 0;
        }

        private Customer? GetSelectedCustomer()
        {
            Customer? customer = null;

            if (dataGridCustomers.CurrentRow != null)
            {
                customer = new Customer();

                customer.Id = (int)dataGridCustomers.CurrentRow.Cells[0].Value;
                customer.Name = dataGridCustomers.CurrentRow.Cells[1].Value.ToString() ?? "";
                customer.Address = dataGridCustomers.CurrentRow.Cells[2].Value.ToString() ?? "";
                customer.City = dataGridCustomers.CurrentRow.Cells[3].Value.ToString() ?? "";
                customer.PostCode = dataGridCustomers.CurrentRow.Cells[4].Value.ToString() ?? "";
                customer.HomePhoneNumber = dataGridCustomers.CurrentRow.Cells[5].Value.ToString() ?? "";
                customer.MobileNumber = dataGridCustomers.CurrentRow.Cells[6].Value.ToString() ?? "";
            }
            
            return customer;
        }

        private DatabaseManager databaseManager = new DatabaseManager();
    }
}
