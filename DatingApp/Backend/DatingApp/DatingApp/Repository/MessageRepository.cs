using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API;
using DatingApp.API.Entities;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Interfaces;

namespace DatingApp.Repository
{
    public class MessageRepository : IMessagesRepository
    {
        private readonly DataBaseContext m_Context;
        public MessageRepository(DataBaseContext context)
        {
            m_Context = context;
        }

        public void AddMessage(Message message)
        {
            m_Context.Messages.Add(message);
        }

        public void DeleteMessage(Message message)
        {
            m_Context.Messages.Remove(message);
        }

        public async Task<Message> GetMessage(int id)
        {
            return await m_Context.Messages.FindAsync(id);
        }

        public Task<PagedList<MessageDTO>> GetMessagesForUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MessageDTO>> GetMessageThread(int currentUserId, int recipientId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await m_Context.SaveChangesAsync() > 0;
        }
    }
}