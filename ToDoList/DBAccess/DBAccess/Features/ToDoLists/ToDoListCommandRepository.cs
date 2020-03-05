using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DBAccess.EFCore;
using DBAccess.Entities;
using Microsoft.Extensions.Logging;

namespace DBAccess.Features.ToDoLists
{
    public class ToDoListCommandRepository : IToDoListCommandRepository
    {
        private readonly ILogger  m_Logger;
        private readonly ToDoListDBContext m_ToDoListDBContext;
        public ToDoListCommandRepository(ILogger<ToDoListCommandRepository> logger, ToDoListDBContext context)
        {
            m_Logger = logger;
            m_ToDoListDBContext = context;
        }
        public async Task<bool> AddItem(ToDoListEntity toDoListEntity)
        {
            try
            {
                await m_ToDoListDBContext.ToDoList.AddAsync(toDoListEntity);
                await m_ToDoListDBContext.SaveChangesAsync();

                m_Logger.LogWarning("ToDoList data is saved into DB");

                return true;
            }
            catch(Exception ex)
            {
                m_Logger.LogError(ex, "Exception occurred while saving data into ToDoList DB");
                return false;
            }
        }
    }
}
