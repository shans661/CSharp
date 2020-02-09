using Facade.Features.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Features.Individual
{
    /// <summary>
    /// Sub system
    /// </summary>
    class CreditCard
    {
        public bool HasGoodCreditRating(Customer customer)
        {
            if(customer.CreditScore > 700)
            {
                Console.WriteLine("Credit rating is good");
                return true;
            }
            Console.WriteLine("Credit rating is not good");
            return false;
        }
    }
}
