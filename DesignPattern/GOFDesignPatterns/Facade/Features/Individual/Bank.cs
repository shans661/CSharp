using Facade.Features.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Features.Individual
{
    /// <summary>
    /// Bank system
    /// </summary>
    class Bank
    {
        public bool HasSufficientBalance(Customer cutomer, int loanAmount)
        {
            if (cutomer.Balance > (loanAmount / 2))
            {
                Console.WriteLine("Has sufficient balance");
                return true;
            }
            Console.WriteLine("Do not have sufficient balance");
            return false;
        }
    }
}
