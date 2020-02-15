using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interfaces
{
    /// <summary>
    /// Chart room interface
    /// </summary>
    interface IChartRoom 
    {
        void Register(string userName, IParticipant participant);
        void Send(string from, string to, string message);
    }
}
