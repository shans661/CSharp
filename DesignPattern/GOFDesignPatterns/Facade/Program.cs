using Facade.Features.Model;
using Facade.Features.Unified;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            // Mortgage provide unified interface for loan processing
            Mortgage mortgage = new Mortgage();

            //Cutomer pbject
            Customer lucyHale = new Customer();
            lucyHale.Name = "Lucy Hale";
            lucyHale.Balance = 66000;
            lucyHale.CreditScore = 710;
            lucyHale.LoanBalance = 10000;

            Console.WriteLine($"Customer {lucyHale.Name} loan eligibility");

            if(mortgage.IsEligibleForLoan(lucyHale, 50000))
            {
                Console.WriteLine($"{lucyHale.Name} eligible for the loan amount 50000");
            }
            else
            {
                Console.WriteLine($"{lucyHale.Name} is not eligible for the loan amount 50000");
            }
            Console.WriteLine("------------------------------");

            if (mortgage.IsEligibleForLoan(lucyHale, 700000))
            {
                Console.WriteLine($"{lucyHale.Name} eligible for the loan amount 70000");
            }
            else
            {
                Console.WriteLine($"{lucyHale.Name} is not eligible for the loan amount 70000");
            }

            Console.ReadKey();
        }
    }
}
