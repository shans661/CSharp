using Facade.Features.Individual;
using Facade.Features.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Features.Unified
{
    /// <summary>
    /// Main system
    /// </summary>
    class Mortgage
    {
        Bank m_Bank = new Bank();
        CreditCard m_CreditCard = new CreditCard();
        Loan m_Loan = new Loan();

        public bool IsEligibleForLoan(Customer customer, int loanAmount)
        {
            bool isEligible = false;
            isEligible = m_Bank.HasSufficientBalance(customer, loanAmount);
            isEligible = m_Loan.HasLoanBalance(customer, loanAmount);
            isEligible = m_CreditCard.HasGoodCreditRating(customer);

            return isEligible;
        }
    }
}
