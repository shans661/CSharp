using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        internal readonly DataBaseContext m_Context;

        public UserController(ILogger<UserController> logger, DataBaseContext context)
        {
            _logger = logger;
            m_Context = context;
        }

        [HttpGet]
        [Route("api/users")]
        public IEnumerable<AppUser> Get()
        {
            var users =  m_Context.User.ToList();
            users = null;
            var user1 = users[0];
            return users;
        }

        [HttpGet]
        [Route("api/error")]
        public ActionResult Error()
        {
            return StatusCode(404);
        }
    }
}
