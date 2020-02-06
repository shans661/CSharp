using FactoryMethod.Features.Documents;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Report report = new Report();
            report.CreateDocument();
            report.ShowDoucument();

            Console.WriteLine("------------------------------");
            Resume resume = new Resume();
            resume.CreateDocument();
            resume.ShowDoucument();

            Console.ReadKey();

        }
    }
}
