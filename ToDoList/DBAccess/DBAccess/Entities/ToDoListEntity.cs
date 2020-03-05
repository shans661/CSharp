using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.Entities
{
    public class ToDoListEntity 
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public string Item { get; set; }
    }
}
