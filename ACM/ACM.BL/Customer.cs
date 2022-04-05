using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        // : this  --> constructor chaining, call another constructor
        public Customer() : this(0)  // : this(0)  --> constructor chaining, use it any time one constructor needs to call another.  
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        //public Address WorkAddress { get; set; }
        //public Address HomeAdress { get; set; }
        public List<Address> AddressList { get; set; }      // For a list, the default is null. If any code attempts to access the AddressList property, the code will throw a null value exception.
                                                            // To prevent this exception, we'll modify the constructor to create an appropriate instance of the address list.  
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

        //public string Log()
        //{
        //    var logString = CustomerId + ": " +
        //        FullName + ": " +
        //        "Email: " + EmailAdress + ": " +
        //        "Status: " + EntityState.ToString();
        //    return logString;
        //}

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAdress} Status: {EntityState.ToString()}";


        public override string ToString() => FullName;

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
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
