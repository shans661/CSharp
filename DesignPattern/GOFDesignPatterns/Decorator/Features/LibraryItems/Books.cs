using Decorator.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Features.LibraryItems
{
    /// <summary>
    /// Concrete component
    /// </summary>
    class Books : LibraryItem
    {
        private string Author { get; set; }
        private string Title { get; set; }

        public Books(string author, string title, int copies)
        {
            Author = author;
            Title = title;
            NumberOfCopies = copies;
        }
        public override void Display()
        {
            Console.WriteLine($"Book author {Author}");
            Console.WriteLine($"Book title {Title}");
            Console.WriteLine($"Book copies {NumberOfCopies}");
        }
    }
}
