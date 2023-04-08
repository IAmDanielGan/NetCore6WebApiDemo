using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet(Name = "Company")]
        public Company GetCompany()
        {
            return new() { ID = 1, Name = "Kingstar" };
        }

        [HttpPost(Name = "Company")]
        public int AddCompany()
        {
            return 1;
        }

        [HttpPut(Name = "Company")]
        public int UpdateCompany()
        {
            return 1;
        }

        [HttpDelete(Name = "Company")]
        public int DeleteCompany()
        {
            return 1;
        }

    }
}
