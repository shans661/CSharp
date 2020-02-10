using ChainOfResponsibility.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Features.Approvers
{
    /// <summary>
    /// Create class - Approver - President
    /// </summary>
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Price > 20000)
            {
                Console.WriteLine($"{purchase.ProductName} purchase request handled by {this.GetType().Name}");
            }
            else if (Successor != null)
            {
                Console.WriteLine("No more superior available");
            }
        }

        public override void SetSuccessor(Approver approver)
        {
            Successor = approver;
        }
    }
}
