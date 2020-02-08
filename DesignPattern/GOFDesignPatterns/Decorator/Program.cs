using Decorator.Features.Decorators;
using Decorator.Features.LibraryItems;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            //Create concrete component
            Books books = new Books("Shiva", "Think on that", 99);
            books.Display();
            //Use decorator
            Borrowable borrower = new Borrowable(books);
            borrower.BorrowItem("Aish");
            borrower.BorrowItem("Raj");
            borrower.BorrowItem("Krish");
            borrower.ReturnItem("Aish");

            borrower.DisplayBorrowers();

            Console.WriteLine("-----------------------");

            Console.ReadKey();
        }
    }
}
