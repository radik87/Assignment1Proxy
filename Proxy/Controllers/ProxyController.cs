using Microsoft.AspNetCore.Mvc;
using Proxy.Services;

namespace Proxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private readonly GetReplacedTextService _getReplacedTextService;
        public ProxyController(GetReplacedTextService getReplacedTextService)
        {
            _getReplacedTextService = getReplacedTextService;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            return await _getReplacedTextService.GetResponseFromUrl("https://localhost:7112/api/Service");
        }
    }
}
