using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    /// <summary>
    /// Database class for holding the customer data. This would be the database ideally but a simpler structure of holding customer data in collections is being used here.
    /// </summary>
    internal class Database
    {
        public Database() 
        {
            LoadDefaultData();
        }

        public List<Customer> GetCustomers() 
        { 
            return customers.Values.ToList();
        }

        public void AddNewCustomer(Customer customer)
        {
            int id = GetNextId();
            customer.Id = id;

            customers.Add(id, customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool success = true;

            if (customers.ContainsKey(customer.Id))
            {
                customers[customer.Id] = customer;
            }
            else
            {
                success = false;
            }

            return success;
        }

        public bool DeleteCustomer(int customerId)
        {
            bool success = true;

            if (customers.ContainsKey(customerId))
            {
                customers.Remove(customerId);
            }
            else
            {
                success = false;
            }

            return success;
        }

        private int GetNextId()
        {
            return customers.Count > 0 ? customers.OrderByDescending(x => x.Key).First().Key + 1 : 1;
        }

        private void LoadDefaultData()
        {
            customers.Clear();
            customers.Add(1, new Customer(1, "Mr Smith", "1 West Street", "Birmingham", "B32 2AD", "0121 333 4444", ""));
            customers.Add(2, new Customer(2, "Mrs Jones", "23 Hill Lane", "Birmingham", "B23 2XY", "0121 567 2323", "0745 765 9854"));
            customers.Add(3, new Customer(3, "Mr Needham", "34 Hagley Road", "Birmingham", "B11 5DD", "", "0796 345 2345"));
            customers.Add(4, new Customer(4, "Mr Smith", "55 East Street", "Birmingham", "B32 2AH", "0121 333 8989", "0747 678 2346"));
            customers.Add(5, new Customer(5, "Mrs Woods", "65 Brook Avenue", "Birmingham", "B1 7HS", "0121 452 3434", "0792 783 7629"));
        }

        private Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
    }
}
