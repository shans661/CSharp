using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    /// <summary>
    /// Gold state of the account
    /// </summary>
    class GoldState : AbstractState
    {
        public GoldState(int amount, Account account) : base(amount, account)
        {
            LowerLimit = 10000;
            UpperLimit = 10000000;
            Balance = amount;
            InterstRate = 3;
        }
        public override void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Balance is updated after deposit, current balance is {Balance}");
            ChangeState();
        }

        public override void PayInterest()
        {
            Balance += (Balance * InterstRate);
            Console.WriteLine($"Balance is updated after interrest pay, current balance is {Balance}");
            ChangeState();
        }

        public override void WithDraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine($"Balance is updated after withdrawal, current balance is {Balance}");
            ChangeState();
        }

        private void ChangeState()
        {
            if (Balance < LowerLimit)
            {
                Console.WriteLine($"Balance {Balance} is lower than {UpperLimit}");
                Account.State = new SilverState(Account.Balance, Account);
                Console.WriteLine("Account state changed to silver state");
            }
        }
    }
}
