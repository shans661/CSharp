using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Features
{
    /// <summary>
    /// Concrete participant type
    /// </summary>
    class Beatle : IParticipant
    {
        public string Name { get; set; }

        public ChartRoom ChatRoom { get; set; }
        public Beatle(string name)
        {
            Console.WriteLine($"Beatle user created {name}");
            Name = name;
        }
        public void Notify(string from, string message)
        {
            Console.WriteLine($"{Name} received message {message} from {from}");
        }
    }
}
