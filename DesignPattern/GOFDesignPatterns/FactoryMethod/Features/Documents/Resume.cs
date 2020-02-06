using FactoryMethod.AbstractClass;
using FactoryMethod.Features.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Features.Documents
{
    /// <summary>
    /// Resume will be created
    /// </summary>
    class Resume : Document
    {
        /// <summary>
        /// Resume pages will be created
        /// </summary>
        public override void CreateDocument()
        {
            Console.WriteLine("Resume document");
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new SkillsPage());
        }
    }
}
