using DBAccess.Entities;
using DBAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBAccess.Features.ToDoLists
{
    public interface IToDoListQueryRepository
    {
        /// <summary>
        /// Returns the all the items saved by the given user
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        IList<Item> GetItems(string userName);
    }
}
