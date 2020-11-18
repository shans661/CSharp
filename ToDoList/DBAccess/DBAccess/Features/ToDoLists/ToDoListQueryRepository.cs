using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public NoteItem GetItem(int userId, int id)
        {
            try
            {
                m_Logger.LogInformation($"Getitem started for the user {userId} and item {id}");


                var item = m_ToDoListDBContext.ToDoList.Where(x => x.UserId == userId && x.Id == id).FirstOrDefault();

                if (item != null)
                {
                    return new NoteItem()
                    {
                        Title = item.Title,
                        Body = item.Body
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                m_Logger.LogError(ex, $"Exception occurred during getitem for user {userId} and item id {id}");
                return null;
            }
        }

        public IList<NoteItem> GetItems(int userId)
        {
            try
            {
                m_Logger.LogInformation($"Getitems started for the user {userId}");

                var items = m_ToDoListDBContext.ToDoList.Where(x => x.UserId == userId)
                    .Select(x => new NoteItem() { Title = x.Title, Body = x.Body }).ToList();

                m_Logger.LogInformation($"Total items found is {items.Count} for the user {userId}");

                return items;
            }
            catch (Exception ex)
            {
                m_Logger.LogError(ex, $"Exception occurred during getitems for user {userId}");
                return new List<NoteItem>();
            }
        }
    }
}
