using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Mementos
{
    /// <summary>
    /// Class which internal stores the state of sales
    /// </summary>
    class ProspectMemory
    {
        private Mement m_Memento;
        public Mement Memento
        {
            get { return m_Memento; }
            set { m_Memento = value; }
        }
    }
}
