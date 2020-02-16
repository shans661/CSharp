using System;
using System.Collections.Generic;
using System.Text;

namespace State.States
{
    abstract class AbstractState
    {
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        public int InterstRate { get; set; }
        public int Balance { get; set; }
        public Account Account { get; set; }

        public AbstractState(int amount, Account account)
        {
            Balance = amount;
            Account = account;
        }
        public abstract void Deposit(int amount);
        public abstract void WithDraw(int amount);
        public abstract void PayInterest();
    }
}
