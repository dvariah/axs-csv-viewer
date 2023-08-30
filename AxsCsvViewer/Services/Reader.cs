using AxsCsvViewer.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace AxsCsvViewer.Services
{

    public class Reader : IReader
    {
        public IEnumerable<Sale> Read(string filePath)
        {
            using var streamreader = new StreamReader(filePath);

            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = false,
            };

            using var csvReader = new CsvReader(streamreader, csvConfig);
            var sales = csvReader.GetRecords<Sale>();
            return sales.ToList();
        }
    }
}
