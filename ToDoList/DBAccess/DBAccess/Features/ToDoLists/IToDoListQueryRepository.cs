using DBAccess.Entities;
using DBAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Features.ToDoLists
{
    public interface IToDoListQueryRepository
    {
        /// <summary>
        /// Returns the all the items saved by the given user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        IList<NoteItem> GetItems(int userId);

        NoteItem GetItem(int userId, int id);
    }
}
