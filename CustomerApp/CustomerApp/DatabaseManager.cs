using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    /// <summary>
    /// Class used as interface to the database
    /// </summary>
    internal class DatabaseManager
    {
        public List<Customer> GetAllCustomers()
        {
            return database.GetCustomers();
        }

        public bool DeleteCustomer(int customerId)
        {
            return database.DeleteCustomer(customerId);
        }

        public bool EditCustomer(Customer customer)
        {
            return database.UpdateCustomer(customer);
        }

        public void AddCustomer(Customer customer)
        {
            database.AddNewCustomer(customer);
        }

        private Database database = new Database();
    }
}
