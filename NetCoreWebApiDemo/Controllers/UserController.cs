using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet(Name="User")]
        public User GetUser()
        {
            return new() { ID = 1, Name = "Daniel", Age = 25 };
        }

        [HttpPost(Name ="User")]
        public int AddUser()
        {
            return 1;
        }

        [HttpPut(Name ="User")]
        public int UpdateUser()
        {
            return 1;
        }

        [HttpDelete(Name ="User")]
        public int DeleteUser() 
        {
            return 1;
        }
    }
}
