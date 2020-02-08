using Decorator.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Features.Decorators
{
    /// <summary>
    /// Concrete decorator
    /// </summary>
     class Borrowable : Decorator
    {
        List<string> Borrowers = new List<string>();
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {

        }

        public void BorrowItem(string name)
        {
            Borrowers.Add(name);
            LibraryItem.NumberOfCopies--;

            Console.WriteLine($"{LibraryItem.GetType().Name} borrowed");

            Console.WriteLine($"Borrower name {name}");
            Console.WriteLine($"{LibraryItem.GetType().Name} count remaining {LibraryItem.NumberOfCopies}");
        }

        public void ReturnItem(string name)
        {
            Borrowers.Remove(name);
            LibraryItem.NumberOfCopies++;
            Console.WriteLine($"{LibraryItem.GetType().Name} retured");
            Console.WriteLine($"Borrower name {name}");
            Console.WriteLine($"{LibraryItem.GetType().Name} count remaining {LibraryItem.NumberOfCopies}");
        }

        public void DisplayBorrowers()
        {
            foreach(var item in Borrowers)
            {
                Console.WriteLine($"Borrower : {item}");
            }
        }
    }
}
