﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false, GroupName = nameof(ApiVersions.V1))]
    public class CompanyController : ControllerBase
    {
        [HttpGet()]
        public Company GetCompany()
        {
            return new() { ID = 1, Name = "Kingstar" };
        }

        [HttpPost()]
        public int AddCompany()
        {
            return 1;
        }

        [HttpPut()]
        public int UpdateCompany()
        {
            return 1;
        }

        [HttpDelete()]
        public int DeleteCompany()
        {
            return 1;
        }

    }
}
