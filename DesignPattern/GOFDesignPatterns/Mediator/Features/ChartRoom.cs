using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Features
{
    /// <summary>
    /// Concrete meadiator - chart room
    /// </summary>
    class ChartRoom : IChartRoom
    {
        Dictionary<string, IParticipant> participantsList = new Dictionary<string, IParticipant>();
        public void Register(string userName, IParticipant participant)
        {
            if (!participantsList.ContainsKey(userName))
            {
                participantsList.Add(userName, participant);
                Console.WriteLine($"Participant {userName} is successfully registered");
            }
            else
            {
                Console.WriteLine($"Participant {userName} already registered");
            }
        }

        public void Send(string from, string to, string message)
        {
            IParticipant receivingParticipant = participantsList[to];

            if(receivingParticipant != null)
            {
                receivingParticipant.Notify(from, message);
            }
        }
    }
}
