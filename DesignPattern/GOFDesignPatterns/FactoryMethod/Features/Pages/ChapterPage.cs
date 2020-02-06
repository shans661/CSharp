using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Features.Pages
{
    class ChapterPage : IPage
    {
        public void ShowPage()
        {
            Console.WriteLine("Chapter page");
        }
    }
}
