using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    /// <summary>
    /// Class for holding data for a customer
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string HomePhoneNumber { get; set; }
        public string MobileNumber { get; set; }

        public Customer(int id, string name, string address, string city, string postCode, string homePhoneNumber, string mobilePhoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            PostCode = postCode;
            HomePhoneNumber = homePhoneNumber;
            MobileNumber = mobilePhoneNumber;
        }

        public Customer()
        {
            Id = 0;
            Name = "";
            Address = "";
            City = "";
            PostCode = "";
            HomePhoneNumber = "";
            MobileNumber = "";
        }

    }
}
