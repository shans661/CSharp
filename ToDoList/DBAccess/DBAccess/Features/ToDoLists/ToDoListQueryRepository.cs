using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBAccess.EFCore;
using DBAccess.Entities;
using DBAccess.Models;
using Microsoft.Extensions.Logging;

namespace DBAccess.Features.ToDoLists
{
    public class ToDoListQueryRepository : IToDoListQueryRepository
    {
        private readonly ILogger m_Logger;
        private readonly ToDoListDBContext m_ToDoListDBContext;
        public ToDoListQueryRepository(ILogger<ToDoListQueryRepository> logger, ToDoListDBContext contex)
        {
            m_Logger = logger;
            m_ToDoListDBContext = contex;
        }

        public IList<Item> GetItems(string userName)
        {
            try
            {
                m_Logger.LogInformation($"Getitems started for the user {userName}");

                var items = m_ToDoListDBContext.ToDoList.Where(x => x.UserName == userName)
                    .Select(x => new Item() { Value = x.Item, CreationTime = x.CreationTime }).ToList();

                m_Logger.LogInformation($"Total items found is {items.Count} for the user {userName}");

                return items;
            }
            catch(Exception ex)
            {
                m_Logger.LogError(ex, $"Exception occurred during getitems for user {userName}");
                return new List<Item>();
            }
        }
    }
}
