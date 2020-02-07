using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Interfaces
{
    /// <summary>
    /// Interface for the implementation
    /// </summary>
    interface IDataObject
    {
        bool AddRecord(string name);
        bool DeleteRecord(string name);
        void NextRecord();
        void PriorRecord();
        void ShowRecord();
        void ShowAllRecords();
    }
}
