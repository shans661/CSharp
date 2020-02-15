using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interfaces
{
    interface IParticipant
    {
        void Notify(string from, string message);
    }
}
