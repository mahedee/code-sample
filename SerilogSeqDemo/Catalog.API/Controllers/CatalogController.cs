using Catalog.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }
        //GET api/<CatalogController>/1/110
        [HttpGet("{catalogId}/{quantity}")]
        public string GetItem(int catalogId, int quantity)
        {
            try
            {
                CatalogItem item = GetItems(catalogId);

                if (item.AvailableStock < quantity)
                {
                    _logger.LogInformation("Stock quantity {0} is lower than requested quantity {1}", item.AvailableStock, quantity);
                    return "Stock quantity is lower than requested quantity.";
                }
            }
            catch(Exception exp)
            {
                var logMsg = new StringBuilder();
                logMsg.AppendLine($"Error message:{exp.Message}");
                logMsg.AppendLine($"Error stack trace:{exp.StackTrace}");
                _logger.LogError(logMsg.ToString());
            }
            return "Your order has been submitted";
        }


        private CatalogItem GetItems(int catalogId)
        {
            List<CatalogItem> catalogRepository = new List<CatalogItem>();
            catalogRepository.Add(new CatalogItem { Id = 1, Name = "Asus ZenBook", Price = 150000, AvailableStock = 25, RestockThreshold = 5 });
            catalogRepository.Add(new CatalogItem { Id = 2, Name = "Dell 4345", Price = 110000, AvailableStock = 25, RestockThreshold = 5 });
            catalogRepository.Add(new CatalogItem { Id = 3, Name = "Lenovo ThinkPad", Price = 180000, AvailableStock = 25, RestockThreshold = 5 });
            catalogRepository.Add(new CatalogItem { Id = 4, Name = "Microsoft Surface", Price = 250000, AvailableStock = 25, RestockThreshold = 5 });

            CatalogItem item = new CatalogItem();
            try
            {
                item = catalogRepository.Where(p => p.Id == catalogId).FirstOrDefault();
            }
            catch(Exception exp)
            {
                throw new Exception(exp.Message);
            }

            return item;
        }
    }
}
