using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.API.Configurations
{
    public class ConnectionString
    {
        public static string host { get; set; } = "localhost";
        public static string Tenant { get; set; } = "ToDoListDB";
        public static string Name { get; set; } = "postgres";
        public static string Password { get; set; } = "@Sql1234";
        public static string Port { get; set; } = "8432";
    }
}
