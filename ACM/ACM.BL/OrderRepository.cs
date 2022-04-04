using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Product class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined product

            //Temporary hard-coded values to return a populated product
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));                
            }
            return order;
        }
        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>

        public bool Save(Product order)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}
