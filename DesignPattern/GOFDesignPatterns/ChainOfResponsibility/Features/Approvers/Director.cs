using ChainOfResponsibility.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Features.Approvers
{
    /// <summary>
    /// Create class - Approver
    /// </summary>
    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Price < 10000)
            {
                Console.WriteLine($"{purchase.ProductName} purchase request handled by {this.GetType().Name}");
            }
            else if(Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }

        public override void SetSuccessor(Approver approver)
        {
            Successor = approver;
        }
    }
}
