using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Features.Abstration
{
    /// <summary>
    /// Refined class for customers
    /// </summary>
    class Customers : CustomerBase
    {
        public override void ShowAllCustomer()
        {
            base.ShowAllCustomer();
            Console.WriteLine("These are the customers exists in the DB");
        }
    }
}
