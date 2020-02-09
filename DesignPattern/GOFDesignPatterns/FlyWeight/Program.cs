using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            CharacterFactory characterFactory = new CharacterFactory();

            char[] charArray = { 'A', 'Z', 'B', 'S', 'B', 'B' };

            foreach(var item in charArray)
            {
                //Object is created and stored in factory will return when requested
                var character = characterFactory.GetCharacter(item.ToString());
                if (character != null)
                {
                    character.Display();
                }
            }

            Console.WriteLine("---------------------------");

            Console.ReadKey();
        }
    }
}
