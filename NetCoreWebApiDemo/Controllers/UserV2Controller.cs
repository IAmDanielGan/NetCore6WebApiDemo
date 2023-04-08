using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    /// <summary>
    /// A new version about UserController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false, GroupName = nameof(ApiVersions.V2))]
    public class UserV2Controller : ControllerBase
    {
        [HttpGet()]
        public User GetUser()
        {
            return new() { ID = 1, Name = "Daniel", Age = 25 };
        }

        [HttpPost()]
        public int AddUser()
        {
            return 1;
        }

        [HttpPut()]
        public int UpdateUser()
        {
            return 1;
        }

        [HttpDelete()]
        public int DeleteUser()
        {
            return 1;
        }
    }
}
