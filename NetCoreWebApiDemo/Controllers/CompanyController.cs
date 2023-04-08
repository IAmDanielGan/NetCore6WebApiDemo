using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApiDemo.Utility.Swagger;

namespace NetCoreWebApiDemo.Controllers
{
    /// <summary>
    /// Company Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false, GroupName = nameof(ApiVersions.V1))]
    public class CompanyController : ControllerBase
    {
        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public Company GetCompany()
        {
            return new() { ID = 1, Name = "Kingstar" };
        }

        /// <summary>
        /// Add new company information
        /// </summary>
        /// <returns></returns>
        [HttpPost()]
        public int AddCompany()
        {
            return 1;
        }

        /// <summary>
        /// update company Information
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public int UpdateCompany()
        {
            return 1;
        }

        /// <summary>
        /// delete information
        /// </summary>
        /// <returns></returns>
        [HttpDelete()]
        public int DeleteCompany()
        {
            return 1;
        }

    }
}
