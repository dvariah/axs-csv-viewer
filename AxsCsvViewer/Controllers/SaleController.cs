using AxsCsvViewer.Services;
using Microsoft.AspNetCore.Mvc;

namespace AxsCsvViewer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : Controller
    {
        ISaleService _saleService;

        public SaleController(ISaleService service)
        {
            _saleService = service;
        }

        /// <summary>
        /// Returns a collection of unique transaction ids from sales csv
        /// </summary>
        /// <param name="subscription"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUniqueTansaction([FromBody] string filePath)
        {
            var result = await _saleService.GetAllUniqueTansactionsId(filePath);

            return Ok(result);
        }

        /// <summary>
        /// Returns a collection of sales associated with transaction id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetByTansactionId([FromBody] string filePath, [FromBody] string transactionId)
        {
            var result = await _saleService.GetSalesByTansactionId(filePath, transactionId);

            return Ok(result);
        }
    }
}
