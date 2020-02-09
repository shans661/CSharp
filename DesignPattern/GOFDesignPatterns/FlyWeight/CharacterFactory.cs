using FlyWeight.AbstarctClass;
using FlyWeight.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    /// <summary>
    /// Character factory stores all the chracters
    /// </summary>
    class CharacterFactory
    {
        Dictionary<string, Character> m_CharacterFactory = new Dictionary<string, Character>();

        public Character GetCharacter(string character)
        {
            if(m_CharacterFactory.ContainsKey(character))
            {
                Console.WriteLine($"{character}  is already exists in factory");
                return m_CharacterFactory[character];
            }
            else
            {
                switch(character)
                {
                    case "A":
                        var charA = new CharacterA();
                        m_CharacterFactory.Add(character, charA);
                        return charA;
                    case "B":
                        var charB = new CharacterB();
                        m_CharacterFactory.Add(character, charB);
                        return charB;
                    case "Z":
                        var charZ = new CharacterB();
                        m_CharacterFactory.Add(character, charZ);
                        return charZ;
                    default:
                        Console.WriteLine($"{character} not available");
                        return null;
                }
            }
        }
    }
}
