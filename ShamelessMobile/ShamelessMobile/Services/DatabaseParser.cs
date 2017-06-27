using Newtonsoft.Json.Linq;
using ShamelessMobile.Models;
using ShamelessMobile.Resources;
using ShamelessMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShamelessMobile.Services
{
    public class DatabaseParser : IDatabaseParser
    {
        IStorageService _storageService = DependencyService.Get<IStorageService>();
        IWebService _webService = DependencyService.Get<IWebService>();

        public void DownloadDatabase(string outputFile)
        {
            _webService.DownloadFile(URLs.Json_Enc, Files.DBFileName);
        }

        public void DownloadSizes(string outputFile)
        {
            throw new NotImplementedException();
        }

        public string HumanReadableFileSize(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            var order = 0;
            double actualSize = size;

            while (actualSize >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                actualSize /= 1024;
            }

            return $"{actualSize:0.##} {sizes[order]}";
        }

        public Nintendo3DSTitle[] ParseFromDatabase(string databasePath, string sizesPath)
        {
            var database = _storageService.LoadTextFile(Files.DBFileName);
            var sizesDb = _storageService.LoadTextFile(Files.SizesFileName);

            Func<JToken, string> value = t => t.ToString();
            var titles = JArray.Parse(database);
            var sizes = JObject.Parse(sizesDb);

            var entries = new List<Nintendo3DSTitle>();

            foreach (var title in titles)
            {
                var titleId = value(title["titleID"]);
                var type = Nintendo3DSTitle.GetTitleType(value(titleId));
                var encKey = value(title["encTitleKey"]);
                if (string.IsNullOrWhiteSpace(encKey))
                {
                    continue;
                }

                var name = value(title["name"]).Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "Unknown";
                }

                var region = value(title["region"]);
                var serial = value(title["serial"]);
                long size = 0;

                if (sizes[titleId.ToUpper()] != null)
                {
                    size = sizes[titleId.ToUpper()].Value<long>();
                }

                var generated = new Nintendo3DSTitle(titleId, encKey, name, type, region, serial, size);
                entries.Add(generated);
            }

            return entries.ToArray();
        }
    }
}
