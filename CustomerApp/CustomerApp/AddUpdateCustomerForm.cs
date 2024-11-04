using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerApp
{
    public partial class AddUpdateCustomerForm : Form
    {
        public AddUpdateCustomerForm(bool NewCustomer)
        {
            InitializeComponent();
            UpdatedCustomer = new Customer();

            this.Text = "Add Customer";
            newCustomer = true;
        }

        public AddUpdateCustomerForm(Customer customer)
        {
            InitializeComponent();
            UpdatedCustomer = new Customer();

            this.Text = "Update Customer";
            newCustomer = false;

            UpdateFormControls(customer);
        }

        private void UpdateFormControls(Customer customer)
        {
            tbCustomerId.Text = customer.Id.ToString();
            tbName.Text = customer.Name;
            tbAddress.Text = customer.Address;
            tbCity.Text = customer.City;
            tbPostCode.Text = customer.PostCode;
            tbHomePhoneNumber.Text = customer.HomePhoneNumber;
            tbMobileNumber.Text = customer.MobileNumber;
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            // Validate customer
            CustomerValidation customerValidation = new CustomerValidation();
            (bool validCustomer, string validationErrors) = customerValidation.ValidateCustomer(tbName.Text, tbAddress.Text, tbCity.Text, tbPostCode.Text, tbHomePhoneNumber.Text, tbMobileNumber.Text);

            if (!validCustomer)
            {
                string errorMessage = String.Format("Error validating customer:\n\n{0}", validationErrors);

                MessageBox.Show(errorMessage, "Error");

                DialogResult = DialogResult.None;
            }
            else
            {
                // If valid save customer data to updated customer
                if (!newCustomer)
                {
                    // Id only exists for a existing cusomer
                    UpdatedCustomer.Id = Convert.ToInt32(tbCustomerId.Text);
                }

                UpdatedCustomer.Name = tbName.Text;
                UpdatedCustomer.Address = tbAddress.Text;
                UpdatedCustomer.City = tbCity.Text;
                UpdatedCustomer.PostCode = tbPostCode.Text;
                UpdatedCustomer.HomePhoneNumber = tbHomePhoneNumber.Text;
                UpdatedCustomer.MobileNumber = tbMobileNumber.Text;
            }
        }

        public Customer UpdatedCustomer { get; }

        private bool newCustomer = false;
    }
}
