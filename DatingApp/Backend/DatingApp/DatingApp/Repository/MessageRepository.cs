using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatingApp.API;
using DatingApp.API.Entities;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Helpers;
using DatingApp.Interfaces;

namespace DatingApp.Repository
{
    public class MessageRepository : IMessagesRepository
    {
        private readonly DataBaseContext m_Context;
        private readonly IMapper m_Mapper;
        public MessageRepository(DataBaseContext context, IMapper mapper)
        {
            m_Context = context;
            m_Mapper = mapper;
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

        public async Task<PagedList<MessageDTO>> GetMessagesForUser(MessageParams messageParams)
        {
            var query = m_Context.Messages.OrderByDescending(x => x.MessageSent).AsQueryable();

            query =  messageParams.Container switch
            {
                "Inbox" => query.Where(x => x.Recipient.UserName == messageParams.Username),
                "Outbox" => query.Where(x => x.Sender.UserName == messageParams.Username),
                _ => query.Where(x => x.Recipient.UserName == messageParams.Username && x.DateRead == null)
            };

            var messages = query.ProjectTo<MessageDTO>(m_Mapper.ConfigurationProvider);

            return await PagedList<MessageDTO>.CreateAsync(messages, messageParams.PageNumber, messageParams.PageSize);
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