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
        /// <summary>
        /// GetUser V2
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public User GetUser()
        {
            return new() { ID = 1, Name = "Daniel", Age = 25 };
        }

        /// <summary>
        /// AddUser V2
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public int AddUser()
        {
            return 1;
        }

        /// <summary>
        /// UpdateUser V2
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public int UpdateUser()
        {
            return 1;
        }

        /// <summary>
        /// DeleteUser V2
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public int DeleteUser()
        {
            return 1;
        }
    }
}
