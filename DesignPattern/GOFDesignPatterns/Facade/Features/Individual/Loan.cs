using Facade.Features.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Features.Individual
{
    /// <summary>
    /// Sub system
    /// </summary>
    class Loan
    {
        public bool HasLoanBalance(Customer customer, int loanAmount)
        {
            if(customer.LoanBalance < (loanAmount/4))
            {
                Console.WriteLine("Loan balance is manageble");
                return true;
            }
            Console.WriteLine("Loan balance is not manageble");
            return false;
        }
    }
}
