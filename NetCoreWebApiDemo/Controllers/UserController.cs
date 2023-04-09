using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    //[Route("api/[controller]/[action]")]    [action]  Knowledge point: against RESTFul the style
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
        /// Get Page User ByID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("{userId}/{pageSize}")]     //Result in URL userId=1, pageSize=2: https://localhost:7114/api/User/1/2    
        public int GetPageUserByID(int userId,int pageSize)
        {
            return 2;
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
