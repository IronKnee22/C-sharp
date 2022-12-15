using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    interface IOrder
    {
        int Number { get; }
        /// <summary>
        /// Customer first name
        /// </summary>
        string FirstName { get; }
        /// <summary>
        /// Customer last name
        /// </summary>
        string LastName { get; }
        /// <summary>
        /// Street
        /// </summary>
        string Street { get; }
        /// <summary>
        /// House number
        /// </summary>
        int HouseNumber { get; }
        /// <summary>
        /// Registry number
        /// </summary>
        
        string City { get; }
        /// <summary>
        /// Zip code
        /// </summary>
        
        string[] Products { get; }
        /// <summary>
        /// Product quantities
        /// </summary>
        int[] Quantities { get; }
        /// <summary>
        /// Product prices
        /// </summary>
        int[] Prices { get; }
    }
}
