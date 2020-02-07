using Bridge.Features.Implementation;
using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Features.Abstration
{
    /// <summary>
    /// Abstration class
    /// </summary>
    class CustomerBase
    {
        //Create customer data object
        IDataObject customerDataObject = new CustomerDataObject();

        public virtual void AddCustomer(string name)
        {
            Console.WriteLine($"Customer {name} is added");
            if (customerDataObject.AddRecord(name))
            {
                Console.WriteLine($"Customer {name} added into data base");
            }
            else
            {
                Console.WriteLine($"Customer {name} is exists in the data base");
            }
        }

        public virtual void DeleteCustomer(string name)
        {
            if (customerDataObject.DeleteRecord(name))
            {
                Console.WriteLine($"Customer {name} deleted from the data base");
            }
            else
            {
                Console.WriteLine($"Customer {name} not exists in the data base");
            }
        }

        public virtual void NextCustomer()
        {
            customerDataObject.NextRecord();
        }

        public virtual void PriorCustomer()
        {
            customerDataObject.PriorRecord();
        }

        public virtual void ShowCustomer()
        {
            customerDataObject.ShowRecord();
        }

        public virtual void ShowAllCustomer()
        {
            customerDataObject.ShowAllRecords();
        }
    }
}
