using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Features.Implementation
{
    /// <summary>
    /// Implementation of the customer data object
    /// </summary>
    class CustomerDataObject : IDataObject
    {
        List<string> m_Cutomers = new List<string>();
        int m_CurrentRecord = 0;

        public CustomerDataObject()
        {
            m_Cutomers.Add("Aish");
            m_Cutomers.Add("Krish");
            m_Cutomers.Add("Raj");
            m_Cutomers.Add("Sush");
        }
        public bool AddRecord(string name)
        {
            if (!m_Cutomers.Contains(name))
            {
                m_Cutomers.Add(name);

                return true;
            }

            return false;
        }

        public bool DeleteRecord(string name)
        {
            if (m_Cutomers.Contains(name))
            {
               return m_Cutomers.Remove(name);
            }
            return false;
        }

        public void NextRecord()
        {
            if(m_CurrentRecord < m_Cutomers.Count)
            {
                m_CurrentRecord++;
                Console.WriteLine($"Record is {m_Cutomers[m_CurrentRecord]}");
            }
        }

        public void PriorRecord()
        {
            if(m_CurrentRecord > 0)
            {
                m_CurrentRecord--;
                Console.WriteLine($"Record is {m_Cutomers[m_CurrentRecord]}");
            }
        }

        public void ShowAllRecords()
        {
            Console.WriteLine($"All records are");

            for (int index = 0; index < m_Cutomers.Count; index++)
            {
                Console.WriteLine($"Record is {m_Cutomers[index]}");
            }
        }

        public void ShowRecord()
        {
            if (m_CurrentRecord < m_Cutomers.Count && m_CurrentRecord > 0)
            {
                Console.WriteLine($"Current Record is {m_Cutomers[m_CurrentRecord]}");
            }
        }
    }
}
