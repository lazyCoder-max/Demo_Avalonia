using Demo.Catalog.MVVM.Merchandise.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.Services
{
    public class CsvHelperControl
    {
        public List<ItemModel> GetAllData()
        {
            List<ItemModel> datas = new List<ItemModel>();
            if (File.Exists($"{Directory.GetCurrentDirectory()}/itemData.csv"))
            {
                using (var streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}/itemData.csv"))
                {
                    using (var csvReader = new CsvHelper.CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<ItemModelClassMap>();
                        var records = csvReader.GetRecords<ItemModel>();
                        datas.AddRange(records);
                        return datas;
                    }
                }
            }
            else
                throw new FileNotFoundException("CSV File Not Found");
        }
        public void SaveCsvFile(List<ItemModel> itemModels)
        {
            using (var streamWriter = new StreamWriter($"{Directory.GetCurrentDirectory()}/itemData.csv"))
            {
                using (var csvWriter = new CsvHelper.CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<ItemModel>();
                    csvWriter.NextRecord();
                    foreach(var record in itemModels)
                    {
                        csvWriter.WriteRecord(record);
                        csvWriter.NextRecord();
                    }
                }
            }
        }

        public ItemSettingModel GetSetting()
        {
            ItemSettingModel datas = new ItemSettingModel();
            if (File.Exists($"{Directory.GetCurrentDirectory()}/settings.csv"))
            {
                using (var streamReader = new StreamReader($"{Directory.GetCurrentDirectory()}/settings.csv"))
                {
                    using (var csvReader = new CsvHelper.CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        csvReader.Context.RegisterClassMap<ItemSettingModelClassMap>();
                        var records = csvReader.GetRecords<ItemSettingModel>().FirstOrDefault();
                        datas = records;
                        return datas;
                    }
                }
            }
            else
                throw new FileNotFoundException("CSV File Not Found");
        }
        public void SaveSetting(ItemSettingModel itemModel)
        {
            using (var streamWriter = new StreamWriter($"{Directory.GetCurrentDirectory()}/settings.csv"))
            {
                using (var csvWriter = new CsvHelper.CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<ItemSettingModel>();
                    csvWriter.NextRecord();
                    csvWriter.WriteRecord(itemModel);
                    csvWriter.NextRecord();
                }
            }
        }
    }
}
