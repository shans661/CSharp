using DBWrapper;
using DBWrapper.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        internal readonly DataBaseContext m_Context;

        public UserController(ILogger<UserController> logger, DataBaseContext context)
        {
            _logger = logger;
            m_Context = context;
        }

        [Route("api/users")]
        public IEnumerable<User> Get()
        {
            return new List<User>()
            {
                new User()
                {
                    UserName = "Shiva",
                    Id = 1
                },
                new User()
                {
                    Id = 2,
                    UserName = "Shankara"
                }
            };
        }
    }
}
