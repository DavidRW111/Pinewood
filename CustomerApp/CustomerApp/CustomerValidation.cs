using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    /// <summary>
    /// Performs validation for a customer
    /// </summary>
    public class CustomerValidation
    {
        public (bool valid, string errorMessage) ValidateCustomer(string name, string address, string city, string postCode, string homePhoneNumber, string mobileNumber)
        {
            validCustomer = true;
            validationErrors.Clear();

            // Validate mandatory fields
            ValidateName(name);
            ValidateAddress(address);
            ValidateCity(city);
            ValidatePostCode(postCode);

            // Validate optional fields
            ValidatePhoneNumbers(homePhoneNumber, mobileNumber);

            return (validCustomer, validationErrors.ToString());
        }

        private void ValidateName(string name)
        {
            if (name.Trim().Length == 0)
            {
                validCustomer = false;
                validationErrors.Append("No customer name specified\n");
            }
        }

        private void ValidateAddress(string address)
        {
            if (address.Trim().Length == 0)
            {
                validCustomer = false;
                validationErrors.Append("No customer address specified\n");
            }
        }

        private void ValidateCity(string city)
        {
            if (city.Trim().Length == 0)
            {
                validCustomer = false;
                validationErrors.Append("No customer city specified\n");
            }
        }

        private void ValidatePostCode(string postCode)
        {
            if (postCode.Trim().Length == 0)
            {
                validCustomer = false;
                validationErrors.Append("No customer post code specified\n");
            }
            else
            {
                // Do some basic post code checking so we know that there are only alphanumeric characters or spaces in the post code
                // Note : more validation would be required for complete implementation
                if (!postCode.Trim().All(c => char.IsAsciiLetterOrDigit(c) || c == ' '))
                {
                    validCustomer = false;
                    validationErrors.Append("Invalid post code specified\n");
                }
            }
        }

        private void ValidatePhoneNumbers(string homePhoneNumber, string mobilePhoneNumber)
        {
            if (homePhoneNumber.Trim().Length == 0 && mobilePhoneNumber.Trim().Length == 0)
            {
                validCustomer = false;
                validationErrors.Append("No home phone number or mobile number specified\n");
            }
            else
            {
                // Do some basic phone number validation
                if (!homePhoneNumber.Trim().All(c => char.IsDigit(c) || c == ' '))
                {
                    validCustomer = false;
                    validationErrors.Append("Invalid home phone number specified\n");
                }

                if (!mobilePhoneNumber.Trim().All(c => char.IsDigit(c) || c == ' '))
                {
                    validCustomer = false;
                    validationErrors.Append("Invalid mobile phone number specified\n");
                }
            }
        }

        private StringBuilder validationErrors = new StringBuilder();
        private bool validCustomer = true;
    }
}
