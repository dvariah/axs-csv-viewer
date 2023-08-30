using AxsCsvViewer.Services;
using Microsoft.AspNetCore.Mvc;

namespace AxsCsvViewer.Controllers
{
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
        public async Task<IActionResult> GetAllUniqueTansaction()
        {
            var result = await _saleService.GetAllUniqueTansactionsId();

            return Ok(result);
        }

        /// <summary>
        /// Returns a collection of sales associated with transaction id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetByTansactionId()
        {
            var result = await _saleService.GetSalesByTansactionId();

            return Ok(result);
        }
    }
}
