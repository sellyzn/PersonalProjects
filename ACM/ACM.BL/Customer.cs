using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                //to handle valid and invalid values
                string fullName = Lastname;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastname;
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        ///// <summary>
        ///// Retrieve one customer.
        ///// </summary>
        ///// <param name="customerId"></param>
        ///// <returns></returns>
        //public Customer Retrieve(int customerId)
        //{
        //    //Code that retrieve the defined customer

        //    return new Customer();
        //}

        //public List<Customer> Retrieve()
        //{
        //    //Code that retrieve all of the customers

        //    return new List<Customer>();
        //}

        ///// <summary>
        ///// Saves the current customer.
        ///// </summary>
        ///// <returns></returns>
        //public bool Save()
        //{
        //    //Code that saves the defined customer

        //    return true;
        //}

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Lastname))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress))
                isValid = false;

            return isValid;
        }



        


    }
}
