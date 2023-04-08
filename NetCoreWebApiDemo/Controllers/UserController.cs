using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi =false,GroupName =nameof(ApiVersions.V1))]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Get User
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public User GetUser()
        {
            return new() { ID = 1, Name = "Daniel", Age = 25 };
        }

        /// <summary>
        /// Add user
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public int AddUser()
        {
            return 1;
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public int UpdateUser()
        {
            return 1;
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public int DeleteUser() 
        {
            return 1;
        }
    }
}
