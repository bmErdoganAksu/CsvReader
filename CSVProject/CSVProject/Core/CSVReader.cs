using CsvHelper;
using CsvHelper.Configuration;
using CSVProject.Models;
using System.Globalization;

namespace CSVProject.Core;

public class CSVReader
{
    public List<IssueModel> ReadFromCSV(string path, string delimiter = ",")
    {

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            NewLine = Environment.NewLine,
            Delimiter = delimiter,
            HasHeaderRecord = false
            
        };
        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, config))
        {
            var records = csv.GetRecords<IssueModel>();
            return records.ToList();
        }
 
    }
}
