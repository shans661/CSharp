using Mediator.Features;
using Mediator.Interfaces;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            ChartRoom chartRoom = new ChartRoom();
            var shivaParticipant = new Beatle("Shiva");
            shivaParticipant.ChatRoom = chartRoom;
            var shankaraParticipant = new Beatle("Shankara");
            shankaraParticipant.ChatRoom = chartRoom;
            var swathiParticipant = new Beatle("Swathi");
            swathiParticipant.ChatRoom = chartRoom;
            var shruthiParticipant = new Beatle("Shruthi");
            shruthiParticipant.ChatRoom = chartRoom;

            chartRoom.Register(shivaParticipant.Name, shivaParticipant);
            chartRoom.Register(shankaraParticipant.Name, shankaraParticipant);
            chartRoom.Register(swathiParticipant.Name, swathiParticipant);
            chartRoom.Register(shruthiParticipant.Name, shruthiParticipant);

            shivaParticipant.ChatRoom.Send(shivaParticipant.Name, shankaraParticipant.Name, "Hello shan i'm shiv");
            shruthiParticipant.ChatRoom.Send(shruthiParticipant.Name, shivaParticipant.Name, "Hey how r u?");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
