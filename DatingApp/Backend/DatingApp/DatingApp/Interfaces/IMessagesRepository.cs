using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Entities;
using DatingApp.API.Helpers;
using DatingApp.DTOs;

namespace DatingApp.Interfaces
{
    public interface IMessagesRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDTO>> GetMessagesForUser();

        Task<IEnumerable<MessageDTO>> GetMessageThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync();
    }
}