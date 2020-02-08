using Decorator.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Features.LibraryItems
{
    /// <summary>
    /// Concrete component
    /// </summary>
    class Videos : LibraryItem
    {
        private string Author { get; set; }
        private string Title { get; set; }

        public Videos(string author, string title)
        {
            Author = author;
            Title = title;
        }
        public override void Display()
        {
            Console.WriteLine($"Video author {Author}");
            Console.WriteLine($"Video title {Title}");
            Console.WriteLine($"Video copies {NumberOfCopies}");
        }
    }
}
