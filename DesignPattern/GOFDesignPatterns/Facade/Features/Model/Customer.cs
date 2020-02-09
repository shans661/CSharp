using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Features.Model
{
    /// <summary>
    /// Cutomer model
    /// </summary>
    class Customer
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public int CreditScore { get; set; }
        public int LoanBalance { get; set; }
    }
}
