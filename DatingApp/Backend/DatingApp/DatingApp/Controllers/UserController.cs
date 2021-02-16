using DBWrapper.Entities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DatingApp.API.Controllers
{

    public class UserController : BaseController
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

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
