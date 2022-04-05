using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order(): this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        // Defines CustomerId, ShippingAddressId
        // when the order repository populates the order, these ID properties are populated, but not the customer or address details.
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; } // Define the composition relationship between the order and the order items using references by defining a list of order items.
        public int ShippingAddressId { get; set; }

        public string Log() =>
            $"{OrderId} Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";
        

        public override string ToString() =>
            $"{OrderDate.Value.Date}({OrderId})";       //Return the order date and ID
       

        ///// <summary>
        ///// Retrieve one order.
        ///// </summary>
        ///// <param name="orderId"></param>
        ///// <returns></returns>
        //public Order Retrieve(int orderId)
        //{
        //    //Code that retrieve the defined order

        //    return new Order();
        //}

        ///// <summary>
        ///// Saves the current order.
        ///// </summary>
        ///// <returns></returns>
        //public bool Save()
        //{
        //    //Code that saves the defined order

        //    return true;
        //}

        /// <summary>
        /// Validates the order data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            
            if (OrderDate == null)
                isValid = false;

            return isValid;
        }



    }
}
