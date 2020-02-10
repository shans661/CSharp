using ChainOfResponsibility.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AbstractClass
{
    /// <summary>
    /// Abract class - Approver
    /// </summary>
    abstract class Approver
    {
        public Approver Successor { get; set; }

        /// <summary>
        /// Sets to successor to handle the request
        /// </summary>
        /// <param name="approver"></param>
        public abstract void SetSuccessor(Approver approver);

        /// <summary>
        /// Method to process the request and send to superior if 
        /// </summary>
        /// <param name="purchase"></param>
        public abstract void ProcessRequest(Purchase purchase);
    }
}
