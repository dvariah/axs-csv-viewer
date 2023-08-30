using AxsCsvViewer.Models;

namespace AxsCsvViewer.Services
{
    public class SaleService : ISaleService
    {
        public IReader _reader;

        public SaleService(IReader reader)
        {
            _reader = reader;
        }

        public async Task<List<string>> GetAllUniqueTansactionsId(string filePath)
        {
            var sales = _reader.Read("");
            var result = sales.Select(s => s.transaction_id).Distinct();
            return result.ToList();
        }

        public async Task<List<Sale>> GetSalesByTansactionId(string filePath, string transactionId)
        {
            var sales = _reader.Read("");
            var result = sales.Where(s => s.transaction_id == transactionId);
            return sales.ToList();
        }
    }
}
