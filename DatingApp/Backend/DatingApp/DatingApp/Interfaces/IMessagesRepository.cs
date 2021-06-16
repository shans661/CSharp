using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Entities;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Helpers;

namespace DatingApp.Interfaces
{
    public interface IMessagesRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDTO>> GetMessagesForUser(MessageParams messageParams);

        Task<IEnumerable<MessageDTO>> GetMessageThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync();
    }
}