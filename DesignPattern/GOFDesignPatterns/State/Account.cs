using State.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Account
    {
        public int Balance { get; set; }
        private AbstractState m_State;

        public AbstractState State { get { return m_State; } set { m_State = value; } }

        public Account(int amount)
        {
            Balance = amount;
            m_State = new GeneralState(amount, this);
        }

        public void Deposit(int amount)
        {
            Console.WriteLine($"Deposit {amount} initiated");
            m_State.Deposit(amount);
        }

        public void Withdraw(int amount)
        {
            Console.WriteLine($"Withdrawal initiated {amount}");
            m_State.WithDraw(amount);
        }

        public void PayInterest()
        {
            Console.WriteLine($"Interest pay initiated");
            m_State.PayInterest();
        }
    }
}
