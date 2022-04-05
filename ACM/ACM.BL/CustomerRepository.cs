using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            // Establishes a collaborative relationship between CustomerRepository and AddressRepository
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            //Temporary hard-coded values to return a populated customer
            // and address
            if(customerId == 1)
            {
                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.Lastname = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();     // when any code requests to retrieve a customer, Retrieve method will retrieve and populate the customer and its associated addresses.
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }
    }
}
