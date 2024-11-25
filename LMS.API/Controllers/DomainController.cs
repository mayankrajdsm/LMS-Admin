using LMS.API.ResponseHandler;
using LMS.Mapper.ConversionHelper;
using LMS.Mapper.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainController : ControllerBase
    {
        private readonly IDomainService _domainService;
        public DomainController(IDomainService domainService)
        {
            _domainService = domainService;
        }
        [HttpPost]
        [Route("create")]
        public async Task<APIResponse> InsertDomain(Mapper.BusinessObject.Domain domain)
        {
            var domains = await _domainService.InsertDomain(domain);
            if (domains > 0)
                return new APIResponse((int)HttpStatusCode.OK, "Domain created successfully.", domain);
            else
                return new APIResponse((int)HttpStatusCode.BadRequest, "Domain not deleted.", domain);
        }
        [HttpPatch]
        [Route("edit")]
        public async Task<APIResponse> UpdateDomain(Mapper.BusinessObject.Domain domain)
        {
            var domains = await _domainService.UpdateDomain(domain);
            if (domains > 0)
                return new APIResponse((int)HttpStatusCode.OK, "Domain created successfully.", domain);
            else
                return new APIResponse((int)HttpStatusCode.BadRequest, "Domain not deleted.", domain);
        }
        [HttpGet]
        [Route("list")]
        public async Task<APIResponse> GetDomains()
        {
            var domains = await _domainService.GetDomains();
            if (domains.Any())
                return new APIResponse((int)HttpStatusCode.OK, "Domain list successfully.", domains);
            else
                return new APIResponse((int)HttpStatusCode.OK, "No Record Found.");
        }
        [HttpGet]
        [Route("details")]
        public async Task<APIResponse> GetDomain(string id)
        {
            var domains = await _domainService.GetDomainsById(id);
            if (domains != null)
                return new APIResponse((int)HttpStatusCode.OK, "Domain Found.", domains);
            else
                return new APIResponse((int)HttpStatusCode.OK, "No Record Found.");
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<APIResponse> DeleteDomain(string id)
        {
            var domains = await _domainService.DeleteDomain(id);
            if (domains > 0)
                return new APIResponse((int)HttpStatusCode.OK, "Domain deleted successfully.", id);
            else
                return new APIResponse((int)HttpStatusCode.BadRequest, "Domain not deleted.", id);
        }
    }
}
