using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    class GeneralState : AbstractState
    {
        public GeneralState(int amount, Account account) : base(amount, account)
        {
            LowerLimit = 0;
            UpperLimit = 5000;
            Balance = amount;
            InterstRate = 1;
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
            if(Balance > UpperLimit)
            {
                Console.WriteLine($"Balance {Balance} is greater than {UpperLimit}");
                Account.State = new SilverState(Account.Balance, Account);
                Console.WriteLine("Account state changed to silver state");
            }
        }
    }
}
