using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Features
{
    /// <summary>
    /// Server used inside load balancer
    /// </summary>
    class Server
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
    }
}
