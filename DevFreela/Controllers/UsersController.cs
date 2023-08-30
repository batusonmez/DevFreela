using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Controllers
{


    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([Frombody] CreateUserModel createUserModel)
    }
}
