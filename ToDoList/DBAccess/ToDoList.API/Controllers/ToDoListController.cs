using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBAccess.Features.ToDoLists;
using DBAccess.Entities;

namespace ToDoList.API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private IToDoListCommandRepository m_ToDoListCommandRepository;
        public ToDoListController(IToDoListCommandRepository commandRepositoty)
        {
            m_ToDoListCommandRepository = commandRepositoty;
        }

        [HttpPost("todolist")]
        public async Task<ActionResult<bool>> StoreToDoList(ToDoListEntity entity)
        {
            var response = await m_ToDoListCommandRepository.AddItem(entity);

            if(response)
            {
                return StatusCode(201);
            }
            return StatusCode(500);
        }
    }
}