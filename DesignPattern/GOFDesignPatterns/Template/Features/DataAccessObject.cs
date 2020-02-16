using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Features
{
    /// <summary>
    /// Abstract class of products
    /// </summary>
    abstract class DataAccessObject
    {
        public virtual void Connect()
        {
            Console.WriteLine("Connected to DB");
        }
        public abstract void Select();
        public abstract void Process();
        public virtual void Disconnect()
        {
            Console.WriteLine("Disconnected from DB");
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
