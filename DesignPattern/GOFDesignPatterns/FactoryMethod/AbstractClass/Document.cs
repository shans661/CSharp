using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.AbstractClass
{
    /// <summary>
    /// Different type of document creates different pages
    /// </summary>
    abstract class Document
    {
        public Document()
        {
            Pages = new List<IPage>();
        }
        public List<IPage> Pages { get; set; }

        /// <summary>
        /// Creates different pages
        /// </summary>
        public abstract void CreateDocument();

        public void ShowDoucument()
        {
            foreach(var page in Pages)
            {
                page.ShowPage();
            }
        }

    }
}
