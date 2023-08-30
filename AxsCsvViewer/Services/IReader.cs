using AxsCsvViewer.Models;

namespace AxsCsvViewer.Services
{
    public interface IReader
    {
        IEnumerable<Sale> Read(string filePath);
    }
}
