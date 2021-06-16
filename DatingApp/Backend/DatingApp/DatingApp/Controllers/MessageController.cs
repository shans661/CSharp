using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Entities;
using DatingApp.API.Extensions;
using DatingApp.DTOs;
using DatingApp.Extensions;
using DatingApp.Helpers;
using DatingApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [Authorize]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IUserRepository m_UserRepository;
        private readonly IMessagesRepository m_MessageRepository;
        private readonly IMapper m_Mapper;

        public MessageController(IUserRepository userRepository,
            IMessagesRepository messagesRepository, IMapper mapper)
        {
            m_UserRepository = userRepository;
            m_MessageRepository = messagesRepository;
            m_Mapper = mapper;
        }

        [HttpPost]
        [Route("api/createmessage")]
        public async Task<ActionResult<MessageDTO>> CreateMessage(CreateMessageDTO messageToCreate)
        {
            var sender = await m_UserRepository.GetUserByNameAsync(User.GetUsername());

            if (messageToCreate.RecipientUsername == sender.UserName) return BadRequest("You can't send message to yourself");

            var recipient = await m_UserRepository.GetUserByNameAsync(messageToCreate.RecipientUsername);

            if(recipient == null) return NotFound();

            var message = new Message()
            {
                Sender = sender,
                SenderName = sender.UserName,
                Recipient = recipient,
                RecipientName = recipient.UserName,
                Content = messageToCreate.Content
            };

            m_MessageRepository.AddMessage(message);

            if(await m_MessageRepository.SaveAllAsync()) return Ok(m_Mapper.Map<MessageDTO>(message));

            return BadRequest("Failed to send message");

        }

        [HttpGet]
        [Route("api/getmessages")]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessagesForUser(MessageParams messageParams)
        {
            messageParams.Username = User.GetUsername();

            var messages = await m_MessageRepository.GetMessagesForUser(messageParams);

            Response.AddPaginationHeader(messages.CurrentPage, messages.PageSize, messages.TotalCount, messages.TotalPage);

            return Ok(messages);
        }

    }
}