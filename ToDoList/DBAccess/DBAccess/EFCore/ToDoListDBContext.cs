using DBAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.EFCore
{
    public class ToDoListDBContext : DbContext
    {
        public ToDoListDBContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<ToDoListEntity> ToDoList { get; set; }
    }
}
