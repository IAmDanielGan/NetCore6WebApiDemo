﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi =false,GroupName =nameof(ApiVersions.V1))]
    public class UserController : ControllerBase
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
