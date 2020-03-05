using DBAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Features.ToDoLists
{
    public interface IToDoListCommandRepository
    {
        Task<bool> AddItem(ToDoListEntity toDoListEntity);
    }
}
