using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        //public string ProductName { get; set; }

        //hanlde the ProductName
        private string _productName;
        public string ProductName
        {
            get
            {
                //// Common StringHandler class, use new keyword to instanciate it, and use the instance to call the class methods
                //var stringHandler = new StringHandler();
                //return stringHandler.InsertSpaces(_productName);

                //// Modify StringHandler class as a static class, we should use the class name to call its methods
                //return StringHandler.InsertSpaces(_productName);

                // Modify the InsertSpaces method in StringHandler class as an extension methos using this keyword
                // we can use the variable to call the method directly, and the method has no parameters
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        ///// <summary>
        ///// Retrieve one product.
        ///// </summary>
        ///// <param name="productId"></param>
        ///// <returns></returns>
        //public Product Retrieve(int productId)
        //{
        //    //Code that retrieve the defined customer

        //    return new Product();
        //}

        ///// <summary>
        ///// Saves the current product.
        ///// </summary>
        ///// <returns></returns>
        //public bool Save()
        //{
        //    //Code that saves the defined product

        //    return true;
        //}

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }


    }
}
