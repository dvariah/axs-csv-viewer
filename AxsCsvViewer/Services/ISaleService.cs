using AxsCsvViewer.Models;

namespace AxsCsvViewer.Services
{
    public interface ISaleService
    {
        Task<List<string>> GetAllUniqueTansactionsId();
        Task<List<Sale>> GetSalesByTansactionId(string transactionId);
    }
}
