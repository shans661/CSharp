using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");

            Account m_Account = new Account(10);
            m_Account.Deposit(110);
            m_Account.Deposit(4000);
            m_Account.Deposit(10000);
            m_Account.Withdraw(14000);

            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }
    }
}
