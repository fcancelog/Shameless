using Newtonsoft.Json;
using ShamelessMobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShamelessMobile.Services
{
    public class TitleFilteringService : ITitleFilteringService
    {
        IStorageService _storageService = DependencyService.Get<IStorageService>();

        public TitleFilter ParseFilterSettings(string filterPath)
        {
            var json = _storageService.LoadTextFile(filterPath);
            var filter = JsonConvert.DeserializeObject<TitleFilter>(json);

            return filter;
        }

        public void WriteFilterSettings(TitleFilter filter, string filterPath)
        {
            var output = JsonConvert.SerializeObject(filter, Formatting.Indented);
            _storageService.SaveTextFile(filterPath, output);
        }
    }
}
