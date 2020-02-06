using FactoryMethod.AbstractClass;
using FactoryMethod.Features.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Features.Documents
{
    /// <summary>
    /// Report document will create different pages
    /// </summary>
    class Report : Document
    {
        /// <summary>
        /// Creates different pages
        /// </summary>
        public override void CreateDocument()
        {
            Console.WriteLine("Report document");
            Pages.Add(new ContentsPage());
            Pages.Add(new Bibiliography());
            Pages.Add(new AcknowledgePage());
            Pages.Add(new ChapterPage());
            Pages.Add(new SummaryPage());
        }
    }
}
