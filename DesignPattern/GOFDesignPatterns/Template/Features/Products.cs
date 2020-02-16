using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Features
{
    /// <summary>
    /// Implementation of the products
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Product is processed");
        }

        public override void Select()
        {
            Console.WriteLine("Product is selected for the process");
        }
    }
}
