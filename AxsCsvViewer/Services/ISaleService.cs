using AxsCsvViewer.Models;

namespace AxsCsvViewer.Services
{
    public interface ISaleService
    {
        Task<List<string>> GetAllUniqueTansactionsId(string filePath);
        Task<List<Sale>> GetSalesByTansactionId(string filePath, string transactionId);
    }
}
