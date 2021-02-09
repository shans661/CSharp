using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBAccess.Features.ToDoLists;
using DBAccess.Entities;
using DBAccess.Models;

namespace ToDoList.API.Controllers
{
    
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private IToDoListCommandRepository m_ToDoListCommandRepository;
        private IToDoListQueryRepository m_ToDoListQueryRepository;

        public ToDoListController(IToDoListCommandRepository commandRepositoty, IToDoListQueryRepository queryRepository)
        {
            m_ToDoListCommandRepository = commandRepositoty;
            m_ToDoListQueryRepository = queryRepository;
        }

        [Route("api/additem")]
        [HttpPost]
        public async Task<ActionResult<bool>> StoreListItem(ToDoListEntity entity)
        {
            var response = await m_ToDoListCommandRepository.AddItem(entity);

            if(response)
            {
                return StatusCode(201);
            }
            return StatusCode(500);
        }

        [Route("api/updateitem")]
        [HttpPut]
        public async Task<ActionResult> UpdateListItem(ToDoListEntity entity)
        {
            var response = await m_ToDoListCommandRepository.AddItem(entity);

            if (response)
            {
                return StatusCode(201);
            }
            return StatusCode(500);
        }

        [Route("api/AllItems")]
        [HttpGet]
        public ActionResult<IList<NoteItem>> GetAllItems(int userId)
        {
            var response =  m_ToDoListQueryRepository.GetItems(userId);

            if(response != null)
            {
                return Ok(response);
            }

            return NoContent();
        }

        [Route("api/Item")]
        [HttpGet]
        public ActionResult<NoteItem> GetItem(int userId, int itemId)
        {
            var response = m_ToDoListQueryRepository.GetItem(userId, itemId);

            if(response != null)
            {
                return Ok(response);
            }

            return NoContent();
        }
    }
}