using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Features
{
    /// <summary>
    /// Purchase model
    /// </summary>
    class Purchase
    {
        public string ProductName { get; set; }
        public int Quntity { get; set; }
        public int Price { get; set; }
    }
}
