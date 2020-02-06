using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Features.Pages
{
    class SkillsPage : IPage
    {
        public void ShowPage()
        {
            Console.WriteLine("Skills page");
        }
    }
}
