using DBWrapper.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/user")]
        public IEnumerable<User> Get()
        {
            return new List<User>()
            {
                new User()
                {
                    Name = "Shiva",
                    Id = 1
                },
                new User()
                {
                    Id = 2,
                    Name = "Shankara"
                }
            };
        }
    }
}
