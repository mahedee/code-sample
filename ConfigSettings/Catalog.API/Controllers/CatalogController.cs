using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private CatalogSettings _settings;

        public CatalogController(IOptions<CatalogSettings> settings)
        {
            _settings = settings.Value;
        }
        // GET: api/<CatalogController>
        [HttpGet]
        public CatalogSettings Get()
        {
            return _settings;
        }
    }
}
