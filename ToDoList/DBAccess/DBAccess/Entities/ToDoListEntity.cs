using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.Entities
{
    public class ToDoListEntity 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
